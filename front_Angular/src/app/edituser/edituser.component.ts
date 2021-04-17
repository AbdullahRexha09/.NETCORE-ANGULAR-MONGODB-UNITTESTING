import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { UserService } from '../services/userservice';

@Component({
  selector: 'app-edituser',
  templateUrl: './edituser.component.html',
  styleUrls: ['./edituser.component.css']
})
export class EdituserComponent implements OnInit {
  userObject: any;
  userUpdObj:any;
  constructor(private router: Router,private userService : UserService) { }

  ngOnInit(): void {
    this.userService.getUserByJwt().subscribe((obj)=>{
      this.userObject = obj;
    })
  }
  updateUser(form: NgForm){
    this.userUpdObj = form.value;
    this.userService.updateUser(this.userUpdObj,this.userObject.id).subscribe();
    this.router.navigate([""]);

  }

}
