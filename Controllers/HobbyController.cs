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
  public class HobbyController : ControllerBase
  {
    private readonly HobbysService _hs;
    public HobbyController(HobbysService hs)
    {
      _hs = hs;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Hobby>> Get()
    {
      try
      {
        return Ok(_hs.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Hobby> Get(int id)
    {
      try
      {
        return Ok(_hs.GetById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Hobby> Create([FromBody] Hobby newData)
    {
      try
      {
        return Ok(_hs.Create(newData));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Hobby> Edit([FromBody] Hobby update, int id)
    {
      try
      {
        update.Id = id;
        return Ok(_hs.Edit(update));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<String> Delete(int id)
    {
      try
      {
        return Ok(_hs.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}