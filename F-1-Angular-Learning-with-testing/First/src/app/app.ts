import { Component, signal } from '@angular/core';
import { Todo } from './todo/todo';
import { Getset } from './getset/getset';
import { Todolist } from './todolist/todolist';
import { Parent } from './parent/parent';
import { DisplayCount } from './display-count/display-count';
import { ControlCount } from './control-count/control-count';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [Todo, Getset, Todolist, Parent, DisplayCount, ControlCount, CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  title = 'hello this is new title for kalawatiputra edu';

  rupees = 10.5;
  date = '07/05/2026';
}
