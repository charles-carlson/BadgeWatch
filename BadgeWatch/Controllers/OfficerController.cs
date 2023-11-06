using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BadgeWatch.Models;
using BadgeWatch.Models.Dto;
using Microsoft.AspNetCore.Http;
using BadgeWatch.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BadgeWatch.Controllers
{
    [Route("api/[controller]")]
    public class OfficerController : Controller
    {
        private readonly PublicRecordsContext _dbcontext;
        public OfficerController(PublicRecordsContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<OfficerDto>> GetOfficers()
        {
            //Task: Get All Officers from DB
            return Ok(_dbcontext.OfficersView.ToList());
        }
        [HttpGet("id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<OfficerDto> GetOfficer(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var officer = _dbcontext.Officers.SingleOrDefault(u=>u.Id == id);
            if (officer == null)
            {
                return NotFound();
            }
            return Ok(officer);
        }
        [HttpGet("Name")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<OfficerDto> GetOfficer(string name)
        {
            if (name == "")
            {
                return BadRequest();
            }
            var officer = _dbcontext.Officers.SingleOrDefault(u => u.Name == name);
            if (officer == null)
            {
                return NotFound();
            }
            return Ok(officer);
        }
        [HttpGet("BadgeNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<OfficerDto> GetOfficerByBadgeNumber(int badgeNumber)
        {
            if (badgeNumber == 0)
            {
                return BadRequest();
            }
            var officer = _dbcontext.Officers.SingleOrDefault(u => u.BadgeNumber == badgeNumber);
            if (officer == null)
            {
                return NotFound();
            }
            return Ok(officer);
        }
        [HttpGet("city")]
        public ActionResult<IEnumerable<OfficerDto>> GetOfficersByCity(string city)
        {
            if (city == "")
            {
                return BadRequest();
            }
            var officers = _dbcontext.Officers.Where(u => u.City == city).ToList();
            if (officers == null)
            {
                return NotFound();
            }
            return Ok(officers);
        }
        [HttpGet("Precinct")]
        public ActionResult<IEnumerable<OfficerDto>> GetOfficersByPrecint(string precinct)
        {
            if (precinct == "")
            {
                return BadRequest();
            }
            var officers = _dbcontext.Officers.Where(u => u.Precinct == precinct).ToList();
            if (officers == null)
            {
                return NotFound();
            }
            return Ok(officers);
        }

    }
    
}
