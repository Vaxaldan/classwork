// typescript file goes here
console.log("Welcome to TypeScript")
// This app will create, set and process a set of students
// Each student will have a Name, a class, and a start date for the class
// Students will be storedin an array and manipulated using array functions
// To assure every student has the expected attributes
// we will define an interface to be a template for a student
// ----------------------------------------------------------------------------
interface Student {
    studentName : string;
    class : string;
    startDate : number
}

class Roster {
private studentRoster : Student[]; //Arry of Students
    constructor(){
        this.studentRoster = [];
    }

    // Add a student to array
    addStudent(newStudent : Student) : void {
     this.studentRoster.push(newStudent);
    }

    // Return all students in our array
    getStudents() : Student[]{
        return this.studentRoster
    }

    findStudent(aName : string) : Student | null {
        let indexOfFoundElement = this.studentRoster.findIndex(theElement => theElement.studentName == aName)
        if (indexOfFoundElement > -1) {
            return this.studentRoster[indexOfFoundElement];
        }
        return null;
    }

}
// -------------------------------------------------------------
// Define and process our class Roster


let classRoster = new Roster();    // Instantiate a Roster

// Define some students to add to the roster
classRoster.addStudent({studentName : "Josh", class : "Programming", startDate : 20240801})
classRoster.addStudent({studentName : "Evan", class : "Programing", startDate : 20240801})
classRoster.addStudent({studentName : "Ashley", class : "Programming", startDate : 20240801})
classRoster.addStudent({studentName : "Ethan", class : "C#", startDate : 20240801})
classRoster.addStudent({studentName : "Ryan", class : "HTML", startDate : 20240801})
classRoster.addStudent({studentName : "Kendall", class : "Angular", startDate : 20240801})
let aStudent : Student = {studentName: "Frank", class : "Welding", startDate : 20250214}
classRoster.addStudent(aStudent)

// Display the elements on the classRoster

// Loop through the arry of Students in the class Roster
classRoster.getStudents().forEach(theStudent => {console.log(theStudent)});

console.log(classRoster.findStudent("Evan"));
console.log(classRoster.findStudent("Bob"));
