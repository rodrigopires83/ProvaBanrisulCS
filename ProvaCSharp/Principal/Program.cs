using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergs.ProvacSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuUsuario menu = new MenuUsuario();
            menu.Menu();

            Console.ReadKey();
        }
    }
}
