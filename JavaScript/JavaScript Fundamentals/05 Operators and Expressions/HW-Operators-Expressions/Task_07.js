// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

var num = 29;

if (((num !== 1) && (num % 2 !== 0) && (num % 3 !== 0) && (num % 5 !== 0) && (num % 7 !== 0) && (num % 9 !== 0)) ||
                (num === 2 || num === 3 || num === 5 || num === 7)) {
    console.log('Number ' + num + ' is prime.');
}
else {
    console.log('Number ' + num + ' is not prime.');
}

//for (var i = 0; i <= 100; i++) {
//    if (((i !== 1) && (i % 2 !== 0) && (i % 3 !== 0) && (i % 5 !== 0) && (i % 7 !== 0) && (i % 9 !== 0))
//           || (i === 2 || i === 3 || i === 5 || i === 7)) {
//        console.log(i);
//    }
//}

function isPrime(number) {
    for (var i = 2; i <= Math.sqrt(number) ; i++) {
        if ((number % i) == 0) {
            return false;
        }
    }
    return true;
}