// 01 Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

var arrSize = 20;
var integers = [];
var i;

for (i = 0; i < arrSize; i += 1) {
    integers[i] = i * 5;
}

console.log(integers.join(', '));