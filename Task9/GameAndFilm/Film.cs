using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAndFilm
{
    class Film
    {
        public string NameF { get; set; }
        public string MadeByF { get; set; }
        public int YearF { get; set; }
        public string StypeF { get; set; }

        public Film() { }
        public Film(string nameF, string madeByF, int yearF, string stypeF)
        {
            NameF = nameF;
            MadeByF = madeByF;
            YearF = yearF;
            StypeF = stypeF;
        }

        public override string ToString()
        {
            return $"Game: {NameF}, Made by: {MadeByF}, Year: {YearF}, Stype: {StypeF}";
        }
    }
}
