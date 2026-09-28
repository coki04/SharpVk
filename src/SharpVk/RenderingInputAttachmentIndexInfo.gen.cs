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
    public partial struct RenderingInputAttachmentIndexInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public uint[] ColorAttachmentInputIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? DepthInputAttachmentIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? StencilInputAttachmentIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.RenderingInputAttachmentIndexInfo* pointer)
        {
            pointer->SType = StructureType.RenderingInputAttachmentIndexInfoGraphics;
            pointer->Next = null;
            pointer->ColorAttachmentCount = (uint)(Interop.HeapUtil.GetLength(this.ColorAttachmentInputIndices));
            if (this.ColorAttachmentInputIndices != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.ColorAttachmentInputIndices.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ColorAttachmentInputIndices.Length); index++)
                {
                    fieldPointer[index] = this.ColorAttachmentInputIndices[index];
                }
                pointer->ColorAttachmentInputIndices = fieldPointer;
            }
            else
            {
                pointer->ColorAttachmentInputIndices = null;
            }
            if (this.DepthInputAttachmentIndex != null)
            {
                pointer->DepthInputAttachmentIndex = (uint*)(Interop.HeapUtil.Allocate<uint>());
                *pointer->DepthInputAttachmentIndex = this.DepthInputAttachmentIndex.Value;
            }
            else
            {
                pointer->DepthInputAttachmentIndex = default(uint*);
            }
            if (this.StencilInputAttachmentIndex != null)
            {
                pointer->StencilInputAttachmentIndex = (uint*)(Interop.HeapUtil.Allocate<uint>());
                *pointer->StencilInputAttachmentIndex = this.StencilInputAttachmentIndex.Value;
            }
            else
            {
                pointer->StencilInputAttachmentIndex = default(uint*);
            }
        }
    }
}
