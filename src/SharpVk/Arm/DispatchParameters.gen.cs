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
    public partial struct DispatchParameters
    {
        /// <summary>
        /// 
        /// </summary>
        public uint? WorkGroupBatchSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? MaxQueuedWorkGroupBatches
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? MaxWarpsPerShaderCore
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Arm.DispatchParameters* pointer)
        {
            pointer->SType = StructureType.DispatchParameters;
            pointer->Next = null;
            if (this.WorkGroupBatchSize != null)
            {
                pointer->WorkGroupBatchSize = this.WorkGroupBatchSize.Value;
            }
            else
            {
                pointer->WorkGroupBatchSize = default(uint);
            }
            if (this.MaxQueuedWorkGroupBatches != null)
            {
                pointer->MaxQueuedWorkGroupBatches = this.MaxQueuedWorkGroupBatches.Value;
            }
            else
            {
                pointer->MaxQueuedWorkGroupBatches = default(uint);
            }
            if (this.MaxWarpsPerShaderCore != null)
            {
                pointer->MaxWarpsPerShaderCore = this.MaxWarpsPerShaderCore.Value;
            }
            else
            {
                pointer->MaxWarpsPerShaderCore = default(uint);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe DispatchParameters MarshalFrom(SharpVk.Interop.Arm.DispatchParameters* pointer)
        {
            DispatchParameters result = default(DispatchParameters);
            result.WorkGroupBatchSize = pointer->WorkGroupBatchSize;
            result.MaxQueuedWorkGroupBatches = pointer->MaxQueuedWorkGroupBatches;
            result.MaxWarpsPerShaderCore = pointer->MaxWarpsPerShaderCore;
            return result;
        }
    }
}
