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
    public partial struct StdVideoEncodeH264PictureInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264PictureInfoFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte SeqParameterSetId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte PicParameterSetId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort IdrPicId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264PictureType PrimaryPicType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint FrameNum
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int PicOrderCnt
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte TemporalId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (byte, byte, byte) Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264ReferenceListsInfo? RefLists
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoEncodeH264PictureInfo* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->SeqParameterSetId = this.SeqParameterSetId;
            pointer->PicParameterSetId = this.PicParameterSetId;
            pointer->IdrPicId = this.IdrPicId;
            pointer->PrimaryPicType = this.PrimaryPicType;
            pointer->FrameNum = this.FrameNum;
            pointer->PicOrderCnt = this.PicOrderCnt;
            pointer->TemporalId = this.TemporalId;
            pointer->Reserved1[0] = this.Reserved1.Item1;
            pointer->Reserved1[1] = this.Reserved1.Item2;
            pointer->Reserved1[2] = this.Reserved1.Item3;
            if (this.RefLists != null)
            {
                pointer->RefLists = (SharpVk.Interop.StdVideoEncodeH264ReferenceListsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoEncodeH264ReferenceListsInfo>());
                this.RefLists.Value.MarshalTo(pointer->RefLists);
            }
            else
            {
                pointer->RefLists = default(SharpVk.Interop.StdVideoEncodeH264ReferenceListsInfo*);
            }
        }
    }
}
