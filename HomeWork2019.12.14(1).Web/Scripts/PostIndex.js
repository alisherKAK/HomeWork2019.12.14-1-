$("i").on("click", function (e) {
    var count = parseInt($(this).data("count")) + 1;
    var id = $(this).attr("id");
    $.post("/Post/Index",
        {
            postId: id,
            likeCount: count
        });

    $("#" + id + " span").html(count);
});