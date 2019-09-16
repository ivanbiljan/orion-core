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

namespace Orion.Networking.Packets.Npcs {
    /// <summary>
    /// Packet sent to set an NPC's home.
    /// </summary>
    public sealed class NpcHomePacket : Packet {
        private short _npcIndex;
        private short _npcHomeX;
        private short _npcHomeY;
        private bool _isNpcHomeless;

        /// <summary>
        /// Gets or sets the NPC index.
        /// </summary>
        public short NpcIndex {
            get => _npcIndex;
            set {
                _npcIndex = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the NPC home's X coordinate.
        /// </summary>
        public short NpcHomeX {
            get => _npcHomeX;
            set {
                _npcHomeX = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the NPC home's Y coordinate.
        /// </summary>
        public short NpcHomeY {
            get => _npcHomeY;
            set {
                _npcHomeY = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the NPC is homeless.
        /// </summary>
        public bool IsNpcHomeless {
            get => _isNpcHomeless;
            set {
                _isNpcHomeless = value;
                IsDirty = true;
            }
        }

        /// <inheritdoc />
        public override PacketType Type => PacketType.NpcHome;

        /// <inheritdoc />
        [ExcludeFromCodeCoverage]
        public override string ToString() => $"{Type}[#={NpcIndex} @ ({NpcHomeX}, {NpcHomeY}), ...]";

        private protected override void ReadFromReader(BinaryReader reader, PacketContext context) {
            _npcIndex = reader.ReadInt16();
            _npcHomeX = reader.ReadInt16();
            _npcHomeY = reader.ReadInt16();
            _isNpcHomeless = reader.ReadBoolean();
        }

        private protected override void WriteToWriter(BinaryWriter writer, PacketContext context) {
            writer.Write(NpcIndex);
            writer.Write(NpcHomeX);
            writer.Write(NpcHomeY);
            writer.Write(IsNpcHomeless);
        }
    }
}
