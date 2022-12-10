using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Work2
{
    public delegate void Handler(object sender, EventArgs e);
    public class Telephone
    {
        public event Handler Handler;

        public void Phone()
        {
            Console.WriteLine("Снял трубку.");
        }


    }
}
