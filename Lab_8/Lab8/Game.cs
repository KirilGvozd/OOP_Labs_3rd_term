namespace Lab8
{
    public class GameEventArgs
    {
        public string Message { get; }
        public int Health { get; }
        public GameEventArgs(string mes, int num)
        {
            Message = mes;
            Health = num;
        }
    }

    public delegate void GameHandler(object sender, GameEventArgs e);

    class Player
    {
        public event GameHandler Notify;
        public Player(int num)
        {
            Health = num;
        }
        public int Health { get; private set; }
        public void Heal(int num)
        {
            Health += num;
            Notify?.Invoke(this, new GameEventArgs($"Вылечено {num} очков здоровья", num));
        }
        public void Damage(int num)
        {
            if (Health >= num)
            {
                Health -= num;
                Notify?.Invoke(this, new GameEventArgs($"Нанесено {num} урона", num));
            }
            else
            {
                Health = 0;
                Notify?.Invoke(this, new GameEventArgs($"Нанесено {num} урона. Вы умерли :(", num)); ;
            }
        }
    }
}