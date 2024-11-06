import { CommonModule }  from '@angular/common';
import { Component }     from '@angular/core';
import { MoviesInfo }    from '../moviesInfo';            // access the MoviesList interface
import { MoviesService } from '../movies.service-memory'; // access the MoviesServices service
import { RouterLink }    from '@angular/router';

@Component({
  selector: 'app-movie-list',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './movie-list.component.html',
  styleUrl: './movie-list.component.css'
})
export class MovieListComponent {

// This will hold the data for the movies to be displayed
// the data will come from a call to a service
// it starts out as an empty array  
//     var-name   : data-type - array of our interface
public moviesList : MoviesInfo [] ; // This is an array of MoviesInfo objects

// constructor is used to initialize data in the component
//
// This style of constructor will define the variable, create a MoviesService object
//                                       and assign that object to the variable
//                                       using Dependency Injection (DI)
//
// Dependency Injection is the automatic creation of variables and objects required
// (instead of the programming having to instantiate objects it needs, its done automatically)
//
// Dependency Injection decouples the service from the code
// (makes it much easier to change the service)
//   
// without Dependency Injection the code would look like this:
//
//     private movieService;   // define a variable to hold the service
//
//     constructor() {
//                    movieService = new MoviesServices();// create the service
//                   }                                    //    and assign it to the variable
//

// The constructor for component is automatically run when the component is instantiated by Angular

//           this movieService object is automatically instantiated and passed to this constructor                           
constructor(private movieService  : MoviesService ) { 
  // When this component is instantiated, we will call the service function to get our movies
  // Call the service method to send back the current list of movies from the data source
  this.moviesList = movieService.getMoviesList(); // Initialize our moviesList from service
  //  1. movieService.getMoviesList() - go to the movieService and run the method getMoviesList
  //  2. = - take with the method returns and assign it to (store it in)
} //  3. this.moviesList is assigned the data from step 2
}
