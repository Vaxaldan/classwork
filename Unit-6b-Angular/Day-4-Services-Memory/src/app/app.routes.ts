import { Routes }               from '@angular/router';
import { HomeComponent }        from './home/home.component';
import { MovieListComponent }   from './movie-list/movie-list.component';
import { AddMovieComponent }    from './add-movie/add-movie.component';

export const routes: Routes = [
    {path: '', redirectTo: '/home', pathMatch: 'full' }  ,
    {path: 'home',       component: HomeComponent}       ,
    {path: 'movies',     component: MovieListComponent} ,
    {path: 'addmovie',   component: AddMovieComponent} ,
   
];
