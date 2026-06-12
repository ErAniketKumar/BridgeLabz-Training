import { Component } from '@angular/core';
import { FormControl, FormsModule, ReactiveFormsModule } from "@angular/forms";

@Component({
  selector: 'app-login',
  imports: [ReactiveFormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  username = new FormControl();
  password = new FormControl();


  HandleLoginForm() {
    console.log(this.username.value, this.password.value);
  }


  HandleSetDefaultValue() {
    this.username.setValue("Aniket");
    this.password.setValue("password123");
  }

}
