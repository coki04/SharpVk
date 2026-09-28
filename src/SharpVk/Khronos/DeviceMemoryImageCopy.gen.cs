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
    public partial struct DeviceMemoryImageCopy
    {
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
        public uint AddressRowLength
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint AddressImageHeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ImageSubresourceLayers ImageSubresource
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ImageLayout ImageLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Offset3D ImageOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent3D ImageExtent
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.DeviceMemoryImageCopy* pointer)
        {
            pointer->SType = StructureType.DeviceMemoryImageCopy;
            pointer->Next = null;
            pointer->AddressRange = this.AddressRange;
            if (this.AddressFlags != null)
            {
                pointer->AddressFlags = this.AddressFlags.Value;
            }
            else
            {
                pointer->AddressFlags = default(SharpVk.Khronos.AddressCommandFlags);
            }
            pointer->AddressRowLength = this.AddressRowLength;
            pointer->AddressImageHeight = this.AddressImageHeight;
            pointer->ImageSubresource = this.ImageSubresource;
            pointer->ImageLayout = this.ImageLayout;
            pointer->ImageOffset = this.ImageOffset;
            pointer->ImageExtent = this.ImageExtent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe DeviceMemoryImageCopy MarshalFrom(SharpVk.Interop.Khronos.DeviceMemoryImageCopy* pointer)
        {
            DeviceMemoryImageCopy result = default(DeviceMemoryImageCopy);
            result.AddressRange = pointer->AddressRange;
            result.AddressFlags = pointer->AddressFlags;
            result.AddressRowLength = pointer->AddressRowLength;
            result.AddressImageHeight = pointer->AddressImageHeight;
            result.ImageSubresource = pointer->ImageSubresource;
            result.ImageLayout = pointer->ImageLayout;
            result.ImageOffset = pointer->ImageOffset;
            result.ImageExtent = pointer->ImageExtent;
            return result;
        }
    }
}
