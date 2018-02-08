namespace OverwatchStandings.Models
{
    public class ScoreLine
    {
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }

        public ScoreLine(int home, int away)
        {
            HomeScore = home;
            AwayScore = away;
        }
    }
}