﻿// Copyright (c) 2015-2019 Pryaxis & Orion Contributors
// 
// This file is part of Orion.
// 
// Orion is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Orion is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Orion.  If not, see <https://www.gnu.org/licenses/>.

using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Orion.Networking.Packets.World {
    /// <summary>
    /// Packet sent to activate wire at a specific position.
    /// </summary>
    public sealed class ActivateWirePacket : Packet {
        /// <summary>
        /// Gets or sets the wire's X coordinate.
        /// </summary>
        public short WireX { get; set; }

        /// <summary>
        /// Gets or sets the wire's Y coordinate.
        /// </summary>
        public short WireY { get; set; }

        public override PacketType Type => PacketType.ActivateWire;

        /// <inheritdoc />
        [ExcludeFromCodeCoverage]
        public override string ToString() => $"{Type}[({WireX}, {WireY})]";

        private protected override void ReadFromReader(BinaryReader reader, PacketContext context) {
            WireX = reader.ReadInt16();
            WireY = reader.ReadInt16();
        }

        private protected override void WriteToWriter(BinaryWriter writer, PacketContext context) {
            writer.Write(WireX);
            writer.Write(WireY);
        }
    }
}
