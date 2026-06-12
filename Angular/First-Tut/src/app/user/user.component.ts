import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-user',
  imports: [],
  templateUrl: './user.component.html',
  styleUrl: './user.component.css'
})
export class UserComponent {
  constructor(private route : ActivatedRoute) {}

  id:number|string|null = "";
  name:string|null = "";
  age:number|string|null ="";
  ngOnInit() {
    this.route.params.subscribe((params=>{
      this.id = params['id'];
      this.name = params['name'];
      this.age = params['age'];
    }))
  }
}
