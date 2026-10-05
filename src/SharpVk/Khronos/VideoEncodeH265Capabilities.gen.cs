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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VideoEncodeH265Capabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeH265CapabilityFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265LevelIdc MaxLevelIdc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSliceSegmentCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MaxTiles
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeH265CtbSizeFlags CtbSizes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeH265TransformBlockSizeFlags TransformBlockSizes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPPictureL0ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxBPictureL0ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxL1ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSubLayerCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExpectDyadicTemporalSubLayerPattern
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int MinQp
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int MaxQp
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PrefersGopRemainingFrames
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool RequiresGopRemainingFrames
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeH265StdFlags StdSyntaxFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe VideoEncodeH265Capabilities MarshalFrom(SharpVk.Interop.Khronos.VideoEncodeH265Capabilities* pointer)
        {
            VideoEncodeH265Capabilities result = default(VideoEncodeH265Capabilities);
            result.Flags = pointer->Flags;
            result.MaxLevelIdc = pointer->MaxLevelIdc;
            result.MaxSliceSegmentCount = pointer->MaxSliceSegmentCount;
            result.MaxTiles = pointer->MaxTiles;
            result.CtbSizes = pointer->CtbSizes;
            result.TransformBlockSizes = pointer->TransformBlockSizes;
            result.MaxPPictureL0ReferenceCount = pointer->MaxPPictureL0ReferenceCount;
            result.MaxBPictureL0ReferenceCount = pointer->MaxBPictureL0ReferenceCount;
            result.MaxL1ReferenceCount = pointer->MaxL1ReferenceCount;
            result.MaxSubLayerCount = pointer->MaxSubLayerCount;
            result.ExpectDyadicTemporalSubLayerPattern = pointer->ExpectDyadicTemporalSubLayerPattern;
            result.MinQp = pointer->MinQp;
            result.MaxQp = pointer->MaxQp;
            result.PrefersGopRemainingFrames = pointer->PrefersGopRemainingFrames;
            result.RequiresGopRemainingFrames = pointer->RequiresGopRemainingFrames;
            result.StdSyntaxFlags = pointer->StdSyntaxFlags;
            return result;
        }
    }
}
