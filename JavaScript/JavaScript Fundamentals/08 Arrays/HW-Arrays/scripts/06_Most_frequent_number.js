// 06 Write a program that finds the most frequent number in an array. 
// Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

var numbers = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
var results = []; // I'm using the "results" object as a dictionary (key-value pair).
var maxCount = 0;
var maxNumber, i, index;

for (i = 0; i < numbers.length; i += 1) {
    // if results[numbers[i]] !== undefined (same as the line below).... i.e. if the element exists.
    if (results[numbers[i]]) {
        results[numbers[i]] += 1;
    }
    else {
        results[numbers[i]] = 1;
    }
}

for (index in results) {
    if (results[index] > maxCount) {
        maxCount = results[index];
        maxNumber = index;
    }
}

console.log('{' + numbers.join(', ') + '} -> ' + maxNumber + ' (' + maxCount + ' times)');