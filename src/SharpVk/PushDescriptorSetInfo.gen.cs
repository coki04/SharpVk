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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PushDescriptorSetInfo
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
        public uint? Set
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.WriteDescriptorSet[] DescriptorWrites
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.PushDescriptorSetInfo* pointer)
        {
            pointer->SType = StructureType.PushDescriptorSetInfoVersion;
            pointer->Next = null;
            pointer->StageFlags = this.StageFlags;
            pointer->Layout = this.Layout?.handle ?? default(SharpVk.Interop.PipelineLayout);
            if (this.Set != null)
            {
                pointer->Set = this.Set.Value;
            }
            else
            {
                pointer->Set = default(uint);
            }
            pointer->DescriptorWriteCount = (uint)(Interop.HeapUtil.GetLength(this.DescriptorWrites));
            if (this.DescriptorWrites != null)
            {
                var fieldPointer = (SharpVk.Interop.WriteDescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.WriteDescriptorSet>(this.DescriptorWrites.Length).ToPointer());
                for(int index = 0; index < (uint)(this.DescriptorWrites.Length); index++)
                {
                    this.DescriptorWrites[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->DescriptorWrites = fieldPointer;
            }
            else
            {
                pointer->DescriptorWrites = null;
            }
        }
    }
}
