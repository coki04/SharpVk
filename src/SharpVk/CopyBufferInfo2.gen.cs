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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct CopyBufferInfo2
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Buffer SourceBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Buffer DestinationBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.BufferCopy2[] Regions
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.CopyBufferInfo2* pointer)
        {
            pointer->SType = StructureType.CopyBufferInfo2Version;
            pointer->Next = null;
            pointer->SourceBuffer = this.SourceBuffer?.handle ?? default(SharpVk.Interop.Buffer);
            pointer->DestinationBuffer = this.DestinationBuffer?.handle ?? default(SharpVk.Interop.Buffer);
            pointer->RegionCount = (uint)(Interop.HeapUtil.GetLength(this.Regions));
            if (this.Regions != null)
            {
                var fieldPointer = (SharpVk.Interop.BufferCopy2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BufferCopy2>(this.Regions.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Regions.Length); index++)
                {
                    this.Regions[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Regions = fieldPointer;
            }
            else
            {
                pointer->Regions = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe CopyBufferInfo2 MarshalFrom(SharpVk.Interop.CopyBufferInfo2* pointer)
        {
            CopyBufferInfo2 result = default(CopyBufferInfo2);
            result.SourceBuffer = new SharpVk.Buffer(default(SharpVk.Device), pointer->SourceBuffer);
            result.DestinationBuffer = new SharpVk.Buffer(default(SharpVk.Device), pointer->DestinationBuffer);
            if (pointer->Regions != null)
            {
                var fieldPointer = new SharpVk.BufferCopy2[(uint)(pointer->RegionCount)];
                for(int index = 0; index < (uint)(pointer->RegionCount); index++)
                {
                    fieldPointer[index] = SharpVk.BufferCopy2.MarshalFrom(&pointer->Regions[index]);
                }
                result.Regions = fieldPointer;
            }
            else
            {
                result.Regions = null;
            }
            return result;
        }
    }
}
