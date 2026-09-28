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
    public partial struct TensorDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.TensorTiling Tiling
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public long[] Dimensions
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public long[] Strides
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.TensorUsageFlags Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Arm.TensorDescription* pointer)
        {
            pointer->SType = StructureType.TensorDescription;
            pointer->Next = null;
            pointer->Tiling = this.Tiling;
            pointer->Format = this.Format;
            pointer->DimensionCount = (uint)(Interop.HeapUtil.GetLength(this.Dimensions));
            if (this.Dimensions != null)
            {
                var fieldPointer = (long*)(Interop.HeapUtil.AllocateAndClear<long>(this.Dimensions.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Dimensions.Length); index++)
                {
                    fieldPointer[index] = this.Dimensions[index];
                }
                pointer->Dimensions = fieldPointer;
            }
            else
            {
                pointer->Dimensions = null;
            }
            if (this.Strides != null)
            {
                var fieldPointer = (long*)(Interop.HeapUtil.AllocateAndClear<long>(this.Strides.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Strides.Length); index++)
                {
                    fieldPointer[index] = this.Strides[index];
                }
                pointer->Strides = fieldPointer;
            }
            else
            {
                pointer->Strides = null;
            }
            pointer->Usage = this.Usage;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe TensorDescription MarshalFrom(SharpVk.Interop.Arm.TensorDescription* pointer)
        {
            TensorDescription result = default(TensorDescription);
            result.Tiling = pointer->Tiling;
            result.Format = pointer->Format;
            if (pointer->Dimensions != null)
            {
                var fieldPointer = new long[(uint)(pointer->DimensionCount)];
                for(int index = 0; index < (uint)(pointer->DimensionCount); index++)
                {
                    fieldPointer[index] = pointer->Dimensions[index];
                }
                result.Dimensions = fieldPointer;
            }
            else
            {
                result.Dimensions = null;
            }
            if (pointer->Strides != null)
            {
                var fieldPointer = new long[(uint)(pointer->DimensionCount)];
                for(int index = 0; index < (uint)(pointer->DimensionCount); index++)
                {
                    fieldPointer[index] = pointer->Strides[index];
                }
                result.Strides = fieldPointer;
            }
            else
            {
                result.Strides = null;
            }
            result.Usage = pointer->Usage;
            return result;
        }
    }
}
