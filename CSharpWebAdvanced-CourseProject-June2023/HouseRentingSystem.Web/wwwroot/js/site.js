function statistics() {
    $('#statics_btn').on('click', function (e) {
        e.preventDeafault();
        e.stopPropagation();
        $.get('https://localhost:7056/api/statistics', function (data) {
            $('#total_houses').text(data.totalHouses + " Houses");
            $('#total_rents').text(data.totalRents + " Rents");

            $('#statistics_box').removeClass('d-none');
            $('#statistics_btn').hide();
        });
    });
}