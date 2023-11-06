using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BadgeWatch.Data;
using BadgeWatch.Models;
using BadgeWatch.Models.Dto;
using BadgeWatch.Models.Views;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BadgeWatch.Controllers
{
    [Route("api/[controller]")]
    public class RecordController : Controller
    {
        private readonly PublicRecordsContext _dbcontext;
        public RecordController(PublicRecordsContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        [HttpGet]
        public ActionResult<RecordDto> GetRecords()
        {
            return Ok(_dbcontext.Records.ToList());
        }
        [HttpGet("id")]
        public ActionResult<RecordDto> GetRecord(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var record = _dbcontext.Records.SingleOrDefault(u=>u.Id == id);
            if (record is null)
            {
                return NotFound();
            }
            return Ok(record);
        }
        public ActionResult<RecordsView> GetRecordByOfficerId(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var record = _dbcontext.RecordsView.Where(r => r.OfficerId == id).ToList();
            if(record is null)
            {
                return NotFound();
            }
            return Ok(record);
        }
    }
}
