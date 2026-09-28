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
    public partial struct GeneratedCommandsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Pipeline Pipeline
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.IndirectCommandsLayout IndirectCommandsLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.IndirectCommandsStream[] Streams
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SequencesCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Buffer PreprocessBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong PreprocessOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong PreprocessSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Buffer SequencesCountBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong SequencesCountOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Buffer SequencesIndexBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong SequencesIndexOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.GeneratedCommandsInfo* pointer)
        {
            pointer->SType = StructureType.GeneratedCommandsInfoNv;
            pointer->Next = null;
            pointer->PipelineBindPoint = this.PipelineBindPoint;
            pointer->Pipeline = this.Pipeline?.handle ?? default(SharpVk.Interop.Pipeline);
            pointer->IndirectCommandsLayout = this.IndirectCommandsLayout?.handle ?? default(SharpVk.Interop.NVidia.IndirectCommandsLayout);
            pointer->StreamCount = (uint)(Interop.HeapUtil.GetLength(this.Streams));
            if (this.Streams != null)
            {
                var fieldPointer = (SharpVk.Interop.NVidia.IndirectCommandsStream*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.IndirectCommandsStream>(this.Streams.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Streams.Length); index++)
                {
                    this.Streams[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Streams = fieldPointer;
            }
            else
            {
                pointer->Streams = null;
            }
            pointer->SequencesCount = this.SequencesCount;
            pointer->PreprocessBuffer = this.PreprocessBuffer?.handle ?? default(SharpVk.Interop.Buffer);
            pointer->PreprocessOffset = this.PreprocessOffset;
            pointer->PreprocessSize = this.PreprocessSize;
            pointer->SequencesCountBuffer = this.SequencesCountBuffer?.handle ?? default(SharpVk.Interop.Buffer);
            pointer->SequencesCountOffset = this.SequencesCountOffset;
            pointer->SequencesIndexBuffer = this.SequencesIndexBuffer?.handle ?? default(SharpVk.Interop.Buffer);
            pointer->SequencesIndexOffset = this.SequencesIndexOffset;
        }
    }
}
