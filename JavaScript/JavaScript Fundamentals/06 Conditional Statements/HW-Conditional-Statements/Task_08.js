// Write a script that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
//0 -> 'Zero'
//273 -> 'Two hundred seventy three'
//400 -> 'Four hundred'
//501 -> 'Five hundred and one'
//711 -> 'Seven hundred and eleven'

var number = 123;
var pronunciation;

number += ''; // converting to string

if (number.length === 1) {
    switch (number) {
        case '0': pronunciation = 'zero'; break;
        case '1': pronunciation = 'one'; break;
        case '2': pronunciation = 'two'; break;
        case '3': pronunciation = 'three'; break;
        case '4': pronunciation = 'four'; break;
        case '5': pronunciation = 'five'; break;
        case '6': pronunciation = 'six'; break;
        case '7': pronunciation = 'seven'; break;
        case '8': pronunciation = 'eight'; break;
        case '9': pronunciation = 'nine'; break;
        default:
    }
}

if (number.length === 2) {
    if (number.charAt(0) === '1') {
        switch (number.charAt(1)) {
            case '0': pronunciation = 'ten'; break;
            case '1': pronunciation = 'eleven'; break;
            case '2': pronunciation = 'twelve'; break;
            case '3': pronunciation = 'thirteen'; break;
            case '4': pronunciation = 'fourteen'; break;
            case '5': pronunciation = 'fifteen'; break;
            case '6': pronunciation = 'sixteen'; break;
            case '7': pronunciation = 'seventeen'; break;
            case '8': pronunciation = 'eighteen'; break;
            case '9': pronunciation = 'nineteen'; break;
            default:
        }
    }
    else {
        switch (number.charAt(0)) {
            case '2': pronunciation = 'twenty'; break;
            case '3': pronunciation = 'thirty'; break;
            case '4': pronunciation = 'fourty'; break;
            case '5': pronunciation = 'fifty'; break;
            case '6': pronunciation = 'sixty'; break;
            case '7': pronunciation = 'seventy'; break;
            case '8': pronunciation = 'eighty'; break;
            case '9': pronunciation = 'ninety'; break;
            default:
        }

        pronunciation += ' ';

        switch (number.charAt(1)) {
            case '1': pronunciation += 'one'; break;
            case '2': pronunciation += 'two'; break;
            case '3': pronunciation += 'three'; break;
            case '4': pronunciation += 'four'; break;
            case '5': pronunciation += 'five'; break;
            case '6': pronunciation += 'six'; break;
            case '7': pronunciation += 'seven'; break;
            case '8': pronunciation += 'eight'; break;
            case '9': pronunciation += 'nine'; break;
            default:
        }
    }
}

if (number.length === 3) {
    switch (number.charAt(0)) {
        case '1': pronunciation = 'one'; break;
        case '2': pronunciation = 'two'; break;
        case '3': pronunciation = 'three'; break;
        case '4': pronunciation = 'four'; break;
        case '5': pronunciation = 'five'; break;
        case '6': pronunciation = 'six'; break;
        case '7': pronunciation = 'seven'; break;
        case '8': pronunciation = 'eight'; break;
        case '9': pronunciation = 'nine'; break;
        default:
    }

    pronunciation += ' hundred';

    if (number.charAt(1) !== '0') {
        pronunciation += ' and ';
    }

    if (number.charAt(1) === '1') {
        switch (number.charAt(2)) {
            case '0': pronunciation += 'ten'; break;
            case '1': pronunciation += 'eleven'; break;
            case '2': pronunciation += 'twelve'; break;
            case '3': pronunciation += 'thirteen'; break;
            case '4': pronunciation += 'fourteen'; break;
            case '5': pronunciation += 'fifteen'; break;
            case '6': pronunciation += 'sixteen'; break;
            case '7': pronunciation += 'seventeen'; break;
            case '8': pronunciation += 'eighteen'; break;
            case '9': pronunciation += 'nineteen'; break;
            default:
        }
    }
    else {
        switch (number.charAt(1)) {
            case '2': pronunciation += 'twenty'; break;
            case '3': pronunciation += 'thirty'; break;
            case '4': pronunciation += 'fourty'; break;
            case '5': pronunciation += 'fifty'; break;
            case '6': pronunciation += 'sixty'; break;
            case '7': pronunciation += 'seventy'; break;
            case '8': pronunciation += 'eighty'; break;
            case '9': pronunciation += 'ninety'; break;
            default:
        }

        if (number.charAt(1) === '0' && number.charAt(2) !== '0') {
            pronunciation += ' and ';
        }
        else {
            pronunciation += ' ';
        }

        switch (number.charAt(2)) {
            case '1': pronunciation += 'one'; break;
            case '2': pronunciation += 'two'; break;
            case '3': pronunciation += 'three'; break;
            case '4': pronunciation += 'four'; break;
            case '5': pronunciation += 'five'; break;
            case '6': pronunciation += 'six'; break;
            case '7': pronunciation += 'seven'; break;
            case '8': pronunciation += 'eight'; break;
            case '9': pronunciation += 'nine'; break;
            default:
        }
    }
}

if (number.length > 3) {
    pronunciation = 'this number is bigger than 999';
}

console.log(number + ' = ' + pronunciation);