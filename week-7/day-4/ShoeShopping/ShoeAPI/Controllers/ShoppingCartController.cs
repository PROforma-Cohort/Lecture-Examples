using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoeAPI.Controllers
{
    public class ShoppingCartViewModel
    {
        public int ShoeId { get; set; }
        public int Quantity { get; set; }
    }


    public class ShoppingCartController : ApiController
    {
        [HttpPost]
        [Route("api/shoppingcart/{userId}")]
        public IHttpActionResult AddShoeToShopping([FromUri] int userId, [FromBody]ShoppingCartViewModel data)
        {

            return Ok();
        }
    }
}
