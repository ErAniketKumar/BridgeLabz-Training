import { Component, signal } from '@angular/core';

type Task = {
  id: number;
  title: string;
};
@Component({
  selector: 'app-todolist',
  imports: [],
  templateUrl: './todolist.html',
  styleUrl: './todolist.css',
})
export class Todolist {
  id = 1;

  task = signal('');
  tasks = signal<Task[]>([]);

  addTaskBtn() {
    this.tasks.update((prev) => [
      ...prev,
      {
        id: this.id++,
        title: this.task(),
      },
    ]);
    this.task.set('');
  }

  deleteHandler(id: number | string) {
    id = Number(id);
    this.tasks.update((prev) =>
      prev.filter((item) => {
        return item.id != id;
      }),
    );
  }

  editHandler(id: number | string) {
    id = Number(id);
    const newTask = prompt('enter task tile');

    this.tasks.update((prev) =>
      prev.map((item) =>
        item.id == id
          ? {
              ...item,
              title: newTask!,
            }
          : item,
      ),
    );
  }
}
