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
    public partial struct QueueFamilyDataGraphOpticalFlowProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.DataGraphOpticalFlowGridSizeFlags SupportedOutputGridSizes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.DataGraphOpticalFlowGridSizeFlags SupportedHintGridSizes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool HintSupported
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool CostSupported
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinWidth
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinHeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxWidth
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxHeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe QueueFamilyDataGraphOpticalFlowProperties MarshalFrom(SharpVk.Interop.Arm.QueueFamilyDataGraphOpticalFlowProperties* pointer)
        {
            QueueFamilyDataGraphOpticalFlowProperties result = default(QueueFamilyDataGraphOpticalFlowProperties);
            result.SupportedOutputGridSizes = pointer->SupportedOutputGridSizes;
            result.SupportedHintGridSizes = pointer->SupportedHintGridSizes;
            result.HintSupported = pointer->HintSupported;
            result.CostSupported = pointer->CostSupported;
            result.MinWidth = pointer->MinWidth;
            result.MinHeight = pointer->MinHeight;
            result.MaxWidth = pointer->MaxWidth;
            result.MaxHeight = pointer->MaxHeight;
            return result;
        }
    }
}
