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
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct BindDescriptorSetsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderStageFlags StageFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineLayout Layout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? FirstSet
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.DescriptorSet[] DescriptorSets
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] DynamicOffsets
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.BindDescriptorSetsInfo* pointer)
        {
            pointer->SType = StructureType.BindDescriptorSetsInfoCompute;
            pointer->Next = null;
            pointer->StageFlags = this.StageFlags;
            pointer->Layout = this.Layout?.handle ?? default(SharpVk.Interop.PipelineLayout);
            if (this.FirstSet != null)
            {
                pointer->FirstSet = this.FirstSet.Value;
            }
            else
            {
                pointer->FirstSet = default(uint);
            }
            pointer->DescriptorSetCount = (uint)(Interop.HeapUtil.GetLength(this.DescriptorSets));
            if (this.DescriptorSets != null)
            {
                var fieldPointer = (SharpVk.Interop.DescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSet>(this.DescriptorSets.Length).ToPointer());
                for(int index = 0; index < (uint)(this.DescriptorSets.Length); index++)
                {
                    fieldPointer[index] = this.DescriptorSets[index]?.handle ?? default(SharpVk.Interop.DescriptorSet);
                }
                pointer->DescriptorSets = fieldPointer;
            }
            else
            {
                pointer->DescriptorSets = null;
            }
            pointer->DynamicOffsetCount = (uint)(Interop.HeapUtil.GetLength(this.DynamicOffsets));
            if (this.DynamicOffsets != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.DynamicOffsets.Length).ToPointer());
                for(int index = 0; index < (uint)(this.DynamicOffsets.Length); index++)
                {
                    fieldPointer[index] = this.DynamicOffsets[index];
                }
                pointer->DynamicOffsets = fieldPointer;
            }
            else
            {
                pointer->DynamicOffsets = null;
            }
        }
    }
}
