// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2025
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
    public partial struct VideoEncodeH264Capabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeH264CapabilityFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int MaxLevelIdc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSliceCount
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
        public uint MaxTemporalLayerCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExpectDyadicTemporalLayerPattern
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
        public SharpVk.Khronos.VideoEncodeH264StdFlags StdSyntaxFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe VideoEncodeH264Capabilities MarshalFrom(SharpVk.Interop.Khronos.VideoEncodeH264Capabilities* pointer)
        {
            VideoEncodeH264Capabilities result = default(VideoEncodeH264Capabilities);
            result.Flags = pointer->Flags;
            result.MaxLevelIdc = pointer->MaxLevelIdc;
            result.MaxSliceCount = pointer->MaxSliceCount;
            result.MaxPPictureL0ReferenceCount = pointer->MaxPPictureL0ReferenceCount;
            result.MaxBPictureL0ReferenceCount = pointer->MaxBPictureL0ReferenceCount;
            result.MaxL1ReferenceCount = pointer->MaxL1ReferenceCount;
            result.MaxTemporalLayerCount = pointer->MaxTemporalLayerCount;
            result.ExpectDyadicTemporalLayerPattern = pointer->ExpectDyadicTemporalLayerPattern;
            result.MinQp = pointer->MinQp;
            result.MaxQp = pointer->MaxQp;
            result.PrefersGopRemainingFrames = pointer->PrefersGopRemainingFrames;
            result.RequiresGopRemainingFrames = pointer->RequiresGopRemainingFrames;
            result.StdSyntaxFlags = pointer->StdSyntaxFlags;
            return result;
        }
    }
}
