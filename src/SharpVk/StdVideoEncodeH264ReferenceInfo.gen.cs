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
    public partial struct StdVideoEncodeH264ReferenceInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public StdVideoEncodeH264ReferenceInfo(SharpVk.StdVideoEncodeH264ReferenceInfoFlags flags, SharpVk.StdVideoH264PictureType primaryPicType, uint frameNum, int picOrderCnt, ushort longTermPicNum, ushort longTermFrameIdx, byte temporalId)
        {
            this.Flags = flags;
            this.PrimaryPicType = primaryPicType;
            this.FrameNum = frameNum;
            this.PicOrderCnt = picOrderCnt;
            this.LongTermPicNum = longTermPicNum;
            this.LongTermFrameIdx = longTermFrameIdx;
            this.TemporalId = temporalId;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264ReferenceInfoFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264PictureType PrimaryPicType; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint FrameNum; 
        
        /// <summary>
        /// 
        /// </summary>
        public int PicOrderCnt; 
        
        /// <summary>
        /// 
        /// </summary>
        public ushort LongTermPicNum; 
        
        /// <summary>
        /// 
        /// </summary>
        public ushort LongTermFrameIdx; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte TemporalId; 
    }
}
