import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders} from '@angular/common/http';
import { Router } from "@angular/router";
import {moduleConfig} from '../config/moduleConfig'
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class UserService {
    constructor(
        private http: HttpClient,private router: Router,private jwtHelper:JwtHelperService) {
    }
    getUserByJwt() : any {
        const token: string = localStorage.getItem("jwt");
        var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
        return this.http.get(moduleConfig.baserUrl + "api/user/getUserByJwt?jwt="+token, {
            headers: headers_object,
          });
           
      }
      updateUser(model,id):any{
        const token: string = localStorage.getItem("jwt");
        var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
        return this.http.put(moduleConfig.baserUrl + "api/user/updateUser?id="+id,model, {
            headers: headers_object,
          });
      }
}