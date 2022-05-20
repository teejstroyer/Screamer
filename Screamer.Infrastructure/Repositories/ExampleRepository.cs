using System.Data;
using Npgsql;
using Screamer.Domain.Models;
using Screamer.Infrastructure.Repositories.Interfaces;

namespace Screamer.Infrastructure.Repositories
{
  public class ExampleRepository : IExampleRepository
  {

    private readonly NpgsqlConnection _db;

    public ExampleRepository(NpgsqlConnection db)
    {
      _db = db;
    }

    public int Add(Example example)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Example> GetAll()
    {
      string sql = "SELECT * FROM Example";
      var da = new NpgsqlDataAdapter(sql, _db);
      var ds = new DataSet();
      DataTable dt;
      try
      {
        _db.Open();
        ds.Reset();
        da.Fill(ds);
        dt = ds.Tables[0];
        _db.Close();

      }
      catch (Exception msg)
      {
        Console.WriteLine(msg.Message);
        throw;
      }

      return dt.ToExampleEnumerable();
    }

    public void Update(Example example)
    {
      throw new NotImplementedException();
    }

    Example IExampleRepository.GetById(int id)
    {
      throw new NotImplementedException();
    }
  }

  public static class ExampleExtension
  {
    public static Example ToExample(this DataRow r)
    {
      return new Example()
      {
        Id = r.Field<int>("Id"),
        Name = r.Field<string?>("Name"),
        Age = r.Field<int>("Age"),
      };
    }

    public static IEnumerable<Example> ToExampleEnumerable(this DataTable dt)
    {
      foreach (DataRow r in dt.Rows)
      {
        yield return r.ToExample();
      }
    }

  }

}
