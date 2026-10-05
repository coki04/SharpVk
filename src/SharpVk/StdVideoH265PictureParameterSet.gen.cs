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
    public partial struct StdVideoH265PictureParameterSet
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265PpsFlags Flags
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
        public byte PpsSeqParameterSetId
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
        public byte NumExtraSliceHeaderBits
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
        public sbyte InitQpMinus26
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte DiffCuQpDeltaDepth
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsCbQpOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsCrQpOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsBetaOffsetDiv2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsTcOffsetDiv2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2ParallelMergeLevelMinus2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MaxTransformSkipBlockSizeMinus2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte DiffCuChromaQpOffsetDepth
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte ChromaQpOffsetListLenMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] CbQpOffsetList
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] CrQpOffsetList
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2SaoOffsetScaleLuma
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2SaoOffsetScaleChroma
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsActYQpOffsetPlus5
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsActCbQpOffsetPlus5
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsActCrQpOffsetPlus3
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte PpsNumPalettePredictorInitializers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte LumaBitDepthEntryMinus8
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte ChromaBitDepthEntryMinus8
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumTileColumnsMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumTileRowsMinus1
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
        public ushort[] ColumnWidthMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort[] RowHeightMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Reserved3
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
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoH265PictureParameterSet* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->PpsPicParameterSetId = this.PpsPicParameterSetId;
            pointer->PpsSeqParameterSetId = this.PpsSeqParameterSetId;
            pointer->SpsVideoParameterSetId = this.SpsVideoParameterSetId;
            pointer->NumExtraSliceHeaderBits = this.NumExtraSliceHeaderBits;
            pointer->NumRefIdxL0DefaultActiveMinus1 = this.NumRefIdxL0DefaultActiveMinus1;
            pointer->NumRefIdxL1DefaultActiveMinus1 = this.NumRefIdxL1DefaultActiveMinus1;
            pointer->InitQpMinus26 = this.InitQpMinus26;
            pointer->DiffCuQpDeltaDepth = this.DiffCuQpDeltaDepth;
            pointer->PpsCbQpOffset = this.PpsCbQpOffset;
            pointer->PpsCrQpOffset = this.PpsCrQpOffset;
            pointer->PpsBetaOffsetDiv2 = this.PpsBetaOffsetDiv2;
            pointer->PpsTcOffsetDiv2 = this.PpsTcOffsetDiv2;
            pointer->Log2ParallelMergeLevelMinus2 = this.Log2ParallelMergeLevelMinus2;
            pointer->Log2MaxTransformSkipBlockSizeMinus2 = this.Log2MaxTransformSkipBlockSizeMinus2;
            pointer->DiffCuChromaQpOffsetDepth = this.DiffCuChromaQpOffsetDepth;
            pointer->ChromaQpOffsetListLenMinus1 = this.ChromaQpOffsetListLenMinus1;
            Interop.HeapUtil.MarshalTo(this.CbQpOffsetList, checked((int)Constants.StdVideoH265ChromaQpOffsetListSize), pointer->CbQpOffsetList);
            Interop.HeapUtil.MarshalTo(this.CrQpOffsetList, checked((int)Constants.StdVideoH265ChromaQpOffsetListSize), pointer->CrQpOffsetList);
            pointer->Log2SaoOffsetScaleLuma = this.Log2SaoOffsetScaleLuma;
            pointer->Log2SaoOffsetScaleChroma = this.Log2SaoOffsetScaleChroma;
            pointer->PpsActYQpOffsetPlus5 = this.PpsActYQpOffsetPlus5;
            pointer->PpsActCbQpOffsetPlus5 = this.PpsActCbQpOffsetPlus5;
            pointer->PpsActCrQpOffsetPlus3 = this.PpsActCrQpOffsetPlus3;
            pointer->PpsNumPalettePredictorInitializers = this.PpsNumPalettePredictorInitializers;
            pointer->LumaBitDepthEntryMinus8 = this.LumaBitDepthEntryMinus8;
            pointer->ChromaBitDepthEntryMinus8 = this.ChromaBitDepthEntryMinus8;
            pointer->NumTileColumnsMinus1 = this.NumTileColumnsMinus1;
            pointer->NumTileRowsMinus1 = this.NumTileRowsMinus1;
            pointer->Reserved1 = this.Reserved1;
            pointer->Reserved2 = this.Reserved2;
            Interop.HeapUtil.MarshalTo(this.ColumnWidthMinus1, checked((int)Constants.StdVideoH265ChromaQpOffsetTileColsListSize), pointer->ColumnWidthMinus1);
            Interop.HeapUtil.MarshalTo(this.RowHeightMinus1, checked((int)Constants.StdVideoH265ChromaQpOffsetTileRowsListSize), pointer->RowHeightMinus1);
            pointer->Reserved3 = this.Reserved3;
            if (this.ScalingLists != null)
            {
                pointer->ScalingLists = (SharpVk.Interop.StdVideoH265ScalingLists*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH265ScalingLists>());
                this.ScalingLists.Value.MarshalTo(pointer->ScalingLists);
            }
            else
            {
                pointer->ScalingLists = default(SharpVk.Interop.StdVideoH265ScalingLists*);
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
        internal static unsafe StdVideoH265PictureParameterSet MarshalFrom(SharpVk.Interop.StdVideoH265PictureParameterSet* pointer)
        {
            StdVideoH265PictureParameterSet result = default(StdVideoH265PictureParameterSet);
            result.Flags = pointer->Flags;
            result.PpsPicParameterSetId = pointer->PpsPicParameterSetId;
            result.PpsSeqParameterSetId = pointer->PpsSeqParameterSetId;
            result.SpsVideoParameterSetId = pointer->SpsVideoParameterSetId;
            result.NumExtraSliceHeaderBits = pointer->NumExtraSliceHeaderBits;
            result.NumRefIdxL0DefaultActiveMinus1 = pointer->NumRefIdxL0DefaultActiveMinus1;
            result.NumRefIdxL1DefaultActiveMinus1 = pointer->NumRefIdxL1DefaultActiveMinus1;
            result.InitQpMinus26 = pointer->InitQpMinus26;
            result.DiffCuQpDeltaDepth = pointer->DiffCuQpDeltaDepth;
            result.PpsCbQpOffset = pointer->PpsCbQpOffset;
            result.PpsCrQpOffset = pointer->PpsCrQpOffset;
            result.PpsBetaOffsetDiv2 = pointer->PpsBetaOffsetDiv2;
            result.PpsTcOffsetDiv2 = pointer->PpsTcOffsetDiv2;
            result.Log2ParallelMergeLevelMinus2 = pointer->Log2ParallelMergeLevelMinus2;
            result.Log2MaxTransformSkipBlockSizeMinus2 = pointer->Log2MaxTransformSkipBlockSizeMinus2;
            result.DiffCuChromaQpOffsetDepth = pointer->DiffCuChromaQpOffsetDepth;
            result.ChromaQpOffsetListLenMinus1 = pointer->ChromaQpOffsetListLenMinus1;
            result.CbQpOffsetList = Interop.HeapUtil.MarshalFrom(pointer->CbQpOffsetList, checked((int)Constants.StdVideoH265ChromaQpOffsetListSize));
            result.CrQpOffsetList = Interop.HeapUtil.MarshalFrom(pointer->CrQpOffsetList, checked((int)Constants.StdVideoH265ChromaQpOffsetListSize));
            result.Log2SaoOffsetScaleLuma = pointer->Log2SaoOffsetScaleLuma;
            result.Log2SaoOffsetScaleChroma = pointer->Log2SaoOffsetScaleChroma;
            result.PpsActYQpOffsetPlus5 = pointer->PpsActYQpOffsetPlus5;
            result.PpsActCbQpOffsetPlus5 = pointer->PpsActCbQpOffsetPlus5;
            result.PpsActCrQpOffsetPlus3 = pointer->PpsActCrQpOffsetPlus3;
            result.PpsNumPalettePredictorInitializers = pointer->PpsNumPalettePredictorInitializers;
            result.LumaBitDepthEntryMinus8 = pointer->LumaBitDepthEntryMinus8;
            result.ChromaBitDepthEntryMinus8 = pointer->ChromaBitDepthEntryMinus8;
            result.NumTileColumnsMinus1 = pointer->NumTileColumnsMinus1;
            result.NumTileRowsMinus1 = pointer->NumTileRowsMinus1;
            result.Reserved1 = pointer->Reserved1;
            result.Reserved2 = pointer->Reserved2;
            result.ColumnWidthMinus1 = Interop.HeapUtil.MarshalFrom(pointer->ColumnWidthMinus1, checked((int)Constants.StdVideoH265ChromaQpOffsetTileColsListSize));
            result.RowHeightMinus1 = Interop.HeapUtil.MarshalFrom(pointer->RowHeightMinus1, checked((int)Constants.StdVideoH265ChromaQpOffsetTileRowsListSize));
            result.Reserved3 = pointer->Reserved3;
            if (pointer->ScalingLists != null)
            {
                result.ScalingLists = SharpVk.StdVideoH265ScalingLists.MarshalFrom(pointer->ScalingLists);
            }
            else
            {
                result.ScalingLists = null;
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
