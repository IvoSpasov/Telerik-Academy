// 06 Write a function that extracts the content of a html page given as text.
// The function should return anything that is in a tag, without the tags.

function solve() {
    'use strict';
    var htmlTest,
        result;

    function tagRemoval(html) {
        var indexOpen,
            indexClose,
            tag;

        do {
            indexOpen = html.indexOf('<');
            indexClose = html.indexOf('>');
            tag = html.slice(indexOpen, indexClose + 1);
            html = html.replace(tag, '');
            tag = tag[0] + '/' + tag.substr(1, tag.length - 1);
            html = html.replace(tag, '');
        } while (indexOpen !== -1);

        return html;
    }

    htmlTest = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';
    console.log('Before -> ' + htmlTest);
    result = tagRemoval(htmlTest);
    console.log('After  -> ' + result);
}

solve();