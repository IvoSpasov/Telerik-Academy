// 02 Write a function that removes all elements with a given value. 
// Attach it to the array type.
// Read about prototypeand how to attach methods.

if (!Array.prototype.remove) {
    Array.prototype.remove = function (number) {
        var i;
        for (i = 0; i < this.length; i++) {
            if (this[i] === number) {
                this.splice(i, 1);
            }
        }
    }
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
console.log('The array before removing "1" -> ' + arr.join(', '));
arr.remove(1);
console.log('The array after removing "1" -> ' + arr.join(', '));
