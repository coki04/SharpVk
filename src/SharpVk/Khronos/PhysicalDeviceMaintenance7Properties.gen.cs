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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceMaintenance7Properties
    {
        /// <summary>
        /// 
        /// </summary>
        public bool RobustFragmentShadingRateAttachmentAccess
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SeparateDepthStencilAttachmentAccess
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetTotalUniformBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetTotalStorageBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetTotalBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindTotalBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceMaintenance7Properties MarshalFrom(SharpVk.Interop.Khronos.PhysicalDeviceMaintenance7Properties* pointer)
        {
            PhysicalDeviceMaintenance7Properties result = default(PhysicalDeviceMaintenance7Properties);
            result.RobustFragmentShadingRateAttachmentAccess = pointer->RobustFragmentShadingRateAttachmentAccess;
            result.SeparateDepthStencilAttachmentAccess = pointer->SeparateDepthStencilAttachmentAccess;
            result.MaxDescriptorSetTotalUniformBuffersDynamic = pointer->MaxDescriptorSetTotalUniformBuffersDynamic;
            result.MaxDescriptorSetTotalStorageBuffersDynamic = pointer->MaxDescriptorSetTotalStorageBuffersDynamic;
            result.MaxDescriptorSetTotalBuffersDynamic = pointer->MaxDescriptorSetTotalBuffersDynamic;
            result.MaxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic = pointer->MaxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;
            result.MaxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic = pointer->MaxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;
            result.MaxDescriptorSetUpdateAfterBindTotalBuffersDynamic = pointer->MaxDescriptorSetUpdateAfterBindTotalBuffersDynamic;
            return result;
        }
    }
}
