// Sort 3 real values in descending order using nested if statements.

var a = 1;
var b = 3;
var c = 2;
var temp;

if (a < b) {
    temp = a;
    a = b;
    b = temp;
    if (a < c) {
        temp = a;
        a = c;
        c = temp;
    }
}
if (b < c) {
    temp = b;
    b = c;
    c = temp;
    if (a < b) {
        temp = a;
        a = b;
        b = temp;
    }
}

console.log(a);
console.log(b);
console.log(c);