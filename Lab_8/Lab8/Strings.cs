
namespace Lab8
{
    public static class Strings
    {
        // Удалить знаки препинания
        public static string RemoveS(string str)        
        {
            str = str.Replace(".", string.Empty);
            str = str.Replace(",", string.Empty);
            str = str.Replace("!", string.Empty);
            str = str.Replace("?", string.Empty);
            return str;
        }

        public static string AddToString(string str)    
        {
            return str += "!";
        }

        public static string RemoveSpaсes(string str)
        {
            return str.Replace(" ", string.Empty);
        }

        public static string UpperCase(string str)          
        {
            for (int i = 0; i < str.Length; i++)
            {
                str = str.Replace(str[i], char.ToUpper(str[i]));
            }
            return str;
        }

        public static string LowerCase(string str)          
        {
            for (int i = 0; i < str.Length; i++)
            {
                str = str.Replace(str[i], char.ToLower(str[i]));
            }
            return str;
        }
    }
}
