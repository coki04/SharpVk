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
    public unsafe partial struct StdVideoDecodeVP9PictureInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoDecodeVP9PictureInfoFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoVP9Profile Profile; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoVP9FrameType FrameType; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte FrameContextIdx; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte ResetFrameContext; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte RefreshFrameFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte RefFrameSignBiasMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoVP9InterpolationFilter InterpolationFilter; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte BaseQIdx; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte DeltaQYDc; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte DeltaQUvDc; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte DeltaQUvAc; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte TileColsLog2; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte TileRowsLog2; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed ushort Reserved1[3]; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoVP9ColorConfig* ColorConfig; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoVP9LoopFilter* LoopFilter; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoVP9Segmentation* Segmentation; 
    }
}
