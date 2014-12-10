function drawTelerikLogo() {
    var paper = Raphael(0, 0, 1000, 400);

    var logoPartOne = paper.path('M50 100 L100 50 150 100 200 50 250 100 235 115 200 80 165 115 220 170 150 240 80 170 135 115 100 80 65 115 z');
    logoPartOne.attr({
        fill: '#62E331',
        stroke: 'none'
    });

    var logoPartTwo = paper.path('M150 130 L190 170 150 210 110 170 z');
    logoPartTwo.attr({
        fill: '#fff',
        stroke: 'none'
    });

    var telerikText = paper.text(300, 185, 'Telerik');
    telerikText.attr({
        'font-size': '150px',
        'font-weight': 'bold',
        'text-anchor': 'start'
    });

    var developText = paper.text(330, 300, 'Develop experiences');
    developText.attr({
        'font-size': '70px',
        'text-anchor': 'start'
    });

    var rCircle = paper.circle(800, 175, 12);
    rCircle.attr({
        'stroke-width': 2
    });

    var rText = paper.text(799, 175, 'R');
    rText.attr({
        'font-size': '18px',
        'font-weight': 'bold'
    });


}

drawTelerikLogo();