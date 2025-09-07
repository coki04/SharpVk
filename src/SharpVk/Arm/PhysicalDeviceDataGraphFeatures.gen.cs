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

namespace SharpVk.Arm
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceDataGraphFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public bool DataGraph
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DataGraphUpdateAfterBind
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DataGraphSpecializationConstants
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DataGraphDescriptorBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DataGraphShaderModule
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Arm.PhysicalDeviceDataGraphFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceDataGraphFeatures;
            pointer->Next = null;
            pointer->DataGraph = this.DataGraph;
            pointer->DataGraphUpdateAfterBind = this.DataGraphUpdateAfterBind;
            pointer->DataGraphSpecializationConstants = this.DataGraphSpecializationConstants;
            pointer->DataGraphDescriptorBuffer = this.DataGraphDescriptorBuffer;
            pointer->DataGraphShaderModule = this.DataGraphShaderModule;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceDataGraphFeatures MarshalFrom(SharpVk.Interop.Arm.PhysicalDeviceDataGraphFeatures* pointer)
        {
            PhysicalDeviceDataGraphFeatures result = default(PhysicalDeviceDataGraphFeatures);
            result.DataGraph = pointer->DataGraph;
            result.DataGraphUpdateAfterBind = pointer->DataGraphUpdateAfterBind;
            result.DataGraphSpecializationConstants = pointer->DataGraphSpecializationConstants;
            result.DataGraphDescriptorBuffer = pointer->DataGraphDescriptorBuffer;
            result.DataGraphShaderModule = pointer->DataGraphShaderModule;
            return result;
        }
    }
}
