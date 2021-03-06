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

using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Orion.Core.Packets.World
{
    [SuppressMessage("Style", "IDE0017:Simplify object initialization", Justification = "Testing")]
    public class MoonLordInfoTests
    {
        private readonly byte[] _bytes = { 7, 0, 103, 16, 14, 0, 0 };

        [Fact]
        public void SpawnTicks_Set_Get()
        {
            var packet = new MoonLordInfo();

            packet.SpawnTicks = 3600;

            Assert.Equal(3600, packet.SpawnTicks);
        }

        [Fact]
        public void Read()
        {
            var packet = TestUtils.ReadPacket<MoonLordInfo>(_bytes, PacketContext.Server);

            Assert.Equal(3600, packet.SpawnTicks);
        }
    }
}
