// Write a script that finds the greatest of given 5 variables.

var a = 6, b = 7, c = 8, d = 9, e = 5, temp;

if (a > b) {
    temp = a;
}
else {
    temp = b;
}
if (temp < c) {
    temp = c;
}
if (temp < d) {
    temp = d;
}
if (temp < e) {
    temp = e;
}

console.log('The greatest number is: ' + temp);