(function () {
    'use strict';
    var canvas = document.getElementById('canvas-with-bike'),
        ctx = canvas.getContext('2d'),
        x, y;

    ctx.lineWidth = 2;
    ctx.strokeStyle = '337D8F';
    ctx.fillStyle = '90CAD7';

    //ctx.beginPath();
    ctx.arc(100, 200, 60, 0, 2 * Math.PI);
    ctx.fill();
    ctx.moveTo(100, 200);
    ctx.lineTo(200, 198);
    ctx.lineTo(200 + 100, 198 - 68);
    ctx.lineTo(200 - 30, 198 - 68);
    ctx.closePath();
    ctx.moveTo(200, 198);
    ctx.lineTo(200 - 40, 198 - 100);
    ctx.moveTo(200 - 65, 198 - 100);
    ctx.lineTo(200 - 15, 198 - 100);
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(330, 200, 60, 0, 2 * Math.PI);
    ctx.fill();
    ctx.moveTo(330, 200);
    ctx.lineTo(200 + 80, 198 - 120);
    ctx.lineTo(280 + 30, 78 - 30);
    ctx.moveTo(200 + 80, 198 - 120);
    ctx.lineTo(280 - 42, 78 + 10);
    ctx.moveTo(200, 198);
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(200, 198, 16, 0, 2 * Math.PI);

    // This is for the pedals
    // x = x0 + r * cos(theta)
    // y = y0 + r * sin(theta)
    // theta is in radians, x0 and y0 are the coordinates of the centre, r is the radius, 
    // and the angle is measured anticlockwise from the x-axis.

    x = 200 + 16 * Math.cos(45 * Math.PI / 180);
    y = 198 + 16 * Math.sin(45 * Math.PI / 180);

    ctx.moveTo(x, y);
    x = 200 + 32 * Math.cos(45 * Math.PI / 180);
    y = 198 + 32 * Math.sin(45 * Math.PI / 180);
    ctx.lineTo(x, y);

    x = 200 + 16 * Math.cos((45 + 180) * Math.PI / 180);
    y = 198 + 16 * Math.sin(45 + 180 * Math.PI / 180);
    ctx.moveTo(x + 1, y + 1);
    x = 200 + 32 * Math.cos((45 + 184) * Math.PI / 180);
    y = 198 + 32 * Math.sin((45 + 184) * Math.PI / 180); // hmm ? why 184 and not 180
    ctx.lineTo(x, y);

    ctx.stroke();
}());