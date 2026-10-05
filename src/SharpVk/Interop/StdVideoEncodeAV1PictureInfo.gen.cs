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
    public unsafe partial struct StdVideoEncodeAV1PictureInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeAV1PictureInfoFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1FrameType FrameType; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint FramePresentationTime; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint CurrentFrameId; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte OrderHint; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte PrimaryRefFrame; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte RefreshFrameFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte CodedDenom; 
        
        /// <summary>
        /// 
        /// </summary>
        public ushort RenderWidthMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public ushort RenderHeightMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1InterpolationFilter InterpolationFilter; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1TxMode TxMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte DeltaQRes; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte DeltaLfRes; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed byte RefOrderHint[checked((int)Constants.StdVideoAv1NumRefFrames)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed sbyte RefFrameIdx[checked((int)Constants.StdVideoAv1RefsPerFrame)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed byte Reserved1[3]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed uint DeltaFrameIdMinus1[checked((int)Constants.StdVideoAv1RefsPerFrame)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoAV1TileInfo* TileInfo; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1Quantization* Quantization; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoAV1Segmentation* Segmentation; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoAV1LoopFilter* LoopFilter; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoAV1CDEF* CDEF; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoAV1LoopRestoration* LoopRestoration; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoAV1GlobalMotion* GlobalMotion; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeAV1ExtensionHeader* ExtensionHeader; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* BufferRemovalTimes; 
    }
}
