using System;
using ServerEngine.ProcessorQueues;
using ServerEngine.PacketManagement.CustomAttributes;
using ServerEngine.PacketManagement.Definitions;

namespace GameServer.Packets.FromClient
{
        [PacketAttributes(IsIncoming = true, Header = 41)]
        public class Packet41 : IPacket
        {
                public class PacketSt41 : IPacketTemplate
                {
                        public UInt16 Header { get { return 41; } }
                        public UInt32 Data1;
                }

                public void InitPacket(object parser)
                {
                        pParser = (PacketParser<PacketSt41>)parser;
                        IsInitialized = true;
                        IsInUse = false;
                }

                public bool Handler(ref NetworkMessage message)
                {
                        throw new NotImplementedException();
                }

                public bool IsInitialized { get; set; }

                public bool IsInUse { get; set; }

                private PacketParser<PacketSt41> pParser;
        }
}
