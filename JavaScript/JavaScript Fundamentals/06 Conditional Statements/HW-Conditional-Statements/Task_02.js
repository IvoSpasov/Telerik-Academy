// Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

var first = 5;
var second = -3;
var third = -4;
var counter = 0;

if (first !== 0 && second !== 0 && third !== 0) {
    if (first < 0) {
        counter++;
    }
    if (second < 0) {
        counter++;
    }
    if (third < 0) {
        counter++;
    }
    if (counter % 2 === 0) {
        console.log('The sign is plus.');
    }
    else {
        console.log('The sign is minus.');
    }
}
else {
    console.log('Atleast one of the numbers is 0.');
}