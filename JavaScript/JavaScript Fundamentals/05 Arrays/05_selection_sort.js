// Sorting an array means to arrange its elements in increasing order.
// Write a script to sort an array.
// Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
// Hint: Use a second array

(function () {
    'use strict';
    var numbers;

    function selectionSort(arrayOfElements) {
        var i,
            j,
            length,
            elementHolder,
            indexOfSmallestElement;

        for (i = 0, length = arrayOfElements.length; i < length; i += 1) {
            elementHolder = arrayOfElements[i];

            for (j = i + 1; j < length; j += 1) {
                if (arrayOfElements[j] < elementHolder) {
                    elementHolder = arrayOfElements[j];
                    indexOfSmallestElement = j;
                }
            }

            arrayOfElements[indexOfSmallestElement] = arrayOfElements[i];
            arrayOfElements[i] = elementHolder;
        }
    }

    numbers = [5, 3, 1, 4, 6, 15, 1, 2, 4, -5, 0, -2026];

    selectionSort(numbers);
    console.log(numbers.join(', '));
})();