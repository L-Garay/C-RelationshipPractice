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
  public class PersonController : ControllerBase
  {
    private readonly PersonsService _ps;
    public PersonController(PersonsService ps)
    {
      _ps = ps;

    }

    [HttpGet]
    public ActionResult<IEnumerable<Person>> Get()
    {
      try
      {
        return Ok(_ps.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Person> Get(int id)
    {
      try
      {
        return Ok(_ps.GetById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Person> Create([FromBody] Person newData)
    {
      try
      {
        return Ok(_ps.Create(newData));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Person> Edit([FromBody] Person update, int id)
    {
      try
      {
        update.Id = id;
        return Ok(_ps.Edit(update));
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
        return Ok(_ps.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}