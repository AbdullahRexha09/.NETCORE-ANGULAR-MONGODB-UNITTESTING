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
  edit(id){
    sessionStorage.setItem("taskid",id);
    this.router.navigate(["edittask"]);

  }
  back(){
    this.router.navigate([""]);
  }
  onLoad(){
    this.taskService.getAllTasks().subscribe((data)=>{
      this.task = data;
    });
    sessionStorage.setItem('taskid','');
  }
  handleClick(id){
    this.taskService.changeStatus(id).subscribe(()=>this.onLoad());
  }
  formatDate(date)
  {
    if(!date)
      return '';
  
      var d = new Date(date),
      month = '' + (d.getMonth() + 1),
      day = '' + d.getDate(),
      year = d.getFullYear();
  
    if (month.length < 2) 
      month = '0' + month;
    if (day.length < 2) 
      day = '0' + day;
  
    return [day, month, year].join('-');
  }

}
