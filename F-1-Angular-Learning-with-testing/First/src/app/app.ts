import { Component, signal } from '@angular/core';
import { Todo } from './todo/todo';
import { Getset } from './getset/getset';

@Component({
  selector: 'app-root',
  imports: [Todo, Getset],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('First');
}
