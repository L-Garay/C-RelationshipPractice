using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using relationships.Models;
using relationships.Services;

namespace relationships.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PeopleHobbyController : ControllerBase
  {
    private readonly PeopleHobbysService _phs;
    public PeopleHobbyController(PeopleHobbysService phs)
    {
      _phs = phs;
    }
    [HttpPost]
    public ActionResult<String> Create([FromBody] PeopleHobby newData)
    {
      try
      {
        _phs.Create(newData);
        return Ok("Success");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("/removeStudent")]
    public ActionResult<String> Edit([FromBody] PeopleHobby cs)
    {
      try
      {
        return Ok(_phs.Delete(cs));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}