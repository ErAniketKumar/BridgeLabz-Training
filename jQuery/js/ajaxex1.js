jQuery.noConflict();

(function ($) {
  jQuery(document).ready(function () {
    getData();
  });

  function getData() {
    $.ajax({
      url: "../html/hello.html",
      type: "GET",

      dataType: "text",

      success: successFun,

      error: errorFun,

      complete: function () {
        console.log("Request Completed");
      },
    });
  }

  function successFun(result) {
    console.log("Success");

    $("#display").append(result);
  }

  function errorFun(xhr, status, error) {
    console.log(status);

    console.log(error);
  }
})(jQuery);
