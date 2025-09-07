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
    public partial struct VideoEncodeAV1QualityLevelProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeAV1RateControlFlags PreferredRateControlFlags
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
        public uint PreferredKeyFramePeriod
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredConsecutiveBipredictiveFrameCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredTemporalLayerCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeAV1QIndex PreferredConstantQIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredMaxSingleReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredSingleReferenceNameMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredMaxUnidirectionalCompoundReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredMaxUnidirectionalCompoundGroup1ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredUnidirectionalCompoundReferenceNameMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredMaxBidirectionalCompoundReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredMaxBidirectionalCompoundGroup1ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredMaxBidirectionalCompoundGroup2ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreferredBidirectionalCompoundReferenceNameMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe VideoEncodeAV1QualityLevelProperties MarshalFrom(SharpVk.Interop.Khronos.VideoEncodeAV1QualityLevelProperties* pointer)
        {
            VideoEncodeAV1QualityLevelProperties result = default(VideoEncodeAV1QualityLevelProperties);
            result.PreferredRateControlFlags = pointer->PreferredRateControlFlags;
            result.PreferredGopFrameCount = pointer->PreferredGopFrameCount;
            result.PreferredKeyFramePeriod = pointer->PreferredKeyFramePeriod;
            result.PreferredConsecutiveBipredictiveFrameCount = pointer->PreferredConsecutiveBipredictiveFrameCount;
            result.PreferredTemporalLayerCount = pointer->PreferredTemporalLayerCount;
            result.PreferredConstantQIndex = pointer->PreferredConstantQIndex;
            result.PreferredMaxSingleReferenceCount = pointer->PreferredMaxSingleReferenceCount;
            result.PreferredSingleReferenceNameMask = pointer->PreferredSingleReferenceNameMask;
            result.PreferredMaxUnidirectionalCompoundReferenceCount = pointer->PreferredMaxUnidirectionalCompoundReferenceCount;
            result.PreferredMaxUnidirectionalCompoundGroup1ReferenceCount = pointer->PreferredMaxUnidirectionalCompoundGroup1ReferenceCount;
            result.PreferredUnidirectionalCompoundReferenceNameMask = pointer->PreferredUnidirectionalCompoundReferenceNameMask;
            result.PreferredMaxBidirectionalCompoundReferenceCount = pointer->PreferredMaxBidirectionalCompoundReferenceCount;
            result.PreferredMaxBidirectionalCompoundGroup1ReferenceCount = pointer->PreferredMaxBidirectionalCompoundGroup1ReferenceCount;
            result.PreferredMaxBidirectionalCompoundGroup2ReferenceCount = pointer->PreferredMaxBidirectionalCompoundGroup2ReferenceCount;
            result.PreferredBidirectionalCompoundReferenceNameMask = pointer->PreferredBidirectionalCompoundReferenceNameMask;
            return result;
        }
    }
}
