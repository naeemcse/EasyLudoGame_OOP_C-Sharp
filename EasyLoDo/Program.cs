
using EasyLoDo;

namespace EasyLoDo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EasyLoDo!");
            Console.Write("Enter the number of players: ");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            Console.Write("Enter the board size: ");
            int boardSize = int.Parse(Console.ReadLine());
            Game game = new Game(numberOfPlayers, boardSize);
            game.Start();
        }
    }
}