namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new { Id = 1, Fullname = "Telman Mammedov", Age = 18, Schoolarship = 300 };
            var student2 = new { Id = 2, Fullname = "Eliyar Aliyev", Age = 19, Schoolarship = 400 };
            var student3 = new { Id = 3, Fullname = "Fuad Kazimov", Age = 20, Schoolarship = 500 };
            var student4 = new { Id = 4, Fullname = "Zakir Qurbanov", Age = 21, Schoolarship = 600 };
            var student5 = new { Id = 5, Fullname = "Elman Qasimov", Age = 22, Schoolarship = 700 };

            var students = new[] { student1, student2, student3, student4, student5 };


            //foreach (var All in students)
            //{
            //    Console.WriteLine($"Fullname:{All.Fullname}");
            //    Console.WriteLine($"Id:{All.Id}");
            //    Console.WriteLine($"Sc:{All.Schoolarship}");

            //}

            int prices = 0;
            int count = 0;


            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);

                if (students[i].Id % 2 == 1)
                {
                    prices += students[i].Schoolarship;
                    count++;
                }

            }

            Console.WriteLine(prices / count);

        }
    }
}
