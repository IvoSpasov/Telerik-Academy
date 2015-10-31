/// <reference path="libs/require.js" />
/// <reference path="libs/jquery-2.1.1.min.js" />
/// <reference path="template-engine" />

(function () {
    require.config({
        paths: {
            'jquery': 'libs/jquery-2.1.1.min',
            'handlebars': 'libs/handlebars-v1.3.0',
            'tEngine': 'template-engine',
            'comboBox': 'combo-box'
        }
    });

    require(['jquery', 'tEngine', 'comboBox'], function ($) {
        var people = [{
            id: 1, name: "Doncho Minkov", age: 18, avatarUrl: "images/doncho.jpg"
        }, {
            id: 2, name: "Niki Kostov", age: 19, avatarUrl: "images/niki.jpg"
        }, {
            id: 3, name: "Ivo Kenov", age: 17, avatarUrl: "images/ivo.jpg"
        }];

        var $template = $('#person-template');
        var $divCombo = $('#combo-box');
        $divCombo.templateEngine($template, people);
        $divCombo.comboBox();
    });
}());