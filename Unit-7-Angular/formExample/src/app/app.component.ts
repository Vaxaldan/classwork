import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormExampleComponent } from "./components/form-example/form-example.component";
// @Component identifies all the Angular stuff you are using
// including new components
@Component({
  selector: 'app-root',
  standalone: true,
  // imports identifies external resources, like components, used in the app
  imports: [RouterOutlet, FormExampleComponent], // Note the name has Component 
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})


// export allows processes outside this component to access things defined in the component
// To use One-Way Binding for data defined in this cide in the HTML: {{variable-name}}
export class AppComponent {
  pageHeading = 'Welcome to AHGC - C# - Contact Info Submission';
}
