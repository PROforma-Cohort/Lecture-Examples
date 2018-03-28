// define a function 
const myFunc = () =>{
        // logic goes here
        // NOTE: this doesn't exist
}

function myFunc(){
    this.property = 5;
    
    // NOTE: this does exist
}

const obj = new myFunc();
console.log(obj.property)


// less abstract 

function Person(){
    this.name = "";
    this.gender = "";
    this.sayHi = function(otherPerson) {
        console.log(this);
        return "Hello, " + otherPerson
    }
    this.introduce = () => {
        return "My name is" + this.name;
    }

}

const tammy = new Person();
tammy.name = "tammy";
tammy.gender = "female";
tammy.sayHi("Paul"); // return Hello, Paul

console.log(tammy.name);

const tom = new Person();
tom.name ="tom";
console.log(tom.name);

/* KEY DIFFENCE : 

this

*/