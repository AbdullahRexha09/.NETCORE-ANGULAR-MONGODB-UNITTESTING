import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ListService} from '../services/listservice'
import { TaskService} from '../services/taskservice'

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {
  list:any;
  assignedTasks:any;
  constructor(private router:Router, private listService: ListService, 
  private taskService: TaskService) { }
//getTaskByListId
  ngOnInit(): void {
    this.onLoad();
  }
  create(){
    this.router.navigate(["createlist"]);
  }
  edit(id){
        sessionStorage.setItem("listid",id);
        this.router.navigate(["editlist"]);
  }
  back(){
    this.router.navigate([""]);
  }
   onLoad(){
    this.listService.getAllLists().subscribe((data)=>{
      debugger;
      this.list = data;
    });
    sessionStorage.setItem('listid','');
  }
  delete(id){
        var txt;
  var r = confirm("Are You Sure!");
  if (r == true) {
  txt = "You pressed OK!";
    this.listService.delete(id).subscribe(()=> this.onLoad());
} else {
  txt = "You pressed Cancel!";
}
  }

}
