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
using Moq;
using Orion.Entities;
using Orion.Packets;
using Xunit;

namespace Orion.Players {
    public class PlayerServiceTests {
        [Fact]
        public void BroadcastPacket_Ref() {
            var mockPlayer = new Mock<IPlayer>();
            var mockPlayers = new Mock<IReadOnlyArray<IPlayer>>();
            mockPlayers.SetupGet(p => p.Count).Returns(1);
            mockPlayers.SetupGet(p => p[0]).Returns(mockPlayer.Object);
            var mockPlayerService = new Mock<IPlayerService>();
            mockPlayerService.SetupGet(ps => ps.Players).Returns(mockPlayers.Object);

            var packet = new TestPacket();
            mockPlayerService.Object.BroadcastPacket(ref packet);

            mockPlayer.Verify(p => p.SendPacket(ref It.Ref<TestPacket>.IsAny));
        }

        [Fact]
        public void BroadcastPacket() {
            var mockPlayer = new Mock<IPlayer>();
            var mockPlayers = new Mock<IReadOnlyArray<IPlayer>>();
            mockPlayers.SetupGet(p => p.Count).Returns(1);
            mockPlayers.SetupGet(p => p[0]).Returns(mockPlayer.Object);
            var mockPlayerService = new Mock<IPlayerService>();
            mockPlayerService.SetupGet(ps => ps.Players).Returns(mockPlayers.Object);

            var packet = new TestPacket();
            mockPlayerService.Object.BroadcastPacket(packet);

            mockPlayer.Verify(p => p.SendPacket(ref It.Ref<TestPacket>.IsAny));
        }

        private struct TestPacket : IPacket {
            public PacketId Id => throw new NotImplementedException();
            public void Read(ReadOnlySpan<byte> span, PacketContext context) => throw new NotImplementedException();
            public void Write(ref Span<byte> span, PacketContext context) => throw new NotImplementedException();
        }
    }
}
