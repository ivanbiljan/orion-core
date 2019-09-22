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
using System.IO;
using FluentAssertions;
using Orion.Entities;
using Xunit;

namespace Orion.Networking.Packets.Entities {
    public class NpcBuffsPacketTests {
        [Fact]
        public void SetSimpleProperties_MarkAsDirty() {
            var packet = new NpcBuffsPacket();

            packet.SetSimplePropertiesShouldMarkAsDirty();
        }

        [Fact]
        public void NpcBuffs_SetItem_MarksAsDirty() {
            var packet = new NpcBuffsPacket();

            packet.NpcBuffs[0] = new Buff(BuffType.None, TimeSpan.Zero);

            packet.ShouldBeDirty();
        }

        [Fact]
        public void NpcBuffs_Count_IsCorrect() {
            var packet = new NpcBuffsPacket();

            packet.NpcBuffs.Count.Should().Be(Terraria.NPC.maxBuffs);
        }

        public static readonly byte[] Bytes = {20, 0, 54, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        [Fact]
        public void ReadFromStream_IsCorrect() {
            using (var stream = new MemoryStream(Bytes)) {
                var packet = (NpcBuffsPacket)Packet.ReadFromStream(stream, PacketContext.Server);

                packet.NpcIndex.Should().Be(0);
                foreach (var buff in packet.NpcBuffs) {
                    buff.Should().Be(new Buff(BuffType.None, TimeSpan.Zero));
                }
            }
        }

        [Fact]
        public void DeserializeAndSerialize_SamePacket() {
            Bytes.ShouldDeserializeAndSerializeSamePacket();
        }
    }
}
