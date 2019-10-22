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
using Orion.Npcs;

namespace Orion.Events.Npcs {
    /// <summary>
    /// Represents an NPC-related event.
    /// </summary>
    public abstract class NpcEvent : Event {
        /// <summary>
        /// Gets the NPC involved in the event.
        /// </summary>
        /// <value>The NPC involved in the event.</value>
        public INpc Npc { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NpcEvent"/> class with the specified NPC.
        /// </summary>
        /// <param name="npc">The NPC.</param>
        /// <exception cref="ArgumentNullException"><paramref name="npc"/> is <see langword="null"/>.</exception>
        protected NpcEvent(INpc npc) {
            Npc = npc ?? throw new ArgumentNullException(nameof(npc));
        }
    }
}