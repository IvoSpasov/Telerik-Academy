// Crеate a function that gets the value of <input type="color"> and sets the background of the body to this value

function SetColor() {
    var firstColorField = document.querySelector('input[type=color]'),
        color = firstColorField.value;
    console.log(color);
    document.body.style.background = color
}
