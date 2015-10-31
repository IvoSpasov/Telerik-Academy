// Write a script that compares two char arrays lexicographically (letter by letter).

(function () {
    'use strict';
    var firstComparison,
        secondComparison,
        firstWord = 'academy',
        secondWord = 'academy',
        thirdWord = 'Academy';

    function compareLetterByLetter(firstCharArray, secondCharArray) {
        var firstLength,
            secondLength,
            i;

        if (!Array.isArray(firstCharArray) || !Array.isArray(secondCharArray)) {
            return 'One or both of the parameters is not an array.';
        }

        firstLength = firstCharArray.length;
        secondLength = secondCharArray.length;
        if (firstLength !== secondLength) {
            return false;
        }

        for (i = 0; i < firstLength; i += 1) {
            if (firstCharArray[i] !== secondCharArray[i]) {
                return false;
            }
        }

        return true;
    }

    function wordToCharArray(word) {
        var wordAsArray = [],
            index;
        for (index in word) {
            wordAsArray[index] = word[index];
        }

        return wordAsArray;
    }

    firstComparison = compareLetterByLetter(wordToCharArray(firstWord), wordToCharArray(secondWord));
    secondComparison = compareLetterByLetter(wordToCharArray(firstWord), wordToCharArray(thirdWord));

    console.log('Is "' + firstWord + '" same as "' + secondWord + '": ' + firstComparison);
    console.log('Is "' + firstWord + '" same as "' + thirdWord + '": ' + secondComparison);
})();