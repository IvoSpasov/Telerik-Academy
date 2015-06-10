// rite a function that extracts the content of a html page given as text.
// The function should return anything that is in a tag, without the tags.

(function () {
    'use strict';
    var htmlTest,
        result;

    function textExtraction(html) {
        var openingTagStartIndex,
            openingTagEndIndex,
            openingTag,
            closingTag;

        do {
            openingTagStartIndex = html.indexOf('<');
            openingTagEndIndex = html.indexOf('>');
            openingTag = html.slice(openingTagStartIndex, openingTagEndIndex + 1);
            closingTag = openingTag[0] + '/' + openingTag.substr(1, openingTag.length - 1);
            html = html.replace(openingTag, '');
            html = html.replace(closingTag, '');
        } while (openingTagStartIndex !== -1);

        return html;
    }

    htmlTest = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';
    result = textExtraction(htmlTest);
    console.log('Before -> ' + htmlTest);
    console.log('After  -> ' + result);
})();