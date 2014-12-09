//01 Write a function that returns the last digit of given integer as an English word.
//   Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine"

function lastNumberAsWord(number) {
    var lastDigit = number % 10;

    switch (lastDigit) {
        case 0: console.log(number + ' -> zero'); break;
        case 1: console.log(number + ' -> one'); break;
        case 2: console.log(number + ' -> two'); break;
        case 3: console.log(number + ' -> three'); break;
        case 4: console.log(number + ' -> four'); break;
        case 5: console.log(number + ' -> five'); break;
        case 6: console.log(number + ' -> six'); break;
        case 7: console.log(number + ' -> seven'); break;
        case 8: console.log(number + ' -> eight'); break;
        case 9: console.log(number + ' -> nine'); break;
        default:
    }
}

lastNumberAsWord(512);
lastNumberAsWord(1024);
lastNumberAsWord(12309);