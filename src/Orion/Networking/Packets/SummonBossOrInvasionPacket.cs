﻿using System.IO;

namespace Orion.Networking.Packets {
    /// <summary>
    /// Packet sent to summon a boss or an invasion.
    /// </summary>
    public sealed class SummonBossOrInvasionPacket : Packet {
        /// <summary>
        /// Gets or sets the player index.
        /// </summary>
        public short PlayerIndex { get; set; }

        /// <summary>
        /// Gets or sets the boss or invasion type.
        /// </summary>
        public short BossOrInvasionType { get; set; }

        private protected override void ReadFromReader(BinaryReader reader, ushort packetLength) {
            PlayerIndex = reader.ReadInt16();
            BossOrInvasionType = reader.ReadInt16();
        }

        private protected override void WriteToWriter(BinaryWriter writer) {
            writer.Write(PlayerIndex);
            writer.Write(BossOrInvasionType);
        }
    }
}
