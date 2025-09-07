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
    public partial struct IndirectCommandsLayoutToken
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.IndirectCommandsTokenType TokenType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Stream
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint VertexBindingUnit
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool VertexDynamicStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineLayout PushconstantPipelineLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderStageFlags? PushconstantShaderStageFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PushconstantOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PushconstantSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.IndirectStateFlags? IndirectStateFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.IndexType[] IndexTypes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] IndexTypeValues
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.IndirectCommandsLayoutToken* pointer)
        {
            pointer->SType = StructureType.IndirectCommandsLayoutTokenNv;
            pointer->Next = null;
            pointer->TokenType = this.TokenType;
            pointer->Stream = this.Stream;
            pointer->Offset = this.Offset;
            pointer->VertexBindingUnit = this.VertexBindingUnit;
            pointer->VertexDynamicStride = this.VertexDynamicStride;
            pointer->PushconstantPipelineLayout = this.PushconstantPipelineLayout?.handle ?? default(SharpVk.Interop.PipelineLayout);
            if (this.PushconstantShaderStageFlags != null)
            {
                pointer->PushconstantShaderStageFlags = this.PushconstantShaderStageFlags.Value;
            }
            else
            {
                pointer->PushconstantShaderStageFlags = default(SharpVk.ShaderStageFlags);
            }
            pointer->PushconstantOffset = this.PushconstantOffset;
            pointer->PushconstantSize = this.PushconstantSize;
            if (this.IndirectStateFlags != null)
            {
                pointer->IndirectStateFlags = this.IndirectStateFlags.Value;
            }
            else
            {
                pointer->IndirectStateFlags = default(SharpVk.NVidia.IndirectStateFlags);
            }
            pointer->IndexTypeCount = (uint)(Interop.HeapUtil.GetLength(this.IndexTypes));
            if (this.IndexTypes != null)
            {
                var fieldPointer = (SharpVk.IndexType*)(Interop.HeapUtil.AllocateAndClear<SharpVk.IndexType>(this.IndexTypes.Length).ToPointer());
                for(int index = 0; index < (uint)(this.IndexTypes.Length); index++)
                {
                    fieldPointer[index] = this.IndexTypes[index];
                }
                pointer->IndexTypes = fieldPointer;
            }
            else
            {
                pointer->IndexTypes = null;
            }
            if (this.IndexTypeValues != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.IndexTypeValues.Length).ToPointer());
                for(int index = 0; index < (uint)(this.IndexTypeValues.Length); index++)
                {
                    fieldPointer[index] = this.IndexTypeValues[index];
                }
                pointer->IndexTypeValues = fieldPointer;
            }
            else
            {
                pointer->IndexTypeValues = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe IndirectCommandsLayoutToken MarshalFrom(SharpVk.Interop.NVidia.IndirectCommandsLayoutToken* pointer)
        {
            IndirectCommandsLayoutToken result = default(IndirectCommandsLayoutToken);
            result.TokenType = pointer->TokenType;
            result.Stream = pointer->Stream;
            result.Offset = pointer->Offset;
            result.VertexBindingUnit = pointer->VertexBindingUnit;
            result.VertexDynamicStride = pointer->VertexDynamicStride;
            result.PushconstantPipelineLayout = new SharpVk.PipelineLayout(default(SharpVk.Device), pointer->PushconstantPipelineLayout);
            result.PushconstantShaderStageFlags = pointer->PushconstantShaderStageFlags;
            result.PushconstantOffset = pointer->PushconstantOffset;
            result.PushconstantSize = pointer->PushconstantSize;
            result.IndirectStateFlags = pointer->IndirectStateFlags;
            if (pointer->IndexTypes != null)
            {
                var fieldPointer = new SharpVk.IndexType[(uint)(pointer->IndexTypeCount)];
                for(int index = 0; index < (uint)(pointer->IndexTypeCount); index++)
                {
                    fieldPointer[index] = pointer->IndexTypes[index];
                }
                result.IndexTypes = fieldPointer;
            }
            else
            {
                result.IndexTypes = null;
            }
            if (pointer->IndexTypeValues != null)
            {
                var fieldPointer = new uint[(uint)(pointer->IndexTypeCount)];
                for(int index = 0; index < (uint)(pointer->IndexTypeCount); index++)
                {
                    fieldPointer[index] = pointer->IndexTypeValues[index];
                }
                result.IndexTypeValues = fieldPointer;
            }
            else
            {
                result.IndexTypeValues = null;
            }
            return result;
        }
    }
}
