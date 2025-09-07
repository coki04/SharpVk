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
    public partial struct DeviceFaultInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string Description
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.DeviceFaultAddressInfo? AddressInfos
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.DeviceFaultVendorInfo? VendorInfos
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr? VendorBinaryData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe DeviceFaultInfo MarshalFrom(SharpVk.Interop.Multivendor.DeviceFaultInfo* pointer)
        {
            DeviceFaultInfo result = default(DeviceFaultInfo);
            result.Description = Interop.HeapUtil.MarshalStringFrom(pointer->Description, Constants.MaxDescriptionSize, true);
            if (pointer->AddressInfos != null)
            {
                result.AddressInfos = *pointer->AddressInfos;
            }
            else
            {
                result.AddressInfos = null;
            }
            if (pointer->VendorInfos != null)
            {
                result.VendorInfos = SharpVk.Multivendor.DeviceFaultVendorInfo.MarshalFrom(pointer->VendorInfos);
            }
            else
            {
                result.VendorInfos = null;
            }
            if (pointer->VendorBinaryData != null)
            {
                result.VendorBinaryData = new IntPtr(pointer->VendorBinaryData);
            }
            else
            {
                result.VendorBinaryData = null;
            }
            return result;
        }
    }
}
