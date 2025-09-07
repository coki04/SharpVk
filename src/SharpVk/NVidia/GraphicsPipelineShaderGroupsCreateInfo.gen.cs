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

namespace SharpVk.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GraphicsPipelineShaderGroupsCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.GraphicsShaderGroupCreateInfo[] Groups
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Pipeline[] Pipelines
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.GraphicsPipelineShaderGroupsCreateInfo* pointer)
        {
            pointer->SType = StructureType.GraphicsPipelineShaderGroupsCreateInfo;
            pointer->Next = null;
            pointer->GroupCount = (uint)(Interop.HeapUtil.GetLength(this.Groups));
            if (this.Groups != null)
            {
                var fieldPointer = (SharpVk.Interop.NVidia.GraphicsShaderGroupCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.GraphicsShaderGroupCreateInfo>(this.Groups.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Groups.Length); index++)
                {
                    this.Groups[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Groups = fieldPointer;
            }
            else
            {
                pointer->Groups = null;
            }
            pointer->PipelineCount = (uint)(Interop.HeapUtil.GetLength(this.Pipelines));
            if (this.Pipelines != null)
            {
                var fieldPointer = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Pipeline>(this.Pipelines.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Pipelines.Length); index++)
                {
                    fieldPointer[index] = this.Pipelines[index]?.handle ?? default(SharpVk.Interop.Pipeline);
                }
                pointer->Pipelines = fieldPointer;
            }
            else
            {
                pointer->Pipelines = null;
            }
        }
    }
}
