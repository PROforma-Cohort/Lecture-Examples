// we N people, that will be passed into our function as an array
// if all people, have even number of flowers, then they a big group of friends



const friendFinder = (people) => {
    // want to test if all number in the array are even
    for (let i = 0; i < people.length; i++) {
        const person = people[i];
        console.log(person);
        const isPersonEven = person % 2 === 0;
        if (!isPersonEven){
            return false;
        } 
    }
    return true;
}



const friends = [1,3,4,5,7,87,4,2];
const evens = [2,26,12,18]
console.log(friendFinder(friends));
console.log(friendFinder(evens));