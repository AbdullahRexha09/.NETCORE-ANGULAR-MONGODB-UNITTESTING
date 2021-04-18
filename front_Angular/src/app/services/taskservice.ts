import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders} from '@angular/common/http';
import { Router } from "@angular/router";
import {moduleConfig} from '../config/moduleConfig'
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class TaskService {
    constructor(
        private http: HttpClient,private router: Router,private jwtHelper:JwtHelperService) {
    }
    getTaskById(id) : any {
      const token: string = localStorage.getItem("jwt");
      var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
      return this.http.get(moduleConfig.baserUrl + "api/task/getTaskById?id="+id, {
          headers: headers_object,
        });
         
    }
    getTaskByListId(id) : any {
      const token: string = localStorage.getItem("jwt");
      var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
      return this.http.get(moduleConfig.baserUrl + "api/task/getByListId?id="+id, {
          headers: headers_object,
        });
         
    }
    getAllTasks() : any {
        const token: string = localStorage.getItem("jwt");
        var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
        return this.http.get(moduleConfig.baserUrl + "api/task/getAllTasks", {
            headers: headers_object,
          });
           
      }
      createTask(taskModel):any{
        const token: string = localStorage.getItem("jwt");
        var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
        return this.http.post(moduleConfig.baserUrl + "api/task/createTask",taskModel, {
            headers: headers_object,
          });
      }
      delete(id):any{
        const token: string = localStorage.getItem("jwt");
        var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
        return this.http.delete(moduleConfig.baserUrl + "api/task/delete?id="+id, {
            headers: headers_object,
          });
      }
    //   changeStatus(id):any{
    // const token: string = localStorage.getItem("jwt");
    //     var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
    //     return this.http.post(moduleConfig.baserUrl + "api/task/chngstatus?id="+id, {
    //         headers: headers_object,
    //       });
    //   }
      changeStatus(id):any{
        const token: string = localStorage.getItem("jwt");
        var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
        return this.http.put(moduleConfig.baserUrl + "api/task/chngstatus?id="+id, {
            headers: headers_object,
          });
      }
      update(model,id):any{
        const token: string = localStorage.getItem("jwt");
        var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
        return this.http.put(moduleConfig.baserUrl + "api/task/updateTask?id="+id,model, {
            headers: headers_object,
          });
      }

}