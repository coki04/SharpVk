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
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="executionGraph">
        /// </param>
        /// <param name="scratch">
        /// </param>
        /// <param name="scratchSize">
        /// </param>
        public static unsafe void InitializeGraphScratchMemory(this SharpVk.CommandBuffer extendedHandle, SharpVk.Pipeline executionGraph, ulong scratch, ulong scratchSize)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Amdx.VkCommandBufferInitializeGraphScratchMemoryDelegate commandDelegate = commandCache.Cache.vkCmdInitializeGraphScratchMemoryAMDX;
                commandDelegate(extendedHandle.handle, executionGraph?.handle ?? default(SharpVk.Interop.Pipeline), scratch, scratchSize);
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
        /// <param name="scratch">
        /// </param>
        /// <param name="scratchSize">
        /// </param>
        /// <param name="countInfo">
        /// </param>
        public static unsafe void DispatchGraph(this SharpVk.CommandBuffer extendedHandle, ulong scratch, ulong scratchSize, SharpVk.Amdx.DispatchGraphCountInfo countInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Amdx.DispatchGraphCountInfo* marshalledCountInfo = default(SharpVk.Interop.Amdx.DispatchGraphCountInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledCountInfo = (SharpVk.Interop.Amdx.DispatchGraphCountInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amdx.DispatchGraphCountInfo>());
                countInfo.MarshalTo(marshalledCountInfo);
                SharpVk.Interop.Amdx.VkCommandBufferDispatchGraphDelegate commandDelegate = commandCache.Cache.vkCmdDispatchGraphAMDX;
                commandDelegate(extendedHandle.handle, scratch, scratchSize, marshalledCountInfo);
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
        /// <param name="scratch">
        /// </param>
        /// <param name="scratchSize">
        /// </param>
        /// <param name="countInfo">
        /// </param>
        public static unsafe void DispatchGraphIndirect(this SharpVk.CommandBuffer extendedHandle, ulong scratch, ulong scratchSize, SharpVk.Amdx.DispatchGraphCountInfo countInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Amdx.DispatchGraphCountInfo* marshalledCountInfo = default(SharpVk.Interop.Amdx.DispatchGraphCountInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledCountInfo = (SharpVk.Interop.Amdx.DispatchGraphCountInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amdx.DispatchGraphCountInfo>());
                countInfo.MarshalTo(marshalledCountInfo);
                SharpVk.Interop.Amdx.VkCommandBufferDispatchGraphIndirectDelegate commandDelegate = commandCache.Cache.vkCmdDispatchGraphIndirectAMDX;
                commandDelegate(extendedHandle.handle, scratch, scratchSize, marshalledCountInfo);
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
        /// <param name="scratch">
        /// </param>
        /// <param name="scratchSize">
        /// </param>
        /// <param name="countInfo">
        /// </param>
        public static unsafe void DispatchGraphIndirectCount(this SharpVk.CommandBuffer extendedHandle, ulong scratch, ulong scratchSize, ulong countInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Amdx.VkCommandBufferDispatchGraphIndirectCountDelegate commandDelegate = commandCache.Cache.vkCmdDispatchGraphIndirectCountAMDX;
                commandDelegate(extendedHandle.handle, scratch, scratchSize, countInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
