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
    public enum VideoEncodeH265CapabilityFlags 
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityHrdCompliance = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityPredictionWeightTableGenerated = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityRowUnalignedSliceSegment = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityDifferentSliceSegmentType = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityBFrameInL0List = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityBFrameInL1List = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityPerPictureTypeMinMaxQp = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityPerSliceSegmentConstantQp = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityMultipleTilesPerSliceSegment = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityMultipleSliceSegmentsPerTile = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityBPictureIntraRefresh = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityCuQpDiffWraparound = 1 << 10, 
    }
}
