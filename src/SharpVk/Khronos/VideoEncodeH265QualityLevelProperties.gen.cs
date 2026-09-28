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
    public partial struct VideoEncodeH265QualityLevelProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeH265RateControlFlags PreferredRateControlFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredGopFrameCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredIdrPeriod
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredConsecutiveBFrameCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredSubLayerCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeH265Qp PreferredConstantQp
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredMaxL0ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredMaxL1ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe VideoEncodeH265QualityLevelProperties MarshalFrom(SharpVk.Interop.Khronos.VideoEncodeH265QualityLevelProperties* pointer)
        {
            VideoEncodeH265QualityLevelProperties result = default(VideoEncodeH265QualityLevelProperties);
            result.PreferredRateControlFlags = pointer->PreferredRateControlFlags;
            result.PreferredGopFrameCount = pointer->PreferredGopFrameCount;
            result.PreferredIdrPeriod = pointer->PreferredIdrPeriod;
            result.PreferredConsecutiveBFrameCount = pointer->PreferredConsecutiveBFrameCount;
            result.PreferredSubLayerCount = pointer->PreferredSubLayerCount;
            result.PreferredConstantQp = pointer->PreferredConstantQp;
            result.PreferredMaxL0ReferenceCount = pointer->PreferredMaxL0ReferenceCount;
            result.PreferredMaxL1ReferenceCount = pointer->PreferredMaxL1ReferenceCount;
            return result;
        }
    }
}
