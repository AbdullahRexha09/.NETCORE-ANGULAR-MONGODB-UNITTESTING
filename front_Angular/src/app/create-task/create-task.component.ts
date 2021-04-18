import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TaskService } from '../services/taskservice';
import { ListService } from '../services/listservice';

@Component({
  selector: 'app-create-task',
  templateUrl: './create-task.component.html',
  styleUrls: ['./create-task.component.css']
})
export class CreateTaskComponent implements OnInit {
  task: any;
  lists: any;
  constructor(private taskService: TaskService, private listService: ListService ,private router: Router) { }

  ngOnInit(): void {
    this.listService.getAllLists().subscribe((data)=>{
      this.lists = data;
    })
  }
  submit(model){
    this.task = model.form.value;
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
