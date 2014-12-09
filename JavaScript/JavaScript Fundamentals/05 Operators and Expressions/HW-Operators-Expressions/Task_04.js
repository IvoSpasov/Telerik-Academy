// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.

var number = -1732.35423;
var absNumber = Math.abs(number);
var result = Math.floor((absNumber % 1000) / 100);

if (result === 7) {
    console.log('Yes, the third digit is 7.');
}
else {
    console.log('No, the third digit is not 7');
}