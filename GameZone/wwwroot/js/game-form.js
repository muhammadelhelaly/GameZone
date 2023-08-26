$(document).ready(function () {
    $('#Cover').on('change', function () {
        $('.cover-preview').attr('src', window.URL.createObjectURL(this.files[0])).removeClass('d-none');
    });
});