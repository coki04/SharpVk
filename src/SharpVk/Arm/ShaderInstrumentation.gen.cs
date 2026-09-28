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

namespace SharpVk.Arm
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ShaderInstrumentation
        : IDisposable
    {
        internal readonly SharpVk.Interop.Arm.ShaderInstrumentation handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        /// <summary>
        /// 
        /// </summary>
        public ShaderInstrumentation(SharpVk.Device parent, SharpVk.Interop.Arm.ShaderInstrumentation handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Arm.ShaderInstrumentation RawHandle => this.handle;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator">
        /// </param>
        public unsafe void Destroy(SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Arm.VkShaderInstrumentationARMDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyShaderInstrumentationARM;
                commandDelegate(this.parent.handle, this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="metricBlockCount">
        /// </param>
        /// <param name="metricValues">
        /// </param>
        /// <param name="flags">
        /// </param>
        public unsafe Result GetValues(uint metricBlockCount, IntPtr? metricValues = default(IntPtr?), SharpVk.Arm.ShaderInstrumentationValuesFlags? flags = default(SharpVk.Arm.ShaderInstrumentationValuesFlags?))
        {
            try
            {
                Result result = default(Result);
                uint* marshalledMetricBlockCount = default(uint*);
                void* marshalledMetricValues = default(void*);
                SharpVk.Arm.ShaderInstrumentationValuesFlags marshalledFlags = default(SharpVk.Arm.ShaderInstrumentationValuesFlags);
                marshalledMetricBlockCount = (uint*)(Interop.HeapUtil.Allocate<uint>());
                *marshalledMetricBlockCount = metricBlockCount;
                if (metricValues != null)
                {
                    marshalledMetricValues = metricValues.Value.ToPointer();
                }
                else
                {
                    marshalledMetricValues = default(void*);
                }
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.Arm.ShaderInstrumentationValuesFlags);
                }
                SharpVk.Interop.Arm.VkShaderInstrumentationARMGetValuesDelegate commandDelegate = commandCache.Cache.vkGetShaderInstrumentationValuesARM;
                result = commandDelegate(this.parent.handle, this.handle, marshalledMetricBlockCount, marshalledMetricValues, marshalledFlags);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void ClearMetrics()
        {
            try
            {
                SharpVk.Interop.Arm.VkShaderInstrumentationARMClearMetricsDelegate commandDelegate = commandCache.Cache.vkClearShaderInstrumentationMetricsARM;
                commandDelegate(this.parent.handle, this.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Destroys the handles and releases any unmanaged resources
        /// associated with it.
        /// </summary>
        public void Dispose()
        {
            this.Destroy();
        }
    }
}
