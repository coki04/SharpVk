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
    public unsafe partial struct StdVideoH265SequenceParameterSet
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265SpsFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265ChromaFormatIdc ChromaFormatIdc; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PicWidthInLumaSamples; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PicHeightInLumaSamples; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte SpsVideoParameterSetId; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte SpsMaxSubLayersMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte SpsSeqParameterSetId; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte BitDepthLumaMinus8; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte BitDepthChromaMinus8; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MaxPicOrderCntLsbMinus4; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MinLumaCodingBlockSizeMinus3; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2DiffMaxMinLumaCodingBlockSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MinLumaTransformBlockSizeMinus2; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2DiffMaxMinLumaTransformBlockSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxTransformHierarchyDepthInter; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxTransformHierarchyDepthIntra; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumShortTermRefPicSets; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumLongTermRefPicsSps; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte PcmSampleBitDepthLumaMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte PcmSampleBitDepthChromaMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MinPcmLumaCodingBlockSizeMinus3; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2DiffMaxMinPcmLumaCodingBlockSize; 
        
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
        public byte PaletteMaxSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte DeltaPaletteMaxPredictorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MotionVectorResolutionControlIdc; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte SpsNumPalettePredictorInitializersMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ConfWinLeftOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ConfWinRightOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ConfWinTopOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ConfWinBottomOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265ProfileTierLevel* ProfileTierLevel; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoH265DecPicBufMgr* DecPicBufMgr; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoH265ScalingLists* ScalingLists; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoH265ShortTermRefPicSet* ShortTermRefPicSet; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoH265LongTermRefPicsSps* LongTermRefPicsSps; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoH265SequenceParameterSetVui* SequenceParameterSetVui; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoH265PredictorPaletteEntries* PredictorPaletteEntries; 
    }
}
