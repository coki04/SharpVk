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

namespace SharpVk.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AccelerationStructureSRTMotionInstance
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.SRTData TransformT0
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.SRTData TransformT1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint) InstanceCustomIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint, uint, uint, uint, uint, uint) Mask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint) InstanceShaderBindingTableRecordOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (SharpVk.Khronos.GeometryInstanceFlags, SharpVk.Khronos.GeometryInstanceFlags, SharpVk.Khronos.GeometryInstanceFlags, SharpVk.Khronos.GeometryInstanceFlags, SharpVk.Khronos.GeometryInstanceFlags, SharpVk.Khronos.GeometryInstanceFlags, SharpVk.Khronos.GeometryInstanceFlags, SharpVk.Khronos.GeometryInstanceFlags) Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong AccelerationStructureReference
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.AccelerationStructureSRTMotionInstance* pointer)
        {
            pointer->TransformT0 = this.TransformT0;
            pointer->TransformT1 = this.TransformT1;
            pointer->InstanceCustomIndex[0] = this.InstanceCustomIndex.Item1;
            pointer->InstanceCustomIndex[1] = this.InstanceCustomIndex.Item2;
            pointer->InstanceCustomIndex[2] = this.InstanceCustomIndex.Item3;
            pointer->InstanceCustomIndex[3] = this.InstanceCustomIndex.Item4;
            pointer->InstanceCustomIndex[4] = this.InstanceCustomIndex.Item5;
            pointer->InstanceCustomIndex[5] = this.InstanceCustomIndex.Item6;
            pointer->InstanceCustomIndex[6] = this.InstanceCustomIndex.Item7;
            pointer->InstanceCustomIndex[7] = this.InstanceCustomIndex.Item8;
            pointer->InstanceCustomIndex[8] = this.InstanceCustomIndex.Item9;
            pointer->InstanceCustomIndex[9] = this.InstanceCustomIndex.Item10;
            pointer->InstanceCustomIndex[10] = this.InstanceCustomIndex.Item11;
            pointer->InstanceCustomIndex[11] = this.InstanceCustomIndex.Item12;
            pointer->InstanceCustomIndex[12] = this.InstanceCustomIndex.Item13;
            pointer->InstanceCustomIndex[13] = this.InstanceCustomIndex.Item14;
            pointer->InstanceCustomIndex[14] = this.InstanceCustomIndex.Item15;
            pointer->InstanceCustomIndex[15] = this.InstanceCustomIndex.Item16;
            pointer->InstanceCustomIndex[16] = this.InstanceCustomIndex.Item17;
            pointer->InstanceCustomIndex[17] = this.InstanceCustomIndex.Item18;
            pointer->InstanceCustomIndex[18] = this.InstanceCustomIndex.Item19;
            pointer->InstanceCustomIndex[19] = this.InstanceCustomIndex.Item20;
            pointer->InstanceCustomIndex[20] = this.InstanceCustomIndex.Item21;
            pointer->InstanceCustomIndex[21] = this.InstanceCustomIndex.Item22;
            pointer->InstanceCustomIndex[22] = this.InstanceCustomIndex.Item23;
            pointer->InstanceCustomIndex[23] = this.InstanceCustomIndex.Item24;
            pointer->Mask[0] = this.Mask.Item1;
            pointer->Mask[1] = this.Mask.Item2;
            pointer->Mask[2] = this.Mask.Item3;
            pointer->Mask[3] = this.Mask.Item4;
            pointer->Mask[4] = this.Mask.Item5;
            pointer->Mask[5] = this.Mask.Item6;
            pointer->Mask[6] = this.Mask.Item7;
            pointer->Mask[7] = this.Mask.Item8;
            pointer->InstanceShaderBindingTableRecordOffset[0] = this.InstanceShaderBindingTableRecordOffset.Item1;
            pointer->InstanceShaderBindingTableRecordOffset[1] = this.InstanceShaderBindingTableRecordOffset.Item2;
            pointer->InstanceShaderBindingTableRecordOffset[2] = this.InstanceShaderBindingTableRecordOffset.Item3;
            pointer->InstanceShaderBindingTableRecordOffset[3] = this.InstanceShaderBindingTableRecordOffset.Item4;
            pointer->InstanceShaderBindingTableRecordOffset[4] = this.InstanceShaderBindingTableRecordOffset.Item5;
            pointer->InstanceShaderBindingTableRecordOffset[5] = this.InstanceShaderBindingTableRecordOffset.Item6;
            pointer->InstanceShaderBindingTableRecordOffset[6] = this.InstanceShaderBindingTableRecordOffset.Item7;
            pointer->InstanceShaderBindingTableRecordOffset[7] = this.InstanceShaderBindingTableRecordOffset.Item8;
            pointer->InstanceShaderBindingTableRecordOffset[8] = this.InstanceShaderBindingTableRecordOffset.Item9;
            pointer->InstanceShaderBindingTableRecordOffset[9] = this.InstanceShaderBindingTableRecordOffset.Item10;
            pointer->InstanceShaderBindingTableRecordOffset[10] = this.InstanceShaderBindingTableRecordOffset.Item11;
            pointer->InstanceShaderBindingTableRecordOffset[11] = this.InstanceShaderBindingTableRecordOffset.Item12;
            pointer->InstanceShaderBindingTableRecordOffset[12] = this.InstanceShaderBindingTableRecordOffset.Item13;
            pointer->InstanceShaderBindingTableRecordOffset[13] = this.InstanceShaderBindingTableRecordOffset.Item14;
            pointer->InstanceShaderBindingTableRecordOffset[14] = this.InstanceShaderBindingTableRecordOffset.Item15;
            pointer->InstanceShaderBindingTableRecordOffset[15] = this.InstanceShaderBindingTableRecordOffset.Item16;
            pointer->InstanceShaderBindingTableRecordOffset[16] = this.InstanceShaderBindingTableRecordOffset.Item17;
            pointer->InstanceShaderBindingTableRecordOffset[17] = this.InstanceShaderBindingTableRecordOffset.Item18;
            pointer->InstanceShaderBindingTableRecordOffset[18] = this.InstanceShaderBindingTableRecordOffset.Item19;
            pointer->InstanceShaderBindingTableRecordOffset[19] = this.InstanceShaderBindingTableRecordOffset.Item20;
            pointer->InstanceShaderBindingTableRecordOffset[20] = this.InstanceShaderBindingTableRecordOffset.Item21;
            pointer->InstanceShaderBindingTableRecordOffset[21] = this.InstanceShaderBindingTableRecordOffset.Item22;
            pointer->InstanceShaderBindingTableRecordOffset[22] = this.InstanceShaderBindingTableRecordOffset.Item23;
            pointer->InstanceShaderBindingTableRecordOffset[23] = this.InstanceShaderBindingTableRecordOffset.Item24;
            pointer->Flags_0 = this.Flags.Item1;
            pointer->Flags_1 = this.Flags.Item2;
            pointer->Flags_2 = this.Flags.Item3;
            pointer->Flags_3 = this.Flags.Item4;
            pointer->Flags_4 = this.Flags.Item5;
            pointer->Flags_5 = this.Flags.Item6;
            pointer->Flags_6 = this.Flags.Item7;
            pointer->Flags_7 = this.Flags.Item8;
            pointer->AccelerationStructureReference = this.AccelerationStructureReference;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe AccelerationStructureSRTMotionInstance MarshalFrom(SharpVk.Interop.NVidia.AccelerationStructureSRTMotionInstance* pointer)
        {
            AccelerationStructureSRTMotionInstance result = default(AccelerationStructureSRTMotionInstance);
            result.TransformT0 = pointer->TransformT0;
            result.TransformT1 = pointer->TransformT1;
            result.InstanceCustomIndex = (pointer->InstanceCustomIndex[0], pointer->InstanceCustomIndex[1], pointer->InstanceCustomIndex[2], pointer->InstanceCustomIndex[3], pointer->InstanceCustomIndex[4], pointer->InstanceCustomIndex[5], pointer->InstanceCustomIndex[6], pointer->InstanceCustomIndex[7], pointer->InstanceCustomIndex[8], pointer->InstanceCustomIndex[9], pointer->InstanceCustomIndex[10], pointer->InstanceCustomIndex[11], pointer->InstanceCustomIndex[12], pointer->InstanceCustomIndex[13], pointer->InstanceCustomIndex[14], pointer->InstanceCustomIndex[15], pointer->InstanceCustomIndex[16], pointer->InstanceCustomIndex[17], pointer->InstanceCustomIndex[18], pointer->InstanceCustomIndex[19], pointer->InstanceCustomIndex[20], pointer->InstanceCustomIndex[21], pointer->InstanceCustomIndex[22], pointer->InstanceCustomIndex[23]);
            result.Mask = (pointer->Mask[0], pointer->Mask[1], pointer->Mask[2], pointer->Mask[3], pointer->Mask[4], pointer->Mask[5], pointer->Mask[6], pointer->Mask[7]);
            result.InstanceShaderBindingTableRecordOffset = (pointer->InstanceShaderBindingTableRecordOffset[0], pointer->InstanceShaderBindingTableRecordOffset[1], pointer->InstanceShaderBindingTableRecordOffset[2], pointer->InstanceShaderBindingTableRecordOffset[3], pointer->InstanceShaderBindingTableRecordOffset[4], pointer->InstanceShaderBindingTableRecordOffset[5], pointer->InstanceShaderBindingTableRecordOffset[6], pointer->InstanceShaderBindingTableRecordOffset[7], pointer->InstanceShaderBindingTableRecordOffset[8], pointer->InstanceShaderBindingTableRecordOffset[9], pointer->InstanceShaderBindingTableRecordOffset[10], pointer->InstanceShaderBindingTableRecordOffset[11], pointer->InstanceShaderBindingTableRecordOffset[12], pointer->InstanceShaderBindingTableRecordOffset[13], pointer->InstanceShaderBindingTableRecordOffset[14], pointer->InstanceShaderBindingTableRecordOffset[15], pointer->InstanceShaderBindingTableRecordOffset[16], pointer->InstanceShaderBindingTableRecordOffset[17], pointer->InstanceShaderBindingTableRecordOffset[18], pointer->InstanceShaderBindingTableRecordOffset[19], pointer->InstanceShaderBindingTableRecordOffset[20], pointer->InstanceShaderBindingTableRecordOffset[21], pointer->InstanceShaderBindingTableRecordOffset[22], pointer->InstanceShaderBindingTableRecordOffset[23]);
            result.Flags = (pointer->Flags_0, pointer->Flags_1, pointer->Flags_2, pointer->Flags_3, pointer->Flags_4, pointer->Flags_5, pointer->Flags_6, pointer->Flags_7);
            result.AccelerationStructureReference = pointer->AccelerationStructureReference;
            return result;
        }
    }
}
