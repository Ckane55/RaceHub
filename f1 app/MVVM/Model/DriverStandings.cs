﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1_app.MVVM.Model
{
    public class DriverStandings
    {


        public string DriverName {  get; set; }
        public string Nationality {  get; set; }
        public string Team {  get; set; }
        public string Position {  get; set; }
        public string Points {  get; set; }
        public object Driver { get; set; }

        public DriverStandings(string name, string nation, string position, string team, string points) 
        {
            DriverName = name;
            Nationality = nation;
            Position = position;
            Points = points;
            Team = team;


        }
    }
    public class Root2
    {
        public Mrdata MRData { get; set; }
    }

    public class Mrdata
    {
        public string xmlns { get; set; }
        public string series { get; set; }
        public string url { get; set; }
        public string limit { get; set; }
        public string offset { get; set; }
        public string total { get; set; }
        public Standingstable StandingsTable { get; set; }
    }

    public class Standingstable
    {
        public string season { get; set; }
        public string round { get; set; }
        public List<Standingslist> StandingsLists { get; set; }
    }

    public class Standingslist
    {
        public string season { get; set; }
        public string round { get; set; }
        public List<Driverstanding> DriverStandings { get; set; }
    }

    public class Driverstanding
    {
        public string position { get; set; }
        public string positionText { get; set; }
        public string points { get; set; }
        public string wins { get; set; }
        public Driver Driver { get; set; }
        public List<Constructor2> Constructors { get; set; }
    }

    public class Driver
    {
        public string driverId { get; set; }
        public string permanentNumber { get; set; }
        public string code { get; set; }
        public string url { get; set; }
        public string givenName { get; set; }
        public string familyName { get; set; }
        public string dateOfBirth { get; set; }
        public string nationality { get; set; }
    }

    public class Constructor2
    {
        public string constructorId { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string nationality { get; set; }
    }

}
