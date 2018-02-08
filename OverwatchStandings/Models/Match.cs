﻿using System;
using System.Collections.Generic;

namespace OverwatchStandings.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime MatchDate { get; set; }
        public ScoreLine Score { get; set; }
        public Team Home { get; }
        public Team Away { get; set; }
        public List<Game> GameList { get; set; }
        public int Stage { get; set; }
    }
}