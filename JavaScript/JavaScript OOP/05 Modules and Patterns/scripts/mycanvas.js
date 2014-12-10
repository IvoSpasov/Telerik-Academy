var MyCanvas = function () {
    "use strict";

    var canvas = document.getElementById('drawing');
    var context = canvas.getContext('2d');

    function drawRectangle(topLeftX, topRightY, width, height, strokeColor, fillColor) {
        if (fillColor) {
            context.fillStyle = fillColor;
            context.fillRect(topLeftX, topRightY, width, height);
        }

        if (strokeColor) {
            context.strokeStyle = strokeColor;
            context.strokeRect(topLeftX, topRightY, width, height);
        }
    }

    function drawArc(x, y, r, strokeColor, fillColor, start, finish) {
        context.beginPath();
        context.arc(x, y, r, start, finish);

        if (fillColor) {
            context.fillStyle = fillColor;
            context.fill();
        }

        if (strokeColor) {
            context.strokeStyle = strokeColor;
            context.stroke();
        }
    }

    function drawText(x, y, text, fontSize, fontStyle, fillColor) {
        var font = fontSize.toString() + "px " + fontStyle;
        context.fillStyle = fillColor;
        context.font = font;
        context.fillText(text, x, y);
    }

    function getHeight() {
        return canvas.height;
    }

    function getWidth() {
        return canvas.width;
    }

    function clear(){
        context.clearRect(0, 0, canvas.width, canvas.height);
    }

    return {
        drawRectangle: drawRectangle,
        drawArc: drawArc,
        drawText: drawText,
        width: getWidth,
        height: getHeight,
        clear:clear
    }
}();