using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using WebApplication3.LAB3;
using Rectangle = WebApplication3.LAB3.Rectangle;

namespace WebApplication3.Controllers.LAB3
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public int GetArea()
        {
            var rec = new Rectangle(23, 23);
            return rec.GetArea();
        }

        [HttpGet]
        public int GetSumArea()
        {
            var rec = new Rectangle(4, 4);
            var rec2 = new Rectangle(3, 3);
            var result = rec + rec2;
            return result.GetArea();

        }
    }

}
