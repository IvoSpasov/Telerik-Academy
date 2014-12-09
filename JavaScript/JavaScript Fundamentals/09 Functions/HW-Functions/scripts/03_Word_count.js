// 03 Write a function that finds all the occurrences of word in a text.
// The search can case sensitive or case insensitive. Use function overloading.

function wordCount(text, word, isCaseSensitive) {
    var count = 0;
    var textAsArray = text.split(' ');

    function wordCountInsensitive() {
        var i;
        for (i = 0; i < textAsArray.length; i++) {
            if (textAsArray[i].toLowerCase() === word.toLowerCase()) {
                count += 1;
            }
        }

        return count;
    }

    function wordCountSensitive() {
        var i;
        for (i = 0; i < textAsArray.length; i++) {
            if (textAsArray[i] === word) {
                count += 1;
            }
        }

        return count;
    }

    switch (arguments.length) {
        case 2:
            return wordCountInsensitive();
        case 3:
            return isCaseSensitive ? wordCountSensitive() : wordCountInsensitive();
    }
}

var text = 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et ' +
    'dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ' +
    'Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint ' +
    'occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.';

console.log('In -> ' + wordCount(text, 'In') + ' (case insensitive)');
console.log('In -> ' + wordCount(text, 'In', false) + ' (case insensitive)');
console.log('In -> ' + wordCount(text, 'In', true) + ' (case sensitive)');