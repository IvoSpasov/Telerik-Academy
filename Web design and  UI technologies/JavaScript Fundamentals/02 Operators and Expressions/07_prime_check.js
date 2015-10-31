// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

(function () {
    'use strict';
    function isPrime(number) {
        for (var i = 2; i <= Math.sqrt(number) ; i++) {
            if ((number % i) == 0) {
                return false;
            }
        }
        return true;
    }

    var firstNumber = 5,
        secondNumber = 37,
        thirdNumber = 99;
    console.log('Is the number ' + firstNumber + ' prime: ' + isPrime(firstNumber));
    console.log('Is the number ' + secondNumber + ' prime: ' + isPrime(secondNumber));
    console.log('Is the number ' + thirdNumber + ' prime: ' + isPrime(thirdNumber));
})();