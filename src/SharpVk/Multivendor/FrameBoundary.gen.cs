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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct FrameBoundary
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.FrameBoundaryFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong FrameID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Image[] Images
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Buffer[] Buffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong? TagName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] Tag
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.FrameBoundary* pointer)
        {
            pointer->SType = StructureType.FrameBoundary;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Multivendor.FrameBoundaryFlags);
            }
            pointer->FrameID = this.FrameID;
            pointer->ImageCount = (uint)(Interop.HeapUtil.GetLength(this.Images));
            if (this.Images != null)
            {
                var fieldPointer = (SharpVk.Interop.Image*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Image>(this.Images.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Images.Length); index++)
                {
                    fieldPointer[index] = this.Images[index]?.handle ?? default(SharpVk.Interop.Image);
                }
                pointer->Images = fieldPointer;
            }
            else
            {
                pointer->Images = null;
            }
            pointer->BufferCount = (uint)(Interop.HeapUtil.GetLength(this.Buffers));
            if (this.Buffers != null)
            {
                var fieldPointer = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Buffer>(this.Buffers.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Buffers.Length); index++)
                {
                    fieldPointer[index] = this.Buffers[index]?.handle ?? default(SharpVk.Interop.Buffer);
                }
                pointer->Buffers = fieldPointer;
            }
            else
            {
                pointer->Buffers = null;
            }
            if (this.TagName != null)
            {
                pointer->TagName = this.TagName.Value;
            }
            else
            {
                pointer->TagName = default(ulong);
            }
            pointer->TagSize = (HostSize)(Interop.HeapUtil.GetLength(this.Tag));
            if (this.Tag != null)
            {
                var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(this.Tag.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Tag.Length); index++)
                {
                    fieldPointer[index] = this.Tag[index];
                }
                pointer->Tag = fieldPointer;
            }
            else
            {
                pointer->Tag = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe FrameBoundary MarshalFrom(SharpVk.Interop.Multivendor.FrameBoundary* pointer)
        {
            FrameBoundary result = default(FrameBoundary);
            result.Flags = pointer->Flags;
            result.FrameID = pointer->FrameID;
            if (pointer->Images != null)
            {
                var fieldPointer = new SharpVk.Image[(uint)(pointer->ImageCount)];
                for(int index = 0; index < (uint)(pointer->ImageCount); index++)
                {
                    fieldPointer[index] = new SharpVk.Image(default(SharpVk.Device), pointer->Images[index]);
                }
                result.Images = fieldPointer;
            }
            else
            {
                result.Images = null;
            }
            if (pointer->Buffers != null)
            {
                var fieldPointer = new SharpVk.Buffer[(uint)(pointer->BufferCount)];
                for(int index = 0; index < (uint)(pointer->BufferCount); index++)
                {
                    fieldPointer[index] = new SharpVk.Buffer(default(SharpVk.Device), pointer->Buffers[index]);
                }
                result.Buffers = fieldPointer;
            }
            else
            {
                result.Buffers = null;
            }
            result.TagName = pointer->TagName;
            if (pointer->Tag != null)
            {
                var fieldPointer = new byte[(uint)(pointer->TagSize)];
                for(int index = 0; index < (uint)(pointer->TagSize); index++)
                {
                    fieldPointer[index] = pointer->Tag[index];
                }
                result.Tag = fieldPointer;
            }
            else
            {
                result.Tag = null;
            }
            return result;
        }
    }
}
