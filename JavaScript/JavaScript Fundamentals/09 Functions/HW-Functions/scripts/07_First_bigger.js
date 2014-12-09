// 07 Write a function that returns the index of the first element in array that is bigger than its
// neighbors, or -1, if there’s no such element. Use the function from the previous exercise.

function biggerThanNeighbours(collectionOfNumbers, position) {
    var isBigger = false;
    if (collectionOfNumbers[position - 1] < collectionOfNumbers[position] &&
            collectionOfNumbers[position] > collectionOfNumbers[position + 1]) {
        isBigger = true;
    }

    return isBigger;
}

function firstIndexOfBiggerElement(collectionOfNumbers) {
    var i;
    for (i = 1; i < collectionOfNumbers.length - 1; i += 1) {
        if (biggerThanNeighbours(collectionOfNumbers, i)) {
            return i;
        }
    }

    return -1;
}

var numbers = [1, 2, 3, 4, 555, 6, 7, 8, 2, 5, 6, 45];
var position = firstIndexOfBiggerElement(numbers);
console.log('The collection of numbers is: ');
console.log(numbers.join(', '));
console.log('The position of the first element bigger than its neighbours is: ' + position);