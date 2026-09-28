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
    public partial struct VideoEncodeIntraRefreshCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeIntraRefreshModeFlags? IntraRefreshModes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxIntraRefreshCycleDuration
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxIntraRefreshActiveReferencePictures
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PartitionIndependentIntraRefreshRegions
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool NonRectangularIntraRefreshRegions
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe VideoEncodeIntraRefreshCapabilities MarshalFrom(SharpVk.Interop.Khronos.VideoEncodeIntraRefreshCapabilities* pointer)
        {
            VideoEncodeIntraRefreshCapabilities result = default(VideoEncodeIntraRefreshCapabilities);
            result.IntraRefreshModes = pointer->IntraRefreshModes;
            result.MaxIntraRefreshCycleDuration = pointer->MaxIntraRefreshCycleDuration;
            result.MaxIntraRefreshActiveReferencePictures = pointer->MaxIntraRefreshActiveReferencePictures;
            result.PartitionIndependentIntraRefreshRegions = pointer->PartitionIndependentIntraRefreshRegions;
            result.NonRectangularIntraRefreshRegions = pointer->NonRectangularIntraRefreshRegions;
            return result;
        }
    }
}
