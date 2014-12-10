//var points = [40, 100, 100, 5, 25, 10];
//points.sort(function (a, b) { return (a === b) ? 0 : (a > b) ? 1 : -1; });

//console.log(points);

window.onload = function () {
    var familyMembers = [{
        mother: 'Teodora Petrova',
        father: 'Qnko',
        children: ['Mitko']
    }, {
        mother: 'Maria Petrova',
        father: 'Georgi Petrov',
        children: ['Teodora Petrova', 'Peter Petrov']
    }, {
        mother: 'Petra Stamatova',
        father: 'Todor Stamatov',
        children: ['Maria Petrova']
    }];

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

    sortingFamilies(familyMembers);

    console.log(familyMembers);
};

