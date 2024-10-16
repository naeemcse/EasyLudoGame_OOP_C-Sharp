namespace EasyLoDo;
using System.Collections.Generic;
public class Game
{
    private List<Player> players;
    private int boardSize;
    
    public Game(int numberOfPlayers, int boardSize = 50)
    {
        players = new List<Player>();
        this.boardSize = boardSize;

        for (int i = 1; i <= numberOfPlayers; i++)
        {
            Console.Write($"Enter the name for Player {i}: ");
            string name = Console.ReadLine();
            players.Add(new Player(name));
        }
    }

    public void Start()
    {
        Console.WriteLine("\nGame Started!\n");
        bool gameEnded = false;
        while (!gameEnded)
        {
            
            foreach (var player in players)
            {
              
                Console.WriteLine($"{player.Name}'s turn. Press Enter to roll the dice...");
                Console.ReadLine();
                int diceRoll =new Dice().Roll();
                Console.WriteLine($"{player.Name} rolled {diceRoll}");
                    
               if(diceRoll==6 && !player.FirstSix) player.FirstSix = true;

               KhaiceKina(diceRoll,player);
               
               if(player.FirstSix)
                player.Move(diceRoll, boardSize);
                DisplayBoard();
                if (player.HasWon)
                {
                    Console.WriteLine($"\nCongratulations {player.Name}! You have won the game!");
                    gameEnded = true;
                    break;
                }
            }
        }
        Console.WriteLine("Game Over. Press any key to exit.");
        Console.ReadKey();
    }
    
    
    private void DisplayBoard2()
    {
        Console.WriteLine("\nCurrent Positions:");
        foreach (var player in players)
        {
            Console.WriteLine($"{player.Name}: Current Score: {player.Score}" + (player.HasWon ? " (Winner!)" : ""));
        }
        Console.WriteLine();
    }

    private void DisplayBoard()
    {
        Console.WriteLine("\nCurrent Positions:");
        foreach (var player in players)
        {
            Console.WriteLine($"\n{player.Name}: Current Score: {player.Score}" + (player.HasWon ? " (Winner!)" : ""));
       
        for(int i = 0 ;i<100;i++)
            Console.Write("#");
        Console.WriteLine();

        for (int i = 0; i < 100; i++)
        {
            if(i<(player.Score*100/boardSize) || i==99)
                Console.Write("#");
            else 
            if(i%5==0)
                Console.Write("|");
            else
            {
       
                Console.Write(" ");
            }
            
        } 

        Console.WriteLine();

        for(int i = 0 ;i<100;i++)
            Console.Write("#");
        }
        Console.WriteLine();
    }

    public void KhaiceKina(int diceRoll , Player p)
    {
        foreach (var player in players)
        {
            if(p.Score+diceRoll==player.Score)
            {
                Console.WriteLine($"{p.Name} rolled {diceRoll} and ate {player.Name} and moved to {player.Score}");
              player.Score = 0;
              player.FirstSix = false;
            }
        }
    }
}

