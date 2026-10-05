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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VideoEncodeAV1SessionParametersCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1SequenceHeader StdSequenceHeader
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeAV1DecoderModelInfo? StdDecoderModelInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeAV1OperatingPointInfo[] StdOperatingPoints
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.VideoEncodeAV1SessionParametersCreateInfo* pointer)
        {
            pointer->SType = StructureType.VideoEncodeAv1SessionParametersCreateInfo;
            pointer->Next = null;
            pointer->StdSequenceHeader = (SharpVk.Interop.StdVideoAV1SequenceHeader*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoAV1SequenceHeader>());
            this.StdSequenceHeader.MarshalTo(pointer->StdSequenceHeader);
            if (this.StdDecoderModelInfo != null)
            {
                pointer->StdDecoderModelInfo = (SharpVk.StdVideoEncodeAV1DecoderModelInfo*)(Interop.HeapUtil.Allocate<SharpVk.StdVideoEncodeAV1DecoderModelInfo>());
                *pointer->StdDecoderModelInfo = this.StdDecoderModelInfo.Value;
            }
            else
            {
                pointer->StdDecoderModelInfo = default(SharpVk.StdVideoEncodeAV1DecoderModelInfo*);
            }
            pointer->StdOperatingPointCount = (uint)(Interop.HeapUtil.GetLength(this.StdOperatingPoints));
            if (this.StdOperatingPoints != null)
            {
                var fieldPointer = (SharpVk.StdVideoEncodeAV1OperatingPointInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.StdVideoEncodeAV1OperatingPointInfo>(this.StdOperatingPoints.Length).ToPointer());
                for(int index = 0; index < (uint)(this.StdOperatingPoints.Length); index++)
                {
                    fieldPointer[index] = this.StdOperatingPoints[index];
                }
                pointer->StdOperatingPoints = fieldPointer;
            }
            else
            {
                pointer->StdOperatingPoints = null;
            }
        }
    }
}
