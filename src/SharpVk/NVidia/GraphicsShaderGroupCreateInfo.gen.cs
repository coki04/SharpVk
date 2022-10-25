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
using System.Runtime.InteropServices;

namespace SharpVk.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GraphicsShaderGroupCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineShaderStageCreateInfo[] Stages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineVertexInputStateCreateInfo? VertexInputState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineTessellationStateCreateInfo? TessellationState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.GraphicsShaderGroupCreateInfo* pointer)
        {
            pointer->SType = StructureType.GraphicsShaderGroupCreateInfo;
            pointer->Next = null;
            pointer->StageCount = (uint)(Interop.HeapUtil.GetLength(this.Stages));
            if (this.Stages != null)
            {
                var fieldPointer = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.PipelineShaderStageCreateInfo>(this.Stages.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Stages.Length); index++)
                {
                    this.Stages[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Stages = fieldPointer;
            }
            else
            {
                pointer->Stages = null;
            }
            if (this.VertexInputState != null)
            {
                pointer->VertexInputState = (SharpVk.Interop.PipelineVertexInputStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineVertexInputStateCreateInfo>());
                this.VertexInputState.Value.MarshalTo(pointer->VertexInputState);
            }
            else
            {
                pointer->VertexInputState = default(SharpVk.Interop.PipelineVertexInputStateCreateInfo*);
            }
            if (this.TessellationState != null)
            {
                pointer->TessellationState = (SharpVk.Interop.PipelineTessellationStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineTessellationStateCreateInfo>());
                this.TessellationState.Value.MarshalTo(pointer->TessellationState);
            }
            else
            {
                pointer->TessellationState = default(SharpVk.Interop.PipelineTessellationStateCreateInfo*);
            }
        }
    }
}
