import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ListService } from '../services/listservice';

@Component({
  selector: 'app-create-list',
  templateUrl: './create-list.component.html',
  styleUrls: ['./create-list.component.css']
})
export class CreateListComponent implements OnInit {
  list: any;
  constructor(private router: Router, private listService: ListService) { }

  ngOnInit(): void {

  }
  submit(model){
    debugger;
    this.list = model.form.value;
     if(this.list){
      if(this.list.Name && this.list.Description){
        this.listService.createList(this.list).subscribe(()=>{
          this.router.navigate(["list"]);
        });
        
      }
      else{
        alert('Provide inputs');
      }
    }
  }
    cancel(){
    this.router.navigate(["list"]);
  }

}
