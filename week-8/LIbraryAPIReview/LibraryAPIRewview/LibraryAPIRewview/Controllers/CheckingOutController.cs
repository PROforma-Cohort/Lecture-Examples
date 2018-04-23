using LibraryAPIRewview.Context;
using LibraryAPIRewview.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryAPIRewview.Controllers
{
    public class CheckingOutController : ApiController
    {
        [HttpPut]
        [Route("api/book/{bookId}/checkout")]
        public CheckOutReceiptViewModel Put([FromUri]int bookId, [FromBody]CheckOutViewModel data)
        {
            var db = new LibraryContext();
            // find the book
            var book = db.Books.Single(s => s.Id == bookId);
            if (!book.IsCheckedOut)
            {
                book.IsCheckedOut = true;
                book.DueBackDate = DateTime.Now.AddDays(10);
                db.SaveChanges();
                //TODO: add to ledger   
                return new CheckOutReceiptViewModel
                {
                    Message = "Not here,pal., try again later",
                    DuebackDate = book.DueBackDate
                };
            }
            else
            {
                return new CheckOutReceiptViewModel
                {
                    Message = "Not here,pal., try again later",
                    DuebackDate = book.DueBackDate
                };
                // return Ok({message = " ", duebackDate = the date the book is due back)

            }
        }
    }
}
