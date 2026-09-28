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

namespace SharpVk.Qcom
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
        /// <param name="dispatchTileInfo">
        /// </param>
        public static unsafe void DispatchTile(this SharpVk.CommandBuffer extendedHandle, SharpVk.Qcom.DispatchTileInfo dispatchTileInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Qcom.DispatchTileInfo* marshalledDispatchTileInfo = default(SharpVk.Interop.Qcom.DispatchTileInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledDispatchTileInfo = (SharpVk.Interop.Qcom.DispatchTileInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.DispatchTileInfo>());
                dispatchTileInfo.MarshalTo(marshalledDispatchTileInfo);
                SharpVk.Interop.Qcom.VkCommandBufferDispatchTileDelegate commandDelegate = commandCache.Cache.vkCmdDispatchTileQCOM;
                commandDelegate(extendedHandle.handle, marshalledDispatchTileInfo);
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
        public static unsafe void BeginPerTileExecution(this SharpVk.CommandBuffer extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Qcom.PerTileBeginInfo* marshalledPerTileBeginInfo = default(SharpVk.Interop.Qcom.PerTileBeginInfo*);
                void* vkPerTileBeginInfoQCOMNextPointer = default(void*);
                commandCache = extendedHandle.commandCache;
                marshalledPerTileBeginInfo = (SharpVk.Interop.Qcom.PerTileBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PerTileBeginInfo>());
                marshalledPerTileBeginInfo->SType = StructureType.PerTileBeginInfo;
                marshalledPerTileBeginInfo->Next = vkPerTileBeginInfoQCOMNextPointer;
                SharpVk.Interop.Qcom.VkCommandBufferBeginPerTileExecutionDelegate commandDelegate = commandCache.Cache.vkCmdBeginPerTileExecutionQCOM;
                commandDelegate(extendedHandle.handle, marshalledPerTileBeginInfo);
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
        public static unsafe void EndPerTileExecution(this SharpVk.CommandBuffer extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Qcom.PerTileEndInfo* marshalledPerTileEndInfo = default(SharpVk.Interop.Qcom.PerTileEndInfo*);
                void* vkPerTileEndInfoQCOMNextPointer = default(void*);
                commandCache = extendedHandle.commandCache;
                marshalledPerTileEndInfo = (SharpVk.Interop.Qcom.PerTileEndInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PerTileEndInfo>());
                marshalledPerTileEndInfo->SType = StructureType.PerTileEndInfo;
                marshalledPerTileEndInfo->Next = vkPerTileEndInfoQCOMNextPointer;
                SharpVk.Interop.Qcom.VkCommandBufferEndPerTileExecutionDelegate commandDelegate = commandCache.Cache.vkCmdEndPerTileExecutionQCOM;
                commandDelegate(extendedHandle.handle, marshalledPerTileEndInfo);
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
        /// <param name="memory">
        /// </param>
        public static unsafe void BindTileMemory(this SharpVk.CommandBuffer extendedHandle, SharpVk.DeviceMemory memory)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Qcom.TileMemoryBindInfo* marshalledTileMemoryBindInfo = default(SharpVk.Interop.Qcom.TileMemoryBindInfo*);
                void* vkTileMemoryBindInfoQCOMNextPointer = default(void*);
                commandCache = extendedHandle.commandCache;
                marshalledTileMemoryBindInfo = (SharpVk.Interop.Qcom.TileMemoryBindInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.TileMemoryBindInfo>());
                marshalledTileMemoryBindInfo->SType = StructureType.TileMemoryBindInfo;
                marshalledTileMemoryBindInfo->Next = vkTileMemoryBindInfoQCOMNextPointer;
                marshalledTileMemoryBindInfo->Memory = memory?.handle ?? default(SharpVk.Interop.DeviceMemory);
                SharpVk.Interop.Qcom.VkCommandBufferBindTileMemoryDelegate commandDelegate = commandCache.Cache.vkCmdBindTileMemoryQCOM;
                commandDelegate(extendedHandle.handle, marshalledTileMemoryBindInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
