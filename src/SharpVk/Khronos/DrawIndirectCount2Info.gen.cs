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
    public partial struct DrawIndirectCount2Info
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.StridedDeviceAddressRange AddressRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AddressCommandFlags? AddressFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DeviceAddressRange CountAddressRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AddressCommandFlags? CountAddressFlags
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
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.DrawIndirectCount2Info* pointer)
        {
            pointer->SType = StructureType.DrawIndirectCount2Info;
            pointer->Next = null;
            pointer->AddressRange = this.AddressRange;
            if (this.AddressFlags != null)
            {
                pointer->AddressFlags = this.AddressFlags.Value;
            }
            else
            {
                pointer->AddressFlags = default(SharpVk.Khronos.AddressCommandFlags);
            }
            pointer->CountAddressRange = this.CountAddressRange;
            if (this.CountAddressFlags != null)
            {
                pointer->CountAddressFlags = this.CountAddressFlags.Value;
            }
            else
            {
                pointer->CountAddressFlags = default(SharpVk.Khronos.AddressCommandFlags);
            }
            pointer->MaxDrawCount = this.MaxDrawCount;
        }
    }
}
