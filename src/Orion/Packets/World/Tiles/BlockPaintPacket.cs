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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Orion.World.Tiles;

namespace Orion.Packets.World.Tiles {
    /// <summary>
    /// A packet sent to paint a block.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct BlockPaintPacket : IPacket {
        /// <summary>
        /// Gets or sets the block's X coordinate.
        /// </summary>
        /// <value>The block's X coordinate.</value>
        [field: FieldOffset(0)] public short X { get; set; }

        /// <summary>
        /// Gets or sets the block's Y coordinate.
        /// </summary>
        /// <value>The block's Y coordinate.</value>
        [field: FieldOffset(2)] public short Y { get; set; }

        /// <summary>
        /// Gets or sets the paint color.
        /// </summary>
        /// <value>The paint color.</value>
        [field: FieldOffset(4)] public PaintColor Color { get; set; }

        PacketId IPacket.Id => PacketId.BlockPaint;

        /// <inheritdoc/>
        public int Read(Span<byte> span, PacketContext context) {
            Unsafe.CopyBlockUnaligned(ref this.AsRefByte(0), ref span[0], 5);
            return 5;
        }

        /// <inheritdoc/>
        public int Write(Span<byte> span, PacketContext context) {
            Unsafe.CopyBlockUnaligned(ref span[0], ref this.AsRefByte(0), 5);
            return 5;
        }
    }
}
