using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catapi.DataBase;
using catapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace catapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatController : ControllerBase
  {

    List<Cat> Cats = Data.Cats;


    [HttpGet]
    public ActionResult<List<Cat>> Get()
    {
      return Cats;
    }

    [HttpGet("{id}")]
    public ActionResult<Cat> Get(int id)
    {
      Cat found = Cats.Find(c => c.Id == id);
      if (found != null)
      {
        return found;
      }
      return BadRequest("NOT FOUND");
    }

    [HttpPost]
    public ActionResult<List<Cat>> Post([FromBody] Cat value)
    {
      Cats.Add(value);
      return Cats;
    }

    [HttpPut("{id}")]
    public ActionResult<Cat> Put(int id, [FromBody] Cat newdata)
    {
      Cat oldData = Cats.Find(c => c.Id == id);
      if (oldData == null) { return BadRequest(); }
      Cats.Remove(oldData);
      Cats.Add(newdata);
      return newdata;
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      Cat oldData = Cats.Find(c => c.Id == id);
      if (oldData == null) { return BadRequest(); }
      Cats.Remove(oldData);
      return Ok();
    }
  }
}