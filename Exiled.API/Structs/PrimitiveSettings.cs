// -----------------------------------------------------------------------
// <copyright file="PrimitiveSettings.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Structs
{
    using AdminToys;
    using UnityEngine;

    /// <summary>
    /// Settings for primitives.
    /// </summary>
    public struct PrimitiveSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimitiveSettings"/> struct.
        /// </summary>
        /// <param name="primitiveType">The type of the primitive.</param>
        /// <param name="color">The color of the primitive.</param>
        /// <param name="position">The position of the primitive.</param>
        /// <param name="rotation">The rotation of the primitive.</param>
        /// <param name="scale">The scale of the primitive.</param>
        /// <param name="spawn">Whether or not the primitive should be spawned.</param>
        /// <param name="isStatic">Whether or not the primitive should be static.</param>
        public PrimitiveSettings(PrimitiveType primitiveType, Color color, Vector3 position, Vector3 rotation, Vector3 scale, bool spawn, bool isStatic)
        {
            PrimitiveType = primitiveType;
            Flags = PrimitiveFlags.Collidable | PrimitiveFlags.Visible;
            Color = color;
            Position = position;
            Rotation = rotation;
            Scale = scale;
            Spawn = spawn;
            IsStatic = isStatic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrimitiveSettings"/> struct.
        /// </summary>
        /// <param name="primitiveType">The type of the primitive.</param>
        /// <param name="color">The color of the primitive.</param>
        /// <param name="position">The position of the primitive.</param>
        /// <param name="rotation">The rotation of the primitive.</param>
        /// <param name="scale">The scale of the primitive.</param>
        /// <param name="spawn">Whether or not the primitive should be spawned.</param>
        public PrimitiveSettings(PrimitiveType primitiveType, Color color, Vector3 position, Vector3 rotation, Vector3 scale, bool spawn)
        {
            PrimitiveType = primitiveType;
            Flags = PrimitiveFlags.Collidable | PrimitiveFlags.Visible;
            Color = color;
            Position = position;
            Rotation = rotation;
            Scale = scale;
            Spawn = spawn;
            IsStatic = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrimitiveSettings"/> struct.
        /// </summary>
        /// <param name="primitiveType">The type of the primitive.</param>
        /// <param name="primitiveFlags">The flags of the primitive.</param>
        /// <param name="color">The color of the primitive.</param>
        /// <param name="position">The position of the primitive.</param>
        /// <param name="rotation">The rotation of the primitive.</param>
        /// <param name="scale">The scale of the primitive.</param>
        /// <param name="spawn">Whether or not the primitive should be spawned.</param>
        public PrimitiveSettings(PrimitiveType primitiveType, PrimitiveFlags primitiveFlags, Color color, Vector3 position, Vector3 rotation, Vector3 scale, bool spawn)
        {
            PrimitiveType = primitiveType;
            Flags = primitiveFlags;
            Color = color;
            Position = position;
            Rotation = rotation;
            Scale = scale;
            Spawn = spawn;
            IsStatic = false;
        }

        /// <summary>
        /// Gets the primitive type.
        /// </summary>
        public PrimitiveType PrimitiveType { get; }

        /// <summary>
        /// Gets the primitive flags.
        /// </summary>
        public PrimitiveFlags Flags { get; }

        /// <summary>
        /// Gets the primitive color.
        /// </summary>
        public Color Color { get; }

        /// <summary>
        /// Gets the primitive position.
        /// </summary>
        public Vector3 Position { get; }

        /// <summary>
        /// Gets the primitive rotation.
        /// </summary>
        public Vector3 Rotation { get; }

        /// <summary>
        /// Gets the primitive scale.
        /// </summary>
        public Vector3 Scale { get; }

        /// <summary>
        /// Gets a value indicating whether or not the primitive should be spawned.
        /// </summary>
        public bool IsStatic { get; }

        /// <summary>
        /// Gets a value indicating whether or not the primitive should be spawned.
        /// </summary>
        public bool Spawn { get; }
    }
}