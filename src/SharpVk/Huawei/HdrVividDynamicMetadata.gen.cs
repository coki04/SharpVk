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

namespace SharpVk.Huawei
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct HdrVividDynamicMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        public byte[] DynamicMetadata
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Huawei.HdrVividDynamicMetadata* pointer)
        {
            pointer->SType = StructureType.HdrVividDynamicMetadata;
            pointer->Next = null;
            pointer->DynamicMetadataSize = (HostSize)(Interop.HeapUtil.GetLength(this.DynamicMetadata));
            if (this.DynamicMetadata != null)
            {
                var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(this.DynamicMetadata.Length).ToPointer());
                for(int index = 0; index < (uint)(this.DynamicMetadata.Length); index++)
                {
                    fieldPointer[index] = this.DynamicMetadata[index];
                }
                pointer->DynamicMetadata = fieldPointer;
            }
            else
            {
                pointer->DynamicMetadata = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe HdrVividDynamicMetadata MarshalFrom(SharpVk.Interop.Huawei.HdrVividDynamicMetadata* pointer)
        {
            HdrVividDynamicMetadata result = default(HdrVividDynamicMetadata);
            if (pointer->DynamicMetadata != null)
            {
                var fieldPointer = new byte[(uint)(pointer->DynamicMetadataSize)];
                for(int index = 0; index < (uint)(pointer->DynamicMetadataSize); index++)
                {
                    fieldPointer[index] = pointer->DynamicMetadata[index];
                }
                result.DynamicMetadata = fieldPointer;
            }
            else
            {
                result.DynamicMetadata = null;
            }
            return result;
        }
    }
}
