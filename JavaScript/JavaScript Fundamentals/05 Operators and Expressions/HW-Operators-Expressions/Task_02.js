// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

var number = 35;

if (number % 7 === 0 && number % 5 === 0) {
    console.log('The number ' + number + ' is divisible by 5 and 7 in the same time.');
}
else {
    console.log('The number ' + number + ' is not divisible by 5 and 7 in the same time.');
}