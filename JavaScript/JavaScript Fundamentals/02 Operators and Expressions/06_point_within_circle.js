// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

(function () {
    'use strict';
    function pointWithinCircle(circle, point) {
        var pointX = point.x - circle.xOffset,
            pointY = point.y - circle.yOffset,
            isWithinCircle = (pointX * pointX) + (pointY * pointY) <= (circle.radius * circle.radius);

        if (isWithinCircle) {
            return 'True. The point (' + point.x + ', ' + point.y + ') is within the circle.';
        }
        else {
            return 'False. The point (' + point.x + ', ' + point.y + ') is outside the circle.';
        }
    }

    var circle = {
            radius: 6,
            xOffset: 0,
            yOffset: 5
        },
        firstPoint = {
            x: 2,
            y: 2
        },
        secondPoint = {
            x: -2,
            y: -2
        };

    console.log(pointWithinCircle(circle, firstPoint));
    console.log(pointWithinCircle(circle, secondPoint));
})();