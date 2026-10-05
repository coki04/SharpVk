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
    public partial struct StdVideoH265SubLayerHrdParameters
    {
        /// <summary>
        /// 
        /// </summary>
        public uint[] BitRateValueMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] CpbSizeValueMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] CpbSizeDuValueMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] BitRateDuValueMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint CbrFlag
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoH265SubLayerHrdParameters* pointer)
        {
            Interop.HeapUtil.MarshalTo(this.BitRateValueMinus1, checked((int)Constants.StdVideoH265CpbCntListSize), pointer->BitRateValueMinus1);
            Interop.HeapUtil.MarshalTo(this.CpbSizeValueMinus1, checked((int)Constants.StdVideoH265CpbCntListSize), pointer->CpbSizeValueMinus1);
            Interop.HeapUtil.MarshalTo(this.CpbSizeDuValueMinus1, checked((int)Constants.StdVideoH265CpbCntListSize), pointer->CpbSizeDuValueMinus1);
            Interop.HeapUtil.MarshalTo(this.BitRateDuValueMinus1, checked((int)Constants.StdVideoH265CpbCntListSize), pointer->BitRateDuValueMinus1);
            pointer->CbrFlag = this.CbrFlag;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoH265SubLayerHrdParameters MarshalFrom(SharpVk.Interop.StdVideoH265SubLayerHrdParameters* pointer)
        {
            StdVideoH265SubLayerHrdParameters result = default(StdVideoH265SubLayerHrdParameters);
            result.BitRateValueMinus1 = Interop.HeapUtil.MarshalFrom(pointer->BitRateValueMinus1, checked((int)Constants.StdVideoH265CpbCntListSize));
            result.CpbSizeValueMinus1 = Interop.HeapUtil.MarshalFrom(pointer->CpbSizeValueMinus1, checked((int)Constants.StdVideoH265CpbCntListSize));
            result.CpbSizeDuValueMinus1 = Interop.HeapUtil.MarshalFrom(pointer->CpbSizeDuValueMinus1, checked((int)Constants.StdVideoH265CpbCntListSize));
            result.BitRateDuValueMinus1 = Interop.HeapUtil.MarshalFrom(pointer->BitRateDuValueMinus1, checked((int)Constants.StdVideoH265CpbCntListSize));
            result.CbrFlag = pointer->CbrFlag;
            return result;
        }
    }
}
