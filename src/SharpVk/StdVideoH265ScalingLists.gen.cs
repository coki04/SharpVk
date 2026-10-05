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
    public partial struct StdVideoH265ScalingLists
    {
        /// <summary>
        /// 
        /// </summary>
        public byte[] ScalingList4X4
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] ScalingList8X8
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] ScalingList16X16
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] ScalingList32X32
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] ScalingListDCCoef16X16
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] ScalingListDCCoef32X32
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoH265ScalingLists* pointer)
        {
            Interop.HeapUtil.MarshalTo(this.ScalingList4X4, checked((int)Constants.StdVideoH265ScalingList4x4NumLists), pointer->ScalingList4X4);
            Interop.HeapUtil.MarshalTo(this.ScalingList8X8, checked((int)Constants.StdVideoH265ScalingList8x8NumLists), pointer->ScalingList8X8);
            Interop.HeapUtil.MarshalTo(this.ScalingList16X16, checked((int)Constants.StdVideoH265ScalingList16x16NumLists), pointer->ScalingList16X16);
            Interop.HeapUtil.MarshalTo(this.ScalingList32X32, checked((int)Constants.StdVideoH265ScalingList32x32NumLists), pointer->ScalingList32X32);
            Interop.HeapUtil.MarshalTo(this.ScalingListDCCoef16X16, checked((int)Constants.StdVideoH265ScalingList16x16NumLists), pointer->ScalingListDCCoef16X16);
            Interop.HeapUtil.MarshalTo(this.ScalingListDCCoef32X32, checked((int)Constants.StdVideoH265ScalingList32x32NumLists), pointer->ScalingListDCCoef32X32);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoH265ScalingLists MarshalFrom(SharpVk.Interop.StdVideoH265ScalingLists* pointer)
        {
            StdVideoH265ScalingLists result = default(StdVideoH265ScalingLists);
            result.ScalingList4X4 = Interop.HeapUtil.MarshalFrom(pointer->ScalingList4X4, checked((int)Constants.StdVideoH265ScalingList4x4NumLists));
            result.ScalingList8X8 = Interop.HeapUtil.MarshalFrom(pointer->ScalingList8X8, checked((int)Constants.StdVideoH265ScalingList8x8NumLists));
            result.ScalingList16X16 = Interop.HeapUtil.MarshalFrom(pointer->ScalingList16X16, checked((int)Constants.StdVideoH265ScalingList16x16NumLists));
            result.ScalingList32X32 = Interop.HeapUtil.MarshalFrom(pointer->ScalingList32X32, checked((int)Constants.StdVideoH265ScalingList32x32NumLists));
            result.ScalingListDCCoef16X16 = Interop.HeapUtil.MarshalFrom(pointer->ScalingListDCCoef16X16, checked((int)Constants.StdVideoH265ScalingList16x16NumLists));
            result.ScalingListDCCoef32X32 = Interop.HeapUtil.MarshalFrom(pointer->ScalingListDCCoef32X32, checked((int)Constants.StdVideoH265ScalingList32x32NumLists));
            return result;
        }
    }
}
