// Write an expression that calculates rectangle’s area by given width and height.

(function () {
    'use strict';
    function calculateRectangleArea(widht, height) {
        return widht * height;
    }

    var width = 5,
        height = 2;
    console.log('The area of a rectangle with width ' +
        width + ' and height ' + height + ' is ' + calculateRectangleArea(width, height));
})();