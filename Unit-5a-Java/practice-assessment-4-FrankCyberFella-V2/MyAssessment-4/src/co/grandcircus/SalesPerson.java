package co.grandcircus;

import java.util.ArrayList;
import java.util.List;

public class SalesPerson {  
    private String name;
    private String company;
    private List<Customer> customers;

    public String getName() {
        return name;
    }
    public String getCompany() {
        return company;
    }
    public SalesPerson(String name, String company) {
        this.name = name;
        this.company = company;
        this.customers = new ArrayList<Customer>();
    }

    public void addCustomer(Customer customer) {
        customers.add(customer);
    }

    public Customer getLastCustomerCall() {
        // Go through the list of Customers
        // and locate the Customer with the oldest most recent phone call
        // based on the date
        //
        // Define a place to hold the smallest date so far initialized to the biggest possible value
        // Define a Customer to hold the one with the smallest date
        //
        // Inside the loop:
        //
        //      Get the date of the current customer last phone call
        //      is date less than the smallest one we have so far
        //         if it is... store is as the smallest one we have so far
        //                     store the current Customer (remember this Customer)
        //         if it's not... do nothing
        //
        //                 yyyymmdd
        int smallestDate = 99999999; // Hold the biggest date so far - set to the lowest possible value
        Customer theCustomerWeFound = null; // Customer with smallest phone date

        //        element      : collection
        for(Customer aCustomer : customers) { // Go through the list of Customers one at a time
            //      Get the date of the current customer last phone call
            int currentCallDate = aCustomer.getLastCall().getDate();
            if(currentCallDate < smallestDate){ // is date less than the biggest one we have so far
                smallestDate = currentCallDate; //   Remember the currentCallDate as the smallest
                theCustomerWeFound = aCustomer; //   Remember the current Customer as one with smallest date
            }  
        }

         // return the Customer with the oldest call date
         return theCustomerWeFound;  
    }
    

}
