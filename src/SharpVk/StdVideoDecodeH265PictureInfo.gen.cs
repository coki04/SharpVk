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
    public partial struct StdVideoDecodeH265PictureInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoDecodeH265PictureInfoFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte SpsVideoParameterSetId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte PpsSeqParameterSetId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte PpsPicParameterSetId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumDeltaPocsOfRefRpsIdx
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int PicOrderCntVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort NumBitsForSTRefPicSetInSlice
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort Reserved
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] RefPicSetStCurrBefore
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] RefPicSetStCurrAfter
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] RefPicSetLtCurr
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoDecodeH265PictureInfo* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->SpsVideoParameterSetId = this.SpsVideoParameterSetId;
            pointer->PpsSeqParameterSetId = this.PpsSeqParameterSetId;
            pointer->PpsPicParameterSetId = this.PpsPicParameterSetId;
            pointer->NumDeltaPocsOfRefRpsIdx = this.NumDeltaPocsOfRefRpsIdx;
            pointer->PicOrderCntVal = this.PicOrderCntVal;
            pointer->NumBitsForSTRefPicSetInSlice = this.NumBitsForSTRefPicSetInSlice;
            pointer->Reserved = this.Reserved;
            Interop.HeapUtil.MarshalTo(this.RefPicSetStCurrBefore, checked((int)Constants.StdVideoDecodeH265RefPicSetListSize), pointer->RefPicSetStCurrBefore);
            Interop.HeapUtil.MarshalTo(this.RefPicSetStCurrAfter, checked((int)Constants.StdVideoDecodeH265RefPicSetListSize), pointer->RefPicSetStCurrAfter);
            Interop.HeapUtil.MarshalTo(this.RefPicSetLtCurr, checked((int)Constants.StdVideoDecodeH265RefPicSetListSize), pointer->RefPicSetLtCurr);
        }
    }
}
