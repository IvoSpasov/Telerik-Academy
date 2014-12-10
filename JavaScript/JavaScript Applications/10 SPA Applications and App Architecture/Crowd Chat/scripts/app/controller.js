define(['jquery', 'sammy', 'reloadChat', 'sendMessage'], function ($, sammy, reloadChat, sendMessage) {
    'use strict';
    var app = function (div, resourceUrl) {
        return sammy(div, function () {
            this.get("#/home", function () {
                $('#chat-div').remove();
                $('#send-div').remove();
                $('#about-div').remove();
                $(div)
                    .append($('<label />')
                        .html('Username')
                        .attr("id", "label-user-name"))
                    .append($('<input /> ')
                        .attr("type", "text")
                        .attr("maxlength", "10")
                        .attr("id", "tb-user-name"));
            });

            this.get("#/chat", function () {
                var userName = $('#tb-user-name').val() || 'Anonymous';
                $('#tb-user-name').remove();
                $('#label-user-name').remove();
                $('#about-div').remove();
                $(div)
                    .append($('<div />')
                        .attr("id", "chat-div"))
                    .append($('<div />')
                        .attr("id", "send-div")
                        .append($('<input /> ')
                            .attr("type", "text")
                            .attr("maxlength", "70")
                            .attr("id", "tb-send"))
                        .append($('<button />')
                            .attr("id", "send-btn")
                            .html("Send")
                            .on('click', function () {
                                var message = {
                                    user: userName,
                                    text: $('#tb-send').val()
                                };
                                sendMessage(resourceUrl, message);
                            })));
                reloadChat(resourceUrl);
            });

            this.get("#/about", function () {
                $('#chat-div').remove();
                $('#send-div').remove();
                $('#tb-user-name').remove();
                $('#label-user-name').remove();
                $(div)
                    .append($('<div />')
                            .attr("id", "about-div")
                            .html("Thanks to:<br/> jQuery, Sammy and RequireJS."));
            });
        });
    };

    return app;
});