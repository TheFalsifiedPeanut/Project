namespace Collect_Dudes
{
    using ConsoleUtilities.Colours;
    using Screens.Menu;
    using System;
    using ConsoleUtilities.Screens;
    using ConsoleUtilities.Serialisation;
    using Serialization;
    using Data.Player;

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
            
            JSONData<Player>.SaveData(new Player("Phil", 0, 1, 2), "Player/Player.json");
            JSONData<Player[]>.SaveData(new Player[2] { new Player("Phil", 0, 1, 2), new Player("Phil", 0, 1, 2) }, "Player/Player2.json");

            /*Player[] players = new Player[3];
            players[0] = new Player("Namer", 32, 13, 2023);
            players[1] = new Player("Named", 0, 0, 0000);
            players[2] = new Player("Naming", 3245, 53, 23);
            Save<Player[]>.SaveData(players, @"PlayerSave.json");
            Player[] playerData = Save<Player[]>.LoadData(@"PlayerSave.json");
            for (int i = 0; i < playerData.Length; i++)
            {
                Player player = playerData[i];
                Console.WriteLine(player.name + "\n" + player.day + "\n" + player.month + "\n" + player.year);
            }*/
            
        }
    }
}
