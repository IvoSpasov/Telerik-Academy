// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

(function () {
    'use strict';
    function divideWithoutReminder(number, divider) {
        return number % divider === 0 ? true : false;
    }
    function message(number, divider) {
        return 'Is the number ' + number + ' divisible to ' + divider + ' without reminder: ';
    }

    var div = 5 * 7,
        firstNumber = 175,
        secondNumber = 1453;
    console.log(message(firstNumber, div) + divideWithoutReminder(firstNumber, div));
    console.log(message(secondNumber, div) + divideWithoutReminder(secondNumber, div));
})();