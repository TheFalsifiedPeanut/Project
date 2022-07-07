namespace Collect_Dudes
{
    using ConsoleUtilities.Colours;
    using ConsoleUtilities.Screens;
    using ConsoleUtilities.Serialisation;
    using Data.Mental;
    using Data.Units;
    using Screens.Menu;
    using Serialization;
    using System;
    using World;

    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading...");
            // Determine if the advance colour mode is not active and activate it per the system requirements.
            if (!ColourUtilities.IsAdvancedColourModeEnabled())
            {
                ColourUtilities.EnableAdvancedColourMode();
            }

            new Time(1, 1, 2030);
            new UnitPool(10);

            new ScreenManager();
            ScreenManager.QuickRender(new MainMenu());
            
            

            /*Unit[] units = new Unit[]
            {
                new Unit(0, "JohnJohn", new Date(5,1,12), 10, 10, 10, Morale.Shattered, Happiness.Sad), 
                new Unit(1, "JimJim", new Date(9,4,1923), 1, 1, 1, Morale.Confident, Happiness.Ecstatic),
                new Unit(2, "JoeJoe", new Date(28,8,2025), 9, 11, 10, Morale.Neutral, Happiness.Happy)
            };*/
            
            //JSONData<Unit[]>.SaveData(units, InternalSettings.unitDataPath);


        }
    }
}
