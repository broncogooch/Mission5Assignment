// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#calculate').click(function () {
        var hours = parseFloat($('#hours').val());

        // Validation to make sure a positive number is entered
        if (isNaN(hours) || hours <= 0) {
            alert("Please enter a valid positive number for hours.");
            return;
        }

        var charge = parseFloat($('#charge').val());
        var total = hours * charge;

        // Display total
        $('#total').text('$' + total.toFixed(2)); // Assuming you're using USD currency
    });
});
