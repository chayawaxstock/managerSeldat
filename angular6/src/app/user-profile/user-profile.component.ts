import { Component, OnInit } from '@angular/core';
import { UserService } from '../shared/services/user.service';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.css']
})
export class UserProfileComponent implements OnInit {

  userName:string="";
  departmentName:string="";
  constructor(public userService:UserService) { }

  ngOnInit() {
       this.userName=this.userService.currentUser.userName;
       this.departmentName=this.userService.currentUser.departmentUser.department;
  }

}
