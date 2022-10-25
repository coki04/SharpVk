// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2022
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
    public partial struct DeviceFaultVendorBinaryHeaderVersionOne
    {
        /// <summary>
        /// 
        /// </summary>
        public uint HeaderSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.DeviceFaultVendorBinaryHeaderVersion HeaderVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint VendorID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint DeviceID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Version DriverVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Guid PipelineCacheUUID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ApplicationNameOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Version ApplicationVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint EngineNameOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.DeviceFaultVendorBinaryHeaderVersionOne* pointer)
        {
            pointer->HeaderSize = this.HeaderSize;
            pointer->HeaderVersion = this.HeaderVersion;
            pointer->VendorID = this.VendorID;
            pointer->DeviceID = this.DeviceID;
            pointer->DriverVersion = (uint)(this.DriverVersion);
            Interop.HeapUtil.MarshalTo(this.PipelineCacheUUID, Constants.UuidSize, pointer->PipelineCacheUUID);
            pointer->ApplicationNameOffset = this.ApplicationNameOffset;
            pointer->ApplicationVersion = (uint)(this.ApplicationVersion);
            pointer->EngineNameOffset = this.EngineNameOffset;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe DeviceFaultVendorBinaryHeaderVersionOne MarshalFrom(SharpVk.Interop.Multivendor.DeviceFaultVendorBinaryHeaderVersionOne* pointer)
        {
            DeviceFaultVendorBinaryHeaderVersionOne result = default(DeviceFaultVendorBinaryHeaderVersionOne);
            result.HeaderSize = pointer->HeaderSize;
            result.HeaderVersion = pointer->HeaderVersion;
            result.VendorID = pointer->VendorID;
            result.DeviceID = pointer->DeviceID;
            result.DriverVersion = (Version)(pointer->DriverVersion);
            result.PipelineCacheUUID = new Guid(Interop.HeapUtil.MarshalFrom(pointer->PipelineCacheUUID, Constants.UuidSize));
            result.ApplicationNameOffset = pointer->ApplicationNameOffset;
            result.ApplicationVersion = (Version)(pointer->ApplicationVersion);
            result.EngineNameOffset = pointer->EngineNameOffset;
            return result;
        }
    }
}
