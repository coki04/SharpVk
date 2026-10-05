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

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1FilmGrain
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1FilmGrainFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte GrainScalingMinus8; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte ArCoeffLag; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte ArCoeffShiftMinus6; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte GrainScaleShift; 
        
        /// <summary>
        /// 
        /// </summary>
        public ushort GrainSeed; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte FilmGrainParamsRefIdx; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumYPoints; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed byte PointYValue[checked((int)Constants.StdVideoAv1MaxNumYPoints)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed byte PointYScaling[checked((int)Constants.StdVideoAv1MaxNumYPoints)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumCbPoints; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed byte PointCbValue[checked((int)Constants.StdVideoAv1MaxNumCbPoints)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed byte PointCbScaling[checked((int)Constants.StdVideoAv1MaxNumCbPoints)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte NumCrPoints; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed byte PointCrValue[checked((int)Constants.StdVideoAv1MaxNumCrPoints)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed byte PointCrScaling[checked((int)Constants.StdVideoAv1MaxNumCrPoints)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed sbyte ArCoeffsYPlus128[checked((int)Constants.StdVideoAv1MaxNumPosLuma)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed sbyte ArCoeffsCbPlus128[checked((int)Constants.StdVideoAv1MaxNumPosChroma)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed sbyte ArCoeffsCrPlus128[checked((int)Constants.StdVideoAv1MaxNumPosChroma)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte CbMult; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte CbLumaMult; 
        
        /// <summary>
        /// 
        /// </summary>
        public ushort CbOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte CrMult; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte CrLumaMult; 
        
        /// <summary>
        /// 
        /// </summary>
        public ushort CrOffset; 
    }
}
