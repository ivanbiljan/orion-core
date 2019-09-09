﻿using System.Diagnostics;
using Microsoft.Xna.Framework;
using Orion.Utils;

namespace Orion.Entities {
    internal abstract class OrionEntity<TEntity> : AnnotatableObject, IEntity where TEntity : Terraria.Entity {
        public int Index => Wrapped.whoAmI;
        
        public bool IsActive {
            get => Wrapped.active;
            set => Wrapped.active = value;
        }
        
        public abstract string Name { get; set; }
        
        public Vector2 Position {
            get => Wrapped.position;
            set => Wrapped.position = value;
        }
        
        public Vector2 Velocity {
            get => Wrapped.velocity;
            set => Wrapped.velocity = value;
        }
        
        public Vector2 Size {
            get => Wrapped.Size;
            set => Wrapped.Size = value;
        }

        internal TEntity Wrapped { get; }

        protected OrionEntity(TEntity terrariaEntity) {
            Debug.Assert(terrariaEntity != null, $"{nameof(terrariaEntity)} should not be null.");

            Wrapped = terrariaEntity;
        }
    }
}
