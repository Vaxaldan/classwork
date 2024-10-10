// Since most companies mau create classes with the same names, but different
//      purposes. 
//
// To avoid a conflict between those classes,
//  packages are typically named compoany URL in reverse
//
// Grand Circus web URL is grandcircus.co
//
// so we would name packages co.grandcircus

package co.grandcircus;  // Package to hold this class

import java.util.ArrayList; // Give me access to the Java ArrayList code
import java.util.List;      // Give me access to the Java List code

public class Customer {

    private String     name;
    private String     telephone;
    private List<Call> calls;

    // An ArrayList is the Java version of a C# List
    //
    // List<data-type) is a base class/interface for several types of Lists
    //
    //     1. ArrayList
    //     2. LinkedList
    //     3. HashedLinkList
    //
    // To Define an ArrayList:
    //
    //  base-class-object     = store-a-subclass-object - THAT'S Polymorphism 
    //  List<data-type>  name = new ArrayList();  // Allows polymorphism to be used when processing the List
    //
    //    -or-
    //
    //  ArrayList<data-type> name = ArrayList();  // Polymorphism CANNOT be used when processing the List
    //
    //  .add() - add an element to the end of the ArrayList
    //  .size() - returns the number of elements in the ArrayList
    //  .get(index) - retrieve the element at the index given (1st element is index 0)
    //  .remove(index) -  remove the element at index given
    //  .indexOf(object) - return the index of the element matching the object given
    //                     (this requires a equals() method exists for the class of objects in the List)

    public Customer(String name, String telephone) {
        this.name      = name;
        this.telephone = telephone;
        this.calls     = new ArrayList<Call>();  // also code ArrayList() - may generate a warning
    }

    public void addCall(int date, String notes) {
        Call newCall = new Call(date, notes);   // Create a new call using data passed
        calls.add(newCall);                     // Add the new call to the ArrayList
    }

    public Call getLastCall() {

        // Get the last element in the list (index = size - 1)
        // Call lastOne = calls.get(calls.size()-1); 
        // return the element we just retrieved
        //return lastOne;

        return (calls.get(calls.size()-1));
        // return calls.getLast();
    }

    // Return the calls to a user
    public List<Call> getCalls() {
        return calls;
    }

    @Override
    public String toString() {
        return "Customer [name=" + name + ", telephone=" + telephone + ", calls=" + calls + "]";
    }

    


}  // End of Customer CLass
