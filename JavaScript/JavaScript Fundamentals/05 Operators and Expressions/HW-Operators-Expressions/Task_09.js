// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

var cirlceRadius = 3;
var circleXOffset = 1;
var circleYOffset = 1;
var recWidth, recHeight, recTop, recBottom, recLeft, recRight;
recTop = 1;
recLeft = -1;
recWidth = 6;
recHeight = 2;
recBottom = recTop - recHeight;
recRight = recLeft + recWidth;

var pointX = 3;
var pointY = 3;

pointX -= circleXOffset;
pointY -= circleYOffset;

if (((pointX * pointX) + (pointY * pointY) <= (cirlceRadius * cirlceRadius)) &&
        (pointX < recLeft || pointX > recRight || pointY < recBottom || pointY > recBottom)) {
    console.log('True. The point is within the circle and outside of the rectangle.');
}
else {
    console.log('False. The point is NOT within the circle and outside of the rectangle.');
}
