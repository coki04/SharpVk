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
    public partial struct MemoryRangeBarrier
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineStageFlags2? SourceStageMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AccessFlags2? SourceAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineStageFlags2? DestinationStageMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AccessFlags2? DestinationAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SourceQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint DestinationQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DeviceAddressRange AddressRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AddressCommandFlags? AddressFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.MemoryRangeBarrier* pointer)
        {
            pointer->SType = StructureType.MemoryRangeBarrier;
            pointer->Next = null;
            if (this.SourceStageMask != null)
            {
                pointer->SourceStageMask = this.SourceStageMask.Value;
            }
            else
            {
                pointer->SourceStageMask = default(SharpVk.PipelineStageFlags2);
            }
            if (this.SourceAccessMask != null)
            {
                pointer->SourceAccessMask = this.SourceAccessMask.Value;
            }
            else
            {
                pointer->SourceAccessMask = default(SharpVk.AccessFlags2);
            }
            if (this.DestinationStageMask != null)
            {
                pointer->DestinationStageMask = this.DestinationStageMask.Value;
            }
            else
            {
                pointer->DestinationStageMask = default(SharpVk.PipelineStageFlags2);
            }
            if (this.DestinationAccessMask != null)
            {
                pointer->DestinationAccessMask = this.DestinationAccessMask.Value;
            }
            else
            {
                pointer->DestinationAccessMask = default(SharpVk.AccessFlags2);
            }
            pointer->SourceQueueFamilyIndex = this.SourceQueueFamilyIndex;
            pointer->DestinationQueueFamilyIndex = this.DestinationQueueFamilyIndex;
            pointer->AddressRange = this.AddressRange;
            if (this.AddressFlags != null)
            {
                pointer->AddressFlags = this.AddressFlags.Value;
            }
            else
            {
                pointer->AddressFlags = default(SharpVk.Khronos.AddressCommandFlags);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe MemoryRangeBarrier MarshalFrom(SharpVk.Interop.Khronos.MemoryRangeBarrier* pointer)
        {
            MemoryRangeBarrier result = default(MemoryRangeBarrier);
            result.SourceStageMask = pointer->SourceStageMask;
            result.SourceAccessMask = pointer->SourceAccessMask;
            result.DestinationStageMask = pointer->DestinationStageMask;
            result.DestinationAccessMask = pointer->DestinationAccessMask;
            result.SourceQueueFamilyIndex = pointer->SourceQueueFamilyIndex;
            result.DestinationQueueFamilyIndex = pointer->DestinationQueueFamilyIndex;
            result.AddressRange = pointer->AddressRange;
            result.AddressFlags = pointer->AddressFlags;
            return result;
        }
    }
}
