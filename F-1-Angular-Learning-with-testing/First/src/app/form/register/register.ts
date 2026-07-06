import { CommonModule } from '@angular/common';
import { Component, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { form, FormField } from '@angular/forms/signals';

@Component({
  selector: 'app-register',
  imports: [FormsModule, CommonModule, FormField],
  templateUrl: './register.html',
  styleUrl: './register.css',
})
export class Register {
  // regiterFormHandler(data: NgForm) {
  //   console.log(data);
  // }

  loginFormModel = signal({
    email: '',
    password: '',
  });

  loginForm = form(this.loginFormModel);
  
  submitHandler() {
    console.log(this.loginForm.email().value());
    console.log(this.loginForm.password().value());
  }
}
