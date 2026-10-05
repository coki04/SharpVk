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

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265PictureParameterSet
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265PpsFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte PpsPicParameterSetId; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte PpsSeqParameterSetId; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte SpsVideoParameterSetId; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumExtraSliceHeaderBits; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumRefIdxL0DefaultActiveMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumRefIdxL1DefaultActiveMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte InitQpMinus26; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte DiffCuQpDeltaDepth; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsCbQpOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsCrQpOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsBetaOffsetDiv2; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsTcOffsetDiv2; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2ParallelMergeLevelMinus2; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MaxTransformSkipBlockSizeMinus2; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte DiffCuChromaQpOffsetDepth; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte ChromaQpOffsetListLenMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed sbyte CbQpOffsetList[checked((int)Constants.StdVideoH265ChromaQpOffsetListSize)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed sbyte CrQpOffsetList[checked((int)Constants.StdVideoH265ChromaQpOffsetListSize)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2SaoOffsetScaleLuma; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2SaoOffsetScaleChroma; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsActYQpOffsetPlus5; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsActCbQpOffsetPlus5; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte PpsActCrQpOffsetPlus3; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte PpsNumPalettePredictorInitializers; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte LumaBitDepthEntryMinus8; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte ChromaBitDepthEntryMinus8; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumTileColumnsMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumTileRowsMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Reserved1; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Reserved2; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed ushort ColumnWidthMinus1[checked((int)Constants.StdVideoH265ChromaQpOffsetTileColsListSize)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed ushort RowHeightMinus1[checked((int)Constants.StdVideoH265ChromaQpOffsetTileRowsListSize)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Reserved3; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoH265ScalingLists* ScalingLists; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoH265PredictorPaletteEntries* PredictorPaletteEntries; 
    }
}
