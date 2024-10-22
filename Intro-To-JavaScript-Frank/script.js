/*
    Example of a multi-line comment just like in C#/Java
*/

// Single line comment

/**
 * Functions start with the word function.
 * They don't have a return type and the naming convention is camel-case.
 */
function variables() {
  // Declares a variable where the value cannot be changed
  const aVariable = 31;
  console.log(`The value in aVariable is: ${aVariable}`) // Display a value on the screen
  // Declares a variable those value can be changed
  let anotherVariable = "Frank"  // Set value to string
  console.log(`anotherVariable: ${anotherVariable}`)
  anotherVariable = 3.14  // set value to a double
  console.log(`anotherVariable: ${anotherVariable}`)
 
  // Declares a variable that will always be an array
 let aArray = ["josh", 5, 7.3, "Jay", true]
 console.log(aArray); 
 console.table(aArray)
}

/**
 * Functions can also accept parameters.
 * Notice the parameters do not have types.
 * @param {Number} param1 The first number to display
 * @param {Number} param2 The second number to display
 */
function printParameters(param1, param2) {
  console.log(`The value of param1 is ${param1}`);
  console.log(`The value of param2 is ${param2}`);
}

/**
 * Compares two values x and y.
 * == is loose equality - only the values need to be the same, datatypes may differ
 * === is strict equality - both the values and the datatype must be the same
 * @param {Object} x
 * @param {Object} y
 */
function equality(x, y) {
  console.log(`x is ${typeof x}`); // typeof returns the type of data in variable
  console.log(`y is ${typeof y}`);

  console.log(`x == y : ${x == y}`); 
  console.log(`x === y : ${x === y}`);  
}

/**
 * Each value is inherently truthy or falsy.
 * false, 0, '', null, undefined, and NaN are always falsy
 * everything else is always truthy
 * @param {Object} x The object to check for truthy or falsy,
 */
function falsy(x) {
  if (x) {
    console.log(`${x} is truthy`);
  } else {
    console.log(`${x} is falsy`);
  }
}

/**
 *  Objects are simple key-value pairs  (like in Dictionary or Map)
    - values can be primitive data types
    - values can be arrays
    - or they can be functions
    Objects in JavaScript are NOT Object-Oriented objects
*/
function objects() {
  const person = {          // Start of the object
    firstName: "James T.",
    lastName: "Kirk",
    age: 42,
    employees: [
      "Spock",
      "McCoy",
      "Uhura",
      "Scotty"
    ]
  };

  // Log the object
  console.log(person)    // `` for interpolation are optional for objects
  console.table(person)
  // Log the first and last name
  // Access to attributes:  objectName.attributeName
  console.log(`${person.firstName} ${person.lastName} is the name of the person`)

  // Log each employee
  // Since employee is an array - use for-loop to loop through it
  for(let i=0; i < person.employees.length; i++) {
    console.log(`Employee #${i+1}; ${person.employees[i]}`)
  }
}

/*
########################
Function Overloading
########################

In C#/Java: Functions overloads were functions with same name, but different parameters
            The compiler wold choose which function to run based on the parameters
            (We used function overload with constructors)
                       

Function Overloading is not available in Javascript. If you declare a
function with the same name, more than one time in a script file, the
earlier ones are overridden and the most recent one will be used.
*/

function Add(num1, num2) {
  return num1 + num2;
}
// This function will replace any other function previously defined with same name
function Add(num1, num2, num3) {
  return num1 + num2 + num3;
}

/*
########################
Math Library
########################

A built-in `Math` object has properties and methods for mathematical constants and functions.
*/

function mathFunctions() {
  console.log("Math.PI : " + Math.PI);
  console.log("Math.LOG10E : " + Math.LOG10E);
  console.log("Math.abs(-10) : " + Math.abs(-10));
  console.log("Math.floor(1.99) : " + Math.floor(1.99));
  console.log("Math.ceil(1.01) : " + Math.ceil(1.01));
  console.log("Math.random() : " + Math.random());
}
/*
########################
String Methods
########################

The string data type has a lot of properties and methods similar to strings in Java/C#
*/

function stringFunctions(value) {
  console.log(`.length -  ${value.length}`);
  console.log(`.endsWith('World') - ${value.endsWith("World")}`);
  console.log(`.startsWith('Hello') - ${value.startsWith("Hello")}`);
  console.log(`.indexOf('Hello') - ${value.indexOf("Hello")}`);  // First occurrence of the string
  console.log(`.indexOf('l') - ${value.indexOf("l")}`);          // First occurrence of the string
  console.log(`.lastIndexOf('l') - ${value.lastIndexOf("l")}`);  // last occurrence of the string
 
  console.log(`.substr(value,2,3) - ${value.substr(2,3)}`);       // string.substr(start-index, #-chars)
  console.log(`.substring(value,2,3) - ${value.substring(2,3)}`); // string.substring(start-index, end-index)
                                                                  // return the chars starting at start-index
                                                                  //    up to but not including the char at end-index
                                                                  //    just like Java
    /*
    Other Methods
        - split(string)
        - substr(number, number)
        - substring(number, number)
        - toLowerCase()
        - trim()
        - https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String
    */
}
    /*
    ############################
    Array Manipulation Examples
    ############################
    */

    function arrayFunctions() {
      let stooges = [
                    "Moe"
                   ,"Larry"
                   ,"Curly"
                   ]
      
    console.table(stooges)

    stooges.push("Shemp");  // add an element to end of the array
    console.table(stooges);

    stooges.unshift("Curly Joe") // add an element to the start of the array
    console.table(stooges);

    stooges.splice(3,0,"Groucho", "Chico", "Harpo") // insert elements starting at index 3 and delete 0 elements
    console.table(stooges);

    stooges.splice(3,1) // delete 1 element starting at element 3
    console.table(stooges);

    stooges.splice(3,2) // remove 2 elements starting at index 3
    console.table(stooges);

    stooges.shift() // remove one element from the start of the array
    console.table(stooges);

    stooges.pop()   // remove one element from the end of the array
    console.table(stooges);

    let marxBros = [
                   "Groucho"
                  ,"Chico"
                  ,"Harpo"
                ]
    let oldFunnyGuys = stooges.concat(marxBros)  // Combine two arrays
    console.table(oldFunnyGuys)
    }