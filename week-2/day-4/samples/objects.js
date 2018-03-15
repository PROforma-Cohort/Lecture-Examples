// Objects

const sum = 3 + 4;

const arr = [1,2,3,4,5]

// name, phone, address, hair, eyes

const person1Name = ""
const person1phone = ""
const person1address = ""
const person1hair = ""

const jenny = {
    name: "Jenny Smith",
    phone: "8675309",
    address: "123 fake street", 
    hair: "blonde"
}



const will = {
    name: "Will Smith",
    phone: "8675309",
    address: "123 fake street", 
    hair: "blonde"
}

const val = jenny.name;

const addPersonToDom = (person) => {
    // add to DOm 
    const _section = document.createElement("section")
    _section.textContent = person.name + "lives at " + person.address;
    document.querySelector(".parent").appendChild(_section);
}



addPersonToDom(jenny)

const studyGroup = [jenny, will];

for (let i = 0; i < studyGroup.length; i++) {
    const student = studyGroup[i];
    addPersonToDom(student);
}