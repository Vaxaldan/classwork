/***************************************************************
 This is service

 A service is a set of processing to facilitate the retrieval
 and storage of data - typically in a persistent source (saved)

 May do other processing as well

 The data from this service is stored on an external API

*******************************************************************/

import { Injectable}   from '@angular/core'; // Access Angular Dependency Injection
// Get access to the Angular HTTP request support
// HttpClient - handle all the HTTP requests we make
// HttpHeaders - handle all the "header info" an HTTP request might need
//               (usually only POST and PUT requests need headers) 
import { HttpClient, HttpHeaders } from '@angular/common/http';

// Tell Angular this service is Dependency Injectable
@Injectable({
  providedIn: 'root'
})

export class MoviesService {

  // A module contains data and methods/functions for processing that data

  // Source of data for calls to retrieve the data - initialized in the code
  private listOfMovies : any[] = []  // An array of objects from the API

  // This is a variable to hold the external API URL - used in the calls to the API
  private movieInfoApi : string = "https://65f1fd0b034bdbecc7642d17.mockapi.io/api/v1/movies"

  // constructor is run after Angular initialization 
  // it should initialize data for the service
  // This one will get the initial copy of the data from the external API
  constructor(private http:HttpClient) {} 
    
    // Call the function getMoviesList() asynchronously to get the data
    // It returns the Promise from async call to the API with the associated data
    // Because this is an async function, it returns a Promise with any data
    //     function-name(parms) : what-it-returns
    async  getMoviesList() :  Promise<any[]> {  // this function returns a array of objects
      // await - wait for the async call to complete before continuing
      // this.http.get<> - Does the HTTP GET to the URL specified
      // this.movieInfoAPI - the variable with the URL for the API  
      // .Promise() - Use a Promise for when the async class is done
      //
      //theMovies will hole the data from the API call    
      const theMovies: any[] = await this.http.get<any>(this.movieInfoApi).toPromise()
      
      this.listOfMovies = theMovies  // Assign the data from the API call to our array
      
      return this.listOfMovies       // return our array of movies
      }

  // This method will receive a MoviesInfo object and add it to our data source (listOfMovies)
  // an HTTP POST is used to add data to an an API
  // The HTTP POST needs to tell the server what kind of dat is being for addition to data source
  // HTTP Headers provide info about the request to the server such as:
  //     1. Security tokens to identify who you are
  //     2. The type of data being sent with the request
  //     3.  Admin info about the request
  // We need to create a header to at least tell the server what type of data we are sending it.
  //     (usually it JSON, but could be plain text, XML, image and others) 
  
  async addMovies(newMovie : any) : Promise<any> {      
      //  console.table(newMovie)          // optional - verify new movie data
      
      // Create a header to tell the server we are sending it JSON data with the request
      // 'application/json' is how you indicate JSON data
      // the Angular HttpCLient takes care of converting the data for you, if necessary
      // 'Content-Type' is the attribute where type of incoming data is specified
      // Use new HttpHeaders too create a JSON object with the attributes you want to send
      const headers = new HttpHeaders ({
                                        'Content-Type' : 'application/json'
                                       });
                                       
       // use http.post(API-URL, data-to-send, {header-object}).toPromise()                                
       return this.http.post(this.movieInfoApi, newMovie, {headers}).toPromise();
             }
  } 
