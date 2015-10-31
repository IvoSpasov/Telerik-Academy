/// <reference path="libs/jquery-2.1.1.min.js" />

define(['jquery', 'handlebars'], function ($) {
    var TemplateEngine = (function () {
        $.fn.templateEngine = function ($template, data) {
            var $this = $(this),
                postTemplateHTML,
                postTemplate;

            postTemplateHTML = $template.html();
            postTemplate = Handlebars.compile(postTemplateHTML);

            for (var i = 0, len = data.length; i < len; i++) {
                $this.append(postTemplate(data[i]));
            }

            return $this;
        };
    }());
    
    return TemplateEngine;
});