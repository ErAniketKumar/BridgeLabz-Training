import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { CounterAppComponent } from './counter-app/counter-app.component';
import { TodoListComponent } from './todo-list/todo-list.component';
import { HeaderComponentComponent } from './header-component/header-component.component';
import { UserComponent } from './user/user.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HeaderComponentComponent, UserComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  // title = 'First-Tut';
  // userName = 'hello dymanic data passed!';

  // userData = {
  //   name: 'Kumar',
  //   age: 20,
  //   'Roll No': 1054,
  // };

  students = [
    {
      id: 1,
      name: 'Aniket',
      age: 20,
      course: 'cse',
    },
    {
      id: 2,
      name: 'kumar',
      age: 22,
      course: 'Ai/ml',
    },
    {
      id: 3,
      name: 'Sonu',
      age: 20,
      course: 'B.pharm',
    },
    {
      id: 4,
      name: 'Archi',
      age: 20,
      course: 'B.Sc',
    },
  ];
}
