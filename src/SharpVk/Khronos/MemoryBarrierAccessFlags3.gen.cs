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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MemoryBarrierAccessFlags3
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AccessFlags3? SourceAccessMask3
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AccessFlags3? DestinationAccessMask3
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.MemoryBarrierAccessFlags3* pointer)
        {
            pointer->SType = StructureType.MemoryBarrierAccessFlags3;
            pointer->Next = null;
            if (this.SourceAccessMask3 != null)
            {
                pointer->SourceAccessMask3 = this.SourceAccessMask3.Value;
            }
            else
            {
                pointer->SourceAccessMask3 = default(SharpVk.Khronos.AccessFlags3);
            }
            if (this.DestinationAccessMask3 != null)
            {
                pointer->DestinationAccessMask3 = this.DestinationAccessMask3.Value;
            }
            else
            {
                pointer->DestinationAccessMask3 = default(SharpVk.Khronos.AccessFlags3);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe MemoryBarrierAccessFlags3 MarshalFrom(SharpVk.Interop.Khronos.MemoryBarrierAccessFlags3* pointer)
        {
            MemoryBarrierAccessFlags3 result = default(MemoryBarrierAccessFlags3);
            result.SourceAccessMask3 = pointer->SourceAccessMask3;
            result.DestinationAccessMask3 = pointer->DestinationAccessMask3;
            return result;
        }
    }
}
