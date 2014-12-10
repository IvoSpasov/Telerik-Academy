(function () {
    var canvas = document.getElementById('canvas-with-face'),
        ctx = canvas.getContext('2d');

    ctx.strokeStyle = '#22545F';
    ctx.lineWidth = 2;
    ctx.fillStyle = '#90CAD7';

    // draw face
    ctx.beginPath();
    ctx.save();
    ctx.scale(1, 0.9);
    ctx.arc(100, 130 * 1.5 / 0.9, 60, 0, 2 * Math.PI);
    ctx.restore();
    ctx.fill();
    ctx.stroke();

    // draw eyes
    ctx.beginPath();
    ctx.save();
    ctx.scale(1, 0.7);
    ctx.arc(100 - 40, (130 * 1.5 - 20) / 0.7, 10, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(100, (130 * 1.5 - 20) / 0.7, 10, 0, 2 * Math.PI);
    ctx.restore();
    ctx.stroke();

    ctx.fillStyle = '#22545F';
    ctx.beginPath();
    ctx.save();
    ctx.scale(0.5, 1);
    ctx.arc((100 - 43) / 0.5, 130 * 1.5 - 20, 5.5, 0, 2 * Math.PI);
    ctx.fill();
    ctx.beginPath();
    ctx.arc((100 - 3) / 0.5, 130 * 1.5 - 20, 5.5, 0, 2 * Math.PI);
    ctx.fill();
    ctx.restore();

    // draw nose
    ctx.beginPath();
    ctx.moveTo(80, 130 * 1.5 + 10);
    ctx.lineTo(65, 130 * 1.5 + 10);
    ctx.lineTo(80, 130 * 1.5 - 20);
    ctx.stroke();

    // draw mouth
    ctx.beginPath();
    ctx.save();
    ctx.rotate(5 * Math.PI / 180);
    ctx.scale(1, 0.3);
    ctx.arc(80 + 25, (130 * 1.5 + 20) / 0.3, 23, 0, 2 * Math.PI);
    ctx.restore();
    ctx.stroke();

    ctx.strokeStyle = '#000';
    ctx.fillStyle = '#396693';

    // draw cylinder bottom
    ctx.beginPath();
    ctx.save();
    ctx.scale(1, 0.2);
    ctx.arc(100 - 5, 140 / 0.2, 2 * 40, 0, 2 * Math.PI);
    ctx.restore();
    ctx.fill();
    ctx.stroke();

    // drawing cylinder top
    ctx.beginPath();
    ctx.save();
    ctx.scale(1, 0.4);
    ctx.arc(100, 50 / 0.4, 40, 0, 2 * Math.PI);
    ctx.restore();
    ctx.save();
    ctx.scale(1, 0.4);
    ctx.arc(100, 130 / 0.4, 40, 0, Math.PI);
    ctx.restore();
    ctx.lineTo(60, 50);
    ctx.fill();
    ctx.stroke();
}());