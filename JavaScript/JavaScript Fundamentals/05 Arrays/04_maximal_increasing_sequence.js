// Write a script that finds the maximal increasing sequence in an array.

(function () {
    'use strict';
    var numbers;

    function findMaximalIncreasingSequence(arrayOfElements) {
        var i,
            length,
            startIndex,
            result = [],
            currentCounter = 1,
            maxCounter = 1;

        for (i = 0, length = arrayOfElements.length; i < length; i += 1) {
            if (arrayOfElements[i] + 1 === arrayOfElements[i + 1]) {
                currentCounter += 1;
            }
            else {
                currentCounter = 1;
            }
            if (currentCounter > maxCounter) {
                maxCounter = currentCounter;
                startIndex = i + 2 - currentCounter;
            }
        }

        for (i = 0; i < maxCounter; i += 1) {
            result[i] = arrayOfElements[i + startIndex];
        }

        return result;
    }

    numbers = [3, 2, 3, 4, 2, 2, 4];

    console.log('{' + numbers.join(', ') + '} -> {' + findMaximalIncreasingSequence(numbers).join(', ') + '}');
})();