import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs/internal/Observable';
import {map} from 'rxjs/operators';
import { City } from '../models/city';
import {Location} from '../models/location';
import { LocationService } from '../services/locationservice';


@Component({
  selector: 'app-edit-location',
  templateUrl: './edit-location.component.html',
  styleUrls: ['./edit-location.component.css']
})
export class EditLocationComponent implements OnInit {
  state$: Observable<object>;
  location : any;
  cities : City;
  latitude : any;
  longitude : any;
  objCity : any;
  locationId : string;
  arrivedlocation : any;
  city1 :any;
  constructor(public activatedRoute: ActivatedRoute,private locationService: LocationService,
    private router: Router) { }

  ngOnInit() {
    this.state$ = this.activatedRoute.paramMap
    .pipe(map(() => window.history.state));
    if(window.history.state.location){
    this.arrivedlocation = window.history.state.location
    localStorage.removeItem("locationId");
    localStorage.setItem("locationId",this.arrivedlocation.id);
    this.locationId = this.arrivedlocation.id;
    }else{
      this.locationId = localStorage.getItem("locationId");
    }
    
    this.locationService.getAllCities().subscribe(response => {
      this.cities = <City>response;
      this.getLocation(this.locationId);
    },
    err => {
      console.log("Wrong!")
    });

  }
  selectedCity(cityId){
    debugger;
    this.objCity = Object.values(this.cities).find(x=>x.id == cityId);
    if(this.objCity){
      this.latitude = this.objCity.latitude;
      this.longitude = this.objCity.longitude;
    }

  }
  getLocation(id){
    debugger;
    this.locationService.getLocationById(id).subscribe(response => {
      
      this.location = <any>response;
      this.latitude = Object.values(this.cities).find(x=>x.id == this.location.cityId).latitude;
      this.longitude = Object.values(this.cities).find(x=>x.id == this.location.cityId).longitude;
      this.objCity = Object.values(this.cities).find(x=>x.id == this.location.cityId);
      
     
     },
    err => {
      console.log("Wrong!")
    });
  }
  submit(editForm,locationId){
    
    this.locationService.updateLocationById(editForm.value,locationId).subscribe(response =>{
      this.router.navigate(["location"]);
    });
    
  }
  cancel(){
    this.router.navigate(["location"]);
  }
  onChoseLocation(event){
    debugger;
    console.log(event);
  }

}
