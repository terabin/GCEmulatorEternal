﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameServer.network;

namespace GameServer.Buffers
{
    class mymatchrank
    {
        public void info(User user)
        {
            PacketManager Write = new PacketManager();
            Write.OP(1528);
            Write.Hex("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
            user.Send(Write.ack);
        }
    }
}
