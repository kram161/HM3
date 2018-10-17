using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM44
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFilm> F = new List<IFilm>()
            {
                new Comedy("бабушка легкого поведения",110,2018, new List<Days>{ Days.Sunday,Days.Monday,Days.Tuesday,Days.Wednesday})
            };

            foreach (var x in F)
            {
                Console.WriteLine("Название фильма:" + x.FilmName);
                Console.WriteLine("Длительность фильма:" + x.MovieDuration);
                Console.WriteLine("Год премьеры фильма:" + x.YearOfIssue);
                Console.WriteLine("Дни показа:");
                    foreach (var y in x.DaysOfShow)
                    Console.WriteLine(y.ToString());
            }
            Console.ReadKey();
        }
    }
}
