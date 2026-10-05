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
    public partial struct StdVideoH264SequenceParameterSet
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264SpsFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264ProfileIdc ProfileIdc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264LevelIdc LevelIdc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264ChromaFormatIdc ChromaFormatIdc
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
        public byte BitDepthLumaMinus8
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte BitDepthChromaMinus8
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MaxFrameNumMinus4
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264PocType PicOrderCntType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int OffsetForNonRefPic
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int OffsetForTopToBottomField
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MaxPicOrderCntLsbMinus4
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxNumRefFrames
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PicWidthInMbsMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PicHeightInMapUnitsMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint FrameCropLeftOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint FrameCropRightOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint FrameCropTopOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint FrameCropBottomOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Reserved2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int[] OffsetForRefFrame
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
        public SharpVk.StdVideoH264SequenceParameterSetVui? SequenceParameterSetVui
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoH264SequenceParameterSet* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->ProfileIdc = this.ProfileIdc;
            pointer->LevelIdc = this.LevelIdc;
            pointer->ChromaFormatIdc = this.ChromaFormatIdc;
            pointer->SeqParameterSetId = this.SeqParameterSetId;
            pointer->BitDepthLumaMinus8 = this.BitDepthLumaMinus8;
            pointer->BitDepthChromaMinus8 = this.BitDepthChromaMinus8;
            pointer->Log2MaxFrameNumMinus4 = this.Log2MaxFrameNumMinus4;
            pointer->PicOrderCntType = this.PicOrderCntType;
            pointer->OffsetForNonRefPic = this.OffsetForNonRefPic;
            pointer->OffsetForTopToBottomField = this.OffsetForTopToBottomField;
            pointer->Log2MaxPicOrderCntLsbMinus4 = this.Log2MaxPicOrderCntLsbMinus4;
            pointer->NumRefFramesInPicOrderCntCycle = (byte)(Interop.HeapUtil.GetLength(this.OffsetForRefFrame));
            pointer->MaxNumRefFrames = this.MaxNumRefFrames;
            pointer->Reserved1 = this.Reserved1;
            pointer->PicWidthInMbsMinus1 = this.PicWidthInMbsMinus1;
            pointer->PicHeightInMapUnitsMinus1 = this.PicHeightInMapUnitsMinus1;
            pointer->FrameCropLeftOffset = this.FrameCropLeftOffset;
            pointer->FrameCropRightOffset = this.FrameCropRightOffset;
            pointer->FrameCropTopOffset = this.FrameCropTopOffset;
            pointer->FrameCropBottomOffset = this.FrameCropBottomOffset;
            pointer->Reserved2 = this.Reserved2;
            if (this.OffsetForRefFrame != null)
            {
                var fieldPointer = (int*)(Interop.HeapUtil.AllocateAndClear<int>(this.OffsetForRefFrame.Length).ToPointer());
                for(int index = 0; index < (uint)(this.OffsetForRefFrame.Length); index++)
                {
                    fieldPointer[index] = this.OffsetForRefFrame[index];
                }
                pointer->OffsetForRefFrame = fieldPointer;
            }
            else
            {
                pointer->OffsetForRefFrame = null;
            }
            if (this.ScalingLists != null)
            {
                pointer->ScalingLists = (SharpVk.Interop.StdVideoH264ScalingLists*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH264ScalingLists>());
                this.ScalingLists.Value.MarshalTo(pointer->ScalingLists);
            }
            else
            {
                pointer->ScalingLists = default(SharpVk.Interop.StdVideoH264ScalingLists*);
            }
            if (this.SequenceParameterSetVui != null)
            {
                pointer->SequenceParameterSetVui = (SharpVk.Interop.StdVideoH264SequenceParameterSetVui*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH264SequenceParameterSetVui>());
                this.SequenceParameterSetVui.Value.MarshalTo(pointer->SequenceParameterSetVui);
            }
            else
            {
                pointer->SequenceParameterSetVui = default(SharpVk.Interop.StdVideoH264SequenceParameterSetVui*);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoH264SequenceParameterSet MarshalFrom(SharpVk.Interop.StdVideoH264SequenceParameterSet* pointer)
        {
            StdVideoH264SequenceParameterSet result = default(StdVideoH264SequenceParameterSet);
            result.Flags = pointer->Flags;
            result.ProfileIdc = pointer->ProfileIdc;
            result.LevelIdc = pointer->LevelIdc;
            result.ChromaFormatIdc = pointer->ChromaFormatIdc;
            result.SeqParameterSetId = pointer->SeqParameterSetId;
            result.BitDepthLumaMinus8 = pointer->BitDepthLumaMinus8;
            result.BitDepthChromaMinus8 = pointer->BitDepthChromaMinus8;
            result.Log2MaxFrameNumMinus4 = pointer->Log2MaxFrameNumMinus4;
            result.PicOrderCntType = pointer->PicOrderCntType;
            result.OffsetForNonRefPic = pointer->OffsetForNonRefPic;
            result.OffsetForTopToBottomField = pointer->OffsetForTopToBottomField;
            result.Log2MaxPicOrderCntLsbMinus4 = pointer->Log2MaxPicOrderCntLsbMinus4;
            result.MaxNumRefFrames = pointer->MaxNumRefFrames;
            result.Reserved1 = pointer->Reserved1;
            result.PicWidthInMbsMinus1 = pointer->PicWidthInMbsMinus1;
            result.PicHeightInMapUnitsMinus1 = pointer->PicHeightInMapUnitsMinus1;
            result.FrameCropLeftOffset = pointer->FrameCropLeftOffset;
            result.FrameCropRightOffset = pointer->FrameCropRightOffset;
            result.FrameCropTopOffset = pointer->FrameCropTopOffset;
            result.FrameCropBottomOffset = pointer->FrameCropBottomOffset;
            result.Reserved2 = pointer->Reserved2;
            if (pointer->OffsetForRefFrame != null)
            {
                var fieldPointer = new int[(uint)(pointer->NumRefFramesInPicOrderCntCycle)];
                for(int index = 0; index < (uint)(pointer->NumRefFramesInPicOrderCntCycle); index++)
                {
                    fieldPointer[index] = pointer->OffsetForRefFrame[index];
                }
                result.OffsetForRefFrame = fieldPointer;
            }
            else
            {
                result.OffsetForRefFrame = null;
            }
            if (pointer->ScalingLists != null)
            {
                result.ScalingLists = SharpVk.StdVideoH264ScalingLists.MarshalFrom(pointer->ScalingLists);
            }
            else
            {
                result.ScalingLists = null;
            }
            if (pointer->SequenceParameterSetVui != null)
            {
                result.SequenceParameterSetVui = SharpVk.StdVideoH264SequenceParameterSetVui.MarshalFrom(pointer->SequenceParameterSetVui);
            }
            else
            {
                result.SequenceParameterSetVui = null;
            }
            return result;
        }
    }
}
