using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


/* Questions: 
    X View Models?!?
    X pulling in (including) Author and Genre in Books 
    - PUTS
    - checking out and Emails?
   
    - More about Standard .NET Design, MVC
    
    
    - Authenicate
    - API Key
*/

namespace ShoeAPI.Controllers
{
    public class ShoppingCartViewModel
    {
        public int ShoeId { get; set; }
        public int Quantity { get; set; }
    }

    public class CheckOutViewModel
    {
        public string Email { get; set; }
    }

    public class ShoppingCartController : ApiController
    {
        // Using a better URL for the shopping cart
        [HttpPut]
        [Route("api/shoppingcart/{userId}")]
        public IHttpActionResult AddShoeToShopping([FromUri] int userId, [FromBody]CheckOutViewModel data)
        {
            var who = data.Email;
            var timestamp = DateTime.Now;
            var dueBackdate = DateTime.Now.AddDays(10);


            //check the book status
            // if book is availible 
            // checkout and return Ok(book, dueback)
            // else 
                //return Ok(message ="Book is unavailible"} 
            return Ok(new { Message = "Successfully checked out book", DueBackDate = DateTime.Now.AddDays(10) });
        }
    }
}
