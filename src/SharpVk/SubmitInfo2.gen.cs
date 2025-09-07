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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SubmitInfo2
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SubmitFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SemaphoreSubmitInfo[] WaitSemaphoreInfos
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.CommandBufferSubmitInfo[] CommandBufferInfos
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SemaphoreSubmitInfo[] SignalSemaphoreInfos
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.SubmitInfo2* pointer)
        {
            pointer->SType = StructureType.SubmitInfo2Version;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.SubmitFlags);
            }
            pointer->WaitSemaphoreInfoCount = (uint)(Interop.HeapUtil.GetLength(this.WaitSemaphoreInfos));
            if (this.WaitSemaphoreInfos != null)
            {
                var fieldPointer = (SharpVk.Interop.SemaphoreSubmitInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SemaphoreSubmitInfo>(this.WaitSemaphoreInfos.Length).ToPointer());
                for(int index = 0; index < (uint)(this.WaitSemaphoreInfos.Length); index++)
                {
                    this.WaitSemaphoreInfos[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->WaitSemaphoreInfos = fieldPointer;
            }
            else
            {
                pointer->WaitSemaphoreInfos = null;
            }
            pointer->CommandBufferInfoCount = (uint)(Interop.HeapUtil.GetLength(this.CommandBufferInfos));
            if (this.CommandBufferInfos != null)
            {
                var fieldPointer = (SharpVk.Interop.CommandBufferSubmitInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.CommandBufferSubmitInfo>(this.CommandBufferInfos.Length).ToPointer());
                for(int index = 0; index < (uint)(this.CommandBufferInfos.Length); index++)
                {
                    this.CommandBufferInfos[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->CommandBufferInfos = fieldPointer;
            }
            else
            {
                pointer->CommandBufferInfos = null;
            }
            pointer->SignalSemaphoreInfoCount = (uint)(Interop.HeapUtil.GetLength(this.SignalSemaphoreInfos));
            if (this.SignalSemaphoreInfos != null)
            {
                var fieldPointer = (SharpVk.Interop.SemaphoreSubmitInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SemaphoreSubmitInfo>(this.SignalSemaphoreInfos.Length).ToPointer());
                for(int index = 0; index < (uint)(this.SignalSemaphoreInfos.Length); index++)
                {
                    this.SignalSemaphoreInfos[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->SignalSemaphoreInfos = fieldPointer;
            }
            else
            {
                pointer->SignalSemaphoreInfos = null;
            }
        }
    }
}
