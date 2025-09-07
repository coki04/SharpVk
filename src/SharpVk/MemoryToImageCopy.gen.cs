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
    public partial struct MemoryToImageCopy
    {
        /// <summary>
        /// 
        /// </summary>
        public IntPtr HostPointer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MemoryRowLength
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MemoryImageHeight
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
        internal unsafe void MarshalTo(SharpVk.Interop.MemoryToImageCopy* pointer)
        {
            pointer->SType = StructureType.MemoryToImageCopyVersion;
            pointer->Next = null;
            pointer->HostPointer = this.HostPointer.ToPointer();
            pointer->MemoryRowLength = this.MemoryRowLength;
            pointer->MemoryImageHeight = this.MemoryImageHeight;
            pointer->ImageSubresource = this.ImageSubresource;
            pointer->ImageOffset = this.ImageOffset;
            pointer->ImageExtent = this.ImageExtent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe MemoryToImageCopy MarshalFrom(SharpVk.Interop.MemoryToImageCopy* pointer)
        {
            MemoryToImageCopy result = default(MemoryToImageCopy);
            result.HostPointer = new IntPtr(pointer->HostPointer);
            result.MemoryRowLength = pointer->MemoryRowLength;
            result.MemoryImageHeight = pointer->MemoryImageHeight;
            result.ImageSubresource = pointer->ImageSubresource;
            result.ImageOffset = pointer->ImageOffset;
            result.ImageExtent = pointer->ImageExtent;
            return result;
        }
    }
}
