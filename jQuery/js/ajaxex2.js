jQuery.noConflict();
(function ($) {
  API = "https://jsonplaceholder.typicode.com/posts";
  $(document).ready(() => {
    fetchData();
  });

  function renderUI(data) {
    html = "";

    data.forEach((element) => {
      console.log(element);
      html += `
        <span> title:  ${element.title} </span> <br>
        <span> body:  ${element.body} </span>
        <br>
        <br>
      `;
    });

    $("#display").append(html);
  }

  function fetchData() {
    $.ajax({
      url: API,
      method: "GET",
      dataType: "json",
      success: function (response) {
        renderUI(response.slice(0, 10));
      },
      error: function () {
        alert("error");
      },
    });
  }
})(jQuery);
