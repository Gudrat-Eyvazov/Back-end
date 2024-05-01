$(document).ready(function(){

    var ticket_reservation__slider = $('.ticket-reservation__slider-wrap');
    ticket_reservation__slider.slick({
        dots: false,
        infinite: false,
        speed: 300,
        slidesToShow: 7,
        slidesToScroll: 7,
        prevArrow:"<button type='button' class='slick-prev'><i class='fas fa-arrow-left' aria-hidden='true'></i></button>",
        nextArrow:"<button type='button' class='slick-next'><i class='fas fa-arrow-right' aria-hidden='true'></i></button>",
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 5,
                    slidesToScroll: 5,
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ],
    });

    var hotel_reservation = $('.hotel-reservation-gallery__img'),
        hotel_res_nav = $('.hotel-reservation-gallery__nav');
    hotel_reservation.slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: false,
        fade: true,
        infinite: false,
        asNavFor: '.hotel-reservation-gallery__nav'
    });

    hotel_res_nav.slick({
        slidesToShow: 4,
        slidesToScroll: 1,
        asNavFor: '.hotel-reservation-gallery__img',
        dots: false,
        arrows: false,
        infinite: false,
        focusOnSelect: true
    });

    var client_logos = $('#client-logos');
    client_logos.slick({
        dots: false,
        infinite: false,
        speed: 300,
        slidesToShow: 5,
        slidesToScroll: 5,
        prevArrow:"<button type='button' class='slick-prev'><img src='http://pixsector.com/cache/a8009c95/av8a49a4f81c3318dc69d.png'/></button>",
        nextArrow:"<button type='button' class='slick-next'><img src='http://pixsector.com/cache/81183b13/avcc910c4ee5888b858fe.png'/></button>",
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3,
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ],
    });

    $('.ticket-reservation__slider-heading-hide').click(function(){
        var sliderWrap = $(this).parent().parent().find('.ticket-reservation__slider-wrap');
        sliderWrap.slideToggle('fast');
        sliderWrap.toggleClass('slider-hidden');

        if(sliderWrap.hasClass('slider-hidden')){
            $(this).html('Show <i class="fas fa-arrow-down"></i>')
        }
        else {
            $(this).html('Hide <i class="fas fa-arrow-up"></i>')
        }
    });

    $('.ticket-reservation__slider-item').click(function(){
        $(this).find('input[type=radio]').prop('checked', true);
        $(this).parents('.ticket-reservation__slider-wrap').find('.ticket-reservation__slider-item').removeClass('active');
        $(this).addClass('active')
    })

});
