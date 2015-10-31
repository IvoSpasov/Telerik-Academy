var Game = (function () {
    "use strict";

    var GAME_SPEED = 110;
    var player;
    var highScores = [];
    var isEnd = false;

    if (!Array.prototype.contains) {
        Array.prototype.contains = function (obj) {
            var i = this.length;

            while (i--) {
                if (this[i].equal(obj)) {
                    return true;
                }
            }

            return false;
        };
    }

    function init() {
        window.requestAnimFrame = (function () {
            return window.requestAnimationFrame ||
                window.webkitRequestAnimationFrame ||
                window.mozRequestAnimationFrame ||
                function (callback) {
                    window.setTimeout(callback, 1000 / 0);
                };
        })();

        document.addEventListener('keydown', function (event) {
            Snake.updateDirection(event.keyCode);
        });

        getScores();
        var name = prompt("Enter a name: ");
        player = new Player(name, 0);

        Renderer.drawAll(player.score);
        frame();
    }

    function frame() {
        if (isEnd) {
            logScore();
            return;
        }

        isEnd = Snake.update();

        checkApple();
        Renderer.drawAll(player.score);

        setTimeout(function () {
            requestAnimFrame(function () {
                frame();
            });
        }, GAME_SPEED);
    }

    function checkApple() {
        var currentPosition = Snake.getCoordinates()[0];
        if (currentPosition.equal(Apple.getCoordinate())) {
            Apple.setCoordinate(Coordinate.getRandomCoordinate());
            player.score += 1;
            Snake.eat();
        }
    }

    function logScore() {
        if (player.score !== 0) {
            highScores.push(player);
        }

        var highScoresLength = highScores.length;
        var i;

        for (i = 0; i < highScoresLength; i += 1) {
            for (var j = i + 1; j < highScoresLength; j += 1) {
                if (highScores[i].score < highScores[j].score) {
                    var oldValue = highScores[i];
                    highScores[i] = highScores[j];
                    highScores[j] = oldValue;
                }
            }
        }

        var text = "";

        for (i = 0; i < highScoresLength; i += 1) {
            if (i === 10) {
                break;
            }

            if (highScores[i] instanceof Player) {
                var name = highScores[i].name === null ? "Unknown" : highScores[i].name;
                var score = highScores[i].score.toString();
                text = text + name + "," + score + ",";
            }
        }

        localStorage["snakeScores"] = text;
    }

    function getScores() {
        var highScoresText = localStorage.snakeScores;

        if (highScoresText === undefined) {
            return;
        }

        var splitted = highScoresText.split(",");
        var length = splitted.length;
        var i, player;
        var stringForWeb = "<ol>";

        for (i = 0; i < length; i += 2) {
            var name = splitted[i];
            var playerScore = parseInt(splitted[i + 1]);

            if (name !== undefined && !isNaN(playerScore)) {
                player = new Player(name, playerScore);
                highScores.push(player);
                stringForWeb = stringForWeb + "<li>" + name + " " + playerScore + "</li>";
            }
        }

        stringForWeb = stringForWeb + "</ol>";
        document.getElementById("scores").innerHTML = stringForWeb;
    }

    return {
        init: init
    }


})();

window.onload = function () {
    Game.init();
};