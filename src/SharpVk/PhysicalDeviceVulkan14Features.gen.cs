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
    public partial struct PhysicalDeviceVulkan14Features
    {
        /// <summary>
        /// 
        /// </summary>
        public bool GlobalPriorityQuery
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSubgroupRotate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSubgroupRotateClustered
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderFloatControls2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderExpectAssume
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool RectangularLines
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool BresenhamLines
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SmoothLines
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool StippledRectangularLines
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool StippledBresenhamLines
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool StippledSmoothLines
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool VertexAttributeInstanceRateDivisor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool VertexAttributeInstanceRateZeroDivisor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IndexTypeUint8
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DynamicRenderingLocalRead
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool Maintenance5
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool Maintenance6
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PipelineProtectedAccess
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PipelineRobustness
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool HostImageCopy
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PushDescriptor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.PhysicalDeviceVulkan14Features* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceVulkan14Features;
            pointer->Next = null;
            pointer->GlobalPriorityQuery = this.GlobalPriorityQuery;
            pointer->ShaderSubgroupRotate = this.ShaderSubgroupRotate;
            pointer->ShaderSubgroupRotateClustered = this.ShaderSubgroupRotateClustered;
            pointer->ShaderFloatControls2 = this.ShaderFloatControls2;
            pointer->ShaderExpectAssume = this.ShaderExpectAssume;
            pointer->RectangularLines = this.RectangularLines;
            pointer->BresenhamLines = this.BresenhamLines;
            pointer->SmoothLines = this.SmoothLines;
            pointer->StippledRectangularLines = this.StippledRectangularLines;
            pointer->StippledBresenhamLines = this.StippledBresenhamLines;
            pointer->StippledSmoothLines = this.StippledSmoothLines;
            pointer->VertexAttributeInstanceRateDivisor = this.VertexAttributeInstanceRateDivisor;
            pointer->VertexAttributeInstanceRateZeroDivisor = this.VertexAttributeInstanceRateZeroDivisor;
            pointer->IndexTypeUint8 = this.IndexTypeUint8;
            pointer->DynamicRenderingLocalRead = this.DynamicRenderingLocalRead;
            pointer->Maintenance5 = this.Maintenance5;
            pointer->Maintenance6 = this.Maintenance6;
            pointer->PipelineProtectedAccess = this.PipelineProtectedAccess;
            pointer->PipelineRobustness = this.PipelineRobustness;
            pointer->HostImageCopy = this.HostImageCopy;
            pointer->PushDescriptor = this.PushDescriptor;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceVulkan14Features MarshalFrom(SharpVk.Interop.PhysicalDeviceVulkan14Features* pointer)
        {
            PhysicalDeviceVulkan14Features result = default(PhysicalDeviceVulkan14Features);
            result.GlobalPriorityQuery = pointer->GlobalPriorityQuery;
            result.ShaderSubgroupRotate = pointer->ShaderSubgroupRotate;
            result.ShaderSubgroupRotateClustered = pointer->ShaderSubgroupRotateClustered;
            result.ShaderFloatControls2 = pointer->ShaderFloatControls2;
            result.ShaderExpectAssume = pointer->ShaderExpectAssume;
            result.RectangularLines = pointer->RectangularLines;
            result.BresenhamLines = pointer->BresenhamLines;
            result.SmoothLines = pointer->SmoothLines;
            result.StippledRectangularLines = pointer->StippledRectangularLines;
            result.StippledBresenhamLines = pointer->StippledBresenhamLines;
            result.StippledSmoothLines = pointer->StippledSmoothLines;
            result.VertexAttributeInstanceRateDivisor = pointer->VertexAttributeInstanceRateDivisor;
            result.VertexAttributeInstanceRateZeroDivisor = pointer->VertexAttributeInstanceRateZeroDivisor;
            result.IndexTypeUint8 = pointer->IndexTypeUint8;
            result.DynamicRenderingLocalRead = pointer->DynamicRenderingLocalRead;
            result.Maintenance5 = pointer->Maintenance5;
            result.Maintenance6 = pointer->Maintenance6;
            result.PipelineProtectedAccess = pointer->PipelineProtectedAccess;
            result.PipelineRobustness = pointer->PipelineRobustness;
            result.HostImageCopy = pointer->HostImageCopy;
            result.PushDescriptor = pointer->PushDescriptor;
            return result;
        }
    }
}
