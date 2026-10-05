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
    public partial struct StdVideoH264PictureParameterSet
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264PpsFlags Flags
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
        public byte NumRefIdxL0DefaultActiveMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumRefIdxL1DefaultActiveMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264WeightedBipredIdc WeightedBipredIdc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PicInitQpMinus26
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PicInitQsMinus26
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte ChromaQpIndexOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte SecondChromaQpIndexOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264ScalingLists? ScalingLists
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoH264PictureParameterSet* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->SeqParameterSetId = this.SeqParameterSetId;
            pointer->PicParameterSetId = this.PicParameterSetId;
            pointer->NumRefIdxL0DefaultActiveMinus1 = this.NumRefIdxL0DefaultActiveMinus1;
            pointer->NumRefIdxL1DefaultActiveMinus1 = this.NumRefIdxL1DefaultActiveMinus1;
            pointer->WeightedBipredIdc = this.WeightedBipredIdc;
            pointer->PicInitQpMinus26 = this.PicInitQpMinus26;
            pointer->PicInitQsMinus26 = this.PicInitQsMinus26;
            pointer->ChromaQpIndexOffset = this.ChromaQpIndexOffset;
            pointer->SecondChromaQpIndexOffset = this.SecondChromaQpIndexOffset;
            if (this.ScalingLists != null)
            {
                pointer->ScalingLists = (SharpVk.Interop.StdVideoH264ScalingLists*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH264ScalingLists>());
                this.ScalingLists.Value.MarshalTo(pointer->ScalingLists);
            }
            else
            {
                pointer->ScalingLists = default(SharpVk.Interop.StdVideoH264ScalingLists*);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoH264PictureParameterSet MarshalFrom(SharpVk.Interop.StdVideoH264PictureParameterSet* pointer)
        {
            StdVideoH264PictureParameterSet result = default(StdVideoH264PictureParameterSet);
            result.Flags = pointer->Flags;
            result.SeqParameterSetId = pointer->SeqParameterSetId;
            result.PicParameterSetId = pointer->PicParameterSetId;
            result.NumRefIdxL0DefaultActiveMinus1 = pointer->NumRefIdxL0DefaultActiveMinus1;
            result.NumRefIdxL1DefaultActiveMinus1 = pointer->NumRefIdxL1DefaultActiveMinus1;
            result.WeightedBipredIdc = pointer->WeightedBipredIdc;
            result.PicInitQpMinus26 = pointer->PicInitQpMinus26;
            result.PicInitQsMinus26 = pointer->PicInitQsMinus26;
            result.ChromaQpIndexOffset = pointer->ChromaQpIndexOffset;
            result.SecondChromaQpIndexOffset = pointer->SecondChromaQpIndexOffset;
            if (pointer->ScalingLists != null)
            {
                result.ScalingLists = SharpVk.StdVideoH264ScalingLists.MarshalFrom(pointer->ScalingLists);
            }
            else
            {
                result.ScalingLists = null;
            }
            return result;
        }
    }
}
