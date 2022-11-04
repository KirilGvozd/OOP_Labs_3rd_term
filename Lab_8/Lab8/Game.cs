namespace Lab8;

public class Game
{
    private static int Health { get; set; }

    public Game(int health)
    {
        Health = health;
    }

    public static void Attack(int damage)
    {
        Health -= damage;
    }

    public static void Healing(int addedHealth)
    {
        Health += addedHealth;
    }
}