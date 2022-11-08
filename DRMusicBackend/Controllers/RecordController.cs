using DRMusicBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DRMusicBackend.Managers;

namespace DRMusicBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecordController : ControllerBase
    {
        private RecordManager _records = new RecordManager();
        
        private readonly ILogger<RecordController> _logger;

        public RecordController(ILogger<RecordController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRecords")]
        public async Task<IActionResult> Get()
        {
            return Ok(_records.getAll());
        }
        [HttpPost]
        public async Task<IActionResult> Post(Record record)
        {
            try
            {
                _records.add(record);
                return Ok();

            }
            catch(ArgumentException ex)
            {
                    return BadRequest(ex.Message);
            }
            
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {

            try
            {
                _records.Remove(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(601, ex.Message);
            }
            
        }


    }
}