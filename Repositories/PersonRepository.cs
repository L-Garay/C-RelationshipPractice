using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using relationships.Models;

namespace relationships.Repositories
{
  public class PersonRepository
  {

    private readonly IDbConnection _db;
    public PersonRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Person> Get()
    {
      string sql = "SELECT * FROM persons";
      return _db.Query<Person>(sql);
    }

    internal Person GetById(int Id)
    {
      string sql = "SELECT * FROM persons WHERE id = @Id";
      return _db.QueryFirstOrDefault<Person>(sql, new { Id });

    }

    internal Person Create(Person newData)
    {
      string sql = @"INSERT INTO persons (name) VALUES (@Name); SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newData);
      newData.Id = id;
      return newData;
    }

    internal void Edit(Person update)
    {
      string sql = @"
            UPDATE persons
            SET 
            name = @Name,
            WHERE id = @Id; 
            ";
      _db.Execute(sql, update);
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM persons WHERE id = @id";
      _db.Execute(sql, new { id });
    }
  }
}