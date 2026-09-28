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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GeneratedCommandsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderStageFlags ShaderStages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.IndirectExecutionSet IndirectExecutionSet
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.IndirectCommandsLayout IndirectCommandsLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong IndirectAddress
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong IndirectAddressSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong? PreprocessAddress
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong PreprocessSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSequenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong? SequenceCountAddress
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDrawCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.GeneratedCommandsInfo* pointer)
        {
            pointer->SType = StructureType.GeneratedCommandsInfoExt;
            pointer->Next = null;
            pointer->ShaderStages = this.ShaderStages;
            pointer->IndirectExecutionSet = this.IndirectExecutionSet?.handle ?? default(SharpVk.Interop.Multivendor.IndirectExecutionSet);
            pointer->IndirectCommandsLayout = this.IndirectCommandsLayout?.handle ?? default(SharpVk.Interop.Multivendor.IndirectCommandsLayout);
            pointer->IndirectAddress = this.IndirectAddress;
            pointer->IndirectAddressSize = this.IndirectAddressSize;
            if (this.PreprocessAddress != null)
            {
                pointer->PreprocessAddress = this.PreprocessAddress.Value;
            }
            else
            {
                pointer->PreprocessAddress = default(ulong);
            }
            pointer->PreprocessSize = this.PreprocessSize;
            pointer->MaxSequenceCount = this.MaxSequenceCount;
            if (this.SequenceCountAddress != null)
            {
                pointer->SequenceCountAddress = this.SequenceCountAddress.Value;
            }
            else
            {
                pointer->SequenceCountAddress = default(ulong);
            }
            pointer->MaxDrawCount = this.MaxDrawCount;
        }
    }
}
