// Write an expression that checks if given integer is odd or even.

(function () {
    'use strict';

    var firstNum = 15,
        secondNum = 14;

    console.log(oddOrEven(firstNum));
    console.log(oddOrEven(secondNum));

    function oddOrEven(number) {
        if (number % 2 === 0) {
            return 'the number ' + number + ' is even';
        }

        return 'the number ' + number + ' is odd';
    }
})();