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

namespace SharpVk.Arm
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DataGraphPipelineShaderModuleCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderModule Module
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SpecializationInfo? SpecializationInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.DataGraphPipelineConstant[] Constants
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Arm.DataGraphPipelineShaderModuleCreateInfo* pointer)
        {
            pointer->SType = StructureType.DataGraphPipelineShaderModuleCreateInfo;
            pointer->Next = null;
            pointer->Module = this.Module?.handle ?? default(SharpVk.Interop.ShaderModule);
            pointer->Name = Interop.HeapUtil.MarshalTo(this.Name);
            if (this.SpecializationInfo != null)
            {
                pointer->SpecializationInfo = (SharpVk.Interop.SpecializationInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SpecializationInfo>());
                this.SpecializationInfo.Value.MarshalTo(pointer->SpecializationInfo);
            }
            else
            {
                pointer->SpecializationInfo = default(SharpVk.Interop.SpecializationInfo*);
            }
            pointer->ConstantCount = (uint)(Interop.HeapUtil.GetLength(this.Constants));
            if (this.Constants != null)
            {
                var fieldPointer = (SharpVk.Interop.Arm.DataGraphPipelineConstant*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Arm.DataGraphPipelineConstant>(this.Constants.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Constants.Length); index++)
                {
                    this.Constants[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Constants = fieldPointer;
            }
            else
            {
                pointer->Constants = null;
            }
        }
    }
}
