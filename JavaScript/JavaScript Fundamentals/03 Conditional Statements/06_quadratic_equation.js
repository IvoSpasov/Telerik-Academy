// Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
// Calculates and prints its real roots.
// Note: Quadratic equations may have 0, 1 or 2 real roots.

(function () {
    'use strict';
    function findRoots(a, b, c) {
        var discriminant,
            x1,
            x2;

        discriminant = (b * b) - (4 * a * c);

        if (discriminant > 0) {
            x1 = (-b + Math.sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.sqrt(discriminant)) / (2 * a);

            return ('x1 = ' + x1 + ', x2 = ' + x2);
        }
        else if (discriminant === 0) {
            x1 = (-b) / (2 * a);
            return('x1 = x2 = ' + x1);
        }
        else {
            return('There are no real roots. There are two complex roots.');
        }
    }

    console.log('Result: ' + findRoots(2, 5, -3));
    console.log('Result: ' + findRoots(-1, 3, 0));
    console.log('Result: ' + findRoots(-0.5, 4, -8));
    console.log('Result: ' + findRoots(5, 2, 8));
})();