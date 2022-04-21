namespace Collect_Dudes
{
    using Screens;
    using Screens.Menu;
    using System;
    using ConsoleUtilities;
    using Serialization;
    using Data.Player;

    class Program
    {
        static void Main(string[] args)
        {
            new ScreenManager();
            ScreenManager.GetScreenManager().EnqueueScreen(new MainMenu());
            ScreenManager.GetScreenManager().RenderNextScreen();
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
