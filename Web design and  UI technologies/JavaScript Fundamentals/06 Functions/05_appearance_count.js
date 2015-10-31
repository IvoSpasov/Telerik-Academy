// Write a function that counts how many times given number appears in given array.
// Write a test function to check if the function is working correctly.

(function () {
    'use strict';
    function numberCount(numbers, searchedNumber) {
        var counter = 0,
            i,
            length;

        for (i = 0, length = numbers.length; i < length; i += 1) {
            if (numbers[i] === searchedNumber) {
                counter += 1;
            }
        }

        return counter;
    }

    function testNumberCount(searchedNumber) {
        var numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 1, 3, 4, 3, 2, 34, 43, 5, 67, 9, 3, 2, 4, 5, 63, 3, 2, 1];
        console.log('The array is:');
        console.log(numbers.join(', '));
        console.log('Number "' + searchedNumber + '" appears ' + numberCount(numbers, searchedNumber) + ' times.');
    }

    testNumberCount(3);
    testNumberCount(5);
})();