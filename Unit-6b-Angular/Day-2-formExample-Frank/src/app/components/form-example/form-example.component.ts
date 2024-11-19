import { Component }    from '@angular/core';
import { FormsModule }  from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'form-example',  // Name used in html to reference the component <form-example>
  standalone: true,
  imports: [CommonModule, FormsModule],  // Tell Angular we want Forms and Common features support for this code
  templateUrl: './form-example.component.html',
  styleUrl: './form-example.component.css'
})
// Allow access to stuff defined this component from outside the component
export class FormExampleComponent {

  // Variables getting data from the HTML for via [(ngModel)]
  firstName = ""    // this will hold the firstname entered in the form 
  lastName = ""
  birthDate = ""
  foodPrefs = ""
  email = ""
  email_preference = ""

  // We will handle checkboxes here since they are a multi-valued element
  // Checkbox value are typically stored in an array in the TypeScript code
  //          and displayed in the HTML from that array

  // Define an array to hold our checkbox values
  checkboxes : any[] = [  // Array of any type of values
    {name: 'American Football', value: "Football"},  // name will be displayed and value is what's returned
    {name: 'European Football', value: "Soccer"},
    {name: 'Cricket',    value: "Cricket"},
    {name: 'Baseball',   value: "Baseball"},
    {name: 'Basketball', value: "Basketball"},
    {name: 'Hockey',     value: "Hockey"},
    {name: 'Other',      value: "Other Sport"}, 
    {name: 'None',       value: "None"}
  ]


  onSubmit() { // Handle the Submit button click on the  form
  
    console.log(`-------------------------------------`)
    console.log(`First Name: ${this.firstName}`)
    console.log(` Last Name: ${this.lastName}`)
    console.log(`Birth Date: ${this.birthDate}`)
    console.log(`Food Likes: ${this.foodPrefs}`)
    console.log(`     Email: ${this.email}`)
    console.log(`OK 2 Email: ${this.email_preference}`)
    // Only display the items that were checked instead of all items in the checkbox list
    //console.table(this.checkboxes) // Display all items in the checkbox list
    console.log(`Sports they like: `)
    // Need to loop through the checkbox list for items with checked=true
    // Call a function to return all the items checked in checkbox list 
    //console.table(this.checkBoxResult)  // this method will return all items that have been checked
    
    this.checkBoxResult.forEach ((anElement)=> console.log(anElement.name))
  }

  // This function will check (or uncheck) all items in the checkbox list
  CheckAllOptions() {
    // if all checkboxes are checked - uncheck them all
    if(this.checkboxes.every((aCheckBox) => aCheckBox.checked == true)) {
      // Go through all the checkboxes in the array and uncheck them
      this.checkboxes.forEach((anElement) => anElement.checked = false)
    }
    else {
      this.checkboxes.forEach((aBox) => aBox.checked = true)
    }
    // if all checkboxes are unchecked - check them all
  }

  // Function to return all checkbox items that have been checked
  // We designate it as a "get" function because it's returning a value
  get checkBoxResult() {
    // loop through the checkbox list
    // If a item has checked=true, save it to return
    // when done looping return all saved items that had checked=true
    //
    // .filter() is an array function that will loop through an array
    //           and return an array of elements that an arrow functions
    //           has indicated should be returned
    //
    // The arrow function used with .filter:
    //
    //     1. will receive an element from an array
    //     2. return true if the element meets the return criteria of the filter
    //        return false if the element does not meet the return criteria of the filter
    //
    // .filter() collects all the elements that the arrow returned true on in an new array
    //           them returns the new array
    //
    // This .filter() will go through the checkboxes one at at a time an return the checked value
    return this.checkboxes.filter((aCheckBox) => aCheckBox.checked)
  }
}