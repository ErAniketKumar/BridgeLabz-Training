import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-counter-app',
  imports: [FormsModule],
  templateUrl: './counter-app.component.html',
  styleUrl: './counter-app.component.css'
})
export class CounterAppComponent {
  count=0;
  HandleDecrement() {
    this.count-=1;
  }
  HandleIncrement() {
    this.count+=1;
  }

  HandleReset() {
    this.count = 0;
  }

isHide = 1;
textTitle = "Hide";

ShowHideHandler() {
  this.isHide = this.isHide ? 0 : 1;
  this.textTitle = this.isHide ? "Hide" : "Show";
}


arr: string[] = ["hello", "Aniket", "Kumar"];

HandleGetItem(index:number) {
  console.log(index);
}
  name="";
  
}
