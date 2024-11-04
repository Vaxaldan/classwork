import { CommonModule }  from '@angular/common';
import { Component, OnInit }     from '@angular/core';
import { MoviesService } from '../movies.service-api'; // access the MoviesServices service
import { RouterLink }    from '@angular/router';

@Component({
  selector: 'app-movie-list',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './movie-list.component.html',
  styleUrl: './movie-list.component.css'
})
export class MovieListComponent implements OnInit {

// This will hold the data for the movies to be displayed
// the data will come from a call to a service
// it starts out as an empty array  
//     var-name   : data-type
public moviesList : any[] = []; // This is an array of MoviesInfo objects

                      
constructor(private movieService  : MoviesService ) {}

async ngOnInit() {
  
  const theData  = await this.movieService.getMoviesList(); // Initialize our moviesList from service

  this.moviesList = theData

  console.table(this.movieService)
  
} 

}
