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
    public static class DeviceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="tensors">
        /// </param>
        public static unsafe SharpVk.Multivendor.HostAddressRange[] GetTensorOpaqueCaptureData(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Arm.Tensor>? tensors)
        {
            try
            {
                SharpVk.Multivendor.HostAddressRange[] result = default(SharpVk.Multivendor.HostAddressRange[]);
                CommandCache commandCache = default(CommandCache);
                uint marshalledTensorCount = default(uint);
                SharpVk.Interop.Arm.Tensor* marshalledTensors = default(SharpVk.Interop.Arm.Tensor*);
                SharpVk.Interop.Multivendor.HostAddressRange* marshalledDatas = default(SharpVk.Interop.Multivendor.HostAddressRange*);
                commandCache = extendedHandle.commandCache;
                marshalledTensorCount = (uint)(Interop.HeapUtil.GetLength(tensors));
                if (tensors.IsNull())
                {
                    marshalledTensors = null;
                }
                else
                {
                    if (tensors.Value.Contents == ProxyContents.Single)
                    {
                        marshalledTensors = (SharpVk.Interop.Arm.Tensor*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.Tensor>());
                        *(SharpVk.Interop.Arm.Tensor*)(marshalledTensors) = tensors.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Arm.Tensor);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Arm.Tensor*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Arm.Tensor>(Interop.HeapUtil.GetLength(tensors.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(tensors.Value)); index++)
                        {
                            fieldPointer[index] = tensors.Value[index]?.handle ?? default(SharpVk.Interop.Arm.Tensor);
                        }
                        marshalledTensors = fieldPointer;
                    }
                }
                marshalledDatas = (SharpVk.Interop.Multivendor.HostAddressRange*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.HostAddressRange>(marshalledTensorCount));
                SharpVk.Interop.Arm.VkDeviceGetTensorOpaqueCaptureDataDelegate commandDelegate = commandCache.Cache.vkGetTensorOpaqueCaptureDataARM;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledTensorCount, marshalledTensors, marshalledDatas);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledDatas != null)
                {
                    var fieldPointer = new SharpVk.Multivendor.HostAddressRange[(uint)(marshalledTensorCount)];
                    for(int index = 0; index < (uint)(marshalledTensorCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Multivendor.HostAddressRange.MarshalFrom(&marshalledDatas[index]);
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
        /// <param name="tensors">
        /// </param>
        public static unsafe SharpVk.Multivendor.HostAddressRange GetTensorOpaqueCaptureData(this SharpVk.Device extendedHandle, SharpVk.Arm.Tensor tensors)
        {
            try
            {
                SharpVk.Multivendor.HostAddressRange result = default(SharpVk.Multivendor.HostAddressRange);
                CommandCache commandCache = default(CommandCache);
                uint marshalledTensorCount = default(uint);
                SharpVk.Interop.Arm.Tensor* marshalledTensors = default(SharpVk.Interop.Arm.Tensor*);
                SharpVk.Interop.Multivendor.HostAddressRange* marshalledDatas = default(SharpVk.Interop.Multivendor.HostAddressRange*);
                commandCache = extendedHandle.commandCache;
                marshalledTensorCount = 1;
                marshalledTensors = (SharpVk.Interop.Arm.Tensor*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.Tensor>());
                *marshalledTensors = tensors.handle;
                marshalledDatas = (SharpVk.Interop.Multivendor.HostAddressRange*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.HostAddressRange>(1));
                SharpVk.Interop.Arm.VkDeviceGetTensorOpaqueCaptureDataDelegate commandDelegate = commandCache.Cache.vkGetTensorOpaqueCaptureDataARM;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledTensorCount, marshalledTensors, marshalledDatas);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Multivendor.HostAddressRange.MarshalFrom(marshalledDatas);
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
        /// <param name="description">
        /// </param>
        /// <param name="sharingMode">
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="opaqueCaptureDescriptorDataCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="tensorRollingBackingCreateInfoArm">
        /// Extension struct
        /// </param>
        /// <param name="externalMemoryTensorCreateInfoArm">
        /// Extension struct
        /// </param>
        /// <param name="opaqueCaptureDataCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Arm.Tensor CreateTensor(this SharpVk.Device extendedHandle, SharpVk.Arm.TensorDescription description, SharpVk.SharingMode sharingMode, ArrayProxy<uint>? queueFamilyIndices, SharpVk.Arm.TensorCreateFlags? flags = default(SharpVk.Arm.TensorCreateFlags?), SharpVk.Multivendor.OpaqueCaptureDescriptorDataCreateInfo? opaqueCaptureDescriptorDataCreateInfoExt = null, SharpVk.Arm.TensorRollingBackingCreateInfo? tensorRollingBackingCreateInfoArm = null, SharpVk.Arm.ExternalMemoryTensorCreateInfo? externalMemoryTensorCreateInfoArm = null, SharpVk.Multivendor.OpaqueCaptureDataCreateInfo? opaqueCaptureDataCreateInfoExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Arm.Tensor result = default(SharpVk.Arm.Tensor);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.TensorCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Arm.TensorCreateInfo*);
                void* vkTensorCreateInfoARMNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Arm.Tensor marshalledTensor = default(SharpVk.Interop.Arm.Tensor);
                if (opaqueCaptureDescriptorDataCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.OpaqueCaptureDescriptorDataCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.OpaqueCaptureDescriptorDataCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.OpaqueCaptureDescriptorDataCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.OpaqueCaptureDescriptorDataCreateInfo>());
                    opaqueCaptureDescriptorDataCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkTensorCreateInfoARMNextPointer;
                    vkTensorCreateInfoARMNextPointer = extensionPointer;
                }
                if (tensorRollingBackingCreateInfoArm != null)
                {
                    SharpVk.Interop.Arm.TensorRollingBackingCreateInfo* extensionPointer = default(SharpVk.Interop.Arm.TensorRollingBackingCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Arm.TensorRollingBackingCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.TensorRollingBackingCreateInfo>());
                    tensorRollingBackingCreateInfoArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkTensorCreateInfoARMNextPointer;
                    vkTensorCreateInfoARMNextPointer = extensionPointer;
                }
                if (externalMemoryTensorCreateInfoArm != null)
                {
                    SharpVk.Interop.Arm.ExternalMemoryTensorCreateInfo* extensionPointer = default(SharpVk.Interop.Arm.ExternalMemoryTensorCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Arm.ExternalMemoryTensorCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.ExternalMemoryTensorCreateInfo>());
                    externalMemoryTensorCreateInfoArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkTensorCreateInfoARMNextPointer;
                    vkTensorCreateInfoARMNextPointer = extensionPointer;
                }
                if (opaqueCaptureDataCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.OpaqueCaptureDataCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.OpaqueCaptureDataCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.OpaqueCaptureDataCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.OpaqueCaptureDataCreateInfo>());
                    opaqueCaptureDataCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkTensorCreateInfoARMNextPointer;
                    vkTensorCreateInfoARMNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Arm.TensorCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.TensorCreateInfo>());
                marshalledCreateInfo->SType = StructureType.TensorCreateInfo;
                marshalledCreateInfo->Next = vkTensorCreateInfoARMNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Arm.TensorCreateFlags);
                }
                marshalledCreateInfo->Description = (SharpVk.Interop.Arm.TensorDescription*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.TensorDescription>());
                description.MarshalTo(marshalledCreateInfo->Description);
                marshalledCreateInfo->SharingMode = sharingMode;
                marshalledCreateInfo->QueueFamilyIndexCount = (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices));
                if (queueFamilyIndices.IsNull())
                {
                    marshalledCreateInfo->QueueFamilyIndices = null;
                }
                else
                {
                    if (queueFamilyIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->QueueFamilyIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfo->QueueFamilyIndices) = queueFamilyIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)); index++)
                        {
                            fieldPointer[index] = queueFamilyIndices.Value[index];
                        }
                        marshalledCreateInfo->QueueFamilyIndices = fieldPointer;
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
                SharpVk.Interop.Arm.VkDeviceCreateTensorDelegate commandDelegate = commandCache.Cache.vkCreateTensorARM;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledTensor);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Arm.Tensor(extendedHandle, marshalledTensor);
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
        /// <param name="tensor">
        /// </param>
        /// <param name="format">
        /// </param>
        /// <param name="opaqueCaptureDescriptorDataCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Arm.TensorView CreateTensorView(this SharpVk.Device extendedHandle, SharpVk.Arm.Tensor tensor, SharpVk.Format format, SharpVk.Arm.TensorViewCreateFlags? flags = default(SharpVk.Arm.TensorViewCreateFlags?), SharpVk.Multivendor.OpaqueCaptureDescriptorDataCreateInfo? opaqueCaptureDescriptorDataCreateInfoExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Arm.TensorView result = default(SharpVk.Arm.TensorView);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.TensorViewCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Arm.TensorViewCreateInfo*);
                void* vkTensorViewCreateInfoARMNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Arm.TensorView marshalledView = default(SharpVk.Interop.Arm.TensorView);
                if (opaqueCaptureDescriptorDataCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.OpaqueCaptureDescriptorDataCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.OpaqueCaptureDescriptorDataCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.OpaqueCaptureDescriptorDataCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.OpaqueCaptureDescriptorDataCreateInfo>());
                    opaqueCaptureDescriptorDataCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkTensorViewCreateInfoARMNextPointer;
                    vkTensorViewCreateInfoARMNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Arm.TensorViewCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.TensorViewCreateInfo>());
                marshalledCreateInfo->SType = StructureType.TensorViewCreateInfo;
                marshalledCreateInfo->Next = vkTensorViewCreateInfoARMNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Arm.TensorViewCreateFlags);
                }
                marshalledCreateInfo->Tensor = tensor?.handle ?? default(SharpVk.Interop.Arm.Tensor);
                marshalledCreateInfo->Format = format;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Arm.VkDeviceCreateTensorViewDelegate commandDelegate = commandCache.Cache.vkCreateTensorViewARM;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledView);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Arm.TensorView(extendedHandle, marshalledView);
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
        public static unsafe SharpVk.MemoryRequirements2 GetTensorMemoryRequirements(this SharpVk.Device extendedHandle, SharpVk.Arm.TensorMemoryRequirementsInfo info)
        {
            try
            {
                SharpVk.MemoryRequirements2 result = default(SharpVk.MemoryRequirements2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.TensorMemoryRequirementsInfo* marshalledInfo = default(SharpVk.Interop.Arm.TensorMemoryRequirementsInfo*);
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default(SharpVk.Interop.MemoryRequirements2);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Arm.TensorMemoryRequirementsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.TensorMemoryRequirementsInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Arm.VkDeviceGetTensorMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetTensorMemoryRequirementsARM;
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
        /// <param name="bindInfos">
        /// </param>
        public static unsafe void BindTensorMemory(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Arm.BindTensorMemoryInfo>? bindInfos)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.BindTensorMemoryInfo* marshalledBindInfos = default(SharpVk.Interop.Arm.BindTensorMemoryInfo*);
                commandCache = extendedHandle.commandCache;
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (SharpVk.Interop.Arm.BindTensorMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.BindTensorMemoryInfo>());
                        bindInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Arm.BindTensorMemoryInfo*)(marshalledBindInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Arm.BindTensorMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Arm.BindTensorMemoryInfo>(Interop.HeapUtil.GetLength(bindInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfos.Value)); index++)
                        {
                            bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.Arm.VkDeviceBindTensorMemoryDelegate commandDelegate = commandCache.Cache.vkBindTensorMemoryARM;
                Result methodResult = commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(bindInfos)), marshalledBindInfos);
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
        public static unsafe SharpVk.MemoryRequirements2 GetDeviceTensorMemoryRequirements(this SharpVk.Device extendedHandle, SharpVk.Arm.DeviceTensorMemoryRequirements info)
        {
            try
            {
                SharpVk.MemoryRequirements2 result = default(SharpVk.MemoryRequirements2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.DeviceTensorMemoryRequirements* marshalledInfo = default(SharpVk.Interop.Arm.DeviceTensorMemoryRequirements*);
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default(SharpVk.Interop.MemoryRequirements2);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Arm.DeviceTensorMemoryRequirements*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DeviceTensorMemoryRequirements>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Arm.VkDeviceGetDeviceTensorMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetDeviceTensorMemoryRequirementsARM;
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
        /// <param name="info">
        /// </param>
        /// <param name="data">
        /// </param>
        public static unsafe void GetTensorOpaqueCaptureDescriptorData(this SharpVk.Device extendedHandle, SharpVk.Arm.TensorCaptureDescriptorDataInfo info, IntPtr data)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.TensorCaptureDescriptorDataInfo* marshalledInfo = default(SharpVk.Interop.Arm.TensorCaptureDescriptorDataInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Arm.TensorCaptureDescriptorDataInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.TensorCaptureDescriptorDataInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Arm.VkDeviceGetTensorOpaqueCaptureDescriptorDataDelegate commandDelegate = commandCache.Cache.vkGetTensorOpaqueCaptureDescriptorDataARM;
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
        public static unsafe void GetTensorViewOpaqueCaptureDescriptorData(this SharpVk.Device extendedHandle, SharpVk.Arm.TensorViewCaptureDescriptorDataInfo info, IntPtr data)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.TensorViewCaptureDescriptorDataInfo* marshalledInfo = default(SharpVk.Interop.Arm.TensorViewCaptureDescriptorDataInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Arm.TensorViewCaptureDescriptorDataInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.TensorViewCaptureDescriptorDataInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Arm.VkDeviceGetTensorViewOpaqueCaptureDescriptorDataDelegate commandDelegate = commandCache.Cache.vkGetTensorViewOpaqueCaptureDescriptorDataARM;
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
        /// <param name="deferredOperation">
        /// </param>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Pipeline[] CreateDataGraphPipelines(this SharpVk.Device extendedHandle, SharpVk.Khronos.DeferredOperation deferredOperation, SharpVk.PipelineCache pipelineCache, ArrayProxy<SharpVk.Arm.DataGraphPipelineCreateInfo>? createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline[] result = default(SharpVk.Pipeline[]);
                CommandCache commandCache = default(CommandCache);
                uint marshalledCreateInfoCount = default(uint);
                SharpVk.Interop.Arm.DataGraphPipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Arm.DataGraphPipelineCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
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
                        marshalledCreateInfos = (SharpVk.Interop.Arm.DataGraphPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Arm.DataGraphPipelineCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Arm.DataGraphPipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Arm.DataGraphPipelineCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
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
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(marshalledCreateInfoCount));
                SharpVk.Interop.Arm.VkDeviceCreateDataGraphPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateDataGraphPipelinesARM;
                Result methodResult = commandDelegate(extendedHandle.handle, deferredOperation?.handle ?? default(SharpVk.Interop.Khronos.DeferredOperation), pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new SharpVk.Pipeline[(uint)(marshalledCreateInfoCount)];
                    for(int index = 0; index < (uint)(marshalledCreateInfoCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Pipeline(extendedHandle, marshalledPipelines[index]);
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
        /// <param name="deferredOperation">
        /// </param>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="layout">
        /// </param>
        /// <param name="resourceInfos">
        /// </param>
        /// <param name="shaderModuleCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="pipelineCreationFeedbackCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="dataGraphPipelineNeuralStatisticsCreateInfoArm">
        /// Extension struct
        /// </param>
        /// <param name="dataGraphPipelineCompilerControlCreateInfoArm">
        /// Extension struct
        /// </param>
        /// <param name="dataGraphPipelineShaderModuleCreateInfoArm">
        /// Extension struct
        /// </param>
        /// <param name="dataGraphPipelineIdentifierCreateInfoArm">
        /// Extension struct
        /// </param>
        /// <param name="dataGraphProcessingEngineCreateInfoArm">
        /// Extension struct
        /// </param>
        /// <param name="dataGraphPipelineBuiltinModelCreateInfoQcom">
        /// Extension struct
        /// </param>
        /// <param name="dataGraphPipelineSingleNodeCreateInfoArm">
        /// Extension struct
        /// </param>
        /// <param name="dataGraphPipelineOpticalFlowCreateInfoArm">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Pipeline CreateDataGraphPipeline(this SharpVk.Device extendedHandle, SharpVk.Khronos.DeferredOperation deferredOperation, SharpVk.PipelineCache pipelineCache, SharpVk.PipelineLayout layout, ArrayProxy<SharpVk.Arm.DataGraphPipelineResourceInfo>? resourceInfos, SharpVk.PipelineCreateFlags2? flags = default(SharpVk.PipelineCreateFlags2?), SharpVk.ShaderModuleCreateInfo? shaderModuleCreateInfo = null, SharpVk.PipelineCreationFeedbackCreateInfo? pipelineCreationFeedbackCreateInfo = null, SharpVk.Arm.DataGraphPipelineNeuralStatisticsCreateInfo? dataGraphPipelineNeuralStatisticsCreateInfoArm = null, SharpVk.Arm.DataGraphPipelineCompilerControlCreateInfo? dataGraphPipelineCompilerControlCreateInfoArm = null, SharpVk.Arm.DataGraphPipelineShaderModuleCreateInfo? dataGraphPipelineShaderModuleCreateInfoArm = null, SharpVk.Arm.DataGraphPipelineIdentifierCreateInfo? dataGraphPipelineIdentifierCreateInfoArm = null, SharpVk.Arm.DataGraphProcessingEngineCreateInfo? dataGraphProcessingEngineCreateInfoArm = null, SharpVk.Qcom.DataGraphPipelineBuiltinModelCreateInfo? dataGraphPipelineBuiltinModelCreateInfoQcom = null, SharpVk.Arm.DataGraphPipelineSingleNodeCreateInfo? dataGraphPipelineSingleNodeCreateInfoArm = null, SharpVk.Arm.DataGraphPipelineOpticalFlowCreateInfo? dataGraphPipelineOpticalFlowCreateInfoArm = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline result = default(SharpVk.Pipeline);
                CommandCache commandCache = default(CommandCache);
                uint marshalledCreateInfoCount = default(uint);
                SharpVk.Interop.Arm.DataGraphPipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Arm.DataGraphPipelineCreateInfo*);
                void* vkDataGraphPipelineCreateInfoARMNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
                if (shaderModuleCreateInfo != null)
                {
                    SharpVk.Interop.ShaderModuleCreateInfo* extensionPointer = default(SharpVk.Interop.ShaderModuleCreateInfo*);
                    extensionPointer = (SharpVk.Interop.ShaderModuleCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ShaderModuleCreateInfo>());
                    shaderModuleCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDataGraphPipelineCreateInfoARMNextPointer;
                    vkDataGraphPipelineCreateInfoARMNextPointer = extensionPointer;
                }
                if (pipelineCreationFeedbackCreateInfo != null)
                {
                    SharpVk.Interop.PipelineCreationFeedbackCreateInfo* extensionPointer = default(SharpVk.Interop.PipelineCreationFeedbackCreateInfo*);
                    extensionPointer = (SharpVk.Interop.PipelineCreationFeedbackCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineCreationFeedbackCreateInfo>());
                    pipelineCreationFeedbackCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDataGraphPipelineCreateInfoARMNextPointer;
                    vkDataGraphPipelineCreateInfoARMNextPointer = extensionPointer;
                }
                if (dataGraphPipelineNeuralStatisticsCreateInfoArm != null)
                {
                    SharpVk.Interop.Arm.DataGraphPipelineNeuralStatisticsCreateInfo* extensionPointer = default(SharpVk.Interop.Arm.DataGraphPipelineNeuralStatisticsCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Arm.DataGraphPipelineNeuralStatisticsCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineNeuralStatisticsCreateInfo>());
                    dataGraphPipelineNeuralStatisticsCreateInfoArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDataGraphPipelineCreateInfoARMNextPointer;
                    vkDataGraphPipelineCreateInfoARMNextPointer = extensionPointer;
                }
                if (dataGraphPipelineCompilerControlCreateInfoArm != null)
                {
                    SharpVk.Interop.Arm.DataGraphPipelineCompilerControlCreateInfo* extensionPointer = default(SharpVk.Interop.Arm.DataGraphPipelineCompilerControlCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Arm.DataGraphPipelineCompilerControlCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineCompilerControlCreateInfo>());
                    dataGraphPipelineCompilerControlCreateInfoArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDataGraphPipelineCreateInfoARMNextPointer;
                    vkDataGraphPipelineCreateInfoARMNextPointer = extensionPointer;
                }
                if (dataGraphPipelineShaderModuleCreateInfoArm != null)
                {
                    SharpVk.Interop.Arm.DataGraphPipelineShaderModuleCreateInfo* extensionPointer = default(SharpVk.Interop.Arm.DataGraphPipelineShaderModuleCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Arm.DataGraphPipelineShaderModuleCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineShaderModuleCreateInfo>());
                    dataGraphPipelineShaderModuleCreateInfoArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDataGraphPipelineCreateInfoARMNextPointer;
                    vkDataGraphPipelineCreateInfoARMNextPointer = extensionPointer;
                }
                if (dataGraphPipelineIdentifierCreateInfoArm != null)
                {
                    SharpVk.Interop.Arm.DataGraphPipelineIdentifierCreateInfo* extensionPointer = default(SharpVk.Interop.Arm.DataGraphPipelineIdentifierCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Arm.DataGraphPipelineIdentifierCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineIdentifierCreateInfo>());
                    dataGraphPipelineIdentifierCreateInfoArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDataGraphPipelineCreateInfoARMNextPointer;
                    vkDataGraphPipelineCreateInfoARMNextPointer = extensionPointer;
                }
                if (dataGraphProcessingEngineCreateInfoArm != null)
                {
                    SharpVk.Interop.Arm.DataGraphProcessingEngineCreateInfo* extensionPointer = default(SharpVk.Interop.Arm.DataGraphProcessingEngineCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Arm.DataGraphProcessingEngineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphProcessingEngineCreateInfo>());
                    dataGraphProcessingEngineCreateInfoArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDataGraphPipelineCreateInfoARMNextPointer;
                    vkDataGraphPipelineCreateInfoARMNextPointer = extensionPointer;
                }
                if (dataGraphPipelineBuiltinModelCreateInfoQcom != null)
                {
                    SharpVk.Interop.Qcom.DataGraphPipelineBuiltinModelCreateInfo* extensionPointer = default(SharpVk.Interop.Qcom.DataGraphPipelineBuiltinModelCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Qcom.DataGraphPipelineBuiltinModelCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.DataGraphPipelineBuiltinModelCreateInfo>());
                    dataGraphPipelineBuiltinModelCreateInfoQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDataGraphPipelineCreateInfoARMNextPointer;
                    vkDataGraphPipelineCreateInfoARMNextPointer = extensionPointer;
                }
                if (dataGraphPipelineSingleNodeCreateInfoArm != null)
                {
                    SharpVk.Interop.Arm.DataGraphPipelineSingleNodeCreateInfo* extensionPointer = default(SharpVk.Interop.Arm.DataGraphPipelineSingleNodeCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Arm.DataGraphPipelineSingleNodeCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineSingleNodeCreateInfo>());
                    dataGraphPipelineSingleNodeCreateInfoArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDataGraphPipelineCreateInfoARMNextPointer;
                    vkDataGraphPipelineCreateInfoARMNextPointer = extensionPointer;
                }
                if (dataGraphPipelineOpticalFlowCreateInfoArm != null)
                {
                    SharpVk.Interop.Arm.DataGraphPipelineOpticalFlowCreateInfo* extensionPointer = default(SharpVk.Interop.Arm.DataGraphPipelineOpticalFlowCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Arm.DataGraphPipelineOpticalFlowCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineOpticalFlowCreateInfo>());
                    dataGraphPipelineOpticalFlowCreateInfoArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDataGraphPipelineCreateInfoARMNextPointer;
                    vkDataGraphPipelineCreateInfoARMNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfoCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.Arm.DataGraphPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineCreateInfo>());
                marshalledCreateInfos->SType = StructureType.DataGraphPipelineCreateInfo;
                marshalledCreateInfos->Next = vkDataGraphPipelineCreateInfoARMNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfos->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfos->Flags = default(SharpVk.PipelineCreateFlags2);
                }
                marshalledCreateInfos->Layout = layout?.handle ?? default(SharpVk.Interop.PipelineLayout);
                marshalledCreateInfos->ResourceInfoCount = (uint)(Interop.HeapUtil.GetLength(resourceInfos));
                if (resourceInfos.IsNull())
                {
                    marshalledCreateInfos->ResourceInfos = null;
                }
                else
                {
                    if (resourceInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->ResourceInfos = (SharpVk.Interop.Arm.DataGraphPipelineResourceInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineResourceInfo>());
                        resourceInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Arm.DataGraphPipelineResourceInfo*)(marshalledCreateInfos->ResourceInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Arm.DataGraphPipelineResourceInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Arm.DataGraphPipelineResourceInfo>(Interop.HeapUtil.GetLength(resourceInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(resourceInfos.Value)); index++)
                        {
                            resourceInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos->ResourceInfos = fieldPointer;
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
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(1));
                SharpVk.Interop.Arm.VkDeviceCreateDataGraphPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateDataGraphPipelinesARM;
                Result methodResult = commandDelegate(extendedHandle.handle, deferredOperation?.handle ?? default(SharpVk.Interop.Khronos.DeferredOperation), pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Pipeline(extendedHandle, *marshalledPipelines);
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
        /// <param name="dataGraphPipeline">
        /// </param>
        /// <param name="dataGraphPipelineSessionNeuralStatisticsCreateInfoArm">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Arm.DataGraphPipelineSession CreateDataGraphPipelineSession(this SharpVk.Device extendedHandle, SharpVk.Pipeline dataGraphPipeline, SharpVk.Arm.DataGraphPipelineSessionCreateFlags? flags = default(SharpVk.Arm.DataGraphPipelineSessionCreateFlags?), SharpVk.Arm.DataGraphPipelineSessionNeuralStatisticsCreateInfo? dataGraphPipelineSessionNeuralStatisticsCreateInfoArm = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Arm.DataGraphPipelineSession result = default(SharpVk.Arm.DataGraphPipelineSession);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.DataGraphPipelineSessionCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Arm.DataGraphPipelineSessionCreateInfo*);
                void* vkDataGraphPipelineSessionCreateInfoARMNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Arm.DataGraphPipelineSession marshalledSession = default(SharpVk.Interop.Arm.DataGraphPipelineSession);
                if (dataGraphPipelineSessionNeuralStatisticsCreateInfoArm != null)
                {
                    SharpVk.Interop.Arm.DataGraphPipelineSessionNeuralStatisticsCreateInfo* extensionPointer = default(SharpVk.Interop.Arm.DataGraphPipelineSessionNeuralStatisticsCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Arm.DataGraphPipelineSessionNeuralStatisticsCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineSessionNeuralStatisticsCreateInfo>());
                    dataGraphPipelineSessionNeuralStatisticsCreateInfoArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDataGraphPipelineSessionCreateInfoARMNextPointer;
                    vkDataGraphPipelineSessionCreateInfoARMNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Arm.DataGraphPipelineSessionCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineSessionCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DataGraphPipelineSessionCreateInfo;
                marshalledCreateInfo->Next = vkDataGraphPipelineSessionCreateInfoARMNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Arm.DataGraphPipelineSessionCreateFlags);
                }
                marshalledCreateInfo->DataGraphPipeline = dataGraphPipeline?.handle ?? default(SharpVk.Interop.Pipeline);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Arm.VkDeviceCreateDataGraphPipelineSessionDelegate commandDelegate = commandCache.Cache.vkCreateDataGraphPipelineSessionARM;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSession);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Arm.DataGraphPipelineSession(extendedHandle, marshalledSession);
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
        public static unsafe SharpVk.Arm.DataGraphPipelineSessionBindPointRequirement[] GetDataGraphPipelineSessionBindPointRequirements(this SharpVk.Device extendedHandle, SharpVk.Arm.DataGraphPipelineSessionBindPointRequirementsInfo info)
        {
            try
            {
                SharpVk.Arm.DataGraphPipelineSessionBindPointRequirement[] result = default(SharpVk.Arm.DataGraphPipelineSessionBindPointRequirement[]);
                uint marshalledBindPointRequirementCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.DataGraphPipelineSessionBindPointRequirementsInfo* marshalledInfo = default(SharpVk.Interop.Arm.DataGraphPipelineSessionBindPointRequirementsInfo*);
                SharpVk.Interop.Arm.DataGraphPipelineSessionBindPointRequirement* marshalledBindPointRequirements = default(SharpVk.Interop.Arm.DataGraphPipelineSessionBindPointRequirement*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Arm.DataGraphPipelineSessionBindPointRequirementsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineSessionBindPointRequirementsInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Arm.VkDeviceGetDataGraphPipelineSessionBindPointRequirementsDelegate commandDelegate = commandCache.Cache.vkGetDataGraphPipelineSessionBindPointRequirementsARM;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledInfo, &marshalledBindPointRequirementCount, marshalledBindPointRequirements);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledBindPointRequirements = (SharpVk.Interop.Arm.DataGraphPipelineSessionBindPointRequirement*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineSessionBindPointRequirement>((uint)(marshalledBindPointRequirementCount)));
                commandDelegate(extendedHandle.handle, marshalledInfo, &marshalledBindPointRequirementCount, marshalledBindPointRequirements);
                if (marshalledBindPointRequirements != null)
                {
                    var fieldPointer = new SharpVk.Arm.DataGraphPipelineSessionBindPointRequirement[(uint)(marshalledBindPointRequirementCount)];
                    for(int index = 0; index < (uint)(marshalledBindPointRequirementCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Arm.DataGraphPipelineSessionBindPointRequirement.MarshalFrom(&marshalledBindPointRequirements[index]);
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
        public static unsafe SharpVk.MemoryRequirements2 GetDataGraphPipelineSessionMemoryRequirements(this SharpVk.Device extendedHandle, SharpVk.Arm.DataGraphPipelineSessionMemoryRequirementsInfo info)
        {
            try
            {
                SharpVk.MemoryRequirements2 result = default(SharpVk.MemoryRequirements2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.DataGraphPipelineSessionMemoryRequirementsInfo* marshalledInfo = default(SharpVk.Interop.Arm.DataGraphPipelineSessionMemoryRequirementsInfo*);
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default(SharpVk.Interop.MemoryRequirements2);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Arm.DataGraphPipelineSessionMemoryRequirementsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineSessionMemoryRequirementsInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Arm.VkDeviceGetDataGraphPipelineSessionMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetDataGraphPipelineSessionMemoryRequirementsARM;
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
        /// <param name="bindInfos">
        /// </param>
        public static unsafe void BindDataGraphPipelineSessionMemory(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Arm.BindDataGraphPipelineSessionMemoryInfo>? bindInfos)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.BindDataGraphPipelineSessionMemoryInfo* marshalledBindInfos = default(SharpVk.Interop.Arm.BindDataGraphPipelineSessionMemoryInfo*);
                commandCache = extendedHandle.commandCache;
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (SharpVk.Interop.Arm.BindDataGraphPipelineSessionMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.BindDataGraphPipelineSessionMemoryInfo>());
                        bindInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Arm.BindDataGraphPipelineSessionMemoryInfo*)(marshalledBindInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Arm.BindDataGraphPipelineSessionMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Arm.BindDataGraphPipelineSessionMemoryInfo>(Interop.HeapUtil.GetLength(bindInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfos.Value)); index++)
                        {
                            bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.Arm.VkDeviceBindDataGraphPipelineSessionMemoryDelegate commandDelegate = commandCache.Cache.vkBindDataGraphPipelineSessionMemoryARM;
                Result methodResult = commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(bindInfos)), marshalledBindInfos);
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
        /// <param name="pipelineInfo">
        /// </param>
        public static unsafe SharpVk.Arm.DataGraphPipelineProperty[] GetDataGraphPipelineAvailableProperties(this SharpVk.Device extendedHandle, SharpVk.Arm.DataGraphPipelineInfo pipelineInfo)
        {
            try
            {
                SharpVk.Arm.DataGraphPipelineProperty[] result = default(SharpVk.Arm.DataGraphPipelineProperty[]);
                uint marshalledPropertiesCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.DataGraphPipelineInfo* marshalledPipelineInfo = default(SharpVk.Interop.Arm.DataGraphPipelineInfo*);
                SharpVk.Arm.DataGraphPipelineProperty* marshalledProperties = default(SharpVk.Arm.DataGraphPipelineProperty*);
                commandCache = extendedHandle.commandCache;
                marshalledPipelineInfo = (SharpVk.Interop.Arm.DataGraphPipelineInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineInfo>());
                pipelineInfo.MarshalTo(marshalledPipelineInfo);
                SharpVk.Interop.Arm.VkDeviceGetDataGraphPipelineAvailablePropertiesDelegate commandDelegate = commandCache.Cache.vkGetDataGraphPipelineAvailablePropertiesARM;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledPipelineInfo, &marshalledPropertiesCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Arm.DataGraphPipelineProperty*)(Interop.HeapUtil.Allocate<SharpVk.Arm.DataGraphPipelineProperty>((uint)(marshalledPropertiesCount)));
                commandDelegate(extendedHandle.handle, marshalledPipelineInfo, &marshalledPropertiesCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Arm.DataGraphPipelineProperty[(uint)(marshalledPropertiesCount)];
                    for(int index = 0; index < (uint)(marshalledPropertiesCount); index++)
                    {
                        fieldPointer[index] = marshalledProperties[index];
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
        /// <param name="pipelineInfo">
        /// </param>
        /// <param name="propertiesCount">
        /// </param>
        public static unsafe SharpVk.Arm.DataGraphPipelinePropertyQueryResult[] GetDataGraphPipelineProperties(this SharpVk.Device extendedHandle, SharpVk.Arm.DataGraphPipelineInfo pipelineInfo, uint propertiesCount)
        {
            try
            {
                SharpVk.Arm.DataGraphPipelinePropertyQueryResult[] result = default(SharpVk.Arm.DataGraphPipelinePropertyQueryResult[]);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.DataGraphPipelineInfo* marshalledPipelineInfo = default(SharpVk.Interop.Arm.DataGraphPipelineInfo*);
                uint marshalledPropertiesCount = default(uint);
                SharpVk.Interop.Arm.DataGraphPipelinePropertyQueryResult* marshalledProperties = default(SharpVk.Interop.Arm.DataGraphPipelinePropertyQueryResult*);
                commandCache = extendedHandle.commandCache;
                marshalledPipelineInfo = (SharpVk.Interop.Arm.DataGraphPipelineInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineInfo>());
                pipelineInfo.MarshalTo(marshalledPipelineInfo);
                marshalledPropertiesCount = propertiesCount;
                marshalledProperties = (SharpVk.Interop.Arm.DataGraphPipelinePropertyQueryResult*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelinePropertyQueryResult>(marshalledPropertiesCount));
                SharpVk.Interop.Arm.VkDeviceGetDataGraphPipelinePropertiesDelegate commandDelegate = commandCache.Cache.vkGetDataGraphPipelinePropertiesARM;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledPipelineInfo, marshalledPropertiesCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Arm.DataGraphPipelinePropertyQueryResult[(uint)(marshalledPropertiesCount)];
                    for(int index = 0; index < (uint)(marshalledPropertiesCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Arm.DataGraphPipelinePropertyQueryResult.MarshalFrom(&marshalledProperties[index]);
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
        /// <param name="pipelineInfo">
        /// </param>
        public static unsafe SharpVk.Arm.DataGraphPipelinePropertyQueryResult GetDataGraphPipelinePropertie(this SharpVk.Device extendedHandle, SharpVk.Arm.DataGraphPipelineInfo pipelineInfo)
        {
            try
            {
                SharpVk.Arm.DataGraphPipelinePropertyQueryResult result = default(SharpVk.Arm.DataGraphPipelinePropertyQueryResult);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.DataGraphPipelineInfo* marshalledPipelineInfo = default(SharpVk.Interop.Arm.DataGraphPipelineInfo*);
                uint marshalledPropertiesCount = default(uint);
                SharpVk.Interop.Arm.DataGraphPipelinePropertyQueryResult* marshalledProperties = default(SharpVk.Interop.Arm.DataGraphPipelinePropertyQueryResult*);
                commandCache = extendedHandle.commandCache;
                marshalledPipelineInfo = (SharpVk.Interop.Arm.DataGraphPipelineInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineInfo>());
                pipelineInfo.MarshalTo(marshalledPipelineInfo);
                marshalledPropertiesCount = 1;
                marshalledProperties = (SharpVk.Interop.Arm.DataGraphPipelinePropertyQueryResult*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelinePropertyQueryResult>(1));
                SharpVk.Interop.Arm.VkDeviceGetDataGraphPipelinePropertiesDelegate commandDelegate = commandCache.Cache.vkGetDataGraphPipelinePropertiesARM;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledPipelineInfo, marshalledPropertiesCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Arm.DataGraphPipelinePropertyQueryResult.MarshalFrom(marshalledProperties);
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
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Arm.ShaderInstrumentation CreateShaderInstrumentation(this SharpVk.Device extendedHandle, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Arm.ShaderInstrumentation result = default(SharpVk.Arm.ShaderInstrumentation);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.ShaderInstrumentationCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Arm.ShaderInstrumentationCreateInfo*);
                void* vkShaderInstrumentationCreateInfoARMNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Arm.ShaderInstrumentation marshalledInstrumentation = default(SharpVk.Interop.Arm.ShaderInstrumentation);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Arm.ShaderInstrumentationCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.ShaderInstrumentationCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ShaderInstrumentationCreateInfo;
                marshalledCreateInfo->Next = vkShaderInstrumentationCreateInfoARMNextPointer;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Arm.VkDeviceCreateShaderInstrumentationDelegate commandDelegate = commandCache.Cache.vkCreateShaderInstrumentationARM;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledInstrumentation);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Arm.ShaderInstrumentation(extendedHandle, marshalledInstrumentation);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
