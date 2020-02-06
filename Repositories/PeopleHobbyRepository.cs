using System.Data;
using Dapper;
using relationships.Models;

namespace relationships.Repositories
{
  public class PeopleHobbyRepository
  {
    private readonly IDbConnection _db;
    public PeopleHobbyRepository(IDbConnection db)
    {
      _db = db;
    }
    internal PeopleHobby Find(PeopleHobby ph)
    {
      string sql = "SELECT * FROM peoplehobbys WHERE (personId = @personId AND hobbyId = @hobbyId)";
      return _db.QueryFirstOrDefault(sql, ph);
    }


    internal PeopleHobby Create(PeopleHobby newData)
    {
      string sql = @"
            INSERT INTO peoplehobbys 
            (personId, hobbyId) 
            VALUES 
            (@personId, @hobbyId);
            SELECT LAST_INSERT_ID();
            ";
      int id = _db.ExecuteScalar<int>(sql, newData);
      newData.Id = id;
      return newData;
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM peoplehobbys WHERE id = @id";
      _db.Execute(sql, new { id });
    }
  }
}