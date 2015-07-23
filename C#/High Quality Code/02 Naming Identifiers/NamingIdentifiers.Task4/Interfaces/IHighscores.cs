namespace NamingIdentifiers.Task4.Interfaces
{
    public interface IHighscores
    {
        void PrintPlayersHighscores();

        void AddPlayerToScoreBoard(int correctGuessesCounter);
    }
}