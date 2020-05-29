﻿using System.Diagnostics.Contracts;
using MonoRectangle = Microsoft.Xna.Framework.Rectangle;
using SadRogueRectangle = SadRogue.Primitives.Rectangle;

namespace SadRogue.Primitives
{
    public static class SadRogueRectangleExtensions
    {
        [Pure]
        public static MonoRectangle ToMonoRectangle(this SadRogueRectangle self) => new MonoRectangle(self.X, self.Y, self.Width, self.Height);

        [Pure]
        public static bool Equals(this SadRogueRectangle self, MonoRectangle other)
            => self.X == other.X && self.Y == other.Y && self.Width == other.Width && self.Height == other.Height;
    }
}

namespace Microsoft.Xna.Framework
{
    public static class MonoRectangleExtensions
    {
        [Pure]
        public static SadRogueRectangle ToRectangle(this MonoRectangle self) => new SadRogueRectangle(self.X, self.Y, self.Width, self.Height);

        [Pure]
        public static bool Equals(this MonoRectangle self, SadRogueRectangle other)
            => self.X == other.X && self.Y == other.Y && self.Width == other.Width && self.Height == other.Height;
    }
}
