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
    public partial struct VideoEncodeH265PictureInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeH265NaluSliceSegmentInfo[] NaluSliceSegmentEntries
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr StdPictureInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.VideoEncodeH265PictureInfo* pointer)
        {
            pointer->SType = StructureType.VideoEncodeH265PictureInfo;
            pointer->Next = null;
            pointer->NaluSliceSegmentEntryCount = (uint)(Interop.HeapUtil.GetLength(this.NaluSliceSegmentEntries));
            if (this.NaluSliceSegmentEntries != null)
            {
                var fieldPointer = (SharpVk.Interop.Khronos.VideoEncodeH265NaluSliceSegmentInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.VideoEncodeH265NaluSliceSegmentInfo>(this.NaluSliceSegmentEntries.Length).ToPointer());
                for(int index = 0; index < (uint)(this.NaluSliceSegmentEntries.Length); index++)
                {
                    this.NaluSliceSegmentEntries[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->NaluSliceSegmentEntries = fieldPointer;
            }
            else
            {
                pointer->NaluSliceSegmentEntries = null;
            }
            pointer->StdPictureInfo = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
            *pointer->StdPictureInfo = this.StdPictureInfo;
        }
    }
}
