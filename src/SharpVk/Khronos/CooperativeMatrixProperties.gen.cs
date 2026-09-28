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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct CooperativeMatrixProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public uint MSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint NSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint KSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.ComponentType AType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.ComponentType BType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.ComponentType CType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.ComponentType ResultType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SaturatingAccumulation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.Scope Scope
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe CooperativeMatrixProperties MarshalFrom(SharpVk.Interop.Khronos.CooperativeMatrixProperties* pointer)
        {
            CooperativeMatrixProperties result = default(CooperativeMatrixProperties);
            result.MSize = pointer->MSize;
            result.NSize = pointer->NSize;
            result.KSize = pointer->KSize;
            result.AType = pointer->AType;
            result.BType = pointer->BType;
            result.CType = pointer->CType;
            result.ResultType = pointer->ResultType;
            result.SaturatingAccumulation = pointer->SaturatingAccumulation;
            result.Scope = pointer->Scope;
            return result;
        }
    }
}
