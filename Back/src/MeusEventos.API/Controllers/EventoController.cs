using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeusEventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MeusEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
            
        }

        public IEnumerable<Evento> _evento = new Evento[] 
            { 
                new Evento()
                {
                    EventoId = 1,
                    Tema = "Confraternização",
                    Local = "Home Sweet Home",
                    QtdPessoas = 250,
                    Lote       = "001",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL   = "Foto.png",
                },
                new Evento()
                {
                    EventoId = 2 ,
                    Tema = "Churrasco",
                    Local = "AABB",
                    QtdPessoas = 400,
                    Lote       = "001",
                    DataEvento = DateTime.Now.AddDays(18).ToString("dd/MM/yyyy"),
                    ImagemURL   = "Foto2.png",
                }

            };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPut("{id}")]
        public String Put(int id)
        {
            return $"Exemplo de Put. Id = {id}";
        }
    }
}
