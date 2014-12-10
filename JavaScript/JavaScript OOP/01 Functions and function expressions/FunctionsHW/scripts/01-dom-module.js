var domModule = (function () {
    'use strict';
    var self,
        selectors = {},
        buffer = document.createDocumentFragment();

    function addElementToParent(parentElement, childElement) {
        // check for valid input
        document.querySelector(parentElement).appendChild(childElement);
        return self;
    }

    function removeElement(parentElement, childElement) {
        // check for valid input
        var parent = document.querySelector(parentElement),
            child = document.querySelector(childElement);
        parent.removeChild(child);
        return self;
    }

    function attachEvent(selector, eventType, eventHandler) {
        // check for valid input
        document.querySelector(selector).addEventListener(eventType, eventHandler);
        return self;
    }

    // this method is implemented using a hash table
    function bufferAppend(selector, childElement) {
        // check for valid input
        var BUFFER_SIZE = 4, // I've decided to use buffer size of four because it is easier to test, but it can always be changed to 100
            parentElement;
        if (!selectors[selector]) {
            selectors[selector] = buffer.cloneNode(true);
        }

        selectors[selector].appendChild(childElement);

        // here we check if the buffer is full
        if (selectors[selector].childNodes.length === BUFFER_SIZE) {
            parentElement = document.querySelector(selector);
            parentElement.appendChild(selectors[selector]);
            selectors[selector] = null; // clear the buffer (maybe there is a better way?)
        }

        return self;
    }

    self = {
        appendChild: addElementToParent,
        removeChild: removeElement,
        addHandler: attachEvent,
        appendToBuffer: bufferAppend,
        selectors: selectors
    };

    return self;
}());

var firstDiv = document.createElement('div');
var justDiv = document.createElement('div');
var navItem = document.createElement('li');
var i;
firstDiv.innerText = 'first appended div';

//appends div to #wrapper
domModule.appendChild('#wrapper', firstDiv);

//removes li:first-child from ul
domModule.removeChild('ul', 'li:first-child');

//add handler to each a element with class button
domModule.addHandler('a.button', 'click', function () {
    alert('Clicked');
});

for (i = 1; i <= 11; i += 1) {
    justDiv.innerText = 'just div (number =' + i + ')';
    domModule.appendToBuffer('#wrapper', justDiv.cloneNode(true));
}

domModule.appendToBuffer('#main-nav ul', navItem);
domModule.appendToBuffer('#main-nav ul', navItem);

console.log(domModule.selectors);