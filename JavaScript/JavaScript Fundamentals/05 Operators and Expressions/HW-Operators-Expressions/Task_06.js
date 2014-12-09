// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

var cirlceRadius = 6;
var circleXOffset = 0;
var circleYOffset = 5;
var pointX = 2;
var pointY = 2;

pointX -= circleXOffset;
pointY -= circleYOffset;

if ((pointX * pointX) + (pointY * pointY) <= (cirlceRadius * cirlceRadius)) {
    console.log('True. The point is within the circle.');
}
else {
    console.log('False. The point is ouside the circle.');
}
