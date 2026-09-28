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

namespace SharpVk.NVidia
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
        /// <param name="compactedSize">
        /// </param>
        /// <param name="info">
        /// </param>
        /// <param name="opaqueCaptureDescriptorDataCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.NVidia.AccelerationStructure CreateAccelerationStructure(this SharpVk.Device extendedHandle, ulong compactedSize, SharpVk.NVidia.AccelerationStructureInfo info, SharpVk.Multivendor.OpaqueCaptureDescriptorDataCreateInfo? opaqueCaptureDescriptorDataCreateInfoExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.AccelerationStructure result = default(SharpVk.NVidia.AccelerationStructure);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.AccelerationStructureCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.AccelerationStructureCreateInfo*);
                void* vkAccelerationStructureCreateInfoNVNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.AccelerationStructure marshalledAccelerationStructure = default(SharpVk.Interop.NVidia.AccelerationStructure);
                if (opaqueCaptureDescriptorDataCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.OpaqueCaptureDescriptorDataCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.OpaqueCaptureDescriptorDataCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.OpaqueCaptureDescriptorDataCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.OpaqueCaptureDescriptorDataCreateInfo>());
                    opaqueCaptureDescriptorDataCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkAccelerationStructureCreateInfoNVNextPointer;
                    vkAccelerationStructureCreateInfoNVNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.AccelerationStructureCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.AccelerationStructureCreateInfo>());
                marshalledCreateInfo->SType = StructureType.AccelerationStructureCreateInfoNv;
                marshalledCreateInfo->Next = vkAccelerationStructureCreateInfoNVNextPointer;
                marshalledCreateInfo->CompactedSize = compactedSize;
                info.MarshalTo(&marshalledCreateInfo->Info);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.NVidia.VkDeviceCreateAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCreateAccelerationStructureNV;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledAccelerationStructure);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.AccelerationStructure(extendedHandle, marshalledAccelerationStructure);
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
        public static unsafe SharpVk.MemoryRequirements2 GetAccelerationStructureMemoryRequirements(this SharpVk.Device extendedHandle, SharpVk.NVidia.AccelerationStructureMemoryRequirementsInfo info)
        {
            try
            {
                SharpVk.MemoryRequirements2 result = default(SharpVk.MemoryRequirements2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.AccelerationStructureMemoryRequirementsInfo* marshalledInfo = default(SharpVk.Interop.NVidia.AccelerationStructureMemoryRequirementsInfo*);
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default(SharpVk.Interop.MemoryRequirements2);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.AccelerationStructureMemoryRequirementsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.AccelerationStructureMemoryRequirementsInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.VkDeviceGetAccelerationStructureMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetAccelerationStructureMemoryRequirementsNV;
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
        public static unsafe void BindAccelerationStructureMemory(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.NVidia.BindAccelerationStructureMemoryInfo>? bindInfos)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo* marshalledBindInfos = default(SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo*);
                commandCache = extendedHandle.commandCache;
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo>());
                        bindInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo*)(marshalledBindInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo>(Interop.HeapUtil.GetLength(bindInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfos.Value)); index++)
                        {
                            bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkDeviceBindAccelerationStructureMemoryDelegate commandDelegate = commandCache.Cache.vkBindAccelerationStructureMemoryNV;
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
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Pipeline[] CreateRayTracingPipelines(this SharpVk.Device extendedHandle, SharpVk.PipelineCache pipelineCache, ArrayProxy<SharpVk.NVidia.RayTracingPipelineCreateInfo>? createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline[] result = default(SharpVk.Pipeline[]);
                CommandCache commandCache = default(CommandCache);
                uint marshalledCreateInfoCount = default(uint);
                SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*);
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
                        marshalledCreateInfos = (SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
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
                SharpVk.Interop.NVidia.VkDeviceCreateRayTracingPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateRayTracingPipelinesNV;
                Result methodResult = commandDelegate(extendedHandle.handle, pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
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
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="stages">
        /// </param>
        /// <param name="groups">
        /// </param>
        /// <param name="maxRecursionDepth">
        /// </param>
        /// <param name="layout">
        /// </param>
        /// <param name="basePipelineHandle">
        /// </param>
        /// <param name="basePipelineIndex">
        /// </param>
        /// <param name="pipelineCreateFlags2CreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="pipelineCreationFeedbackCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="pipelineOfflineCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Pipeline CreateRayTracingPipeline(this SharpVk.Device extendedHandle, SharpVk.PipelineCache pipelineCache, ArrayProxy<SharpVk.PipelineShaderStageCreateInfo>? stages, ArrayProxy<SharpVk.NVidia.RayTracingShaderGroupCreateInfo>? groups, uint maxRecursionDepth, SharpVk.PipelineLayout layout, SharpVk.Pipeline basePipelineHandle, int basePipelineIndex, SharpVk.PipelineCreateFlags? flags = default(SharpVk.PipelineCreateFlags?), SharpVk.PipelineCreateFlags2CreateInfo? pipelineCreateFlags2CreateInfo = null, SharpVk.PipelineCreationFeedbackCreateInfo? pipelineCreationFeedbackCreateInfo = null, SharpVk.PipelineOfflineCreateInfo? pipelineOfflineCreateInfo = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline result = default(SharpVk.Pipeline);
                CommandCache commandCache = default(CommandCache);
                uint marshalledCreateInfoCount = default(uint);
                SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*);
                void* vkRayTracingPipelineCreateInfoNVNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
                if (pipelineCreateFlags2CreateInfo != null)
                {
                    SharpVk.Interop.PipelineCreateFlags2CreateInfo* extensionPointer = default(SharpVk.Interop.PipelineCreateFlags2CreateInfo*);
                    extensionPointer = (SharpVk.Interop.PipelineCreateFlags2CreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineCreateFlags2CreateInfo>());
                    pipelineCreateFlags2CreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRayTracingPipelineCreateInfoNVNextPointer;
                    vkRayTracingPipelineCreateInfoNVNextPointer = extensionPointer;
                }
                if (pipelineCreationFeedbackCreateInfo != null)
                {
                    SharpVk.Interop.PipelineCreationFeedbackCreateInfo* extensionPointer = default(SharpVk.Interop.PipelineCreationFeedbackCreateInfo*);
                    extensionPointer = (SharpVk.Interop.PipelineCreationFeedbackCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineCreationFeedbackCreateInfo>());
                    pipelineCreationFeedbackCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRayTracingPipelineCreateInfoNVNextPointer;
                    vkRayTracingPipelineCreateInfoNVNextPointer = extensionPointer;
                }
                if (pipelineOfflineCreateInfo != null)
                {
                    SharpVk.Interop.PipelineOfflineCreateInfo* extensionPointer = default(SharpVk.Interop.PipelineOfflineCreateInfo*);
                    extensionPointer = (SharpVk.Interop.PipelineOfflineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineOfflineCreateInfo>());
                    pipelineOfflineCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRayTracingPipelineCreateInfoNVNextPointer;
                    vkRayTracingPipelineCreateInfoNVNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfoCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo>());
                marshalledCreateInfos->SType = StructureType.RayTracingPipelineCreateInfoNv;
                marshalledCreateInfos->Next = vkRayTracingPipelineCreateInfoNVNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfos->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfos->Flags = default(SharpVk.PipelineCreateFlags);
                }
                marshalledCreateInfos->StageCount = (uint)(Interop.HeapUtil.GetLength(stages));
                if (stages.IsNull())
                {
                    marshalledCreateInfos->Stages = null;
                }
                else
                {
                    if (stages.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Stages = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineShaderStageCreateInfo>());
                        stages.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.PipelineShaderStageCreateInfo*)(marshalledCreateInfos->Stages));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.PipelineShaderStageCreateInfo>(Interop.HeapUtil.GetLength(stages.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(stages.Value)); index++)
                        {
                            stages.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos->Stages = fieldPointer;
                    }
                }
                marshalledCreateInfos->GroupCount = (uint)(Interop.HeapUtil.GetLength(groups));
                if (groups.IsNull())
                {
                    marshalledCreateInfos->Groups = null;
                }
                else
                {
                    if (groups.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Groups = (SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo>());
                        groups.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo*)(marshalledCreateInfos->Groups));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo>(Interop.HeapUtil.GetLength(groups.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(groups.Value)); index++)
                        {
                            groups.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos->Groups = fieldPointer;
                    }
                }
                marshalledCreateInfos->MaxRecursionDepth = maxRecursionDepth;
                marshalledCreateInfos->Layout = layout?.handle ?? default(SharpVk.Interop.PipelineLayout);
                marshalledCreateInfos->BasePipelineHandle = basePipelineHandle?.handle ?? default(SharpVk.Interop.Pipeline);
                marshalledCreateInfos->BasePipelineIndex = basePipelineIndex;
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
                SharpVk.Interop.NVidia.VkDeviceCreateRayTracingPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateRayTracingPipelinesNV;
                Result methodResult = commandDelegate(extendedHandle.handle, pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
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
        /// <param name="info">
        /// </param>
        public static unsafe SharpVk.MemoryRequirements2 GetGeneratedCommandsMemoryRequirements(this SharpVk.Device extendedHandle, SharpVk.NVidia.GeneratedCommandsMemoryRequirementsInfo info)
        {
            try
            {
                SharpVk.MemoryRequirements2 result = default(SharpVk.MemoryRequirements2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.GeneratedCommandsMemoryRequirementsInfo* marshalledInfo = default(SharpVk.Interop.NVidia.GeneratedCommandsMemoryRequirementsInfo*);
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default(SharpVk.Interop.MemoryRequirements2);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.GeneratedCommandsMemoryRequirementsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.GeneratedCommandsMemoryRequirementsInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.VkDeviceGetGeneratedCommandsMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetGeneratedCommandsMemoryRequirementsNV;
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
        /// <param name="pipelineBindPoint">
        /// </param>
        /// <param name="tokens">
        /// </param>
        /// <param name="streamStrides">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.NVidia.IndirectCommandsLayout CreateIndirectCommandsLayout(this SharpVk.Device extendedHandle, SharpVk.PipelineBindPoint pipelineBindPoint, ArrayProxy<SharpVk.NVidia.IndirectCommandsLayoutToken>? tokens, ArrayProxy<uint>? streamStrides, SharpVk.NVidia.IndirectCommandsLayoutUsageFlags? flags = default(SharpVk.NVidia.IndirectCommandsLayoutUsageFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.IndirectCommandsLayout result = default(SharpVk.NVidia.IndirectCommandsLayout);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.IndirectCommandsLayoutCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.IndirectCommandsLayoutCreateInfo*);
                void* vkIndirectCommandsLayoutCreateInfoNVNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.IndirectCommandsLayout marshalledIndirectCommandsLayout = default(SharpVk.Interop.NVidia.IndirectCommandsLayout);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.IndirectCommandsLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.IndirectCommandsLayoutCreateInfo>());
                marshalledCreateInfo->SType = StructureType.IndirectCommandsLayoutCreateInfoNv;
                marshalledCreateInfo->Next = vkIndirectCommandsLayoutCreateInfoNVNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.NVidia.IndirectCommandsLayoutUsageFlags);
                }
                marshalledCreateInfo->PipelineBindPoint = pipelineBindPoint;
                marshalledCreateInfo->TokenCount = (uint)(Interop.HeapUtil.GetLength(tokens));
                if (tokens.IsNull())
                {
                    marshalledCreateInfo->Tokens = null;
                }
                else
                {
                    if (tokens.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Tokens = (SharpVk.Interop.NVidia.IndirectCommandsLayoutToken*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.IndirectCommandsLayoutToken>());
                        tokens.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.IndirectCommandsLayoutToken*)(marshalledCreateInfo->Tokens));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.IndirectCommandsLayoutToken*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.IndirectCommandsLayoutToken>(Interop.HeapUtil.GetLength(tokens.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(tokens.Value)); index++)
                        {
                            tokens.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfo->Tokens = fieldPointer;
                    }
                }
                marshalledCreateInfo->StreamCount = (uint)(Interop.HeapUtil.GetLength(streamStrides));
                if (streamStrides.IsNull())
                {
                    marshalledCreateInfo->StreamStrides = null;
                }
                else
                {
                    if (streamStrides.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->StreamStrides = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfo->StreamStrides) = streamStrides.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(streamStrides.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(streamStrides.Value)); index++)
                        {
                            fieldPointer[index] = streamStrides.Value[index];
                        }
                        marshalledCreateInfo->StreamStrides = fieldPointer;
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
                SharpVk.Interop.NVidia.VkDeviceCreateIndirectCommandsLayoutDelegate commandDelegate = commandCache.Cache.vkCreateIndirectCommandsLayoutNV;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledIndirectCommandsLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.IndirectCommandsLayout(extendedHandle, marshalledIndirectCommandsLayout);
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
        /// <param name="data">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.NVidia.CudaModule CreateCudaModule(this SharpVk.Device extendedHandle, ArrayProxy<byte>? data, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.CudaModule result = default(SharpVk.NVidia.CudaModule);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.CudaModuleCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.CudaModuleCreateInfo*);
                void* vkCudaModuleCreateInfoNVNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.CudaModule marshalledModule = default(SharpVk.Interop.NVidia.CudaModule);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.CudaModuleCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.CudaModuleCreateInfo>());
                marshalledCreateInfo->SType = StructureType.CudaModuleCreateInfo;
                marshalledCreateInfo->Next = vkCudaModuleCreateInfoNVNextPointer;
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
                SharpVk.Interop.NVidia.VkDeviceCreateCudaModuleDelegate commandDelegate = commandCache.Cache.vkCreateCudaModuleNV;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledModule);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.CudaModule(extendedHandle, marshalledModule);
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
        public static unsafe SharpVk.NVidia.CudaFunction CreateCudaFunction(this SharpVk.Device extendedHandle, SharpVk.NVidia.CudaModule module, string name, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.CudaFunction result = default(SharpVk.NVidia.CudaFunction);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.CudaFunctionCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.CudaFunctionCreateInfo*);
                void* vkCudaFunctionCreateInfoNVNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.CudaFunction marshalledFunction = default(SharpVk.Interop.NVidia.CudaFunction);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.CudaFunctionCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.CudaFunctionCreateInfo>());
                marshalledCreateInfo->SType = StructureType.CudaFunctionCreateInfo;
                marshalledCreateInfo->Next = vkCudaFunctionCreateInfoNVNextPointer;
                marshalledCreateInfo->Module = module?.handle ?? default(SharpVk.Interop.NVidia.CudaModule);
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
                SharpVk.Interop.NVidia.VkDeviceCreateCudaFunctionDelegate commandDelegate = commandCache.Cache.vkCreateCudaFunctionNV;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledFunction);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.CudaFunction(extendedHandle, marshalledFunction);
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
        /// <param name="lowLatencyMode">
        /// </param>
        /// <param name="lowLatencyBoost">
        /// </param>
        /// <param name="minimumIntervalUs">
        /// </param>
        public static unsafe void SetLatencySleepModeLegacy(this SharpVk.Device extendedHandle, bool lowLatencyMode, bool lowLatencyBoost, uint minimumIntervalUs)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkDeviceSetLatencySleepModeLegacyDelegate commandDelegate = commandCache.Cache.vkSetLatencySleepModeLegacyNV;
                commandDelegate(extendedHandle.handle, lowLatencyMode, lowLatencyBoost, minimumIntervalUs);
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
        /// <param name="frameID">
        /// </param>
        /// <param name="marker">
        /// </param>
        public static unsafe void SetLatencyMarkerLegacy(this SharpVk.Device extendedHandle, ulong frameID, uint marker)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkDeviceSetLatencyMarkerLegacyDelegate commandDelegate = commandCache.Cache.vkSetLatencyMarkerLegacyNV;
                commandDelegate(extendedHandle.handle, frameID, marker);
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
        public static unsafe bool GetSleepStatusLegacy(this SharpVk.Device extendedHandle)
        {
            try
            {
                bool result = default(bool);
                CommandCache commandCache = default(CommandCache);
                Bool32 marshalledLowLatencyMode = default(Bool32);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkDeviceGetSleepStatusLegacyDelegate commandDelegate = commandCache.Cache.vkGetSleepStatusLegacyNV;
                commandDelegate(extendedHandle.handle, &marshalledLowLatencyMode);
                result = marshalledLowLatencyMode;
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
        public static unsafe void ShutdownLatencyDeviceLegacy(this SharpVk.Device extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkDeviceShutdownLatencyDeviceLegacyDelegate commandDelegate = commandCache.Cache.vkShutdownLatencyDeviceLegacyNV;
                commandDelegate(extendedHandle.handle);
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
        /// <param name="memoryGetRemoteAddressInfo">
        /// </param>
        public static unsafe IntPtr GetMemoryRemoteAddress(this SharpVk.Device extendedHandle, SharpVk.NVidia.MemoryGetRemoteAddressInfo memoryGetRemoteAddressInfo)
        {
            try
            {
                IntPtr result = default(IntPtr);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.MemoryGetRemoteAddressInfo* marshalledMemoryGetRemoteAddressInfo = default(SharpVk.Interop.NVidia.MemoryGetRemoteAddressInfo*);
                IntPtr marshalledAddress = default(IntPtr);
                commandCache = extendedHandle.commandCache;
                marshalledMemoryGetRemoteAddressInfo = (SharpVk.Interop.NVidia.MemoryGetRemoteAddressInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.MemoryGetRemoteAddressInfo>());
                memoryGetRemoteAddressInfo.MarshalTo(marshalledMemoryGetRemoteAddressInfo);
                SharpVk.Interop.NVidia.VkDeviceGetMemoryRemoteAddressDelegate commandDelegate = commandCache.Cache.vkGetMemoryRemoteAddressNV;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledMemoryGetRemoteAddressInfo, &marshalledAddress);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledAddress;
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
        public static unsafe SharpVk.MemoryRequirements2 GetPipelineIndirectMemoryRequirements(this SharpVk.Device extendedHandle, SharpVk.ComputePipelineCreateInfo createInfo)
        {
            try
            {
                SharpVk.MemoryRequirements2 result = default(SharpVk.MemoryRequirements2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.ComputePipelineCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.ComputePipelineCreateInfo*);
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default(SharpVk.Interop.MemoryRequirements2);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.ComputePipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ComputePipelineCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                SharpVk.Interop.NVidia.VkDeviceGetPipelineIndirectMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetPipelineIndirectMemoryRequirementsNV;
                commandDelegate(extendedHandle.handle, marshalledCreateInfo, &marshalledMemoryRequirements);
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
        public static unsafe SharpVk.DeviceAddress GetPipelineIndirectDeviceAddress(this SharpVk.Device extendedHandle, SharpVk.NVidia.PipelineIndirectDeviceAddressInfo info)
        {
            try
            {
                SharpVk.DeviceAddress result = default(SharpVk.DeviceAddress);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.PipelineIndirectDeviceAddressInfo* marshalledInfo = default(SharpVk.Interop.NVidia.PipelineIndirectDeviceAddressInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.PipelineIndirectDeviceAddressInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PipelineIndirectDeviceAddressInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.VkDeviceGetPipelineIndirectDeviceAddressDelegate commandDelegate = commandCache.Cache.vkGetPipelineIndirectDeviceAddressNV;
                result = commandDelegate(extendedHandle.handle, marshalledInfo);
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
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="imageFormat">
        /// </param>
        /// <param name="flowVectorFormat">
        /// </param>
        /// <param name="costFormat">
        /// </param>
        /// <param name="outputGridSize">
        /// </param>
        /// <param name="hintGridSize">
        /// </param>
        /// <param name="performanceLevel">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="opticalFlowSessionCreatePrivateDataInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.NVidia.OpticalFlowSession CreateOpticalFlowSession(this SharpVk.Device extendedHandle, uint width, uint height, SharpVk.Format imageFormat, SharpVk.Format flowVectorFormat, SharpVk.NVidia.OpticalFlowGridSizeFlags outputGridSize, SharpVk.Format? costFormat = default(SharpVk.Format?), SharpVk.NVidia.OpticalFlowGridSizeFlags? hintGridSize = default(SharpVk.NVidia.OpticalFlowGridSizeFlags?), SharpVk.NVidia.OpticalFlowPerformanceLevel? performanceLevel = default(SharpVk.NVidia.OpticalFlowPerformanceLevel?), SharpVk.NVidia.OpticalFlowSessionCreateFlags? flags = default(SharpVk.NVidia.OpticalFlowSessionCreateFlags?), SharpVk.NVidia.OpticalFlowSessionCreatePrivateDataInfo? opticalFlowSessionCreatePrivateDataInfoNv = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.OpticalFlowSession result = default(SharpVk.NVidia.OpticalFlowSession);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.OpticalFlowSessionCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.OpticalFlowSessionCreateInfo*);
                void* vkOpticalFlowSessionCreateInfoNVNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.OpticalFlowSession marshalledSession = default(SharpVk.Interop.NVidia.OpticalFlowSession);
                if (opticalFlowSessionCreatePrivateDataInfoNv != null)
                {
                    SharpVk.Interop.NVidia.OpticalFlowSessionCreatePrivateDataInfo* extensionPointer = default(SharpVk.Interop.NVidia.OpticalFlowSessionCreatePrivateDataInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.OpticalFlowSessionCreatePrivateDataInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.OpticalFlowSessionCreatePrivateDataInfo>());
                    opticalFlowSessionCreatePrivateDataInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkOpticalFlowSessionCreateInfoNVNextPointer;
                    vkOpticalFlowSessionCreateInfoNVNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.OpticalFlowSessionCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.OpticalFlowSessionCreateInfo>());
                marshalledCreateInfo->SType = StructureType.OpticalFlowSessionCreateInfo;
                marshalledCreateInfo->Next = vkOpticalFlowSessionCreateInfoNVNextPointer;
                marshalledCreateInfo->Width = width;
                marshalledCreateInfo->Height = height;
                marshalledCreateInfo->ImageFormat = imageFormat;
                marshalledCreateInfo->FlowVectorFormat = flowVectorFormat;
                if (costFormat != null)
                {
                    marshalledCreateInfo->CostFormat = costFormat.Value;
                }
                else
                {
                    marshalledCreateInfo->CostFormat = default(SharpVk.Format);
                }
                marshalledCreateInfo->OutputGridSize = outputGridSize;
                if (hintGridSize != null)
                {
                    marshalledCreateInfo->HintGridSize = hintGridSize.Value;
                }
                else
                {
                    marshalledCreateInfo->HintGridSize = default(SharpVk.NVidia.OpticalFlowGridSizeFlags);
                }
                if (performanceLevel != null)
                {
                    marshalledCreateInfo->PerformanceLevel = performanceLevel.Value;
                }
                else
                {
                    marshalledCreateInfo->PerformanceLevel = default(SharpVk.NVidia.OpticalFlowPerformanceLevel);
                }
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.NVidia.OpticalFlowSessionCreateFlags);
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
                SharpVk.Interop.NVidia.VkDeviceCreateOpticalFlowSessionDelegate commandDelegate = commandCache.Cache.vkCreateOpticalFlowSessionNV;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSession);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.OpticalFlowSession(extendedHandle, marshalledSession);
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
        public static unsafe Result ConvertCooperativeVectorMatrix(this SharpVk.Device extendedHandle, SharpVk.NVidia.ConvertCooperativeVectorMatrixInfo info)
        {
            try
            {
                Result result = default(Result);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.ConvertCooperativeVectorMatrixInfo* marshalledInfo = default(SharpVk.Interop.NVidia.ConvertCooperativeVectorMatrixInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.ConvertCooperativeVectorMatrixInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ConvertCooperativeVectorMatrixInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.VkDeviceConvertCooperativeVectorMatrixDelegate commandDelegate = commandCache.Cache.vkConvertCooperativeVectorMatrixNV;
                result = commandDelegate(extendedHandle.handle, marshalledInfo);
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="preferredQueue">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.NVidia.ExternalComputeQueue CreateExternalComputeQueue(this SharpVk.Device extendedHandle, SharpVk.Queue preferredQueue, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.ExternalComputeQueue result = default(SharpVk.NVidia.ExternalComputeQueue);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.ExternalComputeQueueCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.ExternalComputeQueueCreateInfo*);
                void* vkExternalComputeQueueCreateInfoNVNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.ExternalComputeQueue marshalledExternalQueue = default(SharpVk.Interop.NVidia.ExternalComputeQueue);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.ExternalComputeQueueCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ExternalComputeQueueCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ExternalComputeQueueCreateInfo;
                marshalledCreateInfo->Next = vkExternalComputeQueueCreateInfoNVNextPointer;
                marshalledCreateInfo->PreferredQueue = preferredQueue?.handle ?? default(SharpVk.Interop.Queue);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.NVidia.VkDeviceCreateExternalComputeQueueDelegate commandDelegate = commandCache.Cache.vkCreateExternalComputeQueueNV;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledExternalQueue);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.ExternalComputeQueue(extendedHandle, marshalledExternalQueue);
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
        public static unsafe SharpVk.Khronos.AccelerationStructureBuildSizesInfo GetClusterAccelerationStructureBuildSizes(this SharpVk.Device extendedHandle, SharpVk.NVidia.ClusterAccelerationStructureInputInfo info)
        {
            try
            {
                SharpVk.Khronos.AccelerationStructureBuildSizesInfo result = default(SharpVk.Khronos.AccelerationStructureBuildSizesInfo);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.ClusterAccelerationStructureInputInfo* marshalledInfo = default(SharpVk.Interop.NVidia.ClusterAccelerationStructureInputInfo*);
                SharpVk.Interop.Khronos.AccelerationStructureBuildSizesInfo marshalledSizeInfo = default(SharpVk.Interop.Khronos.AccelerationStructureBuildSizesInfo);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.ClusterAccelerationStructureInputInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ClusterAccelerationStructureInputInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.VkDeviceGetClusterAccelerationStructureBuildSizesDelegate commandDelegate = commandCache.Cache.vkGetClusterAccelerationStructureBuildSizesNV;
                commandDelegate(extendedHandle.handle, marshalledInfo, &marshalledSizeInfo);
                result = SharpVk.Khronos.AccelerationStructureBuildSizesInfo.MarshalFrom(&marshalledSizeInfo);
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
        public static unsafe SharpVk.Khronos.AccelerationStructureBuildSizesInfo GetPartitionedAccelerationStructuresBuildSizes(this SharpVk.Device extendedHandle, SharpVk.NVidia.PartitionedAccelerationStructureInstancesInput info)
        {
            try
            {
                SharpVk.Khronos.AccelerationStructureBuildSizesInfo result = default(SharpVk.Khronos.AccelerationStructureBuildSizesInfo);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.PartitionedAccelerationStructureInstancesInput* marshalledInfo = default(SharpVk.Interop.NVidia.PartitionedAccelerationStructureInstancesInput*);
                SharpVk.Interop.Khronos.AccelerationStructureBuildSizesInfo marshalledSizeInfo = default(SharpVk.Interop.Khronos.AccelerationStructureBuildSizesInfo);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.PartitionedAccelerationStructureInstancesInput*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PartitionedAccelerationStructureInstancesInput>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.VkDeviceGetPartitionedAccelerationStructuresBuildSizesDelegate commandDelegate = commandCache.Cache.vkGetPartitionedAccelerationStructuresBuildSizesNV;
                commandDelegate(extendedHandle.handle, marshalledInfo, &marshalledSizeInfo);
                result = SharpVk.Khronos.AccelerationStructureBuildSizesInfo.MarshalFrom(&marshalledSizeInfo);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
