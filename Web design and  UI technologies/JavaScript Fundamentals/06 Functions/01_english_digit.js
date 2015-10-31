// Write a function that returns the last digit of given integer as an English word.

(function () {
    'use strict';
    function lastDigitToWord(number) {
        var lastDigit;
        if (typeof number !== 'number') {
            return 'NaN';
        }

        lastDigit = number % 10;

        switch (lastDigit) {
            case 0: return 'zero';
            case 1: return 'one';
            case 2: return 'two';
            case 3: return 'three';
            case 4: return 'four';
            case 5: return 'five';
            case 6: return 'six';
            case 7: return 'seven';
            case 8: return 'eight';
            case 9: return 'nine';
        }
    }

    console.log(lastDigitToWord('error'));
    console.log(lastDigitToWord(1));
    console.log(lastDigitToWord(512));
    console.log(lastDigitToWord(1024));
    console.log(lastDigitToWord(12309));
})();