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
    public partial struct MicromapBuildInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.MicromapType Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.BuildMicromapFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.BuildMicromapMode Mode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.Micromap DestinationMicromap
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.MicromapUsage[] UsageCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Data
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr ScratchData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr TriangleArray
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong TriangleArrayStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.MicromapBuildInfo* pointer)
        {
            pointer->SType = StructureType.MicromapBuildInfo;
            pointer->Next = null;
            pointer->Type = this.Type;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Multivendor.BuildMicromapFlags);
            }
            pointer->Mode = this.Mode;
            pointer->DestinationMicromap = this.DestinationMicromap?.handle ?? default(SharpVk.Interop.Multivendor.Micromap);
            pointer->UsageCountsCount = (uint)(Interop.HeapUtil.GetLength(this.UsageCounts));
            if (this.UsageCounts != null)
            {
                var fieldPointer = (SharpVk.Multivendor.MicromapUsage*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Multivendor.MicromapUsage>(this.UsageCounts.Length).ToPointer());
                for(int index = 0; index < (uint)(this.UsageCounts.Length); index++)
                {
                    fieldPointer[index] = this.UsageCounts[index];
                }
                pointer->UsageCounts = fieldPointer;
            }
            else
            {
                pointer->UsageCounts = null;
            }
            pointer->Data = this.Data;
            pointer->ScratchData = this.ScratchData;
            pointer->TriangleArray = this.TriangleArray;
            pointer->TriangleArrayStride = this.TriangleArrayStride;
        }
    }
}
