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

namespace SharpVk.Qcom
{
    /// <summary>
    /// 
    /// </summary>
    public static class QueueExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Queue handle to extend.
        /// </param>
        /// <param name="perfHintInfo">
        /// </param>
        public static unsafe void SetPerfHint(this SharpVk.Queue extendedHandle, SharpVk.Qcom.PerfHintInfo perfHintInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Qcom.PerfHintInfo* marshalledPerfHintInfo = default(SharpVk.Interop.Qcom.PerfHintInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledPerfHintInfo = (SharpVk.Interop.Qcom.PerfHintInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PerfHintInfo>());
                perfHintInfo.MarshalTo(marshalledPerfHintInfo);
                SharpVk.Interop.Qcom.VkQueueSetPerfHintDelegate commandDelegate = commandCache.Cache.vkQueueSetPerfHintQCOM;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledPerfHintInfo);
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
