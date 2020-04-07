using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TicketAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class JourneiesController : Controller
    {
        private IJourneyService _journeyService;
        public JourneiesController(IJourneyService journeyService)
        {
            _journeyService = journeyService;
        }
        [HttpGet("getlistbyjourneydate")]
        public IActionResult GetListByJourneyDate(DateTime journeyDate, string station, string destination)
        {
            var result = _journeyService.GetListByJourneyDate(journeyDate,station,destination);
            if(result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}