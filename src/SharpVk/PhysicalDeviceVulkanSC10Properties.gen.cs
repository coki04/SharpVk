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
    public partial struct PhysicalDeviceVulkanSC10Properties
    {
        /// <summary>
        /// 
        /// </summary>
        public bool DeviceNoDynamicHostAllocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DeviceDestroyFreesMemory
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool CommandPoolMultipleCommandBuffersRecording
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool CommandPoolResetCommandBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool CommandBufferSimultaneousUse
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SecondaryCommandBufferNullOrImagelessFramebuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool RecycleDescriptorSetMemory
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool RecyclePipelineMemory
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxRenderPassSubpasses
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxRenderPassDependencies
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSubpassInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSubpassPreserveAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFramebufferAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetLayoutBindings
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxQueryFaultCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxCallbackFaultCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxCommandPoolCommandBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxCommandBufferSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceVulkanSC10Properties MarshalFrom(SharpVk.Interop.PhysicalDeviceVulkanSC10Properties* pointer)
        {
            PhysicalDeviceVulkanSC10Properties result = default(PhysicalDeviceVulkanSC10Properties);
            result.DeviceNoDynamicHostAllocations = pointer->DeviceNoDynamicHostAllocations;
            result.DeviceDestroyFreesMemory = pointer->DeviceDestroyFreesMemory;
            result.CommandPoolMultipleCommandBuffersRecording = pointer->CommandPoolMultipleCommandBuffersRecording;
            result.CommandPoolResetCommandBuffer = pointer->CommandPoolResetCommandBuffer;
            result.CommandBufferSimultaneousUse = pointer->CommandBufferSimultaneousUse;
            result.SecondaryCommandBufferNullOrImagelessFramebuffer = pointer->SecondaryCommandBufferNullOrImagelessFramebuffer;
            result.RecycleDescriptorSetMemory = pointer->RecycleDescriptorSetMemory;
            result.RecyclePipelineMemory = pointer->RecyclePipelineMemory;
            result.MaxRenderPassSubpasses = pointer->MaxRenderPassSubpasses;
            result.MaxRenderPassDependencies = pointer->MaxRenderPassDependencies;
            result.MaxSubpassInputAttachments = pointer->MaxSubpassInputAttachments;
            result.MaxSubpassPreserveAttachments = pointer->MaxSubpassPreserveAttachments;
            result.MaxFramebufferAttachments = pointer->MaxFramebufferAttachments;
            result.MaxDescriptorSetLayoutBindings = pointer->MaxDescriptorSetLayoutBindings;
            result.MaxQueryFaultCount = pointer->MaxQueryFaultCount;
            result.MaxCallbackFaultCount = pointer->MaxCallbackFaultCount;
            result.MaxCommandPoolCommandBuffers = pointer->MaxCommandPoolCommandBuffers;
            result.MaxCommandBufferSize = pointer->MaxCommandBufferSize;
            return result;
        }
    }
}
