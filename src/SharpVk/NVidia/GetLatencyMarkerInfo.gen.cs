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

namespace SharpVk.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GetLatencyMarkerInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.LatencyTimingsFrameReport[] Timings
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.GetLatencyMarkerInfo* pointer)
        {
            pointer->SType = StructureType.GetLatencyMarkerInfo;
            pointer->Next = null;
            pointer->TimingCount = (uint)(Interop.HeapUtil.GetLength(this.Timings));
            if (this.Timings != null)
            {
                var fieldPointer = (SharpVk.Interop.NVidia.LatencyTimingsFrameReport*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.LatencyTimingsFrameReport>(this.Timings.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Timings.Length); index++)
                {
                    this.Timings[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Timings = fieldPointer;
            }
            else
            {
                pointer->Timings = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe GetLatencyMarkerInfo MarshalFrom(SharpVk.Interop.NVidia.GetLatencyMarkerInfo* pointer)
        {
            GetLatencyMarkerInfo result = default(GetLatencyMarkerInfo);
            if (pointer->Timings != null)
            {
                var fieldPointer = new SharpVk.NVidia.LatencyTimingsFrameReport[(uint)(pointer->TimingCount)];
                for(int index = 0; index < (uint)(pointer->TimingCount); index++)
                {
                    fieldPointer[index] = SharpVk.NVidia.LatencyTimingsFrameReport.MarshalFrom(&pointer->Timings[index]);
                }
                result.Timings = fieldPointer;
            }
            else
            {
                result.Timings = null;
            }
            return result;
        }
    }
}
