import { Component, EventEmitter, Input, Output } from '@angular/core';

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

  
}
