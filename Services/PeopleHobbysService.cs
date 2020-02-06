using System;
using relationships.Models;
using relationships.Repositories;

namespace relationships.Services
{
  public class PeopleHobbysService
  {
    private readonly PeopleHobbyRepository _phr;
    public PeopleHobbysService(PeopleHobbyRepository phr)
    {
      _phr = phr;
    }
    internal string Create(PeopleHobby newData)
    {
      PeopleHobby exists = _phr.Find(newData);
      if (exists != null) { throw new Exception("Student already enrolled"); }
      _phr.Create(newData);
      return "Successfully Joined";
    }

    internal string Delete(PeopleHobby cs)
    {
      PeopleHobby exists = _phr.Find(cs);
      if (exists == null) { throw new Exception("Invalid Id Combination"); }
      _phr.Delete(exists.Id);
      return "Successfully Deleted";
    }
  }
}