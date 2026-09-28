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
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// Set the viewport W scaling on a command buffer.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="firstViewport">
        /// </param>
        /// <param name="viewportWScalings">
        /// </param>
        public static unsafe void SetViewportWScaling(this SharpVk.CommandBuffer extendedHandle, uint firstViewport, ArrayProxy<SharpVk.NVidia.ViewportWScaling>? viewportWScalings)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.NVidia.ViewportWScaling* marshalledViewportWScalings = default(SharpVk.NVidia.ViewportWScaling*);
                commandCache = extendedHandle.commandCache;
                if (viewportWScalings.IsNull())
                {
                    marshalledViewportWScalings = null;
                }
                else
                {
                    if (viewportWScalings.Value.Contents == ProxyContents.Single)
                    {
                        marshalledViewportWScalings = (SharpVk.NVidia.ViewportWScaling*)(Interop.HeapUtil.Allocate<SharpVk.NVidia.ViewportWScaling>());
                        *(SharpVk.NVidia.ViewportWScaling*)(marshalledViewportWScalings) = viewportWScalings.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.NVidia.ViewportWScaling*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.ViewportWScaling>(Interop.HeapUtil.GetLength(viewportWScalings.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(viewportWScalings.Value)); index++)
                        {
                            fieldPointer[index] = viewportWScalings.Value[index];
                        }
                        marshalledViewportWScalings = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetViewportWScalingDelegate commandDelegate = commandCache.Cache.vkCmdSetViewportWScalingNV;
                commandDelegate(extendedHandle.handle, firstViewport, (uint)(Interop.HeapUtil.GetLength(viewportWScalings)), marshalledViewportWScalings);
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
        /// <param name="imageView">
        /// </param>
        /// <param name="imageLayout">
        /// </param>
        public static unsafe void BindShadingRateImage(this SharpVk.CommandBuffer extendedHandle, SharpVk.ImageView imageView, SharpVk.ImageLayout imageLayout)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferBindShadingRateImageDelegate commandDelegate = commandCache.Cache.vkCmdBindShadingRateImageNV;
                commandDelegate(extendedHandle.handle, imageView?.handle ?? default(SharpVk.Interop.ImageView), imageLayout);
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
        /// <param name="firstViewport">
        /// </param>
        /// <param name="shadingRatePalettes">
        /// </param>
        public static unsafe void SetViewportShadingRatePalette(this SharpVk.CommandBuffer extendedHandle, uint firstViewport, ArrayProxy<SharpVk.NVidia.ShadingRatePalette>? shadingRatePalettes)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.ShadingRatePalette* marshalledShadingRatePalettes = default(SharpVk.Interop.NVidia.ShadingRatePalette*);
                commandCache = extendedHandle.commandCache;
                if (shadingRatePalettes.IsNull())
                {
                    marshalledShadingRatePalettes = null;
                }
                else
                {
                    if (shadingRatePalettes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledShadingRatePalettes = (SharpVk.Interop.NVidia.ShadingRatePalette*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ShadingRatePalette>());
                        shadingRatePalettes.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.ShadingRatePalette*)(marshalledShadingRatePalettes));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.ShadingRatePalette*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.ShadingRatePalette>(Interop.HeapUtil.GetLength(shadingRatePalettes.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(shadingRatePalettes.Value)); index++)
                        {
                            shadingRatePalettes.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledShadingRatePalettes = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetViewportShadingRatePaletteDelegate commandDelegate = commandCache.Cache.vkCmdSetViewportShadingRatePaletteNV;
                commandDelegate(extendedHandle.handle, firstViewport, (uint)(Interop.HeapUtil.GetLength(shadingRatePalettes)), marshalledShadingRatePalettes);
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
        /// <param name="sampleOrderType">
        /// </param>
        /// <param name="customSampleOrders">
        /// </param>
        public static unsafe void SetCoarseSampleOrder(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.CoarseSampleOrderType sampleOrderType, ArrayProxy<SharpVk.NVidia.CoarseSampleOrderCustom>? customSampleOrders)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.CoarseSampleOrderCustom* marshalledCustomSampleOrders = default(SharpVk.Interop.NVidia.CoarseSampleOrderCustom*);
                commandCache = extendedHandle.commandCache;
                if (customSampleOrders.IsNull())
                {
                    marshalledCustomSampleOrders = null;
                }
                else
                {
                    if (customSampleOrders.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCustomSampleOrders = (SharpVk.Interop.NVidia.CoarseSampleOrderCustom*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.CoarseSampleOrderCustom>());
                        customSampleOrders.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.CoarseSampleOrderCustom*)(marshalledCustomSampleOrders));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.CoarseSampleOrderCustom*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.CoarseSampleOrderCustom>(Interop.HeapUtil.GetLength(customSampleOrders.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(customSampleOrders.Value)); index++)
                        {
                            customSampleOrders.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCustomSampleOrders = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetCoarseSampleOrderDelegate commandDelegate = commandCache.Cache.vkCmdSetCoarseSampleOrderNV;
                commandDelegate(extendedHandle.handle, sampleOrderType, (uint)(Interop.HeapUtil.GetLength(customSampleOrders)), marshalledCustomSampleOrders);
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
        /// <param name="instanceData">
        /// </param>
        /// <param name="instanceOffset">
        /// </param>
        /// <param name="update">
        /// </param>
        /// <param name="destination">
        /// </param>
        /// <param name="source">
        /// </param>
        /// <param name="scratch">
        /// </param>
        /// <param name="scratchOffset">
        /// </param>
        public static unsafe void BuildAccelerationStructure(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.AccelerationStructureInfo info, SharpVk.Buffer instanceData, ulong instanceOffset, bool update, SharpVk.NVidia.AccelerationStructure destination, SharpVk.NVidia.AccelerationStructure source, SharpVk.Buffer scratch, ulong scratchOffset)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.AccelerationStructureInfo* marshalledInfo = default(SharpVk.Interop.NVidia.AccelerationStructureInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.AccelerationStructureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.AccelerationStructureInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.VkCommandBufferBuildAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCmdBuildAccelerationStructureNV;
                commandDelegate(extendedHandle.handle, marshalledInfo, instanceData?.handle ?? default(SharpVk.Interop.Buffer), instanceOffset, update, destination?.handle ?? default(SharpVk.Interop.NVidia.AccelerationStructure), source?.handle ?? default(SharpVk.Interop.NVidia.AccelerationStructure), scratch?.handle ?? default(SharpVk.Interop.Buffer), scratchOffset);
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
        /// <param name="destination">
        /// </param>
        /// <param name="source">
        /// </param>
        /// <param name="mode">
        /// </param>
        public static unsafe void CopyAccelerationStructure(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.AccelerationStructure destination, SharpVk.NVidia.AccelerationStructure source, SharpVk.Khronos.CopyAccelerationStructureMode mode)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferCopyAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCmdCopyAccelerationStructureNV;
                commandDelegate(extendedHandle.handle, destination?.handle ?? default(SharpVk.Interop.NVidia.AccelerationStructure), source?.handle ?? default(SharpVk.Interop.NVidia.AccelerationStructure), mode);
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
        /// <param name="raygenShaderBindingTableBuffer">
        /// </param>
        /// <param name="raygenShaderBindingOffset">
        /// </param>
        /// <param name="missShaderBindingTableBuffer">
        /// </param>
        /// <param name="missShaderBindingOffset">
        /// </param>
        /// <param name="missShaderBindingStride">
        /// </param>
        /// <param name="hitShaderBindingTableBuffer">
        /// </param>
        /// <param name="hitShaderBindingOffset">
        /// </param>
        /// <param name="hitShaderBindingStride">
        /// </param>
        /// <param name="callableShaderBindingTableBuffer">
        /// </param>
        /// <param name="callableShaderBindingOffset">
        /// </param>
        /// <param name="callableShaderBindingStride">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        public static unsafe void TraceRays(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, SharpVk.Buffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, SharpVk.Buffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, SharpVk.Buffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferTraceRaysDelegate commandDelegate = commandCache.Cache.vkCmdTraceRaysNV;
                commandDelegate(extendedHandle.handle, raygenShaderBindingTableBuffer?.handle ?? default(SharpVk.Interop.Buffer), raygenShaderBindingOffset, missShaderBindingTableBuffer?.handle ?? default(SharpVk.Interop.Buffer), missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer?.handle ?? default(SharpVk.Interop.Buffer), hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer?.handle ?? default(SharpVk.Interop.Buffer), callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
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
        /// <param name="accelerationStructures">
        /// </param>
        /// <param name="queryType">
        /// </param>
        /// <param name="queryPool">
        /// </param>
        /// <param name="firstQuery">
        /// </param>
        public static unsafe void WriteAccelerationStructuresProperties(this SharpVk.CommandBuffer extendedHandle, ArrayProxy<SharpVk.NVidia.AccelerationStructure>? accelerationStructures, SharpVk.QueryType queryType, SharpVk.QueryPool queryPool, uint firstQuery)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.AccelerationStructure* marshalledAccelerationStructures = default(SharpVk.Interop.NVidia.AccelerationStructure*);
                commandCache = extendedHandle.commandCache;
                if (accelerationStructures.IsNull())
                {
                    marshalledAccelerationStructures = null;
                }
                else
                {
                    if (accelerationStructures.Value.Contents == ProxyContents.Single)
                    {
                        marshalledAccelerationStructures = (SharpVk.Interop.NVidia.AccelerationStructure*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.AccelerationStructure>());
                        *(SharpVk.Interop.NVidia.AccelerationStructure*)(marshalledAccelerationStructures) = accelerationStructures.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.NVidia.AccelerationStructure);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.AccelerationStructure*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.AccelerationStructure>(Interop.HeapUtil.GetLength(accelerationStructures.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(accelerationStructures.Value)); index++)
                        {
                            fieldPointer[index] = accelerationStructures.Value[index]?.handle ?? default(SharpVk.Interop.NVidia.AccelerationStructure);
                        }
                        marshalledAccelerationStructures = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferWriteAccelerationStructuresPropertiesDelegate commandDelegate = commandCache.Cache.vkCmdWriteAccelerationStructuresPropertiesNV;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(accelerationStructures)), marshalledAccelerationStructures, queryType, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), firstQuery);
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
        /// <param name="taskCount">
        /// </param>
        /// <param name="firstTask">
        /// </param>
        public static unsafe void DrawMeshTasks(this SharpVk.CommandBuffer extendedHandle, uint taskCount, uint firstTask)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferDrawMeshTasksDelegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksNV;
                commandDelegate(extendedHandle.handle, taskCount, firstTask);
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
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="drawCount">
        /// </param>
        /// <param name="stride">
        /// </param>
        public static unsafe void DrawMeshTasksIndirect(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer buffer, ulong offset, uint drawCount, uint stride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferDrawMeshTasksIndirectDelegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksIndirectNV;
                commandDelegate(extendedHandle.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset, drawCount, stride);
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
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="countBuffer">
        /// </param>
        /// <param name="countBufferOffset">
        /// </param>
        /// <param name="maxDrawCount">
        /// </param>
        /// <param name="stride">
        /// </param>
        public static unsafe void DrawMeshTasksIndirectCount(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer buffer, ulong offset, SharpVk.Buffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferDrawMeshTasksIndirectCountDelegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksIndirectCountNV;
                commandDelegate(extendedHandle.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset, countBuffer?.handle ?? default(SharpVk.Interop.Buffer), countBufferOffset, maxDrawCount, stride);
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
        /// <param name="firstExclusiveScissor">
        /// </param>
        /// <param name="exclusiveScissorEnables">
        /// </param>
        public static unsafe void SetExclusiveScissorEnable(this SharpVk.CommandBuffer extendedHandle, uint firstExclusiveScissor, ArrayProxy<bool>? exclusiveScissorEnables)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                Bool32* marshalledExclusiveScissorEnables = default(Bool32*);
                commandCache = extendedHandle.commandCache;
                if (exclusiveScissorEnables.IsNull())
                {
                    marshalledExclusiveScissorEnables = null;
                }
                else
                {
                    if (exclusiveScissorEnables.Value.Contents == ProxyContents.Single)
                    {
                        marshalledExclusiveScissorEnables = (Bool32*)(Interop.HeapUtil.Allocate<Bool32>());
                        *(Bool32*)(marshalledExclusiveScissorEnables) = exclusiveScissorEnables.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (Bool32*)(Interop.HeapUtil.AllocateAndClear<Bool32>(Interop.HeapUtil.GetLength(exclusiveScissorEnables.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(exclusiveScissorEnables.Value)); index++)
                        {
                            fieldPointer[index] = exclusiveScissorEnables.Value[index];
                        }
                        marshalledExclusiveScissorEnables = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetExclusiveScissorEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetExclusiveScissorEnableNV;
                commandDelegate(extendedHandle.handle, firstExclusiveScissor, (uint)(Interop.HeapUtil.GetLength(exclusiveScissorEnables)), marshalledExclusiveScissorEnables);
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
        /// <param name="firstExclusiveScissor">
        /// </param>
        /// <param name="exclusiveScissors">
        /// </param>
        public static unsafe void SetExclusiveScissor(this SharpVk.CommandBuffer extendedHandle, uint firstExclusiveScissor, ArrayProxy<SharpVk.Rect2D>? exclusiveScissors)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Rect2D* marshalledExclusiveScissors = default(SharpVk.Rect2D*);
                commandCache = extendedHandle.commandCache;
                if (exclusiveScissors.IsNull())
                {
                    marshalledExclusiveScissors = null;
                }
                else
                {
                    if (exclusiveScissors.Value.Contents == ProxyContents.Single)
                    {
                        marshalledExclusiveScissors = (SharpVk.Rect2D*)(Interop.HeapUtil.Allocate<SharpVk.Rect2D>());
                        *(SharpVk.Rect2D*)(marshalledExclusiveScissors) = exclusiveScissors.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Rect2D*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Rect2D>(Interop.HeapUtil.GetLength(exclusiveScissors.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(exclusiveScissors.Value)); index++)
                        {
                            fieldPointer[index] = exclusiveScissors.Value[index];
                        }
                        marshalledExclusiveScissors = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetExclusiveScissorDelegate commandDelegate = commandCache.Cache.vkCmdSetExclusiveScissorNV;
                commandDelegate(extendedHandle.handle, firstExclusiveScissor, (uint)(Interop.HeapUtil.GetLength(exclusiveScissors)), marshalledExclusiveScissors);
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
        /// <param name="checkpointMarker">
        /// </param>
        public static unsafe void SetCheckpoint(this SharpVk.CommandBuffer extendedHandle, IntPtr checkpointMarker)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferSetCheckpointDelegate commandDelegate = commandCache.Cache.vkCmdSetCheckpointNV;
                commandDelegate(extendedHandle.handle, checkpointMarker.ToPointer());
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
        /// <param name="generatedCommandsInfo">
        /// </param>
        public static unsafe void PreprocessGeneratedCommands(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.GeneratedCommandsInfo generatedCommandsInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.GeneratedCommandsInfo* marshalledGeneratedCommandsInfo = default(SharpVk.Interop.NVidia.GeneratedCommandsInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledGeneratedCommandsInfo = (SharpVk.Interop.NVidia.GeneratedCommandsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.GeneratedCommandsInfo>());
                generatedCommandsInfo.MarshalTo(marshalledGeneratedCommandsInfo);
                SharpVk.Interop.NVidia.VkCommandBufferPreprocessGeneratedCommandsDelegate commandDelegate = commandCache.Cache.vkCmdPreprocessGeneratedCommandsNV;
                commandDelegate(extendedHandle.handle, marshalledGeneratedCommandsInfo);
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
        /// <param name="isPreprocessed">
        /// </param>
        /// <param name="generatedCommandsInfo">
        /// </param>
        public static unsafe void ExecuteGeneratedCommands(this SharpVk.CommandBuffer extendedHandle, bool isPreprocessed, SharpVk.NVidia.GeneratedCommandsInfo generatedCommandsInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.GeneratedCommandsInfo* marshalledGeneratedCommandsInfo = default(SharpVk.Interop.NVidia.GeneratedCommandsInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledGeneratedCommandsInfo = (SharpVk.Interop.NVidia.GeneratedCommandsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.GeneratedCommandsInfo>());
                generatedCommandsInfo.MarshalTo(marshalledGeneratedCommandsInfo);
                SharpVk.Interop.NVidia.VkCommandBufferExecuteGeneratedCommandsDelegate commandDelegate = commandCache.Cache.vkCmdExecuteGeneratedCommandsNV;
                commandDelegate(extendedHandle.handle, isPreprocessed, marshalledGeneratedCommandsInfo);
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
        /// <param name="pipelineBindPoint">
        /// </param>
        /// <param name="pipeline">
        /// </param>
        /// <param name="groupIndex">
        /// </param>
        public static unsafe void BindPipelineShaderGroup(this SharpVk.CommandBuffer extendedHandle, SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.Pipeline pipeline, uint groupIndex)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferBindPipelineShaderGroupDelegate commandDelegate = commandCache.Cache.vkCmdBindPipelineShaderGroupNV;
                commandDelegate(extendedHandle.handle, pipelineBindPoint, pipeline?.handle ?? default(SharpVk.Interop.Pipeline), groupIndex);
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
        /// <param name="launchInfo">
        /// </param>
        public static unsafe void CudaLaunchKernel(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.CudaLaunchInfo launchInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.CudaLaunchInfo* marshalledLaunchInfo = default(SharpVk.Interop.NVidia.CudaLaunchInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledLaunchInfo = (SharpVk.Interop.NVidia.CudaLaunchInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.CudaLaunchInfo>());
                launchInfo.MarshalTo(marshalledLaunchInfo);
                SharpVk.Interop.NVidia.VkCommandBufferCudaLaunchKernelDelegate commandDelegate = commandCache.Cache.vkCmdCudaLaunchKernelNV;
                commandDelegate(extendedHandle.handle, marshalledLaunchInfo);
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
        /// <param name="shadingRate">
        /// </param>
        /// <param name="combinerOps">
        /// </param>
        public static unsafe void SetFragmentShadingRateEnum(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.FragmentShadingRate shadingRate, SharpVk.Khronos.FragmentShadingRateCombinerOp combinerOps)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferSetFragmentShadingRateEnumDelegate commandDelegate = commandCache.Cache.vkCmdSetFragmentShadingRateEnumNV;
                commandDelegate(extendedHandle.handle, shadingRate, combinerOps);
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
        /// <param name="pipelineBindPoint">
        /// </param>
        /// <param name="pipeline">
        /// </param>
        public static unsafe void UpdatePipelineIndirectBuffer(this SharpVk.CommandBuffer extendedHandle, SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.Pipeline pipeline)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferUpdatePipelineIndirectBufferDelegate commandDelegate = commandCache.Cache.vkCmdUpdatePipelineIndirectBufferNV;
                commandDelegate(extendedHandle.handle, pipelineBindPoint, pipeline?.handle ?? default(SharpVk.Interop.Pipeline));
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
        /// <param name="viewportWScalingEnable">
        /// </param>
        public static unsafe void SetViewportWScalingEnable(this SharpVk.CommandBuffer extendedHandle, bool viewportWScalingEnable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferSetViewportWScalingEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetViewportWScalingEnableNV;
                commandDelegate(extendedHandle.handle, viewportWScalingEnable);
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
        /// <param name="firstViewport">
        /// </param>
        /// <param name="viewportSwizzles">
        /// </param>
        public static unsafe void SetViewportSwizzle(this SharpVk.CommandBuffer extendedHandle, uint firstViewport, ArrayProxy<SharpVk.NVidia.ViewportSwizzle>? viewportSwizzles)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.NVidia.ViewportSwizzle* marshalledViewportSwizzles = default(SharpVk.NVidia.ViewportSwizzle*);
                commandCache = extendedHandle.commandCache;
                if (viewportSwizzles.IsNull())
                {
                    marshalledViewportSwizzles = null;
                }
                else
                {
                    if (viewportSwizzles.Value.Contents == ProxyContents.Single)
                    {
                        marshalledViewportSwizzles = (SharpVk.NVidia.ViewportSwizzle*)(Interop.HeapUtil.Allocate<SharpVk.NVidia.ViewportSwizzle>());
                        *(SharpVk.NVidia.ViewportSwizzle*)(marshalledViewportSwizzles) = viewportSwizzles.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.NVidia.ViewportSwizzle*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.ViewportSwizzle>(Interop.HeapUtil.GetLength(viewportSwizzles.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(viewportSwizzles.Value)); index++)
                        {
                            fieldPointer[index] = viewportSwizzles.Value[index];
                        }
                        marshalledViewportSwizzles = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetViewportSwizzleDelegate commandDelegate = commandCache.Cache.vkCmdSetViewportSwizzleNV;
                commandDelegate(extendedHandle.handle, firstViewport, (uint)(Interop.HeapUtil.GetLength(viewportSwizzles)), marshalledViewportSwizzles);
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
        /// <param name="coverageToColorEnable">
        /// </param>
        public static unsafe void SetCoverageToColorEnable(this SharpVk.CommandBuffer extendedHandle, bool coverageToColorEnable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferSetCoverageToColorEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetCoverageToColorEnableNV;
                commandDelegate(extendedHandle.handle, coverageToColorEnable);
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
        /// <param name="coverageToColorLocation">
        /// </param>
        public static unsafe void SetCoverageToColorLocation(this SharpVk.CommandBuffer extendedHandle, uint coverageToColorLocation)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferSetCoverageToColorLocationDelegate commandDelegate = commandCache.Cache.vkCmdSetCoverageToColorLocationNV;
                commandDelegate(extendedHandle.handle, coverageToColorLocation);
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
        /// <param name="coverageModulationMode">
        /// </param>
        public static unsafe void SetCoverageModulationMode(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.CoverageModulationMode coverageModulationMode)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferSetCoverageModulationModeDelegate commandDelegate = commandCache.Cache.vkCmdSetCoverageModulationModeNV;
                commandDelegate(extendedHandle.handle, coverageModulationMode);
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
        /// <param name="coverageModulationTableEnable">
        /// </param>
        public static unsafe void SetCoverageModulationTableEnable(this SharpVk.CommandBuffer extendedHandle, bool coverageModulationTableEnable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferSetCoverageModulationTableEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetCoverageModulationTableEnableNV;
                commandDelegate(extendedHandle.handle, coverageModulationTableEnable);
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
        /// <param name="coverageModulationTable">
        /// </param>
        public static unsafe void SetCoverageModulationTable(this SharpVk.CommandBuffer extendedHandle, ArrayProxy<float>? coverageModulationTable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                float* marshalledCoverageModulationTable = default(float*);
                commandCache = extendedHandle.commandCache;
                if (coverageModulationTable.IsNull())
                {
                    marshalledCoverageModulationTable = null;
                }
                else
                {
                    if (coverageModulationTable.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCoverageModulationTable = (float*)(Interop.HeapUtil.Allocate<float>());
                        *(float*)(marshalledCoverageModulationTable) = coverageModulationTable.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (float*)(Interop.HeapUtil.AllocateAndClear<float>(Interop.HeapUtil.GetLength(coverageModulationTable.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(coverageModulationTable.Value)); index++)
                        {
                            fieldPointer[index] = coverageModulationTable.Value[index];
                        }
                        marshalledCoverageModulationTable = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetCoverageModulationTableDelegate commandDelegate = commandCache.Cache.vkCmdSetCoverageModulationTableNV;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(coverageModulationTable)), marshalledCoverageModulationTable);
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
        /// <param name="shadingRateImageEnable">
        /// </param>
        public static unsafe void SetShadingRateImageEnable(this SharpVk.CommandBuffer extendedHandle, bool shadingRateImageEnable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferSetShadingRateImageEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetShadingRateImageEnableNV;
                commandDelegate(extendedHandle.handle, shadingRateImageEnable);
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
        /// <param name="representativeFragmentTestEnable">
        /// </param>
        public static unsafe void SetRepresentativeFragmentTestEnable(this SharpVk.CommandBuffer extendedHandle, bool representativeFragmentTestEnable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferSetRepresentativeFragmentTestEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetRepresentativeFragmentTestEnableNV;
                commandDelegate(extendedHandle.handle, representativeFragmentTestEnable);
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
        /// <param name="coverageReductionMode">
        /// </param>
        public static unsafe void SetCoverageReductionMode(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.CoverageReductionMode coverageReductionMode)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferSetCoverageReductionModeDelegate commandDelegate = commandCache.Cache.vkCmdSetCoverageReductionModeNV;
                commandDelegate(extendedHandle.handle, coverageReductionMode);
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
        /// <param name="session">
        /// </param>
        /// <param name="executeInfo">
        /// </param>
        public static unsafe void OpticalFlowExecute(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.OpticalFlowSession session, SharpVk.NVidia.OpticalFlowExecuteInfo executeInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.OpticalFlowExecuteInfo* marshalledExecuteInfo = default(SharpVk.Interop.NVidia.OpticalFlowExecuteInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledExecuteInfo = (SharpVk.Interop.NVidia.OpticalFlowExecuteInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.OpticalFlowExecuteInfo>());
                executeInfo.MarshalTo(marshalledExecuteInfo);
                SharpVk.Interop.NVidia.VkCommandBufferOpticalFlowExecuteDelegate commandDelegate = commandCache.Cache.vkCmdOpticalFlowExecuteNV;
                commandDelegate(extendedHandle.handle, session?.handle ?? default(SharpVk.Interop.NVidia.OpticalFlowSession), marshalledExecuteInfo);
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
        /// <param name="infos">
        /// </param>
        public static unsafe void ConvertCooperativeVectorMatrix(this SharpVk.CommandBuffer extendedHandle, ArrayProxy<SharpVk.NVidia.ConvertCooperativeVectorMatrixInfo>? infos)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.ConvertCooperativeVectorMatrixInfo* marshalledInfos = default(SharpVk.Interop.NVidia.ConvertCooperativeVectorMatrixInfo*);
                commandCache = extendedHandle.commandCache;
                if (infos.IsNull())
                {
                    marshalledInfos = null;
                }
                else
                {
                    if (infos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledInfos = (SharpVk.Interop.NVidia.ConvertCooperativeVectorMatrixInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ConvertCooperativeVectorMatrixInfo>());
                        infos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.ConvertCooperativeVectorMatrixInfo*)(marshalledInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.ConvertCooperativeVectorMatrixInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.ConvertCooperativeVectorMatrixInfo>(Interop.HeapUtil.GetLength(infos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(infos.Value)); index++)
                        {
                            infos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferConvertCooperativeVectorMatrixDelegate commandDelegate = commandCache.Cache.vkCmdConvertCooperativeVectorMatrixNV;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(infos)), marshalledInfos);
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
        /// <param name="commandInfos">
        /// </param>
        public static unsafe void BuildClusterAccelerationStructureIndirect(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.ClusterAccelerationStructureCommandsInfo commandInfos)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.ClusterAccelerationStructureCommandsInfo* marshalledCommandInfos = default(SharpVk.Interop.NVidia.ClusterAccelerationStructureCommandsInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledCommandInfos = (SharpVk.Interop.NVidia.ClusterAccelerationStructureCommandsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ClusterAccelerationStructureCommandsInfo>());
                commandInfos.MarshalTo(marshalledCommandInfos);
                SharpVk.Interop.NVidia.VkCommandBufferBuildClusterAccelerationStructureIndirectDelegate commandDelegate = commandCache.Cache.vkCmdBuildClusterAccelerationStructureIndirectNV;
                commandDelegate(extendedHandle.handle, marshalledCommandInfos);
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
        /// <param name="buildInfo">
        /// </param>
        public static unsafe void BuildPartitionedAccelerationStructures(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.BuildPartitionedAccelerationStructureInfo buildInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.BuildPartitionedAccelerationStructureInfo* marshalledBuildInfo = default(SharpVk.Interop.NVidia.BuildPartitionedAccelerationStructureInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledBuildInfo = (SharpVk.Interop.NVidia.BuildPartitionedAccelerationStructureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.BuildPartitionedAccelerationStructureInfo>());
                buildInfo.MarshalTo(marshalledBuildInfo);
                SharpVk.Interop.NVidia.VkCommandBufferBuildPartitionedAccelerationStructuresDelegate commandDelegate = commandCache.Cache.vkCmdBuildPartitionedAccelerationStructuresNV;
                commandDelegate(extendedHandle.handle, marshalledBuildInfo);
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
        /// <param name="parameters">
        /// </param>
        public static unsafe void SetComputeOccupancyPriority(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.ComputeOccupancyPriorityParameters parameters)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.ComputeOccupancyPriorityParameters* marshalledParameters = default(SharpVk.Interop.NVidia.ComputeOccupancyPriorityParameters*);
                commandCache = extendedHandle.commandCache;
                marshalledParameters = (SharpVk.Interop.NVidia.ComputeOccupancyPriorityParameters*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ComputeOccupancyPriorityParameters>());
                parameters.MarshalTo(marshalledParameters);
                SharpVk.Interop.NVidia.VkCommandBufferSetComputeOccupancyPriorityDelegate commandDelegate = commandCache.Cache.vkCmdSetComputeOccupancyPriorityNV;
                commandDelegate(extendedHandle.handle, marshalledParameters);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
