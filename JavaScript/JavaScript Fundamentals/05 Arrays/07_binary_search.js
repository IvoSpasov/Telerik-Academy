// Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

(function () {
    'use strict';
    var numbers;

    function binarySearch(arrayOfIntegers, searchedNumber){
        var startIndex = 0,
            middleIndex,
            endIndex = arrayOfIntegers.length - 1;
        while (true) {
            middleIndex = Math.floor((startIndex / 2) + (endIndex / 2));

            if (arrayOfIntegers[middleIndex] === searchedNumber) {
                return ('The searched number "' + searchedNumber + '" is at index: ' + middleIndex);
            }
            else if (startIndex > endIndex) {
                return ('The searched number "' + searchedNumber + '" is not found');
            }
            else if (arrayOfIntegers[middleIndex] > searchedNumber) {
                endIndex = middleIndex - 1;
            }
            else if (arrayOfIntegers[middleIndex] < searchedNumber) {
                startIndex = middleIndex + 1;
            }
        }
    }

    numbers = [1, 3, 4, 6, 8, 9, 11, 15, 16, 17, 20, 21, 25];
    console.log(binarySearch(numbers, 6));
    console.log(binarySearch(numbers, 65634));
})();


