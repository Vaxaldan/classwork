import { Component }      from '@angular/core';       // Gain access to Component processing in angular core 
import { Product }        from '../../models/product';// Gain access to the Product interface
import { CommonModule }   from '@angular/common';     // Gain access to common Angular directives such as *ngFor and @ngIf
import { ProductService } from '../../services/product.service'; // Gain access to data and functions in ProductService

@Component({
  selector: 'app-product-menu', // html tag name to reference the component
  standalone: true, // This component a standalone entity
                    // It doesn't need to be declared in an NgModule, unlike traditional Angular components.
                    // Allows Angular to process the component more efficiently and provides better application organization
  imports: [CommonModule],      // Tell Angular you are using features defined in the CommonModule code of Angular (required by *ngFor)
  templateUrl: './product-menu.component.html',
  styleUrl: './product-menu.component.css'
})
export class ProductMenuComponent {

// heading title for the page  
title : string = "Frank's Practice Assessment 5 - Angular"

// This will hold the data for the products to be displayed
// The data will come from a call to a service
// It starts out as an empty array  
//      var-name   : data-type - array of our interface data type
public productList : Product [] = []; // Data will be retrieved from the ProductService to initialize this data

// constructor is used to initialize data in the component
//
// The service(s) will be Dependency Injected by Angular

// Dependency Injection is the automatic creation of variables and objects required
// (instead of the programming having to instantiate objects it needs, its done automatically)
//
// Dependency Injection decouples the service from the code
// (makes it much easier to change the service)
//   
constructor(private ProductService  : ProductService ) { 
  // When this component is instantiated, we will call the service function to get our products
  // Call the service method to send back the current list of products from the data source
  this.productList = ProductService.getAllProducts()  ; // Initialize our productList from service
}

}
