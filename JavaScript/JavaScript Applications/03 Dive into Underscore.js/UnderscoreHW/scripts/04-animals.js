(function () {
    'use strict';

    var Animal = function () {
        function Animal(kind, specie, numberOfLegs) {
            this.kind = kind;
            this.specie = specie;
            this.numberOfLegs = numberOfLegs;
        }

        Animal.prototype.toString = function () {
            return this.kind + ' is a ' + this.specie + ' with number of legs -> ' + this.numberOfLegs;
        }

        return Animal;
    }()

    var animals = [
        new Animal('eagle', 'bird', 2),
        new Animal('bear', 'mammal', 4),
        new Animal('goose', 'bird', 2),
        new Animal('butterfly', 'insect', 6),
        new Animal('wood pecker', 'bird', 2),
        new Animal('elephant', 'mammal', 4),
        new Animal('cricket', 'insect', 6),
        new Animal('beaver', 'mammal', 4),
        new Animal('falcon', 'bird', 2),
        new Animal('centipede', 'bug?', 100)
    ];

    var groupedBySpecies = _.groupBy(animals, function (currentAnimal) {
        return currentAnimal.specie;
    });

    var sortedAnimals = _.sortBy(groupedBySpecies, function (currentSpecies) {
        var firstAnimalFromSpecies = currentSpecies[0];
        return firstAnimalFromSpecies.numberOfLegs;
    });

    console.log(sortedAnimals);
}());