import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { debug } from 'console';
import { TaskService } from '../services/taskservice';

@Component({
  selector: 'app-edittask',
  templateUrl: './edittask.component.html',
  styleUrls: ['./edittask.component.css']
})
export class EdittaskComponent implements OnInit {
  taskId:string = sessionStorage.getItem('taskid');
  task:any;
  updatedTask:any;
  constructor(private taskService: TaskService, private router: Router) { }

  ngOnInit(): void {
    this.taskService.getTaskById(this.taskId).subscribe((data)=>{
      this.task = data;
      debugger;
    })
  }
  submit(model,id){
    debugger;
    this.updatedTask = model.form.value;
    this.taskService.update(this.updatedTask,id).subscribe(()=> this.cancel());
  }
  cancel(){
    this.router.navigate(["task"]);
  }
 

}
