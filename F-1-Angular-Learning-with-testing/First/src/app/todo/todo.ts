import { Component, computed, effect, signal } from '@angular/core';

@Component({
  selector: 'app-todo',
  imports: [],
  templateUrl: './todo.html',
  styleUrl: './todo.css',
})
export class Todo {
  count: number = 0;
  Increment() {
    this.count += 1;
  }

  Decrement() {
    this.count -= 1;
  }

  value = signal(0);

  counterFun(action: string) {
    if (action == 'Inc') {
      this.value.update((prev) => prev + 1);
    } else {
      this.value() > 0 && this.value.update((prev) => prev - 1);
    }
  }

  fname = signal('Aniket');
  lname = signal('Kumar');

  fullName = computed(() => {
    return this.fname() + this.lname();
  });

  speed = signal(0);

  color = 'black';
  IncreaseSpeed() {
    this.speed.update((prev) => prev + 20);
  }

  DecreaseSpeed() {
    this.speed() > 0 && this.speed.update((prev) => prev - 20);
  }

  constructor() {
    effect(() => {
      this.color = 'green';
      if (this.speed() >= 80 && this.speed() <= 120) {
        this.color = 'orange';
      } else if (this.speed() > 120) {
        this.color = 'red';
      }
    });
  }
}
