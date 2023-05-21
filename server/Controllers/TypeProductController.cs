using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeProductController : ControllerBase
    {
        // private readonly IConfiguration _configuration;
        private readonly NpgsqlConnection _connection;
        public TypeProductController(IConfiguration configuration){
            // _configuration = configuration;
            _connection = new NpgsqlConnection(
                configuration.GetConnectionString("MyConnection")
            );
        }

        [HttpGet]
        public IActionResult GetAll(){
            _connection.Open();
            using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM types_product", _connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    List<object> result = new List<object>();

                    while (reader.Read())
                    {
                        result.Add(
                            new 
                            {
                                id = reader.GetInt32(0),
                                typeTitle = reader.GetString(1)
                            }
                        );
                    }

                    return Ok(result);
                }
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id){
            _connection.Open();
            using (NpgsqlCommand command = new NpgsqlCommand($"SELECT * FROM types_product where id = {id}", _connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    List<object> result = new List<object>();

                    while (reader.Read())
                    {
                        result.Add(
                            new 
                            {
                                id = reader.GetInt32(0),
                                typeTitle = reader.GetString(1)
                            }
                        );
                    }

                    return Ok(result);
                }
            }
        }
        // protected virtual void Disponse(bool disponse){
        //     if(disponse){
        //         _connection.Dispose();
        //     }
        //     base.Disponse();
        // }


    }
}
