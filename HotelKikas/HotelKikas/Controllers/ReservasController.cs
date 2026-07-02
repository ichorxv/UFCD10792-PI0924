using HotelKikas.Model;
using Microsoft.AspNetCore.Mvc;

namespace HotelKikas.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ReservasController : Controller
    {
        [HttpGet(Name = "Reservas")]
        
        public JsonResult GetReservas() 
        {
            var result = new ReservasResult
            {
                id = Random.Shared.Next(1, 10),
                numeroQuarto = 10,
                cliente = "ola",
            };
            return new JsonResult(Ok());
        }

        [HttpPost(Name = "Reservas")]

        public JsonResult PostReservas( ReservasRequest hotel )
        {
            var result = new ReservasResult
            {
                id = Random.Shared.Next(1, 10),
                numeroQuarto = hotel.numeroQuarto,
                cliente = hotel.cliente,
            };
            return new JsonResult(Ok());
        }
    }
}
