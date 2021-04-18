import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TaskService } from '../services/taskservice';
@Component({
  selector: 'app-create-subtask',
  templateUrl: './create-subtask.component.html',
  styleUrls: ['./create-subtask.component.css']
})
export class CreateSubtaskComponent implements OnInit {

   task: any;
  constructor(private taskService: TaskService, private router: Router) { }

  ngOnInit(): void {
  }
  submit(model){
    debugger;
    this.task = model.form.value;
    this.task.parent = sessionStorage.getItem('taskid');
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
  }
  cancel(){
    this.router.navigate(["task"]);
  }

}
