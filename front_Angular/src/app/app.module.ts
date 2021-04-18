import { AuthGuard } from './guards/auth-guard.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import {JwtModule} from '@auth0/angular-jwt';
import { DataTablesModule } from 'angular-datatables';


import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { AppComponent } from './app.component';
import { RegisterComponent } from './register/register.component';
import { AgmCoreModule } from '@agm/core';
import { EdituserComponent } from './edituser/edituser.component';
import { TaskComponent } from './task/task.component';
import { CreateTaskComponent } from './create-task/create-task.component';
import { EdittaskComponent } from './edittask/edittask.component';
import { CreateSubtaskComponent } from './create-subtask/create-subtask.component';

export function tokenGetter() {
  return localStorage.getItem("jwt");
}

@NgModule({
  declarations: [
    HomeComponent,
    LoginComponent,
    AppComponent,
    RegisterComponent,
    EdituserComponent,
    TaskComponent,
    CreateTaskComponent,
    EdittaskComponent,
    CreateSubtaskComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    DataTablesModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent },
      { path: 'login', component: LoginComponent },
      { path: 'register',component:RegisterComponent},
      { path:'edituser',component:EdituserComponent},
      { path:'task',component:TaskComponent},
      { path:'createtask',component:CreateTaskComponent},
      { path:'edittask',component:EdittaskComponent},
      { path:'subtask',component:CreateSubtaskComponent}
    ]),
    AgmCoreModule.forRoot({
      apiKey : 'AIzaSyDoXcfFQNt1k86YaNEpvpPN4zEsSaiQxOo'
    }),
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        whitelistedDomains: ["localhost:5000"],
        blacklistedRoutes: []
      }
    })
  ],
  providers: [AuthGuard],
  bootstrap: [AppComponent]
})

export class AppModule { }
