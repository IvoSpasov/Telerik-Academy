// Write a function that finds all the occurrences of word in a text.
// The search can be case sensitive or case insensitive.
// Use function overloading.

(function () {
    'use strict';
    var text;

    function wordCount(text, word, isCaseSensitive) {
        var wordsFromText,
            count = 0;

        text = text || [];
        wordsFromText = text.split(' ');

        function wordCountInsensitive() {
            var i,
                length;

            for (i = 0, length = wordsFromText.length; i < length; i += 1) {
                if (wordsFromText[i].toLowerCase() === word.toLowerCase()) {
                    count += 1;
                }
            }

            return count;
        }

        function wordCountSensitive() {
            var i,
                length;

            for (i = 0, length = wordsFromText.length; i < length; i += 1) {
                if (wordsFromText[i] === word) {
                    count += 1;
                }
            }

            return count;
        }

        switch (arguments.length) {
            case 2: return wordCountInsensitive();
            case 3: return isCaseSensitive ? wordCountSensitive() : wordCountInsensitive();
        }
    }

    text = 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et ' +
        'dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ' +
        'Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint ' +
        'occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.';

    console.log('In -> ' + wordCount(text, 'In') + ' times (case insensitive)');
    console.log('In -> ' + wordCount(text, 'In', false) + ' times (case insensitive)');
    console.log('In -> ' + wordCount(text, 'In', true) + ' times (case sensitive)');
})();