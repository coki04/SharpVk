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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceAccelerationStructureProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxGeometryCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxInstanceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxPrimitiveCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorAccelerationStructures
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindAccelerationStructures
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetAccelerationStructures
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindAccelerationStructures
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinAccelerationStructureScratchOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceAccelerationStructureProperties MarshalFrom(SharpVk.Interop.Khronos.PhysicalDeviceAccelerationStructureProperties* pointer)
        {
            PhysicalDeviceAccelerationStructureProperties result = default(PhysicalDeviceAccelerationStructureProperties);
            result.MaxGeometryCount = pointer->MaxGeometryCount;
            result.MaxInstanceCount = pointer->MaxInstanceCount;
            result.MaxPrimitiveCount = pointer->MaxPrimitiveCount;
            result.MaxPerStageDescriptorAccelerationStructures = pointer->MaxPerStageDescriptorAccelerationStructures;
            result.MaxPerStageDescriptorUpdateAfterBindAccelerationStructures = pointer->MaxPerStageDescriptorUpdateAfterBindAccelerationStructures;
            result.MaxDescriptorSetAccelerationStructures = pointer->MaxDescriptorSetAccelerationStructures;
            result.MaxDescriptorSetUpdateAfterBindAccelerationStructures = pointer->MaxDescriptorSetUpdateAfterBindAccelerationStructures;
            result.MinAccelerationStructureScratchOffsetAlignment = pointer->MinAccelerationStructureScratchOffsetAlignment;
            return result;
        }
    }
}
