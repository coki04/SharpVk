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

namespace SharpVk.Huawei
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceClusterCullingShaderProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint) MaxWorkGroupCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint) MaxWorkGroupSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxOutputClusterCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong IndirectBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceClusterCullingShaderProperties MarshalFrom(SharpVk.Interop.Huawei.PhysicalDeviceClusterCullingShaderProperties* pointer)
        {
            PhysicalDeviceClusterCullingShaderProperties result = default(PhysicalDeviceClusterCullingShaderProperties);
            result.MaxWorkGroupCount = (pointer->MaxWorkGroupCount[0], pointer->MaxWorkGroupCount[1], pointer->MaxWorkGroupCount[2]);
            result.MaxWorkGroupSize = (pointer->MaxWorkGroupSize[0], pointer->MaxWorkGroupSize[1], pointer->MaxWorkGroupSize[2]);
            result.MaxOutputClusterCount = pointer->MaxOutputClusterCount;
            result.IndirectBufferOffsetAlignment = pointer->IndirectBufferOffsetAlignment;
            return result;
        }
    }
}
