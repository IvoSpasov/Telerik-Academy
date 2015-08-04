function solve() {
    return function (selector) {
        var element,
            buttons;

        if (!selector) {
            throw 'Function parameter is missing.';
        }

        if (typeof selector !== 'string' && !(selector instanceof HTMLElement)) {
            throw 'The provided parameter is neither string or existing DOM element.';
        }

        if (typeof selector === 'string') {
            element = document.getElementById(selector);

            if (!element) {
                throw 'The provided id does not select anything.';
            }
        }
        else {
            element = selector;
        }

        buttons = element.querySelectorAll('.button');
        for (var i in buttons) {
            buttons[i].innerHTML = 'hide';
        }

        element.addEventListener('click', onButtonClick, false);

        function onButtonClick(event) {

            var currentButton = event.target;
            var currentContent = currentButton.nextSibling;

            if (!currentContent) {
                return;
            }

            while (currentContent.className !== 'content') {
                currentContent = currentContent.nextSibling;
                if (!currentContent) {
                    return;
                }
            }

            if (currentButton.innerHTML === 'hide') {
                currentButton.innerHTML = 'show';
                currentContent.style.display = 'none';
            }
            else if (currentButton.innerHTML === 'show') {
                currentButton.innerHTML = 'hide';
                currentContent.style.display = '';
            }
        }
    };
}

module.exports = solve;