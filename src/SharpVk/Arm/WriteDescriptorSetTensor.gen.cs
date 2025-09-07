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
    public partial struct WriteDescriptorSetTensor
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.TensorView[] TensorViews
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Arm.WriteDescriptorSetTensor* pointer)
        {
            pointer->SType = StructureType.WriteDescriptorSetTensor;
            pointer->Next = null;
            pointer->TensorViewCount = (uint)(Interop.HeapUtil.GetLength(this.TensorViews));
            if (this.TensorViews != null)
            {
                var fieldPointer = (SharpVk.Interop.Arm.TensorView*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Arm.TensorView>(this.TensorViews.Length).ToPointer());
                for(int index = 0; index < (uint)(this.TensorViews.Length); index++)
                {
                    fieldPointer[index] = this.TensorViews[index]?.handle ?? default(SharpVk.Interop.Arm.TensorView);
                }
                pointer->TensorViews = fieldPointer;
            }
            else
            {
                pointer->TensorViews = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe WriteDescriptorSetTensor MarshalFrom(SharpVk.Interop.Arm.WriteDescriptorSetTensor* pointer)
        {
            WriteDescriptorSetTensor result = default(WriteDescriptorSetTensor);
            if (pointer->TensorViews != null)
            {
                var fieldPointer = new SharpVk.Arm.TensorView[(uint)(pointer->TensorViewCount)];
                for(int index = 0; index < (uint)(pointer->TensorViewCount); index++)
                {
                    fieldPointer[index] = new SharpVk.Arm.TensorView(default(SharpVk.Device), pointer->TensorViews[index]);
                }
                result.TensorViews = fieldPointer;
            }
            else
            {
                result.TensorViews = null;
            }
            return result;
        }
    }
}
