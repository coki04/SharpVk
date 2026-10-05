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
    public partial struct StdVideoEncodeH264SliceHeader
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264SliceHeaderFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint FirstMbInSlice
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264SliceType SliceType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte SliceAlphaC0OffsetDiv2
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
        public sbyte SliceQpDelta
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264CabacInitIdc CabacInitIdc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264DisableDeblockingFilterIdc DisableDeblockingFilterIdc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264WeightTable? WeightTable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoEncodeH264SliceHeader* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->FirstMbInSlice = this.FirstMbInSlice;
            pointer->SliceType = this.SliceType;
            pointer->SliceAlphaC0OffsetDiv2 = this.SliceAlphaC0OffsetDiv2;
            pointer->SliceBetaOffsetDiv2 = this.SliceBetaOffsetDiv2;
            pointer->SliceQpDelta = this.SliceQpDelta;
            pointer->Reserved1 = this.Reserved1;
            pointer->CabacInitIdc = this.CabacInitIdc;
            pointer->DisableDeblockingFilterIdc = this.DisableDeblockingFilterIdc;
            if (this.WeightTable != null)
            {
                pointer->WeightTable = (SharpVk.Interop.StdVideoEncodeH264WeightTable*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoEncodeH264WeightTable>());
                this.WeightTable.Value.MarshalTo(pointer->WeightTable);
            }
            else
            {
                pointer->WeightTable = default(SharpVk.Interop.StdVideoEncodeH264WeightTable*);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoEncodeH264SliceHeader MarshalFrom(SharpVk.Interop.StdVideoEncodeH264SliceHeader* pointer)
        {
            StdVideoEncodeH264SliceHeader result = default(StdVideoEncodeH264SliceHeader);
            result.Flags = pointer->Flags;
            result.FirstMbInSlice = pointer->FirstMbInSlice;
            result.SliceType = pointer->SliceType;
            result.SliceAlphaC0OffsetDiv2 = pointer->SliceAlphaC0OffsetDiv2;
            result.SliceBetaOffsetDiv2 = pointer->SliceBetaOffsetDiv2;
            result.SliceQpDelta = pointer->SliceQpDelta;
            result.Reserved1 = pointer->Reserved1;
            result.CabacInitIdc = pointer->CabacInitIdc;
            result.DisableDeblockingFilterIdc = pointer->DisableDeblockingFilterIdc;
            if (pointer->WeightTable != null)
            {
                result.WeightTable = SharpVk.StdVideoEncodeH264WeightTable.MarshalFrom(pointer->WeightTable);
            }
            else
            {
                result.WeightTable = null;
            }
            return result;
        }
    }
}
