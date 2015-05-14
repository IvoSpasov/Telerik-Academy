// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

(function () {
    'use strict';
    function thirdBitValue(number) {
        var thirdBit = ((number & 8) === 0) ? 0 : 1;
        return 'The third bit of the number ' + number + ' is ' + thirdBit;
    }

    console.log(thirdBitValue(5));
    console.log(thirdBitValue(24));
    console.log(thirdBitValue(345));
    console.log(thirdBitValue(653));
    console.log(thirdBitValue(15664));
})();