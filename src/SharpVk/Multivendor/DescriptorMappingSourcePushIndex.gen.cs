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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DescriptorMappingSourcePushIndex
    {
        /// <summary>
        /// 
        /// </summary>
        public uint HeapOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PushOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint HeapIndexStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint HeapArrayStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SamplerCreateInfo? EmbeddedSampler
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool UseCombinedImageSamplerIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SamplerHeapOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SamplerPushOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SamplerHeapIndexStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SamplerHeapArrayStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.DescriptorMappingSourcePushIndex* pointer)
        {
            pointer->HeapOffset = this.HeapOffset;
            pointer->PushOffset = this.PushOffset;
            pointer->HeapIndexStride = this.HeapIndexStride;
            pointer->HeapArrayStride = this.HeapArrayStride;
            if (this.EmbeddedSampler != null)
            {
                pointer->EmbeddedSampler = (SharpVk.Interop.SamplerCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SamplerCreateInfo>());
                this.EmbeddedSampler.Value.MarshalTo(pointer->EmbeddedSampler);
            }
            else
            {
                pointer->EmbeddedSampler = default(SharpVk.Interop.SamplerCreateInfo*);
            }
            pointer->UseCombinedImageSamplerIndex = this.UseCombinedImageSamplerIndex;
            pointer->SamplerHeapOffset = this.SamplerHeapOffset;
            pointer->SamplerPushOffset = this.SamplerPushOffset;
            pointer->SamplerHeapIndexStride = this.SamplerHeapIndexStride;
            pointer->SamplerHeapArrayStride = this.SamplerHeapArrayStride;
        }
    }
}
