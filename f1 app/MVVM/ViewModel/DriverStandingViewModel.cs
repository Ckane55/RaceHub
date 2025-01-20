using f1_app.MVVM.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace f1_app.MVVM.ViewModel
{
    class DriverStandingViewModel
    {
        private readonly HttpClient client = new HttpClient();
        private string selectedYear;
        private List<string> availableYears;
        public ObservableCollection<DriverStandings> Drivers { get; set; }


        public List<string> AvailableYears { get; set; }


        public string SelectedYear
        {
            get { return selectedYear; }
            set
            {
                selectedYear = value;
                getDriverStandings(selectedYear);
            }
        }




        public DriverStandingViewModel()
        {
            Drivers = new ObservableCollection<DriverStandings>();
            getDriverStandings("2024");

            AvailableYears = new List<string>
        {
            "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015",
            "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005",
            "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995"
        };









        }


        public async void getDriverStandings(string SelectedYear)
        {
            string url = "https://api.jolpi.ca/ergast/f1/" + SelectedYear + "/driverStandings/";

            string response = await client.GetStringAsync(url);

            

            var convert = JsonConvert.DeserializeObject<Root2>(response);
            Drivers.Clear();

            foreach (var standing in convert.MRData.StandingsTable.StandingsLists[0].DriverStandings)
            {
                // DriverStandings(string Name, string nation, string Position, string Team, string Points) 

                Drivers.Add(new DriverStandings(standing.Driver.givenName, standing.Driver.nationality, standing.position, standing.Constructors[0].name,standing.points));



            }
        }
    }
}

