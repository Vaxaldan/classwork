/* define the URL path-COmponent connection for the application  
    this tells angular router which component to switch for URL path
*/

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';

// Be sure we have imported all components we are connecting to a URL path
import { HomeComponent }        from './home/home.component';
import { AddMovieComponent } from './add-movie/add-movie.component';

// the routes attribute defines the URL path-Component connection
// it is an array of objects with each object specifying a URL path
//       and the component its connected to
const routes: Routes = [
  // if there is no URL path use (redirect the /home path
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  // if the URL path is /home switch to the HomeComponent
  { path: 'home'      , component: HomeComponent },
  { path: 'addmovie'  , component: AddMovieComponent}
 ];

@NgModule({
  declarations: [],
  // we need to the RouterModule the name of the array of paths
  imports: [RouterModule.forRoot(routes), CommonModule],
  exports: [RouterModule]
})
export class AppRoutingModule { 
  
}






