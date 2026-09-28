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

namespace SharpVk.Qcom
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PipelineCacheHeaderVersionDataGraph
    {
        /// <summary>
        /// 
        /// </summary>
        public uint HeaderSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineCacheHeaderVersion HeaderVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Qcom.DataGraphModelCacheType CacheType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Version CacheVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] ToolchainVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Qcom.PipelineCacheHeaderVersionDataGraph* pointer)
        {
            pointer->HeaderSize = this.HeaderSize;
            pointer->HeaderVersion = this.HeaderVersion;
            pointer->CacheType = this.CacheType;
            pointer->CacheVersion = (uint)(this.CacheVersion);
            Interop.HeapUtil.MarshalTo(this.ToolchainVersion, checked((int)Constants.DataGraphModelToolchainVersionLength), pointer->ToolchainVersion);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PipelineCacheHeaderVersionDataGraph MarshalFrom(SharpVk.Interop.Qcom.PipelineCacheHeaderVersionDataGraph* pointer)
        {
            PipelineCacheHeaderVersionDataGraph result = default(PipelineCacheHeaderVersionDataGraph);
            result.HeaderSize = pointer->HeaderSize;
            result.HeaderVersion = pointer->HeaderVersion;
            result.CacheType = pointer->CacheType;
            result.CacheVersion = (Version)(pointer->CacheVersion);
            result.ToolchainVersion = Interop.HeapUtil.MarshalFrom(pointer->ToolchainVersion, checked((int)Constants.DataGraphModelToolchainVersionLength));
            return result;
        }
    }
}
