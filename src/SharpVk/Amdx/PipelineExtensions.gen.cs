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

namespace SharpVk.Amdx
{
    /// <summary>
    /// 
    /// </summary>
    public static class PipelineExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Pipeline handle to extend.
        /// </param>
        public static unsafe SharpVk.Amdx.ExecutionGraphPipelineScratchSize GetExecutionGraphPipelineScratchSize(this SharpVk.Pipeline extendedHandle)
        {
            try
            {
                SharpVk.Amdx.ExecutionGraphPipelineScratchSize result = default(SharpVk.Amdx.ExecutionGraphPipelineScratchSize);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Amdx.ExecutionGraphPipelineScratchSize marshalledSizeInfo = default(SharpVk.Interop.Amdx.ExecutionGraphPipelineScratchSize);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Amdx.VkPipelineGetExecutionGraphPipelineScratchSizeDelegate commandDelegate = commandCache.Cache.vkGetExecutionGraphPipelineScratchSizeAMDX;
                Result methodResult = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, &marshalledSizeInfo);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Amdx.ExecutionGraphPipelineScratchSize.MarshalFrom(&marshalledSizeInfo);
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
        /// The Pipeline handle to extend.
        /// </param>
        /// <param name="nodeInfo">
        /// </param>
        public static unsafe uint GetExecutionGraphPipelineNodeIndex(this SharpVk.Pipeline extendedHandle, SharpVk.Amdx.PipelineShaderStageNodeCreateInfo nodeInfo)
        {
            try
            {
                uint result = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Amdx.PipelineShaderStageNodeCreateInfo* marshalledNodeInfo = default(SharpVk.Interop.Amdx.PipelineShaderStageNodeCreateInfo*);
                uint marshalledNodeIndex = default(uint);
                commandCache = extendedHandle.commandCache;
                marshalledNodeInfo = (SharpVk.Interop.Amdx.PipelineShaderStageNodeCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amdx.PipelineShaderStageNodeCreateInfo>());
                nodeInfo.MarshalTo(marshalledNodeInfo);
                SharpVk.Interop.Amdx.VkPipelineGetExecutionGraphPipelineNodeIndexDelegate commandDelegate = commandCache.Cache.vkGetExecutionGraphPipelineNodeIndexAMDX;
                Result methodResult = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, marshalledNodeInfo, &marshalledNodeIndex);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledNodeIndex;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
