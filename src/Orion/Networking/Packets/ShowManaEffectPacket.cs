﻿using System.IO;

namespace Orion.Networking.Packets {
    /// <summary>
    /// Packet sent to show a mana effect.
    /// </summary>
    public sealed class ShowManaEffectPacket : Packet {
        /// <summary>
        /// Gets or sets the player index.
        /// </summary>
        public byte PlayerIndex { get; set; }

        /// <summary>
        /// Gets or sets the mana amount.
        /// </summary>
        public short ManaAmount { get; set; }

        private protected override void ReadFromReader(BinaryReader reader, ushort packetLength) {
            PlayerIndex = reader.ReadByte();
            ManaAmount = reader.ReadInt16();
        }

        private protected override void WriteToWriter(BinaryWriter writer) {
            writer.Write(PlayerIndex);
            writer.Write(ManaAmount);
        }
    }
}
