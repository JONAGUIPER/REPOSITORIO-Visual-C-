var percentIncrement;
var percentCurrent = 100;

function slideSwitch() {
    percentCurrent += percentIncrement;

    if (percentCurrent > 100) {
        percentCurrent = percentIncrement;
    }
    console.log(percentCurrent);
    $('#slideshow-progress-bar').progressbar({
        value: percentCurrent
    });

    $('#myProgress').css("width", percentCurrent + "%").attr("aria-valuenow",percentCurrent);

    var $activeCard = $('#slide-show .active-card');

    if ($activeCard.length == 0) {
        $activeCard = $('#slide-show .slide-show-card:last');
    }

    var $nextCard = $activeCard.next();
    if ($nextCard.length == 0) {
        $nextCard = $('#slide-show .slide-show-card:first');
    }
    $activeCard.addClass('last-active-card');
    $nextCard.css({ opacity: 0.0 });
    $nextCard.addClass('active-card');

    $nextCard.animate({ opacity: 1.0 }, 1000, function () {
        $activeCard.removeClass('active-card last-active-card');
    });
}

function CalcularIncremento() {
    var cardCount = $('#slide-show DIV.slide-show-card').length;
    percentIncrement = 100 / cardCount;
    console.log(cardCount);
    //$('#myProgress').css("width", "100%");
    //$('#slideshow-progress-bar').progressbar({ value: 100 });
    
}
$(document).ready(function () {
    CalcularIncremento();
    setInterval("slideSwitch()", 1000);
});