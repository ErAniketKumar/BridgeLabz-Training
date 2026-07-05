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
}
