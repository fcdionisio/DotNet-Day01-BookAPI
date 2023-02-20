using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookAPI.Models;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        [Route("ListAll")]
        [Route("All")]
        [Route("ShowAll")]
        public string ViewAllBooks()
        {
            return "View ALL books...";
        }

        [HttpGet]
        [Route("Display/{id:int:min(1)}")]

        public ActionResult<Book> DisplayBook(int id)
        {
            Book mybook = new Book() { BookId = id, Name = "Life of Ferdie", Author = "My self", AgeLimit = 18, Price = 32000, Publisher = "FCD Book Inc" };

            return mybook;
        }

        [HttpDelete]
        [Route("Delete/{id:int:min(1)}")]
        public string DeleteBook(int id)
        {
            return $"Deleting a book with ID = {id}...";
        }

        [HttpPost]
        [Route("Save")]
        public ActionResult<Book> SaveBook()
        {
            Book mybook = new Book() { BookId=1,Name="Life of Ferdie",Author="My self", AgeLimit = 18, Price=32000, Publisher="FCD Book Inc"};
            return mybook;
        }

        [HttpPut]
        [Route("Update/{id:int:min(1)}")]
        public ActionResult<Book> UpdateBook(int Id)
        {
            Book mybook = new Book() { BookId = Id, Name = "Life of Ferdie", Author = "My self", AgeLimit = 18, Price = 32000, Publisher = "FCD Book Inc" };
            return mybook;
        }

    }
}
