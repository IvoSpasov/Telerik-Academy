(function () {
    var slidePreviewTime = 5000,
        $wrapper = $('#wrapper'),
        $ul = $('<ul>').attr('id', 'slides').appendTo($wrapper),
        $slide1 = $('<li>').addClass('slide').addClass('current').html('<img src="imgs/minion1.jpg" />').appendTo($ul),
        $slide2 = $('<li>').addClass('slide').html('<img src="imgs/minion2.jpg" />').appendTo($ul),
        $slide3 = $('<li>').addClass('slide').html('<img src="imgs/minion3.jpg" />').appendTo($ul),
        $slide4 = $('<li>').addClass('slide').html('<img src="imgs/minion4.jpg" />').appendTo($ul),
        $lastSlide = $('.slide').last(),
        $firstSlide = $('.slide').first();

    $('.slide').css('list-style', 'none');

    function updateSlideView() {
        $('.slide').css('display', 'none');
        $('.current').css('display', '');
    }

    function nextSlide() {
        var $current = $('.current');

        if ($current.is($lastSlide)) {
            $lastSlide.removeClass('current');
            $firstSlide.addClass('current');
        }
        else {
            $current.removeClass('current').next().addClass('current');
        }

        updateSlideView();
    }

    function prevoiusSlide() {
        var $current = $('.current');

        if ($current.is($firstSlide)) {
            $firstSlide.removeClass('current');
            $lastSlide.addClass('current');
        }
        else {
            $current.removeClass('current').prev().addClass('current');
        }

        updateSlideView();
    }

    function playSlides() {
        updateSlideView();
        setTimeout(nextSlide, slidePreviewTime);
        setTimeout(playSlides, slidePreviewTime);
    }

    $('#previous').on('click', prevoiusSlide);
    $('#next').on('click', nextSlide);
    playSlides();
}());