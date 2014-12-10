function createDivs(angleInDegrees) {
    var divElement,
        numberOfDivs = 5,
        dimension = '40px',
        dFrag = document.createDocumentFragment(),
        wrapper = document.getElementById('wrapper'),
        r = 100,
        xCenterPoint = 200,
        yCenterPoint = 200,
        x,
        y,
        angleInDegrees,
        equalDistanceInDegrees = 360 / numberOfDivs,
        angleInRadians;

    // if there are any divs inside the wrapper -> delete them all.
    while (wrapper.childNodes.length !== 0) {
        wrapper.removeChild(wrapper.childNodes[0]);
    }

    // create the divs positioned in a circle
    for (var i = 0; i < numberOfDivs; i += 1) {
        angleInRadians = angleInDegrees * Math.PI / 180;
        x = (r * Math.cos(angleInRadians)) + xCenterPoint;
        y = (r * Math.sin(angleInRadians)) + yCenterPoint;
        angleInDegrees += equalDistanceInDegrees;

        divElement = document.createElement('div');
        divElement.style.width = dimension;
        divElement.style.height = dimension;
        divElement.style.border = '1px solid black';
        divElement.style.borderRadius = dimension;
        divElement.style.position = 'absolute';
        divElement.style.top = y + 'px';
        divElement.style.left = x + 'px';

        dFrag.appendChild(divElement);
    }

    wrapper.appendChild(dFrag);
}

function drawAnimatedDivs() {
    var angle = 0;

    function frame() {
        var refreshInterval = 100;
        createDivs(angle)
        angle++;

        setTimeout(frame, refreshInterval);
        //window.requestAnimationFrame(frame);

        if (angle === 360) {
            angle = 0;
        }
    }

    frame();
}

drawAnimatedDivs();