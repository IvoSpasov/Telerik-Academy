// 05 Sorting an array means to arrange its elements in increasing order. Write a script to sort an array. Use the "selection sort" algorithm:
// Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
// Hint: Use a second array

var numbers = [5, 3, 1, 4, 6, 15, 1, 2, 4, -5, 0, -2026];
var numberHolder, indexOfSmallestNumber;
var i, j;

for (i = 0; i < numbers.length; i += 1) {
    numberHolder = Number.MAX_VALUE;

    for (j = i; j < numbers.length; j += 1) {
        if (numbers[j] < numberHolder) {
            numberHolder = numbers[j];
            indexOfSmallestNumber = j;
        }
    }

    numbers[indexOfSmallestNumber] = numbers[i];
    numbers[i] = numberHolder;
}

console.log(numbers.join(', '));