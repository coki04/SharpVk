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
    public static class DeviceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="renderingInfo">
        /// </param>
        public static unsafe SharpVk.Qcom.TileProperties GetDynamicRenderingTileProperties(this SharpVk.Device extendedHandle, SharpVk.RenderingInfo renderingInfo)
        {
            try
            {
                SharpVk.Qcom.TileProperties result = default(SharpVk.Qcom.TileProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.RenderingInfo* marshalledRenderingInfo = default(SharpVk.Interop.RenderingInfo*);
                SharpVk.Interop.Qcom.TileProperties marshalledProperties = default(SharpVk.Interop.Qcom.TileProperties);
                commandCache = extendedHandle.commandCache;
                marshalledRenderingInfo = (SharpVk.Interop.RenderingInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderingInfo>());
                renderingInfo.MarshalTo(marshalledRenderingInfo);
                SharpVk.Interop.Qcom.VkDeviceGetDynamicRenderingTilePropertiesDelegate commandDelegate = commandCache.Cache.vkGetDynamicRenderingTilePropertiesQCOM;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledRenderingInfo, &marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Qcom.TileProperties.MarshalFrom(&marshalledProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
