// Write an expression that calculates trapezoid's area by given sides a and b and height h.

(function () {
    'use strict';
    function calculateTrapezoidArea(trapezoid) {
        return (trapezoid.a + trapezoid.b) * trapezoid.h / 2;
    }

    var firstTrapezoid = {
        a: 5,
        b: 8,
        h: 3
    };

    console.log('The area of the trapezoid is: ' + calculateTrapezoidArea(firstTrapezoid));
})();