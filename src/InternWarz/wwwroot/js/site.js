// Write your Javascript code.
$(function () {
    $("#FacebookLogin").on("click", function (e) {
        e.preventDefault(); // cancel the link itself
        $.ajax({
            type: "POST",
            url: this.href,
            data: { provider: "Facebook" },
            contentType: "application/json",
            success: () => { },
            dataType: () => { }
        });
        $.post(this.href, {provider: "Facebook"}, function (data) {
            $("#FacebookLogin").html(data);
        });
    });
});

