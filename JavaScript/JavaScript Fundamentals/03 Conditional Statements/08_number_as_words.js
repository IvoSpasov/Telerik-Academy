// Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.

(function () {
    'use strict';
    function singleDigitToWord(digit) {
        if (typeof digit !== "number") {
            return 'not a digit';
        }
        switch (digit) {
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
            default: return 'not a digit';
        }
    }

    function digitFormTenToNineteenToWord(digit) {
        if (typeof digit !== "number") {
            return 'not a digit';
        }
        switch (digit) {
            case 0: return 'ten';
            case 1: return 'eleven';
            case 2: return 'twelve';
            case 3: return 'thirteen';
            case 4: return 'fourteen';
            case 5: return 'fifteen';
            case 6: return 'sixteen';
            case 7: return 'seventeen';
            case 8: return 'eighteen';
            case 9: return 'nineteen';
            default: return 'not a digit';
        }
    }

    function tenthsToWord(digit) {
        if (typeof digit !== "number") {
            return 'not a digit';
        }
        switch (digit) {
            case 2: return 'twenty';
            case 3: return 'thirty';
            case 4: return 'forty';
            case 5: return 'fifty';
            case 6: return 'sixty';
            case 7: return 'seventy';
            case 8: return 'eighty';
            case 9: return 'ninety';
            default: return 'not a digit';
        }
    }

    function twoDigitNumberToWord(number) {
        var numberAsString = number.toString(),
            firstDigit = parseInt(numberAsString.charAt(0)),
            secondDigit = parseInt(numberAsString.charAt(1));

        if (firstDigit === 1) {
            return digitFormTenToNineteenToWord(secondDigit)
        }
        else {
            if (secondDigit !== 0) {
                return tenthsToWord(firstDigit) + ' ' + singleDigitToWord(secondDigit);
            }
            else {
                return tenthsToWord(firstDigit);
            }
        }
    }

    function threeDigitNumberToWord(number) {
        var numberAsString = number.toString(),
            firstDigit = parseInt(numberAsString.charAt(0)),
            secondDigit = parseInt(numberAsString.charAt(1)),
            thirdDigit = parseInt(numberAsString.charAt(2)),
            word;

        word = singleDigitToWord(firstDigit) + ' hundred';
        if(secondDigit !== 0) {
            word += ' and ';
            word += twoDigitNumberToWord(parseInt(numberAsString.charAt(1) + numberAsString.charAt(2)));
        }
        if (secondDigit === 0 && thirdDigit !== 0) {
            word += ' and ';
            word += singleDigitToWord(thirdDigit);
        }

        return word;
    }

    function numberToWord(number) {
        if (typeof number !== "number") {
            return 'not a number';
        }

        var numberAsString = number.toString();

        if (numberAsString.length === 1) {
            return singleDigitToWord(number);
        }
        if (numberAsString.length === 2) {
            return twoDigitNumberToWord(number);
        }
        if (numberAsString.length === 3) {
            return threeDigitNumberToWord(number);
        }
    }

    console.log('Result: ' + numberToWord(0));
    console.log('Result: ' + numberToWord(9));
    console.log('Result: ' + numberToWord(10));
    console.log('Result: ' + numberToWord(12));
    console.log('Result: ' + numberToWord(19));
    console.log('Result: ' + numberToWord(25));
    console.log('Result: ' + numberToWord(60));
    console.log('Result: ' + numberToWord(98));
    console.log('Result: ' + numberToWord(273));
    console.log('Result: ' + numberToWord(400));
    console.log('Result: ' + numberToWord(501));
    console.log('Result: ' + numberToWord(550));
    console.log('Result: ' + numberToWord(617));
    console.log('Result: ' + numberToWord(711));
    console.log('Result: ' + numberToWord(999));
})();