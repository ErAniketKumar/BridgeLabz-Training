jQuery.noConflict();

jQuery(document).ready(($) => {
  $("form").submit(function (e) {
    e.preventDefault();
    let name = $("#name").val();
    let email = $("#email").val();
    let password = $("#password").val();
    let gender = $("[name='gender']:checked").val();
    console.log(name, email, password, gender);

    let form = $(this).serialize();

    console.log(form);

    let params = new URLSearchParams(form);

    console.log(params.get("name"));
    console.log(params.get("email"));
    console.log(params.get("password"));
    console.log(params.get("gender"));

    // serialized array

    data = $(this).serializeArray();

    data.forEach((element) => {
      console.log(element.value);
    });

    
  });
});
