import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { ReactiveFormsModule, FormControl, FormGroup, Validators } from '@angular/forms';
import { minLength } from '@angular/forms/signals';

@Component({
  selector: 'app-profile',
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './profile.html',
  styleUrl: './profile.css',
})
export class Profile {
  // email = new FormControl('');
  // password = new FormControl('');
  // gender = new FormControl('');

  // submitHandler() {
  //   console.log(this.email.value);
  //   console.log(this.password.value);
  //   console.log(this.gender.value);
  // }

  name = '';
  email = '';
  password = '';
  age = 0;

  form = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.minLength(5)]),

    email: new FormControl('', [Validators.required, Validators.email]),

    password: new FormControl('', [
      Validators.required,
      Validators.minLength(4),
      Validators.maxLength(16),
    ]),

    range: new FormControl(''),

    gender: new FormControl('male', [Validators.required]),

    age: new FormControl('', [Validators.required, Validators.min(18), Validators.max(80)]),
  });

  submitHandler() {
    console.log(this.form.value);
  }
}
