import {City} from '../models/city'
export class Location{
    constructor(
        public LocationId:string,
        public Name:string,
        public Address:string,
        public CityId:string,
        public City:City,
    ){}
}