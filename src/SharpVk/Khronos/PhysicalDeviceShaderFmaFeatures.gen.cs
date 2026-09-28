// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2026
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;
using System.Runtime.InteropServices;

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceShaderFmaFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderFmaFloat16
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderFmaFloat32
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderFmaFloat64
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.PhysicalDeviceShaderFmaFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceShaderFmaFeatures;
            pointer->Next = null;
            pointer->ShaderFmaFloat16 = this.ShaderFmaFloat16;
            pointer->ShaderFmaFloat32 = this.ShaderFmaFloat32;
            pointer->ShaderFmaFloat64 = this.ShaderFmaFloat64;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceShaderFmaFeatures MarshalFrom(SharpVk.Interop.Khronos.PhysicalDeviceShaderFmaFeatures* pointer)
        {
            PhysicalDeviceShaderFmaFeatures result = default(PhysicalDeviceShaderFmaFeatures);
            result.ShaderFmaFloat16 = pointer->ShaderFmaFloat16;
            result.ShaderFmaFloat32 = pointer->ShaderFmaFloat32;
            result.ShaderFmaFloat64 = pointer->ShaderFmaFloat64;
            return result;
        }
    }
}
