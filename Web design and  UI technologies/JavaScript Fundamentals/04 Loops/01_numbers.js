// Write a script that prints all the numbers from 1 to N.

(function () {
    'use strict';

    function printAllNumbersFromOneToN(n) {
        var numbers = '',
            i;
        for (i = 1; i <= n; i += 1) {
            numbers += i;
            if (i !== n) {
                numbers += ', ';
            }
        }

        console.log(numbers);
    }

    printAllNumbersFromOneToN(10);
    printAllNumbersFromOneToN(100);
})();