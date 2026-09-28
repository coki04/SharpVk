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
    public partial struct DeviceFaultInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DeviceFaultFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong GroupId
        {
            get;
            set;
        }
        
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
        public SharpVk.Khronos.DeviceFaultAddressInfo? FaultAddressInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DeviceFaultAddressInfo? InstructionAddressInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DeviceFaultVendorInfo? VendorInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe DeviceFaultInfo MarshalFrom(SharpVk.Interop.Khronos.DeviceFaultInfo* pointer)
        {
            DeviceFaultInfo result = default(DeviceFaultInfo);
            result.Flags = pointer->Flags;
            result.GroupId = pointer->GroupId;
            result.Description = Interop.HeapUtil.MarshalStringFrom(pointer->Description, checked((int)Constants.MaxDescriptionSize), true);
            result.FaultAddressInfo = pointer->FaultAddressInfo;
            result.InstructionAddressInfo = pointer->InstructionAddressInfo;
            result.VendorInfo = SharpVk.Khronos.DeviceFaultVendorInfo.MarshalFrom(&pointer->VendorInfo);
            return result;
        }
    }
}
