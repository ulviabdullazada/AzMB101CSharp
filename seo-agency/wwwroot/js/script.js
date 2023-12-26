$(window).on("load", function () {

    "use strict";

    /* ===================================
            Loading Timeout
     ====================================== */

    $('.side-menu').removeClass('hidden');

    setTimeout(function(){
        $('.preloader').fadeOut();
        $('.cd-transition-layer').addClass('closing').delay(1000).queue(function(){
            $(this).removeClass("visible closing opening").dequeue();
        });
    }, 1000);

    setTimeout(function(){
        $('.banner-slider .svg-div').removeClass('svg-anim');
    }, 1000);



});


jQuery(function ($) {

    "use strict";
    /* ===================================
           Header appear
        ====================================== */
    if($(window).width() > 780) {
        $(window).on('scroll', function () {

                if ($(this).scrollTop() > 260) { // Set position from top to add class
                    $('.inner-header').addClass('header-appear');
                } else {
                    $('.inner-header').removeClass('header-appear');
                }

        });
    }else{
        // Set position from top to add class
        $('.inner-header').addClass('header-appear');

    }


    /* ===================================
         arrow appear and scroll to top
     ====================================== */

    $(window).on('scroll', function () {
        if ($(this).scrollTop() > 500) {
            $('.scroll-top-arrow').fadeIn('slow');
        }else {
            $('.scroll-top-arrow').fadeOut('slow');
        }
    });

    //Click event to scroll to top
    $(document).on('click', '.scroll-top-arrow', function () {
        $('html, body').animate({scrollTop: 0}, 800);
        return false;
    });

    $(document).on('click', '.home', function () {
        $('html, body').animate({scrollTop: 0}, 800);
        return false;
    });

    /* ===================================
           Navbar smooth Scroll
       ====================================== */
    $(".scroll").on("click", function (event) {
        event.preventDefault();
        $("html,body").animate({
            scrollTop: $(this.hash).offset().top - 50}, 1200);
    });

    // $(".scroll").on('click', function(event) {
    //
    //     if (this.hash !== "") {
    //         event.preventDefault();
    //
    //         var hash = this.hash;
    //         $('html, body').animate({
    //             scrollTop: $(hash).offset().top -0
    //         }, 500, function () {
    //
    //             window.location.hash = hash;
    //         });
    //     }
    // });

    /* ===================================
        Side Menu
    ====================================== */
    if ($("#sidemenu_toggle").length) {
        $("#sidemenu_toggle").on("click", function () {
            $(".side-menu").removeClass("side-menu-opacity");
            $(".pushwrap").toggleClass("active");
            $(".side-menu").addClass("side-menu-active"), $("#close_side_menu").fadeIn(700)
        }), $("#close_side_menu").on("click", function () {
            $(".side-menu").removeClass("side-menu-active"), $(this).fadeOut(200), $(".pushwrap").removeClass("active");
            setTimeout(function(){
                $(".side-menu").addClass("side-menu-opacity");
            }, 500);
        }), $(".side-nav .navbar-nav .nav-link").on("click", function () {
            $(".side-menu").removeClass("side-menu-active"), $("#close_side_menu").fadeOut(200), $(".pushwrap").removeClass("active");
            setTimeout(function(){
                $(".side-menu").addClass("side-menu-opacity");
            }, 500);
        }), $("#btn_sideNavClose").on("click", function () {
            $(".side-menu").removeClass("side-menu-active"), $("#close_side_menu").fadeOut(200), $(".pushwrap").removeClass("active");
            setTimeout(function(){
                $(".side-menu").addClass("side-menu-opacity");
            }, 500);
        });
    }


    /* =====================================
          Parallax
       ====================================== */

    if($(window).width() < 780) {
        $('.parallax').addClass("parallax-disable");
    } else {
        $('.parallax').removeClass("parallax-disable");

        // parallax
        $(".parallax").parallaxie({
            speed: 0.55,
            offset: 0,
        });
    }

    /* ===================================
                Mouse parallax
    ====================================== */


    $('.slider-area,.slider-sec,header').mousemove(function(e) {
        $('[data-depth]').each(function () {
            var depth = $(this).data('depth');
            var amountMovedX = (e.pageX * -depth/4);
            var amountMovedY = (e.pageY * -depth/4);

            $(this).css({
                'transform':'translate3d(' + amountMovedX +'px,' + amountMovedY +'px, 0)',
            });
        });
    });
    /* ===================================
      Owl Carousel
     ====================================== */

    //Testimonial Slider

    $('.portfolio-carousel').owlCarousel({
        loop: true,
        responsiveClass: true,
        nav:false,
        dots:false,
        autoplay: true,
        margin:30,
        autoplayHoverPause: true,
        responsive: {
            0: {
                items: 1,
            },
            480: {
                items: 1,
            },
            992: {
                items: 1,
            }
        }
    });

    $('#portfolio-arr-right').click(function() {
        var owl = $('.portfolio-carousel');
        owl.owlCarousel();
        owl.trigger('next.owl.carousel');
    });
    $('#portfolio-arr-left').click(function() {
        var owl = $('.portfolio-carousel');
        owl.owlCarousel();
        owl.trigger('prev.owl.carousel', [300]);
    });

    /* ===================================
           slick for testimonial
     ====================================== */

    $('.testimonial-box').owlCarousel({

        loop: true,
        margin: 20,
        slideSpeed: 5000,
        slideTransition: 'linear',
        nav: false,
        dots: false,
        autoplay: true,
        autoplayTimeout: 8000,
        autoplayHoverPause: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            1000: {
                items: 1
            },
        }

    });
    /* =====================================
                    sponsers  carousel
        ====================================== */

    $('.sponser-tags').owlCarousel({

        loop: true,
        margin: 20,
        slideSpeed: 5000,
        slideTransition: 'linear',
        nav: false,
        dots: false,
        autoplay: true,
        autoplayTimeout: 10000,
        autoplayHoverPause: true,
        responsive: {
            0: {
                items: 2
            },
            600: {
                items: 3
            },
            1000: {
                items: 4
            },
        }

    });

    /* =====================================
             slick for slider
     ====================================== */



    /* =====================================
             circular bars
     ====================================== */

    $(".circular-wrap").appear(function () {
        $(".circle").circleProgress({
            size: 210,
            lineCap: "round",
            fill: {
                gradient: ["#fa2851", "#350d82"]
            },
        });
    });


    $(".circular-wrap.dark").appear(function () {
        $('.myskill').circleProgress({
            lineCap: "round",
            size: 200,
        });
    });

    /* ===================================
                 Wow Effects
       ======================================*/
    var wow = new WOW(
        {
            boxClass:'wow',      // default
            animateClass:'animated', // default
            offset:0,          // default
            mobile:false,       // default
            live:true        // default
        }
    );
    wow.init();

    /* =====================================
       Pricing Card
 ====================================== */

    $('.pricing-sec .pricing-cards .pricing-card').on('mouseover',function () {
        $('.pricing-sec .pricing-card:nth-child(2)').removeClass('active');
    });
    $('.pricing-sec .pricing-cards .pricing-card').on('mouseleave',function () {
        $('.pricing-sec .pricing-card:nth-child(2)').addClass('active');
    });

    /* ===================================
    Mouse parallax
   ====================================== */


    $('.banner-slider,header').mousemove(function(e) {
        $('[data-depth]').each(function () {
            var depth = $(this).data('depth');
            var amountMovedX = (e.pageX * -depth/4);
            var amountMovedY = (e.pageY * -depth/4);

            $(this).css({
                'transform':'translate3d(' + amountMovedX +'px,' + amountMovedY +'px, 0)',
            });
        });
    });

    /* ===================================
      Animated Cursor
    ====================================== */

    /* Animated Cursor */

    function animatedCursor() {

        if ($(".aimated-cursor").length) {

            var e = {x: 0, y: 0}, t = {x: 0, y: 0}, n = .25, o = !1, a = document.getElementsByClassName("cursor"),
                i = document.getElementsByClassName("cursor-loader");
            TweenLite.set(a, {xPercent: -50, yPercent: -50}), document.addEventListener("mousemove", function (t) {
                var n = window.pageYOffset || document.documentElement.scrollTop;
                e.x = t.pageX, e.y = t.pageY - n
            }), TweenLite.ticker.addEventListener("tick", function () {
                o || (t.x += (e.x - t.x) * n, t.y += (e.y - t.y) * n , TweenLite.set(a, {x: t.x, y: t.y}))
            }),
                $(".animated-wrap").mouseenter(function (e) {
                    TweenMax.to(this, .3, {scale: 2}), TweenMax.to(a, .3, {
                        scale: 1.5,
                        borderWidth: "1px",
                        opacity: .2
                    }), TweenMax.to(i, .3, {
                        scale: 1.5,
                        borderWidth: "1px",
                        top: 1,
                        left: 1
                    }), TweenMax.to($(this).children(), .3, {scale: .5}), o = !0
                }),
                $(".animated-wrap").mouseleave(function (e) {
                    TweenMax.to(this, .3, {scale: 1}), TweenMax.to(a, .3, {
                        scale: 1,
                        borderWidth: "2px",
                        opacity: 1
                    }), TweenMax.to(i, .3, {
                        scale: 1,
                        borderWidth: "2px",
                        top: 0,
                        left: 0
                    }), TweenMax.to($(this).children(), .3, {scale: 1, x: 0, y: 0}), o = !1
                }),
                $(".animated-wrap").mousemove(function (e) {
                    var n, o, i, l, r, d, c, s, p, h, x, u, w, f, m;
                    n = e, o = 2, i = this.getBoundingClientRect(), l = n.pageX - i.left, r = n.pageY - i.top, d = window.pageYOffset || document.documentElement.scrollTop, t.x = i.left + i.width / 2 + (l - i.width / 2) / o, t.y = i.top + i.height / 2 + (r - i.height / 2 - d) / o, TweenMax.to(a, .3, {
                        x: t.x,
                        y: t.y
                    }), s = e, p = c = this, h = c.querySelector(".animated-element"), x = 20, u = p.getBoundingClientRect(), w = s.pageX - u.left, f = s.pageY - u.top, m = window.pageYOffset || document.documentElement.scrollTop, TweenMax.to(h, .3, {
                        x: (w - u.width / 2) / u.width * x,
                        y: (f - u.height / 2 - m) / u.height * x,
                        ease: Power2.easeOut
                    })
                }),
                $(".hide-cursor,.btn,.tp-bullets").mouseenter(function (e) {
                    TweenMax.to(".cursor", .2, {borderWidth: "1px", scale: 2, opacity: 0})
                }), $(".hide-cursor,.btn,.tp-bullets").mouseleave(function (e) {
                TweenMax.to(".cursor", .3, {borderWidth: "2px", scale: 1, opacity: 1})
            }), $(".link").mouseenter(function (e) {
                TweenMax.to(".cursor", .2, {
                    borderWidth: "0px",
                    scale: 3,
                    backgroundColor: "rgba(255,255,255,0.27)",
                    opacity: .15
                })
            }), $(".navbar-brand.link").mouseenter(function (e) {
                TweenMax.to(".cursor", .2, {
                    borderWidth: "0px",
                    scale: 3,
                    backgroundColor: "rgba(32,32,32,0.27)",
                    opacity: .15
                })
            }), $(".crumbs .link").mouseenter(function (e) {
                TweenMax.to(".cursor", .2, {
                    borderWidth: "0px",
                    scale: 3,
                    backgroundColor: "rgba(32,32,32,0.27)",
                    opacity: .15
                })
            }), $(".link").mouseleave(function (e) {
                TweenMax.to(".cursor", .3, {
                    borderWidth: "2px",
                    scale: 1,
                    backgroundColor: "rgba(255,255,255,0)",
                    opacity: 1
                })
            })

        }

    }

    if ($(window).width() > 991) {
        setTimeout(function () {
            animatedCursor();
        }, 1000);
    }
    else{
        $('.aimated-cursor').addClass('magic');
    }
    $('header .side-menu').mouseenter(function () {
        $('header ~ .aimated-cursor').addClass('magic');
    });
    $('header .side-menu').mouseleave(function () {
        $('header ~ .aimated-cursor').removeClass('magic');
    });


});
