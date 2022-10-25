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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceShaderIntegerDotProductProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct8BitUnsignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct8BitSignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct8BitMixedSignednessAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct4X8BitPackedUnsignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct4X8BitPackedSignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct4X8BitPackedMixedSignednessAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct16BitUnsignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct16BitSignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct16BitMixedSignednessAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct32BitUnsignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct32BitSignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct32BitMixedSignednessAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct64BitUnsignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct64BitSignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProduct64BitMixedSignednessAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating8BitSignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating4X8BitPackedUnsignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating4X8BitPackedSignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating4X8BitPackedMixedSignednessAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating16BitSignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating32BitSignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating64BitSignedAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceShaderIntegerDotProductProperties MarshalFrom(SharpVk.Interop.PhysicalDeviceShaderIntegerDotProductProperties* pointer)
        {
            PhysicalDeviceShaderIntegerDotProductProperties result = default(PhysicalDeviceShaderIntegerDotProductProperties);
            result.IntegerDotProduct8BitUnsignedAccelerated = pointer->IntegerDotProduct8BitUnsignedAccelerated;
            result.IntegerDotProduct8BitSignedAccelerated = pointer->IntegerDotProduct8BitSignedAccelerated;
            result.IntegerDotProduct8BitMixedSignednessAccelerated = pointer->IntegerDotProduct8BitMixedSignednessAccelerated;
            result.IntegerDotProduct4X8BitPackedUnsignedAccelerated = pointer->IntegerDotProduct4X8BitPackedUnsignedAccelerated;
            result.IntegerDotProduct4X8BitPackedSignedAccelerated = pointer->IntegerDotProduct4X8BitPackedSignedAccelerated;
            result.IntegerDotProduct4X8BitPackedMixedSignednessAccelerated = pointer->IntegerDotProduct4X8BitPackedMixedSignednessAccelerated;
            result.IntegerDotProduct16BitUnsignedAccelerated = pointer->IntegerDotProduct16BitUnsignedAccelerated;
            result.IntegerDotProduct16BitSignedAccelerated = pointer->IntegerDotProduct16BitSignedAccelerated;
            result.IntegerDotProduct16BitMixedSignednessAccelerated = pointer->IntegerDotProduct16BitMixedSignednessAccelerated;
            result.IntegerDotProduct32BitUnsignedAccelerated = pointer->IntegerDotProduct32BitUnsignedAccelerated;
            result.IntegerDotProduct32BitSignedAccelerated = pointer->IntegerDotProduct32BitSignedAccelerated;
            result.IntegerDotProduct32BitMixedSignednessAccelerated = pointer->IntegerDotProduct32BitMixedSignednessAccelerated;
            result.IntegerDotProduct64BitUnsignedAccelerated = pointer->IntegerDotProduct64BitUnsignedAccelerated;
            result.IntegerDotProduct64BitSignedAccelerated = pointer->IntegerDotProduct64BitSignedAccelerated;
            result.IntegerDotProduct64BitMixedSignednessAccelerated = pointer->IntegerDotProduct64BitMixedSignednessAccelerated;
            result.IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated = pointer->IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
            result.IntegerDotProductAccumulatingSaturating8BitSignedAccelerated = pointer->IntegerDotProductAccumulatingSaturating8BitSignedAccelerated;
            result.IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated = pointer->IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
            result.IntegerDotProductAccumulatingSaturating4X8BitPackedUnsignedAccelerated = pointer->IntegerDotProductAccumulatingSaturating4X8BitPackedUnsignedAccelerated;
            result.IntegerDotProductAccumulatingSaturating4X8BitPackedSignedAccelerated = pointer->IntegerDotProductAccumulatingSaturating4X8BitPackedSignedAccelerated;
            result.IntegerDotProductAccumulatingSaturating4X8BitPackedMixedSignednessAccelerated = pointer->IntegerDotProductAccumulatingSaturating4X8BitPackedMixedSignednessAccelerated;
            result.IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated = pointer->IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
            result.IntegerDotProductAccumulatingSaturating16BitSignedAccelerated = pointer->IntegerDotProductAccumulatingSaturating16BitSignedAccelerated;
            result.IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated = pointer->IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
            result.IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated = pointer->IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
            result.IntegerDotProductAccumulatingSaturating32BitSignedAccelerated = pointer->IntegerDotProductAccumulatingSaturating32BitSignedAccelerated;
            result.IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated = pointer->IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
            result.IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated = pointer->IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
            result.IntegerDotProductAccumulatingSaturating64BitSignedAccelerated = pointer->IntegerDotProductAccumulatingSaturating64BitSignedAccelerated;
            result.IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated = pointer->IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
            return result;
        }
    }
}
