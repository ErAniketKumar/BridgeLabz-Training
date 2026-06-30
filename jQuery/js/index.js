

jQuery.noConflict();
jQuery(document).ready(($)=>{
    // $("#btn").click(()=>{
    //     alert("hello");
    // })

    // //selector -tag
    // $("div").click(function (e) { 
    //     console.log("div clicked select by tag!")
    // });

    // // selector -id
    // $("#f-para").mouseenter(()=>{
    //     console.log("mouse enter");
    // })

    // $(".classtag").mouseenter(()=>{
    //     console.log("mouse enter");
    // })


// mouse event
    // $("#f-para").mouseenter(()=>{
    //     console.log("mouse enter");
    // })


    // $("#f-para").mouseleave(()=>{
    //     console.log("mouse leave");
    // })
    
    // $("#f-para").mousedown(function () { 
    //     console.log("mouse down")
    // });

    // $("#f-para").mousemove(function (e) { 
    //     console.log("mouse move")
    // });

    // $("#f-para").mouseout(function () { 
    //     console.log("mouse out")
    // });

    
// keyboard events

    // $("#in-name").keypress(function (e) { 
    //     console.log("key pressed");
    // });

    // $("#in-name").keyup(function (e) { 
    //     console.log("key-up");
    // });

    // $("#in-name").keydown(function (e) { 
    //     console.log("key-down");
    // });

    // form event

    // $("#f-email").focus(function (e) { 
    //     e.preventDefault();
    //     console.log("focus event")
    // });

    // $("form").submit(function (e) { 
    //     e.preventDefault();
    //     console.log("form submit!");
    // });

    // $(window).resize(function () { 
    //     console.log("window resize!");
    // });

    $("#show-btn").click(()=>{
        $(".img-1").show(1000);
    });

     $("#hide-btn").click(()=>{
        $(".img-1").hide(1000);
    });


    $(".togle-btn").click(function (e) { 
        $(".img-1").toggle(500);
    });

    

})