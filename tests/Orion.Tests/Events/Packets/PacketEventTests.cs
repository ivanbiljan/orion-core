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
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Orion.Packets;
using Xunit;

namespace Orion.Events.Packets {
    [SuppressMessage("Style", "IDE0017:Simplify object initialization", Justification = "Testing")]
    public class PacketEventTests {
        [Fact]
        public void Packet_Get() {
            var packet = new TestPacket();
            var evt = new TestPacketEvent<TestPacket>(ref packet);

            Assert.True(Unsafe.AreSame(ref packet, ref evt.Packet));
        }

        [Fact]
        public void CancellationReason_Set_Get() {
            var packet = new TestPacket();
            var evt = new TestPacketEvent<TestPacket>(ref packet);

            evt.CancellationReason = "test";

            Assert.Equal("test", evt.CancellationReason);
        }

        public struct TestPacket : IPacket {
            public int Value;

            public PacketId Id => throw new NotImplementedException();
            public void Read(ReadOnlySpan<byte> span, PacketContext context) => throw new NotImplementedException();
            public void Write(ref Span<byte> span, PacketContext context) => throw new NotImplementedException();
        }

        private class TestPacketEvent<TPacket> : PacketEvent<TPacket> where TPacket : struct, IPacket {
            public TestPacketEvent(ref TPacket packet) : base(ref packet) { }
        }
    }
}