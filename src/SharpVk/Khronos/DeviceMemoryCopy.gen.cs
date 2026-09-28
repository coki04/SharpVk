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
    public partial struct DeviceMemoryCopy
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DeviceAddressRange SourceRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AddressCommandFlags? SourceFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DeviceAddressRange DestinationRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AddressCommandFlags? DestinationFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.DeviceMemoryCopy* pointer)
        {
            pointer->SType = StructureType.DeviceMemoryCopy;
            pointer->Next = null;
            pointer->SourceRange = this.SourceRange;
            if (this.SourceFlags != null)
            {
                pointer->SourceFlags = this.SourceFlags.Value;
            }
            else
            {
                pointer->SourceFlags = default(SharpVk.Khronos.AddressCommandFlags);
            }
            pointer->DestinationRange = this.DestinationRange;
            if (this.DestinationFlags != null)
            {
                pointer->DestinationFlags = this.DestinationFlags.Value;
            }
            else
            {
                pointer->DestinationFlags = default(SharpVk.Khronos.AddressCommandFlags);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe DeviceMemoryCopy MarshalFrom(SharpVk.Interop.Khronos.DeviceMemoryCopy* pointer)
        {
            DeviceMemoryCopy result = default(DeviceMemoryCopy);
            result.SourceRange = pointer->SourceRange;
            result.SourceFlags = pointer->SourceFlags;
            result.DestinationRange = pointer->DestinationRange;
            result.DestinationFlags = pointer->DestinationFlags;
            return result;
        }
    }
}
