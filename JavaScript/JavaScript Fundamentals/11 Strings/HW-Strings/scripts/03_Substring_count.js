// 03 Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

function solve() {
    'use strict';
    var text,
        word;

    function substringCount(string, substring) {
        string = string.toLowerCase();
        substring = substring.toLowerCase();
        var counter = 0,
            index = string.indexOf(substring);
        while (index !== -1) {
            counter += 1;
            index = string.indexOf(substring, index + substring.length);
        }

        return counter;
    }


    text = 'We are living in an yellow submarine. We don\'t have anything else. ' +
            'Inside the submarine is very tight. So we are drinking all the day. ' +
            'We will move out of it in 5 days.';
    word = 'in';

    console.log(word + ' -> ' + substringCount(text, word));
}

solve();