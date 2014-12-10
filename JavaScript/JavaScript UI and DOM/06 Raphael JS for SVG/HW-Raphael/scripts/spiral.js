function drawSpiral() {
    var paper = Raphael(50, 50, 800, 800);
    //using the Archimedian spiral equation r = a + b * angle;  a sets the offset from the central point, b - the distance between turnings
    var r,
        x,
        y,
        xCenterPoint = 400,
        yCenterPoint = 400,
        numberOfPoints,
        a = 0,
        b = 10,
        angle,
        spiralPoints = ['M ' + xCenterPoint + ' ' + yCenterPoint];

    for (numberOfPoints = 0; numberOfPoints < 300; numberOfPoints += 1) {
        angle = 0.1 * numberOfPoints;
        r = a + b * angle;
        x = (r * Math.cos(angle)) + xCenterPoint;
        y = (r * Math.sin(angle)) + yCenterPoint;

        paper.circle(x, y, 1);
        spiralPoints.push('L ' + x + ' ' + y);
    }

    var spiralPointsStr = spiralPoints.join(' ');
    paper.path(spiralPointsStr);
}

drawSpiral();