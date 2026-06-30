jQuery.noConflict();

jQuery(document).ready(function ($) {
  let tasks = [];
  let idx = 1;

  // Show all tasks
  function renderTasks() {
    let html = "";

    tasks.forEach(function (task) {
      html += `
                <div class="task" data-id="${task.id}">

                    <div>

                        <input
                            type="checkbox"
                            class="check-task"
                            ${task.completed ? "checked" : ""}
                        >

                        <span class="${task.completed ? "completed" : ""}">
                            ${task.title}
                        </span>

                    </div>

                    <div>
                        <button class="edit-btn">Edit</button>
                        <button class="delete-btn">Delete</button>
                    </div>

                </div>
            `;
    });

    $("#show-result").html(html);
  }

  // Add Task
  $("#todo-form").submit(function (e) {
    e.preventDefault();

    let title = $("#task").val().trim();

    if (title === "") return;

    tasks.push({
      id: idx++,
      title: title,
      completed: false,
    });

    $("#task").val("");

    renderTasks();
  });

  // Delete Task
  $("#show-result").on("click", ".delete-btn", function () {
    let id = $(this).closest(".task").data("id");

    tasks = tasks.filter(function (task) {
      return task.id != id;
    });

    renderTasks();
  });

  // Edit Task
  $("#show-result").on("click", ".edit-btn", function () {
    let id = $(this).closest(".task").data("id");

    let task = tasks.find(function (task) {
      return task.id == id;
    });

    let newTitle = prompt("Edit Task", task.title);

    if (newTitle === null) return;

    newTitle = newTitle.trim();

    if (newTitle === "") return;

    task.title = newTitle;

    renderTasks();
  });

  // Complete Task
  $("#show-result").on("change", ".check-task", function () {
    let id = $(this).closest(".task").data("id");

    let task = tasks.find(function (task) {
      return task.id == id;
    });

    task.completed = this.checked;

    renderTasks();
  });
});
