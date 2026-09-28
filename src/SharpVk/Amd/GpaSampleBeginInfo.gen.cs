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

namespace SharpVk.Amd
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GpaSampleBeginInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Amd.GpaSampleType SampleType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SampleInternalOperations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool CacheFlushOnCounterCollection
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SqShaderMaskEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Amd.GpaSqShaderStageFlags? SqShaderMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Amd.GpaPerfCounter[] PerfCounters
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint StreamingPerfTraceSampleInterval
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong PerfCounterDeviceMemoryLimit
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SqThreadTraceEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SqThreadTraceSuppressInstructionTokens
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong SqThreadTraceDeviceMemoryLimit
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineStageFlags? TimingPreSample
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineStageFlags? TimingPostSample
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Amd.GpaSampleBeginInfo* pointer)
        {
            pointer->SType = StructureType.GpaSampleBeginInfo;
            pointer->Next = null;
            pointer->SampleType = this.SampleType;
            pointer->SampleInternalOperations = this.SampleInternalOperations;
            pointer->CacheFlushOnCounterCollection = this.CacheFlushOnCounterCollection;
            pointer->SqShaderMaskEnable = this.SqShaderMaskEnable;
            if (this.SqShaderMask != null)
            {
                pointer->SqShaderMask = this.SqShaderMask.Value;
            }
            else
            {
                pointer->SqShaderMask = default(SharpVk.Amd.GpaSqShaderStageFlags);
            }
            pointer->PerfCounterCount = (uint)(Interop.HeapUtil.GetLength(this.PerfCounters));
            if (this.PerfCounters != null)
            {
                var fieldPointer = (SharpVk.Amd.GpaPerfCounter*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Amd.GpaPerfCounter>(this.PerfCounters.Length).ToPointer());
                for(int index = 0; index < (uint)(this.PerfCounters.Length); index++)
                {
                    fieldPointer[index] = this.PerfCounters[index];
                }
                pointer->PerfCounters = fieldPointer;
            }
            else
            {
                pointer->PerfCounters = null;
            }
            pointer->StreamingPerfTraceSampleInterval = this.StreamingPerfTraceSampleInterval;
            pointer->PerfCounterDeviceMemoryLimit = this.PerfCounterDeviceMemoryLimit;
            pointer->SqThreadTraceEnable = this.SqThreadTraceEnable;
            pointer->SqThreadTraceSuppressInstructionTokens = this.SqThreadTraceSuppressInstructionTokens;
            pointer->SqThreadTraceDeviceMemoryLimit = this.SqThreadTraceDeviceMemoryLimit;
            if (this.TimingPreSample != null)
            {
                pointer->TimingPreSample = this.TimingPreSample.Value;
            }
            else
            {
                pointer->TimingPreSample = default(SharpVk.PipelineStageFlags);
            }
            if (this.TimingPostSample != null)
            {
                pointer->TimingPostSample = this.TimingPostSample.Value;
            }
            else
            {
                pointer->TimingPostSample = default(SharpVk.PipelineStageFlags);
            }
        }
    }
}
