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
    public partial struct StdVideoDecodeVP9PictureInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoDecodeVP9PictureInfoFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoVP9Profile Profile
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoVP9FrameType FrameType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte FrameContextIdx
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte ResetFrameContext
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte RefreshFrameFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte RefFrameSignBiasMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoVP9InterpolationFilter InterpolationFilter
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte BaseQIdx
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte DeltaQYDc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte DeltaQUvDc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte DeltaQUvAc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte TileColsLog2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte TileRowsLog2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (ushort, ushort, ushort) Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoVP9ColorConfig ColorConfig
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoVP9LoopFilter LoopFilter
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoVP9Segmentation? Segmentation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoDecodeVP9PictureInfo* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->Profile = this.Profile;
            pointer->FrameType = this.FrameType;
            pointer->FrameContextIdx = this.FrameContextIdx;
            pointer->ResetFrameContext = this.ResetFrameContext;
            pointer->RefreshFrameFlags = this.RefreshFrameFlags;
            pointer->RefFrameSignBiasMask = this.RefFrameSignBiasMask;
            pointer->InterpolationFilter = this.InterpolationFilter;
            pointer->BaseQIdx = this.BaseQIdx;
            pointer->DeltaQYDc = this.DeltaQYDc;
            pointer->DeltaQUvDc = this.DeltaQUvDc;
            pointer->DeltaQUvAc = this.DeltaQUvAc;
            pointer->TileColsLog2 = this.TileColsLog2;
            pointer->TileRowsLog2 = this.TileRowsLog2;
            pointer->Reserved1[0] = this.Reserved1.Item1;
            pointer->Reserved1[1] = this.Reserved1.Item2;
            pointer->Reserved1[2] = this.Reserved1.Item3;
            pointer->ColorConfig = (SharpVk.StdVideoVP9ColorConfig*)(Interop.HeapUtil.Allocate<SharpVk.StdVideoVP9ColorConfig>());
            *pointer->ColorConfig = this.ColorConfig;
            pointer->LoopFilter = (SharpVk.Interop.StdVideoVP9LoopFilter*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoVP9LoopFilter>());
            this.LoopFilter.MarshalTo(pointer->LoopFilter);
            if (this.Segmentation != null)
            {
                pointer->Segmentation = (SharpVk.Interop.StdVideoVP9Segmentation*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoVP9Segmentation>());
                this.Segmentation.Value.MarshalTo(pointer->Segmentation);
            }
            else
            {
                pointer->Segmentation = default(SharpVk.Interop.StdVideoVP9Segmentation*);
            }
        }
    }
}
