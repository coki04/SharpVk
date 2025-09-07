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

namespace SharpVk.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceDeviceGeneratedCommandsComputeFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public bool DeviceGeneratedCompute
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DeviceGeneratedComputePipelines
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DeviceGeneratedComputeCaptureReplay
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsComputeFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceDeviceGeneratedCommandsComputeFeatures;
            pointer->Next = null;
            pointer->DeviceGeneratedCompute = this.DeviceGeneratedCompute;
            pointer->DeviceGeneratedComputePipelines = this.DeviceGeneratedComputePipelines;
            pointer->DeviceGeneratedComputeCaptureReplay = this.DeviceGeneratedComputeCaptureReplay;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceDeviceGeneratedCommandsComputeFeatures MarshalFrom(SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsComputeFeatures* pointer)
        {
            PhysicalDeviceDeviceGeneratedCommandsComputeFeatures result = default(PhysicalDeviceDeviceGeneratedCommandsComputeFeatures);
            result.DeviceGeneratedCompute = pointer->DeviceGeneratedCompute;
            result.DeviceGeneratedComputePipelines = pointer->DeviceGeneratedComputePipelines;
            result.DeviceGeneratedComputeCaptureReplay = pointer->DeviceGeneratedComputeCaptureReplay;
            return result;
        }
    }
}
