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
using Xunit;

namespace Orion.Packets.Client {
    public class ClientUuidPacketTests {
        public static readonly byte[] Bytes = { 12, 0, 68, 8, 84, 101, 114, 114, 97, 114, 105, 97 };

        [Fact]
        public void Uuid_SetNullValue_ThrowsArgumentNullException() {
            var packet = new ClientUuidPacket();

            Assert.Throws<ArgumentNullException>(() => packet.Uuid = null!);
        }

        [Fact]
        public void Uuid_Set_Get() {
            var packet = new ClientUuidPacket();

            packet.Uuid = "Terraria";

            Assert.Equal("Terraria", packet.Uuid);
        }

        [Fact]
        public void Read() {
            var packet = new ClientUuidPacket();
            var span = Bytes.AsSpan(IPacket.HeaderSize..);
            Assert.Equal(span.Length, packet.Read(span, PacketContext.Server));

            Assert.Equal("Terraria", packet.Uuid);
        }

        [Fact]
        public void RoundTrip() {
            TestUtils.RoundTripPacket<ClientUuidPacket>(Bytes.AsSpan(IPacket.HeaderSize..), PacketContext.Server);
        }
    }
}