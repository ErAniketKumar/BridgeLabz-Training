import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { subscribeOn, Subscriber } from 'rxjs';

@Component({
  selector: 'app-profile',
  imports: [],
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.css'
})
export class ProfileComponent {

  name:string|null = "";
  age:string|number|null = "";
  id:string|number|null =0;
  constructor(private route:ActivatedRoute) {}
  // ngOnInit():void {
  //   this.id = this.route.snapshot.paramMap.get('id');
  //   this.name = this.route.snapshot.paramMap.get('name');
  //   this.age = this.route.snapshot.paramMap.get('age')
  // }


  ngOnInit() {
    this.route.queryParams.subscribe(params=>{
      this.id = params['id'];
      this.name = params['name'];
      this.age = params['age'];
    });
  }
}
