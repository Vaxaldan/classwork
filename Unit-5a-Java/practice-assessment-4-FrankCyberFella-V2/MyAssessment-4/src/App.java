// To gain access to other classes use import rather than using (C#)
//     packageName.className
import co.grandcircus.Call;
import co.grandcircus.Customer;
import co.grandcircus.SalesPerson;

public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Welcome to Practice Assessment 4!");

        // Instantiate a Call object using the two-arg constructor
        Call aNewCall = new Call(20241007, "Some Notes");

        // Display the newly initiated Call object
        //     note: toString() method will be called obtain a String representation of the object 
        //           for printing
        System.out.println("aNewCall is: " + aNewCall);

        // Instantiate a few calls to add to a Customer
        Call call1 = new Call(20241009, "First call in array list");
        Call call2 = new Call(20241031, "Second call in array list");
        Call call3 = new Call(20241101, "Third call in array list");

        // Instantiate a Customer object
        Customer aCustomer = new Customer("Frank", "440-555-Java");

        // add the calls to the Customer
        aCustomer.addCall(20241009, "First call in array list");
        aCustomer.addCall(call2.getDate(), call2.getNotes());
        aCustomer.addCall(call3.getDate(), call3.getNotes());

        // Display the last call added for the Customer
        System.out.println("The last call for Customer was: " + aCustomer.getLastCall());

        // Display all the Calls for a Customer
        // (the class has to allow the user of the class to do this)
        // (the user for the class does not have direct access to the data)

        System.out.println("------- Display all Calls -------");
        // loop through the calls for a Customer and display them
        // using a foreach loop
        //
        // Java foreach: for(datatype elemName : collectionName)
        for(Call aCall : aCustomer.getCalls()) { // Loop through the list of calls return       ed
            System.out.println(aCall);
        }

        Customer anotherCustomer = new Customer("Ryan","111-111-1111");
        anotherCustomer.addCall(20231009, "First call in array list 2");
        anotherCustomer.addCall(20231209, "First call in array list 2");

        SalesPerson ashley = new SalesPerson("Ashley", "AshleyCo");
        ashley.addCustomer(anotherCustomer);
        ashley.addCustomer(aCustomer);

        // Display the Customer for ashley with the oldest call
        System.out.println("Customer with oldest call is: " + ashley.getLastCustomerCall());

    
    System.out.println("Thanks for visiting my Practice Assessment 4!");
    } // End of main()
} // End of Class App
