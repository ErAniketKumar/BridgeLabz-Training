import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { CounterAppComponent } from "./counter-app/counter-app.component";
import { TodoListComponent } from './todo-list/todo-list.component';
import { HeaderComponentComponent } from "./header-component/header-component.component";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, HeaderComponentComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'First-Tut';
}
