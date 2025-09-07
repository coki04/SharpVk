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

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct DeviceObjectReservationCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PipelineCacheCreateInfoCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.PipelineCacheCreateInfo* PipelineCacheCreateInfos; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PipelinePoolSizeCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.PipelinePoolSize* PipelinePoolSizes; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SemaphoreRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint CommandBufferRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint FenceRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DeviceMemoryRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint BufferRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ImageRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint EventRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint QueryPoolRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint BufferViewRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ImageViewRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint LayeredImageViewRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PipelineCacheRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PipelineLayoutRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint RenderPassRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint GraphicsPipelineRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ComputePipelineRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DescriptorSetLayoutRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SamplerRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DescriptorPoolRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DescriptorSetRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint FramebufferRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint CommandPoolRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SamplerYcbcrConversionRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SurfaceRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SwapchainRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DisplayModeRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SubpassDescriptionRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint AttachmentDescriptionRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DescriptorSetLayoutBindingRequestCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DescriptorSetLayoutBindingLimit; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageViewMipLevels; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageViewArrayLayers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxLayeredImageViewMipLevels; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxOcclusionQueriesPerPool; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPipelineStatisticsQueriesPerPool; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTimestampQueriesPerPool; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImmutableSamplersPerDescriptorSetLayout; 
    }
}
