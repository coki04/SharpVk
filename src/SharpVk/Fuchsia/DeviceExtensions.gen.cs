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
    public static class DeviceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="getZirconHandleInfo">
        /// </param>
        public static unsafe uint GetMemoryZirconHandle(this SharpVk.Device extendedHandle, SharpVk.Fuchsia.MemoryGetZirconHandleInfo getZirconHandleInfo)
        {
            try
            {
                uint result = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Fuchsia.MemoryGetZirconHandleInfo* marshalledGetZirconHandleInfo = default(SharpVk.Interop.Fuchsia.MemoryGetZirconHandleInfo*);
                uint marshalledZirconHandle = default(uint);
                commandCache = extendedHandle.commandCache;
                marshalledGetZirconHandleInfo = (SharpVk.Interop.Fuchsia.MemoryGetZirconHandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Fuchsia.MemoryGetZirconHandleInfo>());
                getZirconHandleInfo.MarshalTo(marshalledGetZirconHandleInfo);
                SharpVk.Interop.Fuchsia.VkDeviceGetMemoryZirconHandleDelegate commandDelegate = commandCache.Cache.vkGetMemoryZirconHandleFUCHSIA;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetZirconHandleInfo, &marshalledZirconHandle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledZirconHandle;
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="handleType">
        /// </param>
        /// <param name="zirconHandle">
        /// </param>
        public static unsafe SharpVk.Fuchsia.MemoryZirconHandleProperties GetMemoryZirconHandleProperties(this SharpVk.Device extendedHandle, SharpVk.ExternalMemoryHandleTypeFlags handleType, uint zirconHandle)
        {
            try
            {
                SharpVk.Fuchsia.MemoryZirconHandleProperties result = default(SharpVk.Fuchsia.MemoryZirconHandleProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Fuchsia.MemoryZirconHandleProperties marshalledMemoryZirconHandleProperties = default(SharpVk.Interop.Fuchsia.MemoryZirconHandleProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Fuchsia.VkDeviceGetMemoryZirconHandlePropertiesDelegate commandDelegate = commandCache.Cache.vkGetMemoryZirconHandlePropertiesFUCHSIA;
                Result methodResult = commandDelegate(extendedHandle.handle, handleType, zirconHandle, &marshalledMemoryZirconHandleProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Fuchsia.MemoryZirconHandleProperties.MarshalFrom(&marshalledMemoryZirconHandleProperties);
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="importSemaphoreZirconHandleInfo">
        /// </param>
        public static unsafe void ImportSemaphoreZirconHandle(this SharpVk.Device extendedHandle, SharpVk.Fuchsia.ImportSemaphoreZirconHandleInfo importSemaphoreZirconHandleInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Fuchsia.ImportSemaphoreZirconHandleInfo* marshalledImportSemaphoreZirconHandleInfo = default(SharpVk.Interop.Fuchsia.ImportSemaphoreZirconHandleInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportSemaphoreZirconHandleInfo = (SharpVk.Interop.Fuchsia.ImportSemaphoreZirconHandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Fuchsia.ImportSemaphoreZirconHandleInfo>());
                importSemaphoreZirconHandleInfo.MarshalTo(marshalledImportSemaphoreZirconHandleInfo);
                SharpVk.Interop.Fuchsia.VkDeviceImportSemaphoreZirconHandleDelegate commandDelegate = commandCache.Cache.vkImportSemaphoreZirconHandleFUCHSIA;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImportSemaphoreZirconHandleInfo);
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="getZirconHandleInfo">
        /// </param>
        public static unsafe uint GetSemaphoreZirconHandle(this SharpVk.Device extendedHandle, SharpVk.Fuchsia.SemaphoreGetZirconHandleInfo getZirconHandleInfo)
        {
            try
            {
                uint result = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Fuchsia.SemaphoreGetZirconHandleInfo* marshalledGetZirconHandleInfo = default(SharpVk.Interop.Fuchsia.SemaphoreGetZirconHandleInfo*);
                uint marshalledZirconHandle = default(uint);
                commandCache = extendedHandle.commandCache;
                marshalledGetZirconHandleInfo = (SharpVk.Interop.Fuchsia.SemaphoreGetZirconHandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Fuchsia.SemaphoreGetZirconHandleInfo>());
                getZirconHandleInfo.MarshalTo(marshalledGetZirconHandleInfo);
                SharpVk.Interop.Fuchsia.VkDeviceGetSemaphoreZirconHandleDelegate commandDelegate = commandCache.Cache.vkGetSemaphoreZirconHandleFUCHSIA;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetZirconHandleInfo, &marshalledZirconHandle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledZirconHandle;
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="collectionToken">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Fuchsia.BufferCollection CreateBufferCollection(this SharpVk.Device extendedHandle, uint collectionToken, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Fuchsia.BufferCollection result = default(SharpVk.Fuchsia.BufferCollection);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Fuchsia.BufferCollectionCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Fuchsia.BufferCollectionCreateInfo*);
                void* vkBufferCollectionCreateInfoFUCHSIANextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Fuchsia.BufferCollection marshalledCollection = default(SharpVk.Interop.Fuchsia.BufferCollection);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Fuchsia.BufferCollectionCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Fuchsia.BufferCollectionCreateInfo>());
                marshalledCreateInfo->SType = StructureType.BufferCollectionCreateInfo;
                marshalledCreateInfo->Next = vkBufferCollectionCreateInfoFUCHSIANextPointer;
                marshalledCreateInfo->CollectionToken = collectionToken;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Fuchsia.VkDeviceCreateBufferCollectionDelegate commandDelegate = commandCache.Cache.vkCreateBufferCollectionFUCHSIA;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledCollection);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Fuchsia.BufferCollection(extendedHandle, marshalledCollection);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
