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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct IndirectExecutionSetShaderInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.Shader[] InitialShaders
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.IndirectExecutionSetShaderLayoutInfo[] SetLayoutInfos
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxShaderCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PushConstantRange[] PushConstantRanges
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.IndirectExecutionSetShaderInfo* pointer)
        {
            pointer->SType = StructureType.IndirectExecutionSetShaderInfo;
            pointer->Next = null;
            pointer->ShaderCount = (uint)(Interop.HeapUtil.GetLength(this.InitialShaders));
            if (this.InitialShaders != null)
            {
                var fieldPointer = (SharpVk.Interop.Multivendor.Shader*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.Shader>(this.InitialShaders.Length).ToPointer());
                for(int index = 0; index < (uint)(this.InitialShaders.Length); index++)
                {
                    fieldPointer[index] = this.InitialShaders[index]?.handle ?? default(SharpVk.Interop.Multivendor.Shader);
                }
                pointer->InitialShaders = fieldPointer;
            }
            else
            {
                pointer->InitialShaders = null;
            }
            if (this.SetLayoutInfos != null)
            {
                var fieldPointer = (SharpVk.Interop.Multivendor.IndirectExecutionSetShaderLayoutInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.IndirectExecutionSetShaderLayoutInfo>(this.SetLayoutInfos.Length).ToPointer());
                for(int index = 0; index < (uint)(this.SetLayoutInfos.Length); index++)
                {
                    this.SetLayoutInfos[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->SetLayoutInfos = fieldPointer;
            }
            else
            {
                pointer->SetLayoutInfos = null;
            }
            pointer->MaxShaderCount = this.MaxShaderCount;
            pointer->PushConstantRangeCount = (uint)(Interop.HeapUtil.GetLength(this.PushConstantRanges));
            if (this.PushConstantRanges != null)
            {
                var fieldPointer = (SharpVk.PushConstantRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.PushConstantRange>(this.PushConstantRanges.Length).ToPointer());
                for(int index = 0; index < (uint)(this.PushConstantRanges.Length); index++)
                {
                    fieldPointer[index] = this.PushConstantRanges[index];
                }
                pointer->PushConstantRanges = fieldPointer;
            }
            else
            {
                pointer->PushConstantRanges = null;
            }
        }
    }
}
