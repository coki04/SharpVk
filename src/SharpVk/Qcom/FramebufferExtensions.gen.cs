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

namespace SharpVk.Qcom
{
    /// <summary>
    /// 
    /// </summary>
    public static class FramebufferExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Framebuffer handle to extend.
        /// </param>
        public static unsafe SharpVk.Qcom.TileProperties[] GetTileProperties(this SharpVk.Framebuffer extendedHandle)
        {
            try
            {
                SharpVk.Qcom.TileProperties[] result = default(SharpVk.Qcom.TileProperties[]);
                uint marshalledPropertiesCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Qcom.TileProperties* marshalledProperties = default(SharpVk.Interop.Qcom.TileProperties*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Qcom.VkFramebufferGetTilePropertiesDelegate commandDelegate = commandCache.Cache.vkGetFramebufferTilePropertiesQCOM;
                Result methodResult = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, &marshalledPropertiesCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Qcom.TileProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.TileProperties>((uint)(marshalledPropertiesCount)));
                commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, &marshalledPropertiesCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Qcom.TileProperties[(uint)(marshalledPropertiesCount)];
                    for(int index = 0; index < (uint)(marshalledPropertiesCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Qcom.TileProperties.MarshalFrom(&marshalledProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
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
