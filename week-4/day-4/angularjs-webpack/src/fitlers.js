
const filters = angular.module("customFilters", [])

filters.filter("addOne", () => {
    return (item) => item + "- this is from a filter"
})

filters.filter("addComma", () => {})

console.log("loading filters")