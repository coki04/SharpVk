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

namespace SharpVk.Fuchsia
{
    /// <summary>
    /// 
    /// </summary>
    public partial class BufferCollection
        : IDisposable
    {
        internal readonly SharpVk.Interop.Fuchsia.BufferCollection handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        /// <summary>
        /// 
        /// </summary>
        public BufferCollection(SharpVk.Device parent, SharpVk.Interop.Fuchsia.BufferCollection handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Fuchsia.BufferCollection RawHandle => this.handle;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageConstraintsInfo">
        /// </param>
        public unsafe void SetImageConstraints(SharpVk.Fuchsia.ImageConstraintsInfo imageConstraintsInfo)
        {
            try
            {
                SharpVk.Interop.Fuchsia.ImageConstraintsInfo* marshalledImageConstraintsInfo = default(SharpVk.Interop.Fuchsia.ImageConstraintsInfo*);
                marshalledImageConstraintsInfo = (SharpVk.Interop.Fuchsia.ImageConstraintsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Fuchsia.ImageConstraintsInfo>());
                imageConstraintsInfo.MarshalTo(marshalledImageConstraintsInfo);
                SharpVk.Interop.Fuchsia.VkBufferCollectionFUCHSIASetImageConstraintsDelegate commandDelegate = commandCache.Cache.vkSetBufferCollectionImageConstraintsFUCHSIA;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, marshalledImageConstraintsInfo);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bufferConstraintsInfo">
        /// </param>
        public unsafe void SetBufferConstraints(SharpVk.Fuchsia.BufferConstraintsInfo bufferConstraintsInfo)
        {
            try
            {
                SharpVk.Interop.Fuchsia.BufferConstraintsInfo* marshalledBufferConstraintsInfo = default(SharpVk.Interop.Fuchsia.BufferConstraintsInfo*);
                marshalledBufferConstraintsInfo = (SharpVk.Interop.Fuchsia.BufferConstraintsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Fuchsia.BufferConstraintsInfo>());
                bufferConstraintsInfo.MarshalTo(marshalledBufferConstraintsInfo);
                SharpVk.Interop.Fuchsia.VkBufferCollectionFUCHSIASetBufferConstraintsDelegate commandDelegate = commandCache.Cache.vkSetBufferCollectionBufferConstraintsFUCHSIA;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, marshalledBufferConstraintsInfo);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
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
                SharpVk.Interop.Fuchsia.VkBufferCollectionFUCHSIADestroyDelegate commandDelegate = commandCache.Cache.vkDestroyBufferCollectionFUCHSIA;
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
        public unsafe SharpVk.Fuchsia.BufferCollectionProperties GetProperties()
        {
            try
            {
                SharpVk.Fuchsia.BufferCollectionProperties result = default(SharpVk.Fuchsia.BufferCollectionProperties);
                SharpVk.Interop.Fuchsia.BufferCollectionProperties marshalledProperties = default(SharpVk.Interop.Fuchsia.BufferCollectionProperties);
                SharpVk.Interop.Fuchsia.VkBufferCollectionFUCHSIAGetPropertiesDelegate commandDelegate = commandCache.Cache.vkGetBufferCollectionPropertiesFUCHSIA;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, &marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Fuchsia.BufferCollectionProperties.MarshalFrom(&marshalledProperties);
                return result;
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
