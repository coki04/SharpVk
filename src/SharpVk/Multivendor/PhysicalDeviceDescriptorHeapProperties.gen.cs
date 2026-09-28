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
    public partial struct PhysicalDeviceDescriptorHeapProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public ulong SamplerHeapAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong ResourceHeapAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxSamplerHeapSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxResourceHeapSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MinSamplerHeapReservedRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MinSamplerHeapReservedRangeWithEmbedded
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MinResourceHeapReservedRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong SamplerDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong ImageDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong BufferDescriptorSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong SamplerDescriptorAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong ImageDescriptorAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong BufferDescriptorAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxPushDataSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize ImageCaptureReplayOpaqueDataSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorHeapEmbeddedSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SamplerYcbcrConversionCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SparseDescriptorHeaps
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ProtectedDescriptorHeaps
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceDescriptorHeapProperties MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceDescriptorHeapProperties* pointer)
        {
            PhysicalDeviceDescriptorHeapProperties result = default(PhysicalDeviceDescriptorHeapProperties);
            result.SamplerHeapAlignment = pointer->SamplerHeapAlignment;
            result.ResourceHeapAlignment = pointer->ResourceHeapAlignment;
            result.MaxSamplerHeapSize = pointer->MaxSamplerHeapSize;
            result.MaxResourceHeapSize = pointer->MaxResourceHeapSize;
            result.MinSamplerHeapReservedRange = pointer->MinSamplerHeapReservedRange;
            result.MinSamplerHeapReservedRangeWithEmbedded = pointer->MinSamplerHeapReservedRangeWithEmbedded;
            result.MinResourceHeapReservedRange = pointer->MinResourceHeapReservedRange;
            result.SamplerDescriptorSize = pointer->SamplerDescriptorSize;
            result.ImageDescriptorSize = pointer->ImageDescriptorSize;
            result.BufferDescriptorSize = pointer->BufferDescriptorSize;
            result.SamplerDescriptorAlignment = pointer->SamplerDescriptorAlignment;
            result.ImageDescriptorAlignment = pointer->ImageDescriptorAlignment;
            result.BufferDescriptorAlignment = pointer->BufferDescriptorAlignment;
            result.MaxPushDataSize = pointer->MaxPushDataSize;
            result.ImageCaptureReplayOpaqueDataSize = pointer->ImageCaptureReplayOpaqueDataSize;
            result.MaxDescriptorHeapEmbeddedSamplers = pointer->MaxDescriptorHeapEmbeddedSamplers;
            result.SamplerYcbcrConversionCount = pointer->SamplerYcbcrConversionCount;
            result.SparseDescriptorHeaps = pointer->SparseDescriptorHeaps;
            result.ProtectedDescriptorHeaps = pointer->ProtectedDescriptorHeaps;
            return result;
        }
    }
}
