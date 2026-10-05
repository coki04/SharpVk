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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct StdVideoAV1Segmentation
    {
        /// <summary>
        /// 
        /// </summary>
        public byte[] FeatureEnabled
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public short[] FeatureData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoAV1Segmentation* pointer)
        {
            Interop.HeapUtil.MarshalTo(this.FeatureEnabled, checked((int)Constants.StdVideoAv1MaxSegments), pointer->FeatureEnabled);
            Interop.HeapUtil.MarshalTo(this.FeatureData, checked((int)Constants.StdVideoAv1MaxSegments), pointer->FeatureData);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoAV1Segmentation MarshalFrom(SharpVk.Interop.StdVideoAV1Segmentation* pointer)
        {
            StdVideoAV1Segmentation result = default(StdVideoAV1Segmentation);
            result.FeatureEnabled = Interop.HeapUtil.MarshalFrom(pointer->FeatureEnabled, checked((int)Constants.StdVideoAv1MaxSegments));
            result.FeatureData = Interop.HeapUtil.MarshalFrom(pointer->FeatureData, checked((int)Constants.StdVideoAv1MaxSegments));
            return result;
        }
    }
}
