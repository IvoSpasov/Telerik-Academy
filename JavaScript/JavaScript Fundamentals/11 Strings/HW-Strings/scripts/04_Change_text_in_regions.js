// You are given a text. Write a function that changes the text in all regions:
// <upcase>text</upcase> to uppercase.
// <lowcase>text</lowcase> to lowercase
// <mixcase>text</mixcase> to mix casing(random)

if (!String.prototype.toMixCase) {
    String.prototype.toMixCase = function () {
        'use strict';
        var result = '',
            i;
        for (i = 0; i < this.length; i += 1) {
            if (Math.random() < 0.5) {
                result += this[i].toLowerCase();
            } else {
                result += this[i].toUpperCase();
            }
        }

        return result;
    }
}

function solve() {
    'use strict';
    var firstString,
        secondString;

    function textChange(text) {
        var closingTagStart = text.indexOf('</'),
            closingTagEnd,
            openingTagStart,
            openingTagEnd,
            tagName,
            substring,
            substringWithTags;

        while (closingTagStart !== -1) {
            closingTagStart = text.indexOf('</');
            closingTagEnd = text.indexOf('>', closingTagStart);
            openingTagStart = text.lastIndexOf('<', closingTagStart - 1);
            openingTagEnd = text.indexOf('>', openingTagStart);
            tagName = text.substring(openingTagStart + 1, openingTagEnd);
            substring = text.substring(openingTagEnd + 1, closingTagStart);
            substringWithTags = text.substring(openingTagStart, closingTagEnd + 1);

            switch (tagName) {
                case 'upcase':
                    substring = substring.toUpperCase().trim();
                    break;
                case 'lowcase':
                    substring = substring.toLowerCase().trim();
                    break;
                case 'mixcase':
                    substring = substring.toMixCase().trim();
                    break;
                default: // throw exception -> tagName not added. 
            }

            text = text.replace(substringWithTags, substring);
        }

        return text;
    }

    firstString = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. ' +
                  'We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';
    secondString = 'We <upcase> are <mixcase>living</mixcase> in a yellow submarine</upcase>. ' +
                   'We <mixcase>don\'t</mixcase> have <mixcase>anything</mixcase> else.';

    console.log(textChange(firstString));
    console.log(textChange(secondString));
}

solve();