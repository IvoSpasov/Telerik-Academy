// Write a function that checks if the element at given position in given array of integers is
// bigger than its two neighbours (when such exist).

(function () {
    'use strict';
    var numbers;

    function biggerThanNeighbours(numbers, position) {
        if (numbers.length <= 1) {
            return ('There is only one element in the collection of numbers.');
        }
        else if (0 < position && position < numbers.length - 1) {
            if (numbers[position - 1] < numbers[position] &&
                    numbers[position] > numbers[position + 1]) {
                return ('The element at position ' + position + ' is bigger than its neighbours.');
            }
            else {
                return ('The element at position ' + position + ' is smaller than at least one of its neighbours.');
            }
        }
        else if (position === 0) {
            if (numbers[position] > numbers[position + 1]) {
                return ('The first element is bigger than the second one.');
            }
            else {
                return ('The first element is smaller than the second one.');
            }
        }
        else if (position === numbers.length - 1) {
            if (numbers[position - 1] < numbers[position]) {
                return ('The last element is bigger than the one before.');
            }
            else {
                return ('The last element is smaller than the one before.');
            }
        }

        return ('Position ' + position + ' is invalid.');
    }

    numbers = [1, 5, 3, 4, 7, 3, 7, 8, 2, 5, 6, 45];
    console.log('The collection of numbers is: ');
    console.log(numbers.join(', '));
    console.log(biggerThanNeighbours(numbers, 4));
    console.log(biggerThanNeighbours(numbers, 0));
    console.log(biggerThanNeighbours(numbers, 11));
    console.log(biggerThanNeighbours(numbers, 113));
    console.log(biggerThanNeighbours(numbers, 5));
})();