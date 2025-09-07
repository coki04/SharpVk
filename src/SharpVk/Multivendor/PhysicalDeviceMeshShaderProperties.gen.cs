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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceMeshShaderProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTaskWorkGroupTotalCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint) MaxTaskWorkGroupCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTaskWorkGroupInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint) MaxTaskWorkGroupSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTaskPayloadSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTaskSharedMemorySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTaskPayloadAndSharedMemorySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshWorkGroupTotalCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint) MaxMeshWorkGroupCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshWorkGroupInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint) MaxMeshWorkGroupSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshSharedMemorySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshPayloadAndSharedMemorySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshOutputMemorySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshPayloadAndOutputMemorySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshOutputVertices
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshOutputPrimitives
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshOutputLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshMultiviewViewCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MeshOutputPerVertexGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MeshOutputPerPrimitiveGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPreferredTaskWorkGroupInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPreferredMeshWorkGroupInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PrefersLocalInvocationVertexOutput
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PrefersLocalInvocationPrimitiveOutput
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PrefersCompactVertexOutput
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PrefersCompactPrimitiveOutput
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceMeshShaderProperties MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceMeshShaderProperties* pointer)
        {
            PhysicalDeviceMeshShaderProperties result = default(PhysicalDeviceMeshShaderProperties);
            result.MaxTaskWorkGroupTotalCount = pointer->MaxTaskWorkGroupTotalCount;
            result.MaxTaskWorkGroupCount = (pointer->MaxTaskWorkGroupCount[0], pointer->MaxTaskWorkGroupCount[1], pointer->MaxTaskWorkGroupCount[2]);
            result.MaxTaskWorkGroupInvocations = pointer->MaxTaskWorkGroupInvocations;
            result.MaxTaskWorkGroupSize = (pointer->MaxTaskWorkGroupSize[0], pointer->MaxTaskWorkGroupSize[1], pointer->MaxTaskWorkGroupSize[2]);
            result.MaxTaskPayloadSize = pointer->MaxTaskPayloadSize;
            result.MaxTaskSharedMemorySize = pointer->MaxTaskSharedMemorySize;
            result.MaxTaskPayloadAndSharedMemorySize = pointer->MaxTaskPayloadAndSharedMemorySize;
            result.MaxMeshWorkGroupTotalCount = pointer->MaxMeshWorkGroupTotalCount;
            result.MaxMeshWorkGroupCount = (pointer->MaxMeshWorkGroupCount[0], pointer->MaxMeshWorkGroupCount[1], pointer->MaxMeshWorkGroupCount[2]);
            result.MaxMeshWorkGroupInvocations = pointer->MaxMeshWorkGroupInvocations;
            result.MaxMeshWorkGroupSize = (pointer->MaxMeshWorkGroupSize[0], pointer->MaxMeshWorkGroupSize[1], pointer->MaxMeshWorkGroupSize[2]);
            result.MaxMeshSharedMemorySize = pointer->MaxMeshSharedMemorySize;
            result.MaxMeshPayloadAndSharedMemorySize = pointer->MaxMeshPayloadAndSharedMemorySize;
            result.MaxMeshOutputMemorySize = pointer->MaxMeshOutputMemorySize;
            result.MaxMeshPayloadAndOutputMemorySize = pointer->MaxMeshPayloadAndOutputMemorySize;
            result.MaxMeshOutputComponents = pointer->MaxMeshOutputComponents;
            result.MaxMeshOutputVertices = pointer->MaxMeshOutputVertices;
            result.MaxMeshOutputPrimitives = pointer->MaxMeshOutputPrimitives;
            result.MaxMeshOutputLayers = pointer->MaxMeshOutputLayers;
            result.MaxMeshMultiviewViewCount = pointer->MaxMeshMultiviewViewCount;
            result.MeshOutputPerVertexGranularity = pointer->MeshOutputPerVertexGranularity;
            result.MeshOutputPerPrimitiveGranularity = pointer->MeshOutputPerPrimitiveGranularity;
            result.MaxPreferredTaskWorkGroupInvocations = pointer->MaxPreferredTaskWorkGroupInvocations;
            result.MaxPreferredMeshWorkGroupInvocations = pointer->MaxPreferredMeshWorkGroupInvocations;
            result.PrefersLocalInvocationVertexOutput = pointer->PrefersLocalInvocationVertexOutput;
            result.PrefersLocalInvocationPrimitiveOutput = pointer->PrefersLocalInvocationPrimitiveOutput;
            result.PrefersCompactVertexOutput = pointer->PrefersCompactVertexOutput;
            result.PrefersCompactPrimitiveOutput = pointer->PrefersCompactPrimitiveOutput;
            return result;
        }
    }
}
