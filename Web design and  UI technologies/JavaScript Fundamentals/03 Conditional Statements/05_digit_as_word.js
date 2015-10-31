// Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
// Print “not a digit” in case of invalid input.
// Use a switch statement.

(function () {
    'use strict';
    function digitToWord(digit) {
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
            default : return 'not a digit';
        }
    }

    console.log('Result: ' + digitToWord(2));
    console.log('Result: ' + digitToWord(1));
    console.log('Result: ' + digitToWord(0));
    console.log('Result: ' + digitToWord(5));
    console.log('Result: ' + digitToWord(-0.1));
    console.log('Result: ' + digitToWord('hi'));
    console.log('Result: ' + digitToWord(9));
    console.log('Result: ' + digitToWord(10));
})();