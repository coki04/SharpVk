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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DeviceFaultCounts
    {
        /// <summary>
        /// 
        /// </summary>
        public uint? AddressInfoCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? VendorInfoCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong? VendorBinarySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.DeviceFaultCounts* pointer)
        {
            pointer->SType = StructureType.DeviceFaultCounts;
            pointer->Next = null;
            if (this.AddressInfoCount != null)
            {
                pointer->AddressInfoCount = this.AddressInfoCount.Value;
            }
            else
            {
                pointer->AddressInfoCount = default(uint);
            }
            if (this.VendorInfoCount != null)
            {
                pointer->VendorInfoCount = this.VendorInfoCount.Value;
            }
            else
            {
                pointer->VendorInfoCount = default(uint);
            }
            if (this.VendorBinarySize != null)
            {
                pointer->VendorBinarySize = this.VendorBinarySize.Value;
            }
            else
            {
                pointer->VendorBinarySize = default(ulong);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe DeviceFaultCounts MarshalFrom(SharpVk.Interop.Multivendor.DeviceFaultCounts* pointer)
        {
            DeviceFaultCounts result = default(DeviceFaultCounts);
            result.AddressInfoCount = pointer->AddressInfoCount;
            result.VendorInfoCount = pointer->VendorInfoCount;
            result.VendorBinarySize = pointer->VendorBinarySize;
            return result;
        }
    }
}
