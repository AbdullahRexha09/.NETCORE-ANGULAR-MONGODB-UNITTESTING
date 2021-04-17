import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders} from '@angular/common/http';
import { Router } from "@angular/router";
import {moduleConfig} from '../config/moduleConfig'
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
    invalidLogin: boolean;
    invalidRegister : boolean;
    token: string = localStorage.getItem("jwt");
  constructor(
      private http: HttpClient,private router: Router,private jwtHelper:JwtHelperService) {
  }
  login(credentials: any) : any {
    return this.http.post(moduleConfig.baserUrl + "api/auth/login", credentials, {
        headers: new HttpHeaders({
          "Content-Type": "application/json"
        })
      });
       
  }
  register(credentials:any): any{
    return this.http.post(moduleConfig.baserUrl + "api/auth/register", credentials, {
        headers: new HttpHeaders({
          "Content-Type": "application/json"
        })
      });
  }




}
