import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CounterAppComponent } from "./counter-app/counter-app.component";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, CounterAppComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'First-Tut';
  name="Aniket";
  age=20;
}
