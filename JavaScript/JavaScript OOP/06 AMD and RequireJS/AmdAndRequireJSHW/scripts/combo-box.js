/// <reference path="libs/jquery-2.1.1.min.js" />

define(['jquery'], function ($) {
    var ComboBox = (function () {
        $.fn.comboBox = function () {
            var $this = $(this);
            var $persons = $this.find(".person-item");
            var $selectedPerson = $this.find(".selected-person");

            // Hide all options
            $persons.hide();

            // Show all options on click
            $selectedPerson.on("click", function () {
                $persons.show();
            });

            // Select person on click
            $persons.on("click", function () {
                var $this = $(this);
                $selectedPerson.html($this.html());
                $persons.hide();
            })

            return $this;
        }
    }());


    return ComboBox;
});