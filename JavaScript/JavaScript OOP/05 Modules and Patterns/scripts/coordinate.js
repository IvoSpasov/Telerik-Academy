var Coordinate = (function () {
    "use strict";

    var TILE_DIMENSION = 10;

    function Coordinate(x, y) {
        this.x = x;
        this.y = y;
    }

    Coordinate.prototype.equal = function (other) {
        return this.x === other.x && this.y === other.y;
    };

    Coordinate.prototype.toString = function () {
        return this.x + "/" + this.x;
    };

    Coordinate.getRandomCoordinate = function () {
        var x = getRandomArbitrary(0, MyCanvas.width() / TILE_DIMENSION) * TILE_DIMENSION;
        var y = getRandomArbitrary(0, MyCanvas.height() / TILE_DIMENSION) * TILE_DIMENSION;
        return new Coordinate(x, y);
    };

    function getRandomArbitrary(min, max) {
        return parseInt(Math.random() * (max - min) + min);
    }

    return Coordinate;
})();