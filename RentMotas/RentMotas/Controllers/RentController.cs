using Microsoft.AspNetCore.Mvc;
using RentMotas.Model;

namespace RentMotas.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class RentController : Controller
    {
        
        public static readonly List<RentModelos> KawasakiModelos = new()
        {
            new RentModelos { Modelo = "Ninja 400", Preco = 250 },
            new RentModelos { Modelo = "Ninja ZX6-R", Preco = 500 },
            new RentModelos { Modelo = "Ninja ZX10-R", Preco = 1000 },
            new RentModelos { Modelo = "Ninja H2R", Preco = 2500 },
            new RentModelos { Modelo = "Ninja ZX14-R", Preco = 2000 }
        };

        [HttpGet(Name = "RentMotas")]

        public JsonResult GetRentMotas()
        {
            var result = new RentResult()
            {
                 Id = Random.Shared.Next(1, 10),
                 Nome = "jose",
                 Numero = 935444333,
                 Marca = "Kawasaki",
                 Modelos = new List<RentModelos>
                 {
                    new RentModelos{Modelo="Ninja 400", Preco=250},
                    new RentModelos{Modelo="Ninja ZX6-R", Preco=500},
                    new RentModelos{Modelo="Ninja ZX10-R", Preco=1000},
                    new RentModelos{Modelo="Ninja H2R", Preco=2500},
                    new RentModelos{Modelo="Ninja ZX14-R", Preco=2000},
                 }
            };
            return new JsonResult(Ok(result));
        }

        [HttpPost(Name = "RentMotas")]

        public JsonResult PostReservas(RentRequests rent)
        {
            var result = new RentResult()
            {
                Id = Random.Shared.Next(1, 10),
                Nome = rent.Nome,
                Numero = rent.Numero,
                Marca = rent.Marca,
                Modelos = new List<RentModelos>()
            };
            if (string.Equals(rent.Marca, "Kawasaki", StringComparison.OrdinalIgnoreCase))
            {
                result.Modelos = KawasakiModelos;
            }
            return new JsonResult(Ok(result));
        }
    }
}
