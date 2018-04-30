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


        $scope.createGroups = () => {
            $http({
                method: "POST",
                url: "/api/groups",
                data: {
                    Name: $scope.groupName,
                    Size: $scope.groupSize
                }
            }).then(resp => {
                $scope.groups = resp.data;
            })
        }

        const init = () => {
            loadLatestList();
        }


        init();

    }])