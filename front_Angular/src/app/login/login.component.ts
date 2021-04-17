import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from "@angular/router";
import { NgForm } from '@angular/forms';
import { LoginService } from '../services/loginservice';

@Component({
  selector: 'login',
  templateUrl: './login.component.html'
})
export class LoginComponent {
  invalidLogin: boolean;

  constructor(private router: Router, private http: HttpClient,private loginSerivce:LoginService) { }
   login(form: NgForm)  {
     
    const credentials = JSON.stringify(form.value);
    this.loginSerivce.login(credentials).subscribe(response => {
      const token = (<any>response).token;
      const refreshToken = (<any>response).refreshToken;
      localStorage.setItem("jwt", token);
      localStorage.setItem("refreshToken", refreshToken);
      this.invalidLogin = false;
      this.router.navigate(["/"]);
    }, err => {
      this.invalidLogin = true;
    });
  }
}
