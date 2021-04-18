import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders} from '@angular/common/http';
import { Router } from "@angular/router";
import {moduleConfig} from '../config/moduleConfig'
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class ListService {
    constructor(
        private http: HttpClient,private router: Router,private jwtHelper:JwtHelperService) {
    }
  createList(listModel):any{
        const token: string = localStorage.getItem("jwt");
        var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
        return this.http.post(moduleConfig.baserUrl + "api/list/createList",listModel, {
            headers: headers_object,
          });
      }
    }