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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceDescriptorBufferProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public bool CombinedImageSamplerDescriptorSingleArray
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool BufferlessPushDescriptors
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool AllowSamplerImageViewPostSubmitCreation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong DescriptorBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorBufferBindings
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxResourceDescriptorBufferBindings
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSamplerDescriptorBufferBindings
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxEmbeddedImmutableSamplerBindings
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxEmbeddedImmutableSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize BufferCaptureReplayDescriptorDataSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize ImageCaptureReplayDescriptorDataSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize ImageViewCaptureReplayDescriptorDataSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize SamplerCaptureReplayDescriptorDataSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize AccelerationStructureCaptureReplayDescriptorDataSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize SamplerDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize CombinedImageSamplerDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize SampledImageDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize StorageImageDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize UniformTexelBufferDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize RobustUniformTexelBufferDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize StorageTexelBufferDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize RobustStorageTexelBufferDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize UniformBufferDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize RobustUniformBufferDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize StorageBufferDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize RobustStorageBufferDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize InputAttachmentDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize AccelerationStructureDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxSamplerDescriptorBufferRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxResourceDescriptorBufferRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong SamplerDescriptorBufferAddressSpaceSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong ResourceDescriptorBufferAddressSpaceSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong DescriptorBufferAddressSpaceSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceDescriptorBufferProperties MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceDescriptorBufferProperties* pointer)
        {
            PhysicalDeviceDescriptorBufferProperties result = default(PhysicalDeviceDescriptorBufferProperties);
            result.CombinedImageSamplerDescriptorSingleArray = pointer->CombinedImageSamplerDescriptorSingleArray;
            result.BufferlessPushDescriptors = pointer->BufferlessPushDescriptors;
            result.AllowSamplerImageViewPostSubmitCreation = pointer->AllowSamplerImageViewPostSubmitCreation;
            result.DescriptorBufferOffsetAlignment = pointer->DescriptorBufferOffsetAlignment;
            result.MaxDescriptorBufferBindings = pointer->MaxDescriptorBufferBindings;
            result.MaxResourceDescriptorBufferBindings = pointer->MaxResourceDescriptorBufferBindings;
            result.MaxSamplerDescriptorBufferBindings = pointer->MaxSamplerDescriptorBufferBindings;
            result.MaxEmbeddedImmutableSamplerBindings = pointer->MaxEmbeddedImmutableSamplerBindings;
            result.MaxEmbeddedImmutableSamplers = pointer->MaxEmbeddedImmutableSamplers;
            result.BufferCaptureReplayDescriptorDataSize = pointer->BufferCaptureReplayDescriptorDataSize;
            result.ImageCaptureReplayDescriptorDataSize = pointer->ImageCaptureReplayDescriptorDataSize;
            result.ImageViewCaptureReplayDescriptorDataSize = pointer->ImageViewCaptureReplayDescriptorDataSize;
            result.SamplerCaptureReplayDescriptorDataSize = pointer->SamplerCaptureReplayDescriptorDataSize;
            result.AccelerationStructureCaptureReplayDescriptorDataSize = pointer->AccelerationStructureCaptureReplayDescriptorDataSize;
            result.SamplerDescriptorSize = pointer->SamplerDescriptorSize;
            result.CombinedImageSamplerDescriptorSize = pointer->CombinedImageSamplerDescriptorSize;
            result.SampledImageDescriptorSize = pointer->SampledImageDescriptorSize;
            result.StorageImageDescriptorSize = pointer->StorageImageDescriptorSize;
            result.UniformTexelBufferDescriptorSize = pointer->UniformTexelBufferDescriptorSize;
            result.RobustUniformTexelBufferDescriptorSize = pointer->RobustUniformTexelBufferDescriptorSize;
            result.StorageTexelBufferDescriptorSize = pointer->StorageTexelBufferDescriptorSize;
            result.RobustStorageTexelBufferDescriptorSize = pointer->RobustStorageTexelBufferDescriptorSize;
            result.UniformBufferDescriptorSize = pointer->UniformBufferDescriptorSize;
            result.RobustUniformBufferDescriptorSize = pointer->RobustUniformBufferDescriptorSize;
            result.StorageBufferDescriptorSize = pointer->StorageBufferDescriptorSize;
            result.RobustStorageBufferDescriptorSize = pointer->RobustStorageBufferDescriptorSize;
            result.InputAttachmentDescriptorSize = pointer->InputAttachmentDescriptorSize;
            result.AccelerationStructureDescriptorSize = pointer->AccelerationStructureDescriptorSize;
            result.MaxSamplerDescriptorBufferRange = pointer->MaxSamplerDescriptorBufferRange;
            result.MaxResourceDescriptorBufferRange = pointer->MaxResourceDescriptorBufferRange;
            result.SamplerDescriptorBufferAddressSpaceSize = pointer->SamplerDescriptorBufferAddressSpaceSize;
            result.ResourceDescriptorBufferAddressSpaceSize = pointer->ResourceDescriptorBufferAddressSpaceSize;
            result.DescriptorBufferAddressSpaceSize = pointer->DescriptorBufferAddressSpaceSize;
            return result;
        }
    }
}
