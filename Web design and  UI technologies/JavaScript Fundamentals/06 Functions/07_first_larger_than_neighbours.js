// Write a function that returns the index of the first element in array that is larger than its neighbours or -1,
// if there’s no such element.
// Use the function from the previous exercise.

(function () {
    'use strict';
    var numbers;

    function isBiggerThanNeighbours(numbers, position) {
        if (numbers[position - 1] < numbers[position] &&
                numbers[position] > numbers[position + 1]) {
            return true;
        }

        return false;
    }

    function firstIndexOfBiggerElement(collectionOfNumbers) {
        var i,
            length;
        for (i = 1, length = collectionOfNumbers.length; i < length - 1; i += 1) {
            if (isBiggerThanNeighbours(collectionOfNumbers, i)) {
                return i;
            }
        }

        return -1;
    }

    numbers = [1, 2, 3, 4, 555, 6, 7, 8, 2, 5, 6, 45];
    console.log('The collection of numbers is: ');
    console.log(numbers.join(', '));
    console.log('The position of the first element bigger than its neighbours is: ' + firstIndexOfBiggerElement(numbers));
})();