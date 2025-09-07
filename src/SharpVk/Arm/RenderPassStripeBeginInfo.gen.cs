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
    public partial struct RenderPassStripeBeginInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.RenderPassStripeInfo[] StripeInfos
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Arm.RenderPassStripeBeginInfo* pointer)
        {
            pointer->SType = StructureType.RenderPassStripeBeginInfo;
            pointer->Next = null;
            pointer->StripeInfoCount = (uint)(Interop.HeapUtil.GetLength(this.StripeInfos));
            if (this.StripeInfos != null)
            {
                var fieldPointer = (SharpVk.Interop.Arm.RenderPassStripeInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Arm.RenderPassStripeInfo>(this.StripeInfos.Length).ToPointer());
                for(int index = 0; index < (uint)(this.StripeInfos.Length); index++)
                {
                    this.StripeInfos[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->StripeInfos = fieldPointer;
            }
            else
            {
                pointer->StripeInfos = null;
            }
        }
    }
}
