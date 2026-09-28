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

namespace SharpVk.Arm
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceTensorProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTensorDimensionCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxTensorElements
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxPerDimensionTensorElements
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public long MaxTensorStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxTensorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTensorShaderAccessArrayLength
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTensorShaderAccessSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetStorageTensors
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorSetStorageTensors
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageTensors
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindStorageTensors
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderStorageTensorArrayNonUniformIndexingNative
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderStageFlags ShaderTensorSupportedStages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceTensorProperties MarshalFrom(SharpVk.Interop.Arm.PhysicalDeviceTensorProperties* pointer)
        {
            PhysicalDeviceTensorProperties result = default(PhysicalDeviceTensorProperties);
            result.MaxTensorDimensionCount = pointer->MaxTensorDimensionCount;
            result.MaxTensorElements = pointer->MaxTensorElements;
            result.MaxPerDimensionTensorElements = pointer->MaxPerDimensionTensorElements;
            result.MaxTensorStride = pointer->MaxTensorStride;
            result.MaxTensorSize = pointer->MaxTensorSize;
            result.MaxTensorShaderAccessArrayLength = pointer->MaxTensorShaderAccessArrayLength;
            result.MaxTensorShaderAccessSize = pointer->MaxTensorShaderAccessSize;
            result.MaxDescriptorSetStorageTensors = pointer->MaxDescriptorSetStorageTensors;
            result.MaxPerStageDescriptorSetStorageTensors = pointer->MaxPerStageDescriptorSetStorageTensors;
            result.MaxDescriptorSetUpdateAfterBindStorageTensors = pointer->MaxDescriptorSetUpdateAfterBindStorageTensors;
            result.MaxPerStageDescriptorUpdateAfterBindStorageTensors = pointer->MaxPerStageDescriptorUpdateAfterBindStorageTensors;
            result.ShaderStorageTensorArrayNonUniformIndexingNative = pointer->ShaderStorageTensorArrayNonUniformIndexingNative;
            result.ShaderTensorSupportedStages = pointer->ShaderTensorSupportedStages;
            return result;
        }
    }
}
