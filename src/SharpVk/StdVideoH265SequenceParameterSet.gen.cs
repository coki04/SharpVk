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
    public partial struct StdVideoH265SequenceParameterSet
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265SpsFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265ChromaFormatIdc ChromaFormatIdc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PicWidthInLumaSamples
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PicHeightInLumaSamples
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
        public byte SpsMaxSubLayersMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte SpsSeqParameterSetId
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
        public byte Log2MaxPicOrderCntLsbMinus4
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MinLumaCodingBlockSizeMinus3
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2DiffMaxMinLumaCodingBlockSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MinLumaTransformBlockSizeMinus2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2DiffMaxMinLumaTransformBlockSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxTransformHierarchyDepthInter
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxTransformHierarchyDepthIntra
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumLongTermRefPicsSps
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte PcmSampleBitDepthLumaMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte PcmSampleBitDepthChromaMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MinPcmLumaCodingBlockSizeMinus3
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2DiffMaxMinPcmLumaCodingBlockSize
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
        public byte Reserved2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte PaletteMaxSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte DeltaPaletteMaxPredictorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MotionVectorResolutionControlIdc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte SpsNumPalettePredictorInitializersMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ConfWinLeftOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ConfWinRightOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ConfWinTopOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ConfWinBottomOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265ProfileTierLevel? ProfileTierLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265DecPicBufMgr? DecPicBufMgr
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265ScalingLists? ScalingLists
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265ShortTermRefPicSet[] ShortTermRefPicSet
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265LongTermRefPicsSps? LongTermRefPicsSps
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265SequenceParameterSetVui? SequenceParameterSetVui
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265PredictorPaletteEntries? PredictorPaletteEntries
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoH265SequenceParameterSet* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->ChromaFormatIdc = this.ChromaFormatIdc;
            pointer->PicWidthInLumaSamples = this.PicWidthInLumaSamples;
            pointer->PicHeightInLumaSamples = this.PicHeightInLumaSamples;
            pointer->SpsVideoParameterSetId = this.SpsVideoParameterSetId;
            pointer->SpsMaxSubLayersMinus1 = this.SpsMaxSubLayersMinus1;
            pointer->SpsSeqParameterSetId = this.SpsSeqParameterSetId;
            pointer->BitDepthLumaMinus8 = this.BitDepthLumaMinus8;
            pointer->BitDepthChromaMinus8 = this.BitDepthChromaMinus8;
            pointer->Log2MaxPicOrderCntLsbMinus4 = this.Log2MaxPicOrderCntLsbMinus4;
            pointer->Log2MinLumaCodingBlockSizeMinus3 = this.Log2MinLumaCodingBlockSizeMinus3;
            pointer->Log2DiffMaxMinLumaCodingBlockSize = this.Log2DiffMaxMinLumaCodingBlockSize;
            pointer->Log2MinLumaTransformBlockSizeMinus2 = this.Log2MinLumaTransformBlockSizeMinus2;
            pointer->Log2DiffMaxMinLumaTransformBlockSize = this.Log2DiffMaxMinLumaTransformBlockSize;
            pointer->MaxTransformHierarchyDepthInter = this.MaxTransformHierarchyDepthInter;
            pointer->MaxTransformHierarchyDepthIntra = this.MaxTransformHierarchyDepthIntra;
            pointer->NumShortTermRefPicSets = (byte)(Interop.HeapUtil.GetLength(this.ShortTermRefPicSet));
            pointer->NumLongTermRefPicsSps = this.NumLongTermRefPicsSps;
            pointer->PcmSampleBitDepthLumaMinus1 = this.PcmSampleBitDepthLumaMinus1;
            pointer->PcmSampleBitDepthChromaMinus1 = this.PcmSampleBitDepthChromaMinus1;
            pointer->Log2MinPcmLumaCodingBlockSizeMinus3 = this.Log2MinPcmLumaCodingBlockSizeMinus3;
            pointer->Log2DiffMaxMinPcmLumaCodingBlockSize = this.Log2DiffMaxMinPcmLumaCodingBlockSize;
            pointer->Reserved1 = this.Reserved1;
            pointer->Reserved2 = this.Reserved2;
            pointer->PaletteMaxSize = this.PaletteMaxSize;
            pointer->DeltaPaletteMaxPredictorSize = this.DeltaPaletteMaxPredictorSize;
            pointer->MotionVectorResolutionControlIdc = this.MotionVectorResolutionControlIdc;
            pointer->SpsNumPalettePredictorInitializersMinus1 = this.SpsNumPalettePredictorInitializersMinus1;
            pointer->ConfWinLeftOffset = this.ConfWinLeftOffset;
            pointer->ConfWinRightOffset = this.ConfWinRightOffset;
            pointer->ConfWinTopOffset = this.ConfWinTopOffset;
            pointer->ConfWinBottomOffset = this.ConfWinBottomOffset;
            if (this.ProfileTierLevel != null)
            {
                pointer->ProfileTierLevel = (SharpVk.StdVideoH265ProfileTierLevel*)(Interop.HeapUtil.Allocate<SharpVk.StdVideoH265ProfileTierLevel>());
                *pointer->ProfileTierLevel = this.ProfileTierLevel.Value;
            }
            else
            {
                pointer->ProfileTierLevel = default(SharpVk.StdVideoH265ProfileTierLevel*);
            }
            if (this.DecPicBufMgr != null)
            {
                pointer->DecPicBufMgr = (SharpVk.Interop.StdVideoH265DecPicBufMgr*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH265DecPicBufMgr>());
                this.DecPicBufMgr.Value.MarshalTo(pointer->DecPicBufMgr);
            }
            else
            {
                pointer->DecPicBufMgr = default(SharpVk.Interop.StdVideoH265DecPicBufMgr*);
            }
            if (this.ScalingLists != null)
            {
                pointer->ScalingLists = (SharpVk.Interop.StdVideoH265ScalingLists*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH265ScalingLists>());
                this.ScalingLists.Value.MarshalTo(pointer->ScalingLists);
            }
            else
            {
                pointer->ScalingLists = default(SharpVk.Interop.StdVideoH265ScalingLists*);
            }
            if (this.ShortTermRefPicSet != null)
            {
                var fieldPointer = (SharpVk.Interop.StdVideoH265ShortTermRefPicSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.StdVideoH265ShortTermRefPicSet>(this.ShortTermRefPicSet.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ShortTermRefPicSet.Length); index++)
                {
                    this.ShortTermRefPicSet[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ShortTermRefPicSet = fieldPointer;
            }
            else
            {
                pointer->ShortTermRefPicSet = null;
            }
            if (this.LongTermRefPicsSps != null)
            {
                pointer->LongTermRefPicsSps = (SharpVk.Interop.StdVideoH265LongTermRefPicsSps*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH265LongTermRefPicsSps>());
                this.LongTermRefPicsSps.Value.MarshalTo(pointer->LongTermRefPicsSps);
            }
            else
            {
                pointer->LongTermRefPicsSps = default(SharpVk.Interop.StdVideoH265LongTermRefPicsSps*);
            }
            if (this.SequenceParameterSetVui != null)
            {
                pointer->SequenceParameterSetVui = (SharpVk.Interop.StdVideoH265SequenceParameterSetVui*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH265SequenceParameterSetVui>());
                this.SequenceParameterSetVui.Value.MarshalTo(pointer->SequenceParameterSetVui);
            }
            else
            {
                pointer->SequenceParameterSetVui = default(SharpVk.Interop.StdVideoH265SequenceParameterSetVui*);
            }
            if (this.PredictorPaletteEntries != null)
            {
                pointer->PredictorPaletteEntries = (SharpVk.Interop.StdVideoH265PredictorPaletteEntries*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH265PredictorPaletteEntries>());
                this.PredictorPaletteEntries.Value.MarshalTo(pointer->PredictorPaletteEntries);
            }
            else
            {
                pointer->PredictorPaletteEntries = default(SharpVk.Interop.StdVideoH265PredictorPaletteEntries*);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoH265SequenceParameterSet MarshalFrom(SharpVk.Interop.StdVideoH265SequenceParameterSet* pointer)
        {
            StdVideoH265SequenceParameterSet result = default(StdVideoH265SequenceParameterSet);
            result.Flags = pointer->Flags;
            result.ChromaFormatIdc = pointer->ChromaFormatIdc;
            result.PicWidthInLumaSamples = pointer->PicWidthInLumaSamples;
            result.PicHeightInLumaSamples = pointer->PicHeightInLumaSamples;
            result.SpsVideoParameterSetId = pointer->SpsVideoParameterSetId;
            result.SpsMaxSubLayersMinus1 = pointer->SpsMaxSubLayersMinus1;
            result.SpsSeqParameterSetId = pointer->SpsSeqParameterSetId;
            result.BitDepthLumaMinus8 = pointer->BitDepthLumaMinus8;
            result.BitDepthChromaMinus8 = pointer->BitDepthChromaMinus8;
            result.Log2MaxPicOrderCntLsbMinus4 = pointer->Log2MaxPicOrderCntLsbMinus4;
            result.Log2MinLumaCodingBlockSizeMinus3 = pointer->Log2MinLumaCodingBlockSizeMinus3;
            result.Log2DiffMaxMinLumaCodingBlockSize = pointer->Log2DiffMaxMinLumaCodingBlockSize;
            result.Log2MinLumaTransformBlockSizeMinus2 = pointer->Log2MinLumaTransformBlockSizeMinus2;
            result.Log2DiffMaxMinLumaTransformBlockSize = pointer->Log2DiffMaxMinLumaTransformBlockSize;
            result.MaxTransformHierarchyDepthInter = pointer->MaxTransformHierarchyDepthInter;
            result.MaxTransformHierarchyDepthIntra = pointer->MaxTransformHierarchyDepthIntra;
            result.NumLongTermRefPicsSps = pointer->NumLongTermRefPicsSps;
            result.PcmSampleBitDepthLumaMinus1 = pointer->PcmSampleBitDepthLumaMinus1;
            result.PcmSampleBitDepthChromaMinus1 = pointer->PcmSampleBitDepthChromaMinus1;
            result.Log2MinPcmLumaCodingBlockSizeMinus3 = pointer->Log2MinPcmLumaCodingBlockSizeMinus3;
            result.Log2DiffMaxMinPcmLumaCodingBlockSize = pointer->Log2DiffMaxMinPcmLumaCodingBlockSize;
            result.Reserved1 = pointer->Reserved1;
            result.Reserved2 = pointer->Reserved2;
            result.PaletteMaxSize = pointer->PaletteMaxSize;
            result.DeltaPaletteMaxPredictorSize = pointer->DeltaPaletteMaxPredictorSize;
            result.MotionVectorResolutionControlIdc = pointer->MotionVectorResolutionControlIdc;
            result.SpsNumPalettePredictorInitializersMinus1 = pointer->SpsNumPalettePredictorInitializersMinus1;
            result.ConfWinLeftOffset = pointer->ConfWinLeftOffset;
            result.ConfWinRightOffset = pointer->ConfWinRightOffset;
            result.ConfWinTopOffset = pointer->ConfWinTopOffset;
            result.ConfWinBottomOffset = pointer->ConfWinBottomOffset;
            if (pointer->ProfileTierLevel != null)
            {
                result.ProfileTierLevel = *pointer->ProfileTierLevel;
            }
            else
            {
                result.ProfileTierLevel = null;
            }
            if (pointer->DecPicBufMgr != null)
            {
                result.DecPicBufMgr = SharpVk.StdVideoH265DecPicBufMgr.MarshalFrom(pointer->DecPicBufMgr);
            }
            else
            {
                result.DecPicBufMgr = null;
            }
            if (pointer->ScalingLists != null)
            {
                result.ScalingLists = SharpVk.StdVideoH265ScalingLists.MarshalFrom(pointer->ScalingLists);
            }
            else
            {
                result.ScalingLists = null;
            }
            if (pointer->ShortTermRefPicSet != null)
            {
                var fieldPointer = new SharpVk.StdVideoH265ShortTermRefPicSet[(uint)(pointer->NumShortTermRefPicSets)];
                for(int index = 0; index < (uint)(pointer->NumShortTermRefPicSets); index++)
                {
                    fieldPointer[index] = SharpVk.StdVideoH265ShortTermRefPicSet.MarshalFrom(&pointer->ShortTermRefPicSet[index]);
                }
                result.ShortTermRefPicSet = fieldPointer;
            }
            else
            {
                result.ShortTermRefPicSet = null;
            }
            if (pointer->LongTermRefPicsSps != null)
            {
                result.LongTermRefPicsSps = SharpVk.StdVideoH265LongTermRefPicsSps.MarshalFrom(pointer->LongTermRefPicsSps);
            }
            else
            {
                result.LongTermRefPicsSps = null;
            }
            if (pointer->SequenceParameterSetVui != null)
            {
                result.SequenceParameterSetVui = SharpVk.StdVideoH265SequenceParameterSetVui.MarshalFrom(pointer->SequenceParameterSetVui);
            }
            else
            {
                result.SequenceParameterSetVui = null;
            }
            if (pointer->PredictorPaletteEntries != null)
            {
                result.PredictorPaletteEntries = SharpVk.StdVideoH265PredictorPaletteEntries.MarshalFrom(pointer->PredictorPaletteEntries);
            }
            else
            {
                result.PredictorPaletteEntries = null;
            }
            return result;
        }
    }
}
