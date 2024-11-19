// This file directs Angular to the Component assign to a path specified as a link

import { Routes }        from '@angular/router';
import { HomeComponent } from './home/home.component';
import { SampleFormComponent } from './sample-form/sample-form.component';
import { StateSealsComponent } from './state-seals/state-seals.component';
import { StudentListComponent } from './student-list/student-list.component';

export const routes: Routes = [
    {path: '', redirectTo: '/home', pathMatch: 'full' },   // if no path is given use the /home path
    {path: 'home',        component: HomeComponent},       // the "/home" path references the HomeComponent 
    {path: 'contactInfo', component: SampleFormComponent}, // the /contactInfo path references the SampleFormComponent
    {path: 'showSeals',   component: StateSealsComponent}, // the /showSeals path references the SampleFormComponent
    {path: 'students',    component: StudentListComponent} // the /students path references the SampleFormComponent
];
