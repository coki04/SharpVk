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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceDeviceGeneratedCommandsProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public uint MaxIndirectPipelineCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxIndirectShaderObjectCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxIndirectSequenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxIndirectCommandsTokenCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxIndirectCommandsTokenOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxIndirectCommandsIndirectStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.IndirectCommandsInputModeFlags SupportedIndirectCommandsInputModes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderStageFlags SupportedIndirectCommandsShaderStages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderStageFlags SupportedIndirectCommandsShaderStagesPipelineBinding
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderStageFlags SupportedIndirectCommandsShaderStagesShaderBinding
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DeviceGeneratedCommandsTransformFeedback
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DeviceGeneratedCommandsMultiDrawIndirectCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceDeviceGeneratedCommandsProperties MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceDeviceGeneratedCommandsProperties* pointer)
        {
            PhysicalDeviceDeviceGeneratedCommandsProperties result = default(PhysicalDeviceDeviceGeneratedCommandsProperties);
            result.MaxIndirectPipelineCount = pointer->MaxIndirectPipelineCount;
            result.MaxIndirectShaderObjectCount = pointer->MaxIndirectShaderObjectCount;
            result.MaxIndirectSequenceCount = pointer->MaxIndirectSequenceCount;
            result.MaxIndirectCommandsTokenCount = pointer->MaxIndirectCommandsTokenCount;
            result.MaxIndirectCommandsTokenOffset = pointer->MaxIndirectCommandsTokenOffset;
            result.MaxIndirectCommandsIndirectStride = pointer->MaxIndirectCommandsIndirectStride;
            result.SupportedIndirectCommandsInputModes = pointer->SupportedIndirectCommandsInputModes;
            result.SupportedIndirectCommandsShaderStages = pointer->SupportedIndirectCommandsShaderStages;
            result.SupportedIndirectCommandsShaderStagesPipelineBinding = pointer->SupportedIndirectCommandsShaderStagesPipelineBinding;
            result.SupportedIndirectCommandsShaderStagesShaderBinding = pointer->SupportedIndirectCommandsShaderStagesShaderBinding;
            result.DeviceGeneratedCommandsTransformFeedback = pointer->DeviceGeneratedCommandsTransformFeedback;
            result.DeviceGeneratedCommandsMultiDrawIndirectCount = pointer->DeviceGeneratedCommandsMultiDrawIndirectCount;
            return result;
        }
    }
}
