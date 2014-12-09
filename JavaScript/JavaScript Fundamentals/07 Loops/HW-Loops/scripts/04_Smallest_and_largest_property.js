// Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects

var smallest = 'z';
var biggest = 'a';
var objects = [document, window, navigator];

for (var i = 0; i < objects.length; i++) {
    for (var prop in objects[i]) {
        if (prop.toLowerCase() < smallest) {
            smallest = prop;
        }
        if (prop.toLowerCase() > biggest) {
            biggest = prop;
        }
    }

    console.log('The lexicographically smallest property in ' + objects[i] + ' is: ' + smallest);
    console.log('The lexicographically biggest property in ' + objects[i] + ' is: ' + biggest);
    smallest = 'z';
    biggest = 'a';
}

//if ('xmlEncoding'.toLowerCase() < 'xmlVersion'.toLowerCase()) {
//    console.log(true);
//}