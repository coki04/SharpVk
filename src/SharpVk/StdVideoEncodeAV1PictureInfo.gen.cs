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
    public partial struct StdVideoEncodeAV1PictureInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeAV1PictureInfoFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1FrameType FrameType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint FramePresentationTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint CurrentFrameId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte OrderHint
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte PrimaryRefFrame
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
        public byte CodedDenom
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort RenderWidthMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort RenderHeightMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1InterpolationFilter InterpolationFilter
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1TxMode TxMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte DeltaQRes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte DeltaLfRes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] RefOrderHint
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] RefFrameIdx
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (byte, byte, byte) Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] DeltaFrameIdMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1TileInfo? TileInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1Quantization Quantization
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1Segmentation? Segmentation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1LoopFilter LoopFilter
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1CDEF? CDEF
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1LoopRestoration? LoopRestoration
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1GlobalMotion GlobalMotion
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeAV1ExtensionHeader? ExtensionHeader
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? BufferRemovalTimes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoEncodeAV1PictureInfo* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->FrameType = this.FrameType;
            pointer->FramePresentationTime = this.FramePresentationTime;
            pointer->CurrentFrameId = this.CurrentFrameId;
            pointer->OrderHint = this.OrderHint;
            pointer->PrimaryRefFrame = this.PrimaryRefFrame;
            pointer->RefreshFrameFlags = this.RefreshFrameFlags;
            pointer->CodedDenom = this.CodedDenom;
            pointer->RenderWidthMinus1 = this.RenderWidthMinus1;
            pointer->RenderHeightMinus1 = this.RenderHeightMinus1;
            pointer->InterpolationFilter = this.InterpolationFilter;
            pointer->TxMode = this.TxMode;
            pointer->DeltaQRes = this.DeltaQRes;
            pointer->DeltaLfRes = this.DeltaLfRes;
            Interop.HeapUtil.MarshalTo(this.RefOrderHint, checked((int)Constants.StdVideoAv1NumRefFrames), pointer->RefOrderHint);
            Interop.HeapUtil.MarshalTo(this.RefFrameIdx, checked((int)Constants.StdVideoAv1RefsPerFrame), pointer->RefFrameIdx);
            pointer->Reserved1[0] = this.Reserved1.Item1;
            pointer->Reserved1[1] = this.Reserved1.Item2;
            pointer->Reserved1[2] = this.Reserved1.Item3;
            Interop.HeapUtil.MarshalTo(this.DeltaFrameIdMinus1, checked((int)Constants.StdVideoAv1RefsPerFrame), pointer->DeltaFrameIdMinus1);
            if (this.TileInfo != null)
            {
                pointer->TileInfo = (SharpVk.Interop.StdVideoAV1TileInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoAV1TileInfo>());
                this.TileInfo.Value.MarshalTo(pointer->TileInfo);
            }
            else
            {
                pointer->TileInfo = default(SharpVk.Interop.StdVideoAV1TileInfo*);
            }
            pointer->Quantization = (SharpVk.StdVideoAV1Quantization*)(Interop.HeapUtil.Allocate<SharpVk.StdVideoAV1Quantization>());
            *pointer->Quantization = this.Quantization;
            if (this.Segmentation != null)
            {
                pointer->Segmentation = (SharpVk.Interop.StdVideoAV1Segmentation*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoAV1Segmentation>());
                this.Segmentation.Value.MarshalTo(pointer->Segmentation);
            }
            else
            {
                pointer->Segmentation = default(SharpVk.Interop.StdVideoAV1Segmentation*);
            }
            pointer->LoopFilter = (SharpVk.Interop.StdVideoAV1LoopFilter*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoAV1LoopFilter>());
            this.LoopFilter.MarshalTo(pointer->LoopFilter);
            if (this.CDEF != null)
            {
                pointer->CDEF = (SharpVk.Interop.StdVideoAV1CDEF*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoAV1CDEF>());
                this.CDEF.Value.MarshalTo(pointer->CDEF);
            }
            else
            {
                pointer->CDEF = default(SharpVk.Interop.StdVideoAV1CDEF*);
            }
            if (this.LoopRestoration != null)
            {
                pointer->LoopRestoration = (SharpVk.Interop.StdVideoAV1LoopRestoration*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoAV1LoopRestoration>());
                this.LoopRestoration.Value.MarshalTo(pointer->LoopRestoration);
            }
            else
            {
                pointer->LoopRestoration = default(SharpVk.Interop.StdVideoAV1LoopRestoration*);
            }
            pointer->GlobalMotion = (SharpVk.Interop.StdVideoAV1GlobalMotion*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoAV1GlobalMotion>());
            this.GlobalMotion.MarshalTo(pointer->GlobalMotion);
            if (this.ExtensionHeader != null)
            {
                pointer->ExtensionHeader = (SharpVk.StdVideoEncodeAV1ExtensionHeader*)(Interop.HeapUtil.Allocate<SharpVk.StdVideoEncodeAV1ExtensionHeader>());
                *pointer->ExtensionHeader = this.ExtensionHeader.Value;
            }
            else
            {
                pointer->ExtensionHeader = default(SharpVk.StdVideoEncodeAV1ExtensionHeader*);
            }
            if (this.BufferRemovalTimes != null)
            {
                pointer->BufferRemovalTimes = (uint*)(Interop.HeapUtil.Allocate<uint>());
                *pointer->BufferRemovalTimes = this.BufferRemovalTimes.Value;
            }
            else
            {
                pointer->BufferRemovalTimes = default(uint*);
            }
        }
    }
}
