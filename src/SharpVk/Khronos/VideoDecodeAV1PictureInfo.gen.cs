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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VideoDecodeAV1PictureInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public IntPtr StdPictureInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int[] ReferenceNameSlotIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint FrameHeaderOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] TileOffsets
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] TileSizes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.VideoDecodeAV1PictureInfo* pointer)
        {
            pointer->SType = StructureType.VideoDecodeAv1PictureInfo;
            pointer->Next = null;
            pointer->StdPictureInfo = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
            *pointer->StdPictureInfo = this.StdPictureInfo;
            Interop.HeapUtil.MarshalTo(this.ReferenceNameSlotIndices, checked((int)Constants.MaxVideoAv1ReferencesPerFrame), pointer->ReferenceNameSlotIndices);
            pointer->FrameHeaderOffset = this.FrameHeaderOffset;
            pointer->TileCount = (uint)(Interop.HeapUtil.GetLength(this.TileOffsets));
            if (this.TileOffsets != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.TileOffsets.Length).ToPointer());
                for(int index = 0; index < (uint)(this.TileOffsets.Length); index++)
                {
                    fieldPointer[index] = this.TileOffsets[index];
                }
                pointer->TileOffsets = fieldPointer;
            }
            else
            {
                pointer->TileOffsets = null;
            }
            if (this.TileSizes != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.TileSizes.Length).ToPointer());
                for(int index = 0; index < (uint)(this.TileSizes.Length); index++)
                {
                    fieldPointer[index] = this.TileSizes[index];
                }
                pointer->TileSizes = fieldPointer;
            }
            else
            {
                pointer->TileSizes = null;
            }
        }
    }
}
