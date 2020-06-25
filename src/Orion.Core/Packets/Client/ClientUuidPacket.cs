﻿// Copyright (c) 2020 Pryaxis & Orion Contributors
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
using System.Text;
using Destructurama.Attributed;

namespace Orion.Core.Packets.Client
{
    /// <summary>
    /// A packet sent from the client to the server to inform the server of its UUID.
    /// </summary>
    public sealed class ClientUuidPacket : IPacket
    {
        private string _uuid = string.Empty;

        /// <summary>
        /// Gets or sets the client's UUID.
        /// </summary>
        /// <value>The client's UUID.</value>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is <see langword="null"/>.</exception>
        [LogMasked]
        public string Uuid
        {
            get => _uuid;
            set => _uuid = value ?? throw new ArgumentNullException(nameof(value));
        }

        PacketId IPacket.Id => PacketId.ClientUuid;

        int IPacket.ReadBody(Span<byte> span, PacketContext context) => span.Read(Encoding.UTF8, out _uuid);
        int IPacket.WriteBody(Span<byte> span, PacketContext context) => span.Write(Uuid, Encoding.UTF8);
    }
}
