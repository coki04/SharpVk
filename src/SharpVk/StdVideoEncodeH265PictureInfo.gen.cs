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
    public partial struct StdVideoEncodeH265PictureInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH265PictureInfoFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265PictureType PicType
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
        public byte ShortTermRefPicSetIdx
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
        public byte TemporalId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (byte, byte, byte, byte, byte, byte, byte) Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH265ReferenceListsInfo? RefLists
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265ShortTermRefPicSet? ShortTermRefPicSet
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH265LongTermRefPics? LongTermRefPics
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoEncodeH265PictureInfo* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->PicType = this.PicType;
            pointer->SpsVideoParameterSetId = this.SpsVideoParameterSetId;
            pointer->PpsSeqParameterSetId = this.PpsSeqParameterSetId;
            pointer->PpsPicParameterSetId = this.PpsPicParameterSetId;
            pointer->ShortTermRefPicSetIdx = this.ShortTermRefPicSetIdx;
            pointer->PicOrderCntVal = this.PicOrderCntVal;
            pointer->TemporalId = this.TemporalId;
            pointer->Reserved1[0] = this.Reserved1.Item1;
            pointer->Reserved1[1] = this.Reserved1.Item2;
            pointer->Reserved1[2] = this.Reserved1.Item3;
            pointer->Reserved1[3] = this.Reserved1.Item4;
            pointer->Reserved1[4] = this.Reserved1.Item5;
            pointer->Reserved1[5] = this.Reserved1.Item6;
            pointer->Reserved1[6] = this.Reserved1.Item7;
            if (this.RefLists != null)
            {
                pointer->RefLists = (SharpVk.Interop.StdVideoEncodeH265ReferenceListsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoEncodeH265ReferenceListsInfo>());
                this.RefLists.Value.MarshalTo(pointer->RefLists);
            }
            else
            {
                pointer->RefLists = default(SharpVk.Interop.StdVideoEncodeH265ReferenceListsInfo*);
            }
            if (this.ShortTermRefPicSet != null)
            {
                pointer->ShortTermRefPicSet = (SharpVk.Interop.StdVideoH265ShortTermRefPicSet*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH265ShortTermRefPicSet>());
                this.ShortTermRefPicSet.Value.MarshalTo(pointer->ShortTermRefPicSet);
            }
            else
            {
                pointer->ShortTermRefPicSet = default(SharpVk.Interop.StdVideoH265ShortTermRefPicSet*);
            }
            if (this.LongTermRefPics != null)
            {
                pointer->LongTermRefPics = (SharpVk.Interop.StdVideoEncodeH265LongTermRefPics*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoEncodeH265LongTermRefPics>());
                this.LongTermRefPics.Value.MarshalTo(pointer->LongTermRefPics);
            }
            else
            {
                pointer->LongTermRefPics = default(SharpVk.Interop.StdVideoEncodeH265LongTermRefPics*);
            }
        }
    }
}
