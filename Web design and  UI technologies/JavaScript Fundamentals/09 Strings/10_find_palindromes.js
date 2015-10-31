// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

(function () {
    'use strict';
    function extractPalindromes(text) {
        var words,
            i,
            len,
            firstPart,
            secondPart,
            reversedSecondPart,
            currentWord,
            wordLength,
            palindromes = [];

        words = text.split(/[ ,.\-?]/g).filter(function (word) {
            return word;
        });

        for (i = 0, len = words.length; i < len; i += 1) {
            currentWord = words[i];
            wordLength = currentWord.length;
            firstPart = currentWord.substring(0, wordLength / 2).toLowerCase();
            if (wordLength % 2 !== 0 && wordLength > 1) {
                secondPart = currentWord.substring(wordLength / 2 + 1).toLowerCase();
            }
            else{
                secondPart = currentWord.substring(wordLength / 2).toLowerCase();
            }

            reversedSecondPart = secondPart.split('').reverse().join('');
            if (firstPart === reversedSecondPart) {
                palindromes.push(currentWord);
            }
        }

        return palindromes;
    }

    var text = 'ABBA was a Swedish pop group formed in Stockholm in 1972.' +
        'Isabelle Lamal was an American film actress. The Honda Civic is a line' +
        ' of subcompact and subsequently compact cars made and manufactured by Honda.' +
        'Back in the day, the four-rotor 13J engine would have been good for 9000 rpm and' +
        ' change, but we shift at 8500 to make sure we maximize our time between rebuilds';

    console.log('The palindromes in the text are: ');
    console.log(extractPalindromes(text));
})();