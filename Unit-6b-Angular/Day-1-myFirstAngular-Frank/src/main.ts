// This starts the Angular Application
// when you ng serve it looks for main.ts to start the app
// This is where  you put the "home" or starting component for the application
import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
// This is where in include the home component for the app
// You specify teh high level qualifiers for the app file
import { AppComponent } from './app/app.component';

// bootstrapApplication function is what the server calla to start the app
// The name of the import defined for the passed as the first parameter
bootstrapApplication(AppComponent, appConfig)
  .catch((err) => console.error(err));

