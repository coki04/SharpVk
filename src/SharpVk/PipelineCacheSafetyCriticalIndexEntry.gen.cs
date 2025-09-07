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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PipelineCacheSafetyCriticalIndexEntry
    {
        /// <summary>
        /// 
        /// </summary>
        public byte[] PipelineIdentifier
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong PipelineMemorySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong JsonSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong JsonOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint StageIndexCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint StageIndexStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong StageIndexOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.PipelineCacheSafetyCriticalIndexEntry* pointer)
        {
            Interop.HeapUtil.MarshalTo(this.PipelineIdentifier, Constants.UuidSize, pointer->PipelineIdentifier);
            pointer->PipelineMemorySize = this.PipelineMemorySize;
            pointer->JsonSize = this.JsonSize;
            pointer->JsonOffset = this.JsonOffset;
            pointer->StageIndexCount = this.StageIndexCount;
            pointer->StageIndexStride = this.StageIndexStride;
            pointer->StageIndexOffset = this.StageIndexOffset;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PipelineCacheSafetyCriticalIndexEntry MarshalFrom(SharpVk.Interop.PipelineCacheSafetyCriticalIndexEntry* pointer)
        {
            PipelineCacheSafetyCriticalIndexEntry result = default(PipelineCacheSafetyCriticalIndexEntry);
            result.PipelineIdentifier = Interop.HeapUtil.MarshalFrom(pointer->PipelineIdentifier, Constants.UuidSize);
            result.PipelineMemorySize = pointer->PipelineMemorySize;
            result.JsonSize = pointer->JsonSize;
            result.JsonOffset = pointer->JsonOffset;
            result.StageIndexCount = pointer->StageIndexCount;
            result.StageIndexStride = pointer->StageIndexStride;
            result.StageIndexOffset = pointer->StageIndexOffset;
            return result;
        }
    }
}
