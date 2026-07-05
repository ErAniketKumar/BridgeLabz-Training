import { Component, signal } from '@angular/core';
import { Todo } from './todo/todo';
import { Getset } from './getset/getset';
import { Todolist } from './todolist/todolist';

@Component({
  selector: 'app-root',
  imports: [Todo, Getset, Todolist],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('First');
}
