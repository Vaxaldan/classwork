/* This configurtion is used by the latest versions of Angular 
   define the URL path-COmponent connection for the application  
    this tells angular router which component to switch for URL path
*/

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';

// Be sure we have imported all components we are connecting to a URL path
import { SampleFormComponent }  from './sample-form/sample-form.component';
import { StateSealsComponent }  from './state-seals/state-seals.component';
import { HomeComponent }        from './home/home.component';
import { StudentListComponent } from './student-list/student-list.component';

// the routes attribute defines the URL path-Component connection
// it is an array of objects with each object specifying a URL path
//       and the component its connected to
const routes: Routes = [
  // if there is no URL path use (redirect the /home path
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  // if the URL path is /home switch to the HomeComponent
  { path: 'home',        component: HomeComponent },
  // if the URL path is /contactInfo switch to the SampleFormComponent
  { path: 'contactInfo', component: SampleFormComponent },
  { path: 'students',    component: StudentListComponent},
  // if the URL path is /showSeals switch to the StateSealsComponent
  { path: 'showSeals',   component: StateSealsComponent }
]
// @NgModule is used by the Angular router to find which component is associate with which path
@NgModule({
  declarations: [],
  // we need to tell the RouterModule the name of the array of paths
  imports: [RouterModule.forRoot(routes), CommonModule],
  exports: [RouterModule]
})
export class AppRoutingModule { 
  
}






