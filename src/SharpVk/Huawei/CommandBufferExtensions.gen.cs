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

namespace SharpVk.Huawei
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
        public static unsafe void SubpassShading(this SharpVk.CommandBuffer extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Huawei.VkCommandBufferSubpassShadingDelegate commandDelegate = commandCache.Cache.vkCmdSubpassShadingHUAWEI;
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
        /// <param name="imageView">
        /// </param>
        /// <param name="imageLayout">
        /// </param>
        public static unsafe void BindInvocationMask(this SharpVk.CommandBuffer extendedHandle, SharpVk.ImageView imageView, SharpVk.ImageLayout imageLayout)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Huawei.VkCommandBufferBindInvocationMaskDelegate commandDelegate = commandCache.Cache.vkCmdBindInvocationMaskHUAWEI;
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
        /// <param name="groupCountX">
        /// </param>
        /// <param name="groupCountY">
        /// </param>
        /// <param name="groupCountZ">
        /// </param>
        public static unsafe void DrawCluster(this SharpVk.CommandBuffer extendedHandle, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Huawei.VkCommandBufferDrawClusterDelegate commandDelegate = commandCache.Cache.vkCmdDrawClusterHUAWEI;
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
        public static unsafe void DrawClusterIndirect(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer buffer, ulong offset)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Huawei.VkCommandBufferDrawClusterIndirectDelegate commandDelegate = commandCache.Cache.vkCmdDrawClusterIndirectHUAWEI;
                commandDelegate(extendedHandle.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
