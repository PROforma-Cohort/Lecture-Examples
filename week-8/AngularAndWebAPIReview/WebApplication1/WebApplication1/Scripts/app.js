console.log("app loaded");


angular
    .module("main", [])
    .controller("searchController", ["$scope", "$http", ($scope, $http) => {
        $scope.books = [];
        
        const searchForBooks = () => {
            let searchUrl = "/api/search"
            if ($scope.searchTerm) {
                searchUrl += "?title=" + $scope.searchTerm
            }
            $http({
                method: "GET",
                url: searchUrl
            }).then(resp => {
                $scope.books = resp.data;
            })
        }

        $scope.searchBooks = () => {
            searchForBooks();
        }

        $scope.checkOutBook = (book) => {
            //PUT
            $http({
                method: "PUT",
                url: "/api/checkout/" + book.Id,
                data: {
                    email:$scope.email
                }
            }).then(resp => {
                /*Expected format from API:
                    {
                        Duebackdate: datetime
                        message: string
                        success: bool
                    }
                */
                console.log(resp.data)
                book.IsCheckedOut = true;
                book.DueBackDate = resp.data.DueBackDate;
                book.Message = resp.data.Message;
            })
        }

        var init = () => {
            $scope.welcomeMessage = "Welcome to the Library!"
            // populate our book list from our API
            searchForBooks();
        }


        init();
    }])