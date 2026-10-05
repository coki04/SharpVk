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

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH264ReferenceListsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264ReferenceListsInfoFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumRefIdxL0ActiveMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumRefIdxL1ActiveMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed byte RefPicList0[checked((int)Constants.StdVideoH264MaxNumListRef)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed byte RefPicList1[checked((int)Constants.StdVideoH264MaxNumListRef)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte RefList0ModOpCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte RefList1ModOpCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte RefPicMarkingOpCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed byte Reserved1[7]; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264RefListModEntry* RefList0ModOperations; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264RefListModEntry* RefList1ModOperations; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264RefPicMarkingEntry* RefPicMarkingOperations; 
    }
}
