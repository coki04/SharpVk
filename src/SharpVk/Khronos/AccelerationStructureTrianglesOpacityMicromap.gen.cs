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
    public partial struct AccelerationStructureTrianglesOpacityMicromap
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.IndexType IndexType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong IndexBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong IndexStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint BaseTriangle
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AccelerationStructure Micromap
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.AccelerationStructureTrianglesOpacityMicromap* pointer)
        {
            pointer->SType = StructureType.AccelerationStructureTrianglesOpacityMicromapKhr;
            pointer->Next = null;
            pointer->IndexType = this.IndexType;
            pointer->IndexBuffer = this.IndexBuffer;
            pointer->IndexStride = this.IndexStride;
            pointer->BaseTriangle = this.BaseTriangle;
            pointer->Micromap = this.Micromap?.handle ?? default(SharpVk.Interop.Khronos.AccelerationStructure);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe AccelerationStructureTrianglesOpacityMicromap MarshalFrom(SharpVk.Interop.Khronos.AccelerationStructureTrianglesOpacityMicromap* pointer)
        {
            AccelerationStructureTrianglesOpacityMicromap result = default(AccelerationStructureTrianglesOpacityMicromap);
            result.IndexType = pointer->IndexType;
            result.IndexBuffer = pointer->IndexBuffer;
            result.IndexStride = pointer->IndexStride;
            result.BaseTriangle = pointer->BaseTriangle;
            result.Micromap = new SharpVk.Khronos.AccelerationStructure(default(SharpVk.Device), pointer->Micromap);
            return result;
        }
    }
}
