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

namespace Orion.Packets {
    /// <summary>
    /// An unknown packet.
    /// </summary>
    public struct UnknownPacket : IPacket {
        private unsafe fixed byte _data[ushort.MaxValue - IPacket.HeaderSize];

        /// <summary>
        /// Gets or sets the packet length.
        /// </summary>
        /// <value>The packet length.</value>
        public ushort Length { get; set; }

        /// <summary>
        /// Gets or sets the packet ID.
        /// </summary>
        /// <value>The packet ID.</value>
        public PacketId Id { get; set; }

        /// <summary>
        /// Gets a reference to the byte at the given <paramref name="index"/> in the packet data.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>A reference to the byte at the given <paramref name="index"/> in the packet data.</returns>
        public unsafe ref byte Data(int index) => ref _data[index];

        /// <inheritdoc/>
        public unsafe int Read(Span<byte> span, PacketContext context) {
            Length = (ushort)span.Length;
            if (Length == 0) {
                return 0;
            }

            Unsafe.CopyBlockUnaligned(ref _data[0], ref span[0], Length);
            return Length;
        }

        /// <inheritdoc/>
        public unsafe int Write(Span<byte> span, PacketContext context) {
            if (Length == 0) {
                return 0;
            }

            Unsafe.CopyBlockUnaligned(ref span[0], ref _data[0], Length);
            return Length;
        }
    }
}