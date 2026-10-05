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
    public partial struct StdVideoEncodeH264ReferenceListsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264ReferenceListsInfoFlags Flags
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
        public (byte, byte, byte, byte, byte, byte, byte) Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264RefListModEntry[] RefList0ModOperations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264RefListModEntry[] RefList1ModOperations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264RefPicMarkingEntry[] RefPicMarkingOperations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoEncodeH264ReferenceListsInfo* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->NumRefIdxL0ActiveMinus1 = this.NumRefIdxL0ActiveMinus1;
            pointer->NumRefIdxL1ActiveMinus1 = this.NumRefIdxL1ActiveMinus1;
            Interop.HeapUtil.MarshalTo(this.RefPicList0, checked((int)Constants.StdVideoH264MaxNumListRef), pointer->RefPicList0);
            Interop.HeapUtil.MarshalTo(this.RefPicList1, checked((int)Constants.StdVideoH264MaxNumListRef), pointer->RefPicList1);
            pointer->RefList0ModOpCount = (byte)(Interop.HeapUtil.GetLength(this.RefList0ModOperations));
            pointer->RefList1ModOpCount = (byte)(Interop.HeapUtil.GetLength(this.RefList1ModOperations));
            pointer->RefPicMarkingOpCount = (byte)(Interop.HeapUtil.GetLength(this.RefPicMarkingOperations));
            pointer->Reserved1[0] = this.Reserved1.Item1;
            pointer->Reserved1[1] = this.Reserved1.Item2;
            pointer->Reserved1[2] = this.Reserved1.Item3;
            pointer->Reserved1[3] = this.Reserved1.Item4;
            pointer->Reserved1[4] = this.Reserved1.Item5;
            pointer->Reserved1[5] = this.Reserved1.Item6;
            pointer->Reserved1[6] = this.Reserved1.Item7;
            if (this.RefList0ModOperations != null)
            {
                var fieldPointer = (SharpVk.StdVideoEncodeH264RefListModEntry*)(Interop.HeapUtil.AllocateAndClear<SharpVk.StdVideoEncodeH264RefListModEntry>(this.RefList0ModOperations.Length).ToPointer());
                for(int index = 0; index < (uint)(this.RefList0ModOperations.Length); index++)
                {
                    fieldPointer[index] = this.RefList0ModOperations[index];
                }
                pointer->RefList0ModOperations = fieldPointer;
            }
            else
            {
                pointer->RefList0ModOperations = null;
            }
            if (this.RefList1ModOperations != null)
            {
                var fieldPointer = (SharpVk.StdVideoEncodeH264RefListModEntry*)(Interop.HeapUtil.AllocateAndClear<SharpVk.StdVideoEncodeH264RefListModEntry>(this.RefList1ModOperations.Length).ToPointer());
                for(int index = 0; index < (uint)(this.RefList1ModOperations.Length); index++)
                {
                    fieldPointer[index] = this.RefList1ModOperations[index];
                }
                pointer->RefList1ModOperations = fieldPointer;
            }
            else
            {
                pointer->RefList1ModOperations = null;
            }
            if (this.RefPicMarkingOperations != null)
            {
                var fieldPointer = (SharpVk.StdVideoEncodeH264RefPicMarkingEntry*)(Interop.HeapUtil.AllocateAndClear<SharpVk.StdVideoEncodeH264RefPicMarkingEntry>(this.RefPicMarkingOperations.Length).ToPointer());
                for(int index = 0; index < (uint)(this.RefPicMarkingOperations.Length); index++)
                {
                    fieldPointer[index] = this.RefPicMarkingOperations[index];
                }
                pointer->RefPicMarkingOperations = fieldPointer;
            }
            else
            {
                pointer->RefPicMarkingOperations = null;
            }
        }
    }
}
