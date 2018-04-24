angular.module("customFilters", []).filter("addOne", () => {
    return (item) => item + "- this is from a filter"
})
console.log("loading filters")