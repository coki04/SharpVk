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
    public partial struct VideoDecodeVP9PictureInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoDecodeVP9PictureInfo StdPictureInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int[] ReferenceNameSlotIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint UncompressedHeaderOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint CompressedHeaderOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint TilesOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.VideoDecodeVP9PictureInfo* pointer)
        {
            pointer->SType = StructureType.VideoDecodeVp9PictureInfo;
            pointer->Next = null;
            pointer->StdPictureInfo = (SharpVk.Interop.StdVideoDecodeVP9PictureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoDecodeVP9PictureInfo>());
            this.StdPictureInfo.MarshalTo(pointer->StdPictureInfo);
            Interop.HeapUtil.MarshalTo(this.ReferenceNameSlotIndices, checked((int)Constants.MaxVideoVp9ReferencesPerFrame), pointer->ReferenceNameSlotIndices);
            pointer->UncompressedHeaderOffset = this.UncompressedHeaderOffset;
            pointer->CompressedHeaderOffset = this.CompressedHeaderOffset;
            pointer->TilesOffset = this.TilesOffset;
        }
    }
}
