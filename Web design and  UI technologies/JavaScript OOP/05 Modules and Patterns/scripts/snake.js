var Snake = function () {
    "use strict";

    var INITIAL_DIRECTION = "d";
    var TILE_DIMENSION = 10;

    var coordinates = generateSnakeCoordinates().slice();
    var direction = INITIAL_DIRECTION;
    var isKeyPressed = false;
    var isDead = false;
    var hasApple = false;

    function generateSnakeCoordinates() {
        var startPosX = 100;
        var startPosY = 60;
        var SNAKE_INITIAL_LENGHT = 8;
        var coords = [];

        for (var i = 0; i < SNAKE_INITIAL_LENGHT; i += 1) {
            coords.push(new Coordinate(startPosX, startPosY));
            startPosX += TILE_DIMENSION;
        }

        return coords;
    }

    function updateDirection(keyCode) {
    // it works with both the direction keys and W,A,S,D
        switch (keyCode) {
            case 37:
                if (direction !== "r") {
                    direction = "l";
                    isKeyPressed = true;
                }
                break;
            case 65:
                if (direction !== "r") {
                    direction = "l";
                    isKeyPressed = true;
                }
                break;
            case 38:
                if (direction !== "d") {
                    direction = "u";
                    isKeyPressed = true;
                }
                break;
            case 87:
                if (direction !== "d") {
                    direction = "u";
                    isKeyPressed = true;
                }
                break;
            case 39:
                if (direction !== "l") {
                    direction = "r";
                    isKeyPressed = true;
                }
                break;
            case 68:
                if (direction !== "l") {
                    direction = "r";
                    isKeyPressed = true;
                }
                break;
            case 40:
                if (direction !== "u") {
                    direction = "d";
                    isKeyPressed = true;
                }
                break;
            case 83:
                if (direction !== "u") {
                    direction = "d";
                    isKeyPressed = true;
                }
                break;

        }
        move();
    }

    function getCoordinates() {
        return coordinates;
    }

    function update() {
        if (isKeyPressed) {
            isKeyPressed = false;
        } else {
            move();
        }

        return isDead;
    }

    function move() {
        var currentPosition = coordinates[0];
        var newX, newY;

        if (direction === "d") {
            newX = currentPosition.x;
            newY = currentPosition.y + TILE_DIMENSION;
        } else if (direction === "u") {
            newX = currentPosition.x;
            newY = currentPosition.y - TILE_DIMENSION;
        } else if (direction === "l") {
            newX = currentPosition.x - TILE_DIMENSION;
            newY = currentPosition.y;
        } else if (direction === "r") {
            newX = currentPosition.x + TILE_DIMENSION;
            newY = currentPosition.y;
        }

        var newPosition = new Coordinate(newX, newY);
        checkCollision(newPosition);
        newPosition = checkForCanvasBorder(newPosition);
        coordinates.unshift(newPosition);


        if(hasApple){
            hasApple = false;
        }else{
            coordinates.pop();
        }
    }

    function checkCollision(position) {
        if (coordinates.contains(position))  {
            isDead = true;
        }
    }

    function checkForCanvasBorder(position) {
        if (position.x < 0) {
            position.x = MyCanvas.width() - 1;
        }
        else if (position.x > MyCanvas.width() - 1) {
            position.x = 0;
        }
        else if (position.y > MyCanvas.height() - 1) {
            position.y = 0;
        }
        else if (position.y < 0) {
            position.y = MyCanvas.height() - 1;
        }

        return position;
    }

    function eat(){
        hasApple = true;
    }

    return {
        updateDirection: updateDirection,
        isKeyPressed: isKeyPressed,
        getCoordinates: getCoordinates,
        update: update,
        eat: eat,
        tileDimension: TILE_DIMENSION
    };
}();