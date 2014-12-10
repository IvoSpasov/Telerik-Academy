var specialConsole = (function () {
    var self;

    function writeOnOneLine(firstArgument, secondArgument) {
        if (!secondArgument) {
            console.log(firstArgument);
        }
        else {
            var openingBracketIndex = firstArgument.indexOf('{');
            var closingBracketIndex = firstArgument.indexOf('}');
            var placeholderValue;
            var argument;
            var result = firstArgument.substring(0, openingBracketIndex);
            var lastIndex;           
            
            while (openingBracketIndex !== -1) {                
                placeholderValue = firstArgument.substring(openingBracketIndex + 1, closingBracketIndex);
                argument = arguments[parseInt(placeholderValue) + 1];
                if (argument) {
                    //throw error;                    
                    result += argument;
                }
                
                openingBracketIndex = firstArgument.indexOf('{', openingBracketIndex + 1);
                lastIndex = (openingBracketIndex === -1) ? firstArgument.length : openingBracketIndex;
                result += firstArgument.substring(closingBracketIndex + 1, lastIndex);
                closingBracketIndex = firstArgument.indexOf('}', closingBracketIndex + 1);                
            }
            // I can also check if there are placeholders with equal numbers but I'll leave it like that for now

            console.log(result);
        }
    }

    self = {
        writeLine: writeOnOneLine,
        writeError: writeOnOneLine,
        writeWarning: writeOnOneLine
    };

    return self;
}());

specialConsole.writeLine('Message: hello');
specialConsole.writeLine('My first name is {1} and my last is {0}.', 'Petrov', 'Georgi'); // notice that the different order of placeholders is working;
specialConsole.writeError('Error: {0}', 'Something happened');
specialConsole.writeWarning('Warning: {0}', 'A warning');
