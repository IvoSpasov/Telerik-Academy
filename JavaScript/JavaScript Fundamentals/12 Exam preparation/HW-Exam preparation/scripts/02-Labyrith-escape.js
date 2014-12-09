//function solve(args) {
//    'use strict';

//    var fieldDimension = args[0].split(' ');
//    var totalRows = parseInt(fieldDimension[0]);
//    var totalCols = parseInt(fieldDimension[1]);
//    var startingPosition = args[1].split(' ');
//    var row = parseInt(startingPosition[0]);
//    var col = parseInt(startingPosition[1]);
//    var fieldWithLetters = args.slice(2);
//    var currentDirection;
//    var sum = 0;
//    var counter = 0;
//    var used = [];

//    while (0 <= row && row < totalRows && 0 <= col && col < totalCols) {
//        if (used[row * totalCols + col] === true) {
//            return 'lost ' + counter;
//        }

//        used[row * totalCols + col] = true;
//        currentDirection = fieldWithLetters[row][col];
//        sum += row * totalCols + col + 1;
//        counter++;

//        switch (currentDirection) {
//            case 'u': row -= 1; break;
//            case 'd': row += 1; break;
//            case 'l': col -= 1; break;
//            case 'r': col += 1; break;
//        }
//    }

//    return 'out ' + sum;
//}

function solve(args) {
    'use strict';

    var fieldDimension = args[0].split(' ');
    var totalRows = parseInt(fieldDimension[0]);
    var totalCols = parseInt(fieldDimension[1]);
    var startingPosition = args[1].split(' ');
    var row = parseInt(startingPosition[0]);
    var col = parseInt(startingPosition[1]);
    var fieldWithLetters = args.slice(2);
    var currentDirection;
    var sum = 0;
    var counter = 0;
    var used = [];
    var directions = {
        l: {
            row: 0,
            column: -1
        },
        r: {
            row: 0,
            column: +1
        },
        u: {
            row: -1,
            column: 0
        },
        d: {
            row: +1,
            column: 0
        }
    }

    while (0 <= row && row < totalRows && 0 <= col && col < totalCols) {
        if (used[row * totalCols + col] === true) {
            return 'lost ' + counter;
        }

        used[row * totalCols + col] = true;
        currentDirection = fieldWithLetters[row][col];
        sum += row * totalCols + col + 1;
        counter++;

        row += directions[currentDirection].row;
        col += directions[currentDirection].column;
    }

    return 'out ' + sum;
}

args = [
 "5 8",
 "0 0",
 "rrrrrrrd",
 "rludulrd",
 "durlddud",
 "urrrldud",
 "ulllllll"]

result = solve(args);

console.log(result);
