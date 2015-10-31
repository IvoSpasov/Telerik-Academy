/// <reference path="libs/require.js" />
/// <reference path="libs/sammy-0.7.4.js" />
/// <reference path="libs/jquery-2.0.3.js" />

(function () {

    require.config({
        paths: {
            jquery: "libs/jquery-2.0.3",
            sammy: "libs/sammy-0.7.5.min",
            reloadChat: "app/reload-chat",
            sendMessage: "app/send-message",
            controller: "app/controller"
        }
    })

    require(["jquery", "controller"], function ($, controller) {
        var resourceUrl = 'http://crowd-chat.herokuapp.com/posts';
        var app = controller("#main-content", resourceUrl);
        app.run("#/home");
    });
}());