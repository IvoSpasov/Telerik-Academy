// Write a script that selects all the div nodes that are directly inside other div elements
// Create a function using querySelectorAll()
// Create a function using getElementsByTagName()

var divsByQuery = document.querySelectorAll('div'),
    i, len;
console.log('These are all nested divs selected by "querySelectorAll".');
for (i = 0; i < divsByQuery.length; i+=1) {
    console.log('div ' + i + ' = ' + divsByQuery[i].innerHTML);
}

console.log('-'.repeat(100));

var divsByTagname = document.getElementsByTagName('div');
console.log('These are all nested divs selected by "getElementsByTagName".');
for (i = 0, len = divsByTagname.length; i < len; i+=1) {
    console.log('div ' + i + ' = ' + divsByTagname[i].innerHTML);
}
