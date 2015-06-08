// Write functions for working with shapes in standard Planar coordinate system.
//      Points are represented by coordinates P(X, Y)
//      Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
// Calculate the distance between two points.
// Check if three segment lines can form a triangle.

(function () {
    'use strict';
    var pointA,
        pointB,
        lineA,
        lineB,
        lineC;

    function buildPoint(X, Y) {
        return {
            X: X,
            Y: Y
        };
    }

    function buildLine(firstPoint, secondPoint) {
        return {
            pointA: firstPoint,
            pointB: secondPoint
        };
    }

    function distanceBetweenTwoPoints(firstPoint, secondPoint) {
        var xDistance = secondPoint.X - firstPoint.X,
            yDistance = secondPoint.Y - firstPoint.Y,
            distance = Math.sqrt(xDistance * xDistance + yDistance * yDistance);
        return distance;
    }

    function calculateLineLength(line) {
        return distanceBetweenTwoPoints(line.pointA, line.pointB);
    }

    function canFormTriangle(firstLine, secondLine, thirdLine) {
        var sideA = calculateLineLength(firstLine),
            sideB = calculateLineLength(secondLine),
            sideC = calculateLineLength(thirdLine);

        if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA) {
            return true;
        }

        return false;
    }

    pointA = buildPoint(1, 4);
    pointB = buildPoint(4, 4);
    lineA = buildLine(pointA, pointB);
    lineB = buildLine(buildPoint(5, 2), buildPoint(5, 8));
    lineC = buildLine(buildPoint(3, 6), buildPoint(10, 3));

    console.log('Can three segment lines form a triangle?: ' + canFormTriangle(lineA, lineB, lineC));
})();