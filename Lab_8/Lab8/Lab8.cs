namespace Lab8
{
    class Program
    {
        static void Main()
        {
            // События для игрока
            Player player = new Player(100);
            Console.WriteLine("Класс Игрок\nКол-во здоровья: " + player.Health);
            player.Notify += DisplayMessage;
            player.Heal(20);
            Console.WriteLine("Кол-во здоровья: " + player.Health);
            player.Damage(10);
            Console.WriteLine("Кол-во здоровья: " + player.Health);
            player.Damage(200);
            Console.WriteLine("Кол-во здоровья: " + player.Health);
            

            // Методы для строк
            Func<string, string> funcStr;
            string str = "K  . i!  ,  r,    ,i  .  l,    l";
            
            Console.WriteLine($"Исходная строка:        {str}");
            funcStr = Strings.RemoveS;
            Console.WriteLine($"Без знаков препинания:  {str = funcStr(str)}");
            funcStr = Strings.RemoveSpaсes;
            Console.WriteLine($"Без пробелов:           {str = funcStr(str)}");
            funcStr = Strings.UpperCase;
            Console.WriteLine($"Заглавными буквами:     {str = funcStr(str)}");
            funcStr = Strings.LowerCase;
            Console.WriteLine($"Строчными буквами:      {str = funcStr(str)}");
            funcStr = Strings.AddToString;
            Console.WriteLine($"С добавлением символа:  {str = funcStr(str)}");
        }

        private static void DisplayMessage(object sender, GameEventArgs e) => Console.WriteLine(e.Message);
    }
}