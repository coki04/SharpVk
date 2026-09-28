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
    public partial struct PhysicalDeviceVulkan13Features
    {
        /// <summary>
        /// 
        /// </summary>
        public bool RobustImageAccess
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool InlineUniformBlock
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DescriptorBindingInlineUniformBlockUpdateAfterBind
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PipelineCreationCacheControl
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PrivateData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderDemoteToHelperInvocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderTerminateInvocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SubgroupSizeControl
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ComputeFullSubgroups
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool Synchronization2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TexturecompressionastcHdr
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderZeroInitializeWorkgroupMemory
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DynamicRendering
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderIntegerDotProduct
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool Maintenance4
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.PhysicalDeviceVulkan13Features* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceVulkan13Features;
            pointer->Next = null;
            pointer->RobustImageAccess = this.RobustImageAccess;
            pointer->InlineUniformBlock = this.InlineUniformBlock;
            pointer->DescriptorBindingInlineUniformBlockUpdateAfterBind = this.DescriptorBindingInlineUniformBlockUpdateAfterBind;
            pointer->PipelineCreationCacheControl = this.PipelineCreationCacheControl;
            pointer->PrivateData = this.PrivateData;
            pointer->ShaderDemoteToHelperInvocation = this.ShaderDemoteToHelperInvocation;
            pointer->ShaderTerminateInvocation = this.ShaderTerminateInvocation;
            pointer->SubgroupSizeControl = this.SubgroupSizeControl;
            pointer->ComputeFullSubgroups = this.ComputeFullSubgroups;
            pointer->Synchronization2 = this.Synchronization2;
            pointer->TexturecompressionastcHdr = this.TexturecompressionastcHdr;
            pointer->ShaderZeroInitializeWorkgroupMemory = this.ShaderZeroInitializeWorkgroupMemory;
            pointer->DynamicRendering = this.DynamicRendering;
            pointer->ShaderIntegerDotProduct = this.ShaderIntegerDotProduct;
            pointer->Maintenance4 = this.Maintenance4;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceVulkan13Features MarshalFrom(SharpVk.Interop.PhysicalDeviceVulkan13Features* pointer)
        {
            PhysicalDeviceVulkan13Features result = default(PhysicalDeviceVulkan13Features);
            result.RobustImageAccess = pointer->RobustImageAccess;
            result.InlineUniformBlock = pointer->InlineUniformBlock;
            result.DescriptorBindingInlineUniformBlockUpdateAfterBind = pointer->DescriptorBindingInlineUniformBlockUpdateAfterBind;
            result.PipelineCreationCacheControl = pointer->PipelineCreationCacheControl;
            result.PrivateData = pointer->PrivateData;
            result.ShaderDemoteToHelperInvocation = pointer->ShaderDemoteToHelperInvocation;
            result.ShaderTerminateInvocation = pointer->ShaderTerminateInvocation;
            result.SubgroupSizeControl = pointer->SubgroupSizeControl;
            result.ComputeFullSubgroups = pointer->ComputeFullSubgroups;
            result.Synchronization2 = pointer->Synchronization2;
            result.TexturecompressionastcHdr = pointer->TexturecompressionastcHdr;
            result.ShaderZeroInitializeWorkgroupMemory = pointer->ShaderZeroInitializeWorkgroupMemory;
            result.DynamicRendering = pointer->DynamicRendering;
            result.ShaderIntegerDotProduct = pointer->ShaderIntegerDotProduct;
            result.Maintenance4 = pointer->Maintenance4;
            return result;
        }
    }
}
