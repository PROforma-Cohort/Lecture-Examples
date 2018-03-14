const countOfApples = 10;
const countOfOranges = 11;


const sum = (x, y) => {
    return x + y + 1;
}

const countOfFruit = sum(countOfApples, countOfOranges);


test("sum function", (t) => {
    t.is(sum(2,3), 5)
    t.is(sum(10,5), 15)
    t.is(sum(5,-2), 3)
    t.is(sum(5.25,2.25), 7.5)
})
