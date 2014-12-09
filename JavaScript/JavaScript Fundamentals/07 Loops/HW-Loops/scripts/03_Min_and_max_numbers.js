// Write a script that finds the max and min number from a sequence of numbers

var numSequence = [1, 2, 50, 16, 35, 9, 108, -25, 70, 123, 45, 512];
var maxNumber = -Number.MAX_VALUE;
var minNumber = Number.MAX_VALUE;

for (var number in numSequence) {
    if (maxNumber < numSequence[number]) {
        maxNumber = numSequence[number];
    }
    if (minNumber > numSequence[number]) {
        minNumber = numSequence[number];
    }
}

console.log('Min number is: ' + minNumber);
console.log('Max number is: ' + maxNumber);