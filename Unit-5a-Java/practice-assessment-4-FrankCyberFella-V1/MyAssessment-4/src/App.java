// To gain access to other classes use import rather than using (C#)
//     packageName.className
import co.grandcircus.Call;  // Give me access to Call class code

public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Welcome to Practice Assessment 4!");

        // Instantiate a Call object using the two-arg constructor
        Call aNewCall = new Call(10072024, "Some Notes");

        // Display the newly initiated Call object
        //     note: toString() method will be called obtain a String representation of the object 
        //           for printing
        System.out.println("aNewCall is: " + aNewCall);
    
    System.out.println("Thanks for visiting my Practice Assessment 4!");
    } // End of main()
} // End of Class App
