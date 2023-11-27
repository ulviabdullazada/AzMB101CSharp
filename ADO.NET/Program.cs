using ADO.NET.Helpers;
using ADO.NET.Models;
using ADO.NET.Services;
using System.Text;

namespace ADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            //string name = Console.ReadLine();
            //string surname = Console.ReadLine();
            #region SDA
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    DataTable dt = new DataTable();
            //    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Artists", connection))
            //    {
            //        sda.Fill(dt);
            //    }
            //    connection.Close();
            //    foreach (DataColumn dc in dt.Columns)
            //    {
            //        Console.Write(dc + " ");
            //    }
            //    Console.Write("\n");
            //    foreach (DataRow item in dt.Rows)
            //    {
            //        Console.WriteLine(item[0] + " " + item[1] + " " + item["Surname"] + "-" + item[3]);
            //    }
            //}
            #endregion
            #region Command
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand($"INSERT INTO Artists VALUES (N'{name}', N'{surname}', NULL)", connection))
            //    {
            //        command.ExecuteNonQuery();
            //    }
            //    connection.Close();
            //}
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand($"SELECT * FROM Artists", connection))
            //    {
            //        SqlDataReader a = command.ExecuteReader();
            //        List<object> list = new List<object>();
            //        while (a.HasRows) 
            //        {
            //            list.Add(a.Read());
            //        }
            //    }
            //    connection.Close();
            //}

            #endregion
            //var a = SqlHelper.Exec("Select * from Artists");
            //Console.WriteLine(a);
            ArtistService artistService = new ArtistService();
            //artistService.GetAll();
            
            Artist a = new Artist
            {
                Name = Console.ReadLine(),
                Surname = Console.ReadLine(),
            };
            artistService.Create(a);
            foreach (var artist in artistService.GetAll())
            {
                Console.WriteLine($"{artist.Id} {artist.Name} {artist.Surname} {artist.BirthDate}");
            }
        }
    }
}