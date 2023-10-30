namespace AzMIU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] stds =
            {
                new Student
                {
                    Name = "Isa",
                    Surname = "Aliyev"
                },
                new Student
                {
                    Name = "Vugar",
                    Surname = "Samadov"
                },
                new Student
                {
                    Name = "Vugar",
                    Surname = "Samadov"
                }
            };
            foreach (Student student in stds)
            {
                Console.WriteLine(student);
            }
        }
    }
}