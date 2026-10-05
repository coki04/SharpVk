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
    public partial struct StdVideoEncodeH265ReferenceListsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH265ReferenceListsInfoFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumRefIdxL0ActiveMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumRefIdxL1ActiveMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] RefPicList0
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] RefPicList1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] ListEntryL0
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] ListEntryL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoEncodeH265ReferenceListsInfo* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->NumRefIdxL0ActiveMinus1 = this.NumRefIdxL0ActiveMinus1;
            pointer->NumRefIdxL1ActiveMinus1 = this.NumRefIdxL1ActiveMinus1;
            Interop.HeapUtil.MarshalTo(this.RefPicList0, checked((int)Constants.StdVideoH265MaxNumListRef), pointer->RefPicList0);
            Interop.HeapUtil.MarshalTo(this.RefPicList1, checked((int)Constants.StdVideoH265MaxNumListRef), pointer->RefPicList1);
            Interop.HeapUtil.MarshalTo(this.ListEntryL0, checked((int)Constants.StdVideoH265MaxNumListRef), pointer->ListEntryL0);
            Interop.HeapUtil.MarshalTo(this.ListEntryL1, checked((int)Constants.StdVideoH265MaxNumListRef), pointer->ListEntryL1);
        }
    }
}
