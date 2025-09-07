// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2025
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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VideoEncodeH264SessionParametersCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public uint MaxStdSPSCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxStdPPSCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeH264SessionParametersAddInfo? ParametersAddInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.VideoEncodeH264SessionParametersCreateInfo* pointer)
        {
            pointer->SType = StructureType.VideoEncodeH264SessionParametersCreateInfo;
            pointer->Next = null;
            pointer->MaxStdSPSCount = this.MaxStdSPSCount;
            pointer->MaxStdPPSCount = this.MaxStdPPSCount;
            if (this.ParametersAddInfo != null)
            {
                pointer->ParametersAddInfo = (SharpVk.Interop.Khronos.VideoEncodeH264SessionParametersAddInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoEncodeH264SessionParametersAddInfo>());
                this.ParametersAddInfo.Value.MarshalTo(pointer->ParametersAddInfo);
            }
            else
            {
                pointer->ParametersAddInfo = default(SharpVk.Interop.Khronos.VideoEncodeH264SessionParametersAddInfo*);
            }
        }
    }
}
