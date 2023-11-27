using ADO.NET.Models;

namespace ADO.NET.Services;
public interface IBaseService<T>
{ 
    List<T> GetAll();
    List<T> GetWhere(string query);
    T GetById(int id);
    int Create(T data);
    int Update(int id, T data);
    int Delete(int id);
}
