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
    public partial struct StdVideoEncodeH264WeightTable
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264WeightTableFlags Flags
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
        public byte ChromaLog2WeightDenom
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] LumaWeightL0
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
        public sbyte[] ChromaWeightL0
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] ChromaOffsetL0
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] LumaWeightL1
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
        public sbyte[] ChromaWeightL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] ChromaOffsetL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoEncodeH264WeightTable* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->LumaLog2WeightDenom = this.LumaLog2WeightDenom;
            pointer->ChromaLog2WeightDenom = this.ChromaLog2WeightDenom;
            Interop.HeapUtil.MarshalTo(this.LumaWeightL0, checked((int)Constants.StdVideoH264MaxNumListRef), pointer->LumaWeightL0);
            Interop.HeapUtil.MarshalTo(this.LumaOffsetL0, checked((int)Constants.StdVideoH264MaxNumListRef), pointer->LumaOffsetL0);
            Interop.HeapUtil.MarshalTo(this.ChromaWeightL0, checked((int)Constants.StdVideoH264MaxNumListRef), pointer->ChromaWeightL0);
            Interop.HeapUtil.MarshalTo(this.ChromaOffsetL0, checked((int)Constants.StdVideoH264MaxNumListRef), pointer->ChromaOffsetL0);
            Interop.HeapUtil.MarshalTo(this.LumaWeightL1, checked((int)Constants.StdVideoH264MaxNumListRef), pointer->LumaWeightL1);
            Interop.HeapUtil.MarshalTo(this.LumaOffsetL1, checked((int)Constants.StdVideoH264MaxNumListRef), pointer->LumaOffsetL1);
            Interop.HeapUtil.MarshalTo(this.ChromaWeightL1, checked((int)Constants.StdVideoH264MaxNumListRef), pointer->ChromaWeightL1);
            Interop.HeapUtil.MarshalTo(this.ChromaOffsetL1, checked((int)Constants.StdVideoH264MaxNumListRef), pointer->ChromaOffsetL1);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoEncodeH264WeightTable MarshalFrom(SharpVk.Interop.StdVideoEncodeH264WeightTable* pointer)
        {
            StdVideoEncodeH264WeightTable result = default(StdVideoEncodeH264WeightTable);
            result.Flags = pointer->Flags;
            result.LumaLog2WeightDenom = pointer->LumaLog2WeightDenom;
            result.ChromaLog2WeightDenom = pointer->ChromaLog2WeightDenom;
            result.LumaWeightL0 = Interop.HeapUtil.MarshalFrom(pointer->LumaWeightL0, checked((int)Constants.StdVideoH264MaxNumListRef));
            result.LumaOffsetL0 = Interop.HeapUtil.MarshalFrom(pointer->LumaOffsetL0, checked((int)Constants.StdVideoH264MaxNumListRef));
            result.ChromaWeightL0 = Interop.HeapUtil.MarshalFrom(pointer->ChromaWeightL0, checked((int)Constants.StdVideoH264MaxNumListRef));
            result.ChromaOffsetL0 = Interop.HeapUtil.MarshalFrom(pointer->ChromaOffsetL0, checked((int)Constants.StdVideoH264MaxNumListRef));
            result.LumaWeightL1 = Interop.HeapUtil.MarshalFrom(pointer->LumaWeightL1, checked((int)Constants.StdVideoH264MaxNumListRef));
            result.LumaOffsetL1 = Interop.HeapUtil.MarshalFrom(pointer->LumaOffsetL1, checked((int)Constants.StdVideoH264MaxNumListRef));
            result.ChromaWeightL1 = Interop.HeapUtil.MarshalFrom(pointer->ChromaWeightL1, checked((int)Constants.StdVideoH264MaxNumListRef));
            result.ChromaOffsetL1 = Interop.HeapUtil.MarshalFrom(pointer->ChromaOffsetL1, checked((int)Constants.StdVideoH264MaxNumListRef));
            return result;
        }
    }
}
