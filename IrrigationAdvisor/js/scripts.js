(function($) {
    "use strict";
    function main() {
        mobilecheck();
        mdselect();
        Learning();
        scrollStyle();

        $(".feature-slider").owlCarousel({
            autoPlay: 10000,
            items: 4,
            itemsDesktop : [1199,4],
            itemsDesktopSmall : [979,3],
            itemsTablet: [768,2],
            itemsTabletSmall: [600,1],
            slideSpeed: 300,
            navigation: true,
            pagination: false,
            navigationText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"]
        });



       

        /*  Account */

        var $toggleList = $('.list-account-info .list-item .toggle-list');
        $('html').on('click', function() {
            $toggleList.stop().removeClass('toggle-message-add');
            $('.list-account-info .item-click').stop().removeClass('active-ac');
        });
        $('.list-account-info .list-item').on('click', function(event) {
            event.stopPropagation();
        });
        $('.list-account-info .item-click').on('click', function(event) {
            if ($(this).hasClass('active-ac') == false) {
                $('.list-account-info .item-click').removeClass('active-ac');
                $toggleList.stop().removeClass('toggle-message-add');
            }
            $(this).toggleClass('active-ac');
            $(this).siblings('.toggle-list')
                .stop()
                .toggleClass('toggle-message-add');
            
        });

        $.each($('.content-bar'), function() {
            var widthList = $(this).find('li').outerWidth(),
                totalList = $(this).find('li').length;
            $(this).find('ul').width(widthList * totalList + 20);
        });
        

       

       
        /*  FOOTER  */
        var $footerStyle2 = $('footer#footer.footer-style-2'),
            heightFooter =  $footerStyle2.height();
        $footerStyle2.appendTo('body');
        $footerStyle2.siblings('#page-wrap').css('marginBottom', heightFooter);


        $('.question-sidebar ul, .list-message, .list-notification').wrap('<div class="list-wrap"></div>');
    }

    function mobilecheck() {
        if( /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent) ) {
            return false;
        }
        return true;
    }

    function formCheckoutCal() {
        var heightWindow = $(window).height(),
            heightForm = $('.form-checkout .container').height(),
            formMiddle = (heightWindow - heightForm) / 2;
        $('.form-checkout').css('top', formMiddle);
        $('.form-checkout .form-body').height($(".form-checkout fieldset").height());
    }

    /*==============================
        MC SELECT
    ==============================*/
    function mdselect() {
        $('.mc-select').find('select.select').each(function() {
            var selected = $(this).find('option:selected').text();
            $(this)
                .css({'z-index':10,'opacity':0,'-khtml-appearance':'none'})
                .after('<span class="select">' + selected + '</span>' + '<i class="fa fa-angle-down"></i>')
                .change(function(){
                    var val = $('option:selected',this).text();
                    $(this).next().text(val);
                });
        });
    }
function Learning() {
        var $navListBody = $('.top-nav-list').find('.list-item-body');
        var width = $navListBody.closest('.top-nav-list').width() - 1;
        $navListBody.width(width);
        if ($('.top-nav-list').children('li').hasClass('active')) {
            $('.learning-section')
                .toggleClass('learning-section-fly')
                .css('paddingRight', width);
        }
        $('.top-nav-list').find('.outline-learn, .discussion-learn, .note-learn').on('click', '> a', function(e) {
            e.preventDefault();
            if ($(this).parent().hasClass('active') == false) {
                $('.top-nav-list').children('li').removeClass('active');
            }
            $(this).parent().toggleClass('active');
            if ($(this).parent().hasClass('active')) {
                $('.learning-section')
                    .toggleClass('learning-section-fly')
                    .css('paddingRight', width);
            } else {
                $('.learning-section')
                    .removeClass('learning-section-fly')
                    .css('paddingRight', '0');
            }
        });
        $('html').on('click', function() {
            $navListBody.removeClass('item-fly');
            $navListBody.parent('li').removeClass('active');
            $('.learning-section')
                .removeClass('learning-section-fly')
                .css('paddingRight', '0');
        });
        $('.top-nav-list, .list-item-body').on('click', function(event) {
            event.stopPropagation();
        });
    }
    function setHeightRespon() {
        var windowHeight = $(window).height(),
            w = window.innerWidth;
        $('.learn-section').css('min-height', windowHeight);

        if (w < 992) {
            $('.question-content-wrap').find('.question-sidebar').height('auto');
            $('.question-content-wrap').find('.score-sb').find('.list-wrap').height('auto').css('max-height', '300px');
        } else if (w >= 992) {
            var height = $('.question-content-wrap').find('.question-content').height() + 30;
            var heightUl = height - 90;
            $('.question-content-wrap').find('.score-sb').find('.list-wrap').height(heightUl).css('max-height', 'none');
            $('.question-content-wrap').find('.question-sidebar').height(height);
        }
    }

    function scrollbar() {
        if (mobilecheck()) {
            var $scrollbar = $('.question-sidebar .list-wrap, .list-wrap,  .list-wrap,  .list-wrap, .list-item-body, .table-wrap .tbody');
            $scrollbar.perfectScrollbar({
                maxScrollbarLength: 150,
            });
            $scrollbar.perfectScrollbar('update');

            $('.content-bar').perfectScrollbar({
                maxScrollbarLength: 150,
                suppressScrollY: true,
                useBothWheelAxes: true,
            });
            $('.content-bar').perfectScrollbar('update');
        }
        $('.content-bar').perfectScrollbar({
            maxScrollbarLength: 150,
            suppressScrollY: true,
            useBothWheelAxes: true,
        });
        $('.content-bar').perfectScrollbar('update');
    }
    function scrollStyle() {
        scrollbar();
        $(window).on('load', function() {
            if ($('.content-bar').length > 0) {
                var  currentPosition =$('.content-bar').find('.current').position().left;
                var  prevCurrentWidth =$('.content-bar').find('.current').prev().width();
                setTimeout(function() {
                    $('.content-bar').animate({
                        scrollLeft: currentPosition - prevCurrentWidth
                    }, 400);
                }, 100);
            }
        });
    }

    function uploadFile() {
        $('.up-file').delegate('a', 'click', function(e) {
            e.preventDefault();
            $(this).siblings('input[type="file"]').trigger('click');
        });
        $('.up-file').delegate('input[type="file"]', 'change', function() {
            var nameFile = $(this).val().replace(/\\/g, '/').replace(/.*\//, '');
            $(this).siblings('input[type="hidden"]').val(nameFile);
            readURL(this);
        });
        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('.changes-avatar')
                        .find('img')
                            .attr('src', e.target.result)
                            .width(140);
                };
                reader.readAsDataURL(input.files[0]);
            }
        }
    }

    /*  Slider */
    function SliderHome(){
        if($('#slide-home').length){
            $('#slide-home').owlCarousel({
                autoPlay: 10000,
                navigation: false,
                pagination: true,
                singleItem: true,
                mouseDrag:false,
                addClassActive:true,
                transitionStyle:'fade'
            });
        }
    }

    /* Slider */
    function ResizeSliderHome() {
        if($('#slide-home')) {
            var parentWidth = $('.slide-cn').innerWidth(),
              imgWidth = $('.item-inner').width(),
              imgHeight = $('.item-inner').height(),
              scale = parentWidth/imgWidth,
              ratio = imgWidth/imgHeight,
              heightItem = parentWidth/ratio;

          $('.slide-item').css({'height': heightItem});

          if ($(window).width() <= 1200) {

            $('.item-inner').css({
              '-webkit-transform': 'scale(' + scale + ')',
              '-moz-transform': 'scale(' + scale + ')',
              '-ms-transform': 'scale(' + scale + ')',
              'transform': 'scale(' + scale + ')'
            });

          } else {

            $('.item-inner').css({
                '-webkit-transform': 'scale(1)',
                '-moz-transform': 'scale(1)',
                '-ms-transform': 'scale(1)',
                'transform': 'scale(1)'
            });

          }
      }
    }
         

    $(document).ready(function() {
        main();
        setHeightRespon();
        uploadFile();
       
        scrollbar();
        $('.nav-tabs').wrap('<div class="nav-tabs-wrap"></div>');

        if (window.innerWidth < 1200) {
            $('.menu-item-has-children').on('click', '> a', function(evt) {
                evt.preventDefault();
                $(this).next().slideToggle(300);
                $(this).toggleClass('mobile-active');
            });
            $('.open-menu').on('click', function() {
                $(this).toggleClass('toggle-active');
                $('.navigation .menu, .search-box').slideToggle(300);
            });
            $('html').on('click', function() {
                $('.open-menu').removeClass('toggle-active');
                $('.navigation .menu, .search-box').slideUp(300);
            });
            $('.navigation .menu, .open-menu, .search-box').on('click', function(evt) {
                evt.stopPropagation();
            });
        }
    });
    $(window).load(function() {
        ResizeSliderHome();
    });

    $(window).on('resize', function() {
        setHeightRespon();
      
        scrollbar();
        SliderHome();
        formCheckoutCal();
        ResizeSliderHome();
    }).trigger('resize');;
    

})(jQuery);