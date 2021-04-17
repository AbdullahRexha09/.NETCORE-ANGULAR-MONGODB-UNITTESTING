import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TaskService } from '../services/taskservice';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css']
})
export class TaskComponent implements OnInit {
  task:any;
  constructor(private taskService:TaskService,private router: Router) { }

  ngOnInit(): void {
    this.onLoad();
  }
  create(){
    this.router.navigate(["createtask"]);

  }
  delete(id){
    var txt;
  var r = confirm("Are You Sure!");
  if (r == true) {
  txt = "You pressed OK!";
  this.taskService.delete(id).subscribe(()=>{
    this.onLoad();
  });
} else {
  txt = "You pressed Cancel!";
}
  }
  back(){
    this.router.navigate([""]);
  }
  onLoad(){
    this.taskService.getAllTasks().subscribe((data)=>{
      this.task = data;
    });
  }
  handleClick(id){
    this.taskService.changeStatus(id).subscribe(()=>this.onLoad());
    debugger;
  }

}
