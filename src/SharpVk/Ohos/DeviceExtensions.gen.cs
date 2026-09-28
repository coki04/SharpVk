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

namespace SharpVk.Ohos
{
    /// <summary>
    /// 
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="buffer">
        /// </param>
        public static unsafe SharpVk.Ohos.NativeBufferProperties GetNativeBufferProperties(this SharpVk.Device extendedHandle, IntPtr buffer)
        {
            try
            {
                SharpVk.Ohos.NativeBufferProperties result = default(SharpVk.Ohos.NativeBufferProperties);
                CommandCache commandCache = default(CommandCache);
                IntPtr* marshalledBuffer = default(IntPtr*);
                SharpVk.Interop.Ohos.NativeBufferProperties marshalledProperties = default(SharpVk.Interop.Ohos.NativeBufferProperties);
                commandCache = extendedHandle.commandCache;
                marshalledBuffer = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledBuffer = buffer;
                SharpVk.Interop.Ohos.VkDeviceGetNativeBufferPropertiesDelegate commandDelegate = commandCache.Cache.vkGetNativeBufferPropertiesOHOS;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledBuffer, &marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Ohos.NativeBufferProperties.MarshalFrom(&marshalledProperties);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        /// <param name="buffer">
        /// </param>
        public static unsafe void GetMemoryNativeBuffer(this SharpVk.Device extendedHandle, SharpVk.Ohos.MemoryGetNativeBufferInfo info, IntPtr buffer)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Ohos.MemoryGetNativeBufferInfo* marshalledInfo = default(SharpVk.Interop.Ohos.MemoryGetNativeBufferInfo*);
                IntPtr* marshalledBuffer = default(IntPtr*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Ohos.MemoryGetNativeBufferInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Ohos.MemoryGetNativeBufferInfo>());
                info.MarshalTo(marshalledInfo);
                marshalledBuffer = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledBuffer = buffer;
                SharpVk.Interop.Ohos.VkDeviceGetMemoryNativeBufferDelegate commandDelegate = commandCache.Cache.vkGetMemoryNativeBufferOHOS;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledInfo, marshalledBuffer);
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
    }
}
