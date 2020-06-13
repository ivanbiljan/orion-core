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
using Xunit;

namespace Orion.Core.Buffs {
    public class BuffTests {
        [Fact]
        public void Ctor_NegativeDuration_ThrowsArgumentOutOfRangeException() {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(-8)));
        }

        [Fact]
        public void Id_Get() {
            var buff = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(8));

            Assert.Equal(BuffId.ObsidianSkin, buff.Id);
        }

        [Fact]
        public void Duration_Get() {
            var buff = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(8));

            Assert.Equal(TimeSpan.FromMinutes(8), buff.Duration);
        }

        [Fact]
        public void Equals_ReturnsTrue() {
            var buff = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(8));
            var buff2 = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(8));

            Assert.True(buff.Equals((object)buff2));
            Assert.True(buff.Equals(buff2));
        }

        [Fact]
        public void Equals_ReturnsFalse() {
            var buff = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(8));
            var buff2 = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(7));
            var buff3 = new Buff(BuffId.Poisoned, TimeSpan.FromMinutes(8));

            Assert.False(buff.Equals(1));
            Assert.False(buff.Equals((object)buff2));
            Assert.False(buff.Equals((object)buff3));
            Assert.False(buff.Equals(buff2));
            Assert.False(buff.Equals(buff3));
        }

        [Fact]
        public void GetHashCode_Equals_AreEqual() {
            var buff = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(8));
            var buff2 = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(8));

            Assert.Equal(buff.GetHashCode(), buff2.GetHashCode());
        }

        [Fact]
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Operator name")]
        public void op_Equality_ReturnsTrue() {
            var buff = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(8));
            var buff2 = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(8));

            Assert.True(buff == buff2);
        }

        [Fact]
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Operator name")]
        public void op_Equality_ReturnsFalse() {
            var buff = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(8));
            var buff2 = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(7));
            var buff3 = new Buff(BuffId.Poisoned, TimeSpan.FromMinutes(8));

            Assert.False(buff == buff2);
            Assert.False(buff == buff3);
        }

        [Fact]
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Operator name")]
        public void op_Inequality_ReturnsTrue() {
            var buff = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(8));
            var buff2 = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(7));
            var buff3 = new Buff(BuffId.Poisoned, TimeSpan.FromMinutes(8));

            Assert.True(buff != buff2);
            Assert.True(buff != buff3);
        }

        [Fact]
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Operator name")]
        public void op_Inequality_ReturnsFalse() {
            var buff = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(8));
            var buff2 = new Buff(BuffId.ObsidianSkin, TimeSpan.FromMinutes(8));

            Assert.False(buff != buff2);
        }
    }
}
