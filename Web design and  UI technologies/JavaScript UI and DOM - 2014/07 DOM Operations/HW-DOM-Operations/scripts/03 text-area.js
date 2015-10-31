(function () {
    var generateFontColorBtn,
        generateBackgroundColorBtn;

    function onSetFontColorButtonClick() {
        var fontColorFiled = document.getElementById('font-color'),
            fontColor = fontColorFiled.value,
            textFiled = document.getElementById('text-area');
        textFiled.style.color = fontColor;
    }

    function onSetBackgroundColorButtonClick() {
        var backgroundColorField = document.getElementById('background-color'),
            backgroundColor = backgroundColorField.value,
            textFiled = document.getElementById('text-area');
        textFiled.style.backgroundColor = backgroundColor;
    }

    generateFontColorBtn = document.getElementById('font-color-btn');
    generateFontColorBtn.addEventListener('click', onSetFontColorButtonClick);
    generateBackgroundColorBtn = document.getElementById('background-color-btn');
    generateBackgroundColorBtn.addEventListener('click', onSetBackgroundColorButtonClick);
}());
