namespace OverwatchStandings.Models
{
    public class Game
    {
        public int Id { get; set; }
        public Map Map { get; set; }
        public ScoreLine Score { get; set; }
        public Team Home { get; set; }
        public Team Away { get; set; }

        public Team Winner
        {
            get
            {
                if (Score.HomeScore > Score.AwayScore) return Home;
                return Away;
            }
        }
    }
}