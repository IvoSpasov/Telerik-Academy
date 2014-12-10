function drawYoutubeLogo() {
    var paper = Raphael(0, 0, 1000, 800);

    var rectangle = paper.rect(130, 12, 150, 80);
    rectangle.attr({
        r: 20,
        fill: '#E74221',
        stroke: 'none'
    });

    paper.setStart();
    var you = paper.text(20, 50, 'You');
    var tube = paper.text(137, 50, 'Tube');
    set = paper.setFinish();
    set.attr({
        'font-size': '56px',
        'text-anchor': 'start',
        'font-weight': 'bold'
    });

    you.attr({
        fill: '#4B4B4B'
    });

    tube.attr({
        fill: '#fff'
    });
}

drawYoutubeLogo();