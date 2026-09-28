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

namespace SharpVk.Fuchsia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageConstraintsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Fuchsia.ImageFormatConstraintsInfo[] FormatConstraints
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Fuchsia.BufferCollectionConstraintsInfo BufferCollectionConstraints
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Fuchsia.ImageConstraintsInfoFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Fuchsia.ImageConstraintsInfo* pointer)
        {
            pointer->SType = StructureType.ImageConstraintsInfo;
            pointer->Next = null;
            pointer->FormatConstraintsCount = (uint)(Interop.HeapUtil.GetLength(this.FormatConstraints));
            if (this.FormatConstraints != null)
            {
                var fieldPointer = (SharpVk.Interop.Fuchsia.ImageFormatConstraintsInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Fuchsia.ImageFormatConstraintsInfo>(this.FormatConstraints.Length).ToPointer());
                for(int index = 0; index < (uint)(this.FormatConstraints.Length); index++)
                {
                    this.FormatConstraints[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->FormatConstraints = fieldPointer;
            }
            else
            {
                pointer->FormatConstraints = null;
            }
            this.BufferCollectionConstraints.MarshalTo(&pointer->BufferCollectionConstraints);
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Fuchsia.ImageConstraintsInfoFlags);
            }
        }
    }
}
