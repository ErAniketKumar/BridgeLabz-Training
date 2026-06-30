jQuery.noConflict();

jQuery(document).ready(($) => {
  let tasks = [];
  let idx = 0;
  let taskHtml = "";

  $("#todo-form").submit(function (e) {
    e.preventDefault();

    let data = $("#task").val();
    $("#task").val("");

    let obj = {
      title: data,
      id: idx++,
      status: "pending",
    };
    tasks.push(obj);

    taskHtml = `
          <div style="display:flex">
          <span> ${obj["title"]}</span>
          <input type="checkbox">
          <div>
          <button>edit</button>
          <button>del</button>
          </div>
          </div>
          `;
    $("#show-result").append(taskHtml);
  });

  

});
