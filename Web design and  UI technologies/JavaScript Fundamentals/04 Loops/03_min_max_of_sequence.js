// Write a script that finds the max and min number from a sequence of numbers.

(function () {
    'use strict';
    function findMinOfSequence(sequence) {
        var minNumber = sequence[0],
            index;
        for (index in sequence) {
            if (minNumber > sequence[index]) {
                minNumber = sequence[index];
            }
        }

        return minNumber;
    }

    function findMaxOfSequence(sequence) {
        var maxNumber = sequence[0],
            index;
        for (index in sequence) {
            if (maxNumber < sequence[index]) {
                maxNumber = sequence[index];
            }
        }

        return maxNumber;
    }

    var testSequence = [1, 2, 50, 16, 35, 9, 512, 108, -25, 70, 123, 45];
    console.log('Min of sequence is: ' + findMinOfSequence(testSequence));
    console.log('Max of sequence is: ' + findMaxOfSequence(testSequence));
})();