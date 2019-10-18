﻿// Copyright (c) 2019 Pryaxis & Orion Contributors
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
using FluentAssertions;
using Moq;
using Orion.Packets.Modules;
using Orion.Players;
using Xunit;

namespace Orion.Events.Players {
    public class PlayerChatEventArgsTests {
        [Fact]
        public void Ctor_NotDirty() {
            var player = new Mock<IPlayer>().Object;
            var args = new PlayerChatEventArgs(player, new ChatModule());

            args.IsDirty.Should().BeFalse();
        }

        [Fact]
        public void Ctor_NullPlayer_ThrowsArgumentNullException() {
            Func<PlayerChatEventArgs> func = () => new PlayerChatEventArgs(null, new ChatModule());

            func.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void Ctor_NullModule_ThrowsArgumentNullException() {
            var player = new Mock<IPlayer>().Object;
            Func<PlayerChatEventArgs> func = () => new PlayerChatEventArgs(player, null);

            func.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void SimpleProperties_Set_MarkAsDirty() {
            var player = new Mock<IPlayer>().Object;
            var args = new PlayerChatEventArgs(player, new ChatModule());

            args.SetSimplePropertiesShouldMarkAsDirty();
        }

        [Fact]
        public void SetGetProperties_ReflectsInModule() {
            var player = new Mock<IPlayer>().Object;
            var args = new PlayerChatEventArgs(player, new ChatModule());

            args.Properties_GetSetShouldReflect("_module");
        }

        [Fact]
        public void SetChatCommand_NullValue_ThrowsArgumentNullException() {
            var player = new Mock<IPlayer>().Object;
            var args = new PlayerChatEventArgs(player, new ChatModule());
            Action action = () => args.PlayerChatCommand = null;

            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void SetChatText_NullValue_ThrowsArgumentNullException() {
            var player = new Mock<IPlayer>().Object;
            var args = new PlayerChatEventArgs(player, new ChatModule());
            Action action = () => args.PlayerChatText = null;

            action.Should().Throw<ArgumentNullException>();
        }
    }
}
