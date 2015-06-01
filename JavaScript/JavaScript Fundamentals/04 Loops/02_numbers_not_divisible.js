// Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

(function (){
    'use strict';

    function printAllNumbersNotDivisible(n) {
        var numbers = '',
            i,
            isDivisible;

        for (i = 1; i <= n; i += 1) {
            isDivisible = i % 21 === 0;
            if (!isDivisible) {
                numbers += i;
            }
            if (!isDivisible && i !== n) {
                numbers += ', ';
            }
        }

        console.log(numbers);
    }

    printAllNumbersNotDivisible(30);
    printAllNumbersNotDivisible(100);
})();