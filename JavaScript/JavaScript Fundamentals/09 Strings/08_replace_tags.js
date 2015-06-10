// Write a JavaScript function that replaces in a HTML document given as string
// all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

(function () {
    'use strict';

    var htmlString,
        result;

    function linkTagReplace(html) {
        while (html.indexOf('<a href=') !== -1) {
            html = html.replace('<a href=', '[URL=').replace('">', ']');
            html = html.replace('</a>', '[/URL]');
        }

        return html;
    }

    htmlString = '<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. ' +
        'Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

    result = linkTagReplace(htmlString);
    console.log('Before -> ' + htmlString);
    console.log('After - > ' + result);
})();