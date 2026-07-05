import { Component } from '@angular/core';
import { Counter } from '../service/counter';

@Component({
  selector: 'app-control-count',
  imports: [],
  templateUrl: './control-count.html',
  styleUrl: './control-count.css',
})
export class ControlCount {
  constructor(public state: Counter) {}
}
