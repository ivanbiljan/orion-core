﻿using System.Diagnostics;
using Orion.Entities;

namespace Orion.Items {
    /// <summary>
    /// Orion's implementation of <see cref="Orion.Items.IItem"/>.
    /// </summary>
    internal sealed class OrionItem : OrionEntity, IItem {
        public ItemType Type {
            get => (ItemType)WrappedItem.type;
            set => WrappedItem.type = (int)value;
        }

        public int StackSize {
            get => WrappedItem.stack;
            set => WrappedItem.stack = value;
        }

        public int MaxStackSize {
            get => WrappedItem.maxStack;
            set => WrappedItem.maxStack = value;
        }

        public ItemPrefix Prefix => (ItemPrefix)WrappedItem.prefix;

        public ItemRarity Rarity {
            get => (ItemRarity)WrappedItem.rare;
            set => WrappedItem.rare = (int)value;
        }

        public int Damage {
            get => WrappedItem.damage;
            set => WrappedItem.damage = value;
        }

        public int UseTime {
            get => WrappedItem.useTime;
            set => WrappedItem.useTime = value;
        }

        internal Terraria.Item WrappedItem { get; }
        
        public OrionItem(Terraria.Item terrariaItem) : base(terrariaItem) {
            Debug.Assert(terrariaItem != null, $"{nameof(terrariaItem)} should not be null.");

            WrappedItem = terrariaItem;
        }

        public void ApplyType(ItemType type) => WrappedItem.SetDefaults((int)type);
        public void ApplyPrefix(ItemPrefix prefix) => WrappedItem.Prefix((int)prefix);
    }
}
