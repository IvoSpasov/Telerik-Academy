// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

var number = 15;

if (((number >> 3) & 1) === 1) {
    console.log('The third bit is 1');
}
else {
    console.log('The third bit is 0');
}