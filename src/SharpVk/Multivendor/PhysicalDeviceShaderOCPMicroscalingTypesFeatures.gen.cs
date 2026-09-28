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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceShaderOCPMicroscalingTypesFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderFloat4
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderFloat6
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderFloat8UnsignedE8M0
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderMXInt8
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.PhysicalDeviceShaderOCPMicroscalingTypesFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceShaderOcpMicroscalingTypesFeatures;
            pointer->Next = null;
            pointer->ShaderFloat4 = this.ShaderFloat4;
            pointer->ShaderFloat6 = this.ShaderFloat6;
            pointer->ShaderFloat8UnsignedE8M0 = this.ShaderFloat8UnsignedE8M0;
            pointer->ShaderMXInt8 = this.ShaderMXInt8;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceShaderOCPMicroscalingTypesFeatures MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceShaderOCPMicroscalingTypesFeatures* pointer)
        {
            PhysicalDeviceShaderOCPMicroscalingTypesFeatures result = default(PhysicalDeviceShaderOCPMicroscalingTypesFeatures);
            result.ShaderFloat4 = pointer->ShaderFloat4;
            result.ShaderFloat6 = pointer->ShaderFloat6;
            result.ShaderFloat8UnsignedE8M0 = pointer->ShaderFloat8UnsignedE8M0;
            result.ShaderMXInt8 = pointer->ShaderMXInt8;
            return result;
        }
    }
}
