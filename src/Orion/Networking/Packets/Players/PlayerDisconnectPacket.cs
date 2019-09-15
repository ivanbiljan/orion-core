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

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Orion.Networking.Packets.Extensions;

namespace Orion.Networking.Packets.Players {
    /// <summary>
    /// Packet sent from the server to the client to disconnect it. This is sent as a response to an invalid
    /// <see cref="PlayerPasswordResponsePacket"/> or for various other reasons.
    /// </summary>
    public sealed class PlayerDisconnectPacket : Packet {
        private Terraria.Localization.NetworkText _playerDisconnectReason = Terraria.Localization.NetworkText.Empty;

        /// <summary>
        /// Gets or sets the player's disconnect reason.
        /// </summary>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
        public Terraria.Localization.NetworkText PlayerDisconnectReason {
            get => _playerDisconnectReason;
            set {
                _playerDisconnectReason = value ?? throw new ArgumentNullException(nameof(value));
                IsDirty = true;
                DidLengthChange = true;
            }
        }

        /// <inheritdoc />
        public override PacketType Type => PacketType.PlayerDisconnect;

        /// <inheritdoc />
        [ExcludeFromCodeCoverage]
        public override string ToString() => $"{Type}[{PlayerDisconnectReason}]";

        private protected override void ReadFromReader(BinaryReader reader, PacketContext context) {
            _playerDisconnectReason = reader.ReadNetworkText();
        }

        private protected override void WriteToWriter(BinaryWriter writer, PacketContext context) {
            writer.Write(PlayerDisconnectReason);
        }
    }
}