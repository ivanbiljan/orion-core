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
using JetBrains.Annotations;

namespace Orion.Networking.Packets.Entities {
    /// <summary>
    /// Packet sent to set a player's minion's target NPC.
    /// </summary>
    [PublicAPI]
    public sealed class PlayerMinionTargetNpcPacket : Packet {
        private byte _playerIndex;
        private short _playerMinionTargetNpcIndex;

        /// <inheritdoc />
        public override PacketType Type => PacketType.PlayerMinionTargetNpc;

        /// <summary>
        /// Gets or sets the player index.
        /// </summary>
        public byte PlayerIndex {
            get => _playerIndex;
            set {
                _playerIndex = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the player's minions' target NPC index.
        /// </summary>
        public short PlayerMinionTargetNpcIndex {
            get => _playerMinionTargetNpcIndex;
            set {
                _playerMinionTargetNpcIndex = value;
                _isDirty = true;
            }
        }

        /// <inheritdoc />
        [ExcludeFromCodeCoverage]
        public override string ToString() => $"{Type}[#={PlayerIndex} to N={PlayerMinionTargetNpcIndex}]";

        private protected override void ReadFromReader(BinaryReader reader, PacketContext context) {
            _playerIndex = reader.ReadByte();
            _playerMinionTargetNpcIndex = reader.ReadInt16();
        }

        private protected override void WriteToWriter(BinaryWriter writer, PacketContext context) {
            writer.Write(_playerIndex);
            writer.Write(_playerMinionTargetNpcIndex);
        }
    }
}