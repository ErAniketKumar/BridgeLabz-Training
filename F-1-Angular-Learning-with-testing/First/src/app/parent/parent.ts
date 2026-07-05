import { Component, Signal, signal, WritableSignal } from '@angular/core';
import { Child } from '../child/child';

@Component({
  selector: 'app-parent',
  imports: [Child],
  templateUrl: './parent.html',
  styleUrl: './parent.css',
})
export class Parent {
  flower = signal('rose');

  users = signal([
    { id: 1, name: 'Aniket', age: 20 },
    { id: 2, name: 'Kumar', age: 22 },
    { id: 3, name: 'Abhishek', age: 19 },
  ]);

  message = '';
  receiveMessage(message: string) {
    this.message = message;
  }

  dataFromChild = signal<any>([]);

  received(data: any[]) {
    this.dataFromChild.set(data);
  }
}
