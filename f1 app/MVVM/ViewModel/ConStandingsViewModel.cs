using f1_app.Core;
using f1_app.MVVM.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace f1_app.MVVM.ViewModel
{
    class ConStandingsViewModel:ObservableObject
    {
        
        private readonly HttpClient client = new HttpClient();
        private string selectedYear;
        public string selectedType;
        
        public ObservableCollection<ConStandings> Teams { get; set; }


        public List<string> AvailableYears { get; set; }
        public List<string> StandingsType { get; set; }

        public string SelectedYear
        {
            get { return selectedYear; }
            set
            {
                selectedYear = value;
                getConstructorStandings(selectedYear);

                
               
                
            }
        }

     


        public ConStandingsViewModel()
        {
            Teams = new ObservableCollection<ConStandings>();
            selectedYear = "2024";
            selectedType = "Constructors";
            
            getConstructorStandings(selectedYear);

            AvailableYears = new List<string> {

            "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015",
            "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005",
            "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995"};


            StandingsType = new List<string> { "Constructors", "Drivers" };













        }


        public async void getConstructorStandings(string SelectedYear)
        {
            string url = "https://api.jolpi.ca/ergast/f1/" + SelectedYear + "/constructorstandings/";

            string response = await client.GetStringAsync(url);



            var convert = JsonConvert.DeserializeObject<Root>(response);
            Teams.Clear();

            foreach (var standing in convert.MRData.StandingsTable.StandingsLists[0].ConstructorStandings)
            {   //position name points
                if (standing.PositionText == "E")
                {
                    Teams.Add(new ConStandings("DSQ", standing.Points, standing.Constructor.Name));

                }
                else
                {
                    Teams.Add(new ConStandings(standing.Position, standing.Points, standing.Constructor.Name));

                }

            }
        }


    }
}
