using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class Person : ControllerBase
    {

   
            public int Id { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public DateOnly Birthday { get; set; }
            public int Age { get; set; }
    }
}
