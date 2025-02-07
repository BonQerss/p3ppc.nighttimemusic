﻿using Reloaded.Memory.Pointers;

namespace Heroes.SDK.Definitions.Structures.Graphics.Device
{
    /// <summary>
    /// Replicates the hardcoded resolution struct stored inside the Sonic Heroes executable.
    /// </summary>
    [Equals(DoNotAddEqualityOperators = true)]
    public struct NativeResolutionEntry
    {
        // TODO: No idea where to put this. Changing this has kinda no effect once the game starts running so /shrug
        // Cannot make this a property due to a runtime bug: https://github.com/dotnet/runtime/issues/1105
        public static RefFixedArrayPtr<NativeResolutionEntry> GetEntries() => new RefFixedArrayPtr<NativeResolutionEntry>(0x7C9290, 8);

        public int Width;
        public int Height;
        public int BitsPerPixel;

        public int Unknown0;
        public int Unknown1;
    }
}