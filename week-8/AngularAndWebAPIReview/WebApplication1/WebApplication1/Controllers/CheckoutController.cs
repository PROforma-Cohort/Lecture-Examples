using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Context;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class CheckoutController : ApiController
    {
        [HttpPut]
        [Route("api/checkout/{bookId}")]
        public IHttpActionResult CheckoutBook([FromUri] int bookId, [FromBody]CheckOutRequestViewModel body)
        {
            // gt the book,
            using (var db = new LibraryContext())
            {
                var book = db.Books.SingleOrDefault(s => s.Id == bookId);
                if (book == null)
                {
                    return NotFound();
                }
                // toggle the checkout
                book.IsCheckedOut = true;
                // add duedate
                var dueBackDate = DateTime.Now.AddDays(10);
                book.DueBackDate = dueBackDate;
                // Add to ledger
                var ledger = new BookLedger {
                   Email = body.Email, 
                   BookId = book.Id
                };
                db.BookLedgers.Add(ledger);
                // Save Changes
                db.SaveChanges();
                // return the message
                var rv = new CheckoutRecieptViewModel
                {
                    DueBackDate = dueBackDate,
                    Message = "Successfully checked out " + book.Title,
                    Success = true
                };
                return Ok(rv);

            }
        }
    }
}
