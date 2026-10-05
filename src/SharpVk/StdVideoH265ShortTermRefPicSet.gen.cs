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
    public partial struct StdVideoH265ShortTermRefPicSet
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265ShortTermRefPicSetFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint DeltaIdxMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort UseDeltaFlag
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort AbsDeltaRpsMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort UsedByCurrPicFlag
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort UsedByCurrPicS0Flag
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort UsedByCurrPicS1Flag
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
        public byte Reserved2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Reserved3
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumNegativePics
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumPositivePics
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort[] DeltaPocS0Minus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort[] DeltaPocS1Minus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoH265ShortTermRefPicSet* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->DeltaIdxMinus1 = this.DeltaIdxMinus1;
            pointer->UseDeltaFlag = this.UseDeltaFlag;
            pointer->AbsDeltaRpsMinus1 = this.AbsDeltaRpsMinus1;
            pointer->UsedByCurrPicFlag = this.UsedByCurrPicFlag;
            pointer->UsedByCurrPicS0Flag = this.UsedByCurrPicS0Flag;
            pointer->UsedByCurrPicS1Flag = this.UsedByCurrPicS1Flag;
            pointer->Reserved1 = this.Reserved1;
            pointer->Reserved2 = this.Reserved2;
            pointer->Reserved3 = this.Reserved3;
            pointer->NumNegativePics = this.NumNegativePics;
            pointer->NumPositivePics = this.NumPositivePics;
            Interop.HeapUtil.MarshalTo(this.DeltaPocS0Minus1, checked((int)Constants.StdVideoH265MaxDpbSize), pointer->DeltaPocS0Minus1);
            Interop.HeapUtil.MarshalTo(this.DeltaPocS1Minus1, checked((int)Constants.StdVideoH265MaxDpbSize), pointer->DeltaPocS1Minus1);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoH265ShortTermRefPicSet MarshalFrom(SharpVk.Interop.StdVideoH265ShortTermRefPicSet* pointer)
        {
            StdVideoH265ShortTermRefPicSet result = default(StdVideoH265ShortTermRefPicSet);
            result.Flags = pointer->Flags;
            result.DeltaIdxMinus1 = pointer->DeltaIdxMinus1;
            result.UseDeltaFlag = pointer->UseDeltaFlag;
            result.AbsDeltaRpsMinus1 = pointer->AbsDeltaRpsMinus1;
            result.UsedByCurrPicFlag = pointer->UsedByCurrPicFlag;
            result.UsedByCurrPicS0Flag = pointer->UsedByCurrPicS0Flag;
            result.UsedByCurrPicS1Flag = pointer->UsedByCurrPicS1Flag;
            result.Reserved1 = pointer->Reserved1;
            result.Reserved2 = pointer->Reserved2;
            result.Reserved3 = pointer->Reserved3;
            result.NumNegativePics = pointer->NumNegativePics;
            result.NumPositivePics = pointer->NumPositivePics;
            result.DeltaPocS0Minus1 = Interop.HeapUtil.MarshalFrom(pointer->DeltaPocS0Minus1, checked((int)Constants.StdVideoH265MaxDpbSize));
            result.DeltaPocS1Minus1 = Interop.HeapUtil.MarshalFrom(pointer->DeltaPocS1Minus1, checked((int)Constants.StdVideoH265MaxDpbSize));
            return result;
        }
    }
}
