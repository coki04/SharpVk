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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VideoEncodeInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeFlags? Flags
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
        public ulong DestinationBufferOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong DestinationBufferRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoPictureResourceInfo SourcePictureResource
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoReferenceSlotInfo? SetupReferenceSlot
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoReferenceSlotInfo[] ReferenceSlots
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PrecedingExternallyEncodedBytes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.VideoEncodeInfo* pointer)
        {
            pointer->SType = StructureType.VideoEncodeInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Khronos.VideoEncodeFlags);
            }
            pointer->DestinationBuffer = this.DestinationBuffer?.handle ?? default(SharpVk.Interop.Buffer);
            pointer->DestinationBufferOffset = this.DestinationBufferOffset;
            pointer->DestinationBufferRange = this.DestinationBufferRange;
            this.SourcePictureResource.MarshalTo(&pointer->SourcePictureResource);
            if (this.SetupReferenceSlot != null)
            {
                pointer->SetupReferenceSlot = (SharpVk.Interop.Khronos.VideoReferenceSlotInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoReferenceSlotInfo>());
                this.SetupReferenceSlot.Value.MarshalTo(pointer->SetupReferenceSlot);
            }
            else
            {
                pointer->SetupReferenceSlot = default(SharpVk.Interop.Khronos.VideoReferenceSlotInfo*);
            }
            pointer->ReferenceSlotCount = (uint)(Interop.HeapUtil.GetLength(this.ReferenceSlots));
            if (this.ReferenceSlots != null)
            {
                var fieldPointer = (SharpVk.Interop.Khronos.VideoReferenceSlotInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.VideoReferenceSlotInfo>(this.ReferenceSlots.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ReferenceSlots.Length); index++)
                {
                    this.ReferenceSlots[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ReferenceSlots = fieldPointer;
            }
            else
            {
                pointer->ReferenceSlots = null;
            }
            pointer->PrecedingExternallyEncodedBytes = this.PrecedingExternallyEncodedBytes;
        }
    }
}
