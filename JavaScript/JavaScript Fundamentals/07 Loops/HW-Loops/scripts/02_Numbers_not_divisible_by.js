// Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

var n = 105;

for (var i = 0; i < n; i++) {
    if (i % 21) { //  !==0
        console.log(i);
    }
}