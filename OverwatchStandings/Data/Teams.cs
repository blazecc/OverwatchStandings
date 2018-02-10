using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OverwatchStandings.Models;

namespace OverwatchStandings.Data
{
    public class Teams
    {
        public List<Team> OWLTeams = new List<Team>
        {
            new Team
            {
                Id = 1,
                Name = "Boston Uprising"
            },
            new Team
            {
                Id = 2,
                Name = "Dalas Fuel"
            }, new Team
            {
                Id = 3,
                Name = "Florid aMayhem"
            }, new Team
            {
                Id = 4,
                Name = "HoustonOutlaws"
            }, new Team
            {
                Id = 5,
                Name = "LondonSpitfire"
            }, new Team
            {
                Id = 6,
                Name = "Los Angeles Gladiators"
            }, new Team
            {
                Id = 7,
                Name = "Los Angeles Valiant"
            }, new Team
            {
                Id = 8,
                Name = "New York Excelsior"
            }, new Team
            {
                Id = 9,
                Name = "Philadelphia Fusion"
            }, new Team
            {
                Id = 10,
                Name = "San Francisco Shock"
            }, new Team
            {
                Id = 11,
                Name = "Seoul Dynasty"
            }, new Team
            {
                Id = 12,
                Name = "Shanghai Dragons"
            }
        };
    }
}