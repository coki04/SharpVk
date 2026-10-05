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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct StdVideoVP9LoopFilter
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoVP9LoopFilterFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte LoopFilterLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte LoopFilterSharpness
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte UpdateRefDelta
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] LoopFilterRefDeltas
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte UpdateModeDelta
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] LoopFilterModeDeltas
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoVP9LoopFilter* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->LoopFilterLevel = this.LoopFilterLevel;
            pointer->LoopFilterSharpness = this.LoopFilterSharpness;
            pointer->UpdateRefDelta = this.UpdateRefDelta;
            Interop.HeapUtil.MarshalTo(this.LoopFilterRefDeltas, checked((int)Constants.StdVideoVp9MaxRefFrames), pointer->LoopFilterRefDeltas);
            pointer->UpdateModeDelta = this.UpdateModeDelta;
            Interop.HeapUtil.MarshalTo(this.LoopFilterModeDeltas, checked((int)Constants.StdVideoVp9LoopFilterAdjustments), pointer->LoopFilterModeDeltas);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoVP9LoopFilter MarshalFrom(SharpVk.Interop.StdVideoVP9LoopFilter* pointer)
        {
            StdVideoVP9LoopFilter result = default(StdVideoVP9LoopFilter);
            result.Flags = pointer->Flags;
            result.LoopFilterLevel = pointer->LoopFilterLevel;
            result.LoopFilterSharpness = pointer->LoopFilterSharpness;
            result.UpdateRefDelta = pointer->UpdateRefDelta;
            result.LoopFilterRefDeltas = Interop.HeapUtil.MarshalFrom(pointer->LoopFilterRefDeltas, checked((int)Constants.StdVideoVp9MaxRefFrames));
            result.UpdateModeDelta = pointer->UpdateModeDelta;
            result.LoopFilterModeDeltas = Interop.HeapUtil.MarshalFrom(pointer->LoopFilterModeDeltas, checked((int)Constants.StdVideoVp9LoopFilterAdjustments));
            return result;
        }
    }
}
