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
            // Determine if the advance colour mode is not active and activate it per the system requirements.
            if (!ColourUtilities.IsAdvancedColourModeEnabled())
            {
                Console.Write("Test");
                ColourUtilities.EnableAdvancedColourMode();
            }
            
            new ScreenManager();
            ScreenManager.QuickRender(new MainMenu());
            
            new Time(1,1,2030);

            Unit[] units = new Unit[]
            {
                new Unit("JohnJohn", new Date(5,1,12), 10, 10, 10, Morale.Shattered, Happiness.Sad), 
                new Unit("JimJim", new Date(9,4,1923), 1, 1, 1, Morale.Confident, Happiness.Ecstatic),
                new Unit("JoeJoe", new Date(28,8,2025), 9, 11, 10, Morale.Neutral, Happiness.Happy)
            };
            
            JSONData<Unit[]>.SaveData(units, InternalSettings.unitDataPath);
        }
    }
}
