// 02 Write a script that compares two char arrays lexicographically (letter by letter).

var firstWord = 'academy';
var secondWord = 'Academy';
var firstCharArray = [];
var secondCharArray = [];
var wordLenght, areEqual, isFirstWordBeforeSecond;
var i;

function wordToArray(word, array) {
    word = word.toLowerCase();
    for (i = 0; i < word.length; i += 1) {
        array[i] = word[i];
    }
}

wordToArray(firstWord, firstCharArray);
wordToArray(secondWord, secondCharArray);

wordLenght = firstCharArray.length;

if (wordLenght > secondCharArray.length) {
    wordLenght = secondCharArray.length;
}

for (i = 0; i < wordLenght; i += 1) {
    if (firstCharArray[i] === secondCharArray[i] &&
            firstCharArray.length === secondCharArray.length) {
        areEqual = true;
    }
    else if (firstCharArray[i] <= secondCharArray[i] &&
            firstCharArray.length < secondCharArray.length) {
        areEqual = false;
        isFirstWordBeforeSecond = true;
        break;
    }
    else {
        areEqual = false;
        isFirstWordBeforeSecond = false;
        break;
    }
}

console.log(areEqual ? 'The words are equal.' : 'The words are not equal.');
if (!areEqual) {
    console.log(isFirstWordBeforeSecond ? '"' + firstWord + '" is lexicographically before "' + secondWord + '".' :
                                          '"' + secondWord + '" is lexicographically before "' + firstWord + '".');
}
