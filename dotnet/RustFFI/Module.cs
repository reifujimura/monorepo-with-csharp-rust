using System;
using System.Runtime.InteropServices;

namespace RustFFI
{
    public static class Module
    {
        [DllImport("rust_ffi", EntryPoint = "rust_add")]
        public static extern Int32 RustAdd(Int32 a, Int32 b);
    }
}
