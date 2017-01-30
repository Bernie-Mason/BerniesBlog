$(function () {

    var ajaxFormSubmit = function () {
        var $form = $(this);
        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        }
    };
    $("form[data-berniesblog-ajax='true]").submit(ajaxFormSubmit);
});

