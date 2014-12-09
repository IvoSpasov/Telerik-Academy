// 01 Write a JavaScript function that reverses a string and returns it. Example: "sample" -> "elpmas".

function solve() {
    'use strict';
    var string = 'sample',
        reversedString = string.split('').reverse().join('');
    console.log(string + ' -> ' + reversedString);
}

solve();