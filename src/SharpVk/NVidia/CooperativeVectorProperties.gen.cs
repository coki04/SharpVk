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
    public partial struct CooperativeVectorProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.ComponentType InputType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.ComponentType InputInterpretation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.ComponentType MatrixInterpretation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.ComponentType BiasInterpretation
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
        public bool Transpose
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.CooperativeVectorProperties* pointer)
        {
            pointer->SType = StructureType.CooperativeVectorProperties;
            pointer->Next = null;
            pointer->InputType = this.InputType;
            pointer->InputInterpretation = this.InputInterpretation;
            pointer->MatrixInterpretation = this.MatrixInterpretation;
            pointer->BiasInterpretation = this.BiasInterpretation;
            pointer->ResultType = this.ResultType;
            pointer->Transpose = this.Transpose;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe CooperativeVectorProperties MarshalFrom(SharpVk.Interop.NVidia.CooperativeVectorProperties* pointer)
        {
            CooperativeVectorProperties result = default(CooperativeVectorProperties);
            result.InputType = pointer->InputType;
            result.InputInterpretation = pointer->InputInterpretation;
            result.MatrixInterpretation = pointer->MatrixInterpretation;
            result.BiasInterpretation = pointer->BiasInterpretation;
            result.ResultType = pointer->ResultType;
            result.Transpose = pointer->Transpose;
            return result;
        }
    }
}
