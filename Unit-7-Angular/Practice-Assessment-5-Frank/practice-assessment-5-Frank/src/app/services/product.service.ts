/****************************************************************************************** 
 * This service will contain all the data access and other manipulation for a Product
 * 
 * It was created with the command: ng generate service services/Product
 * 
 * Note: The command placed the files for the service in a sub-folder called services
 *       of the app folder. 
 * 
 *       The sub-folder name is specified in the 'ng generate service' command:
 *
 *                               subfolder/service-name
 *            ng generate service services/Product
 * 
 *      The name of the files associated with the service is automatically generated:
 * 
 *            service-name.service
 *
 *      The class name assigned to the service is: ServiceNameService
 *      (ie. Service was added to the service-name you specified in the 'ng generate' command)
 *
*/

import { Injectable } from '@angular/core';        // Gain access to 'Injectable' an core Angular feature
import { Product }    from '../models/product' // Gain access to the Product interface
                                                   // Note the relative path to the file is used

// @Injectable tells Angular that this service may be Dependency Injection
@Injectable({
  providedIn: 'root'
})
export class ProductService {

  // Products to be used by the application
  Products : Product[] = []  // Data source for the app - will be initialized by the constructor

  // a constructor is method to initialize data defined in the module
  // it is executed automatically when the service is loaded
  // Here we use the constructor to initialize our data source
  constructor() {
    this. Products.push({name:'Light Saber', productID : '0504', price : 19.95})
    this. Products.push({name:'Phaser     ', productID : '1234', price : 9.95})
    this. Products.push({name:'Death Star' , productID : '666',  price : 99999999.99})
    this. Products.push({name:'Transporter', productID : '7890', price : 234.56})
    this. Products.push({name:'Droid'      , productID : '4532', price : 34.95})
    this. Products.push({name:'Star Ship'  , productID : '0319', price : 2000000.00})
   }

   // This function will return all the current data in our data source (`Products`)
  //  name(parameters) : return-type-of-data-returned
   getAllProducts() : Product[] {
    return this.Products
   }
}
