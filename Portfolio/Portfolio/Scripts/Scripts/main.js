$(document).ready(function () {

    //when clicked on Next button then we need to trigger that Event handler
    $('.image-next').on('click', function(){
        //find current active, and next image to display
        //then swipe them
        var activeImage = $(this).parent().find('.image.active');
        var nextImage = activeImage.next();
        
        if (!nextImage.hasClass('image'))
        {
            
            nextImage = $(this).parent().find('.image').first();
        }
        
        //now we have an current active image and the image next to display
        //for that change the active to hide and hide to active
        activeImage.removeClass('active').addClass('hide');
        nextImage.removeClass('hide').addClass('active');

    });

    //$('.image-previous').on('click', function () {
    //    var activeImage = $('.image.active');
    //    var previousImage = activeImage.prev();
        
    //    if (!previousImage.hasClass('image'))
    //    {
            
    //        previousImage = $('.image').last();
    //    }

    //    activeImage.removeClass('active').addClass('hide');
    //    previousImage.removeClass('hide').addClass('active');
    //});



    //Ajax Post for contact form
    $('#contactForm').on('submit', function (event) {
        //prevents the default behaviour
        //doesn't allow it to be submitting
        event.preventDefault();

        //if the form is valid
        if ($(this).valid()) {
            //time to do Ajax post
            var urlToPostTo = $(this).attr('action');
            //serializing converts the form field
            //into a string that we can pass into our
            //post function

            var dataToSend = $(this).serialize();
            //alert(dataToSend)
            $.post(urlToPostTo, dataToSend, function (data) {
                //update the container element with the new html returned in the data param
                $('#container').html(data);
            });

        }
    });
});