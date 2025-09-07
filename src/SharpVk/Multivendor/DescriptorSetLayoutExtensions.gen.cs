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
    public static class DescriptorSetLayoutExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The DescriptorSetLayout handle to extend.
        /// </param>
        public static unsafe ulong GetSize(this SharpVk.DescriptorSetLayout extendedHandle)
        {
            try
            {
                ulong result = default(ulong);
                CommandCache commandCache = default(CommandCache);
                ulong marshalledLayoutSizeInBytes = default(ulong);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkDescriptorSetLayoutGetSizeDelegate commandDelegate = commandCache.Cache.vkGetDescriptorSetLayoutSizeEXT;
                commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, &marshalledLayoutSizeInBytes);
                result = marshalledLayoutSizeInBytes;
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
        /// The DescriptorSetLayout handle to extend.
        /// </param>
        /// <param name="binding">
        /// </param>
        public static unsafe ulong GetBindingOffset(this SharpVk.DescriptorSetLayout extendedHandle, uint binding)
        {
            try
            {
                ulong result = default(ulong);
                CommandCache commandCache = default(CommandCache);
                ulong marshalledOffset = default(ulong);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkDescriptorSetLayoutGetBindingOffsetDelegate commandDelegate = commandCache.Cache.vkGetDescriptorSetLayoutBindingOffsetEXT;
                commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, binding, &marshalledOffset);
                result = marshalledOffset;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
