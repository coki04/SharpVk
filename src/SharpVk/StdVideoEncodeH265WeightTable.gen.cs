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
    public partial struct StdVideoEncodeH265WeightTable
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH265WeightTableFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte LumaLog2WeightDenom
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte DeltaChromaLog2WeightDenom
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] DeltaLumaWeightL0
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] LumaOffsetL0
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] DeltaChromaWeightL0
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] DeltaChromaOffsetL0
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] DeltaLumaWeightL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] LumaOffsetL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] DeltaChromaWeightL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] DeltaChromaOffsetL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoEncodeH265WeightTable* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->LumaLog2WeightDenom = this.LumaLog2WeightDenom;
            pointer->DeltaChromaLog2WeightDenom = this.DeltaChromaLog2WeightDenom;
            Interop.HeapUtil.MarshalTo(this.DeltaLumaWeightL0, checked((int)Constants.StdVideoH265MaxNumListRef), pointer->DeltaLumaWeightL0);
            Interop.HeapUtil.MarshalTo(this.LumaOffsetL0, checked((int)Constants.StdVideoH265MaxNumListRef), pointer->LumaOffsetL0);
            Interop.HeapUtil.MarshalTo(this.DeltaChromaWeightL0, checked((int)Constants.StdVideoH265MaxNumListRef), pointer->DeltaChromaWeightL0);
            Interop.HeapUtil.MarshalTo(this.DeltaChromaOffsetL0, checked((int)Constants.StdVideoH265MaxNumListRef), pointer->DeltaChromaOffsetL0);
            Interop.HeapUtil.MarshalTo(this.DeltaLumaWeightL1, checked((int)Constants.StdVideoH265MaxNumListRef), pointer->DeltaLumaWeightL1);
            Interop.HeapUtil.MarshalTo(this.LumaOffsetL1, checked((int)Constants.StdVideoH265MaxNumListRef), pointer->LumaOffsetL1);
            Interop.HeapUtil.MarshalTo(this.DeltaChromaWeightL1, checked((int)Constants.StdVideoH265MaxNumListRef), pointer->DeltaChromaWeightL1);
            Interop.HeapUtil.MarshalTo(this.DeltaChromaOffsetL1, checked((int)Constants.StdVideoH265MaxNumListRef), pointer->DeltaChromaOffsetL1);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoEncodeH265WeightTable MarshalFrom(SharpVk.Interop.StdVideoEncodeH265WeightTable* pointer)
        {
            StdVideoEncodeH265WeightTable result = default(StdVideoEncodeH265WeightTable);
            result.Flags = pointer->Flags;
            result.LumaLog2WeightDenom = pointer->LumaLog2WeightDenom;
            result.DeltaChromaLog2WeightDenom = pointer->DeltaChromaLog2WeightDenom;
            result.DeltaLumaWeightL0 = Interop.HeapUtil.MarshalFrom(pointer->DeltaLumaWeightL0, checked((int)Constants.StdVideoH265MaxNumListRef));
            result.LumaOffsetL0 = Interop.HeapUtil.MarshalFrom(pointer->LumaOffsetL0, checked((int)Constants.StdVideoH265MaxNumListRef));
            result.DeltaChromaWeightL0 = Interop.HeapUtil.MarshalFrom(pointer->DeltaChromaWeightL0, checked((int)Constants.StdVideoH265MaxNumListRef));
            result.DeltaChromaOffsetL0 = Interop.HeapUtil.MarshalFrom(pointer->DeltaChromaOffsetL0, checked((int)Constants.StdVideoH265MaxNumListRef));
            result.DeltaLumaWeightL1 = Interop.HeapUtil.MarshalFrom(pointer->DeltaLumaWeightL1, checked((int)Constants.StdVideoH265MaxNumListRef));
            result.LumaOffsetL1 = Interop.HeapUtil.MarshalFrom(pointer->LumaOffsetL1, checked((int)Constants.StdVideoH265MaxNumListRef));
            result.DeltaChromaWeightL1 = Interop.HeapUtil.MarshalFrom(pointer->DeltaChromaWeightL1, checked((int)Constants.StdVideoH265MaxNumListRef));
            result.DeltaChromaOffsetL1 = Interop.HeapUtil.MarshalFrom(pointer->DeltaChromaOffsetL1, checked((int)Constants.StdVideoH265MaxNumListRef));
            return result;
        }
    }
}
