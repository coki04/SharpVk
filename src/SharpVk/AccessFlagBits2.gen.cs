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
    public enum AccessFlagBits2
    {
        /// <summary>
        /// 
        /// </summary>
        Access2None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2IndirectCommandRead = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2IndexRead = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2VertexAttributeRead = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2UniformRead = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2InputAttachmentRead = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2ShaderRead = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2ShaderWrite = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2ColorAttachmentRead = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2ColorAttachmentWrite = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2DepthStencilAttachmentRead = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2DepthStencilAttachmentWrite = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2TransferRead = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2TransferWrite = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2HostRead = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2HostWrite = 1 << 14, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2MemoryRead = 1 << 15, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2MemoryWrite = 1 << 16, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2ShaderSampledRead = 1 << 32, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2ShaderStorageRead = 1 << 33, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2ShaderStorageWrite = 1 << 34, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2VideoDecodeRead = 1 << 35, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2VideoDecodeWrite = 1 << 36, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2Reserved46 = 1 << 46, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2VideoEncodeRead = 1 << 37, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2VideoEncodeWrite = 1 << 38, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2TransformFeedbackWrite = 1 << 25, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2TransformFeedbackCounterRead = 1 << 26, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2TransformFeedbackCounterWrite = 1 << 27, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2ConditionalRenderingRead = 1 << 20, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2CommandPreprocessRead = 1 << 17, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2CommandPreprocessWrite = 1 << 18, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2FragmentShadingRateAttachmentRead = 1 << 23, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2AccelerationStructureRead = 1 << 21, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2AccelerationStructureWrite = 1 << 22, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2FragmentDensityMapRead = 1 << 24, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2ColorAttachmentReadNoncoherent = 1 << 19, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2Reserved41 = 1 << 41, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2InvocationMaskRead = 1 << 39, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2ShaderBindingTableRead = 1 << 40, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2MicromapRead = 1 << 44, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2MicromapWrite = 1 << 45, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2OpticalFlowRead = 1 << 42, 
        
        /// <summary>
        /// 
        /// </summary>
        Access2OpticalFlowWrite = 1 << 43, 
    }
}
