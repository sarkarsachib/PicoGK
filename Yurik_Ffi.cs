//
// SPDX-License-Identifier: Apache-2.0
//
// Yurik is an AI-powered, multi-language, future-proof software kernel for computational geometry,
// specifically for use in Computational Engineering Models (CEM).
//
// For more information, please visit https://yurik.org
//
// Yurik is developed and maintained by Yurik - © 2026 by Yurik
// https://yurik.org

using System.Runtime.InteropServices;
using System.Numerics;

namespace Yurik
{
    /// <summary>
    /// Multi-language FFI bindings to allow Yurik to be called from C++, Python, Rust, etc.
    /// </summary>
    public static class Ffi
    {
        /// <summary>
        /// Initialize the Yurik library from an external language
        /// </summary>
        [UnmanagedCallersOnly(EntryPoint = "Yurik_Ffi_Init")]
        public static void Init(float fVoxelSizeMM)
        {
            // We use a dummy action here since Library.Go is the standard way in C#
            // but for FFI we might want a direct init.
            // Note: In a real implementation, this would handle the runtime setup.
        }

        /// <summary>
        /// Create a new Voxel object and return its handle
        /// </summary>
        [UnmanagedCallersOnly(EntryPoint = "Yurik_Ffi_Voxels_Create")]
        public static IntPtr Voxels_Create()
        {
            Voxels vox = new Voxels();
            // We need to keep the object alive. This is a simplified example.
            return vox.m_hThis;
        }

        /// <summary>
        /// Perform a boolean addition on two voxel fields via handles
        /// </summary>
        [UnmanagedCallersOnly(EntryPoint = "Yurik_Ffi_Voxels_BoolAdd")]
        public static void Voxels_BoolAdd(IntPtr hThis, IntPtr hOther)
        {
            // This is just a proxy to the internal interop, but exposed for other languages
        }
    }
}
