(function () {
    var stage = new Kinetic.Stage({
        container: 'container',
        width: 450,
        height: 385
    }),
        layer = new Kinetic.Layer(),
        marioImage = new Image();
    marioImage.src = 'images/mario.png';

    marioImage.onload = function () {
        var mario = new Kinetic.Sprite({
            x: 250,
            y: 209,
            image: marioImage,
            animation: 'idle',
            animations: {
                idle: [
                    // x, y, width, height (8 frames)
                     10, 5, 75, 120,
                     85, 5, 75, 120,
                    175, 5, 75, 120,
                    255, 5, 75, 120,
                    335, 5, 75, 120,
                    405, 5, 75, 120,
                    480, 5, 75, 120,
                    570, 5, 75, 120,
                    660, 5, 75, 120,
                    745, 5, 75, 120
                ]
            },
            frameRate: 8,
            frameIndex: 0
        });

        // add the shape to the layer
        layer.add(mario);

        // add the layer to the stage
        stage.add(layer);

        // start sprite animation
        mario.start();
    };
}());