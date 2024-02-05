using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class User
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public QuizEntity Quiz { get; internal set; }

        public void GetUserData()
        {
            Console.WriteLine("Podaj swoje dane:");

            Console.Write("Podaj swój wiek: ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Podaj swoją masę ciała [kg]: ");
            Weight = double.Parse(Console.ReadLine());

            Console.Write("Podaj swój wzrost [cm]: ");
            Height = int.Parse(Console.ReadLine());
        }
    }
}
