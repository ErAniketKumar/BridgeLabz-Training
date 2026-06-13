import { NgFor } from '@angular/common';
import { Component, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { StudentDetailsComponent } from '../student-details/student-details.component';

@Component({
  selector: 'app-user',
  standalone: true,
  imports: [StudentDetailsComponent],
  templateUrl: './user.component.html',
  styleUrl: './user.component.css',
})
export class UserComponent {
  // constructor(private route : ActivatedRoute) {}

  // id:number|string|null = "";
  // name:string|null = "";
  // age:number|string|null ="";
  // ngOnInit() {
  //   this.route.params.subscribe((params=>{
  //     this.id = params['id'];
  //     this.name = params['name'];
  //     this.age = params['age'];
  //   }))
  // }

  // @Input() user: string = '';

  // @Input() users: any;

  // @Input() name: string = '';
  // @Input() city: string = '';

  @Input() students: any;
}
