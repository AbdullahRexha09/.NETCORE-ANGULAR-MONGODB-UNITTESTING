import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import {LoginService} from '../services/loginservice';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html'
})
export class RegisterComponent  {
  invalidRegister:boolean;
  constructor(private router: Router, private http: HttpClient,private loginSerivce : LoginService) { }
   register(form: NgForm) {
    if(this.ValidateEmail(form.value.email)){
    const credentials = JSON.stringify(form.value);
    this.loginSerivce.register(credentials).subscribe(response => {
      this.invalidRegister = false;
      this.router.navigate(["/"]);
    }, err => {
       this.invalidRegister = true;
    });;
  }
}
 ValidateEmail(mail:any) 
{
 if (/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/.test(mail))
  {
    return (true)
  }
    alert("You have entered an invalid email address!")
    return (false)
}

 

}
