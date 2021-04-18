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
        getAllLists():any{
        const token: string = localStorage.getItem("jwt");
        var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
        return this.http.get(moduleConfig.baserUrl + "api/list/getAllLists", {
            headers: headers_object,
          });
      }
         getListById(id):any{
        const token: string = localStorage.getItem("jwt");
        var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
        return this.http.get(moduleConfig.baserUrl + "api/list/getListById?id="+id, {
            headers: headers_object,
          });
      }
      update(model,id):any{
        const token: string = localStorage.getItem("jwt");
        var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
        return this.http.put(moduleConfig.baserUrl + "api/list/updateList?id="+id,model, {
            headers: headers_object,
          });
      }
        delete(id):any{
        const token: string = localStorage.getItem("jwt");
        var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
        return this.http.delete(moduleConfig.baserUrl + "api/list/delete?id="+id, {
            headers: headers_object,
          });
      }
    }