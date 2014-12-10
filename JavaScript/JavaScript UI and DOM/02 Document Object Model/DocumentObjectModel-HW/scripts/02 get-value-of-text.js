// Create a function that gets the value of <input type="text"> ands prints its value to the console

var textFields = document.querySelectorAll('input[type=text]'),
    valuesOfTextFields = [],
    i, len,
    value;
for (i = 0, len = textFields.length; i < len; i += 1) {
    value = textFields[i].getAttribute('value');
    if (value !== null) {
        valuesOfTextFields.push(value);
    }
}

console.log(valuesOfTextFields);