namespace Lab8;

public delegate void FirstDelegate(int healthPoints);

public static class Lab8
{
    public static void Main()
    {
        Game firstPlayer = new Game(200);
        Game secondPlayer = new Game(300);
        Game thirdPlayer = new Game(400);
        FirstDelegate attack;
        attack = new FirstDelegate(Game.Attack);
        
    }
}