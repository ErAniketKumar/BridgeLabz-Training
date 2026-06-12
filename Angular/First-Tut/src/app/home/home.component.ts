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

  studentData = [
    {name:"Aniket", age:20},
    {name:"Kumar", age:21},
    {name:"sonu", age:22},
    {name:"soni", age:23},
  ]
}
