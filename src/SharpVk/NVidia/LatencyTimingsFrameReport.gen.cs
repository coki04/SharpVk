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
    public partial struct LatencyTimingsFrameReport
    {
        /// <summary>
        /// 
        /// </summary>
        public ulong PresentID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong InputSampleTimeUs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong SimStartTimeUs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong SimEndTimeUs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong RenderSubmitStartTimeUs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong RenderSubmitEndTimeUs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong PresentStartTimeUs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong PresentEndTimeUs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong DriverStartTimeUs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong DriverEndTimeUs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong OsRenderQueueStartTimeUs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong OsRenderQueueEndTimeUs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong GpuRenderStartTimeUs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong GpuRenderEndTimeUs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.LatencyTimingsFrameReport* pointer)
        {
            pointer->SType = StructureType.LatencyTimingsFrameReport;
            pointer->Next = null;
            pointer->PresentID = this.PresentID;
            pointer->InputSampleTimeUs = this.InputSampleTimeUs;
            pointer->SimStartTimeUs = this.SimStartTimeUs;
            pointer->SimEndTimeUs = this.SimEndTimeUs;
            pointer->RenderSubmitStartTimeUs = this.RenderSubmitStartTimeUs;
            pointer->RenderSubmitEndTimeUs = this.RenderSubmitEndTimeUs;
            pointer->PresentStartTimeUs = this.PresentStartTimeUs;
            pointer->PresentEndTimeUs = this.PresentEndTimeUs;
            pointer->DriverStartTimeUs = this.DriverStartTimeUs;
            pointer->DriverEndTimeUs = this.DriverEndTimeUs;
            pointer->OsRenderQueueStartTimeUs = this.OsRenderQueueStartTimeUs;
            pointer->OsRenderQueueEndTimeUs = this.OsRenderQueueEndTimeUs;
            pointer->GpuRenderStartTimeUs = this.GpuRenderStartTimeUs;
            pointer->GpuRenderEndTimeUs = this.GpuRenderEndTimeUs;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe LatencyTimingsFrameReport MarshalFrom(SharpVk.Interop.NVidia.LatencyTimingsFrameReport* pointer)
        {
            LatencyTimingsFrameReport result = default(LatencyTimingsFrameReport);
            result.PresentID = pointer->PresentID;
            result.InputSampleTimeUs = pointer->InputSampleTimeUs;
            result.SimStartTimeUs = pointer->SimStartTimeUs;
            result.SimEndTimeUs = pointer->SimEndTimeUs;
            result.RenderSubmitStartTimeUs = pointer->RenderSubmitStartTimeUs;
            result.RenderSubmitEndTimeUs = pointer->RenderSubmitEndTimeUs;
            result.PresentStartTimeUs = pointer->PresentStartTimeUs;
            result.PresentEndTimeUs = pointer->PresentEndTimeUs;
            result.DriverStartTimeUs = pointer->DriverStartTimeUs;
            result.DriverEndTimeUs = pointer->DriverEndTimeUs;
            result.OsRenderQueueStartTimeUs = pointer->OsRenderQueueStartTimeUs;
            result.OsRenderQueueEndTimeUs = pointer->OsRenderQueueEndTimeUs;
            result.GpuRenderStartTimeUs = pointer->GpuRenderStartTimeUs;
            result.GpuRenderEndTimeUs = pointer->GpuRenderEndTimeUs;
            return result;
        }
    }
}
