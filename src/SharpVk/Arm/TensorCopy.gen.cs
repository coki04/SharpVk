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

namespace SharpVk.Arm
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct TensorCopy
    {
        /// <summary>
        /// 
        /// </summary>
        public ulong[] SourceOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong[] DestinationOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong[] Extent
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Arm.TensorCopy* pointer)
        {
            pointer->SType = StructureType.TensorCopy;
            pointer->Next = null;
            pointer->DimensionCount = (uint)(Interop.HeapUtil.GetLength(this.SourceOffset));
            if (this.SourceOffset != null)
            {
                var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(this.SourceOffset.Length).ToPointer());
                for(int index = 0; index < (uint)(this.SourceOffset.Length); index++)
                {
                    fieldPointer[index] = this.SourceOffset[index];
                }
                pointer->SourceOffset = fieldPointer;
            }
            else
            {
                pointer->SourceOffset = null;
            }
            if (this.DestinationOffset != null)
            {
                var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(this.DestinationOffset.Length).ToPointer());
                for(int index = 0; index < (uint)(this.DestinationOffset.Length); index++)
                {
                    fieldPointer[index] = this.DestinationOffset[index];
                }
                pointer->DestinationOffset = fieldPointer;
            }
            else
            {
                pointer->DestinationOffset = null;
            }
            if (this.Extent != null)
            {
                var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(this.Extent.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Extent.Length); index++)
                {
                    fieldPointer[index] = this.Extent[index];
                }
                pointer->Extent = fieldPointer;
            }
            else
            {
                pointer->Extent = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe TensorCopy MarshalFrom(SharpVk.Interop.Arm.TensorCopy* pointer)
        {
            TensorCopy result = default(TensorCopy);
            if (pointer->SourceOffset != null)
            {
                var fieldPointer = new ulong[(uint)(pointer->DimensionCount)];
                for(int index = 0; index < (uint)(pointer->DimensionCount); index++)
                {
                    fieldPointer[index] = pointer->SourceOffset[index];
                }
                result.SourceOffset = fieldPointer;
            }
            else
            {
                result.SourceOffset = null;
            }
            if (pointer->DestinationOffset != null)
            {
                var fieldPointer = new ulong[(uint)(pointer->DimensionCount)];
                for(int index = 0; index < (uint)(pointer->DimensionCount); index++)
                {
                    fieldPointer[index] = pointer->DestinationOffset[index];
                }
                result.DestinationOffset = fieldPointer;
            }
            else
            {
                result.DestinationOffset = null;
            }
            if (pointer->Extent != null)
            {
                var fieldPointer = new ulong[(uint)(pointer->DimensionCount)];
                for(int index = 0; index < (uint)(pointer->DimensionCount); index++)
                {
                    fieldPointer[index] = pointer->Extent[index];
                }
                result.Extent = fieldPointer;
            }
            else
            {
                result.Extent = null;
            }
            return result;
        }
    }
}
