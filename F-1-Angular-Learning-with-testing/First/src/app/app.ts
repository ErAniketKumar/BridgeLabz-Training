import { Component, signal } from '@angular/core';
import { Todo } from './todo/todo';
import { Getset } from './getset/getset';
import { Todolist } from './todolist/todolist';
import { Parent } from './parent/parent';
import { DisplayCount } from './display-count/display-count';
import { ControlCount } from './control-count/control-count';
import { CommonModule } from '@angular/common';
import { TrimTextPipe } from './custome-pipe/trim-text-pipe';

@Component({
  selector: 'app-root',
  imports: [Todo, Getset, Todolist, Parent, DisplayCount, ControlCount, CommonModule, TrimTextPipe],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  title = 'hello this is new title for kalawatiputra edu';
  rupees = 10.5;
  date = '07/05/2026';

  heading = signal('this is all about details of heading tag for custome pipes');
}
