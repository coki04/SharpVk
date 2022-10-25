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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VideoEncodeH264VclFrameInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.VideoEncodeH264ReferenceListsInfo? ReferenceFinalLists
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.VideoEncodeH264NaluSliceInfo[] NaluSliceEntries
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr CurrentPictureInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.VideoEncodeH264VclFrameInfo* pointer)
        {
            pointer->SType = StructureType.VideoEncodeH264VclFrameInfo;
            pointer->Next = null;
            if (this.ReferenceFinalLists != null)
            {
                pointer->ReferenceFinalLists = (SharpVk.Interop.Multivendor.VideoEncodeH264ReferenceListsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.VideoEncodeH264ReferenceListsInfo>());
                this.ReferenceFinalLists.Value.MarshalTo(pointer->ReferenceFinalLists);
            }
            else
            {
                pointer->ReferenceFinalLists = default(SharpVk.Interop.Multivendor.VideoEncodeH264ReferenceListsInfo*);
            }
            pointer->NaluSliceEntryCount = (uint)(Interop.HeapUtil.GetLength(this.NaluSliceEntries));
            if (this.NaluSliceEntries != null)
            {
                var fieldPointer = (SharpVk.Interop.Multivendor.VideoEncodeH264NaluSliceInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.VideoEncodeH264NaluSliceInfo>(this.NaluSliceEntries.Length).ToPointer());
                for(int index = 0; index < (uint)(this.NaluSliceEntries.Length); index++)
                {
                    this.NaluSliceEntries[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->NaluSliceEntries = fieldPointer;
            }
            else
            {
                pointer->NaluSliceEntries = null;
            }
            pointer->CurrentPictureInfo = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
            *pointer->CurrentPictureInfo = this.CurrentPictureInfo;
        }
    }
}
