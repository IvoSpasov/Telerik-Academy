// 01 Write a function that checks if the element at given position in given array
// of integers is bigger than its two neighbors (when such exist).

function biggerThanNeighbours(collectionOfNumbers, position) {
    var isBigger = false;
    if (collectionOfNumbers.length <= 1) {
        console.log('There is only one element in the collection of numbers.');
    }

    else if (0 < position && position < collectionOfNumbers.length - 1) {
        if (collectionOfNumbers[position - 1] < collectionOfNumbers[position] &&
                collectionOfNumbers[position] > collectionOfNumbers[position + 1]) {
            console.log('This element at position ' + position + ' is bigger than its neighbours.');
            isBigger = true;
        }
        else {
            console.log('This element at position ' + position + ' is smaller than at least one of its neighbours.');
        }
    }
    else if (position === 0) {
        if (collectionOfNumbers[position] > collectionOfNumbers[position + 1]) {
            console.log('The first element is bigger than the second one.');
        }
        else {
            console.log('The first element is smaller than the second one.');
        }
    }
    else if (position === collectionOfNumbers.length - 1) {
        if (collectionOfNumbers[position - 1] < collectionOfNumbers[position]) {
            console.log('The last element is bigger than the one before.');
        }
        else {
            console.log('The last element is smaller than the one before.');
        }
    }
    else {
        console.log('Invalid position.');
    }

    return isBigger;
}

var numbers = [1, 5, 3, 4, 7, 3, 7, 8, 2, 5, 6, 45];
var randomPosition = 4;
console.log('The collection of numbers is: ');
console.log(numbers.join(', '));
biggerThanNeighbours(numbers, randomPosition);