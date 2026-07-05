import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-getset',
  imports: [],
  templateUrl: './getset.html',
  styleUrl: './getset.css',
})
export class Getset {
  value = signal('');
  setValueFun() {
    this.value.set('Jai Mata Di!');
  }

  setValue(val: string) {
    this.value.set(val);
  }

  data = signal([
    { id: 1, name: 'Aniket', age: 21 },
    {
      id: 2,
      name: 'kumar',
      age: 22,
    },
    {
      id: 3,
      name: 'Rahul',
      age: 20,
    },
    {
      id: 4,
      name: 'Sumit',
      age: 23,
    },
  ]);

  day = signal(0);

  showDay(day: string) {
    this.day.set(Number(day));
  }
}
