using DRMusicBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace DRMusicBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecordController : ControllerBase
    {

        private static List<Record> _records = new List<Record>()
        {
            new Record(){ Id = 0, Artist = "Eminem", Duration = 180, Title="When im gone", PublicationYear = 1999},
            new Record() { Id = 1 ,Artist= "Nirvana", Duration= 300, Title="Some", PublicationYear=1997 },
            new Record(){ Id = 2, Artist = "Metallica", Duration = 230, Title="One", PublicationYear = 2000}
        };

        private readonly ILogger<RecordController> _logger;

        public RecordController(ILogger<RecordController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRecords")]
        public async Task<IActionResult> Get()
        {
            return Ok(_records);
        }
        [HttpPost]
           public async Task<IActionResult> Post(Record record)
        {
            _records.Add(record);
            return Ok();

        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            _records.RemoveAt(id);
             return Ok();
            
        }


    }
}