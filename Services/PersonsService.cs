using System;
using System.Collections.Generic;
using relationships.Models;
using relationships.Repositories;

namespace relationships.Services
{
  public class PersonsService
  {
    private readonly PersonRepository _pr;
    public PersonsService(PersonRepository pr)
    {
      _pr = pr;
    }

    internal IEnumerable<Person> Get()
    {
      return _pr.Get();
    }

    internal Person GetById(int id)
    {
      var exists = _pr.GetById(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      return exists;
    }

    internal Person Create(Person newData)
    {
      _pr.Create(newData);
      return newData;
    }

    internal Person Edit(Person update)
    {
      var exists = _pr.GetById(update.Id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      _pr.Edit(update);
      return update;

    }

    internal string Delete(int id)
    {
      var exists = _pr.GetById(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      _pr.Delete(id);
      return "Successfully deleted..";
    }
  }
}