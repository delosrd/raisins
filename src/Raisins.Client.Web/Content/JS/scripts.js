﻿$().ready(function () {
    $("ul#teamscontent li a").hover(
        function () {
            $(this).parent().find('h4').show("slide", { direction: "down", easing: 'easeOutBounce' });
        },
        function () {
            $(this).parent().find('h4').hide("slide", { direction: "down", easing: 'easeOutBounce' });
        }

    );
});