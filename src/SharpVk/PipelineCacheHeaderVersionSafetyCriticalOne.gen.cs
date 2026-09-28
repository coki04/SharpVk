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
    public partial struct PipelineCacheHeaderVersionSafetyCriticalOne
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineCacheHeaderVersionOne HeaderVersionOne
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineCacheValidationVersion ValidationVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ImplementationData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PipelineIndexCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PipelineIndexStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong PipelineIndexOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.PipelineCacheHeaderVersionSafetyCriticalOne* pointer)
        {
            this.HeaderVersionOne.MarshalTo(&pointer->HeaderVersionOne);
            pointer->ValidationVersion = this.ValidationVersion;
            pointer->ImplementationData = this.ImplementationData;
            pointer->PipelineIndexCount = this.PipelineIndexCount;
            pointer->PipelineIndexStride = this.PipelineIndexStride;
            pointer->PipelineIndexOffset = this.PipelineIndexOffset;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PipelineCacheHeaderVersionSafetyCriticalOne MarshalFrom(SharpVk.Interop.PipelineCacheHeaderVersionSafetyCriticalOne* pointer)
        {
            PipelineCacheHeaderVersionSafetyCriticalOne result = default(PipelineCacheHeaderVersionSafetyCriticalOne);
            result.HeaderVersionOne = SharpVk.PipelineCacheHeaderVersionOne.MarshalFrom(&pointer->HeaderVersionOne);
            result.ValidationVersion = pointer->ValidationVersion;
            result.ImplementationData = pointer->ImplementationData;
            result.PipelineIndexCount = pointer->PipelineIndexCount;
            result.PipelineIndexStride = pointer->PipelineIndexStride;
            result.PipelineIndexOffset = pointer->PipelineIndexOffset;
            return result;
        }
    }
}
