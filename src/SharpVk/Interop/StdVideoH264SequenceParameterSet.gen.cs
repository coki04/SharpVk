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
    public unsafe partial struct StdVideoH264SequenceParameterSet
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264SpsFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264ProfileIdc ProfileIdc; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264LevelIdc LevelIdc; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264ChromaFormatIdc ChromaFormatIdc; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte SeqParameterSetId; 
        
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
        public byte Log2MaxFrameNumMinus4; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264PocType PicOrderCntType; 
        
        /// <summary>
        /// 
        /// </summary>
        public int OffsetForNonRefPic; 
        
        /// <summary>
        /// 
        /// </summary>
        public int OffsetForTopToBottomField; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MaxPicOrderCntLsbMinus4; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumRefFramesInPicOrderCntCycle; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxNumRefFrames; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Reserved1; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PicWidthInMbsMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PicHeightInMapUnitsMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint FrameCropLeftOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint FrameCropRightOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint FrameCropTopOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint FrameCropBottomOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Reserved2; 
        
        /// <summary>
        /// 
        /// </summary>
        public int* OffsetForRefFrame; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoH264ScalingLists* ScalingLists; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoH264SequenceParameterSetVui* SequenceParameterSetVui; 
    }
}
