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
    public partial struct StdVideoH265SequenceParameterSetVui
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265SpsVuiFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265AspectRatioIdc AspectRatioIdc
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
        public byte MatrixCoeffs
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
        public byte Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Reserved2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort DefDispWinLeftOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort DefDispWinRightOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort DefDispWinTopOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort DefDispWinBottomOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint VuiNumUnitsInTick
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint VuiTimeScale
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint VuiNumTicksPocDiffOneMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort MinSpatialSegmentationIdc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort Reserved3
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxBytesPerPicDenom
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxBitsPerMinCuDenom
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MaxMvLengthHorizontal
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Log2MaxMvLengthVertical
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265HrdParameters? HrdParameters
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoH265SequenceParameterSetVui* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->AspectRatioIdc = this.AspectRatioIdc;
            pointer->SarWidth = this.SarWidth;
            pointer->SarHeight = this.SarHeight;
            pointer->VideoFormat = this.VideoFormat;
            pointer->ColourPrimaries = this.ColourPrimaries;
            pointer->TransferCharacteristics = this.TransferCharacteristics;
            pointer->MatrixCoeffs = this.MatrixCoeffs;
            pointer->ChromaSampleLocTypeTopField = this.ChromaSampleLocTypeTopField;
            pointer->ChromaSampleLocTypeBottomField = this.ChromaSampleLocTypeBottomField;
            pointer->Reserved1 = this.Reserved1;
            pointer->Reserved2 = this.Reserved2;
            pointer->DefDispWinLeftOffset = this.DefDispWinLeftOffset;
            pointer->DefDispWinRightOffset = this.DefDispWinRightOffset;
            pointer->DefDispWinTopOffset = this.DefDispWinTopOffset;
            pointer->DefDispWinBottomOffset = this.DefDispWinBottomOffset;
            pointer->VuiNumUnitsInTick = this.VuiNumUnitsInTick;
            pointer->VuiTimeScale = this.VuiTimeScale;
            pointer->VuiNumTicksPocDiffOneMinus1 = this.VuiNumTicksPocDiffOneMinus1;
            pointer->MinSpatialSegmentationIdc = this.MinSpatialSegmentationIdc;
            pointer->Reserved3 = this.Reserved3;
            pointer->MaxBytesPerPicDenom = this.MaxBytesPerPicDenom;
            pointer->MaxBitsPerMinCuDenom = this.MaxBitsPerMinCuDenom;
            pointer->Log2MaxMvLengthHorizontal = this.Log2MaxMvLengthHorizontal;
            pointer->Log2MaxMvLengthVertical = this.Log2MaxMvLengthVertical;
            if (this.HrdParameters != null)
            {
                pointer->HrdParameters = (SharpVk.Interop.StdVideoH265HrdParameters*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH265HrdParameters>());
                this.HrdParameters.Value.MarshalTo(pointer->HrdParameters);
            }
            else
            {
                pointer->HrdParameters = default(SharpVk.Interop.StdVideoH265HrdParameters*);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoH265SequenceParameterSetVui MarshalFrom(SharpVk.Interop.StdVideoH265SequenceParameterSetVui* pointer)
        {
            StdVideoH265SequenceParameterSetVui result = default(StdVideoH265SequenceParameterSetVui);
            result.Flags = pointer->Flags;
            result.AspectRatioIdc = pointer->AspectRatioIdc;
            result.SarWidth = pointer->SarWidth;
            result.SarHeight = pointer->SarHeight;
            result.VideoFormat = pointer->VideoFormat;
            result.ColourPrimaries = pointer->ColourPrimaries;
            result.TransferCharacteristics = pointer->TransferCharacteristics;
            result.MatrixCoeffs = pointer->MatrixCoeffs;
            result.ChromaSampleLocTypeTopField = pointer->ChromaSampleLocTypeTopField;
            result.ChromaSampleLocTypeBottomField = pointer->ChromaSampleLocTypeBottomField;
            result.Reserved1 = pointer->Reserved1;
            result.Reserved2 = pointer->Reserved2;
            result.DefDispWinLeftOffset = pointer->DefDispWinLeftOffset;
            result.DefDispWinRightOffset = pointer->DefDispWinRightOffset;
            result.DefDispWinTopOffset = pointer->DefDispWinTopOffset;
            result.DefDispWinBottomOffset = pointer->DefDispWinBottomOffset;
            result.VuiNumUnitsInTick = pointer->VuiNumUnitsInTick;
            result.VuiTimeScale = pointer->VuiTimeScale;
            result.VuiNumTicksPocDiffOneMinus1 = pointer->VuiNumTicksPocDiffOneMinus1;
            result.MinSpatialSegmentationIdc = pointer->MinSpatialSegmentationIdc;
            result.Reserved3 = pointer->Reserved3;
            result.MaxBytesPerPicDenom = pointer->MaxBytesPerPicDenom;
            result.MaxBitsPerMinCuDenom = pointer->MaxBitsPerMinCuDenom;
            result.Log2MaxMvLengthHorizontal = pointer->Log2MaxMvLengthHorizontal;
            result.Log2MaxMvLengthVertical = pointer->Log2MaxMvLengthVertical;
            if (pointer->HrdParameters != null)
            {
                result.HrdParameters = SharpVk.StdVideoH265HrdParameters.MarshalFrom(pointer->HrdParameters);
            }
            else
            {
                result.HrdParameters = null;
            }
            return result;
        }
    }
}
