let firstname = "Lawrence";
let lastname = "Neris";
let title = "Software Engineer";
//can you double quotes or single quotes for strings
title = 'cto';

let fullName = firstname + " " + lastname;

fullName = `${firstname} ${lastname}`;
console.log(fullName);
///creating multi-line strings with \n
let bio = "Line 1\nLine2"
console.log(bio);


console.log("-----------------------------------Module 3-------------------------------");
//creating multi-line strings with backticks
bio = `About Lawrence Neris:
Lawrence Neris is the current CTO of globomatics.
He also servers as an author for pluralsight.`;

//escaping characters
let quote = 'David said, "JavaScript is great."';
quote = "David said \"JavaScript is great.\"";
quote = `JavaScript can use 'single' and "double" quotes.`;
quote = `In JavaScript, you must escape the \\ character`;
console.log(quote);

//string length property
let length = quote.length; 
console.log(`Quote Length: ${length}`);

//accessing specific characters
let secondCharacter = quote[1];
console.log(`Second Character in the quote is: ${secondCharacter}`);

//Changing case
let capFirstName = firstname.toUpperCase();
console.log(capFirstName);
let lowerFirstName = firstname.toLowerCase();
console.log(lowerFirstName);

//finding a substring
let idx1 = fullName.indexOf("Law");
console.log(`Position of "law" at : Index ${idx1}`);
let idx2 = fullName.indexOf("Ner");
console.log(`Position of "ner" at : Index ${idx2}`);

// in JS, -1 means query not found
let idx3 = fullName.indexOf("abc");
console.log(`Position of "abc" at : Index ${idx3}`);

//Does a string contain a substring 
let doesContain = fullName.includes("Dav");
console.log(doesContain);



//objects
//create an object with an object literal(preferred)
let obj1 = {};

//Create an object with a constructor
let obj2 = new Object();

//Populate propertires on an object
obj1.firstName = "David";
obj1.lastName = "Tucker";
obj1.isActive = true;
obj1.startDate = new Date("January 1, 2022");
obj1.vacationDays = 14;
//outputs obj1 and all its properties
console.log(obj1);

let obj3 = {
    firstName: "Lawrence",
    lastName: "Neris",
    isActive: true,
    startDate: new Date("January 1, 2022"),
    vacationDays: 14
};
console.log(obj3);
console.log("");
// Accessing properties from an object
console.log(`First Name: ${obj3.firstName}`);
//you can use square brackets for object properties
console.log(`Last Name: ${obj3["lastName"]}`);

//Deleting properties from an object
delete obj3.firstName;
//firstName property deleted
console.log(obj3);

//acessing a property that doesn't exist

//objects are passed by reference, not value
let obj4 = obj3;
obj4.lastName = "Smith";
console.log(`Last Name (obj3): ${obj3.lastName}`);


//DATES
//the right way to output date
let date1 = new Date("January 1, 2023");
console.log(date1);
//the date and time now
let date3 = new Date(); //now
console.log(date3);
//date and time configuration
let date4 = new Date(2023, 0, 1, 2, 30, 4);
console.log(`A fictitious date and time: ${date4}`);


//accessing elements from a date
console.log(`Full year: ${date4.getFullYear()}`);
console.log(`month (zero-indexed so Jan is 0): ${date4.getMonth()}`);



//CLASSES

class CalendarDay {
    //private fields 
    #month;
    #day;
    #year;
    //constructor
    constructor(month,day,year){
        this.#month = month;
        this.#day = day;
        this.#year = year;
    }
    //public method
    toString() {
        return `${this.#year}-${this.#month+1}-${this.#day}`;
    }
}
let day1 = new CalendarDay(2023, 0, 1);
console.log(day1.toString()); //it should print: 2023-11-18
console.log("");
console.log("-----------------------------Module 4-------------------------------");
//CONVERSIONS
//using the typeof function
let strValue = "Hi";
console.log(typeof(strValue));
let numValue = 1;
console.log(typeof(numValue))
let boolValue = true;
console.log("");
//joining a non-string value with a string
let ageString =41;
let firstName = "David";
let description = `${firstName} is ${ageString} years old`;
//compiler assumes first string means this is a string variable. age turns to string.
console.log(description);
let ageNewNum = new Number(ageString); //you dont want this
console.log(typeof(ageNewNum));

//What about NaN
let ageString2 = "forty-one";
let ageNum2 = Number(ageString2);
console.log(`Age String 2: ${ageNum2}`);
console.log("");

//converting a value to a boolean
let num1 = 1;
let num2 = 0;
let bool1 = Boolean(num1);
let bool2 = Boolean(num2);
console.log(`Num1: ${bool1} & Num2: ${bool2}`);


//string to boolean
let str1 = "Hello";
let bool3 = Boolean(str1);
let val1;
let bool4 = Boolean(val1);
console.log(`Bool3: ${bool3} | bool4: ${bool3}`);



//JavaScript Object Notation
let employee = {
    firstName: "David",
    lastName: "Tucker",
    birthDate: new Date("January 1, 1982"),
    numYearsEmployment: 7,
    department: "Engineering",
    title: "Software Engineer",
    isActive: true,
    salary: 100000
};
//Convert to JSON string
let jsonValue = JSON.stringify(employee);
console.log(jsonValue);
jsonValue = JSON.stringify(employee, null, 2);
console.log(jsonValue);

//Convert JSON back to object
let newEmployee = JSON.parse(jsonValue);
console.log(newEmployee);

console.log("");


console.log("-------------------------MODULE 5------------------------------");


//Conditionals
numYearsService = 15;
let badgeColor;

if(numYearsService < 5) {
    badgeColor = "blue";
}
else if (numYearsService < 10) {
    badgeColor = "yellow";
}
else if (numYearsService < 15) {
    badgeColor = "red";
}
else if (numYearsService < 20) {
    badgeColor = "purple";
}
else {
    badgeColor = "silver";
}
console.log(`Your badge color is ${badgeColor}`);
console.log("");

//Comparison operators 
//Three equal signs is called "Strict Equality"
let thisString = "Hello";
let thatString = "Hello";
let strictComparisonOfStrings = thisString === thatString;
let regularComparisonOfStrings = thisString == thatString;
console.log(strictComparisonOfStrings);