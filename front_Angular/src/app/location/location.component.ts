import { Component, OnInit } from '@angular/core';
import {LocationService} from '../services/locationservice'
import {City} from '../models/city'
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

@Component({
  selector: 'app-location',
  templateUrl: './location.component.html',
  styleUrls: ['./location.component.css']
})
export class LocationComponent implements OnInit {

  cities : City;
  locations : Location;
  closeResult = '';
  constructor(private locationService:LocationService,
    private router: Router,private jwtHelper: JwtHelperService) { }

  ngOnInit() {
     this.locationService.getAllCities().subscribe(response => {
      this.cities = <City>response;
    },
    err => {
      console.log("Wrong!")
    });
    this.getLocations();
 
    
  }
  delete(locationId){
    var r = confirm("Are you sure you want to delete?");
    if(r == true){
    this.locationService.deleteLocation(locationId).subscribe(response =>{
      this.getLocations();
    });
  }else{
    console.log("nothing!");
  }
    
  }
  getLocations(){
    this.locationService.getAllLocations().subscribe(response => {
      this.locations = <Location>response
   },
   err => {
     console.log("Wrong!")
   });
  }
  create(){
    this.router.navigate(["createlocation"]);
  }
  back(){
    this.router.navigate([""]);
  }


}
