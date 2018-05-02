angular
  .module("main", [])
  .controller("mainController", [
    "$scope",
    "$http",
    ($scope, $http) => {
      // login 
      $scope.login = () => {
        // take username and password, 
        const data = {
          username: $scope.username, 
          password: $scope.password,
          grant_type:"password"
        }
        // do the post
        $http({
          url:"http://localhost:51423/token",
          method:"POST",
          data:data, 
          headers:{
            "Content-Type":"application/x-www-form-urlencoded"
          },
          transformRequest: function(obj) {
            var str = [];
            for(var p in obj)
            str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
            return str.join("&");
        },
        }).then(resp => {
          console.log(resp)
          // store the token
          if (resp.status == 200){
            localStorage.setItem("token", resp.data.access_token);
          }
        })

      }
      // show order 
    

    }
  ]);