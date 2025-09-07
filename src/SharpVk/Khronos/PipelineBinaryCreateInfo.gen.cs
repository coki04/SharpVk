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
using System.Runtime.InteropServices;

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PipelineBinaryCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.PipelineBinaryKeysAndData? KeysAndDataInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Pipeline Pipeline
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.PipelineCreateInfo? PipelineCreateInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.PipelineBinaryCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineBinaryCreateInfo;
            pointer->Next = null;
            if (this.KeysAndDataInfo != null)
            {
                pointer->KeysAndDataInfo = (SharpVk.Interop.Khronos.PipelineBinaryKeysAndData*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineBinaryKeysAndData>());
                this.KeysAndDataInfo.Value.MarshalTo(pointer->KeysAndDataInfo);
            }
            else
            {
                pointer->KeysAndDataInfo = default(SharpVk.Interop.Khronos.PipelineBinaryKeysAndData*);
            }
            pointer->Pipeline = this.Pipeline?.handle ?? default(SharpVk.Interop.Pipeline);
            if (this.PipelineCreateInfo != null)
            {
                pointer->PipelineCreateInfo = (SharpVk.Interop.Khronos.PipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineCreateInfo>());
                this.PipelineCreateInfo.Value.MarshalTo(pointer->PipelineCreateInfo);
            }
            else
            {
                pointer->PipelineCreateInfo = default(SharpVk.Interop.Khronos.PipelineCreateInfo*);
            }
        }
    }
}
