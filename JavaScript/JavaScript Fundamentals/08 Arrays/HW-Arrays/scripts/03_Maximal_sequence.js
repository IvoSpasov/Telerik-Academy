// 03 Write a script that finds the maximal sequence of equal elements in an array.
// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

var numbers = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
var counter = 1, maxCounter = 1, startIndex;
var result = [];
var i;

for (i = 0; i < numbers.length - 1; i += 1) {
    if (numbers[i] === numbers[i + 1]) {
        counter += 1;
    }
    else {
        counter = 1;
    }
    if (counter > maxCounter) {
        maxCounter = counter;
        startIndex = i + 2 - counter;
    }
}

for (i = 0; i < maxCounter; i += 1) {
    result[i] = numbers[i + startIndex];
}

console.log('{' + numbers.join(', ') + '} -> {' + result.join(', ') + '}');