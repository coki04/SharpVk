// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2022
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

namespace SharpVk.Multivendor
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
        H265CapabilitySeparateColourPlane = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityScalingLists = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilitySampleAdaptiveOffsetEnabled = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityPcmEnable = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilitySpsTemporalMvpEnabled = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityHrdCompliance = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityInitQpMinus26 = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityLog2ParallelMergeLevelMinus2 = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilitySignDataHidingEnabled = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityTransformSkipEnabled = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityTransformSkipDisabled = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityPpsSliceChromaQpOffsetsPresent = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityWeightedPred = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityWeightedBipred = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityWeightedPredNoTable = 1 << 14, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityTransquantBypassEnabled = 1 << 15, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityEntropyCodingSyncEnabled = 1 << 16, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityDeblockingFilterOverrideEnabled = 1 << 17, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityMultipleTilePerFrame = 1 << 18, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityMultipleSlicePerTile = 1 << 19, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityMultipleTilePerSlice = 1 << 20, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilitySliceSegmentCtbCount = 1 << 21, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityRowUnalignedSliceSegment = 1 << 22, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityDependentSliceSegment = 1 << 23, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityDifferentSliceType = 1 << 24, 
        
        /// <summary>
        /// 
        /// </summary>
        H265CapabilityBFrameInL1List = 1 << 25, 
    }
}
