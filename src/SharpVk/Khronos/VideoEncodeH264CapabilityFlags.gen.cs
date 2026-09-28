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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [System.Flags]
    public enum VideoEncodeH264CapabilityFlags 
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        H264CapabilityHrdCompliance = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        H264CapabilityPredictionWeightTableGenerated = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        H264CapabilityRowUnalignedSlice = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        H264CapabilityDifferentSliceType = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        H264CapabilityBFrameInL0List = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        H264CapabilityBFrameInL1List = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        H264CapabilityPerPictureTypeMinMaxQp = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        H264CapabilityPerSliceConstantQp = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        H264CapabilityGeneratePrefixNalu = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        H264CapabilityBPictureIntraRefresh = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        H264CapabilityMbQpDiffWraparound = 1 << 9, 
    }
}
