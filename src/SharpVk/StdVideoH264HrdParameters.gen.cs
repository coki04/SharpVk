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
    public partial struct StdVideoH264HrdParameters
    {
        /// <summary>
        /// 
        /// </summary>
        public byte CpbCntMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte BitRateScale
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte CpbSizeScale
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
        public byte[] CbrFlag
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint InitialCpbRemovalDelayLengthMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint CpbRemovalDelayLengthMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint DpbOutputDelayLengthMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint TimeOffsetLength
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoH264HrdParameters* pointer)
        {
            pointer->CpbCntMinus1 = this.CpbCntMinus1;
            pointer->BitRateScale = this.BitRateScale;
            pointer->CpbSizeScale = this.CpbSizeScale;
            pointer->Reserved1 = this.Reserved1;
            Interop.HeapUtil.MarshalTo(this.BitRateValueMinus1, checked((int)Constants.StdVideoH264CpbCntListSize), pointer->BitRateValueMinus1);
            Interop.HeapUtil.MarshalTo(this.CpbSizeValueMinus1, checked((int)Constants.StdVideoH264CpbCntListSize), pointer->CpbSizeValueMinus1);
            Interop.HeapUtil.MarshalTo(this.CbrFlag, checked((int)Constants.StdVideoH264CpbCntListSize), pointer->CbrFlag);
            pointer->InitialCpbRemovalDelayLengthMinus1 = this.InitialCpbRemovalDelayLengthMinus1;
            pointer->CpbRemovalDelayLengthMinus1 = this.CpbRemovalDelayLengthMinus1;
            pointer->DpbOutputDelayLengthMinus1 = this.DpbOutputDelayLengthMinus1;
            pointer->TimeOffsetLength = this.TimeOffsetLength;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoH264HrdParameters MarshalFrom(SharpVk.Interop.StdVideoH264HrdParameters* pointer)
        {
            StdVideoH264HrdParameters result = default(StdVideoH264HrdParameters);
            result.CpbCntMinus1 = pointer->CpbCntMinus1;
            result.BitRateScale = pointer->BitRateScale;
            result.CpbSizeScale = pointer->CpbSizeScale;
            result.Reserved1 = pointer->Reserved1;
            result.BitRateValueMinus1 = Interop.HeapUtil.MarshalFrom(pointer->BitRateValueMinus1, checked((int)Constants.StdVideoH264CpbCntListSize));
            result.CpbSizeValueMinus1 = Interop.HeapUtil.MarshalFrom(pointer->CpbSizeValueMinus1, checked((int)Constants.StdVideoH264CpbCntListSize));
            result.CbrFlag = Interop.HeapUtil.MarshalFrom(pointer->CbrFlag, checked((int)Constants.StdVideoH264CpbCntListSize));
            result.InitialCpbRemovalDelayLengthMinus1 = pointer->InitialCpbRemovalDelayLengthMinus1;
            result.CpbRemovalDelayLengthMinus1 = pointer->CpbRemovalDelayLengthMinus1;
            result.DpbOutputDelayLengthMinus1 = pointer->DpbOutputDelayLengthMinus1;
            result.TimeOffsetLength = pointer->TimeOffsetLength;
            return result;
        }
    }
}
