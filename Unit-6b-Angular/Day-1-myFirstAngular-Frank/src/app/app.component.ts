// This contains all TypeScript code used in the app
import { Component }    from '@angular/core';   // Give me access to the Angular COmponent processing stuff
import { RouterOutlet } from '@angular/router'; // Give me access to the Angular router stuff

// Identify the attributes/characteristics or the home/starting component
@Component({
  selector: 'app-root',  // Where to insert the HTML angular uses for the component
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',  // File with the HTML Angular to to use for the Component
  styleUrl: './app.component.css'       // File with CSS to be applied to the HTML defined as template
})
// export allow other processes outside of this TypeScript file (like Angular) 
//        to access stuff in the TypeScript file 
export class AppComponent {
  title = 'myFirstAngular';  // Name external processes can use to access this stuff
}
