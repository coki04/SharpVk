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
    public partial struct StdVideoEncodeAV1ReferenceInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeAV1ReferenceInfoFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint RefFrameId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1FrameType FrameType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte OrderHint
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (byte, byte, byte) Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeAV1ExtensionHeader? ExtensionHeader
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoEncodeAV1ReferenceInfo* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->RefFrameId = this.RefFrameId;
            pointer->FrameType = this.FrameType;
            pointer->OrderHint = this.OrderHint;
            pointer->Reserved1[0] = this.Reserved1.Item1;
            pointer->Reserved1[1] = this.Reserved1.Item2;
            pointer->Reserved1[2] = this.Reserved1.Item3;
            if (this.ExtensionHeader != null)
            {
                pointer->ExtensionHeader = (SharpVk.StdVideoEncodeAV1ExtensionHeader*)(Interop.HeapUtil.Allocate<SharpVk.StdVideoEncodeAV1ExtensionHeader>());
                *pointer->ExtensionHeader = this.ExtensionHeader.Value;
            }
            else
            {
                pointer->ExtensionHeader = default(SharpVk.StdVideoEncodeAV1ExtensionHeader*);
            }
        }
    }
}
