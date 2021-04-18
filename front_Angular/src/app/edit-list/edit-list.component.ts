import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ListService } from '../services/listservice';
@Component({
  selector: 'app-edit-list',
  templateUrl: './edit-list.component.html',
  styleUrls: ['./edit-list.component.css']
})
export class EditListComponent implements OnInit {
  listId:string = sessionStorage.getItem('listid');
  list: any;
  updatedList:any;
  constructor(private listService: ListService, private router: Router) { }

  ngOnInit(): void {
      this.listService.getListById(this.listId).subscribe((data)=>{
      this.list = data;
    })
  }
  submit(model,id){
    debugger;
    this.updatedList = model.form.value;
    this.listService.update(this.updatedList,id).subscribe(()=> this.cancel());
  }
  cancel(){
    this.router.navigate(["list"]);
  }

}
