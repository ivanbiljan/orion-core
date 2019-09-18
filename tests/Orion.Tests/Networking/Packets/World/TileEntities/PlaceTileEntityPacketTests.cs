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

using System.IO;
using FluentAssertions;
using Orion.World.TileEntities;
using Xunit;

namespace Orion.Networking.Packets.World.TileEntities {
    public class PlaceTileEntityPacketTests {
        private static readonly byte[] Bytes = {8, 0, 87, 0, 1, 100, 0, 1};

        [Fact]
        public void ReadFromStream_Delete_IsCorrect() {
            using (var stream = new MemoryStream(Bytes)) {
                var packet = (PlaceTileEntityPacket)Packet.ReadFromStream(stream, PacketContext.Server);

                packet.TileEntityX.Should().Be(256);
                packet.TileEntityY.Should().Be(100);
                packet.TileEntityType.Should().BeSameAs(TileEntityType.ItemFrame);
            }
        }

        [Fact]
        public void DeserializeAndSerialize_SamePacket() {
            Bytes.ShouldDeserializeAndSerializeSamePacket();
        }
    }
}