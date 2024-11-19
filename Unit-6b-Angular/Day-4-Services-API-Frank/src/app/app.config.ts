// This file identifies major features of Angular you will be using

import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';
// HTTP is the protocol for interacting with external servers
//
// HTTP: GET    - retrieve data from a server
//       POST   - add data to a server
//       DELETE - remove data from a server
//       PUT    - update data on a server
// Gain access to ANgular HTTP support via HttpClient
import { provideHttpClient } from '@angular/common/http';

import { routes } from './app.routes';

export const appConfig: ApplicationConfig = {
  // the providers attribute is an array of constructors major features you are using
  // include the provideHttpClient() as a provider if using HTTP to interact with servers
  providers: [provideRouter(routes), provideHttpClient()]
};