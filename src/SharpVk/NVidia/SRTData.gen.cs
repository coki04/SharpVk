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
    public partial struct SRTData
    {
        /// <summary>
        /// 
        /// </summary>
        public static SRTData Zero => new SRTData();
        
        /// <summary>
        /// 
        /// </summary>
        public SRTData(float sx, float a, float b, float pvx, float sy, float c, float pvy, float sz, float pvz, float qx, float qy, float qz, float qw, float tx, float ty, float tz)
        {
            this.Sx = sx;
            this.A = a;
            this.B = b;
            this.Pvx = pvx;
            this.Sy = sy;
            this.C = c;
            this.Pvy = pvy;
            this.Sz = sz;
            this.Pvz = pvz;
            this.Qx = qx;
            this.Qy = qy;
            this.Qz = qz;
            this.Qw = qw;
            this.Tx = tx;
            this.Ty = ty;
            this.Tz = tz;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float Sx; 
        
        /// <summary>
        /// 
        /// </summary>
        public float A; 
        
        /// <summary>
        /// 
        /// </summary>
        public float B; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Pvx; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Sy; 
        
        /// <summary>
        /// 
        /// </summary>
        public float C; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Pvy; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Sz; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Pvz; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Qx; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Qy; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Qz; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Qw; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Tx; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Ty; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Tz; 
    }
}
