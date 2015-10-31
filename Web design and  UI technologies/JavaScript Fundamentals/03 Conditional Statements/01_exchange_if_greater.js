// Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
// As a result print the values a and b, separated by a space.

(function () {
    'use strict';
    function exchangeIfGreater(first, second) {
        var previousValue;
        if (first > second) {
            previousValue = first;
            first = second;
            second = previousValue;
        }

        printOnConsole(first, second);
    }

    function printOnConsole(first, second) {
        console.log(first + ' ' + second);
    }

    exchangeIfGreater(5, 10);
    exchangeIfGreater(20, 1);
})();