using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM44
{
    public class Comedy:DomesticFilm
    {
        public string Cast { get; set; }
        public string KindOfComedy { get; set; }

        public void Component(Action<string> Message)
        {
            Message("Много шуток иногда даже смешных");
        }
        public Comedy(string filmname,int movieduration,int yearofissue, List<Days> daysofshow)
        {
            FilmName = filmname;
            MovieDuration = movieduration;
            YearOfIssue = yearofissue;
            DaysOfShow = daysofshow;
        }
    }
}
