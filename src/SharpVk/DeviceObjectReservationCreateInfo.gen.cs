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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DeviceObjectReservationCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineCacheCreateInfo[] PipelineCacheCreateInfos
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelinePoolSize[] PipelinePoolSizes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? SemaphoreRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? CommandBufferRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? FenceRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? DeviceMemoryRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? BufferRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? ImageRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? EventRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? QueryPoolRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? BufferViewRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? ImageViewRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? LayeredImageViewRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? PipelineCacheRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? PipelineLayoutRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? RenderPassRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? GraphicsPipelineRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? ComputePipelineRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? DescriptorSetLayoutRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? SamplerRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? DescriptorPoolRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? DescriptorSetRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? FramebufferRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? CommandPoolRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? SamplerYcbcrConversionRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? SurfaceRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? SwapchainRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? DisplayModeRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? SubpassDescriptionRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? AttachmentDescriptionRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? DescriptorSetLayoutBindingRequestCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint DescriptorSetLayoutBindingLimit
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageViewMipLevels
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageViewArrayLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxLayeredImageViewMipLevels
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxOcclusionQueriesPerPool
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPipelineStatisticsQueriesPerPool
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTimestampQueriesPerPool
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImmutableSamplersPerDescriptorSetLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.DeviceObjectReservationCreateInfo* pointer)
        {
            pointer->SType = StructureType.DeviceObjectReservationCreateInfo;
            pointer->Next = null;
            pointer->PipelineCacheCreateInfoCount = (uint)(Interop.HeapUtil.GetLength(this.PipelineCacheCreateInfos));
            if (this.PipelineCacheCreateInfos != null)
            {
                var fieldPointer = (SharpVk.Interop.PipelineCacheCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.PipelineCacheCreateInfo>(this.PipelineCacheCreateInfos.Length).ToPointer());
                for(int index = 0; index < (uint)(this.PipelineCacheCreateInfos.Length); index++)
                {
                    this.PipelineCacheCreateInfos[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->PipelineCacheCreateInfos = fieldPointer;
            }
            else
            {
                pointer->PipelineCacheCreateInfos = null;
            }
            pointer->PipelinePoolSizeCount = (uint)(Interop.HeapUtil.GetLength(this.PipelinePoolSizes));
            if (this.PipelinePoolSizes != null)
            {
                var fieldPointer = (SharpVk.Interop.PipelinePoolSize*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.PipelinePoolSize>(this.PipelinePoolSizes.Length).ToPointer());
                for(int index = 0; index < (uint)(this.PipelinePoolSizes.Length); index++)
                {
                    this.PipelinePoolSizes[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->PipelinePoolSizes = fieldPointer;
            }
            else
            {
                pointer->PipelinePoolSizes = null;
            }
            if (this.SemaphoreRequestCount != null)
            {
                pointer->SemaphoreRequestCount = this.SemaphoreRequestCount.Value;
            }
            else
            {
                pointer->SemaphoreRequestCount = default(uint);
            }
            if (this.CommandBufferRequestCount != null)
            {
                pointer->CommandBufferRequestCount = this.CommandBufferRequestCount.Value;
            }
            else
            {
                pointer->CommandBufferRequestCount = default(uint);
            }
            if (this.FenceRequestCount != null)
            {
                pointer->FenceRequestCount = this.FenceRequestCount.Value;
            }
            else
            {
                pointer->FenceRequestCount = default(uint);
            }
            if (this.DeviceMemoryRequestCount != null)
            {
                pointer->DeviceMemoryRequestCount = this.DeviceMemoryRequestCount.Value;
            }
            else
            {
                pointer->DeviceMemoryRequestCount = default(uint);
            }
            if (this.BufferRequestCount != null)
            {
                pointer->BufferRequestCount = this.BufferRequestCount.Value;
            }
            else
            {
                pointer->BufferRequestCount = default(uint);
            }
            if (this.ImageRequestCount != null)
            {
                pointer->ImageRequestCount = this.ImageRequestCount.Value;
            }
            else
            {
                pointer->ImageRequestCount = default(uint);
            }
            if (this.EventRequestCount != null)
            {
                pointer->EventRequestCount = this.EventRequestCount.Value;
            }
            else
            {
                pointer->EventRequestCount = default(uint);
            }
            if (this.QueryPoolRequestCount != null)
            {
                pointer->QueryPoolRequestCount = this.QueryPoolRequestCount.Value;
            }
            else
            {
                pointer->QueryPoolRequestCount = default(uint);
            }
            if (this.BufferViewRequestCount != null)
            {
                pointer->BufferViewRequestCount = this.BufferViewRequestCount.Value;
            }
            else
            {
                pointer->BufferViewRequestCount = default(uint);
            }
            if (this.ImageViewRequestCount != null)
            {
                pointer->ImageViewRequestCount = this.ImageViewRequestCount.Value;
            }
            else
            {
                pointer->ImageViewRequestCount = default(uint);
            }
            if (this.LayeredImageViewRequestCount != null)
            {
                pointer->LayeredImageViewRequestCount = this.LayeredImageViewRequestCount.Value;
            }
            else
            {
                pointer->LayeredImageViewRequestCount = default(uint);
            }
            if (this.PipelineCacheRequestCount != null)
            {
                pointer->PipelineCacheRequestCount = this.PipelineCacheRequestCount.Value;
            }
            else
            {
                pointer->PipelineCacheRequestCount = default(uint);
            }
            if (this.PipelineLayoutRequestCount != null)
            {
                pointer->PipelineLayoutRequestCount = this.PipelineLayoutRequestCount.Value;
            }
            else
            {
                pointer->PipelineLayoutRequestCount = default(uint);
            }
            if (this.RenderPassRequestCount != null)
            {
                pointer->RenderPassRequestCount = this.RenderPassRequestCount.Value;
            }
            else
            {
                pointer->RenderPassRequestCount = default(uint);
            }
            if (this.GraphicsPipelineRequestCount != null)
            {
                pointer->GraphicsPipelineRequestCount = this.GraphicsPipelineRequestCount.Value;
            }
            else
            {
                pointer->GraphicsPipelineRequestCount = default(uint);
            }
            if (this.ComputePipelineRequestCount != null)
            {
                pointer->ComputePipelineRequestCount = this.ComputePipelineRequestCount.Value;
            }
            else
            {
                pointer->ComputePipelineRequestCount = default(uint);
            }
            if (this.DescriptorSetLayoutRequestCount != null)
            {
                pointer->DescriptorSetLayoutRequestCount = this.DescriptorSetLayoutRequestCount.Value;
            }
            else
            {
                pointer->DescriptorSetLayoutRequestCount = default(uint);
            }
            if (this.SamplerRequestCount != null)
            {
                pointer->SamplerRequestCount = this.SamplerRequestCount.Value;
            }
            else
            {
                pointer->SamplerRequestCount = default(uint);
            }
            if (this.DescriptorPoolRequestCount != null)
            {
                pointer->DescriptorPoolRequestCount = this.DescriptorPoolRequestCount.Value;
            }
            else
            {
                pointer->DescriptorPoolRequestCount = default(uint);
            }
            if (this.DescriptorSetRequestCount != null)
            {
                pointer->DescriptorSetRequestCount = this.DescriptorSetRequestCount.Value;
            }
            else
            {
                pointer->DescriptorSetRequestCount = default(uint);
            }
            if (this.FramebufferRequestCount != null)
            {
                pointer->FramebufferRequestCount = this.FramebufferRequestCount.Value;
            }
            else
            {
                pointer->FramebufferRequestCount = default(uint);
            }
            if (this.CommandPoolRequestCount != null)
            {
                pointer->CommandPoolRequestCount = this.CommandPoolRequestCount.Value;
            }
            else
            {
                pointer->CommandPoolRequestCount = default(uint);
            }
            if (this.SamplerYcbcrConversionRequestCount != null)
            {
                pointer->SamplerYcbcrConversionRequestCount = this.SamplerYcbcrConversionRequestCount.Value;
            }
            else
            {
                pointer->SamplerYcbcrConversionRequestCount = default(uint);
            }
            if (this.SurfaceRequestCount != null)
            {
                pointer->SurfaceRequestCount = this.SurfaceRequestCount.Value;
            }
            else
            {
                pointer->SurfaceRequestCount = default(uint);
            }
            if (this.SwapchainRequestCount != null)
            {
                pointer->SwapchainRequestCount = this.SwapchainRequestCount.Value;
            }
            else
            {
                pointer->SwapchainRequestCount = default(uint);
            }
            if (this.DisplayModeRequestCount != null)
            {
                pointer->DisplayModeRequestCount = this.DisplayModeRequestCount.Value;
            }
            else
            {
                pointer->DisplayModeRequestCount = default(uint);
            }
            if (this.SubpassDescriptionRequestCount != null)
            {
                pointer->SubpassDescriptionRequestCount = this.SubpassDescriptionRequestCount.Value;
            }
            else
            {
                pointer->SubpassDescriptionRequestCount = default(uint);
            }
            if (this.AttachmentDescriptionRequestCount != null)
            {
                pointer->AttachmentDescriptionRequestCount = this.AttachmentDescriptionRequestCount.Value;
            }
            else
            {
                pointer->AttachmentDescriptionRequestCount = default(uint);
            }
            if (this.DescriptorSetLayoutBindingRequestCount != null)
            {
                pointer->DescriptorSetLayoutBindingRequestCount = this.DescriptorSetLayoutBindingRequestCount.Value;
            }
            else
            {
                pointer->DescriptorSetLayoutBindingRequestCount = default(uint);
            }
            pointer->DescriptorSetLayoutBindingLimit = this.DescriptorSetLayoutBindingLimit;
            pointer->MaxImageViewMipLevels = this.MaxImageViewMipLevels;
            pointer->MaxImageViewArrayLayers = this.MaxImageViewArrayLayers;
            pointer->MaxLayeredImageViewMipLevels = this.MaxLayeredImageViewMipLevels;
            pointer->MaxOcclusionQueriesPerPool = this.MaxOcclusionQueriesPerPool;
            pointer->MaxPipelineStatisticsQueriesPerPool = this.MaxPipelineStatisticsQueriesPerPool;
            pointer->MaxTimestampQueriesPerPool = this.MaxTimestampQueriesPerPool;
            pointer->MaxImmutableSamplersPerDescriptorSetLayout = this.MaxImmutableSamplersPerDescriptorSetLayout;
        }
    }
}
