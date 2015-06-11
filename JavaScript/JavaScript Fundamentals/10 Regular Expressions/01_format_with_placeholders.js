// Write a function that formats a string. The function should have placeholders, as shown in the example
// Add the function to the String.prototype

(function () {
    'use strict';
    var firstText = 'Hello, there! Are you #{name}?',
        secondText = 'My name is #{name} and I am #{age}-years-old',
        thirdText = 'Exam: #{exam}',
        optionOne = {name: 'John'},
        optionTwo = {name: 'John', age: 13},
        optionThree = {exam: 'JavaScript fundamentals'};

    if (!String.prototype.format) {
        String.prototype.format = function (options) {
            var placeholders,
                placeholdersValues = [],
                result,
                i,
                len;

            placeholders = this.match(/#\{[A-z]+\}/g);
            placeholders.forEach(function (item) {
                placeholdersValues.push(item.match(/[A-z]+/g)[0]);
            });

            result = this;
            for (i = 0, len = placeholders.length; i < len; i += 1) {
                result = result.replace(placeholders[i], options[placeholdersValues[i]]);
            }

            return result;
        };
    }

    console.log(firstText.format(optionOne));
    console.log(secondText.format(optionTwo));
    console.log(thirdText.format(optionThree));
})();