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
    public partial struct PhysicalDeviceClusterAccelerationStructureProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVerticesPerCluster
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTrianglesPerCluster
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ClusterScratchByteAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ClusterByteAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ClusterTemplateByteAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ClusterBottomLevelByteAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ClusterTemplateBoundsByteAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxClusterGeometryIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceClusterAccelerationStructureProperties MarshalFrom(SharpVk.Interop.NVidia.PhysicalDeviceClusterAccelerationStructureProperties* pointer)
        {
            PhysicalDeviceClusterAccelerationStructureProperties result = default(PhysicalDeviceClusterAccelerationStructureProperties);
            result.MaxVerticesPerCluster = pointer->MaxVerticesPerCluster;
            result.MaxTrianglesPerCluster = pointer->MaxTrianglesPerCluster;
            result.ClusterScratchByteAlignment = pointer->ClusterScratchByteAlignment;
            result.ClusterByteAlignment = pointer->ClusterByteAlignment;
            result.ClusterTemplateByteAlignment = pointer->ClusterTemplateByteAlignment;
            result.ClusterBottomLevelByteAlignment = pointer->ClusterBottomLevelByteAlignment;
            result.ClusterTemplateBoundsByteAlignment = pointer->ClusterTemplateBoundsByteAlignment;
            result.MaxClusterGeometryIndex = pointer->MaxClusterGeometryIndex;
            return result;
        }
    }
}
