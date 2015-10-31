function solve(inputArray) {
    var commandFirstPart;
    var commandSecondPart;
    var functionProperties;
    var functionValue;
    var functions = {};

    for (var i = 0; i < inputArray.length; i += 1) {
        var firstRE = new RegExp(",", "g");
        inputArray[i] = inputArray[i].replace(firstRE, " , ");
        firstRE = new RegExp("\\[", "g");
        inputArray[i] = inputArray[i].replace(firstRE, "[ ");
        firstRE = new RegExp("\\]", "g");
        inputArray[i] = inputArray[i].replace(firstRE, " ]");
        for (var key in functions) {
            var re = new RegExp(" " + key + " ", "g");
            inputArray[i] = inputArray[i].replace(re, " " + functions[key] + " ");
        }
        commandFirstPart = inputArray[i].split('[')[0];
        commandSecondPart = inputArray[i].split('[')[1];

        functionProperties = getFunctionProperties(commandFirstPart);


        if (inputArray[i].indexOf('def ') !== -1) {
            functionValue = getFunctionValue(functionProperties, commandSecondPart);
            functions[functionProperties.funcName] = functionValue;
        }
        if (i === inputArray.length - 1) {
            return getFunctionValue(functionProperties, commandSecondPart);
        }
    }

    function getFunctionProperties(functionString) {
        var splittedFunctionString = functionString.split(' ');
        var properties = {
            funcName: '',
            funcOperation: 'none'
        };

        for (var i = 0; i < splittedFunctionString.length; i++) {
            if (splittedFunctionString[i] === 'sum' ||
                splittedFunctionString[i] === 'avg' ||
                splittedFunctionString[i] === 'min' ||
                splittedFunctionString[i] === 'max') {
                properties.funcOperation = splittedFunctionString[i];
            }
            if (splittedFunctionString[i] !== 'def' &&
                splittedFunctionString[i] !== properties.funcOperation &&
                splittedFunctionString[i].length > 0) {
                properties.funcName = splittedFunctionString[i];
            }
        }

        return properties;
    }

    function getFunctionValue(funcProperties, values) {
        var newString;
        newString = values.split(']');
        if (funcProperties.funcOperation === 'none') {
            return newString[0].trim();
        }
        else {
            var result = (funcProperties.funcOperation === 'min') ? Number.MAX_VALUE : 0;
            var count = 0;
            var splittedString = newString[0].split(',');
            var number;

            for (var i = 0; i < splittedString.length; i++) {
                var numberAsString = splittedString[i].trim();
                if (!isNaN(numberAsString) && numberAsString.length > 0) {
                    number = parseInt(numberAsString);
                    if (funcProperties.funcOperation === 'sum' ||
                        funcProperties.funcOperation === 'avg') {
                        result += number;
                        count++;
                    }
                    else if (funcProperties.funcOperation === 'max') {
                        if (number > result) {
                            result = number;
                        }
                    }
                    else if (funcProperties.funcOperation === 'min') {
                        if (number < result) {
                            result = number;
                        }
                    }
                }
            }

            if (funcProperties.funcOperation === 'avg') {
                return parseInt(result / count);
            }

            return result;
        }
    }
}

var zeroTestArr = [
    'def func sum[5, 3, 7, 2, 6, 3]',
    'def func2 [5, 3, 7, 2, 6, 3]',
    'def func3 min[func2]',
    'def func4 max[5, 3, 7, 2, 6, 3]',
    'def func5 avg[5, 3, 7, 2, 6, 3]',
    'def func6 sum[func2, func3, func4 ]',
    'sum[func6, func4]'
];

var testArr1 = ['def definition[-100, -100, -100]',
                'def definitionResult sum[definition]',
                'def defTest sum[definitionResult, 6457457, 2345234, -234546]',
                'avg[defTest, 1, 2, 3]'];

console.log(solve(testArr1));