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
    public enum AccessFlags2 : long
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        IndirectCommandRead = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        IndexRead = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexAttributeRead = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        UniformRead = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        InputAttachmentRead = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderRead = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderWrite = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentRead = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentWrite = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthStencilAttachmentRead = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthStencilAttachmentWrite = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        TransferRead = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        TransferWrite = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        HostRead = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        HostWrite = 1 << 14, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryRead = 1 << 15, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryWrite = 1 << 16, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderSampledRead = 1 << 32, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderStorageRead = 1 << 33, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderStorageWrite = 1 << 34, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoDecodeRead = 1 << 35, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoDecodeWrite = 1 << 36, 
        
        /// <summary>
        /// 
        /// </summary>
        SamplerHeapRead = 1 << 57, 
        
        /// <summary>
        /// 
        /// </summary>
        ResourceHeapRead = 1 << 58, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved46 = 1 << 46, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncodeRead = 1 << 37, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncodeWrite = 1 << 38, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved53 = 1 << 53, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved54 = 1 << 54, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderTileAttachmentRead = 1 << 51, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderTileAttachmentWrite = 1 << 52, 
        
        /// <summary>
        /// 
        /// </summary>
        TransformFeedbackWrite = 1 << 25, 
        
        /// <summary>
        /// 
        /// </summary>
        TransformFeedbackCounterRead = 1 << 26, 
        
        /// <summary>
        /// 
        /// </summary>
        TransformFeedbackCounterWrite = 1 << 27, 
        
        /// <summary>
        /// 
        /// </summary>
        ConditionalRenderingRead = 1 << 20, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandPreprocessRead = 1 << 17, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandPreprocessWrite = 1 << 18, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentShadingRateAttachmentRead = 1 << 23, 
        
        /// <summary>
        /// 
        /// </summary>
        AccelerationStructureRead = 1 << 21, 
        
        /// <summary>
        /// 
        /// </summary>
        AccelerationStructureWrite = 1 << 22, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentDensityMapRead = 1 << 24, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentReadNoncoherent = 1 << 19, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorBufferRead = 1 << 41, 
        
        /// <summary>
        /// 
        /// </summary>
        InvocationMaskRead = 1 << 39, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderBindingTableRead = 1 << 40, 
        
        /// <summary>
        /// 
        /// </summary>
        MicromapRead = 1 << 44, 
        
        /// <summary>
        /// 
        /// </summary>
        MicromapWrite = 1 << 45, 
        
        /// <summary>
        /// 
        /// </summary>
        OpticalFlowRead = 1 << 42, 
        
        /// <summary>
        /// 
        /// </summary>
        OpticalFlowWrite = 1 << 43, 
        
        /// <summary>
        /// 
        /// </summary>
        DataGraphRead = 1 << 47, 
        
        /// <summary>
        /// 
        /// </summary>
        DataGraphWrite = 1 << 48, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryDecompressionRead = 1 << 55, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryDecompressionWrite = 1 << 56, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved62 = 1 << 62, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved63 = 1 << 63, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved60 = 1 << 60, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved61 = 1 << 61, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved28 = 1 << 28, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved29 = 1 << 29, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved49 = 1 << 49, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved50 = 1 << 50, 
    }
}
