import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TaskService } from '../services/taskservice';
import { ListService } from '../services/listservice';

@Component({
  selector: 'app-create-subtask',
  templateUrl: './create-subtask.component.html',
  styleUrls: ['./create-subtask.component.css']
})
export class CreateSubtaskComponent implements OnInit {
   task: any;
   taskObj:any;
   lists: any;
  constructor(private taskService: TaskService, private listService: ListService ,private router: Router) { }

  ngOnInit(): void {
      this.listService.getAllLists().subscribe((data)=>{
      this.lists = data;
    })
    this.taskService.getTaskById(sessionStorage.getItem('taskid'))
    .subscribe((data)=> {
      this.taskObj = data
      })
  }
  submit(model){
    this.task = model.form.value;
    this.task.parent = sessionStorage.getItem('taskid');
    if(this.task){
      if(this.task.title && this.task.Description && this.task.duedate && this.task.listId){
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
