import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { throwError } from 'rxjs';

@Component({
  selector: 'form-example',  // Name used in html to reference the component <form-example>
  standalone: true,
  imports: [CommonModule, FormsModule],  // Tell Angular we want Forms support for this code
  templateUrl: './form-example.component.html',
  styleUrl: './form-example.component.css'
})
// Allow access to stuff defined this component from outside the component
export class FormExampleComponent {
  // Variables getting data from html form
  firstName = ''
  lastName = ''
  birthDate = ''
  foodPrefs = ''
  email = ''
  emailPref = ''

  // We will handle checkboxes and radials here
  checkboxes : any[] = [
    {name: 'American Football', value: "Football"},
    {name: 'European Foorball', value: "Soccer"},
    {name: 'Cricket', value: "Cricket"}, 
    {name: 'Baseball', value: "Baseball"},
    {name: 'Basketball', value: "Basketball"},
    {name: 'Hockey', value: "Hockey"},
    {name: 'Other', value: "Other"},
    {name: 'None', value: "None"},
  ]



  onSubmit() { // Handle the Submit button click on the  form
    console.log(`------------------------------`)
    console.log(`First Name ${this.firstName}`)
    console.log(`Last Name ${this.lastName}`)
    console.log(`Birth Date ${this.birthDate}`)
    console.log(`Food Prefernce ${this.foodPrefs}`)
    console.log(`Email ${this.email}`)
    console.log(`Email Prefernce ${this.emailPref}`)
    
    //console.table(this.checkboxes)
    console.log(`Sports they like: `)
    console.table(this.checkBoxResult)
  }

  get checkBoxResult(){

    return this.checkboxes.filter((aCheckBox) => aCheckBox.checked)
  }
}