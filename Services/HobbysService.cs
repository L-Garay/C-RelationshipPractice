using System;
using System.Collections.Generic;
using relationships.Models;
using relationships.Repositories;

namespace relationships.Services
{
  public class HobbysService
  {
    private readonly HobbyRepository _hr;
    public HobbysService(HobbyRepository hr)
    {
      _hr = hr;
    }
    internal IEnumerable<Hobby> Get()
    {
      return _hr.Get();
    }

    internal Hobby GetById(int id)
    {
      var exists = _hr.GetById(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      return exists;
    }

    internal Hobby Create(Hobby newData)
    {
      _hr.Create(newData);
      return newData;
    }

    internal Hobby Edit(Hobby update)
    {
      var exists = _hr.GetById(update.Id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      _hr.Edit(update);
      return update;

    }

    internal string Delete(int id)
    {
      var exists = _hr.GetById(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      _hr.Delete(id);
      return "Successfully deleted..";
    }
  }
}