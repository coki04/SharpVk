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

namespace SharpVk.Arm
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
        /// <param name="copyTensorInfo">
        /// </param>
        public static unsafe void CopyTensor(this SharpVk.CommandBuffer extendedHandle, SharpVk.Arm.CopyTensorInfo copyTensorInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.CopyTensorInfo* marshalledCopyTensorInfo = default(SharpVk.Interop.Arm.CopyTensorInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledCopyTensorInfo = (SharpVk.Interop.Arm.CopyTensorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.CopyTensorInfo>());
                copyTensorInfo.MarshalTo(marshalledCopyTensorInfo);
                SharpVk.Interop.Arm.VkCommandBufferCopyTensorDelegate commandDelegate = commandCache.Cache.vkCmdCopyTensorARM;
                commandDelegate(extendedHandle.handle, marshalledCopyTensorInfo);
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
        /// <param name="flags">
        /// </param>
        public static unsafe void DispatchDataGraph(this SharpVk.CommandBuffer extendedHandle, SharpVk.Arm.DataGraphPipelineSession session, SharpVk.Arm.DataGraphPipelineDispatchFlags? flags = default(SharpVk.Arm.DataGraphPipelineDispatchFlags?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.DataGraphPipelineDispatchInfo* marshalledInfo = default(SharpVk.Interop.Arm.DataGraphPipelineDispatchInfo*);
                void* vkDataGraphPipelineDispatchInfoARMNextPointer = default(void*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Arm.DataGraphPipelineDispatchInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineDispatchInfo>());
                marshalledInfo->SType = StructureType.DataGraphPipelineDispatchInfo;
                marshalledInfo->Next = vkDataGraphPipelineDispatchInfoARMNextPointer;
                if (flags != null)
                {
                    marshalledInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledInfo->Flags = default(SharpVk.Arm.DataGraphPipelineDispatchFlags);
                }
                SharpVk.Interop.Arm.VkCommandBufferDispatchDataGraphDelegate commandDelegate = commandCache.Cache.vkCmdDispatchDataGraphARM;
                commandDelegate(extendedHandle.handle, session?.handle ?? default(SharpVk.Interop.Arm.DataGraphPipelineSession), marshalledInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
