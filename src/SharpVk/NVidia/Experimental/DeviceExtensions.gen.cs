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

namespace SharpVk.NVidia.Experimental
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
        /// <param name="data">
        /// </param>
        /// <param name="cuModuleTexturingModeCreateInfoNvx">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.NVidia.Experimental.CuModule CreateCuModule(this SharpVk.Device extendedHandle, ArrayProxy<byte>? data, SharpVk.NVidia.Experimental.CuModuleTexturingModeCreateInfo? cuModuleTexturingModeCreateInfoNvx = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.Experimental.CuModule result = default(SharpVk.NVidia.Experimental.CuModule);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.Experimental.CuModuleCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.Experimental.CuModuleCreateInfo*);
                void* vkCuModuleCreateInfoNVXNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.Experimental.CuModule marshalledModule = default(SharpVk.Interop.NVidia.Experimental.CuModule);
                if (cuModuleTexturingModeCreateInfoNvx != null)
                {
                    SharpVk.Interop.NVidia.Experimental.CuModuleTexturingModeCreateInfo* extensionPointer = default(SharpVk.Interop.NVidia.Experimental.CuModuleTexturingModeCreateInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.Experimental.CuModuleTexturingModeCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.CuModuleTexturingModeCreateInfo>());
                    cuModuleTexturingModeCreateInfoNvx.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkCuModuleCreateInfoNVXNextPointer;
                    vkCuModuleCreateInfoNVXNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.Experimental.CuModuleCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.CuModuleCreateInfo>());
                marshalledCreateInfo->SType = StructureType.CuModuleCreateInfo;
                marshalledCreateInfo->Next = vkCuModuleCreateInfoNVXNextPointer;
                marshalledCreateInfo->DataSize = (HostSize)(Interop.HeapUtil.GetLength(data));
                if (data.IsNull())
                {
                    marshalledCreateInfo->Data = null;
                }
                else
                {
                    if (data.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Data = (byte*)(Interop.HeapUtil.Allocate<byte>());
                        *(byte*)(marshalledCreateInfo->Data) = data.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Interop.HeapUtil.GetLength(data.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(data.Value)); index++)
                        {
                            fieldPointer[index] = data.Value[index];
                        }
                        marshalledCreateInfo->Data = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.NVidia.Experimental.VkDeviceCreateCuModuleDelegate commandDelegate = commandCache.Cache.vkCreateCuModuleNVX;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledModule);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.Experimental.CuModule(extendedHandle, marshalledModule);
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
        /// <param name="module">
        /// </param>
        /// <param name="name">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.NVidia.Experimental.CuFunction CreateCuFunction(this SharpVk.Device extendedHandle, SharpVk.NVidia.Experimental.CuModule module, string name, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.Experimental.CuFunction result = default(SharpVk.NVidia.Experimental.CuFunction);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.Experimental.CuFunctionCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.Experimental.CuFunctionCreateInfo*);
                void* vkCuFunctionCreateInfoNVXNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.Experimental.CuFunction marshalledFunction = default(SharpVk.Interop.NVidia.Experimental.CuFunction);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.Experimental.CuFunctionCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.CuFunctionCreateInfo>());
                marshalledCreateInfo->SType = StructureType.CuFunctionCreateInfo;
                marshalledCreateInfo->Next = vkCuFunctionCreateInfoNVXNextPointer;
                marshalledCreateInfo->Module = module?.handle ?? default(SharpVk.Interop.NVidia.Experimental.CuModule);
                marshalledCreateInfo->Name = Interop.HeapUtil.MarshalTo(name);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.NVidia.Experimental.VkDeviceCreateCuFunctionDelegate commandDelegate = commandCache.Cache.vkCreateCuFunctionNVX;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledFunction);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.Experimental.CuFunction(extendedHandle, marshalledFunction);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Get the handle for an image view for a specific descriptor type
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// Describes the image view to query and type of handle.
        /// </param>
        public static unsafe void GetImageViewHandle(this SharpVk.Device extendedHandle, SharpVk.NVidia.Experimental.ImageViewHandleInfo info)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.Experimental.ImageViewHandleInfo* marshalledInfo = default(SharpVk.Interop.NVidia.Experimental.ImageViewHandleInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.Experimental.ImageViewHandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.ImageViewHandleInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.Experimental.VkDeviceGetImageViewHandleDelegate commandDelegate = commandCache.Cache.vkGetImageViewHandleNVX;
                commandDelegate(extendedHandle.handle, marshalledInfo);
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
        /// <param name="info">
        /// </param>
        public static unsafe ulong GetImageViewHandle64(this SharpVk.Device extendedHandle, SharpVk.NVidia.Experimental.ImageViewHandleInfo info)
        {
            try
            {
                ulong result = default(ulong);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.Experimental.ImageViewHandleInfo* marshalledInfo = default(SharpVk.Interop.NVidia.Experimental.ImageViewHandleInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.Experimental.ImageViewHandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.ImageViewHandleInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.Experimental.VkDeviceGetImageViewHandle64Delegate commandDelegate = commandCache.Cache.vkGetImageViewHandle64NVX;
                result = commandDelegate(extendedHandle.handle, marshalledInfo);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
