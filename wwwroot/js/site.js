// Write your Javascript code.

$(document).ready(function () {
    $(".slidetoggle").click(function () {
        $(this).next().next().slideToggle(function () {
            });
    })
})