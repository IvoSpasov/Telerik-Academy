// Write a script that finds the biggest of three integers using nested if statements.

var a = 5;
var b = 33;
var c = 16;

if (a > b) {
    if (a > c) {
        console.log(a + ' is the biggest (a).');
    }
    else {
        console.log(c + ' is the biggest (c).');
    }
}
if (b > a) {
    if (b > c) {
        console.log(b + ' is the biggest (b).');
    }
    else {
        console.log(c + ' is the biggest (c).');
    }
}