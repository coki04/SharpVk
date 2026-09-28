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
    public partial struct PipelineBinaryKeysAndData
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.PipelineBinaryKey[] PipelineBinaryKeys
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.PipelineBinaryData[] PipelineBinaryData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.PipelineBinaryKeysAndData* pointer)
        {
            pointer->BinaryCount = (uint)(Interop.HeapUtil.GetLength(this.PipelineBinaryKeys));
            if (this.PipelineBinaryKeys != null)
            {
                var fieldPointer = (SharpVk.Interop.Khronos.PipelineBinaryKey*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.PipelineBinaryKey>(this.PipelineBinaryKeys.Length).ToPointer());
                for(int index = 0; index < (uint)(this.PipelineBinaryKeys.Length); index++)
                {
                    this.PipelineBinaryKeys[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->PipelineBinaryKeys = fieldPointer;
            }
            else
            {
                pointer->PipelineBinaryKeys = null;
            }
            if (this.PipelineBinaryData != null)
            {
                var fieldPointer = (SharpVk.Interop.Khronos.PipelineBinaryData*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.PipelineBinaryData>(this.PipelineBinaryData.Length).ToPointer());
                for(int index = 0; index < (uint)(this.PipelineBinaryData.Length); index++)
                {
                    this.PipelineBinaryData[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->PipelineBinaryData = fieldPointer;
            }
            else
            {
                pointer->PipelineBinaryData = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PipelineBinaryKeysAndData MarshalFrom(SharpVk.Interop.Khronos.PipelineBinaryKeysAndData* pointer)
        {
            PipelineBinaryKeysAndData result = default(PipelineBinaryKeysAndData);
            if (pointer->PipelineBinaryKeys != null)
            {
                var fieldPointer = new SharpVk.Khronos.PipelineBinaryKey[(uint)(pointer->BinaryCount)];
                for(int index = 0; index < (uint)(pointer->BinaryCount); index++)
                {
                    fieldPointer[index] = SharpVk.Khronos.PipelineBinaryKey.MarshalFrom(&pointer->PipelineBinaryKeys[index]);
                }
                result.PipelineBinaryKeys = fieldPointer;
            }
            else
            {
                result.PipelineBinaryKeys = null;
            }
            if (pointer->PipelineBinaryData != null)
            {
                var fieldPointer = new SharpVk.Khronos.PipelineBinaryData[(uint)(pointer->BinaryCount)];
                for(int index = 0; index < (uint)(pointer->BinaryCount); index++)
                {
                    fieldPointer[index] = SharpVk.Khronos.PipelineBinaryData.MarshalFrom(&pointer->PipelineBinaryData[index]);
                }
                result.PipelineBinaryData = fieldPointer;
            }
            else
            {
                result.PipelineBinaryData = null;
            }
            return result;
        }
    }
}
