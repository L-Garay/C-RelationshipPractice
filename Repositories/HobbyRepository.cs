using System.Collections.Generic;
using System.Data;
using Dapper;
using relationships.Models;

namespace relationships.Repositories
{
  public class HobbyRepository
  {
    private readonly IDbConnection _db;
    public HobbyRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Hobby> Get()
    {
      string sql = "SELECT * FROM hobbys";
      return _db.Query<Hobby>(sql);
    }

    internal Hobby GetById(int Id)
    {
      string sql = "SELECT * FROM hobbys WHERE id = @Id";
      return _db.QueryFirstOrDefault<Hobby>(sql, new { Id });

    }

    internal Hobby Create(Hobby newData)
    {
      string sql = @"INSERT INTO hobbys (name, description) VALUES (@Name, @Description); SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newData);
      newData.Id = id;
      return newData;
    }

    internal void Edit(Hobby update)
    {
      string sql = @"
            UPDATE hobbys
            SET 
            name = @Name, description = @Description
            WHERE id = @Id; 
            ";
      _db.Execute(sql, update);
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM hobbys WHERE id = @id";
      _db.Execute(sql, new { id });
    }
  }
}