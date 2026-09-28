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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct BufferImageCopy2
    {
        /// <summary>
        /// 
        /// </summary>
        public ulong BufferOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint BufferRowLength
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint BufferImageHeight
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
        internal unsafe void MarshalTo(SharpVk.Interop.BufferImageCopy2* pointer)
        {
            pointer->SType = StructureType.BufferImageCopy2Base;
            pointer->Next = null;
            pointer->BufferOffset = this.BufferOffset;
            pointer->BufferRowLength = this.BufferRowLength;
            pointer->BufferImageHeight = this.BufferImageHeight;
            pointer->ImageSubresource = this.ImageSubresource;
            pointer->ImageOffset = this.ImageOffset;
            pointer->ImageExtent = this.ImageExtent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe BufferImageCopy2 MarshalFrom(SharpVk.Interop.BufferImageCopy2* pointer)
        {
            BufferImageCopy2 result = default(BufferImageCopy2);
            result.BufferOffset = pointer->BufferOffset;
            result.BufferRowLength = pointer->BufferRowLength;
            result.BufferImageHeight = pointer->BufferImageHeight;
            result.ImageSubresource = pointer->ImageSubresource;
            result.ImageOffset = pointer->ImageOffset;
            result.ImageExtent = pointer->ImageExtent;
            return result;
        }
    }
}
