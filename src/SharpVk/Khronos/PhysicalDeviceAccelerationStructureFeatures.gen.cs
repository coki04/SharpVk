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
    public partial struct PhysicalDeviceAccelerationStructureFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public bool AccelerationStructure
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool AccelerationStructureCaptureReplay
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool AccelerationStructureIndirectBuild
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool AccelerationStructureHostCommands
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DescriptorBindingAccelerationStructureUpdateAfterBind
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.PhysicalDeviceAccelerationStructureFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceAccelerationStructureFeatures;
            pointer->Next = null;
            pointer->AccelerationStructure = this.AccelerationStructure;
            pointer->AccelerationStructureCaptureReplay = this.AccelerationStructureCaptureReplay;
            pointer->AccelerationStructureIndirectBuild = this.AccelerationStructureIndirectBuild;
            pointer->AccelerationStructureHostCommands = this.AccelerationStructureHostCommands;
            pointer->DescriptorBindingAccelerationStructureUpdateAfterBind = this.DescriptorBindingAccelerationStructureUpdateAfterBind;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceAccelerationStructureFeatures MarshalFrom(SharpVk.Interop.Khronos.PhysicalDeviceAccelerationStructureFeatures* pointer)
        {
            PhysicalDeviceAccelerationStructureFeatures result = default(PhysicalDeviceAccelerationStructureFeatures);
            result.AccelerationStructure = pointer->AccelerationStructure;
            result.AccelerationStructureCaptureReplay = pointer->AccelerationStructureCaptureReplay;
            result.AccelerationStructureIndirectBuild = pointer->AccelerationStructureIndirectBuild;
            result.AccelerationStructureHostCommands = pointer->AccelerationStructureHostCommands;
            result.DescriptorBindingAccelerationStructureUpdateAfterBind = pointer->DescriptorBindingAccelerationStructureUpdateAfterBind;
            return result;
        }
    }
}
