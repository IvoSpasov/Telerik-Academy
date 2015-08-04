/* globals $ */

/* 
 Create a function that takes an id or DOM element and an array of contents
 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */

module.exports = function () {
    return function (element, contents) {
        var fragment,
            div,
            divCopy;

        if (!element || !contents) {
            throw 'Any of the function params is missing.';
        }

        if (typeof element !== 'string' && !(element instanceof HTMLElement)) {
            throw 'The provided first parameter is neither string or existing DOM element.';
        }

        if (typeof element === 'string') {
            element = document.getElementById(element);

            if (!element) {
                throw 'The provided id does not select anything.';
            }
        }

        if (contents.some(function (item) {
                return typeof item !== 'string' && typeof item !== 'number';
            })) {
            throw 'Any of the contents is neither string nor number.';
        }

        element.innerHTML = '';

        fragment = document.createDocumentFragment();
        div = document.createElement('div');

        for (var i = 0; i < contents.length; i += 1) {
            divCopy = div.cloneNode(true);
            divCopy.innerHTML = contents[i];
            fragment.appendChild(divCopy);
        }

        element.appendChild(fragment);
    };
};