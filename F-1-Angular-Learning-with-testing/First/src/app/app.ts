import { Component, signal } from '@angular/core';
import { Todo } from './todo/todo';
import { Getset } from './getset/getset';
import { Todolist } from './todolist/todolist';
import { Parent } from './parent/parent';

@Component({
  selector: 'app-root',
  imports: [Todo, Getset, Todolist, Parent],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('First');
}
