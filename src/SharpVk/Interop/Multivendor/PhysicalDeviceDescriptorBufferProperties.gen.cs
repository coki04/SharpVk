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

namespace SharpVk.Interop.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct PhysicalDeviceDescriptorBufferProperties
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
        public Bool32 CombinedImageSamplerDescriptorSingleArray; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 BufferlessPushDescriptors; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 AllowSamplerImageViewPostSubmitCreation; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong DescriptorBufferOffsetAlignment; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorBufferBindings; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxResourceDescriptorBufferBindings; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSamplerDescriptorBufferBindings; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxEmbeddedImmutableSamplerBindings; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxEmbeddedImmutableSamplers; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize BufferCaptureReplayDescriptorDataSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize ImageCaptureReplayDescriptorDataSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize ImageViewCaptureReplayDescriptorDataSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize SamplerCaptureReplayDescriptorDataSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize AccelerationStructureCaptureReplayDescriptorDataSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize SamplerDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize CombinedImageSamplerDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize SampledImageDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize StorageImageDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize UniformTexelBufferDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize RobustUniformTexelBufferDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize StorageTexelBufferDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize RobustStorageTexelBufferDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize UniformBufferDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize RobustUniformBufferDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize StorageBufferDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize RobustStorageBufferDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize InputAttachmentDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize AccelerationStructureDescriptorSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxSamplerDescriptorBufferRange; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxResourceDescriptorBufferRange; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong SamplerDescriptorBufferAddressSpaceSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong ResourceDescriptorBufferAddressSpaceSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong DescriptorBufferAddressSpaceSize; 
    }
}
