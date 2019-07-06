using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StatlerWaldorfCorp.LocationService.Models;
using StatlerWaldorfCorp.LocationService.Persistance;

namespace StatlerWaldorfCorp.LocationService.Controllers
{
    [Route("locations/{memberId}")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILocationRecordRepository _locationRecordRepository;

        public LocationController(ILocationRecordRepository locationRecordRepository)
        {
            _locationRecordRepository = locationRecordRepository;
        }

        [HttpPost]
        public IActionResult AddLocation(Guid memberId,[FromBody]LocationRecord locationRecord)
        {
            _locationRecordRepository.Add(locationRecord);
            return this.Created($"/locations/{memberId}/{locationRecord.ID}",
                locationRecord);
        }

        [HttpGet]
        public IActionResult GetLocationsForMember(Guid memberId)
        {
            return Ok(_locationRecordRepository.AllForMember(memberId));
        }

        [HttpGet("latest")]
        public IActionResult GetLatestForMember(Guid memberId)
        {
            return Ok(_locationRecordRepository.GetLatestForMember(memberId));
        }
    }
}
