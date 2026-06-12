import { Component } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule } from "@angular/forms";

@Component({
  selector: 'app-login',
  imports: [ReactiveFormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  // username = new FormControl();
  // password = new FormControl();


  // HandleLoginForm() {
  //   console.log(this.username.value, this.password.value);
  // }


  // HandleSetDefaultValue() {
  //   this.username.setValue("Aniket");
  //   this.password.setValue("password123");
  // }

    loginForm = new FormGroup({
      username: new FormControl(),
      email: new FormControl(),
      password: new FormControl()
    })

    HandleFormSubmit() {
      console.log(this.loginForm.value);
      console.log(this.loginForm.value.username);
    }
}
