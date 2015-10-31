// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

(function () {
    'use strict';
    function checkThirdDigit(number, digit) {
        var absNumber = Math.abs(number),
            thirdDigit = Math.floor((absNumber % 1000) / 100);
        return thirdDigit === digit ? true : false;
    }

    var digit = 7,
        number = 1732,
        secondNumber = 1,
        thirdNumber = -52758.25,
        fourthNumber = 5432432;

    console.log(number + ' -> ' + checkThirdDigit(number, digit));
    console.log(secondNumber + ' -> ' + checkThirdDigit(secondNumber, digit));
    console.log(thirdNumber + ' -> ' + checkThirdDigit(thirdNumber, digit));
    console.log(fourthNumber + ' -> ' + checkThirdDigit(fourthNumber, digit));
})();