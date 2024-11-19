/***************************************************************
 This is service

 A service is a set of processing to facilitate the retrieval
 and storage of data - typically in a persistent source (saved)

 May do other processing as well

 The data from this service is stored on an external n API

*******************************************************************/

import { Injectable}   from '@angular/core'; // Access Angular Dependency Injection
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})

export class MoviesService {

  // A module contains data and methods/functions for processing that data

  // Source of data for calls to retrieve the data - initialized in the code
  private listOfMovies : any[] = []  // An array of objects from the API

  private movieInfoApi : string = "https://65f1fd0b034bdbecc7642d17.mockapi.io/api/v1/movies"

  constructor(private http:HttpClient) {} 

    async  getMoviesList() :  Promise<any[]> {  // this function returns a array of objects
            
      const theMovies: any[] = await this.http.get<any>(this.movieInfoApi).toPromise()
      
      this.listOfMovies = theMovies  
      
      return this.listOfMovies
      }

  // This method will receive a MoviesInfo object and add it to our data source (listOfMovies)
      async addMovies(newMovie : any) : Promise<any> {      
      //  console.table(newMovie)          // optional - verify new movie data
       
      const headers = new HttpHeaders ({
                                        'Content-Type' : 'application/json'
                                       });
                                       
       return this.http.post(this.movieInfoApi, newMovie, {headers}).toPromise();
             }
  } 
