import { Component, EventEmitter, Input, output, Output, Signal, signal } from '@angular/core';

@Component({
  selector: 'app-child',
  imports: [],
  templateUrl: './child.html',
  styleUrl: './child.css',
})
export class Child {
  @Input() flower: any;
  @Input() users: any;

  @Output()
  messageEvent = new EventEmitter<string>();

  sendData() {
    this.messageEvent.emit('hello parent this is emited from child!');
  }

  dataEvent = output<any[]>();
  
  nusers = signal([
    { id: 1, name: 'Sonu' },
    { id: 2, name: 'Modi' },
    { id: 3, name: 'kapooer' },
  ]);

  sendToParent() {
    this.dataEvent.emit(this.nusers());
  }
}
