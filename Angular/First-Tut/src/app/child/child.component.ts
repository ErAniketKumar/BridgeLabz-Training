import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  imports: [],
  templateUrl: './child.component.html',
  styleUrl: './child.component.css',
})
export class ChildComponent {
  blogs = [
    {
      id: 1,
      title: 'first bogs',
      body: 'this is a body for first blogs',
    },
    {
      id: 2,
      title: 'second bogs',
      body: 'this is a body for second blogs',
    },
    {
      id: 3,
      title: 'third bogs',
      body: 'this is a body for third blogs',
    },
  ];

  @Output() hadleChildFun = new EventEmitter();

  ngOnInit() {
    this.hadleChildFun.emit(this.blogs);
  }
}
