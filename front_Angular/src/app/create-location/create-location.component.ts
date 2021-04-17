import { Component, OnInit } from '@angular/core';
import { LocationService } from '../services/locationservice';
import { City } from '../models/city';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-location',
  templateUrl: './create-location.component.html',
  styleUrls: ['./create-location.component.css']
})
export class CreateLocationComponent implements OnInit {
  cities : City;
  latitude : string = '';
  longitude : string = '';
  name : string;
  address : string;
  city : string;
  objCity : any;
  constructor(private locationService : LocationService,private router: Router) { }

  ngOnInit() {
    this.locationService.getAllCities().subscribe(response => {
     this.cities = <City>response;
   },
   err => {
     console.log("Wrong!")
   });
  }
  selectedCity(cityId){
    this.objCity = Object.values(this.cities).find(x=>x.id == cityId);
    if(this.objCity){
      this.latitude = this.objCity.latitude;
      this.longitude = this.objCity.longitude;
    }

  }
  submit(form:NgForm){
    var locationObj = {
      "Name":form.value.name,
      "Address":form.value.address,
      "CityId":this.objCity.id
    }
    this.locationService.postLocation(locationObj).subscribe(response =>{
      this.router.navigate(["location"]);
    });
  }
  cancel(){
    this.router.navigate(["location"]);
  }

}
