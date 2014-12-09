// 05 Write a function that counts how many times given number appears in given array. 
// Write a test function to check if the function is working correctly.

function numberCount(collectionOfNumbers, number) {
    var counter = 0;
    var i;
    for (i = 0; i < collectionOfNumbers.length; i += 1) {
        if (collectionOfNumbers[i] === number) {
            counter += 1;
        }
    }

    return counter;
}

function test() {
    var numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 1, 3, 4, 3, 2, 34, 43, 5, 67, 9, 3, 2, 4, 5, 63, 3, 2, 1];
    var searchedNumber = 3;
    console.log('The array is:');
    console.log(numbers.join(', '));
    console.log('Number "' + searchedNumber + '" appears ' + numberCount(numbers, searchedNumber) + ' times.');
}

test();