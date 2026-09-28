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
    public partial struct PhysicalDeviceVulkan14Properties
    {
        /// <summary>
        /// 
        /// </summary>
        public uint LineSubPixelPrecisionBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVertexAttribDivisor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SupportsNonZeroFirstInstance
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPushDescriptors
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DynamicRenderingLocalReadDepthStencilAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DynamicRenderingLocalReadMultisampledAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool EarlyFragmentMultisampleCoverageAfterSampleCounting
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool EarlyFragmentSampleMaskTestBeforeSampleCounting
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DepthStencilSwizzleOneSupport
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PolygonModePointSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool NonStrictSinglePixelWideLinesUseParallelogram
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool NonStrictWideLinesUseParallelogram
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool BlockTexelViewCompatibleMultipleLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxCombinedImageSamplerDescriptorCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool FragmentShadingRateClampCombinerInputs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineRobustnessBufferBehavior DefaultRobustnessStorageBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineRobustnessBufferBehavior DefaultRobustnessUniformBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineRobustnessBufferBehavior DefaultRobustnessVertexInputs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineRobustnessImageBehavior DefaultRobustnessImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ImageLayout[] CopySourceLayouts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ImageLayout[] CopyDestinationLayouts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Guid OptimalTilingLayoutUUID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IdenticalMemoryTypeRequirements
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceVulkan14Properties MarshalFrom(SharpVk.Interop.PhysicalDeviceVulkan14Properties* pointer)
        {
            PhysicalDeviceVulkan14Properties result = default(PhysicalDeviceVulkan14Properties);
            result.LineSubPixelPrecisionBits = pointer->LineSubPixelPrecisionBits;
            result.MaxVertexAttribDivisor = pointer->MaxVertexAttribDivisor;
            result.SupportsNonZeroFirstInstance = pointer->SupportsNonZeroFirstInstance;
            result.MaxPushDescriptors = pointer->MaxPushDescriptors;
            result.DynamicRenderingLocalReadDepthStencilAttachments = pointer->DynamicRenderingLocalReadDepthStencilAttachments;
            result.DynamicRenderingLocalReadMultisampledAttachments = pointer->DynamicRenderingLocalReadMultisampledAttachments;
            result.EarlyFragmentMultisampleCoverageAfterSampleCounting = pointer->EarlyFragmentMultisampleCoverageAfterSampleCounting;
            result.EarlyFragmentSampleMaskTestBeforeSampleCounting = pointer->EarlyFragmentSampleMaskTestBeforeSampleCounting;
            result.DepthStencilSwizzleOneSupport = pointer->DepthStencilSwizzleOneSupport;
            result.PolygonModePointSize = pointer->PolygonModePointSize;
            result.NonStrictSinglePixelWideLinesUseParallelogram = pointer->NonStrictSinglePixelWideLinesUseParallelogram;
            result.NonStrictWideLinesUseParallelogram = pointer->NonStrictWideLinesUseParallelogram;
            result.BlockTexelViewCompatibleMultipleLayers = pointer->BlockTexelViewCompatibleMultipleLayers;
            result.MaxCombinedImageSamplerDescriptorCount = pointer->MaxCombinedImageSamplerDescriptorCount;
            result.FragmentShadingRateClampCombinerInputs = pointer->FragmentShadingRateClampCombinerInputs;
            result.DefaultRobustnessStorageBuffers = pointer->DefaultRobustnessStorageBuffers;
            result.DefaultRobustnessUniformBuffers = pointer->DefaultRobustnessUniformBuffers;
            result.DefaultRobustnessVertexInputs = pointer->DefaultRobustnessVertexInputs;
            result.DefaultRobustnessImages = pointer->DefaultRobustnessImages;
            if (pointer->CopySourceLayouts != null)
            {
                var fieldPointer = new SharpVk.ImageLayout[(uint)(pointer->CopySourceLayoutCount)];
                for(int index = 0; index < (uint)(pointer->CopySourceLayoutCount); index++)
                {
                    fieldPointer[index] = pointer->CopySourceLayouts[index];
                }
                result.CopySourceLayouts = fieldPointer;
            }
            else
            {
                result.CopySourceLayouts = null;
            }
            if (pointer->CopyDestinationLayouts != null)
            {
                var fieldPointer = new SharpVk.ImageLayout[(uint)(pointer->CopyDestinationLayoutCount)];
                for(int index = 0; index < (uint)(pointer->CopyDestinationLayoutCount); index++)
                {
                    fieldPointer[index] = pointer->CopyDestinationLayouts[index];
                }
                result.CopyDestinationLayouts = fieldPointer;
            }
            else
            {
                result.CopyDestinationLayouts = null;
            }
            result.OptimalTilingLayoutUUID = new Guid(Interop.HeapUtil.MarshalFrom(pointer->OptimalTilingLayoutUUID, checked((int)Constants.UuidSize)));
            result.IdenticalMemoryTypeRequirements = pointer->IdenticalMemoryTypeRequirements;
            return result;
        }
    }
}
