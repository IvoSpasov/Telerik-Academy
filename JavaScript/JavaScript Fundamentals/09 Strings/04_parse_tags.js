// You are given a text. Write a function that changes the text in all regions:
// <upcase>text</upcase> to uppercase.
// <lowcase>text</lowcase> to lowercase
// <mixcase>text</mixcase> to mix casing(random)
// Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>.
// We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.
// The expected result:
// We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.
// Note: Regions can be nested.

(function () {
    'use strict';
    if (!String.prototype.toMixCase) {
        String.prototype.toMixCase = function () {
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
        };
    }

    function parseTags(text) {
        var closingTagStartIndex = text.indexOf('</'),
            closingTagEndIndex,
            openingTagStartIndex,
            openingTagEndIndex,
            tagName,
            textInTag,
            textWithTags;

        while (closingTagStartIndex !== -1) {
            closingTagEndIndex = text.indexOf('>', closingTagStartIndex);
            openingTagStartIndex = text.lastIndexOf('<', closingTagStartIndex - 1);
            openingTagEndIndex = text.indexOf('>', openingTagStartIndex);
            tagName = text.substring(openingTagStartIndex + 1, openingTagEndIndex);
            textInTag = text.substring(openingTagEndIndex + 1, closingTagStartIndex);
            textWithTags = text.substring(openingTagStartIndex, closingTagEndIndex + 1);

            switch (tagName) {
                case 'upcase':
                    textInTag = textInTag.toUpperCase().trim();
                    break;
                case 'lowcase':
                    textInTag = textInTag.toLowerCase().trim();
                    break;
                case 'mixcase':
                    textInTag = textInTag.toMixCase().trim();
                    break;
                default: return 'tag name not defined';
            }

            text = text.replace(textWithTags, textInTag);
            closingTagStartIndex = text.indexOf('</');
        }

        return text;
    }

    var firstString = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. ' +
        'We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.',
        secondString = 'We <upcase> are <mixcase>living</mixcase> in a yellow submarine</upcase>. ' +
        'We <mixcase>don\'t</mixcase> have <mixcase>anything</mixcase> else.';

    console.log(parseTags(firstString));
    console.log(parseTags(secondString));
})();