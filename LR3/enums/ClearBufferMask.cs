using System;

namespace LR3.enums
{
    [Flags]
    public enum ClearBufferMask
    {
        DepthBufferBit = 0x00000100,
        ColorBufferBit = 0x00004000,
    }
}