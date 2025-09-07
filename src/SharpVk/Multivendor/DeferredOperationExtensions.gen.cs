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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    public static class DeferredOperationExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The DeferredOperation handle to extend.
        /// </param>
        /// <param name="infos">
        /// </param>
        public static unsafe Result BuildMicromaps(this SharpVk.Khronos.DeferredOperation extendedHandle, ArrayProxy<SharpVk.Multivendor.MicromapBuildInfo>? infos)
        {
            try
            {
                Result result = default(Result);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.MicromapBuildInfo* marshalledInfos = default(SharpVk.Interop.Multivendor.MicromapBuildInfo*);
                commandCache = extendedHandle.commandCache;
                if (infos.IsNull())
                {
                    marshalledInfos = null;
                }
                else
                {
                    if (infos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledInfos = (SharpVk.Interop.Multivendor.MicromapBuildInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.MicromapBuildInfo>());
                        infos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.MicromapBuildInfo*)(marshalledInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.MicromapBuildInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.MicromapBuildInfo>(Interop.HeapUtil.GetLength(infos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(infos.Value)); index++)
                        {
                            infos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkDeferredOperationKHRBuildMicromapsDelegate commandDelegate = commandCache.Cache.vkBuildMicromapsEXT;
                result = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(infos)), marshalledInfos);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
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
        /// The DeferredOperation handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe Result CopyMicromap(this SharpVk.Khronos.DeferredOperation extendedHandle, SharpVk.Multivendor.CopyMicromapInfo info)
        {
            try
            {
                Result result = default(Result);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.CopyMicromapInfo* marshalledInfo = default(SharpVk.Interop.Multivendor.CopyMicromapInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Multivendor.CopyMicromapInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.CopyMicromapInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Multivendor.VkDeferredOperationKHRCopyMicromapDelegate commandDelegate = commandCache.Cache.vkCopyMicromapEXT;
                result = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, marshalledInfo);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
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
        /// The DeferredOperation handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe Result CopyMicromapToMemory(this SharpVk.Khronos.DeferredOperation extendedHandle, SharpVk.Multivendor.CopyMicromapToMemoryInfo info)
        {
            try
            {
                Result result = default(Result);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.CopyMicromapToMemoryInfo* marshalledInfo = default(SharpVk.Interop.Multivendor.CopyMicromapToMemoryInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Multivendor.CopyMicromapToMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.CopyMicromapToMemoryInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Multivendor.VkDeferredOperationKHRCopyMicromapToMemoryDelegate commandDelegate = commandCache.Cache.vkCopyMicromapToMemoryEXT;
                result = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, marshalledInfo);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
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
        /// The DeferredOperation handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe Result CopyMemoryToMicromap(this SharpVk.Khronos.DeferredOperation extendedHandle, SharpVk.Multivendor.CopyMemoryToMicromapInfo info)
        {
            try
            {
                Result result = default(Result);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.CopyMemoryToMicromapInfo* marshalledInfo = default(SharpVk.Interop.Multivendor.CopyMemoryToMicromapInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Multivendor.CopyMemoryToMicromapInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.CopyMemoryToMicromapInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Multivendor.VkDeferredOperationKHRCopyMemoryToMicromapDelegate commandDelegate = commandCache.Cache.vkCopyMemoryToMicromapEXT;
                result = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, marshalledInfo);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
