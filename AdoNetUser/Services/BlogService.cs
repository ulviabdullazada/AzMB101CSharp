using AdoNetUser.Helpers;
using AdoNetUser.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetUser.Services
{
    internal class BlogService : IBaseService<Blog>
    {
        public int Create(Blog data)
        {
            string query = $"INSERT INTO Blogs VALUES (N'{data.Title}', N'{data.Description}', )";
            return SqlHelper.Exec(query);
        }

        public ICollection<Blog> GetAll()
        {
            DataTable dt = SqlHelper.GetDatas("SELECT * FROM Blogs");
            ICollection<Blog> list = new List<Blog>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Blog
                {
                    Id = (int)row["Id"],
                    Title = (string)row["Title"],
                    Description = (string)row["Description"],
                    UserId = (int)row["UserId"]
                });
            }
            return list;
        }

        public Blog GetById(int id)
        {
            DataTable dt = SqlHelper.GetDatas($"SELECT * FROM Blogs where Id={id}");
            foreach (DataRow row in dt.Rows)
            {
                Blog blog = new Blog
                {
                    Id = (int)row["Id"],
                    Title = (string)row["Title"],
                    Description = (string)row["Description"],
                    UserId = (int)row["UserId"]
                };
               return blog;
            }
            return null;
        }
    }
}
