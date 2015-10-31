// Write a JavaScript function that finds how many times a substring is contained in a given text
// (perform case insensitive search).
// Example:
// The target sub-string is 'in'
// The text is as follows: We are living in an yellow submarine.
// We don't have anything else. Inside the submarine is very tight.
// So we are drinking all the day. We will move out of it in 5 days.

(function () {
    'use strict';
    function substringCount(text, substring) {
        var currentIndex,
            counter = 0;

        text = text.toLowerCase();
        currentIndex = text.indexOf(substring);
        while (currentIndex >= 0) {
            counter += 1;
            currentIndex = text.indexOf(substring, currentIndex + 1);
        }

        return counter;
    }

    var text = 'We are living in an yellow submarine. We don\'t have anything else.'
        + ' Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.',
        word = 'in';

    console.log('The word "' + word + '" is present ' + substringCount(text, word) + ' times.');
})();