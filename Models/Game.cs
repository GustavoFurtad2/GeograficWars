namespace GeograficWars.Models
{
    public class Game
    { 
        public GameState Register { get; private set; }
        public Game()
        {
            Register = new GameState();
        }


    }
}
