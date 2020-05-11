using System;

namespace LR3.enums
{
    [Flags]
    public enum ClearBufferMask
    {
        DepthBufferBit = 0x00000100,
        AccumBufferBit = 0x00000200,
        StencilBufferBit = 0x00000400,
        ColorBufferBit = 0x00004000,
    }
}