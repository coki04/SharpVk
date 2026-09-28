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
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="firstBinding">
        /// </param>
        /// <param name="buffers">
        /// </param>
        /// <param name="offsets">
        /// </param>
        /// <param name="sizes">
        /// </param>
        public static unsafe void BindTransformFeedbackBuffers(this SharpVk.CommandBuffer extendedHandle, uint firstBinding, ArrayProxy<SharpVk.Buffer>? buffers, ArrayProxy<ulong>? offsets, ArrayProxy<ulong>? sizes = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Buffer* marshalledBuffers = default(SharpVk.Interop.Buffer*);
                ulong* marshalledOffsets = default(ulong*);
                ulong* marshalledSizes = default(ulong*);
                commandCache = extendedHandle.commandCache;
                if (buffers.IsNull())
                {
                    marshalledBuffers = null;
                }
                else
                {
                    if (buffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBuffers = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Buffer>());
                        *(SharpVk.Interop.Buffer*)(marshalledBuffers) = buffers.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Buffer);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Buffer>(Interop.HeapUtil.GetLength(buffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(buffers.Value)); index++)
                        {
                            fieldPointer[index] = buffers.Value[index]?.handle ?? default(SharpVk.Interop.Buffer);
                        }
                        marshalledBuffers = fieldPointer;
                    }
                }
                if (offsets.IsNull())
                {
                    marshalledOffsets = null;
                }
                else
                {
                    if (offsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledOffsets = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledOffsets) = offsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(offsets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(offsets.Value)); index++)
                        {
                            fieldPointer[index] = offsets.Value[index];
                        }
                        marshalledOffsets = fieldPointer;
                    }
                }
                if (sizes.IsNull())
                {
                    marshalledSizes = null;
                }
                else
                {
                    if (sizes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSizes = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledSizes) = sizes.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(sizes.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(sizes.Value)); index++)
                        {
                            fieldPointer[index] = sizes.Value[index];
                        }
                        marshalledSizes = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBindTransformFeedbackBuffersDelegate commandDelegate = commandCache.Cache.vkCmdBindTransformFeedbackBuffersEXT;
                commandDelegate(extendedHandle.handle, firstBinding, (uint)(Interop.HeapUtil.GetLength(buffers)), marshalledBuffers, marshalledOffsets, marshalledSizes);
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
        /// <param name="firstCounterBuffer">
        /// </param>
        /// <param name="counterBuffers">
        /// </param>
        /// <param name="counterBufferOffsets">
        /// </param>
        public static unsafe void BeginTransformFeedback(this SharpVk.CommandBuffer extendedHandle, uint firstCounterBuffer, ArrayProxy<SharpVk.Buffer>? counterBuffers, ArrayProxy<ulong>? counterBufferOffsets = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Buffer* marshalledCounterBuffers = default(SharpVk.Interop.Buffer*);
                ulong* marshalledCounterBufferOffsets = default(ulong*);
                commandCache = extendedHandle.commandCache;
                if (counterBuffers.IsNull())
                {
                    marshalledCounterBuffers = null;
                }
                else
                {
                    if (counterBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBuffers = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Buffer>());
                        *(SharpVk.Interop.Buffer*)(marshalledCounterBuffers) = counterBuffers.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Buffer);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Buffer>(Interop.HeapUtil.GetLength(counterBuffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterBuffers.Value)); index++)
                        {
                            fieldPointer[index] = counterBuffers.Value[index]?.handle ?? default(SharpVk.Interop.Buffer);
                        }
                        marshalledCounterBuffers = fieldPointer;
                    }
                }
                if (counterBufferOffsets.IsNull())
                {
                    marshalledCounterBufferOffsets = null;
                }
                else
                {
                    if (counterBufferOffsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBufferOffsets = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledCounterBufferOffsets) = counterBufferOffsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(counterBufferOffsets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterBufferOffsets.Value)); index++)
                        {
                            fieldPointer[index] = counterBufferOffsets.Value[index];
                        }
                        marshalledCounterBufferOffsets = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBeginTransformFeedbackDelegate commandDelegate = commandCache.Cache.vkCmdBeginTransformFeedbackEXT;
                commandDelegate(extendedHandle.handle, firstCounterBuffer, (uint)(Interop.HeapUtil.GetLength(counterBuffers)), marshalledCounterBuffers, marshalledCounterBufferOffsets);
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
        /// <param name="firstCounterBuffer">
        /// </param>
        /// <param name="counterBuffers">
        /// </param>
        /// <param name="counterBufferOffsets">
        /// </param>
        public static unsafe void EndTransformFeedback(this SharpVk.CommandBuffer extendedHandle, uint firstCounterBuffer, ArrayProxy<SharpVk.Buffer>? counterBuffers, ArrayProxy<ulong>? counterBufferOffsets = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Buffer* marshalledCounterBuffers = default(SharpVk.Interop.Buffer*);
                ulong* marshalledCounterBufferOffsets = default(ulong*);
                commandCache = extendedHandle.commandCache;
                if (counterBuffers.IsNull())
                {
                    marshalledCounterBuffers = null;
                }
                else
                {
                    if (counterBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBuffers = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Buffer>());
                        *(SharpVk.Interop.Buffer*)(marshalledCounterBuffers) = counterBuffers.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Buffer);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Buffer>(Interop.HeapUtil.GetLength(counterBuffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterBuffers.Value)); index++)
                        {
                            fieldPointer[index] = counterBuffers.Value[index]?.handle ?? default(SharpVk.Interop.Buffer);
                        }
                        marshalledCounterBuffers = fieldPointer;
                    }
                }
                if (counterBufferOffsets.IsNull())
                {
                    marshalledCounterBufferOffsets = null;
                }
                else
                {
                    if (counterBufferOffsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBufferOffsets = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledCounterBufferOffsets) = counterBufferOffsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(counterBufferOffsets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterBufferOffsets.Value)); index++)
                        {
                            fieldPointer[index] = counterBufferOffsets.Value[index];
                        }
                        marshalledCounterBufferOffsets = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferEndTransformFeedbackDelegate commandDelegate = commandCache.Cache.vkCmdEndTransformFeedbackEXT;
                commandDelegate(extendedHandle.handle, firstCounterBuffer, (uint)(Interop.HeapUtil.GetLength(counterBuffers)), marshalledCounterBuffers, marshalledCounterBufferOffsets);
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
        /// <param name="queryPool">
        /// </param>
        /// <param name="query">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="index">
        /// </param>
        public static unsafe void BeginQueryIndexed(this SharpVk.CommandBuffer extendedHandle, SharpVk.QueryPool queryPool, uint query, uint index, SharpVk.QueryControlFlags? flags = default(SharpVk.QueryControlFlags?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.QueryControlFlags marshalledFlags = default(SharpVk.QueryControlFlags);
                commandCache = extendedHandle.commandCache;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.QueryControlFlags);
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBeginQueryIndexedDelegate commandDelegate = commandCache.Cache.vkCmdBeginQueryIndexedEXT;
                commandDelegate(extendedHandle.handle, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), query, marshalledFlags, index);
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
        /// <param name="queryPool">
        /// </param>
        /// <param name="query">
        /// </param>
        /// <param name="index">
        /// </param>
        public static unsafe void EndQueryIndexed(this SharpVk.CommandBuffer extendedHandle, SharpVk.QueryPool queryPool, uint query, uint index)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferEndQueryIndexedDelegate commandDelegate = commandCache.Cache.vkCmdEndQueryIndexedEXT;
                commandDelegate(extendedHandle.handle, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), query, index);
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
        /// <param name="instanceCount">
        /// </param>
        /// <param name="firstInstance">
        /// </param>
        /// <param name="counterBuffer">
        /// </param>
        /// <param name="counterBufferOffset">
        /// </param>
        /// <param name="counterOffset">
        /// </param>
        /// <param name="vertexStride">
        /// </param>
        public static unsafe void DrawIndirectByteCount(this SharpVk.CommandBuffer extendedHandle, uint instanceCount, uint firstInstance, SharpVk.Buffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferDrawIndirectByteCountDelegate commandDelegate = commandCache.Cache.vkCmdDrawIndirectByteCountEXT;
                commandDelegate(extendedHandle.handle, instanceCount, firstInstance, counterBuffer?.handle ?? default(SharpVk.Interop.Buffer), counterBufferOffset, counterOffset, vertexStride);
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
        /// <param name="flags">
        /// </param>
        public static unsafe void BeginConditionalRendering(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer buffer, ulong offset, SharpVk.Multivendor.ConditionalRenderingFlags? flags = default(SharpVk.Multivendor.ConditionalRenderingFlags?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo* marshalledConditionalRenderingBegin = default(SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo*);
                void* vkConditionalRenderingBeginInfoEXTNextPointer = default(void*);
                commandCache = extendedHandle.commandCache;
                marshalledConditionalRenderingBegin = (SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo>());
                marshalledConditionalRenderingBegin->SType = StructureType.ConditionalRenderingBeginInfo;
                marshalledConditionalRenderingBegin->Next = vkConditionalRenderingBeginInfoEXTNextPointer;
                marshalledConditionalRenderingBegin->Buffer = buffer?.handle ?? default(SharpVk.Interop.Buffer);
                marshalledConditionalRenderingBegin->Offset = offset;
                if (flags != null)
                {
                    marshalledConditionalRenderingBegin->Flags = flags.Value;
                }
                else
                {
                    marshalledConditionalRenderingBegin->Flags = default(SharpVk.Multivendor.ConditionalRenderingFlags);
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBeginConditionalRenderingDelegate commandDelegate = commandCache.Cache.vkCmdBeginConditionalRenderingEXT;
                commandDelegate(extendedHandle.handle, marshalledConditionalRenderingBegin);
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
        public static unsafe void EndConditionalRendering(this SharpVk.CommandBuffer extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferEndConditionalRenderingDelegate commandDelegate = commandCache.Cache.vkCmdEndConditionalRenderingEXT;
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="firstDiscardRectangle">
        /// </param>
        /// <param name="discardRectangles">
        /// </param>
        public static unsafe void SetDiscardRectangle(this SharpVk.CommandBuffer extendedHandle, uint firstDiscardRectangle, ArrayProxy<SharpVk.Rect2D>? discardRectangles)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Rect2D* marshalledDiscardRectangles = default(SharpVk.Rect2D*);
                commandCache = extendedHandle.commandCache;
                if (discardRectangles.IsNull())
                {
                    marshalledDiscardRectangles = null;
                }
                else
                {
                    if (discardRectangles.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDiscardRectangles = (SharpVk.Rect2D*)(Interop.HeapUtil.Allocate<SharpVk.Rect2D>());
                        *(SharpVk.Rect2D*)(marshalledDiscardRectangles) = discardRectangles.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Rect2D*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Rect2D>(Interop.HeapUtil.GetLength(discardRectangles.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(discardRectangles.Value)); index++)
                        {
                            fieldPointer[index] = discardRectangles.Value[index];
                        }
                        marshalledDiscardRectangles = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetDiscardRectangleDelegate commandDelegate = commandCache.Cache.vkCmdSetDiscardRectangleEXT;
                commandDelegate(extendedHandle.handle, firstDiscardRectangle, (uint)(Interop.HeapUtil.GetLength(discardRectangles)), marshalledDiscardRectangles);
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
        /// <param name="discardRectangleEnable">
        /// </param>
        public static unsafe void SetDiscardRectangleEnable(this SharpVk.CommandBuffer extendedHandle, bool discardRectangleEnable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetDiscardRectangleEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetDiscardRectangleEnableEXT;
                commandDelegate(extendedHandle.handle, discardRectangleEnable);
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
        /// <param name="discardRectangleMode">
        /// </param>
        public static unsafe void SetDiscardRectangleMode(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.DiscardRectangleMode discardRectangleMode)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetDiscardRectangleModeDelegate commandDelegate = commandCache.Cache.vkCmdSetDiscardRectangleModeEXT;
                commandDelegate(extendedHandle.handle, discardRectangleMode);
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
        /// <param name="labelInfo">
        /// </param>
        public static unsafe void BeginDebugUtilsLabel(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.DebugUtilsLabel labelInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugUtilsLabel* marshalledLabelInfo = default(SharpVk.Interop.Multivendor.DebugUtilsLabel*);
                commandCache = extendedHandle.commandCache;
                marshalledLabelInfo = (SharpVk.Interop.Multivendor.DebugUtilsLabel*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsLabel>());
                labelInfo.MarshalTo(marshalledLabelInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferBeginDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkCmdBeginDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.handle, marshalledLabelInfo);
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
        public static unsafe void EndDebugUtilsLabel(this SharpVk.CommandBuffer extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferEndDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkCmdEndDebugUtilsLabelEXT;
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="labelInfo">
        /// </param>
        public static unsafe void InsertDebugUtilsLabel(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.DebugUtilsLabel labelInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugUtilsLabel* marshalledLabelInfo = default(SharpVk.Interop.Multivendor.DebugUtilsLabel*);
                commandCache = extendedHandle.commandCache;
                marshalledLabelInfo = (SharpVk.Interop.Multivendor.DebugUtilsLabel*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsLabel>());
                labelInfo.MarshalTo(marshalledLabelInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferInsertDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkCmdInsertDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.handle, marshalledLabelInfo);
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
        /// <param name="bindInfo">
        /// </param>
        public static unsafe void BindSamplerHeap(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.BindHeapInfo bindInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.BindHeapInfo* marshalledBindInfo = default(SharpVk.Interop.Multivendor.BindHeapInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledBindInfo = (SharpVk.Interop.Multivendor.BindHeapInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.BindHeapInfo>());
                bindInfo.MarshalTo(marshalledBindInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferBindSamplerHeapDelegate commandDelegate = commandCache.Cache.vkCmdBindSamplerHeapEXT;
                commandDelegate(extendedHandle.handle, marshalledBindInfo);
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
        /// <param name="bindInfo">
        /// </param>
        public static unsafe void BindResourceHeap(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.BindHeapInfo bindInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.BindHeapInfo* marshalledBindInfo = default(SharpVk.Interop.Multivendor.BindHeapInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledBindInfo = (SharpVk.Interop.Multivendor.BindHeapInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.BindHeapInfo>());
                bindInfo.MarshalTo(marshalledBindInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferBindResourceHeapDelegate commandDelegate = commandCache.Cache.vkCmdBindResourceHeapEXT;
                commandDelegate(extendedHandle.handle, marshalledBindInfo);
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
        /// <param name="pushDataInfo">
        /// </param>
        public static unsafe void PushData(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.PushDataInfo pushDataInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.PushDataInfo* marshalledPushDataInfo = default(SharpVk.Interop.Multivendor.PushDataInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledPushDataInfo = (SharpVk.Interop.Multivendor.PushDataInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PushDataInfo>());
                pushDataInfo.MarshalTo(marshalledPushDataInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferPushDataDelegate commandDelegate = commandCache.Cache.vkCmdPushDataEXT;
                commandDelegate(extendedHandle.handle, marshalledPushDataInfo);
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
        /// <param name="sampleLocationsInfo">
        /// </param>
        public static unsafe void SetSampleLocations(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.SampleLocationsInfo sampleLocationsInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.SampleLocationsInfo* marshalledSampleLocationsInfo = default(SharpVk.Interop.Multivendor.SampleLocationsInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledSampleLocationsInfo = (SharpVk.Interop.Multivendor.SampleLocationsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SampleLocationsInfo>());
                sampleLocationsInfo.MarshalTo(marshalledSampleLocationsInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferSetSampleLocationsDelegate commandDelegate = commandCache.Cache.vkCmdSetSampleLocationsEXT;
                commandDelegate(extendedHandle.handle, marshalledSampleLocationsInfo);
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
        /// <param name="depthBiasInfo">
        /// </param>
        public static unsafe void SetDepthBias2(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.DepthBiasInfo depthBiasInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DepthBiasInfo* marshalledDepthBiasInfo = default(SharpVk.Interop.Multivendor.DepthBiasInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledDepthBiasInfo = (SharpVk.Interop.Multivendor.DepthBiasInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DepthBiasInfo>());
                depthBiasInfo.MarshalTo(marshalledDepthBiasInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferSetDepthBias2Delegate commandDelegate = commandCache.Cache.vkCmdSetDepthBias2EXT;
                commandDelegate(extendedHandle.handle, marshalledDepthBiasInfo);
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
        /// <param name="bindingInfos">
        /// </param>
        public static unsafe void BindDescriptorBuffers(this SharpVk.CommandBuffer extendedHandle, ArrayProxy<SharpVk.Multivendor.DescriptorBufferBindingInfo>? bindingInfos)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DescriptorBufferBindingInfo* marshalledBindingInfos = default(SharpVk.Interop.Multivendor.DescriptorBufferBindingInfo*);
                commandCache = extendedHandle.commandCache;
                if (bindingInfos.IsNull())
                {
                    marshalledBindingInfos = null;
                }
                else
                {
                    if (bindingInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindingInfos = (SharpVk.Interop.Multivendor.DescriptorBufferBindingInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DescriptorBufferBindingInfo>());
                        bindingInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.DescriptorBufferBindingInfo*)(marshalledBindingInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.DescriptorBufferBindingInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.DescriptorBufferBindingInfo>(Interop.HeapUtil.GetLength(bindingInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindingInfos.Value)); index++)
                        {
                            bindingInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindingInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBindDescriptorBuffersDelegate commandDelegate = commandCache.Cache.vkCmdBindDescriptorBuffersEXT;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(bindingInfos)), marshalledBindingInfos);
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
        /// <param name="layout">
        /// </param>
        /// <param name="firstSet">
        /// </param>
        /// <param name="bufferIndices">
        /// </param>
        /// <param name="offsets">
        /// </param>
        public static unsafe void SetDescriptorBufferOffsets(this SharpVk.CommandBuffer extendedHandle, SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.PipelineLayout layout, uint firstSet, ArrayProxy<uint>? bufferIndices, ArrayProxy<ulong>? offsets)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                uint* marshalledBufferIndices = default(uint*);
                ulong* marshalledOffsets = default(ulong*);
                commandCache = extendedHandle.commandCache;
                if (bufferIndices.IsNull())
                {
                    marshalledBufferIndices = null;
                }
                else
                {
                    if (bufferIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBufferIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledBufferIndices) = bufferIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(bufferIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bufferIndices.Value)); index++)
                        {
                            fieldPointer[index] = bufferIndices.Value[index];
                        }
                        marshalledBufferIndices = fieldPointer;
                    }
                }
                if (offsets.IsNull())
                {
                    marshalledOffsets = null;
                }
                else
                {
                    if (offsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledOffsets = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledOffsets) = offsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(offsets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(offsets.Value)); index++)
                        {
                            fieldPointer[index] = offsets.Value[index];
                        }
                        marshalledOffsets = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetDescriptorBufferOffsetsDelegate commandDelegate = commandCache.Cache.vkCmdSetDescriptorBufferOffsetsEXT;
                commandDelegate(extendedHandle.handle, pipelineBindPoint, layout?.handle ?? default(SharpVk.Interop.PipelineLayout), firstSet, (uint)(Interop.HeapUtil.GetLength(bufferIndices)), marshalledBufferIndices, marshalledOffsets);
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
        /// <param name="layout">
        /// </param>
        /// <param name="set">
        /// </param>
        public static unsafe void BindDescriptorBufferEmbeddedSamplers(this SharpVk.CommandBuffer extendedHandle, SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.PipelineLayout layout, uint set)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferBindDescriptorBufferEmbeddedSamplersDelegate commandDelegate = commandCache.Cache.vkCmdBindDescriptorBufferEmbeddedSamplersEXT;
                commandDelegate(extendedHandle.handle, pipelineBindPoint, layout?.handle ?? default(SharpVk.Interop.PipelineLayout), set);
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
        /// <param name="addressRange">
        /// </param>
        /// <param name="addressFlags">
        /// </param>
        /// <param name="flags">
        /// </param>
        public static unsafe void BeginConditionalRendering2(this SharpVk.CommandBuffer extendedHandle, SharpVk.Khronos.DeviceAddressRange addressRange, SharpVk.Khronos.AddressCommandFlags? addressFlags = default(SharpVk.Khronos.AddressCommandFlags?), SharpVk.Multivendor.ConditionalRenderingFlags? flags = default(SharpVk.Multivendor.ConditionalRenderingFlags?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo2* marshalledConditionalRenderingBegin = default(SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo2*);
                void* vkConditionalRenderingBeginInfo2EXTNextPointer = default(void*);
                commandCache = extendedHandle.commandCache;
                marshalledConditionalRenderingBegin = (SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo2>());
                marshalledConditionalRenderingBegin->SType = StructureType.ConditionalRenderingBeginInfo2;
                marshalledConditionalRenderingBegin->Next = vkConditionalRenderingBeginInfo2EXTNextPointer;
                marshalledConditionalRenderingBegin->AddressRange = addressRange;
                if (addressFlags != null)
                {
                    marshalledConditionalRenderingBegin->AddressFlags = addressFlags.Value;
                }
                else
                {
                    marshalledConditionalRenderingBegin->AddressFlags = default(SharpVk.Khronos.AddressCommandFlags);
                }
                if (flags != null)
                {
                    marshalledConditionalRenderingBegin->Flags = flags.Value;
                }
                else
                {
                    marshalledConditionalRenderingBegin->Flags = default(SharpVk.Multivendor.ConditionalRenderingFlags);
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBeginConditionalRendering2Delegate commandDelegate = commandCache.Cache.vkCmdBeginConditionalRendering2EXT;
                commandDelegate(extendedHandle.handle, marshalledConditionalRenderingBegin);
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
        /// <param name="firstBinding">
        /// </param>
        /// <param name="bindingInfos">
        /// </param>
        public static unsafe void BindTransformFeedbackBuffers2(this SharpVk.CommandBuffer extendedHandle, uint firstBinding, ArrayProxy<SharpVk.Multivendor.BindTransformFeedbackBuffer2Info>? bindingInfos = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info* marshalledBindingInfos = default(SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*);
                commandCache = extendedHandle.commandCache;
                if (bindingInfos.IsNull())
                {
                    marshalledBindingInfos = null;
                }
                else
                {
                    if (bindingInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindingInfos = (SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info>());
                        bindingInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*)(marshalledBindingInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info>(Interop.HeapUtil.GetLength(bindingInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindingInfos.Value)); index++)
                        {
                            bindingInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindingInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBindTransformFeedbackBuffers2Delegate commandDelegate = commandCache.Cache.vkCmdBindTransformFeedbackBuffers2EXT;
                commandDelegate(extendedHandle.handle, firstBinding, (uint)(Interop.HeapUtil.GetLength(bindingInfos)), marshalledBindingInfos);
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
        /// <param name="firstCounterRange">
        /// </param>
        /// <param name="counterInfos">
        /// </param>
        public static unsafe void BeginTransformFeedback2(this SharpVk.CommandBuffer extendedHandle, uint firstCounterRange, ArrayProxy<SharpVk.Multivendor.BindTransformFeedbackBuffer2Info>? counterInfos = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info* marshalledCounterInfos = default(SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*);
                commandCache = extendedHandle.commandCache;
                if (counterInfos.IsNull())
                {
                    marshalledCounterInfos = null;
                }
                else
                {
                    if (counterInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterInfos = (SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info>());
                        counterInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*)(marshalledCounterInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info>(Interop.HeapUtil.GetLength(counterInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterInfos.Value)); index++)
                        {
                            counterInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCounterInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBeginTransformFeedback2Delegate commandDelegate = commandCache.Cache.vkCmdBeginTransformFeedback2EXT;
                commandDelegate(extendedHandle.handle, firstCounterRange, (uint)(Interop.HeapUtil.GetLength(counterInfos)), marshalledCounterInfos);
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
        /// <param name="firstCounterRange">
        /// </param>
        /// <param name="counterInfos">
        /// </param>
        public static unsafe void EndTransformFeedback2(this SharpVk.CommandBuffer extendedHandle, uint firstCounterRange, ArrayProxy<SharpVk.Multivendor.BindTransformFeedbackBuffer2Info>? counterInfos = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info* marshalledCounterInfos = default(SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*);
                commandCache = extendedHandle.commandCache;
                if (counterInfos.IsNull())
                {
                    marshalledCounterInfos = null;
                }
                else
                {
                    if (counterInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterInfos = (SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info>());
                        counterInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*)(marshalledCounterInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info>(Interop.HeapUtil.GetLength(counterInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterInfos.Value)); index++)
                        {
                            counterInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCounterInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferEndTransformFeedback2Delegate commandDelegate = commandCache.Cache.vkCmdEndTransformFeedback2EXT;
                commandDelegate(extendedHandle.handle, firstCounterRange, (uint)(Interop.HeapUtil.GetLength(counterInfos)), marshalledCounterInfos);
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
        /// <param name="instanceCount">
        /// </param>
        /// <param name="firstInstance">
        /// </param>
        /// <param name="counterInfo">
        /// </param>
        /// <param name="counterOffset">
        /// </param>
        /// <param name="vertexStride">
        /// </param>
        public static unsafe void DrawIndirectByteCount2(this SharpVk.CommandBuffer extendedHandle, uint instanceCount, uint firstInstance, SharpVk.Multivendor.BindTransformFeedbackBuffer2Info counterInfo, uint counterOffset, uint vertexStride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info* marshalledCounterInfo = default(SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*);
                commandCache = extendedHandle.commandCache;
                marshalledCounterInfo = (SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.BindTransformFeedbackBuffer2Info>());
                counterInfo.MarshalTo(marshalledCounterInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferDrawIndirectByteCount2Delegate commandDelegate = commandCache.Cache.vkCmdDrawIndirectByteCount2EXT;
                commandDelegate(extendedHandle.handle, instanceCount, firstInstance, marshalledCounterInfo, counterOffset, vertexStride);
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
        public static unsafe void DrawMeshTasksIndirect2(this SharpVk.CommandBuffer extendedHandle, SharpVk.Khronos.DrawIndirect2Info info)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DrawIndirect2Info* marshalledInfo = default(SharpVk.Interop.Khronos.DrawIndirect2Info*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.DrawIndirect2Info*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DrawIndirect2Info>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferDrawMeshTasksIndirect2Delegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksIndirect2EXT;
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe void DrawMeshTasksIndirectCount2(this SharpVk.CommandBuffer extendedHandle, SharpVk.Khronos.DrawIndirectCount2Info info)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DrawIndirectCount2Info* marshalledInfo = default(SharpVk.Interop.Khronos.DrawIndirectCount2Info*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.DrawIndirectCount2Info*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DrawIndirectCount2Info>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferDrawMeshTasksIndirectCount2Delegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksIndirectCount2EXT;
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="groupCountX">
        /// </param>
        /// <param name="groupCountY">
        /// </param>
        /// <param name="groupCountZ">
        /// </param>
        public static unsafe void DrawMeshTasks(this SharpVk.CommandBuffer extendedHandle, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferDrawMeshTasksDelegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksEXT;
                commandDelegate(extendedHandle.handle, groupCountX, groupCountY, groupCountZ);
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
                SharpVk.Interop.Multivendor.VkCommandBufferDrawMeshTasksIndirectDelegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksIndirectEXT;
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
                SharpVk.Interop.Multivendor.VkCommandBufferDrawMeshTasksIndirectCountDelegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksIndirectCountEXT;
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
        /// <param name="vertexBindingDescriptions">
        /// </param>
        /// <param name="vertexAttributeDescriptions">
        /// </param>
        public static unsafe void SetVertexInput(this SharpVk.CommandBuffer extendedHandle, ArrayProxy<SharpVk.Multivendor.VertexInputBindingDescription2>? vertexBindingDescriptions, ArrayProxy<SharpVk.Multivendor.VertexInputAttributeDescription2>? vertexAttributeDescriptions)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.VertexInputBindingDescription2* marshalledVertexBindingDescriptions = default(SharpVk.Interop.Multivendor.VertexInputBindingDescription2*);
                SharpVk.Interop.Multivendor.VertexInputAttributeDescription2* marshalledVertexAttributeDescriptions = default(SharpVk.Interop.Multivendor.VertexInputAttributeDescription2*);
                commandCache = extendedHandle.commandCache;
                if (vertexBindingDescriptions.IsNull())
                {
                    marshalledVertexBindingDescriptions = null;
                }
                else
                {
                    if (vertexBindingDescriptions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledVertexBindingDescriptions = (SharpVk.Interop.Multivendor.VertexInputBindingDescription2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.VertexInputBindingDescription2>());
                        vertexBindingDescriptions.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.VertexInputBindingDescription2*)(marshalledVertexBindingDescriptions));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.VertexInputBindingDescription2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.VertexInputBindingDescription2>(Interop.HeapUtil.GetLength(vertexBindingDescriptions.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(vertexBindingDescriptions.Value)); index++)
                        {
                            vertexBindingDescriptions.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledVertexBindingDescriptions = fieldPointer;
                    }
                }
                if (vertexAttributeDescriptions.IsNull())
                {
                    marshalledVertexAttributeDescriptions = null;
                }
                else
                {
                    if (vertexAttributeDescriptions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledVertexAttributeDescriptions = (SharpVk.Interop.Multivendor.VertexInputAttributeDescription2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.VertexInputAttributeDescription2>());
                        vertexAttributeDescriptions.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.VertexInputAttributeDescription2*)(marshalledVertexAttributeDescriptions));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.VertexInputAttributeDescription2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.VertexInputAttributeDescription2>(Interop.HeapUtil.GetLength(vertexAttributeDescriptions.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(vertexAttributeDescriptions.Value)); index++)
                        {
                            vertexAttributeDescriptions.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledVertexAttributeDescriptions = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetVertexInputDelegate commandDelegate = commandCache.Cache.vkCmdSetVertexInputEXT;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(vertexBindingDescriptions)), marshalledVertexBindingDescriptions, (uint)(Interop.HeapUtil.GetLength(vertexAttributeDescriptions)), marshalledVertexAttributeDescriptions);
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
        /// <param name="colorWriteEnables">
        /// </param>
        public static unsafe void SetColorWriteEnable(this SharpVk.CommandBuffer extendedHandle, ArrayProxy<bool>? colorWriteEnables)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                Bool32* marshalledColorWriteEnables = default(Bool32*);
                commandCache = extendedHandle.commandCache;
                if (colorWriteEnables.IsNull())
                {
                    marshalledColorWriteEnables = null;
                }
                else
                {
                    if (colorWriteEnables.Value.Contents == ProxyContents.Single)
                    {
                        marshalledColorWriteEnables = (Bool32*)(Interop.HeapUtil.Allocate<Bool32>());
                        *(Bool32*)(marshalledColorWriteEnables) = colorWriteEnables.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (Bool32*)(Interop.HeapUtil.AllocateAndClear<Bool32>(Interop.HeapUtil.GetLength(colorWriteEnables.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(colorWriteEnables.Value)); index++)
                        {
                            fieldPointer[index] = colorWriteEnables.Value[index];
                        }
                        marshalledColorWriteEnables = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetColorWriteEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetColorWriteEnableEXT;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(colorWriteEnables)), marshalledColorWriteEnables);
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
        /// <param name="vertexInfo">
        /// </param>
        /// <param name="instanceCount">
        /// </param>
        /// <param name="firstInstance">
        /// </param>
        /// <param name="stride">
        /// </param>
        public static unsafe void DrawMulti(this SharpVk.CommandBuffer extendedHandle, ArrayProxy<SharpVk.Multivendor.MultiDrawInfo>? vertexInfo, uint instanceCount, uint firstInstance, uint stride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Multivendor.MultiDrawInfo* marshalledVertexInfo = default(SharpVk.Multivendor.MultiDrawInfo*);
                commandCache = extendedHandle.commandCache;
                if (vertexInfo.IsNull())
                {
                    marshalledVertexInfo = null;
                }
                else
                {
                    if (vertexInfo.Value.Contents == ProxyContents.Single)
                    {
                        marshalledVertexInfo = (SharpVk.Multivendor.MultiDrawInfo*)(Interop.HeapUtil.Allocate<SharpVk.Multivendor.MultiDrawInfo>());
                        *(SharpVk.Multivendor.MultiDrawInfo*)(marshalledVertexInfo) = vertexInfo.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Multivendor.MultiDrawInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Multivendor.MultiDrawInfo>(Interop.HeapUtil.GetLength(vertexInfo.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(vertexInfo.Value)); index++)
                        {
                            fieldPointer[index] = vertexInfo.Value[index];
                        }
                        marshalledVertexInfo = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferDrawMultiDelegate commandDelegate = commandCache.Cache.vkCmdDrawMultiEXT;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(vertexInfo)), marshalledVertexInfo, instanceCount, firstInstance, stride);
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
        /// <param name="indexInfo">
        /// </param>
        /// <param name="instanceCount">
        /// </param>
        /// <param name="firstInstance">
        /// </param>
        /// <param name="stride">
        /// </param>
        /// <param name="vertexOffset">
        /// </param>
        public static unsafe void DrawMultiIndexed(this SharpVk.CommandBuffer extendedHandle, ArrayProxy<SharpVk.Multivendor.MultiDrawIndexedInfo>? indexInfo, uint instanceCount, uint firstInstance, uint stride, int? vertexOffset = default(int?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Multivendor.MultiDrawIndexedInfo* marshalledIndexInfo = default(SharpVk.Multivendor.MultiDrawIndexedInfo*);
                int* marshalledVertexOffset = default(int*);
                commandCache = extendedHandle.commandCache;
                if (indexInfo.IsNull())
                {
                    marshalledIndexInfo = null;
                }
                else
                {
                    if (indexInfo.Value.Contents == ProxyContents.Single)
                    {
                        marshalledIndexInfo = (SharpVk.Multivendor.MultiDrawIndexedInfo*)(Interop.HeapUtil.Allocate<SharpVk.Multivendor.MultiDrawIndexedInfo>());
                        *(SharpVk.Multivendor.MultiDrawIndexedInfo*)(marshalledIndexInfo) = indexInfo.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Multivendor.MultiDrawIndexedInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Multivendor.MultiDrawIndexedInfo>(Interop.HeapUtil.GetLength(indexInfo.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(indexInfo.Value)); index++)
                        {
                            fieldPointer[index] = indexInfo.Value[index];
                        }
                        marshalledIndexInfo = fieldPointer;
                    }
                }
                if (vertexOffset != null)
                {
                    marshalledVertexOffset = (int*)(Interop.HeapUtil.Allocate<int>());
                    *marshalledVertexOffset = vertexOffset.Value;
                }
                else
                {
                    marshalledVertexOffset = default(int*);
                }
                SharpVk.Interop.Multivendor.VkCommandBufferDrawMultiIndexedDelegate commandDelegate = commandCache.Cache.vkCmdDrawMultiIndexedEXT;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(indexInfo)), marshalledIndexInfo, instanceCount, firstInstance, stride, marshalledVertexOffset);
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
        /// <param name="depthClampEnable">
        /// </param>
        public static unsafe void SetDepthClampEnable(this SharpVk.CommandBuffer extendedHandle, bool depthClampEnable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetDepthClampEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetDepthClampEnableEXT;
                commandDelegate(extendedHandle.handle, depthClampEnable);
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
        /// <param name="polygonMode">
        /// </param>
        public static unsafe void SetPolygonMode(this SharpVk.CommandBuffer extendedHandle, SharpVk.PolygonMode polygonMode)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetPolygonModeDelegate commandDelegate = commandCache.Cache.vkCmdSetPolygonModeEXT;
                commandDelegate(extendedHandle.handle, polygonMode);
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
        /// <param name="rasterizationSamples">
        /// </param>
        public static unsafe void SetRasterizationSamples(this SharpVk.CommandBuffer extendedHandle, SharpVk.SampleCountFlags rasterizationSamples)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetRasterizationSamplesDelegate commandDelegate = commandCache.Cache.vkCmdSetRasterizationSamplesEXT;
                commandDelegate(extendedHandle.handle, rasterizationSamples);
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
        /// <param name="samples">
        /// </param>
        /// <param name="sampleMask">
        /// </param>
        public static unsafe void SetSampleMask(this SharpVk.CommandBuffer extendedHandle, SharpVk.SampleCountFlags samples, ArrayProxy<SampleMask>? sampleMask = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SampleMask* marshalledSampleMask = default(SampleMask*);
                commandCache = extendedHandle.commandCache;
                if (sampleMask.IsNull())
                {
                    marshalledSampleMask = null;
                }
                else
                {
                    if (sampleMask.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSampleMask = (SampleMask*)(Interop.HeapUtil.Allocate<SampleMask>());
                        *(SampleMask*)(marshalledSampleMask) = sampleMask.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SampleMask*)(Interop.HeapUtil.AllocateAndClear<SampleMask>(Interop.HeapUtil.GetLength(sampleMask.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(sampleMask.Value)); index++)
                        {
                            fieldPointer[index] = sampleMask.Value[index];
                        }
                        marshalledSampleMask = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetSampleMaskDelegate commandDelegate = commandCache.Cache.vkCmdSetSampleMaskEXT;
                commandDelegate(extendedHandle.handle, samples, marshalledSampleMask);
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
        /// <param name="alphaToCoverageEnable">
        /// </param>
        public static unsafe void SetAlphaToCoverageEnable(this SharpVk.CommandBuffer extendedHandle, bool alphaToCoverageEnable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetAlphaToCoverageEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetAlphaToCoverageEnableEXT;
                commandDelegate(extendedHandle.handle, alphaToCoverageEnable);
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
        /// <param name="alphaToOneEnable">
        /// </param>
        public static unsafe void SetAlphaToOneEnable(this SharpVk.CommandBuffer extendedHandle, bool alphaToOneEnable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetAlphaToOneEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetAlphaToOneEnableEXT;
                commandDelegate(extendedHandle.handle, alphaToOneEnable);
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
        /// <param name="logicOpEnable">
        /// </param>
        public static unsafe void SetLogicOpEnable(this SharpVk.CommandBuffer extendedHandle, bool logicOpEnable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetLogicOpEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetLogicOpEnableEXT;
                commandDelegate(extendedHandle.handle, logicOpEnable);
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
        /// <param name="firstAttachment">
        /// </param>
        /// <param name="colorBlendEnables">
        /// </param>
        public static unsafe void SetColorBlendEnable(this SharpVk.CommandBuffer extendedHandle, uint firstAttachment, ArrayProxy<bool>? colorBlendEnables)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                Bool32* marshalledColorBlendEnables = default(Bool32*);
                commandCache = extendedHandle.commandCache;
                if (colorBlendEnables.IsNull())
                {
                    marshalledColorBlendEnables = null;
                }
                else
                {
                    if (colorBlendEnables.Value.Contents == ProxyContents.Single)
                    {
                        marshalledColorBlendEnables = (Bool32*)(Interop.HeapUtil.Allocate<Bool32>());
                        *(Bool32*)(marshalledColorBlendEnables) = colorBlendEnables.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (Bool32*)(Interop.HeapUtil.AllocateAndClear<Bool32>(Interop.HeapUtil.GetLength(colorBlendEnables.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(colorBlendEnables.Value)); index++)
                        {
                            fieldPointer[index] = colorBlendEnables.Value[index];
                        }
                        marshalledColorBlendEnables = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetColorBlendEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetColorBlendEnableEXT;
                commandDelegate(extendedHandle.handle, firstAttachment, (uint)(Interop.HeapUtil.GetLength(colorBlendEnables)), marshalledColorBlendEnables);
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
        /// <param name="firstAttachment">
        /// </param>
        /// <param name="colorBlendEquations">
        /// </param>
        public static unsafe void SetColorBlendEquation(this SharpVk.CommandBuffer extendedHandle, uint firstAttachment, ArrayProxy<SharpVk.Multivendor.ColorBlendEquation>? colorBlendEquations)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Multivendor.ColorBlendEquation* marshalledColorBlendEquations = default(SharpVk.Multivendor.ColorBlendEquation*);
                commandCache = extendedHandle.commandCache;
                if (colorBlendEquations.IsNull())
                {
                    marshalledColorBlendEquations = null;
                }
                else
                {
                    if (colorBlendEquations.Value.Contents == ProxyContents.Single)
                    {
                        marshalledColorBlendEquations = (SharpVk.Multivendor.ColorBlendEquation*)(Interop.HeapUtil.Allocate<SharpVk.Multivendor.ColorBlendEquation>());
                        *(SharpVk.Multivendor.ColorBlendEquation*)(marshalledColorBlendEquations) = colorBlendEquations.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Multivendor.ColorBlendEquation*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Multivendor.ColorBlendEquation>(Interop.HeapUtil.GetLength(colorBlendEquations.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(colorBlendEquations.Value)); index++)
                        {
                            fieldPointer[index] = colorBlendEquations.Value[index];
                        }
                        marshalledColorBlendEquations = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetColorBlendEquationDelegate commandDelegate = commandCache.Cache.vkCmdSetColorBlendEquationEXT;
                commandDelegate(extendedHandle.handle, firstAttachment, (uint)(Interop.HeapUtil.GetLength(colorBlendEquations)), marshalledColorBlendEquations);
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
        /// <param name="firstAttachment">
        /// </param>
        /// <param name="colorWriteMasks">
        /// </param>
        public static unsafe void SetColorWriteMask(this SharpVk.CommandBuffer extendedHandle, uint firstAttachment, ArrayProxy<SharpVk.ColorComponentFlags>? colorWriteMasks)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.ColorComponentFlags* marshalledColorWriteMasks = default(SharpVk.ColorComponentFlags*);
                commandCache = extendedHandle.commandCache;
                if (colorWriteMasks.IsNull())
                {
                    marshalledColorWriteMasks = null;
                }
                else
                {
                    if (colorWriteMasks.Value.Contents == ProxyContents.Single)
                    {
                        marshalledColorWriteMasks = (SharpVk.ColorComponentFlags*)(Interop.HeapUtil.Allocate<SharpVk.ColorComponentFlags>());
                        *(SharpVk.ColorComponentFlags*)(marshalledColorWriteMasks) = colorWriteMasks.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.ColorComponentFlags*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ColorComponentFlags>(Interop.HeapUtil.GetLength(colorWriteMasks.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(colorWriteMasks.Value)); index++)
                        {
                            fieldPointer[index] = colorWriteMasks.Value[index];
                        }
                        marshalledColorWriteMasks = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetColorWriteMaskDelegate commandDelegate = commandCache.Cache.vkCmdSetColorWriteMaskEXT;
                commandDelegate(extendedHandle.handle, firstAttachment, (uint)(Interop.HeapUtil.GetLength(colorWriteMasks)), marshalledColorWriteMasks);
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
        /// <param name="domainOrigin">
        /// </param>
        public static unsafe void SetTessellationDomainOrigin(this SharpVk.CommandBuffer extendedHandle, SharpVk.TessellationDomainOrigin domainOrigin)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetTessellationDomainOriginDelegate commandDelegate = commandCache.Cache.vkCmdSetTessellationDomainOriginEXT;
                commandDelegate(extendedHandle.handle, domainOrigin);
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
        /// <param name="rasterizationStream">
        /// </param>
        public static unsafe void SetRasterizationStream(this SharpVk.CommandBuffer extendedHandle, uint rasterizationStream)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetRasterizationStreamDelegate commandDelegate = commandCache.Cache.vkCmdSetRasterizationStreamEXT;
                commandDelegate(extendedHandle.handle, rasterizationStream);
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
        /// <param name="conservativeRasterizationMode">
        /// </param>
        public static unsafe void SetConservativeRasterizationMode(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.ConservativeRasterizationMode conservativeRasterizationMode)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetConservativeRasterizationModeDelegate commandDelegate = commandCache.Cache.vkCmdSetConservativeRasterizationModeEXT;
                commandDelegate(extendedHandle.handle, conservativeRasterizationMode);
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
        /// <param name="extraPrimitiveOverestimationSize">
        /// </param>
        public static unsafe void SetExtraPrimitiveOverestimationSize(this SharpVk.CommandBuffer extendedHandle, float extraPrimitiveOverestimationSize)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetExtraPrimitiveOverestimationSizeDelegate commandDelegate = commandCache.Cache.vkCmdSetExtraPrimitiveOverestimationSizeEXT;
                commandDelegate(extendedHandle.handle, extraPrimitiveOverestimationSize);
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
        /// <param name="depthClipEnable">
        /// </param>
        public static unsafe void SetDepthClipEnable(this SharpVk.CommandBuffer extendedHandle, bool depthClipEnable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetDepthClipEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetDepthClipEnableEXT;
                commandDelegate(extendedHandle.handle, depthClipEnable);
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
        /// <param name="sampleLocationsEnable">
        /// </param>
        public static unsafe void SetSampleLocationsEnable(this SharpVk.CommandBuffer extendedHandle, bool sampleLocationsEnable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetSampleLocationsEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetSampleLocationsEnableEXT;
                commandDelegate(extendedHandle.handle, sampleLocationsEnable);
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
        /// <param name="firstAttachment">
        /// </param>
        /// <param name="colorBlendAdvanced">
        /// </param>
        public static unsafe void SetColorBlendAdvanced(this SharpVk.CommandBuffer extendedHandle, uint firstAttachment, ArrayProxy<SharpVk.Multivendor.ColorBlendAdvanced>? colorBlendAdvanced)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.ColorBlendAdvanced* marshalledColorBlendAdvanced = default(SharpVk.Interop.Multivendor.ColorBlendAdvanced*);
                commandCache = extendedHandle.commandCache;
                if (colorBlendAdvanced.IsNull())
                {
                    marshalledColorBlendAdvanced = null;
                }
                else
                {
                    if (colorBlendAdvanced.Value.Contents == ProxyContents.Single)
                    {
                        marshalledColorBlendAdvanced = (SharpVk.Interop.Multivendor.ColorBlendAdvanced*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ColorBlendAdvanced>());
                        colorBlendAdvanced.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.ColorBlendAdvanced*)(marshalledColorBlendAdvanced));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.ColorBlendAdvanced*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.ColorBlendAdvanced>(Interop.HeapUtil.GetLength(colorBlendAdvanced.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(colorBlendAdvanced.Value)); index++)
                        {
                            colorBlendAdvanced.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledColorBlendAdvanced = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetColorBlendAdvancedDelegate commandDelegate = commandCache.Cache.vkCmdSetColorBlendAdvancedEXT;
                commandDelegate(extendedHandle.handle, firstAttachment, (uint)(Interop.HeapUtil.GetLength(colorBlendAdvanced)), marshalledColorBlendAdvanced);
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
        /// <param name="provokingVertexMode">
        /// </param>
        public static unsafe void SetProvokingVertexMode(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.ProvokingVertexMode provokingVertexMode)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetProvokingVertexModeDelegate commandDelegate = commandCache.Cache.vkCmdSetProvokingVertexModeEXT;
                commandDelegate(extendedHandle.handle, provokingVertexMode);
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
        /// <param name="lineRasterizationMode">
        /// </param>
        public static unsafe void SetLineRasterizationMode(this SharpVk.CommandBuffer extendedHandle, SharpVk.LineRasterizationMode lineRasterizationMode)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetLineRasterizationModeDelegate commandDelegate = commandCache.Cache.vkCmdSetLineRasterizationModeEXT;
                commandDelegate(extendedHandle.handle, lineRasterizationMode);
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
        /// <param name="stippledLineEnable">
        /// </param>
        public static unsafe void SetLineStippleEnable(this SharpVk.CommandBuffer extendedHandle, bool stippledLineEnable)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetLineStippleEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetLineStippleEnableEXT;
                commandDelegate(extendedHandle.handle, stippledLineEnable);
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
        /// <param name="negativeOneToOne">
        /// </param>
        public static unsafe void SetDepthClipNegativeOneToOne(this SharpVk.CommandBuffer extendedHandle, bool negativeOneToOne)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetDepthClipNegativeOneToOneDelegate commandDelegate = commandCache.Cache.vkCmdSetDepthClipNegativeOneToOneEXT;
                commandDelegate(extendedHandle.handle, negativeOneToOne);
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
        /// <param name="stages">
        /// </param>
        /// <param name="shaders">
        /// </param>
        public static unsafe void BindShaders(this SharpVk.CommandBuffer extendedHandle, ArrayProxy<SharpVk.ShaderStageFlags>? stages, ArrayProxy<SharpVk.Multivendor.Shader>? shaders)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.ShaderStageFlags* marshalledStages = default(SharpVk.ShaderStageFlags*);
                SharpVk.Interop.Multivendor.Shader* marshalledShaders = default(SharpVk.Interop.Multivendor.Shader*);
                commandCache = extendedHandle.commandCache;
                if (stages.IsNull())
                {
                    marshalledStages = null;
                }
                else
                {
                    if (stages.Value.Contents == ProxyContents.Single)
                    {
                        marshalledStages = (SharpVk.ShaderStageFlags*)(Interop.HeapUtil.Allocate<SharpVk.ShaderStageFlags>());
                        *(SharpVk.ShaderStageFlags*)(marshalledStages) = stages.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.ShaderStageFlags*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ShaderStageFlags>(Interop.HeapUtil.GetLength(stages.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(stages.Value)); index++)
                        {
                            fieldPointer[index] = stages.Value[index];
                        }
                        marshalledStages = fieldPointer;
                    }
                }
                if (shaders.IsNull())
                {
                    marshalledShaders = null;
                }
                else
                {
                    if (shaders.Value.Contents == ProxyContents.Single)
                    {
                        marshalledShaders = (SharpVk.Interop.Multivendor.Shader*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.Shader>());
                        *(SharpVk.Interop.Multivendor.Shader*)(marshalledShaders) = shaders.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Multivendor.Shader);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.Shader*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.Shader>(Interop.HeapUtil.GetLength(shaders.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(shaders.Value)); index++)
                        {
                            fieldPointer[index] = shaders.Value[index]?.handle ?? default(SharpVk.Interop.Multivendor.Shader);
                        }
                        marshalledShaders = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBindShadersDelegate commandDelegate = commandCache.Cache.vkCmdBindShadersEXT;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(stages)), marshalledStages, marshalledShaders);
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
        /// <param name="patchControlPoints">
        /// </param>
        public static unsafe void SetPatchControlPoints(this SharpVk.CommandBuffer extendedHandle, uint patchControlPoints)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetPatchControlPointsDelegate commandDelegate = commandCache.Cache.vkCmdSetPatchControlPointsEXT;
                commandDelegate(extendedHandle.handle, patchControlPoints);
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
        /// <param name="logicOp">
        /// </param>
        public static unsafe void SetLogicOp(this SharpVk.CommandBuffer extendedHandle, SharpVk.LogicOp logicOp)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetLogicOpDelegate commandDelegate = commandCache.Cache.vkCmdSetLogicOpEXT;
                commandDelegate(extendedHandle.handle, logicOp);
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
        /// <param name="depthClampMode">
        /// </param>
        /// <param name="depthClampRange">
        /// </param>
        public static unsafe void SetDepthClampRange(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.DepthClampMode depthClampMode, SharpVk.Multivendor.DepthClampRange? depthClampRange = default(SharpVk.Multivendor.DepthClampRange?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Multivendor.DepthClampRange* marshalledDepthClampRange = default(SharpVk.Multivendor.DepthClampRange*);
                commandCache = extendedHandle.commandCache;
                if (depthClampRange != null)
                {
                    marshalledDepthClampRange = (SharpVk.Multivendor.DepthClampRange*)(Interop.HeapUtil.Allocate<SharpVk.Multivendor.DepthClampRange>());
                    *marshalledDepthClampRange = depthClampRange.Value;
                }
                else
                {
                    marshalledDepthClampRange = default(SharpVk.Multivendor.DepthClampRange*);
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetDepthClampRangeDelegate commandDelegate = commandCache.Cache.vkCmdSetDepthClampRangeEXT;
                commandDelegate(extendedHandle.handle, depthClampMode, marshalledDepthClampRange);
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
        /// <param name="aspectMask">
        /// </param>
        public static unsafe void SetAttachmentFeedbackLoopEnable(this SharpVk.CommandBuffer extendedHandle, SharpVk.ImageAspectFlags? aspectMask = default(SharpVk.ImageAspectFlags?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.ImageAspectFlags marshalledAspectMask = default(SharpVk.ImageAspectFlags);
                commandCache = extendedHandle.commandCache;
                if (aspectMask != null)
                {
                    marshalledAspectMask = aspectMask.Value;
                }
                else
                {
                    marshalledAspectMask = default(SharpVk.ImageAspectFlags);
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetAttachmentFeedbackLoopEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetAttachmentFeedbackLoopEnableEXT;
                commandDelegate(extendedHandle.handle, marshalledAspectMask);
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
        /// <param name="decompressMemoryInfo">
        /// </param>
        public static unsafe void DecompressMemory(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.DecompressMemoryInfo decompressMemoryInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DecompressMemoryInfo* marshalledDecompressMemoryInfo = default(SharpVk.Interop.Multivendor.DecompressMemoryInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledDecompressMemoryInfo = (SharpVk.Interop.Multivendor.DecompressMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DecompressMemoryInfo>());
                decompressMemoryInfo.MarshalTo(marshalledDecompressMemoryInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferDecompressMemoryDelegate commandDelegate = commandCache.Cache.vkCmdDecompressMemoryEXT;
                commandDelegate(extendedHandle.handle, marshalledDecompressMemoryInfo);
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
        /// <param name="decompressionMethod">
        /// </param>
        /// <param name="indirectCommandsAddress">
        /// </param>
        /// <param name="indirectCommandsCountAddress">
        /// </param>
        /// <param name="maxDecompressionCount">
        /// </param>
        /// <param name="stride">
        /// </param>
        public static unsafe void DecompressMemoryIndirectCount(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.MemoryDecompressionMethodFlags decompressionMethod, ulong indirectCommandsAddress, ulong indirectCommandsCountAddress, uint maxDecompressionCount, uint stride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferDecompressMemoryIndirectCountDelegate commandDelegate = commandCache.Cache.vkCmdDecompressMemoryIndirectCountEXT;
                commandDelegate(extendedHandle.handle, decompressionMethod, indirectCommandsAddress, indirectCommandsCountAddress, maxDecompressionCount, stride);
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
        /// <param name="stateCommandBuffer">
        /// </param>
        public static unsafe void PreprocessGeneratedCommands(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.GeneratedCommandsInfo generatedCommandsInfo, SharpVk.CommandBuffer stateCommandBuffer)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.GeneratedCommandsInfo* marshalledGeneratedCommandsInfo = default(SharpVk.Interop.Multivendor.GeneratedCommandsInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledGeneratedCommandsInfo = (SharpVk.Interop.Multivendor.GeneratedCommandsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.GeneratedCommandsInfo>());
                generatedCommandsInfo.MarshalTo(marshalledGeneratedCommandsInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferPreprocessGeneratedCommandsDelegate commandDelegate = commandCache.Cache.vkCmdPreprocessGeneratedCommandsEXT;
                commandDelegate(extendedHandle.handle, marshalledGeneratedCommandsInfo, stateCommandBuffer?.handle ?? default(SharpVk.Interop.CommandBuffer));
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
        public static unsafe void ExecuteGeneratedCommands(this SharpVk.CommandBuffer extendedHandle, bool isPreprocessed, SharpVk.Multivendor.GeneratedCommandsInfo generatedCommandsInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.GeneratedCommandsInfo* marshalledGeneratedCommandsInfo = default(SharpVk.Interop.Multivendor.GeneratedCommandsInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledGeneratedCommandsInfo = (SharpVk.Interop.Multivendor.GeneratedCommandsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.GeneratedCommandsInfo>());
                generatedCommandsInfo.MarshalTo(marshalledGeneratedCommandsInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferExecuteGeneratedCommandsDelegate commandDelegate = commandCache.Cache.vkCmdExecuteGeneratedCommandsEXT;
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
        /// <param name="beginCustomResolveInfo">
        /// </param>
        public static unsafe void BeginCustomResolve(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.BeginCustomResolveInfo? beginCustomResolveInfo = default(SharpVk.Multivendor.BeginCustomResolveInfo?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.BeginCustomResolveInfo* marshalledBeginCustomResolveInfo = default(SharpVk.Interop.Multivendor.BeginCustomResolveInfo*);
                commandCache = extendedHandle.commandCache;
                if (beginCustomResolveInfo != null)
                {
                    marshalledBeginCustomResolveInfo = (SharpVk.Interop.Multivendor.BeginCustomResolveInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.BeginCustomResolveInfo>());
                    beginCustomResolveInfo.Value.MarshalTo(marshalledBeginCustomResolveInfo);
                }
                else
                {
                    marshalledBeginCustomResolveInfo = default(SharpVk.Interop.Multivendor.BeginCustomResolveInfo*);
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBeginCustomResolveDelegate commandDelegate = commandCache.Cache.vkCmdBeginCustomResolveEXT;
                commandDelegate(extendedHandle.handle, marshalledBeginCustomResolveInfo);
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
        /// <param name="primitiveRestartIndex">
        /// </param>
        public static unsafe void SetPrimitiveRestartIndex(this SharpVk.CommandBuffer extendedHandle, uint? primitiveRestartIndex = default(uint?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                uint marshalledPrimitiveRestartIndex = default(uint);
                commandCache = extendedHandle.commandCache;
                if (primitiveRestartIndex != null)
                {
                    marshalledPrimitiveRestartIndex = primitiveRestartIndex.Value;
                }
                else
                {
                    marshalledPrimitiveRestartIndex = default(uint);
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetPrimitiveRestartIndexDelegate commandDelegate = commandCache.Cache.vkCmdSetPrimitiveRestartIndexEXT;
                commandDelegate(extendedHandle.handle, marshalledPrimitiveRestartIndex);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
