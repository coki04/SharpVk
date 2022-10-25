// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2022
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
        public IntPtr IndexBuffer
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
        public SharpVk.Multivendor.MicromapUsage[] UsageCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.Micromap Micromap
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.AccelerationStructureTrianglesOpacityMicromap* pointer)
        {
            pointer->SType = StructureType.AccelerationStructureTrianglesOpacityMicromap;
            pointer->Next = null;
            pointer->IndexType = this.IndexType;
            pointer->IndexBuffer = this.IndexBuffer;
            pointer->IndexStride = this.IndexStride;
            pointer->BaseTriangle = this.BaseTriangle;
            pointer->UsageCountsCount = (uint)(Interop.HeapUtil.GetLength(this.UsageCounts));
            if (this.UsageCounts != null)
            {
                var fieldPointer = (SharpVk.Multivendor.MicromapUsage*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Multivendor.MicromapUsage>(this.UsageCounts.Length).ToPointer());
                for(int index = 0; index < (uint)(this.UsageCounts.Length); index++)
                {
                    fieldPointer[index] = this.UsageCounts[index];
                }
                pointer->UsageCounts = fieldPointer;
            }
            else
            {
                pointer->UsageCounts = null;
            }
            pointer->Micromap = this.Micromap?.handle ?? default(SharpVk.Interop.Multivendor.Micromap);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe AccelerationStructureTrianglesOpacityMicromap MarshalFrom(SharpVk.Interop.Multivendor.AccelerationStructureTrianglesOpacityMicromap* pointer)
        {
            AccelerationStructureTrianglesOpacityMicromap result = default(AccelerationStructureTrianglesOpacityMicromap);
            result.IndexType = pointer->IndexType;
            result.IndexBuffer = pointer->IndexBuffer;
            result.IndexStride = pointer->IndexStride;
            result.BaseTriangle = pointer->BaseTriangle;
            if (pointer->UsageCounts != null)
            {
                var fieldPointer = new SharpVk.Multivendor.MicromapUsage[(uint)(pointer->UsageCountsCount)];
                for(int index = 0; index < (uint)(pointer->UsageCountsCount); index++)
                {
                    fieldPointer[index] = pointer->UsageCounts[index];
                }
                result.UsageCounts = fieldPointer;
            }
            else
            {
                result.UsageCounts = null;
            }
            result.Micromap = new SharpVk.Multivendor.Micromap(default(SharpVk.Device), pointer->Micromap);
            return result;
        }
    }
}
