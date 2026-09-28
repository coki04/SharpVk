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
    public partial struct ImageCompressionControl
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.ImageCompressionFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.ImageCompressionFixedRateFlags[] FixedRateFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.ImageCompressionControl* pointer)
        {
            pointer->SType = StructureType.ImageCompressionControl;
            pointer->Next = null;
            pointer->Flags = this.Flags;
            pointer->CompressionControlPlaneCount = (uint)(Interop.HeapUtil.GetLength(this.FixedRateFlags));
            if (this.FixedRateFlags != null)
            {
                var fieldPointer = (SharpVk.Multivendor.ImageCompressionFixedRateFlags*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Multivendor.ImageCompressionFixedRateFlags>(this.FixedRateFlags.Length).ToPointer());
                for(int index = 0; index < (uint)(this.FixedRateFlags.Length); index++)
                {
                    fieldPointer[index] = this.FixedRateFlags[index];
                }
                pointer->FixedRateFlags = fieldPointer;
            }
            else
            {
                pointer->FixedRateFlags = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe ImageCompressionControl MarshalFrom(SharpVk.Interop.Multivendor.ImageCompressionControl* pointer)
        {
            ImageCompressionControl result = default(ImageCompressionControl);
            result.Flags = pointer->Flags;
            if (pointer->FixedRateFlags != null)
            {
                var fieldPointer = new SharpVk.Multivendor.ImageCompressionFixedRateFlags[(uint)(pointer->CompressionControlPlaneCount)];
                for(int index = 0; index < (uint)(pointer->CompressionControlPlaneCount); index++)
                {
                    fieldPointer[index] = pointer->FixedRateFlags[index];
                }
                result.FixedRateFlags = fieldPointer;
            }
            else
            {
                result.FixedRateFlags = null;
            }
            return result;
        }
    }
}
