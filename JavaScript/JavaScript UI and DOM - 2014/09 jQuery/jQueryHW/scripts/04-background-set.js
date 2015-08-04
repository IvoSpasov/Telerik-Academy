(function () {
    function onSetColorButtonClick() {
        var $firstColorField = $('input[type=color]'),
            $color = $firstColorField.val();

        $('body').css('background', $color);
    }

    var $colorBtn = $('#background-color');
    $colorBtn.on('click', onSetColorButtonClick);
}());