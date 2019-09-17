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
using Orion.Entities;

namespace Orion.Networking.Packets.Players {
    /// <summary>
    /// Packet sent to set a player's team.
    /// </summary>
    public sealed class PlayerTeamPacket : Packet {
        private byte _playerIndex;
        private PlayerTeam _playerTeam;

        /// <summary>
        /// Gets or sets the player index.
        /// </summary>
        public byte PlayerIndex {
            get => _playerIndex;
            set {
                _playerIndex = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the player's team.
        /// </summary>
        public PlayerTeam PlayerTeam {
            get => _playerTeam;
            set {
                _playerTeam = value;
                IsDirty = true;
            }
        }

        /// <inheritdoc />
        public override PacketType Type => PacketType.PlayerTeam;

        /// <inheritdoc />
        [ExcludeFromCodeCoverage]
        public override string ToString() => $"{Type}[#={PlayerIndex} is {PlayerTeam}]";

        private protected override void ReadFromReader(BinaryReader reader, PacketContext context) {
            _playerIndex = reader.ReadByte();
            _playerTeam = (PlayerTeam)reader.ReadByte();
        }

        private protected override void WriteToWriter(BinaryWriter writer, PacketContext context) {
            writer.Write(PlayerIndex);
            writer.Write((byte)PlayerTeam);
        }
    }
}