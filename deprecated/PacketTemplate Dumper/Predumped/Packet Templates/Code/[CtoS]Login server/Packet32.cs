using System;
using ServerEngine.ProcessorQueues;
using ServerEngine.PacketManagement.CustomAttributes;
using ServerEngine.PacketManagement.Definitions;

namespace LoginServer.Packets.FromClient
{
        [PacketAttributes(IsIncoming = true, Header = 32)]
        public class Packet32 : IPacket
        {
                public class PacketSt32 : IPacketTemplate
                {
                        public UInt16 Header { get { return 32; } }
                        public UInt32 Data1;
                        public UInt16 ArraySize1;
                        [PacketFieldType(ConstSize = false, MaxSize = 512)]
                        public byte[] Data2;
                }

                public void InitPacket(object parser)
                {
                        pParser = (PacketParser<PacketSt32>)parser;
                        IsInitialized = true;
                        IsInUse = false;
                }

                public bool Handler(ref NetworkMessage message)
                {
                        throw new NotImplementedException();
                }

                public bool IsInitialized { get; set; }

                public bool IsInUse { get; set; }

                private PacketParser<PacketSt32> pParser;
        }
}
