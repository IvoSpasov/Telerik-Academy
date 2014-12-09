// 07 Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

var numbers = [1, 3, 4, 6, 8, 9, 11, 15, 16, 17, 20, 21, 25];
var searchedNumber = 6;
var startIndex = 0;
var middleIndex;
var endIndex = numbers.length - 1;

while (true) {
    middleIndex = Math.floor((startIndex / 2) + (endIndex / 2));

    if (numbers[middleIndex] === searchedNumber) {
        console.log('The searched number "' + searchedNumber + '" is at index: ' + middleIndex);
        break;
    }
    else if (startIndex > endIndex) {
        console.log('The searched number "' + searchedNumber + '" is not found');
        break;
    }
    else if (numbers[middleIndex] > searchedNumber) {
        endIndex = middleIndex - 1;
    }
    else if (numbers[middleIndex] < searchedNumber) {
        startIndex = middleIndex + 1;
    }
}

