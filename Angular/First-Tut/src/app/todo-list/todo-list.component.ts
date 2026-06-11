import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-todo-list',
  imports: [FormsModule],
  templateUrl: './todo-list.component.html',
  styleUrl: './todo-list.component.css'
})

export class TodoListComponent {
  task="";
  taskList:{id: number, task: string}[]=[];
  id = 0;
  HandleAddTask(task:string) {
    if (!task.trim()) return;
    this.id++;
    // let taskToBeAdd: {id: number, task:string}= {
    //   id:this.id,
    //   task:task
    // };
    // this.taskList.push(taskToBeAdd);

    this.taskList.push({
      id:this.id,
      task
    });
    
    this.task = "";
  }

  HandleDeleteTask(id:number) {
    this.taskList= this.taskList.filter(task=>task.id!=id);
  }
}
