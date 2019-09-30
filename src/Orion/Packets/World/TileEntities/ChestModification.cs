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

using JetBrains.Annotations;

namespace Orion.Packets.World.TileEntities {
    /// <summary>
    /// Specifies a chest modification in a <see cref="ChestModificationPacket"/>.
    /// </summary>
    [PublicAPI]
    public enum ChestModification : byte {
        /// <summary>
        /// Indicates that a chest should be placed.
        /// </summary>
        PlaceChest = 0,

        /// <summary>
        /// Indicates that a chest should be broken.
        /// </summary>
        BreakChest = 1,

        /// <summary>
        /// Indicates that a dresser should be placed.
        /// </summary>
        PlaceDresser = 2,

        /// <summary>
        /// Indicates that a dresser should be broken.
        /// </summary>
        BreakDresser = 3,

        /// <summary>
        /// Indicates that a chest should be placed.
        /// </summary>
        PlaceChest2 = 4,

        /// <summary>
        /// Indicates that a chest should be removed.
        /// </summary>
        BreakChest2 = 5
    }
}
