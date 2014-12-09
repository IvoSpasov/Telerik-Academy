// 04 Write a script that finds the maximal increasing sequence in an array. 
// Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

var numbers = [3, 2, 3, 4, 2, 2, 4];
var counter = 1;
var maxCounter = 1;
var startIndex;
var result = [];
var i;

for (i = 0; i < numbers.length - 1; i += 1) {
    if (numbers[i] + 1 === numbers[i + 1]) {
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