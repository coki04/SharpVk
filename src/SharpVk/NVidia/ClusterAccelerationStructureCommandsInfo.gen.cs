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

namespace SharpVk.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ClusterAccelerationStructureCommandsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.ClusterAccelerationStructureInputInfo Input
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong? DestinationImplicitData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong ScratchData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.StridedDeviceAddressRegion DestinationAddressesArray
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.StridedDeviceAddressRegion DestinationSizesArray
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.StridedDeviceAddressRegion SourceInfosArray
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong? SourceInfosCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.ClusterAccelerationStructureAddressResolutionFlags? AddressResolutionFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.ClusterAccelerationStructureCommandsInfo* pointer)
        {
            pointer->SType = StructureType.ClusterAccelerationStructureCommandsInfo;
            pointer->Next = null;
            this.Input.MarshalTo(&pointer->Input);
            if (this.DestinationImplicitData != null)
            {
                pointer->DestinationImplicitData = this.DestinationImplicitData.Value;
            }
            else
            {
                pointer->DestinationImplicitData = default(ulong);
            }
            pointer->ScratchData = this.ScratchData;
            pointer->DestinationAddressesArray = this.DestinationAddressesArray;
            pointer->DestinationSizesArray = this.DestinationSizesArray;
            pointer->SourceInfosArray = this.SourceInfosArray;
            if (this.SourceInfosCount != null)
            {
                pointer->SourceInfosCount = this.SourceInfosCount.Value;
            }
            else
            {
                pointer->SourceInfosCount = default(ulong);
            }
            if (this.AddressResolutionFlags != null)
            {
                pointer->AddressResolutionFlags = this.AddressResolutionFlags.Value;
            }
            else
            {
                pointer->AddressResolutionFlags = default(SharpVk.NVidia.ClusterAccelerationStructureAddressResolutionFlags);
            }
        }
    }
}
