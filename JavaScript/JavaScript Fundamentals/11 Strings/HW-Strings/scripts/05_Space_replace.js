// 05 Write a function that replaces non breaking white-spaces in a text with &nbsp;
// solved without regular expression

function solve() {
    'use strict';
    var text = 'Write a function that replaces non breaking white-spaces in a text with "&nbsp;".',
        result = text.split(' ').join('&nbsp;');
    console.log('Before -> ' + text);
    console.log('After  -> ' + result);
}

solve();