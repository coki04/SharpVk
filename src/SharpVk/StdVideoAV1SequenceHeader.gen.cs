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
    public partial struct StdVideoAV1SequenceHeader
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1SequenceHeaderFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1Profile SeqProfile
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte FrameWidthBitsMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte FrameHeightBitsMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort MaxFrameWidthMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort MaxFrameHeightMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte DeltaFrameIdLengthMinus2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte AdditionalFrameIdLengthMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte OrderHintBitsMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte SeqForceIntegerMv
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte SeqForceScreenContentTools
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (byte, byte, byte, byte, byte) Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1ColorConfig ColorConfig
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1TimingInfo? TimingInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoAV1SequenceHeader* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->SeqProfile = this.SeqProfile;
            pointer->FrameWidthBitsMinus1 = this.FrameWidthBitsMinus1;
            pointer->FrameHeightBitsMinus1 = this.FrameHeightBitsMinus1;
            pointer->MaxFrameWidthMinus1 = this.MaxFrameWidthMinus1;
            pointer->MaxFrameHeightMinus1 = this.MaxFrameHeightMinus1;
            pointer->DeltaFrameIdLengthMinus2 = this.DeltaFrameIdLengthMinus2;
            pointer->AdditionalFrameIdLengthMinus1 = this.AdditionalFrameIdLengthMinus1;
            pointer->OrderHintBitsMinus1 = this.OrderHintBitsMinus1;
            pointer->SeqForceIntegerMv = this.SeqForceIntegerMv;
            pointer->SeqForceScreenContentTools = this.SeqForceScreenContentTools;
            pointer->Reserved1[0] = this.Reserved1.Item1;
            pointer->Reserved1[1] = this.Reserved1.Item2;
            pointer->Reserved1[2] = this.Reserved1.Item3;
            pointer->Reserved1[3] = this.Reserved1.Item4;
            pointer->Reserved1[4] = this.Reserved1.Item5;
            pointer->ColorConfig = (SharpVk.StdVideoAV1ColorConfig*)(Interop.HeapUtil.Allocate<SharpVk.StdVideoAV1ColorConfig>());
            *pointer->ColorConfig = this.ColorConfig;
            if (this.TimingInfo != null)
            {
                pointer->TimingInfo = (SharpVk.StdVideoAV1TimingInfo*)(Interop.HeapUtil.Allocate<SharpVk.StdVideoAV1TimingInfo>());
                *pointer->TimingInfo = this.TimingInfo.Value;
            }
            else
            {
                pointer->TimingInfo = default(SharpVk.StdVideoAV1TimingInfo*);
            }
        }
    }
}
