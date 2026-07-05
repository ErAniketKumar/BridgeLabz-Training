import { Service, signal } from '@angular/core';

@Service()
export class Counter {
  count = signal(0);

  increment() {
    this.count.update((prev) => prev + 1);
  }
  decrement() {
    this.count.update((prev) => prev - 1);
  }

  reset() {
    this.count.set(0);
  }
}
