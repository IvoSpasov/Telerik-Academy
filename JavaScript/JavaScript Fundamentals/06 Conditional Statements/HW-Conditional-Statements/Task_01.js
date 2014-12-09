// Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

var bigger = 5;
var smaller = 13;
var temp;

if (bigger < smaller) {
    temp = bigger;
    bigger = smaller;
    smaller = temp;
}

console.log('Bigger: ' + bigger);
console.log('Smaller: ' + smaller);