// typescript file goes here
console.log("Welcome to TypeScript");
var Roster = /** @class */ (function () {
    function Roster() {
        this.studentRoster = [];
    }
    // Add a student to array
    Roster.prototype.addStudent = function (newStudent) {
        this.studentRoster.push(newStudent);
    };
    // Return all students in our array
    Roster.prototype.getStudents = function () {
        return this.studentRoster;
    };
    Roster.prototype.findStudent = function (aName) {
        var indexOfFoundElement = this.studentRoster.findIndex(function (theElement) { return theElement.studentName == aName; });
        if (indexOfFoundElement > -1) {
            return this.studentRoster[indexOfFoundElement];
        }
        return null;
    };
    return Roster;
}());
// -------------------------------------------------------------
// Define and process our class Roster
var classRoster = new Roster(); // Instantiate a Roster
// Define some students to add to the roster
classRoster.addStudent({ studentName: "Josh", class: "Programming", startDate: 20240801 });
classRoster.addStudent({ studentName: "Evan", class: "Programing", startDate: 20240801 });
classRoster.addStudent({ studentName: "Ashley", class: "Programming", startDate: 20240801 });
classRoster.addStudent({ studentName: "Ethan", class: "C#", startDate: 20240801 });
classRoster.addStudent({ studentName: "Ryan", class: "HTML", startDate: 20240801 });
classRoster.addStudent({ studentName: "Kendall", class: "Angular", startDate: 20240801 });
var aStudent = { studentName: "Frank", class: "Welding", startDate: 20250214 };
classRoster.addStudent(aStudent);
// Display the elements on the classRoster
// Loop through the arry of Students in the class Roster
classRoster.getStudents().forEach(function (theStudent) { console.log(theStudent); });
console.log(classRoster.findStudent("Evan"));
console.log(classRoster.findStudent("Bob"));
