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
    public partial struct PartitionedAccelerationStructureWriteInstanceData
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.TransformMatrix Transform
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (float, float, float, float, float, float) ExplicitAABB
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint InstanceID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint InstanceMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint InstanceContributionToHitGroupIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.PartitionedAccelerationStructureInstanceFlags? InstanceFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint InstanceIndex
        {
            get;
            set;
        }
        
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
        public ulong AccelerationStructure
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.PartitionedAccelerationStructureWriteInstanceData* pointer)
        {
            this.Transform.MarshalTo(&pointer->Transform);
            pointer->ExplicitAABB[0] = this.ExplicitAABB.Item1;
            pointer->ExplicitAABB[1] = this.ExplicitAABB.Item2;
            pointer->ExplicitAABB[2] = this.ExplicitAABB.Item3;
            pointer->ExplicitAABB[3] = this.ExplicitAABB.Item4;
            pointer->ExplicitAABB[4] = this.ExplicitAABB.Item5;
            pointer->ExplicitAABB[5] = this.ExplicitAABB.Item6;
            pointer->InstanceID = this.InstanceID;
            pointer->InstanceMask = this.InstanceMask;
            pointer->InstanceContributionToHitGroupIndex = this.InstanceContributionToHitGroupIndex;
            if (this.InstanceFlags != null)
            {
                pointer->InstanceFlags = this.InstanceFlags.Value;
            }
            else
            {
                pointer->InstanceFlags = default(SharpVk.NVidia.PartitionedAccelerationStructureInstanceFlags);
            }
            pointer->InstanceIndex = this.InstanceIndex;
            pointer->PartitionIndex = this.PartitionIndex;
            pointer->AccelerationStructure = this.AccelerationStructure;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PartitionedAccelerationStructureWriteInstanceData MarshalFrom(SharpVk.Interop.NVidia.PartitionedAccelerationStructureWriteInstanceData* pointer)
        {
            PartitionedAccelerationStructureWriteInstanceData result = default(PartitionedAccelerationStructureWriteInstanceData);
            result.Transform = SharpVk.Khronos.TransformMatrix.MarshalFrom(&pointer->Transform);
            result.ExplicitAABB = (pointer->ExplicitAABB[0], pointer->ExplicitAABB[1], pointer->ExplicitAABB[2], pointer->ExplicitAABB[3], pointer->ExplicitAABB[4], pointer->ExplicitAABB[5]);
            result.InstanceID = pointer->InstanceID;
            result.InstanceMask = pointer->InstanceMask;
            result.InstanceContributionToHitGroupIndex = pointer->InstanceContributionToHitGroupIndex;
            result.InstanceFlags = pointer->InstanceFlags;
            result.InstanceIndex = pointer->InstanceIndex;
            result.PartitionIndex = pointer->PartitionIndex;
            result.AccelerationStructure = pointer->AccelerationStructure;
            return result;
        }
    }
}
