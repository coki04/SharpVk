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
    public partial struct RenderingInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.RenderingFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Rect2D RenderArea
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint LayerCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ViewMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.RenderingAttachmentInfo[] ColorAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.RenderingAttachmentInfo? DepthAttachment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.RenderingAttachmentInfo? StencilAttachment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.RenderingInfo* pointer)
        {
            pointer->SType = StructureType.RenderingInfoGraphics;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.RenderingFlags);
            }
            pointer->RenderArea = this.RenderArea;
            pointer->LayerCount = this.LayerCount;
            pointer->ViewMask = this.ViewMask;
            pointer->ColorAttachmentCount = (uint)(Interop.HeapUtil.GetLength(this.ColorAttachments));
            if (this.ColorAttachments != null)
            {
                var fieldPointer = (SharpVk.Interop.RenderingAttachmentInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.RenderingAttachmentInfo>(this.ColorAttachments.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ColorAttachments.Length); index++)
                {
                    this.ColorAttachments[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ColorAttachments = fieldPointer;
            }
            else
            {
                pointer->ColorAttachments = null;
            }
            if (this.DepthAttachment != null)
            {
                pointer->DepthAttachment = (SharpVk.Interop.RenderingAttachmentInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderingAttachmentInfo>());
                this.DepthAttachment.Value.MarshalTo(pointer->DepthAttachment);
            }
            else
            {
                pointer->DepthAttachment = default(SharpVk.Interop.RenderingAttachmentInfo*);
            }
            if (this.StencilAttachment != null)
            {
                pointer->StencilAttachment = (SharpVk.Interop.RenderingAttachmentInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderingAttachmentInfo>());
                this.StencilAttachment.Value.MarshalTo(pointer->StencilAttachment);
            }
            else
            {
                pointer->StencilAttachment = default(SharpVk.Interop.RenderingAttachmentInfo*);
            }
        }
    }
}
