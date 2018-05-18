angular.module("main", [])
    .controller("hatController", ["$scope", "$http", ($scope, $http) => {
        const loadLatestList = () => {
            $http({
                method: "GET",
                url: "/api/people"
            }).then(resp => {
                $scope.names = resp.data;
            })
        }


        $scope.groupSize = 2;
        $scope.names = [];
        $scope.addPersonToHat = () => {
            const _person = $scope.newPersonName;
            console.log("adding" + _person)
            // TODO: Add person
            $http({
                method: "POST",
                url: "/api/people",
                data: { Name: _person }
            }).then(resp => {
                loadLatestList();
            })
        }
        $scope.deletePerson = (person) => {
            // TODO: Add person
            $http({
                method: "DELETE",
                url: "/api/people/"+person.Id,
            }).then(resp => {
                loadLatestList();
            })
        }

        const createGroup = (groupSize) => {
            $http({
                method: "POST",
                url: "/api/groups",
                data: {
                    Name: $scope.groupName,
                    Size: groupSize
                }
            }).then(resp => {
                $scope.groups = resp.data;
            })
        }

        $scope.createGroups = () => {
            createGroup($scope.groupSize)
        }

        $scope.divideIntoNumberOfGroups = () => {
            // do a little math to get the group size,
            const groupSize = Math.round($scope.names.length / $scope.numberOfGroups)
            // call out existing funationality
            createGroup(groupSize);
        }

        const init = () => {
            loadLatestList();
        }


        init();

    }])