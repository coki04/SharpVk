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

namespace SharpVk.Amd
{
    /// <summary>
    /// 
    /// </summary>
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="gpaSession">
        /// </param>
        public static unsafe void BeginGpaSession(this SharpVk.CommandBuffer extendedHandle, SharpVk.Amd.GpaSession gpaSession)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Amd.VkCommandBufferBeginGpaSessionDelegate commandDelegate = commandCache.Cache.vkCmdBeginGpaSessionAMD;
                Result methodResult = commandDelegate(extendedHandle.handle, gpaSession?.handle ?? default(SharpVk.Interop.Amd.GpaSession));
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="gpaSession">
        /// </param>
        public static unsafe void EndGpaSession(this SharpVk.CommandBuffer extendedHandle, SharpVk.Amd.GpaSession gpaSession)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Amd.VkCommandBufferEndGpaSessionDelegate commandDelegate = commandCache.Cache.vkCmdEndGpaSessionAMD;
                Result methodResult = commandDelegate(extendedHandle.handle, gpaSession?.handle ?? default(SharpVk.Interop.Amd.GpaSession));
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="gpaSession">
        /// </param>
        /// <param name="sampleType">
        /// </param>
        /// <param name="sampleInternalOperations">
        /// </param>
        /// <param name="cacheFlushOnCounterCollection">
        /// </param>
        /// <param name="sqShaderMaskEnable">
        /// </param>
        /// <param name="sqShaderMask">
        /// </param>
        /// <param name="perfCounters">
        /// </param>
        /// <param name="streamingPerfTraceSampleInterval">
        /// </param>
        /// <param name="perfCounterDeviceMemoryLimit">
        /// </param>
        /// <param name="sqThreadTraceEnable">
        /// </param>
        /// <param name="sqThreadTraceSuppressInstructionTokens">
        /// </param>
        /// <param name="sqThreadTraceDeviceMemoryLimit">
        /// </param>
        /// <param name="timingPreSample">
        /// </param>
        /// <param name="timingPostSample">
        /// </param>
        public static unsafe uint BeginGpaSample(this SharpVk.CommandBuffer extendedHandle, SharpVk.Amd.GpaSession gpaSession, SharpVk.Amd.GpaSampleType sampleType, bool sampleInternalOperations, bool cacheFlushOnCounterCollection, bool sqShaderMaskEnable, ArrayProxy<SharpVk.Amd.GpaPerfCounter>? perfCounters, uint streamingPerfTraceSampleInterval, ulong perfCounterDeviceMemoryLimit, bool sqThreadTraceEnable, bool sqThreadTraceSuppressInstructionTokens, ulong sqThreadTraceDeviceMemoryLimit, SharpVk.Amd.GpaSqShaderStageFlags? sqShaderMask = default(SharpVk.Amd.GpaSqShaderStageFlags?), SharpVk.PipelineStageFlags? timingPreSample = default(SharpVk.PipelineStageFlags?), SharpVk.PipelineStageFlags? timingPostSample = default(SharpVk.PipelineStageFlags?))
        {
            try
            {
                uint result = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Amd.GpaSampleBeginInfo* marshalledGpaSampleBeginInfo = default(SharpVk.Interop.Amd.GpaSampleBeginInfo*);
                void* vkGpaSampleBeginInfoAMDNextPointer = default(void*);
                uint marshalledSampleID = default(uint);
                commandCache = extendedHandle.commandCache;
                marshalledGpaSampleBeginInfo = (SharpVk.Interop.Amd.GpaSampleBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.GpaSampleBeginInfo>());
                marshalledGpaSampleBeginInfo->SType = StructureType.GpaSampleBeginInfo;
                marshalledGpaSampleBeginInfo->Next = vkGpaSampleBeginInfoAMDNextPointer;
                marshalledGpaSampleBeginInfo->SampleType = sampleType;
                marshalledGpaSampleBeginInfo->SampleInternalOperations = sampleInternalOperations;
                marshalledGpaSampleBeginInfo->CacheFlushOnCounterCollection = cacheFlushOnCounterCollection;
                marshalledGpaSampleBeginInfo->SqShaderMaskEnable = sqShaderMaskEnable;
                if (sqShaderMask != null)
                {
                    marshalledGpaSampleBeginInfo->SqShaderMask = sqShaderMask.Value;
                }
                else
                {
                    marshalledGpaSampleBeginInfo->SqShaderMask = default(SharpVk.Amd.GpaSqShaderStageFlags);
                }
                marshalledGpaSampleBeginInfo->PerfCounterCount = (uint)(Interop.HeapUtil.GetLength(perfCounters));
                if (perfCounters.IsNull())
                {
                    marshalledGpaSampleBeginInfo->PerfCounters = null;
                }
                else
                {
                    if (perfCounters.Value.Contents == ProxyContents.Single)
                    {
                        marshalledGpaSampleBeginInfo->PerfCounters = (SharpVk.Amd.GpaPerfCounter*)(Interop.HeapUtil.Allocate<SharpVk.Amd.GpaPerfCounter>());
                        *(SharpVk.Amd.GpaPerfCounter*)(marshalledGpaSampleBeginInfo->PerfCounters) = perfCounters.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Amd.GpaPerfCounter*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Amd.GpaPerfCounter>(Interop.HeapUtil.GetLength(perfCounters.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(perfCounters.Value)); index++)
                        {
                            fieldPointer[index] = perfCounters.Value[index];
                        }
                        marshalledGpaSampleBeginInfo->PerfCounters = fieldPointer;
                    }
                }
                marshalledGpaSampleBeginInfo->StreamingPerfTraceSampleInterval = streamingPerfTraceSampleInterval;
                marshalledGpaSampleBeginInfo->PerfCounterDeviceMemoryLimit = perfCounterDeviceMemoryLimit;
                marshalledGpaSampleBeginInfo->SqThreadTraceEnable = sqThreadTraceEnable;
                marshalledGpaSampleBeginInfo->SqThreadTraceSuppressInstructionTokens = sqThreadTraceSuppressInstructionTokens;
                marshalledGpaSampleBeginInfo->SqThreadTraceDeviceMemoryLimit = sqThreadTraceDeviceMemoryLimit;
                if (timingPreSample != null)
                {
                    marshalledGpaSampleBeginInfo->TimingPreSample = timingPreSample.Value;
                }
                else
                {
                    marshalledGpaSampleBeginInfo->TimingPreSample = default(SharpVk.PipelineStageFlags);
                }
                if (timingPostSample != null)
                {
                    marshalledGpaSampleBeginInfo->TimingPostSample = timingPostSample.Value;
                }
                else
                {
                    marshalledGpaSampleBeginInfo->TimingPostSample = default(SharpVk.PipelineStageFlags);
                }
                SharpVk.Interop.Amd.VkCommandBufferBeginGpaSampleDelegate commandDelegate = commandCache.Cache.vkCmdBeginGpaSampleAMD;
                Result methodResult = commandDelegate(extendedHandle.handle, gpaSession?.handle ?? default(SharpVk.Interop.Amd.GpaSession), marshalledGpaSampleBeginInfo, &marshalledSampleID);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledSampleID;
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="gpaSession">
        /// </param>
        /// <param name="sampleID">
        /// </param>
        public static unsafe void EndGpaSample(this SharpVk.CommandBuffer extendedHandle, SharpVk.Amd.GpaSession gpaSession, uint sampleID)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Amd.VkCommandBufferEndGpaSampleDelegate commandDelegate = commandCache.Cache.vkCmdEndGpaSampleAMD;
                commandDelegate(extendedHandle.handle, gpaSession?.handle ?? default(SharpVk.Interop.Amd.GpaSession), sampleID);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="gpaSession">
        /// </param>
        public static unsafe void CopyGpaSessionResults(this SharpVk.CommandBuffer extendedHandle, SharpVk.Amd.GpaSession gpaSession)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Amd.VkCommandBufferCopyGpaSessionResultsDelegate commandDelegate = commandCache.Cache.vkCmdCopyGpaSessionResultsAMD;
                commandDelegate(extendedHandle.handle, gpaSession?.handle ?? default(SharpVk.Interop.Amd.GpaSession));
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Execute a pipelined write of a marker value into a buffer.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="pipelineStage">
        /// One of the PipelineStageFlags values, specifying the pipeline stage
        /// whose completion triggers the marker write.
        /// </param>
        /// <param name="destinationBuffer">
        /// The buffer where the marker will be written to.
        /// </param>
        /// <param name="destinationOffset">
        /// The byte offset into the buffer where the marker will be written
        /// to.
        /// </param>
        /// <param name="marker">
        /// The 32-bit value of the marker.
        /// </param>
        public static unsafe void WriteBufferMarker(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer destinationBuffer, ulong destinationOffset, uint marker, SharpVk.PipelineStageFlags? pipelineStage = default(SharpVk.PipelineStageFlags?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.PipelineStageFlags marshalledPipelineStage = default(SharpVk.PipelineStageFlags);
                commandCache = extendedHandle.commandCache;
                if (pipelineStage != null)
                {
                    marshalledPipelineStage = pipelineStage.Value;
                }
                else
                {
                    marshalledPipelineStage = default(SharpVk.PipelineStageFlags);
                }
                SharpVk.Interop.Amd.VkCommandBufferWriteBufferMarkerDelegate commandDelegate = commandCache.Cache.vkCmdWriteBufferMarkerAMD;
                commandDelegate(extendedHandle.handle, marshalledPipelineStage, destinationBuffer?.handle ?? default(SharpVk.Interop.Buffer), destinationOffset, marker);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="stage">
        /// </param>
        /// <param name="destinationBuffer">
        /// </param>
        /// <param name="destinationOffset">
        /// </param>
        /// <param name="marker">
        /// </param>
        public static unsafe void WriteBufferMarker2(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer destinationBuffer, ulong destinationOffset, uint marker, SharpVk.PipelineStageFlags2? stage = default(SharpVk.PipelineStageFlags2?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.PipelineStageFlags2 marshalledStage = default(SharpVk.PipelineStageFlags2);
                commandCache = extendedHandle.commandCache;
                if (stage != null)
                {
                    marshalledStage = stage.Value;
                }
                else
                {
                    marshalledStage = default(SharpVk.PipelineStageFlags2);
                }
                SharpVk.Interop.Amd.VkCommandBufferWriteBufferMarker2Delegate commandDelegate = commandCache.Cache.vkCmdWriteBufferMarker2AMD;
                commandDelegate(extendedHandle.handle, marshalledStage, destinationBuffer?.handle ?? default(SharpVk.Interop.Buffer), destinationOffset, marker);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe void WriteMarkerToMemory(this SharpVk.CommandBuffer extendedHandle, SharpVk.Amd.MemoryMarkerInfo info)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Amd.MemoryMarkerInfo* marshalledInfo = default(SharpVk.Interop.Amd.MemoryMarkerInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Amd.MemoryMarkerInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.MemoryMarkerInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Amd.VkCommandBufferWriteMarkerToMemoryDelegate commandDelegate = commandCache.Cache.vkCmdWriteMarkerToMemoryAMD;
                commandDelegate(extendedHandle.handle, marshalledInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
