using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM44
{
    public interface IFilm
    {
        string FilmName { get; set; }
        int MovieDuration { get; set; }
        int YearOfIssue { get; set; }
        List<Days> DaysOfShow { get; set; }


        void BeginningOfFilm(Action<string> Message);

        void EndOfFilm(Action<string> Message);
    }
}
