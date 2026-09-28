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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    public partial class IndirectExecutionSet
        : IDisposable
    {
        internal readonly SharpVk.Interop.Multivendor.IndirectExecutionSet handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        /// <summary>
        /// 
        /// </summary>
        public IndirectExecutionSet(SharpVk.Device parent, SharpVk.Interop.Multivendor.IndirectExecutionSet handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Multivendor.IndirectExecutionSet RawHandle => this.handle;
        
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
                SharpVk.Interop.Multivendor.VkIndirectExecutionSetEXTDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyIndirectExecutionSetEXT;
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
        /// <param name="executionSetWrites">
        /// </param>
        public unsafe void UpdatePipeline(ArrayProxy<SharpVk.Multivendor.WriteIndirectExecutionSetPipeline>? executionSetWrites)
        {
            try
            {
                SharpVk.Interop.Multivendor.WriteIndirectExecutionSetPipeline* marshalledExecutionSetWrites = default(SharpVk.Interop.Multivendor.WriteIndirectExecutionSetPipeline*);
                if (executionSetWrites.IsNull())
                {
                    marshalledExecutionSetWrites = null;
                }
                else
                {
                    if (executionSetWrites.Value.Contents == ProxyContents.Single)
                    {
                        marshalledExecutionSetWrites = (SharpVk.Interop.Multivendor.WriteIndirectExecutionSetPipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.WriteIndirectExecutionSetPipeline>());
                        executionSetWrites.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.WriteIndirectExecutionSetPipeline*)(marshalledExecutionSetWrites));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.WriteIndirectExecutionSetPipeline*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.WriteIndirectExecutionSetPipeline>(Interop.HeapUtil.GetLength(executionSetWrites.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(executionSetWrites.Value)); index++)
                        {
                            executionSetWrites.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledExecutionSetWrites = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkIndirectExecutionSetEXTUpdatePipelineDelegate commandDelegate = commandCache.Cache.vkUpdateIndirectExecutionSetPipelineEXT;
                commandDelegate(this.parent.handle, this.handle, (uint)(Interop.HeapUtil.GetLength(executionSetWrites)), marshalledExecutionSetWrites);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="executionSetWrites">
        /// </param>
        public unsafe void UpdateShader(ArrayProxy<SharpVk.Multivendor.WriteIndirectExecutionSetShader>? executionSetWrites)
        {
            try
            {
                SharpVk.Interop.Multivendor.WriteIndirectExecutionSetShader* marshalledExecutionSetWrites = default(SharpVk.Interop.Multivendor.WriteIndirectExecutionSetShader*);
                if (executionSetWrites.IsNull())
                {
                    marshalledExecutionSetWrites = null;
                }
                else
                {
                    if (executionSetWrites.Value.Contents == ProxyContents.Single)
                    {
                        marshalledExecutionSetWrites = (SharpVk.Interop.Multivendor.WriteIndirectExecutionSetShader*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.WriteIndirectExecutionSetShader>());
                        executionSetWrites.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.WriteIndirectExecutionSetShader*)(marshalledExecutionSetWrites));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.WriteIndirectExecutionSetShader*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.WriteIndirectExecutionSetShader>(Interop.HeapUtil.GetLength(executionSetWrites.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(executionSetWrites.Value)); index++)
                        {
                            executionSetWrites.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledExecutionSetWrites = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkIndirectExecutionSetEXTUpdateShaderDelegate commandDelegate = commandCache.Cache.vkUpdateIndirectExecutionSetShaderEXT;
                commandDelegate(this.parent.handle, this.handle, (uint)(Interop.HeapUtil.GetLength(executionSetWrites)), marshalledExecutionSetWrites);
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
