(function () {
    var canvas = document.getElementById('canvas-with-circle'),
        ctx = canvas.getContext('2d'),        
        r = 30,
        x = r,
        y = r,
        hasReachedEndOfX = false,
        hasReachedEndOfY = false;

    ctx.lineWidth = 2;

    function animationFrame() {
        ctx.clearRect(0, 0, canvas.width, canvas.height);
        ctx.beginPath();
        ctx.arc(x, y, r, 0, 2 * Math.PI);
        ctx.stroke();

        if (x === canvas.width - r) {
            hasReachedEndOfX = true;
        }
        if (x === r) {
            hasReachedEndOfX = false;
        }
        if (y === canvas.height - r) {
            hasReachedEndOfY = true;
        }
        if (y === r) {
            hasReachedEndOfY = false;
        }

        hasReachedEndOfX ? x-- : x++;
        hasReachedEndOfY ? y-- : y++;

        requestAnimationFrame(animationFrame);
    }

    animationFrame();
}());