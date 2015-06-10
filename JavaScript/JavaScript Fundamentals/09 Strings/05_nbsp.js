// Write a function that replaces non breaking white-spaces in a text with &nbsp;

(function () {
    'use strict';
    function replaceWhiteSpaces(text, replaceWith) {
        replaceWith = replaceWith || '&nbsp';
        return text.split(' ').join(replaceWith);
    }

    var text = 'Write a function that replaces non breaking white-spaces in a text with "&nbsp;".';
    console.log('Before -> ' + text);
    console.log('After  -> ' + replaceWhiteSpaces(text));
})();