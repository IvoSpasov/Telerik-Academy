var movingShapes = (function () {
    'use strict';
    var self;

    function addShape(typeOfShape) {
        var wrapper = document.querySelector('#wrapper');

        switch (typeOfShape) {
            case 'circle': createCircle(); break;
            case 'rect': createRectangle(); break;
            default:
        }

        function createCircle() {
            var DIV_HOLDER_DIMENSION = 350,
                CIRCULAR_DIV_DIMENSION = 40,
                NUMBER_OF_DIVS = 6,
                R = 100,
                circlesHolder = document.createElement('div'),
                circularDiv = document.createElement('div'),
                fragment = document.createDocumentFragment(),
                xCenterPoint = (DIV_HOLDER_DIMENSION / 2) - (CIRCULAR_DIV_DIMENSION / 2),
                yCenterPoint = (DIV_HOLDER_DIMENSION / 2) - (CIRCULAR_DIV_DIMENSION / 2),
                x,
                y,
                equalDistanceInDegrees = 360 / NUMBER_OF_DIVS,
                angleInRadians,
                i,
                divCopy,
                currentHolderCopy,
                backgroundColor = createRandomColors(),
                borderColor = createRandomColors();

            function createRandomColors() {
                var colors = [];
                for (i = 0; i < NUMBER_OF_DIVS; i += 1) {
                    colors[i] = getRandomColor();
                }

                return colors;
            }

            function applyDivHolderAttributes() {
                circlesHolder.style.width = DIV_HOLDER_DIMENSION + 'px';
                circlesHolder.style.height = DIV_HOLDER_DIMENSION + 'px';
                circlesHolder.style.border = '1px solid blue';
                circlesHolder.style.position = 'relative';
                circlesHolder.setAttribute('class', 'circle-wrapper');
            }

            function applyCircluarDivsStyles() {
                circularDiv.style.width = CIRCULAR_DIV_DIMENSION + 'px';
                circularDiv.style.height = CIRCULAR_DIV_DIMENSION + 'px';
                circularDiv.style.borderWidth = '4px';
                circularDiv.style.borderStyle = 'solid';
                circularDiv.style.borderRadius = CIRCULAR_DIV_DIMENSION + 'px';
                circularDiv.style.position = 'absolute';
            }

            function applyIndividualCircularDivsStyles() {
                circularDiv.style.top = y + 'px';
                circularDiv.style.left = x + 'px';
                circularDiv.style.backgroundColor = backgroundColor[i];
                circularDiv.style.borderColor = borderColor[i];
            }

            applyDivHolderAttributes();
            applyCircluarDivsStyles();

            function createCircularDivs(angleInDegrees) {
                // clear
                if (currentHolderCopy) {
                    wrapper.removeChild(currentHolderCopy);
                }

                // create the divs positioned in a circle
                for (i = 0; i < NUMBER_OF_DIVS; i += 1) {
                    angleInRadians = angleInDegrees * Math.PI / 180;
                    x = (R * Math.cos(angleInRadians)) + xCenterPoint;
                    y = (R * Math.sin(angleInRadians)) + yCenterPoint;
                    angleInDegrees += equalDistanceInDegrees;

                    applyIndividualCircularDivsStyles();
                    divCopy = circularDiv.cloneNode(true);
                    fragment.appendChild(divCopy); // why there is no need the clear the frament?
                }

                currentHolderCopy = circlesHolder.cloneNode(true);
                currentHolderCopy.appendChild(fragment);
                wrapper.appendChild(currentHolderCopy);
            }

            function createCirclularAnimation() {
                var REFRESH_INTERVAL = 80,
                    angle = 0;

                function frame() {
                    createCircularDivs(angle);
                    angle += 0.4;

                    //setTimeout(frame, REFRESH_INTERVAL); // a bug appears when using setTimeout but I can't fix it
                    window.requestAnimationFrame(frame);

                    if (angle === 360) {
                        angle = 0;
                    }
                }

                frame();
            }

            return createCirclularAnimation();
        }

        function createRectangle() {
            // next time
        }

        return self;
    }

    self = {
        add: addShape
    };

    return self;
}());

//add element with cricular movement
movingShapes.add('circle');
movingShapes.add('circle').add('circle');


function getRandomInt(min, max) {
    'use strict';
    if (min === max) {
        return min;
    }
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function getRandomColor() {
    'use strict';
    var r = getRandomInt(0, 255),
        g = getRandomInt(0, 255),
        b = getRandomInt(0, 255),
        color = 'rgb(' + r + ', ' + g + ', ' + b + ')';
    return color;
}