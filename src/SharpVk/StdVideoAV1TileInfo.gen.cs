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
    public partial struct StdVideoAV1TileInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1TileInfoFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort ContextUpdateTileId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte TileSizeBytesMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (byte, byte, byte, byte, byte, byte, byte) Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort[] MiColStarts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort[] MiRowStarts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort[] WidthInSbsMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort[] HeightInSbsMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoAV1TileInfo* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->TileCols = (byte)(Interop.HeapUtil.GetLength(this.MiColStarts));
            pointer->TileRows = (byte)(Interop.HeapUtil.GetLength(this.MiRowStarts));
            pointer->ContextUpdateTileId = this.ContextUpdateTileId;
            pointer->TileSizeBytesMinus1 = this.TileSizeBytesMinus1;
            pointer->Reserved1[0] = this.Reserved1.Item1;
            pointer->Reserved1[1] = this.Reserved1.Item2;
            pointer->Reserved1[2] = this.Reserved1.Item3;
            pointer->Reserved1[3] = this.Reserved1.Item4;
            pointer->Reserved1[4] = this.Reserved1.Item5;
            pointer->Reserved1[5] = this.Reserved1.Item6;
            pointer->Reserved1[6] = this.Reserved1.Item7;
            if (this.MiColStarts != null)
            {
                var fieldPointer = (ushort*)(Interop.HeapUtil.AllocateAndClear<ushort>(this.MiColStarts.Length).ToPointer());
                for(int index = 0; index < (uint)(this.MiColStarts.Length); index++)
                {
                    fieldPointer[index] = this.MiColStarts[index];
                }
                pointer->MiColStarts = fieldPointer;
            }
            else
            {
                pointer->MiColStarts = null;
            }
            if (this.MiRowStarts != null)
            {
                var fieldPointer = (ushort*)(Interop.HeapUtil.AllocateAndClear<ushort>(this.MiRowStarts.Length).ToPointer());
                for(int index = 0; index < (uint)(this.MiRowStarts.Length); index++)
                {
                    fieldPointer[index] = this.MiRowStarts[index];
                }
                pointer->MiRowStarts = fieldPointer;
            }
            else
            {
                pointer->MiRowStarts = null;
            }
            if (this.WidthInSbsMinus1 != null)
            {
                var fieldPointer = (ushort*)(Interop.HeapUtil.AllocateAndClear<ushort>(this.WidthInSbsMinus1.Length).ToPointer());
                for(int index = 0; index < (uint)(this.WidthInSbsMinus1.Length); index++)
                {
                    fieldPointer[index] = this.WidthInSbsMinus1[index];
                }
                pointer->WidthInSbsMinus1 = fieldPointer;
            }
            else
            {
                pointer->WidthInSbsMinus1 = null;
            }
            if (this.HeightInSbsMinus1 != null)
            {
                var fieldPointer = (ushort*)(Interop.HeapUtil.AllocateAndClear<ushort>(this.HeightInSbsMinus1.Length).ToPointer());
                for(int index = 0; index < (uint)(this.HeightInSbsMinus1.Length); index++)
                {
                    fieldPointer[index] = this.HeightInSbsMinus1[index];
                }
                pointer->HeightInSbsMinus1 = fieldPointer;
            }
            else
            {
                pointer->HeightInSbsMinus1 = null;
            }
        }
    }
}
