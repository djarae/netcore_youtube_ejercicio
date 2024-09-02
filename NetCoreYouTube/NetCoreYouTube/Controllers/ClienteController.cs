using Microsoft.AspNetCore.Mvc;
using NetCoreYouTube.Models;
using System.Numerics;

namespace NetCoreYouTube.Controllers


{

    [ApiController]
    [Route("cliente")]
    public class CllienteController : ControllerBase
    {

        [HttpGet]
        [Route("listar")]
        public dynamic listarCliente(int idCliente )
        {
            //Todo el codigo que quieras
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                    id = "1",
                    nombre = "Diego Jara",
                    edad = "30",
                    correo = "correoprueba@gmail.com"

                },
                new Cliente
                {
                    id = "2",
                    nombre="Pedro diaz",
                    edad ="20",
                    correo ="a@gmail.com"
                }

            };
            //return clientes;
            return idCliente;

        }

        [HttpPost]
        [Route("guardar")]
        public dynamic guardarCliente(Cliente cliente)
        {
            //cliente.id = "3";
            return new
            {

                success = true,
                message = "Cliente Registrado",
                result = cliente.id
            };
        }
    }
}
