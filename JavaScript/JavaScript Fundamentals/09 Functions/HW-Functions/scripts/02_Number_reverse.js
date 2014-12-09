// 02 Write a function that reverses the digits of given decimal number. Example: 256 -> 652

function numberReverse(number) {
    var numberAsString = number.toString();
    numberAsString = numberAsString.split('').reverse().join('');
    return parseFloat(numberAsString);
}

var number = 256;
console.log(number + ' -> ' + numberReverse(number));