using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GCNet.CoreLib;
using GCNet.PacketLib;
using GameServer.Packets;
using GameServer.Buffers;
using GameServer.Conexao;

namespace GameServer.network
{
    public class Packets
    {
        Readers Ler = new Readers();
        HeartBeat heartbeat = new HeartBeat();
        Log log = new Log();
        Player player = new Player();
        equipitem equipamentos = new equipitem();
        CharsInfo charsInfo = new CharsInfo();
        getfullsp spInfo = new getfullsp();
        PetCustom petcustom = new PetCustom();
        VerificarInventario invetario = new VerificarInventario();
        ClientInfo ClientInfo = new ClientInfo();
        GamebleBuy cost_rate = new GamebleBuy();
        charselect joinchar = new charselect();
        choicebox Choicebox = new choicebox();
        exppotion expPotion = new exppotion();
        noneInventory InventoryBuff = new noneInventory();
        AgitStore agitstorematerial = new AgitStore();
        AgitMap agitmap = new AgitMap();
        FairyTree fairytreelvtable = new FairyTree();
        Channellist channellist = new Channellist();
        EnterChannel enterChannel = new EnterChannel();
        Depot depotInfo = new Depot();
        RegisterNick regNick = new RegisterNick();
        Canal canal = new Canal();
        leaveRoom SairdaSala = new leaveRoom();
        StartGame playgame = new StartGame();
        LoadComplete Loading = new LoadComplete();
        StageLoadComplete stageLoading = new StageLoadComplete();
        joinRoom join = new joinRoom();
        LeaveChannel exit0 = new LeaveChannel();
        Chat getChat = new Chat();
        UserList playerlist = new UserList();
        Hero_Item_Catalog HeroItemC = new Hero_Item_Catalog();
        Hero_Item_Material HeroItemM = new Hero_Item_Material();
        ManuFactureMaterial ManuF = new ManuFactureMaterial();
        Manufacture_Catalog ManuC = new Manufacture_Catalog();
        SpecificItemBreakup SpecItemB = new SpecificItemBreakup();
        
        public Packets(short opcode, Readers Ler,User here,byte[] buffer,PlayerInfo pInfo)
        {
            switch (opcode)
            {                
                case 0:
                    {
                        heartbeat.HeartBeatNot(here);
                        break;
                    }

                case 2:
                    {
                        player.logar(here,pInfo,charsInfo,Ler);
                        break;
                    }

                case 24:
                    {
                        canal.CriarSala(here,pInfo, Ler, charsInfo);
                        break;
                    }

                case 16:
                    {
                        canal.Salas(here,Ler);
                        break;
                    }


                case 423:
                    {
                        spInfo.fullspInfo(here);
                        break;
                    }

                case 1555:
                    {
                        joinchar.CharSelectJoin(here);
                        break;
                    }

                case 871:
                    {
                        cost_rate.cost_rate(here);
                        break;
                    }

                case 1106:
                    {
                        agitmap.map(here);
                        break;
                    }

                case 1184:
                    {
                        fairytreelvtable.lvtable(here);
                        break;
                    }

                case 1340:
                    {
                        depotInfo.Info(here);
                        break;
                    }

                case 1012:
                    {
                        Choicebox.list(here);
                        channellist.ChannelList(here);
                        break;
                    }
                case 12:
                    {
                        enterChannel.enterchannel(here, Ler);
                        break;
                    }

                case 14:
                    {
                        channellist.ChannelList(here);
                        break;
                    }

               case 33:
                    {
                        SairdaSala.leaveroom(here);
                        break;
                    }

               case 36:
                    {
                        playgame.rungame(here);
                        break;
                    }
               case 39:
                    {
                        Loading.LoadCompleteNot(here);
                        break;
                    }

               case 927:
                    {
                        stageLoading.stageLoadComplete(here);
                        break;
                    }
               case 20:
                    {
                        join.enterRoom(here,Ler,charsInfo);
                        break;
                    }

               case 26:
                    {
                        exit0.SairDoCanal(here);
                        break;
                    }
               case 6:
                    {
                        getChat.chat(here,Ler);
                        break;
                    }
               case 18:
                    {
                        playerlist.userlist(here);
                        break;
                    }
                case 886:
                    {
                        HeroItemC.Lista_De_Item(here);
                        break;
                        
                    }
               case 889:
                    {
                        HeroItemM.Item_Material(here);
                        break;
                    }
               case 806:
                    {
                        ManuF.Manu(here);
                        break;
                    }
               case 804:
                    {
                        ManuC.Manu(here);
                        break;
                    }
               case 1465:
                    {
                        SpecItemB.SpecificItemB(here);
                        break;
                    }

                default:
                    {
                        log.Hex("Recebido, OpCode {" + opcode + "} Payload: ", buffer);
                        break;
                    }
            }
        }
     }
}
