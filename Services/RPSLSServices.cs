namespace RockPaperScissorLizardSpock.Services
{
    public class RPSLSServices
    {
        public string DidWin()
        {
            Random rng = new();
            return rng.Next(1, 6) switch {
                1 => "Rock",
                2 => "Paper",
                3 => "Scissors",
                4 => "Lizard",
                5 => "Spock",
                _ => "Error"
            };
        }
    }
}