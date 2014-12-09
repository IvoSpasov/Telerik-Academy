// 02 Write a JavaScript function to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

function solve() {
    'use strict';
    var firstWrong = '(a+b)/5-d)(',
        secondWrong = ')(a+b)(a+z',
        thirdWrong = '((a+b)/5-d',
        firstCorrect = '((a+b)/5-d)',
        secondCorrect = '(((a+b)*c)-(2+3))*17';

    function checkTheBrackets(expression) {
        var bracketCounter = 0,
            i;
        for (i = 0; i < expression.length; i++) {
            switch (expression[i]) {
                case '(': bracketCounter += 1; break;
                case ')': bracketCounter -= 1; break;
            }

            if (bracketCounter < 0) {
                return false;
            }
        }

        if (bracketCounter !== 0) {
            return false;
        }

        return true;
    }

    console.log('"' + firstWrong + '" -> ' + checkTheBrackets(firstWrong));
    console.log('"' + secondWrong + '" -> ' + checkTheBrackets(secondWrong));
    console.log('"' + thirdWrong + '" -> ' + checkTheBrackets(thirdWrong));
    console.log('"' + firstCorrect + '" -> ' + checkTheBrackets(firstCorrect));
    console.log('"' + secondCorrect + '" -> ' + checkTheBrackets(secondCorrect));
}

solve();