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
    public partial struct StdVideoAV1FilmGrain
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1FilmGrainFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte GrainScalingMinus8
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte ArCoeffLag
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte ArCoeffShiftMinus6
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte GrainScaleShift
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort GrainSeed
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte FilmGrainParamsRefIdx
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumYPoints
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] PointYValue
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] PointYScaling
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumCbPoints
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] PointCbValue
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] PointCbScaling
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumCrPoints
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] PointCrValue
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] PointCrScaling
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] ArCoeffsYPlus128
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] ArCoeffsCbPlus128
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte[] ArCoeffsCrPlus128
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte CbMult
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte CbLumaMult
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort CbOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte CrMult
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte CrLumaMult
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort CrOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoAV1FilmGrain* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->GrainScalingMinus8 = this.GrainScalingMinus8;
            pointer->ArCoeffLag = this.ArCoeffLag;
            pointer->ArCoeffShiftMinus6 = this.ArCoeffShiftMinus6;
            pointer->GrainScaleShift = this.GrainScaleShift;
            pointer->GrainSeed = this.GrainSeed;
            pointer->FilmGrainParamsRefIdx = this.FilmGrainParamsRefIdx;
            pointer->NumYPoints = this.NumYPoints;
            Interop.HeapUtil.MarshalTo(this.PointYValue, checked((int)Constants.StdVideoAv1MaxNumYPoints), pointer->PointYValue);
            Interop.HeapUtil.MarshalTo(this.PointYScaling, checked((int)Constants.StdVideoAv1MaxNumYPoints), pointer->PointYScaling);
            pointer->NumCbPoints = this.NumCbPoints;
            Interop.HeapUtil.MarshalTo(this.PointCbValue, checked((int)Constants.StdVideoAv1MaxNumCbPoints), pointer->PointCbValue);
            Interop.HeapUtil.MarshalTo(this.PointCbScaling, checked((int)Constants.StdVideoAv1MaxNumCbPoints), pointer->PointCbScaling);
            pointer->NumCrPoints = this.NumCrPoints;
            Interop.HeapUtil.MarshalTo(this.PointCrValue, checked((int)Constants.StdVideoAv1MaxNumCrPoints), pointer->PointCrValue);
            Interop.HeapUtil.MarshalTo(this.PointCrScaling, checked((int)Constants.StdVideoAv1MaxNumCrPoints), pointer->PointCrScaling);
            Interop.HeapUtil.MarshalTo(this.ArCoeffsYPlus128, checked((int)Constants.StdVideoAv1MaxNumPosLuma), pointer->ArCoeffsYPlus128);
            Interop.HeapUtil.MarshalTo(this.ArCoeffsCbPlus128, checked((int)Constants.StdVideoAv1MaxNumPosChroma), pointer->ArCoeffsCbPlus128);
            Interop.HeapUtil.MarshalTo(this.ArCoeffsCrPlus128, checked((int)Constants.StdVideoAv1MaxNumPosChroma), pointer->ArCoeffsCrPlus128);
            pointer->CbMult = this.CbMult;
            pointer->CbLumaMult = this.CbLumaMult;
            pointer->CbOffset = this.CbOffset;
            pointer->CrMult = this.CrMult;
            pointer->CrLumaMult = this.CrLumaMult;
            pointer->CrOffset = this.CrOffset;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoAV1FilmGrain MarshalFrom(SharpVk.Interop.StdVideoAV1FilmGrain* pointer)
        {
            StdVideoAV1FilmGrain result = default(StdVideoAV1FilmGrain);
            result.Flags = pointer->Flags;
            result.GrainScalingMinus8 = pointer->GrainScalingMinus8;
            result.ArCoeffLag = pointer->ArCoeffLag;
            result.ArCoeffShiftMinus6 = pointer->ArCoeffShiftMinus6;
            result.GrainScaleShift = pointer->GrainScaleShift;
            result.GrainSeed = pointer->GrainSeed;
            result.FilmGrainParamsRefIdx = pointer->FilmGrainParamsRefIdx;
            result.NumYPoints = pointer->NumYPoints;
            result.PointYValue = Interop.HeapUtil.MarshalFrom(pointer->PointYValue, checked((int)Constants.StdVideoAv1MaxNumYPoints));
            result.PointYScaling = Interop.HeapUtil.MarshalFrom(pointer->PointYScaling, checked((int)Constants.StdVideoAv1MaxNumYPoints));
            result.NumCbPoints = pointer->NumCbPoints;
            result.PointCbValue = Interop.HeapUtil.MarshalFrom(pointer->PointCbValue, checked((int)Constants.StdVideoAv1MaxNumCbPoints));
            result.PointCbScaling = Interop.HeapUtil.MarshalFrom(pointer->PointCbScaling, checked((int)Constants.StdVideoAv1MaxNumCbPoints));
            result.NumCrPoints = pointer->NumCrPoints;
            result.PointCrValue = Interop.HeapUtil.MarshalFrom(pointer->PointCrValue, checked((int)Constants.StdVideoAv1MaxNumCrPoints));
            result.PointCrScaling = Interop.HeapUtil.MarshalFrom(pointer->PointCrScaling, checked((int)Constants.StdVideoAv1MaxNumCrPoints));
            result.ArCoeffsYPlus128 = Interop.HeapUtil.MarshalFrom(pointer->ArCoeffsYPlus128, checked((int)Constants.StdVideoAv1MaxNumPosLuma));
            result.ArCoeffsCbPlus128 = Interop.HeapUtil.MarshalFrom(pointer->ArCoeffsCbPlus128, checked((int)Constants.StdVideoAv1MaxNumPosChroma));
            result.ArCoeffsCrPlus128 = Interop.HeapUtil.MarshalFrom(pointer->ArCoeffsCrPlus128, checked((int)Constants.StdVideoAv1MaxNumPosChroma));
            result.CbMult = pointer->CbMult;
            result.CbLumaMult = pointer->CbLumaMult;
            result.CbOffset = pointer->CbOffset;
            result.CrMult = pointer->CrMult;
            result.CrLumaMult = pointer->CrLumaMult;
            result.CrOffset = pointer->CrOffset;
            return result;
        }
    }
}
