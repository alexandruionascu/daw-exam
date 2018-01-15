$(document).ready(function () {
    // MODAL
    $('.modal').modal();
    // DROPDOWNS
    $(".dropdown-button").dropdown(
        {
            belowOrigin: true
        }
    );
    // INPUT SELECTS
    $('select').material_select();
    // TABS
    $('ul.tabs').tabs();
    // SCROLLSPY
    $('.scrollspy').scrollSpy();
    //SIDENAV
    $(".button-collapse").sideNav();
});