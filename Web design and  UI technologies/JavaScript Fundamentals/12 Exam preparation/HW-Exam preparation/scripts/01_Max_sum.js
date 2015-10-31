function solve(params) {
    'use strict';

    var numbers = params.slice(1);
    //numbers = numbers.map(function (item) {
    //    return parseInt(item);
    //});
    numbers = numbers.map(Number);
    var maxSum = -2000000;
    var sum;

    for (var i = 0; i < numbers.length; i += 1) {
        sum = 0;
        for (var j = i; j < numbers.length; j += 1) {
            sum += numbers[j];
            if (maxSum < sum) {
                maxSum = sum;
            }
        }
    }

    return maxSum;
}

var arr = ['8', '1', '6', '-9', '4', '4', '-2', '10', '-1'];

result = solve(arr);
console.log(result);