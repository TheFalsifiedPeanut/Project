

namespace Collect_Dudes.Screens.Menu
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Utilities;
    using ConsoleUtilities;
    
    class MainMenu : Screen
    {
        public override void Render()
        {
            Colours.ColourLine(Colours.BlueFG + "Play");
            Console.WriteLine(" 1. Play \n 2. Exit \n 3. Delete");
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
