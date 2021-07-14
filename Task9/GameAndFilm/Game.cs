using System;

namespace GameAndFilm
{
    class Game
    {
        public string NameG { get; set; }
        public string MadeByG { get; set; }
        public int YearG { get; set; }
        public string StypeG { get; set; }

        public Game() { }
        public Game(string nameG, string madeByG, int yearG, string stypeG)
        {
            NameG = nameG;
            MadeByG = madeByG;
            YearG = yearG;
            StypeG = stypeG;
        }

        public override string ToString()
        {
            return $"Game: {NameG}, Made by: {MadeByG}, Year: {YearG}, Stype: {StypeG}";
        }
    }
}
