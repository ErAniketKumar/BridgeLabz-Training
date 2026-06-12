import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { RouterLink } from "@angular/router";

@Component({
  selector: 'app-home',
  imports: [NgFor, RouterLink],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

  // studentData = [
  //   {id: 1,name:"Aniket", age:20},
  //   {id:2,name:"Kumar", age:21},
  //   {id:3,name:"sonu", age:22},
  //   {id:4,name:"soni", age:23},
  // ]


  users = [
    {id: 1,name:"Aniket", age:20},
    {id:2,name:"Kumar", age:21},
    {id:3,name:"sonu", age:22},
    {id:4,name:"soni", age:23},
  ]
}
