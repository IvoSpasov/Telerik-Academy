// The program is not working perfectly and it is not looking very well. This is all I managed to do in the given time.

window.onload = function () {

    var stage = new Kinetic.Stage({
        container: 'canvas-container',
        width: 1200,
        height: 800
    });

    var layer = new Kinetic.Layer();

    var familyMembers = [{
        mother: 'Maria Petrova',
        father: 'Georgi Petrov',
        children: ['Teodora Petrova', 'Peter Petrov']
    }, {
        mother: 'Petra Stamatova',
        father: 'Todor Stamatov',
        children: ['Maria Petrova']
    }],
        startPosX = 50,
        startPosY = 50,
        distanceBetweenRows = 150,
        distanceBetweenNames = 200,
        rowHeight = 58,
        position = {
            x: startPosX,
            y: startPosY
        },
        relation = 'no relation';

    function sortingFamilies(families) {
        var previousFamily,
            i, j, k;

        for (i = 0; i < families.length; i += 1) {
            for (j = i + 1; j < families.length; j += 1) {
                for (k = 0; k < families[j].children.length; k += 1) {
                    if (families[i].father === families[j].children[k] ||
                            families[i].mother === families[j].children[k]) {
                        previousFamily = families[i];
                        families[i] = families[j];
                        families[j] = previousFamily;
                    }
                }
            }
        }
    }

    function drawBoxWithName(name, posX, posY) {
        var text = new Kinetic.Text({
            x: posX,
            y: posY,
            text: name,
            fontSize: 18,
            fontFamily: 'Calibri',
            fill: '#000',
            padding: 20
        }),
            rect = new Kinetic.Rect({
                x: posX,
                y: posY,
                width: text.width(),
                height: text.height(),
                stroke: 'black'

            });

        layer.add(text);
        layer.add(rect);

    }

    function drawLine(lineCoordinates) {
        var lineCoordsCopy = [],
            textBoxWidth = 75,
            line,
            i;
        for (i = 0; i < lineCoordinates.length; i += 1) {
            if (i % 2 === 0) {
                lineCoordsCopy[i] = lineCoordinates[i] + textBoxWidth;
            }
            else {
                lineCoordsCopy[i] = lineCoordinates[i];
            }
        }

        line = new Kinetic.Line({
            points: lineCoordsCopy,
            stroke: 'green',
            strokeWidth: 2
        });

        layer.add(line);
    }

    function checkForRelation(firstFamily, secondFamily) {
        var i;
        for (i = 0; i < firstFamily.children.length; i += 1) {
            if (secondFamily.father === firstFamily.children[i]) {
                return 'father';
            }
            else if (secondFamily.mother === firstFamily.children[i]) {
                return 'mother';
            }
            else {
                return 'no relation';
            }
        }
    }

    function drawFamily(theFamily, relation) {
        var fatherChildLine = [],
            motherChildLine = [],
            i;

        if (relation === 'no relation') {
            drawBoxWithName(theFamily.father, position.x, position.y);
            drawBoxWithName(theFamily.mother, position.x + distanceBetweenNames, position.y);
            fatherChildLine.push(position.x, position.y + rowHeight);
            motherChildLine.push(position.x + distanceBetweenNames, position.y + rowHeight);
        }
        else if (relation === 'mother') {
            drawBoxWithName(theFamily.father, position.x, position.y);
            fatherChildLine.push(position.x, position.y + rowHeight);
            motherChildLine.push(position.x - distanceBetweenNames, position.y + rowHeight);
            position.x = startPosX; // reset x... depends on global variable!
        }
        else if (relation === 'father') {
            drawBoxWithName(theFamily.mother, position.x, position.y);
            fatherChildLine.push(position.x, position.y + rowHeight);
            motherChildLine.push(position.x + distanceBetweenNames, position.y + rowHeight);
            position.x = startPosX; // reset x... depends on global variable!
        }

        position.y += distanceBetweenRows;

        for (i = 0; i < theFamily.children.length; i += 1) {
            drawBoxWithName(theFamily.children[i], position.x, position.y);

            fatherChildLine.push(position.x, position.y);
            motherChildLine.push(position.x, position.y);

            drawLine(fatherChildLine);
            drawLine(motherChildLine);

            fatherChildLine.pop(); // reset
            fatherChildLine.pop(); // reset
            motherChildLine.pop(); // reset
            motherChildLine.pop(); // reset

            position.x += distanceBetweenNames;
        }
    }

    sortingFamilies(familyMembers);

    for (var i = 0; i < familyMembers.length; i += 1) {
        drawFamily(familyMembers[i], relation);

        if (i + 1 < familyMembers.length) {
            relation = checkForRelation(familyMembers[i], familyMembers[i + 1]);
            console.log(relation);
        }
    }

    stage.add(layer);
};