﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameServer.network;

namespace GameServer.Buffers
{
    class AgitStore
    {
        public void material(User user)
        {
            PacketManager Write = new PacketManager();
            Write.OP(1117);
            Write.Hex("00 00 00 4F 00 00 00 09 3C 74 00 00 00 01 00 09 3C 56 00 00 00 64 FF FF FF FF 00 FF 00 00 00 01 00 09 3C 7E 00 00 00 01 00 09 3C 56 00 00 03 E8 FF FF FF FF 00 FF 00 00 00 02 00 09 3D 8C 00 00 00 01 00 09 3C 56 00 00 00 78 FF FF FF FF 00 FF 00 00 00 03 00 09 3D 96 00 00 00 01 00 09 3C 56 00 00 00 B4 FF FF FF FF 00 FF 00 00 00 04 00 09 3D A0 00 00 00 01 00 09 3C 56 00 00 00 6E FF FF FF FF 00 FF 00 00 00 05 00 09 3D AA 00 00 00 01 00 09 3C 56 00 00 00 5A FF FF FF FF 00 FF 00 00 00 06 00 09 3D B4 00 00 00 01 00 09 3C 56 00 00 00 96 FF FF FF FF 00 FF 00 00 00 07 00 09 3D BE 00 00 00 01 00 09 3C 56 00 00 00 78 FF FF FF FF 00 FF 00 00 00 08 00 09 3D C8 00 00 00 01 00 09 3C 56 00 00 00 B4 FF FF FF FF 00 FF 00 00 00 09 00 09 3D D2 00 00 00 01 00 09 3C 56 00 00 00 6E FF FF FF FF 00 FF 00 00 00 0A 00 09 3D DC 00 00 00 01 00 09 3C 56 00 00 00 5A FF FF FF FF 00 FF 00 00 00 0B 00 09 3D E6 00 00 00 01 00 09 3C 56 00 00 00 96 FF FF FF FF 00 FF 00 00 00 0C 00 09 3D F0 00 00 00 01 00 09 3C 56 00 00 01 4A FF FF FF FF 00 FF 00 00 00 0D 00 09 3D FA 00 00 00 01 00 09 3C 56 00 00 01 C2 FF FF FF FF 00 FF 00 00 00 0E 00 09 3E 04 00 00 00 01 00 09 3C 56 00 00 01 2C FF FF FF FF 00 FF 00 00 00 0F 00 09 3E 0E 00 00 00 01 00 09 3C 56 00 00 00 FA FF FF FF FF 00 FF 00 00 00 10 00 09 3E 18 00 00 00 01 00 09 3C 56 00 00 01 AE FF FF FF FF 00 FF 00 00 00 11 00 09 3E 22 00 00 00 01 00 09 3C 56 00 00 00 FA FF FF FF FF 00 FF 00 00 00 12 00 09 3E 2C 00 00 00 01 00 09 3C 56 00 00 01 4A FF FF FF FF 00 FF 00 00 00 13 00 09 3E 36 00 00 00 01 00 09 3C 56 00 00 01 C2 FF FF FF FF 00 FF 00 00 00 14 00 09 3E 40 00 00 00 01 00 09 3C 56 00 00 01 2C FF FF FF FF 00 FF 00 00 00 15 00 09 3E 4A 00 00 00 01 00 09 3C 56 00 00 00 FA FF FF FF FF 00 FF 00 00 00 16 00 09 3E 54 00 00 00 01 00 09 3C 56 00 00 01 AE FF FF FF FF 00 FF 00 00 00 17 00 09 3E 5E 00 00 00 01 00 09 3C 56 00 00 00 FA FF FF FF FF 00 FF 00 00 00 18 00 09 3E 68 00 00 00 01 00 09 3C 56 00 00 01 4A FF FF FF FF 00 FF 00 00 00 19 00 09 3E 72 00 00 00 01 00 09 3C 56 00 00 01 F4 FF FF FF FF 00 FF 00 00 00 1A 00 09 3E 7C 00 00 00 01 00 09 3C 56 00 00 01 2C FF FF FF FF 00 FF 00 00 00 1B 00 09 3E 86 00 00 00 01 00 09 3C 56 00 00 00 FA FF FF FF FF 00 FF 00 00 00 1C 00 09 3E 90 00 00 00 01 00 09 3C 56 00 00 01 AE FF FF FF FF 00 FF 00 00 00 1D 00 09 3E 9A 00 00 00 01 00 09 3C 56 00 00 01 4A FF FF FF FF 00 FF 00 00 00 1E 00 09 3E A4 00 00 00 01 00 09 3C 56 00 00 01 F4 FF FF FF FF 00 FF 00 00 00 1F 00 09 3E AE 00 00 00 01 00 09 3C 56 00 00 01 2C FF FF FF FF 00 FF 00 00 00 20 00 09 3E B8 00 00 00 01 00 09 3C 56 00 00 00 FA FF FF FF FF 00 FF 00 00 00 21 00 09 3E C2 00 00 00 01 00 09 3C 56 00 00 01 AE FF FF FF FF 00 FF 00 00 00 22 00 09 3E CC 00 00 00 01 00 09 3C 56 00 00 00 FA FF FF FF FF 00 FF 00 00 00 23 00 09 3E D6 00 00 00 01 00 09 3C 56 00 00 00 50 FF FF FF FF 00 FF 00 00 00 24 00 09 3E E0 00 00 00 01 00 09 3C 56 00 00 00 50 FF FF FF FF 00 FF 00 00 00 25 00 09 3E EA 00 00 00 01 00 09 3C 56 00 00 00 32 FF FF FF FF 00 FF 00 00 00 26 00 09 3E F4 00 00 00 01 00 09 3C 56 00 00 00 28 FF FF FF FF 00 FF 00 00 00 27 00 09 3E FE 00 00 00 01 00 09 3C 56 00 00 00 3C FF FF FF FF 00 FF 00 00 00 28 00 09 3F 08 00 00 00 01 00 09 3C 56 00 00 00 50 FF FF FF FF 00 FF 00 00 00 29 00 09 3F 12 00 00 00 01 00 09 3C 56 00 00 00 6E FF FF FF FF 00 FF 00 00 00 2A 00 09 3F 1C 00 00 00 01 00 09 3C 56 00 00 00 78 FF FF FF FF 00 FF 00 00 00 2B 00 09 3F 26 00 00 00 01 00 09 3C 56 00 00 00 0F FF FF FF FF 00 FF 00 00 00 2C 00 09 3F 30 00 00 00 01 00 09 3C 56 00 00 00 0A FF FF FF FF 00 FF 00 00 00 2D 00 09 3F 3A 00 00 00 01 00 09 3C 56 00 00 00 0F FF FF FF FF 00 FF 00 00 00 2E 00 09 3F 44 00 00 00 01 00 09 3C 56 00 00 01 90 FF FF FF FF 00 FF 00 00 00 2F 00 09 3F 4E 00 00 00 01 00 09 3C 56 00 00 00 BE FF FF FF FF 00 FF 00 00 00 30 00 09 3F 58 00 00 00 01 00 09 3C 56 00 00 03 20 FF FF FF FF 00 FF 00 00 00 31 00 09 3F 62 00 00 00 01 00 09 3C 56 00 00 00 14 FF FF FF FF 00 FF 00 00 00 32 00 09 3F 6C 00 00 00 01 00 09 3C 56 00 00 00 64 FF FF FF FF 00 FF 00 00 00 33 00 09 3F 76 00 00 00 01 00 09 3C 56 00 00 00 28 FF FF FF FF 00 FF 00 00 00 34 00 09 3F 80 00 00 00 01 00 09 3C 56 00 00 00 82 FF FF FF FF 00 FF 00 00 00 35 00 09 3F 8A 00 00 00 01 00 09 3C 56 00 00 00 82 FF FF FF FF 00 FF 00 00 00 36 00 09 3F 94 00 00 00 01 00 09 3C 56 00 00 00 64 FF FF FF FF 00 FF 00 00 00 37 00 09 3F 9E 00 00 00 01 00 09 3C 56 00 00 01 18 FF FF FF FF 00 FF 00 00 00 38 00 09 3F A8 00 00 00 01 00 09 3C 56 00 00 01 18 FF FF FF FF 00 FF 00 00 00 39 00 09 3F B2 00 00 00 01 00 09 3C 56 00 00 00 C8 FF FF FF FF 00 FF 00 00 00 3A 00 09 3F BC 00 00 00 01 00 09 3C 56 00 00 00 96 FF FF FF FF 00 FF 00 00 00 3B 00 09 3F C6 00 00 00 01 00 09 3C 56 00 00 00 96 FF FF FF FF 00 FF 00 00 00 3C 00 09 3F D0 00 00 00 01 00 09 3C 56 00 00 00 BE FF FF FF FF 00 FF 00 00 00 3D 00 09 3F DA 00 00 00 01 00 09 3C 56 00 00 01 22 FF FF FF FF 00 FF 00 00 00 3E 00 09 3F E4 00 00 00 01 00 09 3C 56 00 00 01 C2 FF FF FF FF 00 FF 00 00 00 3F 00 09 3F EE 00 00 00 01 00 09 3C 56 00 00 01 C2 FF FF FF FF 00 FF 00 00 00 40 00 09 3F F8 00 00 00 01 00 09 3C 56 00 00 00 A0 FF FF FF FF 00 FF 00 00 00 41 00 09 40 02 00 00 00 01 00 09 3C 56 00 00 02 BC FF FF FF FF 00 FF 00 00 00 42 00 09 40 0C 00 00 00 01 00 09 3C 56 00 00 00 32 FF FF FF FF 00 FF 00 00 00 43 00 09 40 16 00 00 00 01 00 09 3C 56 00 00 00 0A FF FF FF FF 00 FF 00 00 00 44 00 09 40 20 00 00 00 01 00 09 3C 56 00 00 00 6E FF FF FF FF 00 FF 00 00 00 45 00 09 40 2A 00 00 00 01 00 09 3C 56 00 00 00 AA FF FF FF FF 00 FF 00 00 00 46 00 09 40 48 00 00 00 01 00 09 3C 56 00 00 00 FA FF FF FF FF 00 FF 00 00 00 47 00 09 40 52 00 00 00 01 00 09 3C 56 00 00 01 2C FF FF FF FF 00 FF 00 00 00 48 00 09 41 7E 00 00 00 01 00 09 3C 56 00 00 01 2C FF FF FF FF 00 FF 00 00 00 49 00 09 41 88 00 00 00 01 00 09 3C 56 00 00 01 C2 FF FF FF FF 00 FF 00 00 00 4A 00 0A 05 DC 00 00 00 01 00 09 3C 56 00 00 00 64 FF FF FF FF 00 FF 00 00 00 4B 00 0A 05 E6 00 00 00 01 00 09 3C 56 00 00 00 96 FF FF FF FF 00 FF 00 00 00 4C 00 0A 05 F0 00 00 00 01 00 09 3C 56 00 00 00 C8 FF FF FF FF 00 FF 00 00 00 4D 00 0A 06 04 00 00 00 01 00 09 3C 56 00 00 01 F4 FF FF FF FF 00 FF 00 00 00 4E 00 0A 06 0E 00 00 00 01 00 09 3C 56 00 00 01 2C FF FF FF FF 00 FF 00 00");
            user.Send(Write.ack);
        }
    }
}
