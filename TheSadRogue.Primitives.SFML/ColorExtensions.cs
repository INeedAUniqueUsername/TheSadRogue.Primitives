﻿using SFMLColor = SFML.Graphics.Color;
using SadRogueColor = SadRogue.Primitives.Color;

namespace SadRogue.Primitives
{
    public static class SadRogueColorExtensions
    {
        public static SFMLColor ToMonoColor(this SadRogueColor self) => new SFMLColor(self.R, self.G, self.B, self.A);
        public static bool Equals(this SadRogueColor self, SFMLColor other)
            => self.R == other.R && self.G == other.G && self.B == other.B && self.A == other.A;
    }
}

namespace SFML.Graphics
{
    public static class SFMLColorExtensions
    {
        public static SadRogueColor ToSadRogueColor(this SFMLColor self) => new SadRogueColor(self.R, self.G, self.B, self.A);
        public static bool Equals(this SFMLColor self, SadRogueColor other)
            => self.R == other.R && self.G == other.G && self.B == other.B && self.A == other.A;
    }
}