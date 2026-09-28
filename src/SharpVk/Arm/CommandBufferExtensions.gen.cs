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
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="dispatchParameters">
        /// </param>
        public static unsafe void SetDispatchParameters(this SharpVk.CommandBuffer extendedHandle, SharpVk.Arm.DispatchParameters dispatchParameters)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.DispatchParameters* marshalledDispatchParameters = default(SharpVk.Interop.Arm.DispatchParameters*);
                commandCache = extendedHandle.commandCache;
                marshalledDispatchParameters = (SharpVk.Interop.Arm.DispatchParameters*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DispatchParameters>());
                dispatchParameters.MarshalTo(marshalledDispatchParameters);
                SharpVk.Interop.Arm.VkCommandBufferSetDispatchParametersDelegate commandDelegate = commandCache.Cache.vkCmdSetDispatchParametersARM;
                commandDelegate(extendedHandle.handle, marshalledDispatchParameters);
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
        /// <param name="dataGraphPipelineOpticalFlowDispatchInfoArm">
        /// Extension struct
        /// </param>
        public static unsafe void DispatchDataGraph(this SharpVk.CommandBuffer extendedHandle, SharpVk.Arm.DataGraphPipelineSession session, SharpVk.Arm.DataGraphPipelineDispatchFlags? flags = default(SharpVk.Arm.DataGraphPipelineDispatchFlags?), SharpVk.Arm.DataGraphPipelineOpticalFlowDispatchInfo? dataGraphPipelineOpticalFlowDispatchInfoArm = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.DataGraphPipelineDispatchInfo* marshalledInfo = default(SharpVk.Interop.Arm.DataGraphPipelineDispatchInfo*);
                void* vkDataGraphPipelineDispatchInfoARMNextPointer = default(void*);
                if (dataGraphPipelineOpticalFlowDispatchInfoArm != null)
                {
                    SharpVk.Interop.Arm.DataGraphPipelineOpticalFlowDispatchInfo* extensionPointer = default(SharpVk.Interop.Arm.DataGraphPipelineOpticalFlowDispatchInfo*);
                    extensionPointer = (SharpVk.Interop.Arm.DataGraphPipelineOpticalFlowDispatchInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphPipelineOpticalFlowDispatchInfo>());
                    dataGraphPipelineOpticalFlowDispatchInfoArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDataGraphPipelineDispatchInfoARMNextPointer;
                    vkDataGraphPipelineDispatchInfoARMNextPointer = extensionPointer;
                }
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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="instrumentation">
        /// </param>
        public static unsafe void BeginShaderInstrumentation(this SharpVk.CommandBuffer extendedHandle, SharpVk.Arm.ShaderInstrumentation instrumentation)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Arm.VkCommandBufferBeginShaderInstrumentationDelegate commandDelegate = commandCache.Cache.vkCmdBeginShaderInstrumentationARM;
                commandDelegate(extendedHandle.handle, instrumentation?.handle ?? default(SharpVk.Interop.Arm.ShaderInstrumentation));
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
        public static unsafe void EndShaderInstrumentation(this SharpVk.CommandBuffer extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Arm.VkCommandBufferEndShaderInstrumentationDelegate commandDelegate = commandCache.Cache.vkCmdEndShaderInstrumentationARM;
                commandDelegate(extendedHandle.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
