using System;
using System.Runtime.InteropServices;

namespace RustFFI
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RustVector2D
    {
        public double X;
        public double Y;
    }
    public static class Module
    {

        [DllImport("rust_ffi", EntryPoint = "rust_add")]
        public static extern Int32 RustAdd(Int32 a, Int32 b);

        [DllImport("rust_ffi", EntryPoint = "rust_length")]
        public static extern double RustLength(RustVector2D vector);
    }
}
