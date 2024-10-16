namespace EasyLoDo;

public class Player
{
    public string Name { get; set; }
    public int Score { get; set; }
    public bool HasWon { get; set; }
    public Boolean FirstSix { get; set; }

    public Player(string name)
    {
        Name = name;
        Score = 0;
        HasWon = false;
        FirstSix = false;
    }
    public void Move(int diceRoll, int boardSize=50)
    {
        if(Score + diceRoll <= boardSize)
        {
            Score += diceRoll;
            if(Score == boardSize)
            {
                HasWon = true;
                Console.WriteLine($"{Name} rolled {diceRoll} and won the game");
            }
        } else
        {
            Score -= diceRoll;
            Console.WriteLine($"{Name} rolled {diceRoll} but cannot move beyond {boardSize} as our rules your score discreses by {diceRoll}");
           
        }
    }
}