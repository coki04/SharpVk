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
    public partial struct VideoDecodeH264PictureInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoDecodeH264PictureInfo StdPictureInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] SliceOffsets
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.VideoDecodeH264PictureInfo* pointer)
        {
            pointer->SType = StructureType.VideoDecodeH264PictureInfo;
            pointer->Next = null;
            pointer->StdPictureInfo = (SharpVk.Interop.StdVideoDecodeH264PictureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoDecodeH264PictureInfo>());
            this.StdPictureInfo.MarshalTo(pointer->StdPictureInfo);
            pointer->SliceCount = (uint)(Interop.HeapUtil.GetLength(this.SliceOffsets));
            if (this.SliceOffsets != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.SliceOffsets.Length).ToPointer());
                for(int index = 0; index < (uint)(this.SliceOffsets.Length); index++)
                {
                    fieldPointer[index] = this.SliceOffsets[index];
                }
                pointer->SliceOffsets = fieldPointer;
            }
            else
            {
                pointer->SliceOffsets = null;
            }
        }
    }
}
