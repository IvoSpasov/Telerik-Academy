/* globals $ */

/*
 Create a function that takes a selector and:
 * Finds all elements with class `button` or `content` within the provided element
 * Change the content of all `.button` elements with "hide"
 * When a `.button` is clicked:
 * Find the topmost `.content` element, that is before another `.button` and:
 * If the `.content` is visible:
 * Hide the `.content`
 * Change the content of the `.button` to "show"
 * If the `.content` is hidden:
 * Show the `.content`
 * Change the content of the `.button` to "hide"
 * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
 * Throws if:
 * The provided ID is not a **jQuery object** or a `string`

 */
function solve() {
    return function (selector) {
        var $element;

        if (typeof selector !== 'string') {
            throw 'Selector parameter is missing or it is not a string.';
        }

        $element = $(selector);

        if ($element.length <= 0) {
            throw 'The provided selector does not select anything.';
        }

        $element.children('.button').text('hide');
        $element.on('click', '.button', onButtonClick);

        function onButtonClick() {
            var $currentButton = $(this),
                $currentContent = $currentButton.nextAll('.content').first();

            if ($currentButton.text() === 'hide') {
                $currentButton.text('show');
                $currentContent.css('display', 'none');
            }
            else if ($currentButton.text() === 'show') {
                $currentButton.text('hide');
                $currentContent.css('display', '');
            }
        }
    };
}

module.exports = solve;