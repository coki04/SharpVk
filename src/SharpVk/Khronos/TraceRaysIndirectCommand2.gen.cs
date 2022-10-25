// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2022
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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct TraceRaysIndirectCommand2
    {
        /// <summary>
        /// 
        /// </summary>
        public TraceRaysIndirectCommand2(ulong raygenShaderRecordAddress, ulong raygenShaderRecordSize, ulong missShaderBindingTableAddress, ulong missShaderBindingTableSize, ulong missShaderBindingTableStride, ulong hitShaderBindingTableAddress, ulong hitShaderBindingTableSize, ulong hitShaderBindingTableStride, ulong callableShaderBindingTableAddress, ulong callableShaderBindingTableSize, ulong callableShaderBindingTableStride, uint width, uint height, uint depth)
        {
            this.RaygenShaderRecordAddress = raygenShaderRecordAddress;
            this.RaygenShaderRecordSize = raygenShaderRecordSize;
            this.MissShaderBindingTableAddress = missShaderBindingTableAddress;
            this.MissShaderBindingTableSize = missShaderBindingTableSize;
            this.MissShaderBindingTableStride = missShaderBindingTableStride;
            this.HitShaderBindingTableAddress = hitShaderBindingTableAddress;
            this.HitShaderBindingTableSize = hitShaderBindingTableSize;
            this.HitShaderBindingTableStride = hitShaderBindingTableStride;
            this.CallableShaderBindingTableAddress = callableShaderBindingTableAddress;
            this.CallableShaderBindingTableSize = callableShaderBindingTableSize;
            this.CallableShaderBindingTableStride = callableShaderBindingTableStride;
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong RaygenShaderRecordAddress; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong RaygenShaderRecordSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MissShaderBindingTableAddress; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MissShaderBindingTableSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MissShaderBindingTableStride; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong HitShaderBindingTableAddress; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong HitShaderBindingTableSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong HitShaderBindingTableStride; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong CallableShaderBindingTableAddress; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong CallableShaderBindingTableSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong CallableShaderBindingTableStride; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Width; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Height; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Depth; 
    }
}
