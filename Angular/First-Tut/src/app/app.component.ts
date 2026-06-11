import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CounterAppComponent } from "./counter-app/counter-app.component";
import { TodoListComponent } from './todo-list/todo-list.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, CounterAppComponent, TodoListComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'First-Tut';
}
