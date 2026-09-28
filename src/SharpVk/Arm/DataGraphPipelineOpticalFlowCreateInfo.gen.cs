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
    public partial struct DataGraphPipelineOpticalFlowCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public uint Width
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Height
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Format ImageFormat
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Format FlowVectorFormat
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Format? CostFormat
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.DataGraphOpticalFlowGridSizeFlags OutputGridSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.DataGraphOpticalFlowGridSizeFlags HintGridSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.DataGraphOpticalFlowPerformanceLevel? PerformanceLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.DataGraphOpticalFlowCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Arm.DataGraphPipelineOpticalFlowCreateInfo* pointer)
        {
            pointer->SType = StructureType.DataGraphPipelineOpticalFlowCreateInfo;
            pointer->Next = null;
            pointer->Width = this.Width;
            pointer->Height = this.Height;
            pointer->ImageFormat = this.ImageFormat;
            pointer->FlowVectorFormat = this.FlowVectorFormat;
            if (this.CostFormat != null)
            {
                pointer->CostFormat = this.CostFormat.Value;
            }
            else
            {
                pointer->CostFormat = default(SharpVk.Format);
            }
            pointer->OutputGridSize = this.OutputGridSize;
            pointer->HintGridSize = this.HintGridSize;
            if (this.PerformanceLevel != null)
            {
                pointer->PerformanceLevel = this.PerformanceLevel.Value;
            }
            else
            {
                pointer->PerformanceLevel = default(SharpVk.Arm.DataGraphOpticalFlowPerformanceLevel);
            }
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Arm.DataGraphOpticalFlowCreateFlags);
            }
        }
    }
}
