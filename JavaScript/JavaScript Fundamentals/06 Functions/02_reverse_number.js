// Write a function that reverses the digits of given decimal number.

(function () {
    'use strict';
    function reverseDigits(number) {
        var numberAsString,
            reversedNumberAsString;

        if (typeof number !== 'number') {
            return 'NaN';
        }
        numberAsString = number.toString();
        reversedNumberAsString = numberAsString.split('').reverse().join('');
        return parseFloat(reversedNumberAsString);
    }

    console.log(reverseDigits(256));
    console.log(reverseDigits(123.45));
    console.log(reverseDigits('not a number'));
})();