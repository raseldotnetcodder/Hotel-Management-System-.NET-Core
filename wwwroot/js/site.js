

//$(function () {
//    $("#loaderbody").addClass('hide');
//    $(document).bind('ajaxStart', function () {
//        $("#loaderbody").removeClass('hide');
//    }).bind('ajaxStop', function () {
//        $("#loaderbody").addClass('hide');
//    });
//});

function Preview(imageUploader, previewImage) {
    if (imageUploader.files && imageUploader.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $(previewImage).attr('src', e.target.result);
        }
        reader.readAsDataURL(imageUploader.files[0]);
    }
}

showInPopup = (url) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (response) {
            $("#popup .modal-body").html(response);
            $("#popup").modal('show');
        }
    })
}

$(document).ready(function () {
    $('#DeleteModal').on('show.bs.modal', function (e) {

        var imageID = $(e.relatedTarget).data('image-id');
        var imageName = $(e.relatedTarget).data('image-name');
        var deleteMessage = "Are you sure you want to delete " + imageName + "?";
        $('#DeleteConfirmation').html(deleteMessage);
        $(e.currentTarget).find('input[name="id"]').val(imageID);
    });
});
