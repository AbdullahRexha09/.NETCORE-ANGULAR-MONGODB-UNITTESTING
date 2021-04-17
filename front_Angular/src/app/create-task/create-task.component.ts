import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TaskService } from '../services/taskservice';

@Component({
  selector: 'app-create-task',
  templateUrl: './create-task.component.html',
  styleUrls: ['./create-task.component.css']
})
export class CreateTaskComponent implements OnInit {
  task: any;
  constructor(private taskService: TaskService, private router: Router) { }

  ngOnInit(): void {
  }
  submit(model){
    this.task = model.form.value;
    if(this.task){
      if(this.task.title && this.task.Description && this.task.duedate){
        this.taskService.createTask(this.task).subscribe(()=>{
          this.router.navigate(["task"]);
        });
        
      }
      else{
        alert('Provide inputs');
      }
    }
    debugger;
  }
  cancel(){
    this.router.navigate(["task"]);
  }

}
