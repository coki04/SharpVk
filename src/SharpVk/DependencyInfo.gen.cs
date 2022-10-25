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
    public partial struct DependencyInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.DependencyFlags? DependencyFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.MemoryBarrier2[] MemoryBarriers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.BufferMemoryBarrier2[] BufferMemoryBarriers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ImageMemoryBarrier2[] ImageMemoryBarriers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.DependencyInfo* pointer)
        {
            pointer->SType = StructureType.DependencyInfoVersion;
            pointer->Next = null;
            if (this.DependencyFlags != null)
            {
                pointer->DependencyFlags = this.DependencyFlags.Value;
            }
            else
            {
                pointer->DependencyFlags = default(SharpVk.DependencyFlags);
            }
            pointer->MemoryBarrierCount = (uint)(Interop.HeapUtil.GetLength(this.MemoryBarriers));
            if (this.MemoryBarriers != null)
            {
                var fieldPointer = (SharpVk.Interop.MemoryBarrier2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.MemoryBarrier2>(this.MemoryBarriers.Length).ToPointer());
                for(int index = 0; index < (uint)(this.MemoryBarriers.Length); index++)
                {
                    this.MemoryBarriers[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->MemoryBarriers = fieldPointer;
            }
            else
            {
                pointer->MemoryBarriers = null;
            }
            pointer->BufferMemoryBarrierCount = (uint)(Interop.HeapUtil.GetLength(this.BufferMemoryBarriers));
            if (this.BufferMemoryBarriers != null)
            {
                var fieldPointer = (SharpVk.Interop.BufferMemoryBarrier2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BufferMemoryBarrier2>(this.BufferMemoryBarriers.Length).ToPointer());
                for(int index = 0; index < (uint)(this.BufferMemoryBarriers.Length); index++)
                {
                    this.BufferMemoryBarriers[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->BufferMemoryBarriers = fieldPointer;
            }
            else
            {
                pointer->BufferMemoryBarriers = null;
            }
            pointer->ImageMemoryBarrierCount = (uint)(Interop.HeapUtil.GetLength(this.ImageMemoryBarriers));
            if (this.ImageMemoryBarriers != null)
            {
                var fieldPointer = (SharpVk.Interop.ImageMemoryBarrier2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.ImageMemoryBarrier2>(this.ImageMemoryBarriers.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ImageMemoryBarriers.Length); index++)
                {
                    this.ImageMemoryBarriers[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ImageMemoryBarriers = fieldPointer;
            }
            else
            {
                pointer->ImageMemoryBarriers = null;
            }
        }
    }
}
