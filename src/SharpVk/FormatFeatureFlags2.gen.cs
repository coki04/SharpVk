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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [System.Flags]
    public enum FormatFeatureFlags2 : long
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImage = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageImage = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageImageAtomic = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        UniformTexelBuffer = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageTexelBuffer = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageTexelBufferAtomic = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexBuffer = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachment = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentBlend = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthStencilAttachment = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        BlitSource = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        BlitDestination = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageFilterLinear = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        TransferSource = 1 << 14, 
        
        /// <summary>
        /// 
        /// </summary>
        TransferDestination = 1 << 15, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageFilterMinmax = 1 << 16, 
        
        /// <summary>
        /// 
        /// </summary>
        MidpointChromaSamples = 1 << 17, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageYcbcrConversionLinearFilter = 1 << 18, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageYcbcrConversionSeparateReconstructionFilter = 1 << 19, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageYcbcrConversionChromaReconstructionExplicit = 1 << 20, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageYcbcrConversionChromaReconstructionExplicitForceable = 1 << 21, 
        
        /// <summary>
        /// 
        /// </summary>
        Disjoint = 1 << 22, 
        
        /// <summary>
        /// 
        /// </summary>
        CositedChromaSamples = 1 << 23, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageReadWithoutFormat = 1 << 31, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageWriteWithoutFormat = 1 << 32, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageDepthComparison = 1 << 33, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageFilterCubic = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        HostImageTransfer = 1 << 46, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoDecodeOutput = 1 << 25, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoDecodeDpb = 1 << 26, 
        
        /// <summary>
        /// 
        /// </summary>
        AccelerationStructureVertexBuffer = 1 << 29, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentDensityMap = 1 << 24, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentShadingRateAttachment = 1 << 30, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncodeInput = 1 << 27, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncodeDpb = 1 << 28, 
        
        /// <summary>
        /// 
        /// </summary>
        BlockMatchingSxd = 1 << 44, 
        
        /// <summary>
        /// 
        /// </summary>
        AccelerationStructureRadiusBuffer = 1 << 51, 
        
        /// <summary>
        /// 
        /// </summary>
        LinearColorAttachment = 1 << 38, 
        
        /// <summary>
        /// 
        /// </summary>
        WeightImage = 1 << 34, 
        
        /// <summary>
        /// 
        /// </summary>
        WeightSampledImage = 1 << 35, 
        
        /// <summary>
        /// 
        /// </summary>
        BlockMatching = 1 << 36, 
        
        /// <summary>
        /// 
        /// </summary>
        BoxFilterSampled = 1 << 37, 
        
        /// <summary>
        /// 
        /// </summary>
        TensorShader = 1 << 39, 
        
        /// <summary>
        /// 
        /// </summary>
        TensorImageAliasing = 1 << 43, 
        
        /// <summary>
        /// 
        /// </summary>
        OpticalFlowImage = 1 << 40, 
        
        /// <summary>
        /// 
        /// </summary>
        OpticalFlowVector = 1 << 41, 
        
        /// <summary>
        /// 
        /// </summary>
        OpticalFlowCost = 1 << 42, 
        
        /// <summary>
        /// 
        /// </summary>
        TensorDataGraph = 1 << 48, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved60 = 1 << 60, 
        
        /// <summary>
        /// 
        /// </summary>
        CopyImageIndirectDestination = 1 << 59, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncodeQuantizationDeltaMap = 1 << 49, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncodeEmphasisMap = 1 << 50, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageFilterLinear2d = 1 << 45, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthCopyOnComputeQueue = 1 << 52, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthCopyOnTransferQueue = 1 << 53, 
        
        /// <summary>
        /// 
        /// </summary>
        StencilCopyOnComputeQueue = 1 << 54, 
        
        /// <summary>
        /// 
        /// </summary>
        StencilCopyOnTransferQueue = 1 << 55, 
        
        /// <summary>
        /// 
        /// </summary>
        DataGraphOpticalFlowImage = 1 << 56, 
        
        /// <summary>
        /// 
        /// </summary>
        DataGraphOpticalFlowVector = 1 << 57, 
        
        /// <summary>
        /// 
        /// </summary>
        DataGraphOpticalFlowCost = 1 << 58, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved47 = 1 << 47, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved61 = 1 << 61, 
    }
}
