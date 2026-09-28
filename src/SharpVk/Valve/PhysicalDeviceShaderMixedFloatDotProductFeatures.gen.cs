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

namespace SharpVk.Valve
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceShaderMixedFloatDotProductFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderMixedFloatDotProductFloat16AccFloat32
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderMixedFloatDotProductFloat16AccFloat16
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderMixedFloatDotProductBFloat16Acc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderMixedFloatDotProductFloat8AccFloat32
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Valve.PhysicalDeviceShaderMixedFloatDotProductFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceShaderMixedFloatDotProductFeatures;
            pointer->Next = null;
            pointer->ShaderMixedFloatDotProductFloat16AccFloat32 = this.ShaderMixedFloatDotProductFloat16AccFloat32;
            pointer->ShaderMixedFloatDotProductFloat16AccFloat16 = this.ShaderMixedFloatDotProductFloat16AccFloat16;
            pointer->ShaderMixedFloatDotProductBFloat16Acc = this.ShaderMixedFloatDotProductBFloat16Acc;
            pointer->ShaderMixedFloatDotProductFloat8AccFloat32 = this.ShaderMixedFloatDotProductFloat8AccFloat32;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceShaderMixedFloatDotProductFeatures MarshalFrom(SharpVk.Interop.Valve.PhysicalDeviceShaderMixedFloatDotProductFeatures* pointer)
        {
            PhysicalDeviceShaderMixedFloatDotProductFeatures result = default(PhysicalDeviceShaderMixedFloatDotProductFeatures);
            result.ShaderMixedFloatDotProductFloat16AccFloat32 = pointer->ShaderMixedFloatDotProductFloat16AccFloat32;
            result.ShaderMixedFloatDotProductFloat16AccFloat16 = pointer->ShaderMixedFloatDotProductFloat16AccFloat16;
            result.ShaderMixedFloatDotProductBFloat16Acc = pointer->ShaderMixedFloatDotProductBFloat16Acc;
            result.ShaderMixedFloatDotProductFloat8AccFloat32 = pointer->ShaderMixedFloatDotProductFloat8AccFloat32;
            return result;
        }
    }
}
