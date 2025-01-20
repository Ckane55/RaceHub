using f1_app.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using f1_app.MVVM.ViewModel;

namespace f1_app.MVVM.Model
{


    public class ConStandings
    {




        public string Position { get; set; }
        public string Points { get; set; }
        public string Name { get; set; }
        public ConStandings(string pos, string point, string nam)
        {
            Position = pos;
            Points = point;
            Name = nam;
        }

    }
    public class Root
    {
        public MRData MRData { get; set; }
    }

    public class MRData
    {
        public StandingsTable StandingsTable { get; set; }
    }

    public class StandingsTable
    {
        public string Season { get; set; }
        public List<StandingsList> StandingsLists { get; set; }
    }

    public class StandingsList
    {
        public List<ConstructorStanding> ConstructorStandings { get; set; }
    }

    public class ConstructorStanding
    {
        public string Position { get; set; }
        public string PositionText { get; set; }
        public string Points { get; set; }
        public Constructor Constructor { get; set; }
    }

    public class Constructor
    {
        public string Name { get; set; }
        public string Nationality { get; set; }
    }
}
