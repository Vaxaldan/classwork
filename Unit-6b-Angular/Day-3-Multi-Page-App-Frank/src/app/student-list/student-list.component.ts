import { Component }    from '@angular/core';
import { CommonModule } from '@angular/common'

@Component({
  selector: 'app-student-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './student-list.component.html',
  styleUrl: './student-list.component.css'
})
// The class contains the data and function used in teh component
// It is exported so processes outside the component can access it
export class StudentListComponent {
// Define a list of students to be displayed
// For today, it will be coded as an array of literals
// Soon, we will be getting the data from an external source like an API server
studentNames = ["Joshua", "Ashley", "Ryan", "Kendall", "Ethan", "Evan"] 
}
