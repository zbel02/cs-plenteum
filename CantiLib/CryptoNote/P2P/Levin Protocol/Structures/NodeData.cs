﻿using Canti.Data;
using System;

namespace Canti.CryptoNote.P2P
{
    [Serializable]
    internal struct NetworkAddress
    {
        internal uint IpAddress { get; set; }
        internal uint Port { get; set; }
        public byte[] Serialize()
        {
            PortableStorage Storage = new PortableStorage();
            Storage.AddEntry("ip", IpAddress);
            Storage.AddEntry("port", Port);
            return Storage.Serialize(false);
        }
    };

    [Serializable]
    internal struct PeerlistEntry
    {
        internal NetworkAddress Address { get; set; }
        internal ulong Id { get; set; }
        internal ulong LastSeen { get; set; }
        public byte[] Serialize()
        {
            PortableStorage Storage = new PortableStorage();
            Storage.AddEntry("address", Address.Serialize());
            Storage.AddEntry("id", Id);
            Storage.AddEntry("last_seen", LastSeen);
            return Storage.Serialize(false);
        }
    };

    [Serializable]
    internal struct NodeData
    {
        public string NetworkId { get; set; }
        public byte Version { get; set; }
        public ulong PeerId { get; set; }
        public ulong LocalTime { get; set; }
        public uint Port { get; set; }
        public byte[] Serialize()
        {
            PortableStorage Storage = new PortableStorage();
            Storage.AddEntry("network_id", NetworkId);
            Storage.AddEntry("version", Version);
            Storage.AddEntry("peer_id", PeerId);
            Storage.AddEntry("local_time", LocalTime);
            Storage.AddEntry("my_port", Port);
            return Storage.Serialize(false);
        }
        public static NodeData Deserialize(object Value)
        {
            if (Value.GetType() != typeof(PortableStorage)) throw new Exception("Invalid deserialization object");
            PortableStorage Storage = (PortableStorage)Value;
            return new NodeData
            {
                NetworkId = (string)Storage.GetEntry("network_id"),
                Version = (byte)Storage.GetEntry("version"),
                PeerId = (ulong)Storage.GetEntry("peer_id"),
                LocalTime = (ulong)Storage.GetEntry("local_time"),
                Port = (uint)Storage.GetEntry("my_port")
            };
        }
    }
}
