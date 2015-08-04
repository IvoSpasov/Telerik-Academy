(function () {
    var canvas = document.getElementById('canvas-with-house'),
        ctx = canvas.getContext('2d');

    ctx.lineWidth = 2;
    ctx.fillStyle = '#975B5B';

    // draw roof
    ctx.moveTo(300, 50);
    ctx.lineTo(100, 250);
    ctx.lineTo(500, 250);
    ctx.closePath();
    ctx.fill();
    ctx.stroke();

    // draw chimney
    ctx.beginPath();
    ctx.moveTo(500 - 75, 250 - 50);
    ctx.save();
    ctx.scale(1, 0.5);
    ctx.arc(425 - 20, 100 / 0.5, 20, 2 * Math.PI, 1 * Math.PI, true);    
    ctx.restore();
    ctx.lineTo(385, 200);    
    ctx.fill();
    ctx.stroke();

    ctx.beginPath();
    ctx.save();
    ctx.scale(1, 0.5);
    ctx.arc(425 - 20, 100 / 0.5, 20, 0, 2 * Math.PI);
    ctx.restore();

    // draw body
    ctx.moveTo(100, 250);
    ctx.lineTo(100, 250 + 300);
    ctx.lineTo(500, 550);
    ctx.lineTo(500, 250);

    ctx.fill();
    ctx.stroke();

    // draw the windows
    function drawPartOfWindow(x, y) {
        ctx.beginPath();
        ctx.fillStyle = '#000';
        ctx.moveTo(x, y);
        ctx.lineTo(x, y + 50);
        ctx.lineTo(x + 75, y + 50);
        ctx.lineTo(x + 75, y);
        ctx.closePath();
        ctx.fill();
    }

    function drawWindow(x, y) {
        drawPartOfWindow(x, y);
        drawPartOfWindow(x + 78, y);
        drawPartOfWindow(x, y + 53);
        drawPartOfWindow(x + 78, y + 53);
    }

    drawWindow(125, 280);
    drawWindow(500 - 25 - 153, 280);
    drawWindow(500 - 25 - 153, 280 + 130);

    // draw door
    ctx.beginPath();
    ctx.moveTo(140, 550);
    ctx.lineTo(140, 450);
    ctx.bezierCurveTo(200 - 45, 400, 200 + 45, 400, 140 + 120, 450);
    ctx.lineTo(140 + 120, 550);
    ctx.moveTo(140 + 60, 550);
    ctx.lineTo(200, 412);
    ctx.stroke();

    ctx.beginPath();
    ctx.arc(200 - 15, 500, 6, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(200 + 15, 500, 6, 0, 2 * Math.PI);
    ctx.stroke();

}());