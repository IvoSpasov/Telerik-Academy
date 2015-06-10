// Write a JavaScript function that reverses a string and returns it.

(function () {
    'use strict';
    function reverseString(text) {
        return text.split('').reverse().join('');
    }
    var word = 'sample';

    console.log(word + ' -> ' + reverseString(word));
})();