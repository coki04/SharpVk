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
    public partial struct StdVideoEncodeH265SliceSegmentHeader
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH265SliceSegmentHeaderFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265SliceType SliceType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SliceSegmentAddress
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte CollocatedRefIdx
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxNumMergeCand
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte SliceCbQpOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte SliceCrQpOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte SliceBetaOffsetDiv2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte SliceTcOffsetDiv2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte SliceActYQpOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte SliceActCbQpOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte SliceActCrQpOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte SliceQpDelta
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH265WeightTable? WeightTable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoEncodeH265SliceSegmentHeader* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->SliceType = this.SliceType;
            pointer->SliceSegmentAddress = this.SliceSegmentAddress;
            pointer->CollocatedRefIdx = this.CollocatedRefIdx;
            pointer->MaxNumMergeCand = this.MaxNumMergeCand;
            pointer->SliceCbQpOffset = this.SliceCbQpOffset;
            pointer->SliceCrQpOffset = this.SliceCrQpOffset;
            pointer->SliceBetaOffsetDiv2 = this.SliceBetaOffsetDiv2;
            pointer->SliceTcOffsetDiv2 = this.SliceTcOffsetDiv2;
            pointer->SliceActYQpOffset = this.SliceActYQpOffset;
            pointer->SliceActCbQpOffset = this.SliceActCbQpOffset;
            pointer->SliceActCrQpOffset = this.SliceActCrQpOffset;
            pointer->SliceQpDelta = this.SliceQpDelta;
            pointer->Reserved1 = this.Reserved1;
            if (this.WeightTable != null)
            {
                pointer->WeightTable = (SharpVk.Interop.StdVideoEncodeH265WeightTable*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoEncodeH265WeightTable>());
                this.WeightTable.Value.MarshalTo(pointer->WeightTable);
            }
            else
            {
                pointer->WeightTable = default(SharpVk.Interop.StdVideoEncodeH265WeightTable*);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoEncodeH265SliceSegmentHeader MarshalFrom(SharpVk.Interop.StdVideoEncodeH265SliceSegmentHeader* pointer)
        {
            StdVideoEncodeH265SliceSegmentHeader result = default(StdVideoEncodeH265SliceSegmentHeader);
            result.Flags = pointer->Flags;
            result.SliceType = pointer->SliceType;
            result.SliceSegmentAddress = pointer->SliceSegmentAddress;
            result.CollocatedRefIdx = pointer->CollocatedRefIdx;
            result.MaxNumMergeCand = pointer->MaxNumMergeCand;
            result.SliceCbQpOffset = pointer->SliceCbQpOffset;
            result.SliceCrQpOffset = pointer->SliceCrQpOffset;
            result.SliceBetaOffsetDiv2 = pointer->SliceBetaOffsetDiv2;
            result.SliceTcOffsetDiv2 = pointer->SliceTcOffsetDiv2;
            result.SliceActYQpOffset = pointer->SliceActYQpOffset;
            result.SliceActCbQpOffset = pointer->SliceActCbQpOffset;
            result.SliceActCrQpOffset = pointer->SliceActCrQpOffset;
            result.SliceQpDelta = pointer->SliceQpDelta;
            result.Reserved1 = pointer->Reserved1;
            if (pointer->WeightTable != null)
            {
                result.WeightTable = SharpVk.StdVideoEncodeH265WeightTable.MarshalFrom(pointer->WeightTable);
            }
            else
            {
                result.WeightTable = null;
            }
            return result;
        }
    }
}
