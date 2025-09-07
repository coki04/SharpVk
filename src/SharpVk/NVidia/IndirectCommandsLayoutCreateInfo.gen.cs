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

namespace SharpVk.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct IndirectCommandsLayoutCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.IndirectCommandsLayoutUsageFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.IndirectCommandsLayoutToken[] Tokens
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] StreamStrides
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.IndirectCommandsLayoutCreateInfo* pointer)
        {
            pointer->SType = StructureType.IndirectCommandsLayoutCreateInfoNv;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.NVidia.IndirectCommandsLayoutUsageFlags);
            }
            pointer->PipelineBindPoint = this.PipelineBindPoint;
            pointer->TokenCount = (uint)(Interop.HeapUtil.GetLength(this.Tokens));
            if (this.Tokens != null)
            {
                var fieldPointer = (SharpVk.Interop.NVidia.IndirectCommandsLayoutToken*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.IndirectCommandsLayoutToken>(this.Tokens.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Tokens.Length); index++)
                {
                    this.Tokens[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Tokens = fieldPointer;
            }
            else
            {
                pointer->Tokens = null;
            }
            pointer->StreamCount = (uint)(Interop.HeapUtil.GetLength(this.StreamStrides));
            if (this.StreamStrides != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.StreamStrides.Length).ToPointer());
                for(int index = 0; index < (uint)(this.StreamStrides.Length); index++)
                {
                    fieldPointer[index] = this.StreamStrides[index];
                }
                pointer->StreamStrides = fieldPointer;
            }
            else
            {
                pointer->StreamStrides = null;
            }
        }
    }
}
