// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

(function () {
    'use strict';
    function isPointInsideCircle(circle, point) {
        var pointX = point.x - circle.xOffset,
            pointY = point.y - circle.yOffset,
            isWithinCircle = (pointX * pointX) + (pointY * pointY) <= (circle.radius * circle.radius);

        return isWithinCircle;
    }
    function isPointInsideRectangle(rectangle, point) {
        var rectangleRight = rectangle.left + rectangle.width,
            rectangleBottom = rectangle.top - rectangle.height,
            isWithinRectangle = rectangle.left <= point.x && point.x <= rectangleRight &&
                rectangleBottom <= point.y && point.y <= rectangle.top;

        return isWithinRectangle;
    }

    var circle = {
            radius: 3,
            xOffset: 1,
            yOffset: 1
        },
        rectangle = {
            top: 1,
            left: -1,
            width: 6,
            height: 2
        },
        firstPoint = {
            x: 1,
            y: 2
        },
        secondPoint = {
            x: 0,
            y: 0
        },
        inCircleAndOutOfRectangleFirstPoint = isPointInsideCircle(circle, firstPoint) &&
            !isPointInsideRectangle(rectangle, firstPoint),
        inCircleAndOutOfRectangleSecondPoint = isPointInsideCircle(circle, secondPoint) &&
            !isPointInsideRectangle(rectangle, secondPoint);

    console.log('Is the point (' + firstPoint.x + ', ' + firstPoint.y + ') within the circle and out of the rectangle: '
        + inCircleAndOutOfRectangleFirstPoint);
    console.log('Is the point (' + secondPoint.x + ', ' + secondPoint.y + ') within the circle and out of the rectangle: '
        + inCircleAndOutOfRectangleSecondPoint);
})();