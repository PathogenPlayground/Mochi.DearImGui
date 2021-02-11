// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 136)]
public unsafe partial struct ImFontConfig
{
    [FieldOffset(0)] public void* FontData;

    [FieldOffset(8)] public int FontDataSize;

    [FieldOffset(12)] [MarshalAs(UnmanagedType.I1)] public bool FontDataOwnedByAtlas;

    [FieldOffset(16)] public int FontNo;

    [FieldOffset(20)] public float SizePixels;

    [FieldOffset(24)] public int OversampleH;

    [FieldOffset(28)] public int OversampleV;

    [FieldOffset(32)] [MarshalAs(UnmanagedType.I1)] public bool PixelSnapH;

    [FieldOffset(36)] public ImVec2 GlyphExtraSpacing;

    [FieldOffset(44)] public ImVec2 GlyphOffset;

    [FieldOffset(56)] public ushort* GlyphRanges;

    [FieldOffset(64)] public float GlyphMinAdvanceX;

    [FieldOffset(68)] public float GlyphMaxAdvanceX;

    [FieldOffset(72)] [MarshalAs(UnmanagedType.I1)] public bool MergeMode;

    [FieldOffset(76)] public uint FontBuilderFlags;

    [FieldOffset(80)] public float RasterizerMultiply;

    [FieldOffset(84)] public ushort EllipsisChar;

    [FieldOffset(86)] public ConstantArray_char_40 Name;

    [FieldOffset(128)] public ImFont* DstFont;

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0ImFontConfig@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(ImFontConfig* @this);

    [DebuggerStepThrough, DebuggerHidden]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Constructor()
    {
        fixed (ImFontConfig* @this = &this)
        { Constructor_PInvoke(@this); }
    }
}
