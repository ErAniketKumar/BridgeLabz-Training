import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-profile',
  imports: [],
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.css'
})
export class ProfileComponent {

  name:string|null = "";
  age:string|number|null = "";

  constructor(private route:ActivatedRoute) {}
  ngOnInit():void {
    this.name = this.route.snapshot.paramMap.get('name');
    this.age = this.route.snapshot.paramMap.get('age')
  }
}
