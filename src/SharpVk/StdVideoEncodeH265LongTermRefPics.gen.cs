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
    public partial struct StdVideoEncodeH265LongTermRefPics
    {
        /// <summary>
        /// 
        /// </summary>
        public byte NumLongTermSps
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumLongTermPics
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] LtIdxSps
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] PocLsbLt
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort UsedByCurrPicLtFlag
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] DeltaPocMsbPresentFlag
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] DeltaPocMsbCycleLt
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoEncodeH265LongTermRefPics* pointer)
        {
            pointer->NumLongTermSps = this.NumLongTermSps;
            pointer->NumLongTermPics = this.NumLongTermPics;
            Interop.HeapUtil.MarshalTo(this.LtIdxSps, checked((int)Constants.StdVideoH265MaxLongTermRefPicsSps), pointer->LtIdxSps);
            Interop.HeapUtil.MarshalTo(this.PocLsbLt, checked((int)Constants.StdVideoH265MaxLongTermPics), pointer->PocLsbLt);
            pointer->UsedByCurrPicLtFlag = this.UsedByCurrPicLtFlag;
            Interop.HeapUtil.MarshalTo(this.DeltaPocMsbPresentFlag, checked((int)Constants.StdVideoH265MaxDeltaPoc), pointer->DeltaPocMsbPresentFlag);
            Interop.HeapUtil.MarshalTo(this.DeltaPocMsbCycleLt, checked((int)Constants.StdVideoH265MaxDeltaPoc), pointer->DeltaPocMsbCycleLt);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoEncodeH265LongTermRefPics MarshalFrom(SharpVk.Interop.StdVideoEncodeH265LongTermRefPics* pointer)
        {
            StdVideoEncodeH265LongTermRefPics result = default(StdVideoEncodeH265LongTermRefPics);
            result.NumLongTermSps = pointer->NumLongTermSps;
            result.NumLongTermPics = pointer->NumLongTermPics;
            result.LtIdxSps = Interop.HeapUtil.MarshalFrom(pointer->LtIdxSps, checked((int)Constants.StdVideoH265MaxLongTermRefPicsSps));
            result.PocLsbLt = Interop.HeapUtil.MarshalFrom(pointer->PocLsbLt, checked((int)Constants.StdVideoH265MaxLongTermPics));
            result.UsedByCurrPicLtFlag = pointer->UsedByCurrPicLtFlag;
            result.DeltaPocMsbPresentFlag = Interop.HeapUtil.MarshalFrom(pointer->DeltaPocMsbPresentFlag, checked((int)Constants.StdVideoH265MaxDeltaPoc));
            result.DeltaPocMsbCycleLt = Interop.HeapUtil.MarshalFrom(pointer->DeltaPocMsbCycleLt, checked((int)Constants.StdVideoH265MaxDeltaPoc));
            return result;
        }
    }
}
