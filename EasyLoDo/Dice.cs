namespace EasyLoDo;

public class Dice
{
    public int Roll()
    {
        return new Random().Next(1, 7);
    }
}