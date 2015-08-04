(function () {
    'use strict';
    var students = [{
        firstName: 'Peter',
        lastName: 'Ivanov',
        grade: 3
    }, {
        firstName: 'Milena',
        lastName: 'Grigorova',
        grade: 6
    }, {
        firstName: 'Gergana',
        lastName: 'Borisova',
        grade: 12
    }, {
        firstName: 'Boyko',
        lastName: 'Petrov',
        grade: 7
    }];

    function generateTable(people) {
        var $table = $('<table>'),
            $tableHeading = $('<thead>'),
            $firstRow = $('<tr>'),
            $nextRow,
            i;
        $table.appendTo($('#wrapper'));
        $tableHeading.appendTo($table);
        $firstRow.appendTo($tableHeading);
        $firstRow.append($('<th>').text('First name'));
        $firstRow.append($('<th>').text('Last name'));
        $firstRow.append($('<th>').text('Grade'));

        for (i = 0; i < people.length; i += 1) {
            $nextRow = $('<tr>');
            $nextRow.appendTo($table);
            $nextRow.append($('<td>').text(people[i].firstName));
            $nextRow.append($('<td>').text(people[i].lastName));
            $nextRow.append($('<td>').text(people[i].grade));
        }

        // apply styles
        $table.css('border', '1px solid black').css('border-collapse', 'collapse');
        $('th').css('border', '1px solid black').css('padding', '5px');
        $('td').css('border', '1px solid black').css('padding', '5px');
    }

    generateTable(students);
}());