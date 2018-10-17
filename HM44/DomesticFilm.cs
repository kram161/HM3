using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM44
{
    public class DomesticFilm:IFilm
    {
        public string FilmName { get; set; }
        public int MovieDuration { get; set; }
        public int YearOfIssue { get; set; }
        public List<Days> DaysOfShow { get; set; }

        public string FilmDirector {get;set;}
        public string FilmProducer { get; set; }

        public void BeginningOfFilm(Action<string> Message)
        {
            Message("Куча рекламы и начало фильма");
        }
        public void Session(Action<string> Message)
        {
            Message("Увлекательный просмотр отечественного фильма");
        }
        public void EndOfFilm(Action<string> Message)
        {
            Message("Титры");
        }
    }
}
