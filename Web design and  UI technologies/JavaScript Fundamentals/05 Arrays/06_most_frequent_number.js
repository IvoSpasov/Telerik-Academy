// Write a script that finds the most frequent number in an array.

(function () {
    'use strict';
    var numbers,
        res;

    function findMostFrequentElement(arrayOfElements) {
        var i,
            length,
            index,
            result = {
                maxCount: 0,
                mostFrequentElement: 0
            },
            elementsCount = [];

        for (i = 0, length = arrayOfElements.length; i < length; i += 1) {
            // if results[numbers[i]] !== undefined (same as the line below).... i.e. if the element exists.
            if (elementsCount[arrayOfElements[i]]) {
                elementsCount[arrayOfElements[i]] += 1;
            }
            else {
                elementsCount[arrayOfElements[i]] = 1;
            }
        }

        for (index in elementsCount) {
            if (elementsCount[index] > result.maxCount) {
                result.maxCount = elementsCount[index];
                result.mostFrequentElement = index;
            }
        }

        return result;
    }

    numbers = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
    res = findMostFrequentElement(numbers);
    console.log('{' + numbers.join(', ') + '} -> ' + res.mostFrequentElement + ' (' + res.maxCount + ' times)');
})();