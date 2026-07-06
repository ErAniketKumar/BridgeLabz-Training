import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-user',
  imports: [],
  templateUrl: './user.html',
  styleUrl: './user.css',
})
export class User {
  constructor(private route: ActivatedRoute) {}
  id = '';
  page='';
  sort='';
  limit='';
  ngOnInit() {
    // this.route.params.subscribe((params) => {
    //   this.id = params['id'];
    //   console.log(this.id);
    // });

    
    this.route.queryParams.subscribe((params)=>{
      this.page=params['page'];
      this.limit=params['limit'];
      this.sort=params['sort'];

    })
  }
}
