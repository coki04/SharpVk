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

namespace SharpVk.Multivendor
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
        /// <param name="display">
        /// </param>
        /// <param name="displayPowerInfo">
        /// </param>
        public static unsafe void DisplayPowerControl(this SharpVk.Device extendedHandle, SharpVk.Khronos.Display display, SharpVk.Multivendor.DisplayPowerInfo displayPowerInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DisplayPowerInfo* marshalledDisplayPowerInfo = default(SharpVk.Interop.Multivendor.DisplayPowerInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledDisplayPowerInfo = (SharpVk.Interop.Multivendor.DisplayPowerInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DisplayPowerInfo>());
                displayPowerInfo.MarshalTo(marshalledDisplayPowerInfo);
                SharpVk.Interop.Multivendor.VkDeviceDisplayPowerControlDelegate commandDelegate = commandCache.Cache.vkDisplayPowerControlEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, display?.handle ?? default(SharpVk.Interop.Khronos.Display), marshalledDisplayPowerInfo);
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
        /// <param name="deviceEventInfo">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Fence RegisterEvent(this SharpVk.Device extendedHandle, SharpVk.Multivendor.DeviceEventInfo deviceEventInfo, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Fence result = default(SharpVk.Fence);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DeviceEventInfo* marshalledDeviceEventInfo = default(SharpVk.Interop.Multivendor.DeviceEventInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Fence marshalledFence = default(SharpVk.Interop.Fence);
                commandCache = extendedHandle.commandCache;
                marshalledDeviceEventInfo = (SharpVk.Interop.Multivendor.DeviceEventInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DeviceEventInfo>());
                deviceEventInfo.MarshalTo(marshalledDeviceEventInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Multivendor.VkDeviceRegisterEventDelegate commandDelegate = commandCache.Cache.vkRegisterDeviceEventEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledDeviceEventInfo, marshalledAllocator, &marshalledFence);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Fence(extendedHandle, marshalledFence);
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
        /// <param name="display">
        /// </param>
        /// <param name="displayEventInfo">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Fence RegisterDisplayEvent(this SharpVk.Device extendedHandle, SharpVk.Khronos.Display display, SharpVk.Multivendor.DisplayEventInfo displayEventInfo, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Fence result = default(SharpVk.Fence);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DisplayEventInfo* marshalledDisplayEventInfo = default(SharpVk.Interop.Multivendor.DisplayEventInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Fence marshalledFence = default(SharpVk.Interop.Fence);
                commandCache = extendedHandle.commandCache;
                marshalledDisplayEventInfo = (SharpVk.Interop.Multivendor.DisplayEventInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DisplayEventInfo>());
                displayEventInfo.MarshalTo(marshalledDisplayEventInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Multivendor.VkDeviceRegisterDisplayEventDelegate commandDelegate = commandCache.Cache.vkRegisterDisplayEventEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, display?.handle ?? default(SharpVk.Interop.Khronos.Display), marshalledDisplayEventInfo, marshalledAllocator, &marshalledFence);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Fence(extendedHandle, marshalledFence);
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
        /// <param name="swapchains">
        /// </param>
        /// <param name="metadata">
        /// </param>
        public static unsafe void SetHdrMetadata(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Khronos.Swapchain>? swapchains, ArrayProxy<SharpVk.Multivendor.HdrMetadata>? metadata)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Swapchain* marshalledSwapchains = default(SharpVk.Interop.Khronos.Swapchain*);
                SharpVk.Interop.Multivendor.HdrMetadata* marshalledMetadata = default(SharpVk.Interop.Multivendor.HdrMetadata*);
                commandCache = extendedHandle.commandCache;
                if (swapchains.IsNull())
                {
                    marshalledSwapchains = null;
                }
                else
                {
                    if (swapchains.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSwapchains = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Swapchain>());
                        *(SharpVk.Interop.Khronos.Swapchain*)(marshalledSwapchains) = swapchains.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.Swapchain>(Interop.HeapUtil.GetLength(swapchains.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(swapchains.Value)); index++)
                        {
                            fieldPointer[index] = swapchains.Value[index]?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                        }
                        marshalledSwapchains = fieldPointer;
                    }
                }
                if (metadata.IsNull())
                {
                    marshalledMetadata = null;
                }
                else
                {
                    if (metadata.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMetadata = (SharpVk.Interop.Multivendor.HdrMetadata*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.HdrMetadata>());
                        metadata.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.HdrMetadata*)(marshalledMetadata));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.HdrMetadata*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.HdrMetadata>(Interop.HeapUtil.GetLength(metadata.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(metadata.Value)); index++)
                        {
                            metadata.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledMetadata = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkDeviceSetHdrMetadataDelegate commandDelegate = commandCache.Cache.vkSetHdrMetadataEXT;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(swapchains)), marshalledSwapchains, marshalledMetadata);
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
        /// <param name="nameInfo">
        /// </param>
        public static unsafe void SetDebugUtilsObjectName(this SharpVk.Device extendedHandle, SharpVk.Multivendor.DebugUtilsObjectNameInfo nameInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugUtilsObjectNameInfo* marshalledNameInfo = default(SharpVk.Interop.Multivendor.DebugUtilsObjectNameInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledNameInfo = (SharpVk.Interop.Multivendor.DebugUtilsObjectNameInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsObjectNameInfo>());
                nameInfo.MarshalTo(marshalledNameInfo);
                SharpVk.Interop.Multivendor.VkDeviceSetDebugUtilsObjectNameDelegate commandDelegate = commandCache.Cache.vkSetDebugUtilsObjectNameEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledNameInfo);
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
        /// <param name="tagInfo">
        /// </param>
        public static unsafe void SetDebugUtilsObjectTag(this SharpVk.Device extendedHandle, SharpVk.Multivendor.DebugUtilsObjectTagInfo tagInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugUtilsObjectTagInfo* marshalledTagInfo = default(SharpVk.Interop.Multivendor.DebugUtilsObjectTagInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledTagInfo = (SharpVk.Interop.Multivendor.DebugUtilsObjectTagInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsObjectTagInfo>());
                tagInfo.MarshalTo(marshalledTagInfo);
                SharpVk.Interop.Multivendor.VkDeviceSetDebugUtilsObjectTagDelegate commandDelegate = commandCache.Cache.vkSetDebugUtilsObjectTagEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledTagInfo);
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
        /// <param name="flags">
        /// </param>
        /// <param name="initialData">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Multivendor.ValidationCache CreateValidationCache(this SharpVk.Device extendedHandle, ArrayProxy<byte>? initialData, SharpVk.Multivendor.ValidationCacheCreateFlags? flags = default(SharpVk.Multivendor.ValidationCacheCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Multivendor.ValidationCache result = default(SharpVk.Multivendor.ValidationCache);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.ValidationCacheCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Multivendor.ValidationCacheCreateInfo*);
                void* vkValidationCacheCreateInfoEXTNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Multivendor.ValidationCache marshalledValidationCache = default(SharpVk.Interop.Multivendor.ValidationCache);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.ValidationCacheCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ValidationCacheCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ValidationCacheCreateInfo;
                marshalledCreateInfo->Next = vkValidationCacheCreateInfoEXTNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Multivendor.ValidationCacheCreateFlags);
                }
                marshalledCreateInfo->InitialDataSize = (HostSize)(Interop.HeapUtil.GetLength(initialData));
                if (initialData.IsNull())
                {
                    marshalledCreateInfo->InitialData = null;
                }
                else
                {
                    if (initialData.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->InitialData = (byte*)(Interop.HeapUtil.Allocate<byte>());
                        *(byte*)(marshalledCreateInfo->InitialData) = initialData.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Interop.HeapUtil.GetLength(initialData.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(initialData.Value)); index++)
                        {
                            fieldPointer[index] = initialData.Value[index];
                        }
                        marshalledCreateInfo->InitialData = fieldPointer;
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
                SharpVk.Interop.Multivendor.VkDeviceCreateValidationCacheDelegate commandDelegate = commandCache.Cache.vkCreateValidationCacheEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledValidationCache);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Multivendor.ValidationCache(extendedHandle, marshalledValidationCache);
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
        /// <param name="hostPointer">
        /// </param>
        public static unsafe SharpVk.Multivendor.MemoryHostPointerProperties GetMemoryHostPointerProperties(this SharpVk.Device extendedHandle, SharpVk.ExternalMemoryHandleTypeFlags handleType, IntPtr hostPointer)
        {
            try
            {
                SharpVk.Multivendor.MemoryHostPointerProperties result = default(SharpVk.Multivendor.MemoryHostPointerProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.MemoryHostPointerProperties marshalledMemoryHostPointerProperties = default(SharpVk.Interop.Multivendor.MemoryHostPointerProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkDeviceGetMemoryHostPointerPropertiesDelegate commandDelegate = commandCache.Cache.vkGetMemoryHostPointerPropertiesEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, handleType, hostPointer.ToPointer(), &marshalledMemoryHostPointerProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Multivendor.MemoryHostPointerProperties.MarshalFrom(&marshalledMemoryHostPointerProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query device group present capabilities for a surface
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="surfaceInfo">
        /// An instance of the VkPhysicalDeviceSurfaceInfo2KHR structure,
        /// describing the surface and other fixed parameters that would be
        /// consumed by vkCreateSwapchainKHR.
        /// </param>
        public static unsafe SharpVk.Khronos.DeviceGroupPresentModeFlags GetGroupSurfacePresentModes2(this SharpVk.Device extendedHandle, SharpVk.Khronos.PhysicalDeviceSurfaceInfo2 surfaceInfo)
        {
            try
            {
                SharpVk.Khronos.DeviceGroupPresentModeFlags result = default(SharpVk.Khronos.DeviceGroupPresentModeFlags);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2* marshalledSurfaceInfo = default(SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*);
                SharpVk.Khronos.DeviceGroupPresentModeFlags marshalledModes = default(SharpVk.Khronos.DeviceGroupPresentModeFlags);
                commandCache = extendedHandle.commandCache;
                marshalledSurfaceInfo = (SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2>());
                surfaceInfo.MarshalTo(marshalledSurfaceInfo);
                SharpVk.Interop.Multivendor.VkDeviceGetGroupSurfacePresentModes2Delegate commandDelegate = commandCache.Cache.vkGetDeviceGroupSurfacePresentModes2EXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledSurfaceInfo, &marshalledModes);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledModes;
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
        /// <param name="metalObjectsInfo">
        /// </param>
        public static unsafe void ExportMetalObjects(this SharpVk.Device extendedHandle, SharpVk.Multivendor.ExportMetalObjectsInfo metalObjectsInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.ExportMetalObjectsInfo* marshalledMetalObjectsInfo = default(SharpVk.Interop.Multivendor.ExportMetalObjectsInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledMetalObjectsInfo = (SharpVk.Interop.Multivendor.ExportMetalObjectsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ExportMetalObjectsInfo>());
                metalObjectsInfo.MarshalTo(marshalledMetalObjectsInfo);
                SharpVk.Interop.Multivendor.VkDeviceExportMetalObjectsDelegate commandDelegate = commandCache.Cache.vkExportMetalObjectsEXT;
                commandDelegate(extendedHandle.handle, marshalledMetalObjectsInfo);
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
        /// <param name="type">
        /// </param>
        /// <param name="data">
        /// </param>
        /// <param name="descriptorGetTensorInfoArm">
        /// Extension struct
        /// </param>
        /// <param name="dataSize">
        /// </param>
        public static unsafe byte[] GetDescriptor(this SharpVk.Device extendedHandle, SharpVk.DescriptorType type, SharpVk.Multivendor.DescriptorData data, HostSize dataSize, SharpVk.Arm.DescriptorGetTensorInfo? descriptorGetTensorInfoArm = null)
        {
            try
            {
                byte[] result = default(byte[]);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DescriptorGetInfo* marshalledDescriptorInfo = default(SharpVk.Interop.Multivendor.DescriptorGetInfo*);
                void* vkDescriptorGetInfoEXTNextPointer = default(void*);
                HostSize marshalledDataSize = default(HostSize);
                byte* marshalledDescriptor = default(byte*);
                if (descriptorGetTensorInfoArm != null)
                {
                    SharpVk.Interop.Arm.DescriptorGetTensorInfo* extensionPointer = default(SharpVk.Interop.Arm.DescriptorGetTensorInfo*);
                    extensionPointer = (SharpVk.Interop.Arm.DescriptorGetTensorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DescriptorGetTensorInfo>());
                    descriptorGetTensorInfoArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDescriptorGetInfoEXTNextPointer;
                    vkDescriptorGetInfoEXTNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledDescriptorInfo = (SharpVk.Interop.Multivendor.DescriptorGetInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DescriptorGetInfo>());
                marshalledDescriptorInfo->SType = StructureType.DescriptorGetInfo;
                marshalledDescriptorInfo->Next = vkDescriptorGetInfoEXTNextPointer;
                marshalledDescriptorInfo->Type = type;
                marshalledDescriptorInfo->Data = data;
                marshalledDataSize = dataSize;
                marshalledDescriptor = (byte*)(Interop.HeapUtil.Allocate<byte>(marshalledDataSize));
                SharpVk.Interop.Multivendor.VkDeviceGetDescriptorDelegate commandDelegate = commandCache.Cache.vkGetDescriptorEXT;
                commandDelegate(extendedHandle.handle, marshalledDescriptorInfo, marshalledDataSize, marshalledDescriptor);
                if (marshalledDescriptor != null)
                {
                    var fieldPointer = new byte[(uint)(marshalledDataSize)];
                    for(int index = 0; index < (uint)(marshalledDataSize); index++)
                    {
                        fieldPointer[index] = marshalledDescriptor[index];
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        /// <param name="data">
        /// </param>
        public static unsafe void GetBufferOpaqueCaptureDescriptorData(this SharpVk.Device extendedHandle, SharpVk.Multivendor.BufferCaptureDescriptorDataInfo info, IntPtr data)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.BufferCaptureDescriptorDataInfo* marshalledInfo = default(SharpVk.Interop.Multivendor.BufferCaptureDescriptorDataInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Multivendor.BufferCaptureDescriptorDataInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.BufferCaptureDescriptorDataInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Multivendor.VkDeviceGetBufferOpaqueCaptureDescriptorDataDelegate commandDelegate = commandCache.Cache.vkGetBufferOpaqueCaptureDescriptorDataEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledInfo, data.ToPointer());
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
        /// <param name="info">
        /// </param>
        /// <param name="data">
        /// </param>
        public static unsafe void GetImageOpaqueCaptureDescriptorData(this SharpVk.Device extendedHandle, SharpVk.Multivendor.ImageCaptureDescriptorDataInfo info, IntPtr data)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.ImageCaptureDescriptorDataInfo* marshalledInfo = default(SharpVk.Interop.Multivendor.ImageCaptureDescriptorDataInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Multivendor.ImageCaptureDescriptorDataInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImageCaptureDescriptorDataInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Multivendor.VkDeviceGetImageOpaqueCaptureDescriptorDataDelegate commandDelegate = commandCache.Cache.vkGetImageOpaqueCaptureDescriptorDataEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledInfo, data.ToPointer());
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
        /// <param name="info">
        /// </param>
        /// <param name="data">
        /// </param>
        public static unsafe void GetImageViewOpaqueCaptureDescriptorData(this SharpVk.Device extendedHandle, SharpVk.Multivendor.ImageViewCaptureDescriptorDataInfo info, IntPtr data)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.ImageViewCaptureDescriptorDataInfo* marshalledInfo = default(SharpVk.Interop.Multivendor.ImageViewCaptureDescriptorDataInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Multivendor.ImageViewCaptureDescriptorDataInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImageViewCaptureDescriptorDataInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Multivendor.VkDeviceGetImageViewOpaqueCaptureDescriptorDataDelegate commandDelegate = commandCache.Cache.vkGetImageViewOpaqueCaptureDescriptorDataEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledInfo, data.ToPointer());
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
        /// <param name="info">
        /// </param>
        /// <param name="data">
        /// </param>
        public static unsafe void GetSamplerOpaqueCaptureDescriptorData(this SharpVk.Device extendedHandle, SharpVk.Multivendor.SamplerCaptureDescriptorDataInfo info, IntPtr data)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.SamplerCaptureDescriptorDataInfo* marshalledInfo = default(SharpVk.Interop.Multivendor.SamplerCaptureDescriptorDataInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Multivendor.SamplerCaptureDescriptorDataInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SamplerCaptureDescriptorDataInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Multivendor.VkDeviceGetSamplerOpaqueCaptureDescriptorDataDelegate commandDelegate = commandCache.Cache.vkGetSamplerOpaqueCaptureDescriptorDataEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledInfo, data.ToPointer());
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
        /// <param name="info">
        /// </param>
        /// <param name="data">
        /// </param>
        public static unsafe void GetAccelerationStructureOpaqueCaptureDescriptorData(this SharpVk.Device extendedHandle, SharpVk.Multivendor.AccelerationStructureCaptureDescriptorDataInfo info, IntPtr data)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.AccelerationStructureCaptureDescriptorDataInfo* marshalledInfo = default(SharpVk.Interop.Multivendor.AccelerationStructureCaptureDescriptorDataInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Multivendor.AccelerationStructureCaptureDescriptorDataInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.AccelerationStructureCaptureDescriptorDataInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Multivendor.VkDeviceGetAccelerationStructureOpaqueCaptureDescriptorDataDelegate commandDelegate = commandCache.Cache.vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledInfo, data.ToPointer());
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
        /// <param name="faultCounts">
        /// </param>
        public static unsafe SharpVk.Multivendor.DeviceFaultInfo GetFaultInfo(this SharpVk.Device extendedHandle, SharpVk.Multivendor.DeviceFaultCounts faultCounts)
        {
            try
            {
                SharpVk.Multivendor.DeviceFaultInfo result = default(SharpVk.Multivendor.DeviceFaultInfo);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DeviceFaultCounts* marshalledFaultCounts = default(SharpVk.Interop.Multivendor.DeviceFaultCounts*);
                SharpVk.Interop.Multivendor.DeviceFaultInfo marshalledFaultInfo = default(SharpVk.Interop.Multivendor.DeviceFaultInfo);
                commandCache = extendedHandle.commandCache;
                marshalledFaultCounts = (SharpVk.Interop.Multivendor.DeviceFaultCounts*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DeviceFaultCounts>());
                faultCounts.MarshalTo(marshalledFaultCounts);
                SharpVk.Interop.Multivendor.VkDeviceGetFaultInfoDelegate commandDelegate = commandCache.Cache.vkGetDeviceFaultInfoEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledFaultCounts, &marshalledFaultInfo);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Multivendor.DeviceFaultInfo.MarshalFrom(&marshalledFaultInfo);
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
        /// <param name="pipelineInfo">
        /// </param>
        public static unsafe SharpVk.BaseOutStructure GetPipelineProperties(this SharpVk.Device extendedHandle, SharpVk.Khronos.PipelineInfo pipelineInfo)
        {
            try
            {
                SharpVk.BaseOutStructure result = default(SharpVk.BaseOutStructure);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PipelineInfo* marshalledPipelineInfo = default(SharpVk.Interop.Khronos.PipelineInfo*);
                SharpVk.Interop.BaseOutStructure marshalledPipelineProperties = default(SharpVk.Interop.BaseOutStructure);
                commandCache = extendedHandle.commandCache;
                marshalledPipelineInfo = (SharpVk.Interop.Khronos.PipelineInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineInfo>());
                pipelineInfo.MarshalTo(marshalledPipelineInfo);
                SharpVk.Interop.Multivendor.VkDeviceGetPipelinePropertiesDelegate commandDelegate = commandCache.Cache.vkGetPipelinePropertiesEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledPipelineInfo, &marshalledPipelineProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.BaseOutStructure.MarshalFrom(&marshalledPipelineProperties);
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
        /// <param name="createFlags">
        /// </param>
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="size">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="deviceAddress">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Multivendor.Micromap CreateMicromap(this SharpVk.Device extendedHandle, SharpVk.Buffer buffer, ulong offset, ulong size, SharpVk.Multivendor.MicromapType type, SharpVk.Multivendor.MicromapCreateFlags? createFlags = default(SharpVk.Multivendor.MicromapCreateFlags?), ulong? deviceAddress = default(ulong?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Multivendor.Micromap result = default(SharpVk.Multivendor.Micromap);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.MicromapCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Multivendor.MicromapCreateInfo*);
                void* vkMicromapCreateInfoEXTNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Multivendor.Micromap marshalledMicromap = default(SharpVk.Interop.Multivendor.Micromap);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.MicromapCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.MicromapCreateInfo>());
                marshalledCreateInfo->SType = StructureType.MicromapCreateInfo;
                marshalledCreateInfo->Next = vkMicromapCreateInfoEXTNextPointer;
                if (createFlags != null)
                {
                    marshalledCreateInfo->CreateFlags = createFlags.Value;
                }
                else
                {
                    marshalledCreateInfo->CreateFlags = default(SharpVk.Multivendor.MicromapCreateFlags);
                }
                marshalledCreateInfo->Buffer = buffer?.handle ?? default(SharpVk.Interop.Buffer);
                marshalledCreateInfo->Offset = offset;
                marshalledCreateInfo->Size = size;
                marshalledCreateInfo->Type = type;
                if (deviceAddress != null)
                {
                    marshalledCreateInfo->DeviceAddress = deviceAddress.Value;
                }
                else
                {
                    marshalledCreateInfo->DeviceAddress = default(ulong);
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
                SharpVk.Interop.Multivendor.VkDeviceCreateMicromapDelegate commandDelegate = commandCache.Cache.vkCreateMicromapEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledMicromap);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Multivendor.Micromap(extendedHandle, marshalledMicromap);
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
        /// <param name="micromaps">
        /// </param>
        /// <param name="queryType">
        /// </param>
        /// <param name="data">
        /// </param>
        /// <param name="stride">
        /// </param>
        public static unsafe void WriteMicromapsProperties(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Multivendor.Micromap>? micromaps, SharpVk.QueryType queryType, ArrayProxy<byte>? data, HostSize stride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.Micromap* marshalledMicromaps = default(SharpVk.Interop.Multivendor.Micromap*);
                byte* marshalledData = default(byte*);
                commandCache = extendedHandle.commandCache;
                if (micromaps.IsNull())
                {
                    marshalledMicromaps = null;
                }
                else
                {
                    if (micromaps.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMicromaps = (SharpVk.Interop.Multivendor.Micromap*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.Micromap>());
                        *(SharpVk.Interop.Multivendor.Micromap*)(marshalledMicromaps) = micromaps.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Multivendor.Micromap);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.Micromap*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.Micromap>(Interop.HeapUtil.GetLength(micromaps.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(micromaps.Value)); index++)
                        {
                            fieldPointer[index] = micromaps.Value[index]?.handle ?? default(SharpVk.Interop.Multivendor.Micromap);
                        }
                        marshalledMicromaps = fieldPointer;
                    }
                }
                if (data.IsNull())
                {
                    marshalledData = null;
                }
                else
                {
                    if (data.Value.Contents == ProxyContents.Single)
                    {
                        marshalledData = (byte*)(Interop.HeapUtil.Allocate<byte>());
                        *(byte*)(marshalledData) = data.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Interop.HeapUtil.GetLength(data.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(data.Value)); index++)
                        {
                            fieldPointer[index] = data.Value[index];
                        }
                        marshalledData = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkDeviceWriteMicromapsPropertiesDelegate commandDelegate = commandCache.Cache.vkWriteMicromapsPropertiesEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(micromaps)), marshalledMicromaps, queryType, (HostSize)(Interop.HeapUtil.GetLength(data)), marshalledData, stride);
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
        /// <param name="versionInfo">
        /// </param>
        public static unsafe SharpVk.Khronos.AccelerationStructureCompatibility GetMicromapCompatibility(this SharpVk.Device extendedHandle, SharpVk.Multivendor.MicromapVersionInfo versionInfo)
        {
            try
            {
                SharpVk.Khronos.AccelerationStructureCompatibility result = default(SharpVk.Khronos.AccelerationStructureCompatibility);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.MicromapVersionInfo* marshalledVersionInfo = default(SharpVk.Interop.Multivendor.MicromapVersionInfo*);
                SharpVk.Khronos.AccelerationStructureCompatibility marshalledCompatibility = default(SharpVk.Khronos.AccelerationStructureCompatibility);
                commandCache = extendedHandle.commandCache;
                marshalledVersionInfo = (SharpVk.Interop.Multivendor.MicromapVersionInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.MicromapVersionInfo>());
                versionInfo.MarshalTo(marshalledVersionInfo);
                SharpVk.Interop.Multivendor.VkDeviceGetMicromapCompatibilityDelegate commandDelegate = commandCache.Cache.vkGetDeviceMicromapCompatibilityEXT;
                commandDelegate(extendedHandle.handle, marshalledVersionInfo, &marshalledCompatibility);
                result = marshalledCompatibility;
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
        /// <param name="buildType">
        /// </param>
        /// <param name="buildInfo">
        /// </param>
        public static unsafe SharpVk.Multivendor.MicromapBuildSizesInfo GetMicromapBuildSizes(this SharpVk.Device extendedHandle, SharpVk.Khronos.AccelerationStructureBuildType buildType, SharpVk.Multivendor.MicromapBuildInfo buildInfo)
        {
            try
            {
                SharpVk.Multivendor.MicromapBuildSizesInfo result = default(SharpVk.Multivendor.MicromapBuildSizesInfo);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.MicromapBuildInfo* marshalledBuildInfo = default(SharpVk.Interop.Multivendor.MicromapBuildInfo*);
                SharpVk.Interop.Multivendor.MicromapBuildSizesInfo marshalledSizeInfo = default(SharpVk.Interop.Multivendor.MicromapBuildSizesInfo);
                commandCache = extendedHandle.commandCache;
                marshalledBuildInfo = (SharpVk.Interop.Multivendor.MicromapBuildInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.MicromapBuildInfo>());
                buildInfo.MarshalTo(marshalledBuildInfo);
                SharpVk.Interop.Multivendor.VkDeviceGetMicromapBuildSizesDelegate commandDelegate = commandCache.Cache.vkGetMicromapBuildSizesEXT;
                commandDelegate(extendedHandle.handle, buildType, marshalledBuildInfo, &marshalledSizeInfo);
                result = SharpVk.Multivendor.MicromapBuildSizesInfo.MarshalFrom(&marshalledSizeInfo);
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
        /// <param name="createInfo">
        /// </param>
        public static unsafe SharpVk.Multivendor.ShaderModuleIdentifier GetShaderModuleCreateInfoIdentifier(this SharpVk.Device extendedHandle, SharpVk.ShaderModuleCreateInfo createInfo)
        {
            try
            {
                SharpVk.Multivendor.ShaderModuleIdentifier result = default(SharpVk.Multivendor.ShaderModuleIdentifier);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.ShaderModuleCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.ShaderModuleCreateInfo*);
                SharpVk.Interop.Multivendor.ShaderModuleIdentifier marshalledIdentifier = default(SharpVk.Interop.Multivendor.ShaderModuleIdentifier);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.ShaderModuleCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ShaderModuleCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                SharpVk.Interop.Multivendor.VkDeviceGetShaderModuleCreateInfoIdentifierDelegate commandDelegate = commandCache.Cache.vkGetShaderModuleCreateInfoIdentifierEXT;
                commandDelegate(extendedHandle.handle, marshalledCreateInfo, &marshalledIdentifier);
                result = SharpVk.Multivendor.ShaderModuleIdentifier.MarshalFrom(&marshalledIdentifier);
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
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Multivendor.Shader[] CreateShaders(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Multivendor.ShaderCreateInfo>? createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Multivendor.Shader[] result = default(SharpVk.Multivendor.Shader[]);
                CommandCache commandCache = default(CommandCache);
                uint marshalledCreateInfoCount = default(uint);
                SharpVk.Interop.Multivendor.ShaderCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Multivendor.ShaderCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Multivendor.Shader* marshalledShaders = default(SharpVk.Interop.Multivendor.Shader*);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfoCount = (uint)(Interop.HeapUtil.GetLength(createInfos));
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (SharpVk.Interop.Multivendor.ShaderCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ShaderCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.ShaderCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.ShaderCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.ShaderCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(createInfos.Value)); index++)
                        {
                            createInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos = fieldPointer;
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
                marshalledShaders = (SharpVk.Interop.Multivendor.Shader*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.Shader>(marshalledCreateInfoCount));
                SharpVk.Interop.Multivendor.VkDeviceCreateShadersDelegate commandDelegate = commandCache.Cache.vkCreateShadersEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledShaders);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledShaders != null)
                {
                    var fieldPointer = new SharpVk.Multivendor.Shader[(uint)(marshalledCreateInfoCount)];
                    for(int index = 0; index < (uint)(marshalledCreateInfoCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Multivendor.Shader(extendedHandle, marshalledShaders[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="stage">
        /// </param>
        /// <param name="nextStage">
        /// </param>
        /// <param name="codeType">
        /// </param>
        /// <param name="code">
        /// </param>
        /// <param name="name">
        /// </param>
        /// <param name="setLayouts">
        /// </param>
        /// <param name="pushConstantRanges">
        /// </param>
        /// <param name="specializationInfo">
        /// </param>
        /// <param name="validationFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="pipelineShaderStageRequiredSubgroupSizeCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Multivendor.Shader CreateShader(this SharpVk.Device extendedHandle, SharpVk.ShaderStageFlags stage, SharpVk.Multivendor.ShaderCodeType codeType, ArrayProxy<byte>? code, string name, SharpVk.Multivendor.ShaderCreateFlags? flags = default(SharpVk.Multivendor.ShaderCreateFlags?), SharpVk.ShaderStageFlags? nextStage = default(SharpVk.ShaderStageFlags?), ArrayProxy<SharpVk.DescriptorSetLayout>? setLayouts = null, ArrayProxy<SharpVk.PushConstantRange>? pushConstantRanges = null, SharpVk.SpecializationInfo? specializationInfo = default(SharpVk.SpecializationInfo?), SharpVk.Multivendor.ValidationFeatures? validationFeaturesExt = null, SharpVk.PipelineShaderStageRequiredSubgroupSizeCreateInfo? pipelineShaderStageRequiredSubgroupSizeCreateInfo = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Multivendor.Shader result = default(SharpVk.Multivendor.Shader);
                CommandCache commandCache = default(CommandCache);
                uint marshalledCreateInfoCount = default(uint);
                SharpVk.Interop.Multivendor.ShaderCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Multivendor.ShaderCreateInfo*);
                void* vkShaderCreateInfoEXTNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Multivendor.Shader* marshalledShaders = default(SharpVk.Interop.Multivendor.Shader*);
                if (validationFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.ValidationFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.ValidationFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.ValidationFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ValidationFeatures>());
                    validationFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkShaderCreateInfoEXTNextPointer;
                    vkShaderCreateInfoEXTNextPointer = extensionPointer;
                }
                if (pipelineShaderStageRequiredSubgroupSizeCreateInfo != null)
                {
                    SharpVk.Interop.PipelineShaderStageRequiredSubgroupSizeCreateInfo* extensionPointer = default(SharpVk.Interop.PipelineShaderStageRequiredSubgroupSizeCreateInfo*);
                    extensionPointer = (SharpVk.Interop.PipelineShaderStageRequiredSubgroupSizeCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineShaderStageRequiredSubgroupSizeCreateInfo>());
                    pipelineShaderStageRequiredSubgroupSizeCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkShaderCreateInfoEXTNextPointer;
                    vkShaderCreateInfoEXTNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfoCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.Multivendor.ShaderCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ShaderCreateInfo>());
                marshalledCreateInfos->SType = StructureType.ShaderCreateInfo;
                marshalledCreateInfos->Next = vkShaderCreateInfoEXTNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfos->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfos->Flags = default(SharpVk.Multivendor.ShaderCreateFlags);
                }
                marshalledCreateInfos->Stage = stage;
                if (nextStage != null)
                {
                    marshalledCreateInfos->NextStage = nextStage.Value;
                }
                else
                {
                    marshalledCreateInfos->NextStage = default(SharpVk.ShaderStageFlags);
                }
                marshalledCreateInfos->CodeType = codeType;
                marshalledCreateInfos->CodeSize = (HostSize)(Interop.HeapUtil.GetLength(code));
                if (code.IsNull())
                {
                    marshalledCreateInfos->Code = null;
                }
                else
                {
                    if (code.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Code = (byte*)(Interop.HeapUtil.Allocate<byte>());
                        *(byte*)(marshalledCreateInfos->Code) = code.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Interop.HeapUtil.GetLength(code.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(code.Value)); index++)
                        {
                            fieldPointer[index] = code.Value[index];
                        }
                        marshalledCreateInfos->Code = fieldPointer;
                    }
                }
                marshalledCreateInfos->Name = Interop.HeapUtil.MarshalTo(name);
                marshalledCreateInfos->SetLayoutCount = (uint)(Interop.HeapUtil.GetLength(setLayouts));
                if (setLayouts.IsNull())
                {
                    marshalledCreateInfos->SetLayouts = null;
                }
                else
                {
                    if (setLayouts.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->SetLayouts = (SharpVk.Interop.DescriptorSetLayout*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayout>());
                        *(SharpVk.Interop.DescriptorSetLayout*)(marshalledCreateInfos->SetLayouts) = setLayouts.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.DescriptorSetLayout*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSetLayout>(Interop.HeapUtil.GetLength(setLayouts.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(setLayouts.Value)); index++)
                        {
                            fieldPointer[index] = setLayouts.Value[index]?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
                        }
                        marshalledCreateInfos->SetLayouts = fieldPointer;
                    }
                }
                marshalledCreateInfos->PushConstantRangeCount = (uint)(Interop.HeapUtil.GetLength(pushConstantRanges));
                if (pushConstantRanges.IsNull())
                {
                    marshalledCreateInfos->PushConstantRanges = null;
                }
                else
                {
                    if (pushConstantRanges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->PushConstantRanges = (SharpVk.PushConstantRange*)(Interop.HeapUtil.Allocate<SharpVk.PushConstantRange>());
                        *(SharpVk.PushConstantRange*)(marshalledCreateInfos->PushConstantRanges) = pushConstantRanges.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.PushConstantRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.PushConstantRange>(Interop.HeapUtil.GetLength(pushConstantRanges.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(pushConstantRanges.Value)); index++)
                        {
                            fieldPointer[index] = pushConstantRanges.Value[index];
                        }
                        marshalledCreateInfos->PushConstantRanges = fieldPointer;
                    }
                }
                if (specializationInfo != null)
                {
                    marshalledCreateInfos->SpecializationInfo = (SharpVk.Interop.SpecializationInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SpecializationInfo>());
                    specializationInfo.Value.MarshalTo(marshalledCreateInfos->SpecializationInfo);
                }
                else
                {
                    marshalledCreateInfos->SpecializationInfo = default(SharpVk.Interop.SpecializationInfo*);
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
                marshalledShaders = (SharpVk.Interop.Multivendor.Shader*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.Shader>(1));
                SharpVk.Interop.Multivendor.VkDeviceCreateShadersDelegate commandDelegate = commandCache.Cache.vkCreateShadersEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledShaders);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Multivendor.Shader(extendedHandle, *marshalledShaders);
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
        /// <param name="info">
        /// </param>
        public static unsafe SharpVk.MemoryRequirements2 GetGeneratedCommandsMemoryRequirements(this SharpVk.Device extendedHandle, SharpVk.Multivendor.GeneratedCommandsMemoryRequirementsInfo info)
        {
            try
            {
                SharpVk.MemoryRequirements2 result = default(SharpVk.MemoryRequirements2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.GeneratedCommandsMemoryRequirementsInfo* marshalledInfo = default(SharpVk.Interop.Multivendor.GeneratedCommandsMemoryRequirementsInfo*);
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default(SharpVk.Interop.MemoryRequirements2);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Multivendor.GeneratedCommandsMemoryRequirementsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.GeneratedCommandsMemoryRequirementsInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Multivendor.VkDeviceGetGeneratedCommandsMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetGeneratedCommandsMemoryRequirementsEXT;
                commandDelegate(extendedHandle.handle, marshalledInfo, &marshalledMemoryRequirements);
                result = SharpVk.MemoryRequirements2.MarshalFrom(&marshalledMemoryRequirements);
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
        /// <param name="flags">
        /// </param>
        /// <param name="shaderStages">
        /// </param>
        /// <param name="indirectStride">
        /// </param>
        /// <param name="pipelineLayout">
        /// </param>
        /// <param name="tokens">
        /// </param>
        /// <param name="pipelineLayoutCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Multivendor.IndirectCommandsLayout CreateIndirectCommandsLayout(this SharpVk.Device extendedHandle, SharpVk.ShaderStageFlags shaderStages, uint indirectStride, SharpVk.PipelineLayout pipelineLayout, ArrayProxy<SharpVk.Multivendor.IndirectCommandsLayoutToken>? tokens, SharpVk.Multivendor.IndirectCommandsLayoutUsageFlags? flags = default(SharpVk.Multivendor.IndirectCommandsLayoutUsageFlags?), SharpVk.PipelineLayoutCreateInfo? pipelineLayoutCreateInfo = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Multivendor.IndirectCommandsLayout result = default(SharpVk.Multivendor.IndirectCommandsLayout);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.IndirectCommandsLayoutCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Multivendor.IndirectCommandsLayoutCreateInfo*);
                void* vkIndirectCommandsLayoutCreateInfoEXTNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Multivendor.IndirectCommandsLayout marshalledIndirectCommandsLayout = default(SharpVk.Interop.Multivendor.IndirectCommandsLayout);
                if (pipelineLayoutCreateInfo != null)
                {
                    SharpVk.Interop.PipelineLayoutCreateInfo* extensionPointer = default(SharpVk.Interop.PipelineLayoutCreateInfo*);
                    extensionPointer = (SharpVk.Interop.PipelineLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineLayoutCreateInfo>());
                    pipelineLayoutCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkIndirectCommandsLayoutCreateInfoEXTNextPointer;
                    vkIndirectCommandsLayoutCreateInfoEXTNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.IndirectCommandsLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.IndirectCommandsLayoutCreateInfo>());
                marshalledCreateInfo->SType = StructureType.IndirectCommandsLayoutCreateInfoExt;
                marshalledCreateInfo->Next = vkIndirectCommandsLayoutCreateInfoEXTNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Multivendor.IndirectCommandsLayoutUsageFlags);
                }
                marshalledCreateInfo->ShaderStages = shaderStages;
                marshalledCreateInfo->IndirectStride = indirectStride;
                marshalledCreateInfo->PipelineLayout = pipelineLayout?.handle ?? default(SharpVk.Interop.PipelineLayout);
                marshalledCreateInfo->TokenCount = (uint)(Interop.HeapUtil.GetLength(tokens));
                if (tokens.IsNull())
                {
                    marshalledCreateInfo->Tokens = null;
                }
                else
                {
                    if (tokens.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Tokens = (SharpVk.Interop.Multivendor.IndirectCommandsLayoutToken*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.IndirectCommandsLayoutToken>());
                        tokens.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.IndirectCommandsLayoutToken*)(marshalledCreateInfo->Tokens));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.IndirectCommandsLayoutToken*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.IndirectCommandsLayoutToken>(Interop.HeapUtil.GetLength(tokens.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(tokens.Value)); index++)
                        {
                            tokens.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfo->Tokens = fieldPointer;
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
                SharpVk.Interop.Multivendor.VkDeviceCreateIndirectCommandsLayoutDelegate commandDelegate = commandCache.Cache.vkCreateIndirectCommandsLayoutEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledIndirectCommandsLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Multivendor.IndirectCommandsLayout(extendedHandle, marshalledIndirectCommandsLayout);
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
        /// <param name="type">
        /// </param>
        /// <param name="info">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Multivendor.IndirectExecutionSet CreateIndirectExecutionSet(this SharpVk.Device extendedHandle, SharpVk.Multivendor.IndirectExecutionSetInfoType type, SharpVk.Multivendor.IndirectExecutionSetInfo info, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Multivendor.IndirectExecutionSet result = default(SharpVk.Multivendor.IndirectExecutionSet);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.IndirectExecutionSetCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Multivendor.IndirectExecutionSetCreateInfo*);
                void* vkIndirectExecutionSetCreateInfoEXTNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Multivendor.IndirectExecutionSet marshalledIndirectExecutionSet = default(SharpVk.Interop.Multivendor.IndirectExecutionSet);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.IndirectExecutionSetCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.IndirectExecutionSetCreateInfo>());
                marshalledCreateInfo->SType = StructureType.IndirectExecutionSetCreateInfo;
                marshalledCreateInfo->Next = vkIndirectExecutionSetCreateInfoEXTNextPointer;
                marshalledCreateInfo->Type = type;
                marshalledCreateInfo->Info = info;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Multivendor.VkDeviceCreateIndirectExecutionSetDelegate commandDelegate = commandCache.Cache.vkCreateIndirectExecutionSetEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledIndirectExecutionSet);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Multivendor.IndirectExecutionSet(extendedHandle, marshalledIndirectExecutionSet);
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
        /// <param name="getMetalHandleInfo">
        /// </param>
        public static unsafe IntPtr GetMemoryMetalHandle(this SharpVk.Device extendedHandle, SharpVk.Multivendor.MemoryGetMetalHandleInfo getMetalHandleInfo)
        {
            try
            {
                IntPtr result = default(IntPtr);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.MemoryGetMetalHandleInfo* marshalledGetMetalHandleInfo = default(SharpVk.Interop.Multivendor.MemoryGetMetalHandleInfo*);
                void* marshalledHandle = default(void*);
                commandCache = extendedHandle.commandCache;
                marshalledGetMetalHandleInfo = (SharpVk.Interop.Multivendor.MemoryGetMetalHandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.MemoryGetMetalHandleInfo>());
                getMetalHandleInfo.MarshalTo(marshalledGetMetalHandleInfo);
                SharpVk.Interop.Multivendor.VkDeviceGetMemoryMetalHandleDelegate commandDelegate = commandCache.Cache.vkGetMemoryMetalHandleEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetMetalHandleInfo, &marshalledHandle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new IntPtr(marshalledHandle);
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
        /// <param name="handle">
        /// </param>
        public static unsafe SharpVk.Multivendor.MemoryMetalHandleProperties GetMemoryMetalHandleProperties(this SharpVk.Device extendedHandle, SharpVk.ExternalMemoryHandleTypeFlags handleType, IntPtr handle)
        {
            try
            {
                SharpVk.Multivendor.MemoryMetalHandleProperties result = default(SharpVk.Multivendor.MemoryMetalHandleProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.MemoryMetalHandleProperties marshalledMemoryMetalHandleProperties = default(SharpVk.Interop.Multivendor.MemoryMetalHandleProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkDeviceGetMemoryMetalHandlePropertiesDelegate commandDelegate = commandCache.Cache.vkGetMemoryMetalHandlePropertiesEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, handleType, handle.ToPointer(), &marshalledMemoryMetalHandleProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Multivendor.MemoryMetalHandleProperties.MarshalFrom(&marshalledMemoryMetalHandleProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
