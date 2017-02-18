﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer
{
    class InviteManager
    {
        public void SendInvite(Client player1, Client player2, string gameid)
        {
            StreamWriter writer = new StreamWriter(player2.user.GetStream());
            if (player1.status != "1" || player2.status != "1")
            {
                writer.WriteLine("invite," + player1.name + "," + player2.name + "," + gameid);
                writer.Flush();
            }
        }
    }
}
