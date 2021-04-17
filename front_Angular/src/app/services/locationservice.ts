import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders} from '@angular/common/http';
import { Router } from "@angular/router";
import { moduleConfig } from '../config/moduleConfig';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class LocationService {
  
  constructor(
      private http: HttpClient,private router: Router,private jwtHelper : JwtHelperService) {
  }

 getAllCities() {
   const token: string = localStorage.getItem("jwt");
   var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
  return this.http.get(moduleConfig.baserUrl + "api/location/getAllCities", {
    headers: headers_object,
  });
 }
 getAllLocations(){
  const token: string = localStorage.getItem("jwt");
  var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
  return this.http.get(moduleConfig.baserUrl + "api/location/getAllLocations", {
    headers: headers_object,
  });
 }
 deleteLocation(locationId){
  const token: string = localStorage.getItem("jwt");
  var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
  return this.http.delete(moduleConfig.baserUrl + "api/location/deleteLocation" + "?id=" + locationId, {
    headers: headers_object,
  });
 }
 postLocation(model){
  const token: string = localStorage.getItem("jwt");
  var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
    return this.http.post(moduleConfig.baserUrl + "api/location/postLocation", model, {
        headers: headers_object,
      });
  }
  getLocationById(id){
    const token: string = localStorage.getItem("jwt");
    var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
      return this.http.get(moduleConfig.baserUrl + "api/location/getLocationById" + "?id=" + id, {
          headers: headers_object,
        });
  }
  updateLocationById(model,id){
    const token: string = localStorage.getItem("jwt");
    var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
      return this.http.put(moduleConfig.baserUrl + "api/location/putLocation" + "?id=" + id, model, {
          headers: headers_object,
        });
  }
}
