namespace Collect_Dudes
{
    using Screens;
    using Screens.Menu;
    using System;
    using ConsoleUtilities;

    class Program
    {
        static void Main(string[] args)
        {
            new ScreenManager();
            ScreenManager.GetScreenManager().EnqueueScreen(new MainMenu());
            ScreenManager.GetScreenManager().RenderNextScreen();
        }
    }
}
