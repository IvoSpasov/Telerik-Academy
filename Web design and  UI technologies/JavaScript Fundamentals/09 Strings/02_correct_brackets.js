// Write a JavaScript function to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
// Incorrect (a+b)/5-d)(

(function () {
    'use strict';
    function areBracketsPutCorrectly(expression) {
        var i,
            len,
            leftBracket = '(',
            rightBracket = ')',
            bracketsCounter = 0;

        for (i = 0, len = expression.length; i < len; i += 1) {
            if (expression[i] === leftBracket) {
                bracketsCounter += 1;
            }
            else if (expression[i] === rightBracket) {
                bracketsCounter -= 1;
            }
            if (bracketsCounter < 0) {
                return false;
            }
        }

        return true;
    }

    var correctExpression = '((a+b)/5-d)',
        incorrectExpression = ')(a+b))',
        incorrectExpression2 = '(a+b)/5-d)(';

    console.log('Is the expression ' + correctExpression + ' correct?: '
        + areBracketsPutCorrectly(correctExpression));
    console.log('Is the expression ' + incorrectExpression + ' correct?: '
        + areBracketsPutCorrectly(incorrectExpression));
    console.log('Is the expression ' + incorrectExpression2 + ' correct?: '
        + areBracketsPutCorrectly(incorrectExpression2));
})();