$(function () {
    $("[data-pdsa-dropdown-val]").on("click", function () {
        var text = $(this).text();
        var parent = $(this).parent().parent();
        debugger;
        $("#" + $(parent).data("pdsa-dropdown-button")).html(text + '&nbsp;<span class="caret"></span>');
        $("#" + $(parent).data("pdsa-dropdown-ctl-text")).val($(this).text());
        $("#" + $(parent).data("pdsa-dropdown-ctl-value")).val($(this).data('pdsa-dropdown-val'));
        $("#" + $(parent).data("pdsa-dropdown-submit-button")).removeClass('disabled');
    });
});

function GetSelectedDropDownValue(selectButton) {
    var sibling = $(selectButton).next();

    // Find previous sibling
    var text = $("#" + $(sibling).data("pdsa-dropdown-ctl-text")).val();
    if (text != "") {
        $("#" + $(sibling).data("pdsa-dropdown-button")).html(text + '&nbsp;<span class="caret"></span>');
        $("#" + $(sibling).data("pdsa-dropdown-submit-button")).removeClass("disabled");
    }
}