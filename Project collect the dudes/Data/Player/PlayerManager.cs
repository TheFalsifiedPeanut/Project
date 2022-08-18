using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.Data.Player
{
    internal class PlayerManager
    {
        public Player player { get; set; }
        static PlayerManager playerManager;

        public static PlayerManager GetPlayerManager()
        {
            return playerManager;   
        }

        public PlayerManager()
        {
            playerManager = this;
        }
    }
}
