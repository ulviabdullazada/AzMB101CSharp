using ADO.NET.Helpers;
using ADO.NET.Models;
using System.Data;

namespace ADO.NET.Services;

public class ArtistService : IBaseService<Artist>
{
    public int Create(Artist data)
    {
        string query = $"INSERT INTO Artists VALUES (N'{data.Name}', N'{data.Surname}', getdate())";
        return SqlHelper.Exec(query);
    }

    public int Delete(int id)
    {
        string query = $"DELETE Artists WHERE Id = {id}";
        return SqlHelper.Exec(query);
    }

    public List<Artist> GetAll()
    {
        DataTable dt = SqlHelper.GetDatas("SELECT * FROM Artists");
        List<Artist> list = new List<Artist>();
        foreach (DataRow row in dt.Rows)
        {
            list.Add(new Artist
            {
                Id = (int)row["Id"],
                Name = (string)row["Name"],
                Surname = (string)row["Surname"],
                BirthDate = row["BirthDate"] != DBNull.Value ? (DateTime?)row["BirthDate"] : null,
            });
        }
        return list;
    }

    public Artist GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Artist> GetWhere(string query)
    {
        throw new NotImplementedException();
    }

    public int Update(int id, Artist data)
    {
        throw new NotImplementedException();
    }
}
