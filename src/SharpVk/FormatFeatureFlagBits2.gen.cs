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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum FormatFeatureFlagBits2
    {
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2SampledImage = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2StorageImage = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2StorageImageAtomic = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2UniformTexelBuffer = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2StorageTexelBuffer = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2StorageTexelBufferAtomic = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2VertexBuffer = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2ColorAttachment = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2ColorAttachmentBlend = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2DepthStencilAttachment = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2BlitSource = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2BlitDestination = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2SampledImageFilterLinear = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2SampledImageFilterCubic = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2TransferSource = 1 << 14, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2TransferDestination = 1 << 15, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2SampledImageFilterMinmax = 1 << 16, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2MidpointChromaSamples = 1 << 17, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2SampledImageYcbcrConversionLinearFilter = 1 << 18, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2SampledImageYcbcrConversionSeparateReconstructionFilter = 1 << 19, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicit = 1 << 20, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitForceable = 1 << 21, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2Disjoint = 1 << 22, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2CositedChromaSamples = 1 << 23, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2StorageReadWithoutFormat = 1 << 31, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2StorageWriteWithoutFormat = 1 << 32, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2SampledImageDepthComparison = 1 << 33, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2VideoDecodeOutput = 1 << 25, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2VideoDecodeDpb = 1 << 26, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2AccelerationStructureVertexBuffer = 1 << 29, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2FragmentDensityMap = 1 << 24, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2FragmentShadingRateAttachment = 1 << 30, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2Reserved44 = 1 << 44, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2Reserved45 = 1 << 45, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2VideoEncodeInput = 1 << 27, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2VideoEncodeDpb = 1 << 28, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2LinearColorAttachment = 1 << 38, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2WeightImage = 1 << 34, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2WeightSampledImage = 1 << 35, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2BlockMatching = 1 << 36, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2BoxFilterSampled = 1 << 37, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2Reserved39 = 1 << 39, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2OpticalFlowImage = 1 << 40, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2OpticalFlowVector = 1 << 41, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatFeature2OpticalFlowCost = 1 << 42, 
    }
}
