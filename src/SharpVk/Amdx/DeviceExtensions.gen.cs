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

namespace SharpVk.Amdx
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
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Pipeline[] CreateExecutionGraphPipelines(this SharpVk.Device extendedHandle, SharpVk.PipelineCache pipelineCache, ArrayProxy<SharpVk.Amdx.ExecutionGraphPipelineCreateInfo>? createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline[] result = default(SharpVk.Pipeline[]);
                CommandCache commandCache = default(CommandCache);
                uint marshalledCreateInfoCount = default(uint);
                SharpVk.Interop.Amdx.ExecutionGraphPipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Amdx.ExecutionGraphPipelineCreateInfo*);
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
                        marshalledCreateInfos = (SharpVk.Interop.Amdx.ExecutionGraphPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amdx.ExecutionGraphPipelineCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Amdx.ExecutionGraphPipelineCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Amdx.ExecutionGraphPipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Amdx.ExecutionGraphPipelineCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
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
                SharpVk.Interop.Amdx.VkDeviceCreateExecutionGraphPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateExecutionGraphPipelinesAMDX;
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
        /// <param name="libraryInfo">
        /// </param>
        /// <param name="layout">
        /// </param>
        /// <param name="basePipelineHandle">
        /// </param>
        /// <param name="basePipelineIndex">
        /// </param>
        /// <param name="pipelineCreationFeedbackCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="pipelineCompilerControlCreateInfoAmd">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Pipeline CreateExecutionGraphPipeline(this SharpVk.Device extendedHandle, SharpVk.PipelineCache pipelineCache, SharpVk.PipelineLayout layout, SharpVk.Pipeline basePipelineHandle, int basePipelineIndex, SharpVk.PipelineCreateFlags? flags = default(SharpVk.PipelineCreateFlags?), ArrayProxy<SharpVk.PipelineShaderStageCreateInfo>? stages = null, SharpVk.Khronos.PipelineLibraryCreateInfo? libraryInfo = default(SharpVk.Khronos.PipelineLibraryCreateInfo?), SharpVk.PipelineCreationFeedbackCreateInfo? pipelineCreationFeedbackCreateInfo = null, SharpVk.Amd.PipelineCompilerControlCreateInfo? pipelineCompilerControlCreateInfoAmd = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline result = default(SharpVk.Pipeline);
                CommandCache commandCache = default(CommandCache);
                uint marshalledCreateInfoCount = default(uint);
                SharpVk.Interop.Amdx.ExecutionGraphPipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Amdx.ExecutionGraphPipelineCreateInfo*);
                void* vkExecutionGraphPipelineCreateInfoAMDXNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
                if (pipelineCreationFeedbackCreateInfo != null)
                {
                    SharpVk.Interop.PipelineCreationFeedbackCreateInfo* extensionPointer = default(SharpVk.Interop.PipelineCreationFeedbackCreateInfo*);
                    extensionPointer = (SharpVk.Interop.PipelineCreationFeedbackCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineCreationFeedbackCreateInfo>());
                    pipelineCreationFeedbackCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkExecutionGraphPipelineCreateInfoAMDXNextPointer;
                    vkExecutionGraphPipelineCreateInfoAMDXNextPointer = extensionPointer;
                }
                if (pipelineCompilerControlCreateInfoAmd != null)
                {
                    SharpVk.Interop.Amd.PipelineCompilerControlCreateInfo* extensionPointer = default(SharpVk.Interop.Amd.PipelineCompilerControlCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Amd.PipelineCompilerControlCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.PipelineCompilerControlCreateInfo>());
                    pipelineCompilerControlCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkExecutionGraphPipelineCreateInfoAMDXNextPointer;
                    vkExecutionGraphPipelineCreateInfoAMDXNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfoCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.Amdx.ExecutionGraphPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amdx.ExecutionGraphPipelineCreateInfo>());
                marshalledCreateInfos->SType = StructureType.ExecutionGraphPipelineCreateInfo;
                marshalledCreateInfos->Next = vkExecutionGraphPipelineCreateInfoAMDXNextPointer;
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
                if (libraryInfo != null)
                {
                    marshalledCreateInfos->LibraryInfo = (SharpVk.Interop.Khronos.PipelineLibraryCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineLibraryCreateInfo>());
                    libraryInfo.Value.MarshalTo(marshalledCreateInfos->LibraryInfo);
                }
                else
                {
                    marshalledCreateInfos->LibraryInfo = default(SharpVk.Interop.Khronos.PipelineLibraryCreateInfo*);
                }
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
                SharpVk.Interop.Amdx.VkDeviceCreateExecutionGraphPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateExecutionGraphPipelinesAMDX;
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
    }
}
