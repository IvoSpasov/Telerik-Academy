// Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

(function () {
    'use strict';
    function showMultiplicationSign(first, second, third) {
        var negativeNumberCounter = 0;

        if (first !== 0 && second !== 0 && third !== 0) {
            if (first < 0) {
                negativeNumberCounter++;
            }
            if (second < 0) {
                negativeNumberCounter++;
            }
            if (third < 0) {
                negativeNumberCounter++;
            }
            if (negativeNumberCounter % 2 === 0) {
                return ('+');
            }
            else {
                return ('-');
            }
        }
        else {
            return ('0');
        }
    }

    console.log('Result is: ' + showMultiplicationSign(5, 2, 2));
    console.log('Result is: ' + showMultiplicationSign(-2, -2, 1));
    console.log('Result is: ' + showMultiplicationSign(-2, 4, 3));
    console.log('Result is: ' + showMultiplicationSign(0, -2.5, 4));
    console.log('Result is: ' + showMultiplicationSign(-1, -0.5, -5.1));
})();