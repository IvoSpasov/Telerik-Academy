var Renderer = (function () {
    "use strict";

    var TILE_DIMENSION = Snake.tileDimension;
    var TILE_COLOR = '#4FFF1E';
    var TILE_BORDER_COLOR = '#000';

    function drawAll(score) {
        MyCanvas.clear();
        drawScore(score);
        drawSnake();
        drawApple();
    }

    function drawScore(score) {
        MyCanvas.drawText(20, 40, 'Your score - ' + score, 20, "Arial", "darkgreen");
    }

    function drawSnake() {
        var i, x, y;
        var coordinates = Snake.getCoordinates();

        for (i = 0; i < coordinates.length; i += 1) {
            x = coordinates[i].x;
            y = coordinates[i].y;

            MyCanvas.drawRectangle(x, y, TILE_DIMENSION, TILE_DIMENSION, TILE_BORDER_COLOR, TILE_COLOR);
        }
    }

    function drawApple() {
        MyCanvas.drawRectangle(Apple.getCoordinate().x, Apple.getCoordinate().y, TILE_DIMENSION, TILE_DIMENSION, TILE_BORDER_COLOR, TILE_COLOR);
    }

    return {
        drawAll: drawAll
    }
})();