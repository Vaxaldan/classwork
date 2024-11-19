/**************************************************************************************
 * This is an interface usable by multiple components and services
 * 
 * It describes the properties of a single product
 * 
 * Note: It was created using the command:
 * 
 *              ng generate interface models/product
 *
 *       The command placed it in sub-folder called 'models' of the app folder. 
 * 
 *       The sub-folder name is specified in the 'ng generate interface' command:
 *
 *                                 subfolder/interfaceName
 *              ng generate interface models/product
 * 
 *       In the client-server world the term 'model' is used to reference anything
 *       associated with the data for an application.
 * 
 * 
 *       It may also be created using the "New File" option of VS Code
 *       and placed in the appropriate sub-folder of the 'app' folder
 *       or in 'app' folder itself (not recommended)
 *
 *       The class name is PascalCase and file name is in kabob-case
 * 
 *       It is assigned the 'export' attribute so other components/services can access it
 * 
 ******************************************************************************************/
export interface Product {
    name      : string,
    productID : string,
    price     : number
}