// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2025
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
    public partial struct PartitionedAccelerationStructureWritePartitionTranslationData
    {
        /// <summary>
        /// 
        /// </summary>
        public uint PartitionIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (float, float, float) PartitionTranslation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.PartitionedAccelerationStructureWritePartitionTranslationData* pointer)
        {
            pointer->PartitionIndex = this.PartitionIndex;
            pointer->PartitionTranslation[0] = this.PartitionTranslation.Item1;
            pointer->PartitionTranslation[1] = this.PartitionTranslation.Item2;
            pointer->PartitionTranslation[2] = this.PartitionTranslation.Item3;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PartitionedAccelerationStructureWritePartitionTranslationData MarshalFrom(SharpVk.Interop.NVidia.PartitionedAccelerationStructureWritePartitionTranslationData* pointer)
        {
            PartitionedAccelerationStructureWritePartitionTranslationData result = default(PartitionedAccelerationStructureWritePartitionTranslationData);
            result.PartitionIndex = pointer->PartitionIndex;
            result.PartitionTranslation = (pointer->PartitionTranslation[0], pointer->PartitionTranslation[1], pointer->PartitionTranslation[2]);
            return result;
        }
    }
}
