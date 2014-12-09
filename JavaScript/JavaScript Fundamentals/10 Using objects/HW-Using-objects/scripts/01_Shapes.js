// 01 Write functions for working with shapes in standard Planar coordinate system. Points are represented by coordinates P(X, Y).
// Lines are represented by two points, marking their beginning and ending -> L(P1(X1,Y1),P2(X2,Y2)).
// Calculate the distance between two points. Check if three segment lines can form a triangle.

var buildPoint = function (X, Y) {
    return {
        X: X,
        Y: Y
    };
};

var buildLine = function (firstPoit, secondPoint) {
    return {
        pointA: firstPoit,
        pointB: secondPoint
    };
};

function calculateDistance(firstPoint, secondPoint) {
    var xDistance = secondPoint.X - firstPoint.X;
    var yDistance = secondPoint.Y - firstPoint.Y;
    var distance = Math.sqrt(xDistance * xDistance + yDistance * yDistance);
    return distance;
}

function calculateLineLenght(line) {
    var lenght = calculateDistance(line.pointA, line.pointB);
    return lenght;
}

function canFormTriangle(firstLine, secondLine, thirdLine) {
    var sideA = calculateLineLenght(firstLine);
    var sideB = calculateLineLenght(secondLine);
    var sideC = calculateLineLenght(thirdLine);

    if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA) {
        return true;
    }
    else {
        return false;
    }
}

var pointA = buildPoint(1, 4);
var pointB = buildPoint(4, 4);
var lineA = buildLine(pointA, pointB);
var lineB = buildLine(buildPoint(5, 2), buildPoint(5, 8));
var lineC = buildLine(buildPoint(3, 6), buildPoint(10, 3));

var canMakeTraingle = canFormTriangle(lineA, lineB, lineC);
console.log('Can three segment lines form a triangle?: ' + canMakeTraingle);