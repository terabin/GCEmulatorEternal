﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameServer.network;

namespace GameServer.Buffers
{
    class exptable
    {
        public void xptable(User user)
        {
            PacketManager Write = new PacketManager();
            Write.OP(1250);
            Write.Hex("00 00 00 55 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 01 00 00 00 00 00 00 00 F0 00 00 00 02 00 00 00 00 00 00 02 24 00 00 00 03 00 00 00 00 00 00 03 74 00 00 00 04 00 00 00 00 00 00 05 96 00 00 00 05 00 00 00 00 00 00 08 0C 00 00 00 06 00 00 00 00 00 00 0A AC 00 00 00 07 00 00 00 00 00 00 0D A0 00 00 00 08 00 00 00 00 00 00 10 BE 00 00 00 09 00 00 00 00 00 00 14 30 00 00 00 0A 00 00 00 00 00 00 1A 18 00 00 00 0B 00 00 00 00 00 00 20 7E 00 00 00 0C 00 00 00 00 00 00 27 A1 00 00 00 0D 00 00 00 00 00 00 2F 42 00 00 00 0E 00 00 00 00 00 00 37 DF 00 00 00 0F 00 00 00 00 00 00 41 39 00 00 00 10 00 00 00 00 00 00 4B 8F 00 00 00 11 00 00 00 00 00 00 56 E1 00 00 00 12 00 00 00 00 00 00 63 6E 00 00 00 13 00 00 00 00 00 00 71 36 00 00 00 14 00 00 00 00 00 00 80 39 00 00 00 15 00 00 00 00 00 00 90 B6 00 00 00 16 00 00 00 00 00 00 A8 FE 00 00 00 17 00 00 00 00 00 00 C3 92 00 00 00 18 00 00 00 00 00 00 E1 1A 00 00 00 19 00 00 00 00 00 01 01 42 00 00 00 1A 00 00 00 00 00 01 24 B2 00 00 00 1B 00 00 00 00 00 01 4B BE 00 00 00 1C 00 00 00 00 00 01 76 BA 00 00 00 1D 00 00 00 00 00 01 BD 9A 00 00 00 1E 00 00 00 00 00 02 0B DC 00 00 00 1F 00 00 00 00 00 02 61 80 00 00 00 20 00 00 00 00 00 02 C0 00 00 00 00 21 00 00 00 00 00 03 27 DA 00 00 00 22 00 00 00 00 00 03 9A 0A 00 00 00 23 00 00 00 00 00 04 17 8C 00 00 00 24 00 00 00 00 00 04 CF F4 00 00 00 25 00 00 00 00 00 05 9A BC 00 00 00 26 00 00 00 00 00 06 79 DC 00 00 00 27 00 00 00 00 00 07 6F 4C 00 00 00 28 00 00 00 00 00 08 7D 04 00 00 00 29 00 00 00 00 00 09 A6 4C 00 00 00 2A 00 00 00 00 00 0A ED 1C 00 00 00 2B 00 00 00 00 00 0C 54 BC 00 00 00 2C 00 00 00 00 00 0D DF CC 00 00 00 2D 00 00 00 00 00 0F 92 E4 00 00 00 2E 00 00 00 00 00 11 E8 E6 00 00 00 2F 00 00 00 00 00 14 7A CA 00 00 00 30 00 00 00 00 00 17 4E 4E 00 00 00 31 00 00 00 00 00 1B 09 26 00 00 00 32 00 00 00 00 00 1F 23 7A 00 00 00 33 00 00 00 00 00 23 A7 22 00 00 00 34 00 00 00 00 00 29 71 C4 00 00 00 35 00 00 00 00 00 2F D0 8C 00 00 00 36 00 00 00 00 00 39 77 AE 00 00 00 37 00 00 00 00 00 44 17 31 00 00 00 38 00 00 00 00 00 4F C6 D0 00 00 00 39 00 00 00 00 00 5C A1 70 00 00 00 3A 00 00 00 00 00 6A C5 20 00 00 00 3B 00 00 00 00 00 7B DF 8E 00 00 00 3C 00 00 00 00 00 8E B0 86 00 00 00 3D 00 00 00 00 00 A3 63 89 00 00 00 3E 00 00 00 00 00 BA 27 94 00 00 00 3F 00 00 00 00 00 D5 79 6C 00 00 00 40 00 00 00 00 00 F3 87 CA 00 00 00 41 00 00 00 00 01 17 58 4B 00 00 00 42 00 00 00 00 01 3E BE 0F 00 00 00 43 00 00 00 00 01 6D 68 ED 00 00 00 44 00 00 00 00 01 A0 BD 98 00 00 00 45 00 00 00 00 01 EE 6C 8C 00 00 00 46 00 00 00 00 02 6E 9B 64 00 00 00 47 00 00 00 00 03 13 16 71 00 00 00 48 00 00 00 00 03 E1 DE D9 00 00 00 49 00 00 00 00 04 E1 C5 B5 00 00 00 4A 00 00 00 00 06 1A 8D 95 00 00 00 4B 00 00 00 00 08 A9 93 AA 00 00 00 4C 00 00 00 00 0C ED 41 E1 00 00 00 4D 00 00 00 00 13 2E 66 75 00 00 00 4E 00 00 00 00 1B C7 F5 17 00 00 00 4F 00 00 00 00 28 7E BD 4F 00 00 00 50 00 00 00 00 32 A1 39 B7 00 00 00 51 00 00 00 00 3F 4D 08 B0 00 00 00 52 00 00 00 00 4F 24 AB C8 00 00 00 53 00 00 00 00 62 F3 50 2E 00 00 00 54 00 00 00 00 7B B6 FC 6C 00 00 00");
            user.Send(Write.ack);
        }
    }
}