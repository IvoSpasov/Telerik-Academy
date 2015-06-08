// Write a function that removes all elements with a given value.
// Attach it to the array type.
// Read about prototype and how to attach methods.

(function () {
    'use strict';
    var numbers;

    if (!Array.prototype.remove) {
        Array.prototype.remove = function (number) {
            var i,
                length;

            for (i = 0, length = this.length; i < length; i += 1) {
                if (this[i] === number) {
                    this.splice(i, 1);
                }
            }
        };
    }

    numbers = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
    console.log('The array before removing "1" -> ' + numbers.join(', '));
    numbers.remove(1);
    console.log('The array after removing "1" -> ' + numbers.join(', '));
})();