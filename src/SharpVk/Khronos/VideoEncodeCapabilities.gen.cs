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
    public partial struct VideoEncodeCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeCapabilityFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeRateControlModeFlags RateControlModes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxRateControlLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxBitrate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxQualityLevels
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D EncodeInputPictureGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeFeedbackFlags SupportedEncodeFeedbackFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe VideoEncodeCapabilities MarshalFrom(SharpVk.Interop.Khronos.VideoEncodeCapabilities* pointer)
        {
            VideoEncodeCapabilities result = default(VideoEncodeCapabilities);
            result.Flags = pointer->Flags;
            result.RateControlModes = pointer->RateControlModes;
            result.MaxRateControlLayers = pointer->MaxRateControlLayers;
            result.MaxBitrate = pointer->MaxBitrate;
            result.MaxQualityLevels = pointer->MaxQualityLevels;
            result.EncodeInputPictureGranularity = pointer->EncodeInputPictureGranularity;
            result.SupportedEncodeFeedbackFlags = pointer->SupportedEncodeFeedbackFlags;
            return result;
        }
    }
}
