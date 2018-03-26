angular
  .module("contactListApp", [])
  .controller("peopleListController", ($scope) => {
    $scope.contactList = [
      {name: "bill", age:"33"},
      {name: "beth", age:"63"},
      {name: "jamie", age:"18"},
      {name: "shane", age:"17"},
      {name: "bubba", age:"24"},
      {name: "pap", age:"88"},
    ]
  })