// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2022
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
    public static class ImageExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Image handle to extend.
        /// </param>
        public static unsafe SharpVk.Multivendor.ImageDrmFormatModifierProperties GetDrmFormatModifierProperties(this SharpVk.Image extendedHandle)
        {
            try
            {
                SharpVk.Multivendor.ImageDrmFormatModifierProperties result = default(SharpVk.Multivendor.ImageDrmFormatModifierProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.ImageDrmFormatModifierProperties marshalledProperties = default(SharpVk.Interop.Multivendor.ImageDrmFormatModifierProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkImageGetDrmFormatModifierPropertiesDelegate commandDelegate = commandCache.Cache.vkGetImageDrmFormatModifierPropertiesEXT;
                Result methodResult = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, &marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Multivendor.ImageDrmFormatModifierProperties.MarshalFrom(&marshalledProperties);
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
        /// The Image handle to extend.
        /// </param>
        /// <param name="subresource">
        /// </param>
        public static unsafe SharpVk.Multivendor.SubresourceLayout2 GetSubresourceLayout2(this SharpVk.Image extendedHandle, SharpVk.Multivendor.ImageSubresource2 subresource)
        {
            try
            {
                SharpVk.Multivendor.SubresourceLayout2 result = default(SharpVk.Multivendor.SubresourceLayout2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.ImageSubresource2* marshalledSubresource = default(SharpVk.Interop.Multivendor.ImageSubresource2*);
                SharpVk.Interop.Multivendor.SubresourceLayout2 marshalledLayout = default(SharpVk.Interop.Multivendor.SubresourceLayout2);
                commandCache = extendedHandle.commandCache;
                marshalledSubresource = (SharpVk.Interop.Multivendor.ImageSubresource2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImageSubresource2>());
                subresource.MarshalTo(marshalledSubresource);
                SharpVk.Interop.Multivendor.VkImageGetSubresourceLayout2Delegate commandDelegate = commandCache.Cache.vkGetImageSubresourceLayout2EXT;
                commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, marshalledSubresource, &marshalledLayout);
                result = SharpVk.Multivendor.SubresourceLayout2.MarshalFrom(&marshalledLayout);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
