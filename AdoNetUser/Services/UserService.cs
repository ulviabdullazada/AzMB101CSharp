using AdoNetUser.Helpers;
using AdoNetUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetUser.Services
{
    internal class UserService
    {
        public int Register(User data)
        {
            //hash passwword
            string query = $"INSERT INTO Users VALUES (N'{data.Name}', N'{data.Surname}', N'{data.Password.HashSHA512("ackili royal")}')";
            return SqlHelper.Exec(query);
        }
        public void Login(string username, string password){
           
        }
    }
}
