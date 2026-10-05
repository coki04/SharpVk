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
    public partial struct StdVideoH264SequenceParameterSetVui
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264SpsVuiFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264AspectRatioIdc AspectRatioIdc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort SarWidth
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort SarHeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte VideoFormat
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte ColourPrimaries
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte TransferCharacteristics
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MatrixCoefficients
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint NumUnitsInTick
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint TimeScale
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxNumReorderFrames
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxDecFrameBuffering
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte ChromaSampleLocTypeTopField
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte ChromaSampleLocTypeBottomField
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264HrdParameters? HrdParameters
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoH264SequenceParameterSetVui* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->AspectRatioIdc = this.AspectRatioIdc;
            pointer->SarWidth = this.SarWidth;
            pointer->SarHeight = this.SarHeight;
            pointer->VideoFormat = this.VideoFormat;
            pointer->ColourPrimaries = this.ColourPrimaries;
            pointer->TransferCharacteristics = this.TransferCharacteristics;
            pointer->MatrixCoefficients = this.MatrixCoefficients;
            pointer->NumUnitsInTick = this.NumUnitsInTick;
            pointer->TimeScale = this.TimeScale;
            pointer->MaxNumReorderFrames = this.MaxNumReorderFrames;
            pointer->MaxDecFrameBuffering = this.MaxDecFrameBuffering;
            pointer->ChromaSampleLocTypeTopField = this.ChromaSampleLocTypeTopField;
            pointer->ChromaSampleLocTypeBottomField = this.ChromaSampleLocTypeBottomField;
            pointer->Reserved1 = this.Reserved1;
            if (this.HrdParameters != null)
            {
                pointer->HrdParameters = (SharpVk.Interop.StdVideoH264HrdParameters*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH264HrdParameters>());
                this.HrdParameters.Value.MarshalTo(pointer->HrdParameters);
            }
            else
            {
                pointer->HrdParameters = default(SharpVk.Interop.StdVideoH264HrdParameters*);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoH264SequenceParameterSetVui MarshalFrom(SharpVk.Interop.StdVideoH264SequenceParameterSetVui* pointer)
        {
            StdVideoH264SequenceParameterSetVui result = default(StdVideoH264SequenceParameterSetVui);
            result.Flags = pointer->Flags;
            result.AspectRatioIdc = pointer->AspectRatioIdc;
            result.SarWidth = pointer->SarWidth;
            result.SarHeight = pointer->SarHeight;
            result.VideoFormat = pointer->VideoFormat;
            result.ColourPrimaries = pointer->ColourPrimaries;
            result.TransferCharacteristics = pointer->TransferCharacteristics;
            result.MatrixCoefficients = pointer->MatrixCoefficients;
            result.NumUnitsInTick = pointer->NumUnitsInTick;
            result.TimeScale = pointer->TimeScale;
            result.MaxNumReorderFrames = pointer->MaxNumReorderFrames;
            result.MaxDecFrameBuffering = pointer->MaxDecFrameBuffering;
            result.ChromaSampleLocTypeTopField = pointer->ChromaSampleLocTypeTopField;
            result.ChromaSampleLocTypeBottomField = pointer->ChromaSampleLocTypeBottomField;
            result.Reserved1 = pointer->Reserved1;
            if (pointer->HrdParameters != null)
            {
                result.HrdParameters = SharpVk.StdVideoH264HrdParameters.MarshalFrom(pointer->HrdParameters);
            }
            else
            {
                result.HrdParameters = null;
            }
            return result;
        }
    }
}
