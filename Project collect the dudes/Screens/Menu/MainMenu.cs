

namespace Collect_Dudes.Screens.Menu
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Utilities;
    class MainMenu : Screen
    {
        public override void Render()
        {
            Console.WriteLine(" 1. A \n 2. B\n 3. C");
            int result = TextUtils.GetChoice("Pick your favourite letter!", 3);
            switch (result)
            {
                case 0:
                    Console.WriteLine("A was chosen.");
                    break;
                case 1:
                    Console.WriteLine("B was chosen.");
                    break;
                case 2:
                    Console.WriteLine("C was chosen.");
                    break;
                default:
                    break;
            }
        }
    }
}
