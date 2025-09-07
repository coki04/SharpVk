// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2025
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
    public partial struct FrameBoundaryTensors
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.Tensor[] Tensors
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Arm.FrameBoundaryTensors* pointer)
        {
            pointer->SType = StructureType.FrameBoundaryTensors;
            pointer->Next = null;
            pointer->TensorCount = (uint)(Interop.HeapUtil.GetLength(this.Tensors));
            if (this.Tensors != null)
            {
                var fieldPointer = (SharpVk.Interop.Arm.Tensor*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Arm.Tensor>(this.Tensors.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Tensors.Length); index++)
                {
                    fieldPointer[index] = this.Tensors[index]?.handle ?? default(SharpVk.Interop.Arm.Tensor);
                }
                pointer->Tensors = fieldPointer;
            }
            else
            {
                pointer->Tensors = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe FrameBoundaryTensors MarshalFrom(SharpVk.Interop.Arm.FrameBoundaryTensors* pointer)
        {
            FrameBoundaryTensors result = default(FrameBoundaryTensors);
            if (pointer->Tensors != null)
            {
                var fieldPointer = new SharpVk.Arm.Tensor[(uint)(pointer->TensorCount)];
                for(int index = 0; index < (uint)(pointer->TensorCount); index++)
                {
                    fieldPointer[index] = new SharpVk.Arm.Tensor(default(SharpVk.Device), pointer->Tensors[index]);
                }
                result.Tensors = fieldPointer;
            }
            else
            {
                result.Tensors = null;
            }
            return result;
        }
    }
}
