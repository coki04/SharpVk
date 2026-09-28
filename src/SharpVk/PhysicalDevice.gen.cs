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

namespace SharpVk
{
    /// <summary>
    /// Opaque handle to a physical device object.
    /// </summary>
    public partial class PhysicalDevice
    {
        internal readonly SharpVk.Interop.PhysicalDevice handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Instance parent; 
        
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDevice(SharpVk.Instance parent, SharpVk.Interop.PhysicalDevice handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.PhysicalDevice RawHandle => this.handle;
        
        /// <summary>
        /// Reports capabilities of a physical device.
        /// </summary>
        public unsafe SharpVk.PhysicalDeviceFeatures GetFeatures()
        {
            try
            {
                SharpVk.PhysicalDeviceFeatures result = default(SharpVk.PhysicalDeviceFeatures);
                SharpVk.Interop.PhysicalDeviceFeatures marshalledFeatures = default(SharpVk.Interop.PhysicalDeviceFeatures);
                SharpVk.Interop.VkPhysicalDeviceGetFeaturesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceFeatures;
                commandDelegate(this.handle, &marshalledFeatures);
                result = SharpVk.PhysicalDeviceFeatures.MarshalFrom(&marshalledFeatures);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Lists physical device's format capabilities.
        /// </summary>
        /// <param name="format">
        /// </param>
        public unsafe SharpVk.FormatProperties GetFormatProperties(SharpVk.Format format)
        {
            try
            {
                SharpVk.FormatProperties result = default(SharpVk.FormatProperties);
                SharpVk.FormatProperties marshalledFormatProperties = default(SharpVk.FormatProperties);
                SharpVk.Interop.VkPhysicalDeviceGetFormatPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceFormatProperties;
                commandDelegate(this.handle, format, &marshalledFormatProperties);
                result = marshalledFormatProperties;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Lists physical device's image format capabilities.
        /// </summary>
        /// <param name="format">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="tiling">
        /// </param>
        /// <param name="usage">
        /// </param>
        /// <param name="flags">
        /// </param>
        public unsafe SharpVk.ImageFormatProperties GetImageFormatProperties(SharpVk.Format format, SharpVk.ImageType type, SharpVk.ImageTiling tiling, SharpVk.ImageUsageFlags usage, SharpVk.ImageCreateFlags? flags = default(SharpVk.ImageCreateFlags?))
        {
            try
            {
                SharpVk.ImageFormatProperties result = default(SharpVk.ImageFormatProperties);
                SharpVk.ImageCreateFlags marshalledFlags = default(SharpVk.ImageCreateFlags);
                SharpVk.ImageFormatProperties marshalledImageFormatProperties = default(SharpVk.ImageFormatProperties);
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.ImageCreateFlags);
                }
                SharpVk.Interop.VkPhysicalDeviceGetImageFormatPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceImageFormatProperties;
                Result methodResult = commandDelegate(this.handle, format, type, tiling, usage, marshalledFlags, &marshalledImageFormatProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledImageFormatProperties;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Returns properties of a physical device.
        /// </summary>
        public unsafe SharpVk.PhysicalDeviceProperties GetProperties()
        {
            try
            {
                SharpVk.PhysicalDeviceProperties result = default(SharpVk.PhysicalDeviceProperties);
                SharpVk.Interop.PhysicalDeviceProperties marshalledProperties = default(SharpVk.Interop.PhysicalDeviceProperties);
                SharpVk.Interop.VkPhysicalDeviceGetPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceProperties;
                commandDelegate(this.handle, &marshalledProperties);
                result = SharpVk.PhysicalDeviceProperties.MarshalFrom(&marshalledProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Reports properties of the queues of the specified physical device.
        /// </summary>
        public unsafe SharpVk.QueueFamilyProperties[] GetQueueFamilyProperties()
        {
            try
            {
                SharpVk.QueueFamilyProperties[] result = default(SharpVk.QueueFamilyProperties[]);
                uint marshalledQueueFamilyPropertyCount = default(uint);
                SharpVk.QueueFamilyProperties* marshalledQueueFamilyProperties = default(SharpVk.QueueFamilyProperties*);
                SharpVk.Interop.VkPhysicalDeviceGetQueueFamilyPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceQueueFamilyProperties;
                commandDelegate(this.handle, &marshalledQueueFamilyPropertyCount, marshalledQueueFamilyProperties);
                marshalledQueueFamilyProperties = (SharpVk.QueueFamilyProperties*)(Interop.HeapUtil.Allocate<SharpVk.QueueFamilyProperties>((uint)(marshalledQueueFamilyPropertyCount)));
                commandDelegate(this.handle, &marshalledQueueFamilyPropertyCount, marshalledQueueFamilyProperties);
                if (marshalledQueueFamilyProperties != null)
                {
                    var fieldPointer = new SharpVk.QueueFamilyProperties[(uint)(marshalledQueueFamilyPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledQueueFamilyPropertyCount); index++)
                    {
                        fieldPointer[index] = marshalledQueueFamilyProperties[index];
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Reports memory information for the specified physical device.
        /// </summary>
        public unsafe SharpVk.PhysicalDeviceMemoryProperties GetMemoryProperties()
        {
            try
            {
                SharpVk.PhysicalDeviceMemoryProperties result = default(SharpVk.PhysicalDeviceMemoryProperties);
                SharpVk.Interop.PhysicalDeviceMemoryProperties marshalledMemoryProperties = default(SharpVk.Interop.PhysicalDeviceMemoryProperties);
                SharpVk.Interop.VkPhysicalDeviceGetMemoryPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceMemoryProperties;
                commandDelegate(this.handle, &marshalledMemoryProperties);
                result = SharpVk.PhysicalDeviceMemoryProperties.MarshalFrom(&marshalledMemoryProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new device instance.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="queueCreateInfos">
        /// </param>
        /// <param name="enabledLayerNames">
        /// ppEnabledLayerNames is deprecated and ignored.
        /// </param>
        /// <param name="enabledExtensionNames">
        /// An array of enabledExtensionCount strings containing the names of
        /// extensions to enable for the created device.
        /// </param>
        /// <param name="enabledFeatures">
        /// Null or a PhysicalDeviceFeatures structure that contains boolean
        /// indicators of all the features to be enabled.
        /// </param>
        /// <param name="applicationParametersExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExternalMemorySciBufFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDeviceGeneratedCommandsFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePushConstantBankFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDeviceGeneratedCommandsComputeFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="devicePrivateDataCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePrivateDataFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePrivateDataBaseHandleFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceClusterAccelerationStructureFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFeatures2">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVariablePointersFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExternalSciSyncFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExternalSciSync2FeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="deviceSemaphoreSciSyncPoolReservationCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMultiviewFeatures">
        /// Extension struct
        /// </param>
        /// <param name="deviceGroupDeviceCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePresentIdFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePresentId2FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePresentWaitFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePresentWait2FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePresentTimingFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevice16BitStorageFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderSubgroupExtendedTypesFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceSamplerYcbcrConversionFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceProtectedMemoryFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceBlendOperationAdvancedFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMultiDrawFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceInlineUniformBlockFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMaintenance4Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMaintenance5Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMaintenance6Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMaintenance7FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMaintenance8FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMaintenance9FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMaintenance11FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMaintenance10FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderDrawParametersFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderFloat16Int8Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceHostQueryResetFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceElapsedTimerQueryFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceGlobalPriorityQueryFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDeviceMemoryReportFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="deviceDeviceMemoryReportCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDescriptorIndexingFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceTimelineSemaphoreFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevice8BitStorageFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceConditionalRenderingFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVulkanMemoryModelFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderAtomicInt64Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderAtomicFloatFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderAtomicFloat2FeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVertexAttributeDivisorFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceASTCDecodeFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceTransformFeedbackFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRepresentativeFragmentTestFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExclusiveScissorFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCornerSampledImageFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceComputeShaderDerivativesFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderImageFootprintFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDedicatedAllocationImageAliasingFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCopyMemoryIndirectFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCopyMemoryIndirectFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMemoryDecompressionFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShadingRateImageFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceInvocationMaskFeaturesHuawei">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMeshShaderFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMeshShaderFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceAccelerationStructureFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRayTracingPipelineFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRayQueryFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRayTracingMaintenance1FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="deviceMemoryOverallocationCreateInfoAmd">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentDensityMapFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentDensityMap2FeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentDensityMapOffsetFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceScalarBlockLayoutFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceUniformBufferStandardLayoutFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDepthClipEnableFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMemoryPriorityFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePageableDeviceLocalMemoryFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceBufferDeviceAddressFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceBufferDeviceAddressFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImagelessFramebufferFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceTextureCompressionASTCHDRFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCooperativeMatrixFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceYcbcrImageArraysFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePresentBarrierFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePerformanceQueryFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="performanceQueryReservationInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCoverageReductionModeFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderIntegerFunctions2FeaturesIntel">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderClockFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceIndexTypeUint8Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderSMBuiltinsFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentShaderInterlockFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceSeparateDepthStencilLayoutsFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePrimitiveTopologyListRestartFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePipelineExecutablePropertiesFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderDemoteToHelperInvocationFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceTexelBufferAlignmentFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceSubgroupSizeControlFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceLineRasterizationFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePipelineCreationCacheControlFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVulkan11Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVulkan12Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVulkan13Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVulkan14Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCoherentMemoryFeaturesAmd">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceGpaFeaturesAmd">
        /// Extension struct
        /// </param>
        /// <param name="faultCallbackInfo">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCustomBorderColorFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceBorderColorSwizzleFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExtendedDynamicStateFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExtendedDynamicState2FeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExtendedDynamicState3FeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExtendedFlagsFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePartitionedAccelerationStructureFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDiagnosticsConfigFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="deviceDiagnosticsConfigCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceZeroInitializeWorkgroupMemoryFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderSubgroupUniformControlFlowFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRobustness2FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImageRobustnessFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePortabilitySubsetFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevice4444FormatsFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceSubpassShadingFeaturesHuawei">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceClusterCullingShaderFeaturesHuawei">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderImageAtomicInt64FeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentShadingRateFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderTerminateInvocationFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentShadingRateEnumsFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImage2DViewOf3DFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImageSlicedViewOf3DFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceLegacyVertexAttributesFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMutableDescriptorTypeFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDepthClipControlFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceZeroInitializeDeviceMemoryFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCustomResolveFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDeviceGeneratedCommandsFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDepthClampControlFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVertexInputDynamicStateFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExternalMemoryRDMAFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderRelaxedExtendedInstructionFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceColorWriteEnableFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceSynchronization2Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceUnifiedImageLayoutsFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceHostImageCopyFeatures">
        /// Extension struct
        /// </param>
        /// <param name="deviceObjectReservationCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVulkanSC10Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePrimitivesGeneratedQueryFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceLegacyDitheringFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMultisampledRenderToSingleSampledFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMultisampledRenderToSwapchainFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePipelineProtectedAccessFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVideoMaintenance1FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVideoMaintenance2FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVideoDecodeVP9FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVideoEncodeQuantizationMapFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVideoEncodeFeedback2FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVideoEncodeAV1FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceInheritedViewportScissorFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceYcbcr2Plane444FormatsFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceProvokingVertexFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVideoEncodeIntraRefreshFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDescriptorBufferFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderIntegerDotProductFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentShaderBarycentricFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderFmaFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRayTracingMotionBlurFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRayTracingValidationFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRayTracingLinearSweptSpheresFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRGBA10X6FormatsFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDynamicRenderingFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImageViewMinLodFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRasterizationOrderAttachmentAccessFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceLinearColorAttachmentFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceGraphicsPipelineLibraryFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePipelineBinaryFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="devicePipelineBinaryInternalCacheControlKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesArm">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDescriptorSetHostMappingFeaturesValve">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceNestedCommandBufferFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderModuleIdentifierFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImageCompressionControlFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImageCompressionControlSwapchainFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceSubpassMergeFeedbackFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceOpacityMicromapFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceOpacityMicromapFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDisplacementMicromapFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePipelinePropertiesFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAmd">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceNonSeamlessCubeMapFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePipelineRobustnessFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderMultipleWaitQueuesFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImageProcessingFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceTilePropertiesFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceAmigoProfilingFeaturesSec">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceAttachmentFeedbackLoopLayoutFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceAddressBindingReportFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceOpticalFlowFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFaultFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFaultFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePipelineLibraryGroupHandlesFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderCoreBuiltinsFeaturesArm">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFrameBoundaryFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDynamicRenderingUnusedAttachmentsFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceInternallySynchronizedQueuesFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceSwapchainMaintenance1FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDepthBiasControlFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRayTracingInvocationReorderFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRayTracingInvocationReorderFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExtendedSparseAddressSpaceFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMultiviewPerViewViewportsFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRayTracingPositionFetchFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMultiviewPerViewRenderAreasFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderObjectFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderTileImageFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExternalMemoryScreenBufferFeaturesQnx">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCooperativeMatrixFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCooperativeMatrixConversionFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderEnqueueFeaturesAmdx">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceAntiLagFeaturesAmd">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceTileMemoryHeapFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCubicClampFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceYcbcrDegammaFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCubicWeightsFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImageProcessing2FeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImageProcessing3FeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDescriptorPoolOverallocationFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePerStageDescriptorSetFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExternalFormatResolveFeaturesAndroid">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCudaKernelLaunchFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="deviceQueueShaderCoreControlCreateInfoArm">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceSchedulingControlsFeaturesArm">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRelaxedLineRasterizationFeaturesImg">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRenderPassStripedFeaturesArm">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePipelineOpacityMicromapFeaturesArm">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderMaximalReconvergenceFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderSubgroupRotateFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderExpectAssumeFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderFloatControls2Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDynamicRenderingLocalReadFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderQuadControlFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderAtomicFloat16VectorFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMapMemoryPlacedFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderBfloat16FeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRawAccessChainsFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCommandBufferInheritanceFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImageAlignmentControlFeaturesMesa">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderReplicatedCompositesFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePresentModeFifoLatestReadyFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCooperativeMatrix2FeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCooperativeMatrixDecodeVectorFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceHdrVividFeaturesHuawei">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVertexAttributeRobustnessFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDenseGeometryFormatFeaturesAmdx">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDepthClampZeroOneFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCooperativeVectorFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceTileShadingFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentDensityMapLayeredFeaturesValve">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePresentMeteringFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="externalComputeQueueDeviceCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderUniformBufferUnsizedArrayFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderMixedFloatDotProductFeaturesValve">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePrimitiveRestartIndexFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFormatPackFeaturesArm">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceThrottleHintFeaturesSec">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceTensorFeaturesArm">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDescriptorBufferTensorFeaturesArm">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderFloat8FeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDataGraphFeaturesArm">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePipelineCacheIncrementalModeFeaturesSec">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDataGraphModelFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderUntypedPointersFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVideoEncodeRgbConversionFeaturesValve">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShader64BitIndexingFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceQueuePerfHintFeaturesQcom">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePerformanceCountersByRegionFeaturesArm">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceComputeOccupancyPriorityFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderLongVectorFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceTextureCompressionASTC3DFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderSubgroupPartitionedFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderSplitBarrierFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDescriptorHeapFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderInstrumentationFeaturesArm">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDeviceAddressCommandsFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderConstantDataFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderAbortFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDataGraphOpticalFlowFeaturesArm">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImageTilingControlFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderOCPMicroscalingTypesFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCooperativeMatrixMaintenance1FeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceBufferDeviceAddressAllocationAlignmentFeaturesValve">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.Device CreateDevice(ArrayProxy<SharpVk.DeviceQueueCreateInfo>? queueCreateInfos, ArrayProxy<string>? enabledLayerNames, ArrayProxy<string>? enabledExtensionNames, SharpVk.DeviceCreateFlags? flags = default(SharpVk.DeviceCreateFlags?), SharpVk.PhysicalDeviceFeatures? enabledFeatures = default(SharpVk.PhysicalDeviceFeatures?), SharpVk.Multivendor.ApplicationParameters? applicationParametersExt = null, SharpVk.NVidia.PhysicalDeviceExternalMemorySciBufFeatures? physicalDeviceExternalMemorySciBufFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures? physicalDeviceDeviceGeneratedCommandsFeaturesNv = null, SharpVk.NVidia.PhysicalDevicePushConstantBankFeatures? physicalDevicePushConstantBankFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceDeviceGeneratedCommandsComputeFeatures? physicalDeviceDeviceGeneratedCommandsComputeFeaturesNv = null, SharpVk.DevicePrivateDataCreateInfo? devicePrivateDataCreateInfo = null, SharpVk.PhysicalDevicePrivateDataFeatures? physicalDevicePrivateDataFeatures = null, SharpVk.NVidia.PhysicalDevicePrivateDataBaseHandleFeatures? physicalDevicePrivateDataBaseHandleFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceClusterAccelerationStructureFeatures? physicalDeviceClusterAccelerationStructureFeaturesNv = null, SharpVk.PhysicalDeviceFeatures2? physicalDeviceFeatures2 = null, SharpVk.PhysicalDeviceVariablePointersFeatures? physicalDeviceVariablePointersFeatures = null, SharpVk.NVidia.PhysicalDeviceExternalSciSyncFeatures? physicalDeviceExternalSciSyncFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceExternalSciSync2Features? physicalDeviceExternalSciSync2FeaturesNv = null, SharpVk.NVidia.DeviceSemaphoreSciSyncPoolReservationCreateInfo? deviceSemaphoreSciSyncPoolReservationCreateInfoNv = null, SharpVk.PhysicalDeviceMultiviewFeatures? physicalDeviceMultiviewFeatures = null, SharpVk.DeviceGroupDeviceCreateInfo? deviceGroupDeviceCreateInfo = null, SharpVk.Khronos.PhysicalDevicePresentIdFeatures? physicalDevicePresentIdFeaturesKhr = null, SharpVk.Khronos.PhysicalDevicePresentId2Features? physicalDevicePresentId2FeaturesKhr = null, SharpVk.Khronos.PhysicalDevicePresentWaitFeatures? physicalDevicePresentWaitFeaturesKhr = null, SharpVk.Khronos.PhysicalDevicePresentWait2Features? physicalDevicePresentWait2FeaturesKhr = null, SharpVk.Multivendor.PhysicalDevicePresentTimingFeatures? physicalDevicePresentTimingFeaturesExt = null, SharpVk.PhysicalDevice16BitStorageFeatures? physicalDevice16BitStorageFeatures = null, SharpVk.PhysicalDeviceShaderSubgroupExtendedTypesFeatures? physicalDeviceShaderSubgroupExtendedTypesFeatures = null, SharpVk.PhysicalDeviceSamplerYcbcrConversionFeatures? physicalDeviceSamplerYcbcrConversionFeatures = null, SharpVk.PhysicalDeviceProtectedMemoryFeatures? physicalDeviceProtectedMemoryFeatures = null, SharpVk.Multivendor.PhysicalDeviceBlendOperationAdvancedFeatures? physicalDeviceBlendOperationAdvancedFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceMultiDrawFeatures? physicalDeviceMultiDrawFeaturesExt = null, SharpVk.PhysicalDeviceInlineUniformBlockFeatures? physicalDeviceInlineUniformBlockFeatures = null, SharpVk.PhysicalDeviceMaintenance4Features? physicalDeviceMaintenance4Features = null, SharpVk.PhysicalDeviceMaintenance5Features? physicalDeviceMaintenance5Features = null, SharpVk.PhysicalDeviceMaintenance6Features? physicalDeviceMaintenance6Features = null, SharpVk.Khronos.PhysicalDeviceMaintenance7Features? physicalDeviceMaintenance7FeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceMaintenance8Features? physicalDeviceMaintenance8FeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceMaintenance9Features? physicalDeviceMaintenance9FeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceMaintenance11Features? physicalDeviceMaintenance11FeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceMaintenance10Features? physicalDeviceMaintenance10FeaturesKhr = null, SharpVk.PhysicalDeviceShaderDrawParametersFeatures? physicalDeviceShaderDrawParametersFeatures = null, SharpVk.PhysicalDeviceShaderFloat16Int8Features? physicalDeviceShaderFloat16Int8Features = null, SharpVk.PhysicalDeviceHostQueryResetFeatures? physicalDeviceHostQueryResetFeatures = null, SharpVk.Qcom.PhysicalDeviceElapsedTimerQueryFeatures? physicalDeviceElapsedTimerQueryFeaturesQcom = null, SharpVk.PhysicalDeviceGlobalPriorityQueryFeatures? physicalDeviceGlobalPriorityQueryFeatures = null, SharpVk.Multivendor.PhysicalDeviceDeviceMemoryReportFeatures? physicalDeviceDeviceMemoryReportFeaturesExt = null, SharpVk.Multivendor.DeviceDeviceMemoryReportCreateInfo? deviceDeviceMemoryReportCreateInfoExt = null, SharpVk.PhysicalDeviceDescriptorIndexingFeatures? physicalDeviceDescriptorIndexingFeatures = null, SharpVk.PhysicalDeviceTimelineSemaphoreFeatures? physicalDeviceTimelineSemaphoreFeatures = null, SharpVk.PhysicalDevice8BitStorageFeatures? physicalDevice8BitStorageFeatures = null, SharpVk.Multivendor.PhysicalDeviceConditionalRenderingFeatures? physicalDeviceConditionalRenderingFeaturesExt = null, SharpVk.PhysicalDeviceVulkanMemoryModelFeatures? physicalDeviceVulkanMemoryModelFeatures = null, SharpVk.PhysicalDeviceShaderAtomicInt64Features? physicalDeviceShaderAtomicInt64Features = null, SharpVk.Multivendor.PhysicalDeviceShaderAtomicFloatFeatures? physicalDeviceShaderAtomicFloatFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceShaderAtomicFloat2Features? physicalDeviceShaderAtomicFloat2FeaturesExt = null, SharpVk.PhysicalDeviceVertexAttributeDivisorFeatures? physicalDeviceVertexAttributeDivisorFeatures = null, SharpVk.Multivendor.PhysicalDeviceASTCDecodeFeatures? physicalDeviceASTCDecodeFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceTransformFeedbackFeatures? physicalDeviceTransformFeedbackFeaturesExt = null, SharpVk.NVidia.PhysicalDeviceRepresentativeFragmentTestFeatures? physicalDeviceRepresentativeFragmentTestFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceExclusiveScissorFeatures? physicalDeviceExclusiveScissorFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceCornerSampledImageFeatures? physicalDeviceCornerSampledImageFeaturesNv = null, SharpVk.Khronos.PhysicalDeviceComputeShaderDerivativesFeatures? physicalDeviceComputeShaderDerivativesFeaturesKhr = null, SharpVk.NVidia.PhysicalDeviceShaderImageFootprintFeatures? physicalDeviceShaderImageFootprintFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceDedicatedAllocationImageAliasingFeatures? physicalDeviceDedicatedAllocationImageAliasingFeaturesNv = null, SharpVk.Khronos.PhysicalDeviceCopyMemoryIndirectFeatures? physicalDeviceCopyMemoryIndirectFeaturesKhr = null, SharpVk.NVidia.PhysicalDeviceCopyMemoryIndirectFeatures? physicalDeviceCopyMemoryIndirectFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceMemoryDecompressionFeatures? physicalDeviceMemoryDecompressionFeaturesExt = null, SharpVk.NVidia.PhysicalDeviceShadingRateImageFeatures? physicalDeviceShadingRateImageFeaturesNv = null, SharpVk.Huawei.PhysicalDeviceInvocationMaskFeatures? physicalDeviceInvocationMaskFeaturesHuawei = null, SharpVk.NVidia.PhysicalDeviceMeshShaderFeatures? physicalDeviceMeshShaderFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceMeshShaderFeatures? physicalDeviceMeshShaderFeaturesExt = null, SharpVk.Khronos.PhysicalDeviceAccelerationStructureFeatures? physicalDeviceAccelerationStructureFeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceRayTracingPipelineFeatures? physicalDeviceRayTracingPipelineFeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceRayQueryFeatures? physicalDeviceRayQueryFeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceRayTracingMaintenance1Features? physicalDeviceRayTracingMaintenance1FeaturesKhr = null, SharpVk.Amd.DeviceMemoryOverallocationCreateInfo? deviceMemoryOverallocationCreateInfoAmd = null, SharpVk.Multivendor.PhysicalDeviceFragmentDensityMapFeatures? physicalDeviceFragmentDensityMapFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceFragmentDensityMap2Features? physicalDeviceFragmentDensityMap2FeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceFragmentDensityMapOffsetFeatures? physicalDeviceFragmentDensityMapOffsetFeaturesExt = null, SharpVk.PhysicalDeviceScalarBlockLayoutFeatures? physicalDeviceScalarBlockLayoutFeatures = null, SharpVk.PhysicalDeviceUniformBufferStandardLayoutFeatures? physicalDeviceUniformBufferStandardLayoutFeatures = null, SharpVk.Multivendor.PhysicalDeviceDepthClipEnableFeatures? physicalDeviceDepthClipEnableFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceMemoryPriorityFeatures? physicalDeviceMemoryPriorityFeaturesExt = null, SharpVk.Multivendor.PhysicalDevicePageableDeviceLocalMemoryFeatures? physicalDevicePageableDeviceLocalMemoryFeaturesExt = null, SharpVk.PhysicalDeviceBufferDeviceAddressFeatures? physicalDeviceBufferDeviceAddressFeatures = null, SharpVk.Multivendor.PhysicalDeviceBufferDeviceAddressFeatures? physicalDeviceBufferDeviceAddressFeaturesExt = null, SharpVk.PhysicalDeviceImagelessFramebufferFeatures? physicalDeviceImagelessFramebufferFeatures = null, SharpVk.PhysicalDeviceTextureCompressionASTCHDRFeatures? physicalDeviceTextureCompressionASTCHDRFeatures = null, SharpVk.NVidia.PhysicalDeviceCooperativeMatrixFeatures? physicalDeviceCooperativeMatrixFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceYcbcrImageArraysFeatures? physicalDeviceYcbcrImageArraysFeaturesExt = null, SharpVk.NVidia.PhysicalDevicePresentBarrierFeatures? physicalDevicePresentBarrierFeaturesNv = null, SharpVk.Khronos.PhysicalDevicePerformanceQueryFeatures? physicalDevicePerformanceQueryFeaturesKhr = null, SharpVk.Khronos.PerformanceQueryReservationInfo? performanceQueryReservationInfoKhr = null, SharpVk.NVidia.PhysicalDeviceCoverageReductionModeFeatures? physicalDeviceCoverageReductionModeFeaturesNv = null, SharpVk.Intel.PhysicalDeviceShaderIntegerFunctions2Features? physicalDeviceShaderIntegerFunctions2FeaturesIntel = null, SharpVk.Khronos.PhysicalDeviceShaderClockFeatures? physicalDeviceShaderClockFeaturesKhr = null, SharpVk.PhysicalDeviceIndexTypeUint8Features? physicalDeviceIndexTypeUint8Features = null, SharpVk.NVidia.PhysicalDeviceShaderSMBuiltinsFeatures? physicalDeviceShaderSMBuiltinsFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceFragmentShaderInterlockFeatures? physicalDeviceFragmentShaderInterlockFeaturesExt = null, SharpVk.PhysicalDeviceSeparateDepthStencilLayoutsFeatures? physicalDeviceSeparateDepthStencilLayoutsFeatures = null, SharpVk.Multivendor.PhysicalDevicePrimitiveTopologyListRestartFeatures? physicalDevicePrimitiveTopologyListRestartFeaturesExt = null, SharpVk.Khronos.PhysicalDevicePipelineExecutablePropertiesFeatures? physicalDevicePipelineExecutablePropertiesFeaturesKhr = null, SharpVk.PhysicalDeviceShaderDemoteToHelperInvocationFeatures? physicalDeviceShaderDemoteToHelperInvocationFeatures = null, SharpVk.Multivendor.PhysicalDeviceTexelBufferAlignmentFeatures? physicalDeviceTexelBufferAlignmentFeaturesExt = null, SharpVk.PhysicalDeviceSubgroupSizeControlFeatures? physicalDeviceSubgroupSizeControlFeatures = null, SharpVk.PhysicalDeviceLineRasterizationFeatures? physicalDeviceLineRasterizationFeatures = null, SharpVk.PhysicalDevicePipelineCreationCacheControlFeatures? physicalDevicePipelineCreationCacheControlFeatures = null, SharpVk.PhysicalDeviceVulkan11Features? physicalDeviceVulkan11Features = null, SharpVk.PhysicalDeviceVulkan12Features? physicalDeviceVulkan12Features = null, SharpVk.PhysicalDeviceVulkan13Features? physicalDeviceVulkan13Features = null, SharpVk.PhysicalDeviceVulkan14Features? physicalDeviceVulkan14Features = null, SharpVk.Amd.PhysicalDeviceCoherentMemoryFeatures? physicalDeviceCoherentMemoryFeaturesAmd = null, SharpVk.Amd.PhysicalDeviceGpaFeatures? physicalDeviceGpaFeaturesAmd = null, SharpVk.FaultCallbackInfo? faultCallbackInfo = null, SharpVk.Multivendor.PhysicalDeviceCustomBorderColorFeatures? physicalDeviceCustomBorderColorFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceBorderColorSwizzleFeatures? physicalDeviceBorderColorSwizzleFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceExtendedDynamicStateFeatures? physicalDeviceExtendedDynamicStateFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceExtendedDynamicState2Features? physicalDeviceExtendedDynamicState2FeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceExtendedDynamicState3Features? physicalDeviceExtendedDynamicState3FeaturesExt = null, SharpVk.Khronos.PhysicalDeviceExtendedFlagsFeatures? physicalDeviceExtendedFlagsFeaturesKhr = null, SharpVk.NVidia.PhysicalDevicePartitionedAccelerationStructureFeatures? physicalDevicePartitionedAccelerationStructureFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceDiagnosticsConfigFeatures? physicalDeviceDiagnosticsConfigFeaturesNv = null, SharpVk.NVidia.DeviceDiagnosticsConfigCreateInfo? deviceDiagnosticsConfigCreateInfoNv = null, SharpVk.PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures? physicalDeviceZeroInitializeWorkgroupMemoryFeatures = null, SharpVk.Khronos.PhysicalDeviceShaderSubgroupUniformControlFlowFeatures? physicalDeviceShaderSubgroupUniformControlFlowFeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceRobustness2Features? physicalDeviceRobustness2FeaturesKhr = null, SharpVk.PhysicalDeviceImageRobustnessFeatures? physicalDeviceImageRobustnessFeatures = null, SharpVk.Khronos.PhysicalDeviceWorkgroupMemoryExplicitLayoutFeatures? physicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKhr = null, SharpVk.Khronos.PhysicalDevicePortabilitySubsetFeatures? physicalDevicePortabilitySubsetFeaturesKhr = null, SharpVk.Multivendor.PhysicalDevice4444FormatsFeatures? physicalDevice4444FormatsFeaturesExt = null, SharpVk.Huawei.PhysicalDeviceSubpassShadingFeatures? physicalDeviceSubpassShadingFeaturesHuawei = null, SharpVk.Huawei.PhysicalDeviceClusterCullingShaderFeatures? physicalDeviceClusterCullingShaderFeaturesHuawei = null, SharpVk.Multivendor.PhysicalDeviceShaderImageAtomicInt64Features? physicalDeviceShaderImageAtomicInt64FeaturesExt = null, SharpVk.Khronos.PhysicalDeviceFragmentShadingRateFeatures? physicalDeviceFragmentShadingRateFeaturesKhr = null, SharpVk.PhysicalDeviceShaderTerminateInvocationFeatures? physicalDeviceShaderTerminateInvocationFeatures = null, SharpVk.NVidia.PhysicalDeviceFragmentShadingRateEnumsFeatures? physicalDeviceFragmentShadingRateEnumsFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceImage2DViewOf3DFeatures? physicalDeviceImage2DViewOf3DFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceImageSlicedViewOf3DFeatures? physicalDeviceImageSlicedViewOf3DFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeatures? physicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceLegacyVertexAttributesFeatures? physicalDeviceLegacyVertexAttributesFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceMutableDescriptorTypeFeatures? physicalDeviceMutableDescriptorTypeFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceDepthClipControlFeatures? physicalDeviceDepthClipControlFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceZeroInitializeDeviceMemoryFeatures? physicalDeviceZeroInitializeDeviceMemoryFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceCustomResolveFeatures? physicalDeviceCustomResolveFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceDeviceGeneratedCommandsFeatures? physicalDeviceDeviceGeneratedCommandsFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceDepthClampControlFeatures? physicalDeviceDepthClampControlFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceVertexInputDynamicStateFeatures? physicalDeviceVertexInputDynamicStateFeaturesExt = null, SharpVk.NVidia.PhysicalDeviceExternalMemoryRDMAFeatures? physicalDeviceExternalMemoryRDMAFeaturesNv = null, SharpVk.Khronos.PhysicalDeviceShaderRelaxedExtendedInstructionFeatures? physicalDeviceShaderRelaxedExtendedInstructionFeaturesKhr = null, SharpVk.Multivendor.PhysicalDeviceColorWriteEnableFeatures? physicalDeviceColorWriteEnableFeaturesExt = null, SharpVk.PhysicalDeviceSynchronization2Features? physicalDeviceSynchronization2Features = null, SharpVk.Khronos.PhysicalDeviceUnifiedImageLayoutsFeatures? physicalDeviceUnifiedImageLayoutsFeaturesKhr = null, SharpVk.PhysicalDeviceHostImageCopyFeatures? physicalDeviceHostImageCopyFeatures = null, SharpVk.DeviceObjectReservationCreateInfo? deviceObjectReservationCreateInfo = null, SharpVk.PhysicalDeviceVulkanSC10Features? physicalDeviceVulkanSC10Features = null, SharpVk.Multivendor.PhysicalDevicePrimitivesGeneratedQueryFeatures? physicalDevicePrimitivesGeneratedQueryFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceLegacyDitheringFeatures? physicalDeviceLegacyDitheringFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceMultisampledRenderToSingleSampledFeatures? physicalDeviceMultisampledRenderToSingleSampledFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceMultisampledRenderToSwapchainFeatures? physicalDeviceMultisampledRenderToSwapchainFeaturesExt = null, SharpVk.PhysicalDevicePipelineProtectedAccessFeatures? physicalDevicePipelineProtectedAccessFeatures = null, SharpVk.Khronos.PhysicalDeviceVideoMaintenance1Features? physicalDeviceVideoMaintenance1FeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceVideoMaintenance2Features? physicalDeviceVideoMaintenance2FeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceVideoDecodeVP9Features? physicalDeviceVideoDecodeVP9FeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceVideoEncodeQuantizationMapFeatures? physicalDeviceVideoEncodeQuantizationMapFeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceVideoEncodeFeedback2Features? physicalDeviceVideoEncodeFeedback2FeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceVideoEncodeAV1Features? physicalDeviceVideoEncodeAV1FeaturesKhr = null, SharpVk.NVidia.PhysicalDeviceInheritedViewportScissorFeatures? physicalDeviceInheritedViewportScissorFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceYcbcr2Plane444FormatsFeatures? physicalDeviceYcbcr2Plane444FormatsFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceProvokingVertexFeatures? physicalDeviceProvokingVertexFeaturesExt = null, SharpVk.Khronos.PhysicalDeviceVideoEncodeIntraRefreshFeatures? physicalDeviceVideoEncodeIntraRefreshFeaturesKhr = null, SharpVk.Multivendor.PhysicalDeviceDescriptorBufferFeatures? physicalDeviceDescriptorBufferFeaturesExt = null, SharpVk.PhysicalDeviceShaderIntegerDotProductFeatures? physicalDeviceShaderIntegerDotProductFeatures = null, SharpVk.Khronos.PhysicalDeviceFragmentShaderBarycentricFeatures? physicalDeviceFragmentShaderBarycentricFeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceShaderFmaFeatures? physicalDeviceShaderFmaFeaturesKhr = null, SharpVk.NVidia.PhysicalDeviceRayTracingMotionBlurFeatures? physicalDeviceRayTracingMotionBlurFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceRayTracingValidationFeatures? physicalDeviceRayTracingValidationFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceRayTracingLinearSweptSpheresFeatures? physicalDeviceRayTracingLinearSweptSpheresFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceRGBA10X6FormatsFeatures? physicalDeviceRGBA10X6FormatsFeaturesExt = null, SharpVk.PhysicalDeviceDynamicRenderingFeatures? physicalDeviceDynamicRenderingFeatures = null, SharpVk.Multivendor.PhysicalDeviceImageViewMinLodFeatures? physicalDeviceImageViewMinLodFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceRasterizationOrderAttachmentAccessFeatures? physicalDeviceRasterizationOrderAttachmentAccessFeaturesExt = null, SharpVk.NVidia.PhysicalDeviceLinearColorAttachmentFeatures? physicalDeviceLinearColorAttachmentFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceGraphicsPipelineLibraryFeatures? physicalDeviceGraphicsPipelineLibraryFeaturesExt = null, SharpVk.Khronos.PhysicalDevicePipelineBinaryFeatures? physicalDevicePipelineBinaryFeaturesKhr = null, SharpVk.Khronos.DevicePipelineBinaryInternalCacheControl? devicePipelineBinaryInternalCacheControlKhr = null, SharpVk.Arm.PhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeatures? physicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesArm = null, SharpVk.Valve.PhysicalDeviceDescriptorSetHostMappingFeatures? physicalDeviceDescriptorSetHostMappingFeaturesValve = null, SharpVk.Multivendor.PhysicalDeviceNestedCommandBufferFeatures? physicalDeviceNestedCommandBufferFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceShaderModuleIdentifierFeatures? physicalDeviceShaderModuleIdentifierFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceImageCompressionControlFeatures? physicalDeviceImageCompressionControlFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceImageCompressionControlSwapchainFeatures? physicalDeviceImageCompressionControlSwapchainFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceSubpassMergeFeedbackFeatures? physicalDeviceSubpassMergeFeedbackFeaturesExt = null, SharpVk.Khronos.PhysicalDeviceOpacityMicromapFeatures? physicalDeviceOpacityMicromapFeaturesKhr = null, SharpVk.Multivendor.PhysicalDeviceOpacityMicromapFeatures? physicalDeviceOpacityMicromapFeaturesExt = null, SharpVk.NVidia.PhysicalDeviceDisplacementMicromapFeatures? physicalDeviceDisplacementMicromapFeaturesNv = null, SharpVk.Multivendor.PhysicalDevicePipelinePropertiesFeatures? physicalDevicePipelinePropertiesFeaturesExt = null, SharpVk.Amd.PhysicalDeviceShaderEarlyAndLateFragmentTestsFeatures? physicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAmd = null, SharpVk.Multivendor.PhysicalDeviceNonSeamlessCubeMapFeatures? physicalDeviceNonSeamlessCubeMapFeaturesExt = null, SharpVk.PhysicalDevicePipelineRobustnessFeatures? physicalDevicePipelineRobustnessFeatures = null, SharpVk.Qcom.PhysicalDeviceShaderMultipleWaitQueuesFeatures? physicalDeviceShaderMultipleWaitQueuesFeaturesQcom = null, SharpVk.Qcom.PhysicalDeviceImageProcessingFeatures? physicalDeviceImageProcessingFeaturesQcom = null, SharpVk.Qcom.PhysicalDeviceTilePropertiesFeatures? physicalDeviceTilePropertiesFeaturesQcom = null, SharpVk.Sec.PhysicalDeviceAmigoProfilingFeatures? physicalDeviceAmigoProfilingFeaturesSec = null, SharpVk.Multivendor.PhysicalDeviceAttachmentFeedbackLoopLayoutFeatures? physicalDeviceAttachmentFeedbackLoopLayoutFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceAddressBindingReportFeatures? physicalDeviceAddressBindingReportFeaturesExt = null, SharpVk.NVidia.PhysicalDeviceOpticalFlowFeatures? physicalDeviceOpticalFlowFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceFaultFeatures? physicalDeviceFaultFeaturesExt = null, SharpVk.Khronos.PhysicalDeviceFaultFeatures? physicalDeviceFaultFeaturesKhr = null, SharpVk.Khronos.PhysicalDevicePipelineLibraryGroupHandlesFeatures? physicalDevicePipelineLibraryGroupHandlesFeaturesKhr = null, SharpVk.Arm.PhysicalDeviceShaderCoreBuiltinsFeatures? physicalDeviceShaderCoreBuiltinsFeaturesArm = null, SharpVk.Multivendor.PhysicalDeviceFrameBoundaryFeatures? physicalDeviceFrameBoundaryFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceDynamicRenderingUnusedAttachmentsFeatures? physicalDeviceDynamicRenderingUnusedAttachmentsFeaturesExt = null, SharpVk.Khronos.PhysicalDeviceInternallySynchronizedQueuesFeatures? physicalDeviceInternallySynchronizedQueuesFeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceSwapchainMaintenance1Features? physicalDeviceSwapchainMaintenance1FeaturesKhr = null, SharpVk.Multivendor.PhysicalDeviceDepthBiasControlFeatures? physicalDeviceDepthBiasControlFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceRayTracingInvocationReorderFeatures? physicalDeviceRayTracingInvocationReorderFeaturesExt = null, SharpVk.NVidia.PhysicalDeviceRayTracingInvocationReorderFeatures? physicalDeviceRayTracingInvocationReorderFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceExtendedSparseAddressSpaceFeatures? physicalDeviceExtendedSparseAddressSpaceFeaturesNv = null, SharpVk.Qcom.PhysicalDeviceMultiviewPerViewViewportsFeatures? physicalDeviceMultiviewPerViewViewportsFeaturesQcom = null, SharpVk.Khronos.PhysicalDeviceRayTracingPositionFetchFeatures? physicalDeviceRayTracingPositionFetchFeaturesKhr = null, SharpVk.Qcom.PhysicalDeviceMultiviewPerViewRenderAreasFeatures? physicalDeviceMultiviewPerViewRenderAreasFeaturesQcom = null, SharpVk.Multivendor.PhysicalDeviceShaderObjectFeatures? physicalDeviceShaderObjectFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceShaderTileImageFeatures? physicalDeviceShaderTileImageFeaturesExt = null, SharpVk.Qnx.PhysicalDeviceExternalMemoryScreenBufferFeatures? physicalDeviceExternalMemoryScreenBufferFeaturesQnx = null, SharpVk.Khronos.PhysicalDeviceCooperativeMatrixFeatures? physicalDeviceCooperativeMatrixFeaturesKhr = null, SharpVk.Qcom.PhysicalDeviceCooperativeMatrixConversionFeatures? physicalDeviceCooperativeMatrixConversionFeaturesQcom = null, SharpVk.Amdx.PhysicalDeviceShaderEnqueueFeatures? physicalDeviceShaderEnqueueFeaturesAmdx = null, SharpVk.Amd.PhysicalDeviceAntiLagFeatures? physicalDeviceAntiLagFeaturesAmd = null, SharpVk.Qcom.PhysicalDeviceTileMemoryHeapFeatures? physicalDeviceTileMemoryHeapFeaturesQcom = null, SharpVk.Qcom.PhysicalDeviceCubicClampFeatures? physicalDeviceCubicClampFeaturesQcom = null, SharpVk.Qcom.PhysicalDeviceYcbcrDegammaFeatures? physicalDeviceYcbcrDegammaFeaturesQcom = null, SharpVk.Qcom.PhysicalDeviceCubicWeightsFeatures? physicalDeviceCubicWeightsFeaturesQcom = null, SharpVk.Qcom.PhysicalDeviceImageProcessing2Features? physicalDeviceImageProcessing2FeaturesQcom = null, SharpVk.Qcom.PhysicalDeviceImageProcessing3Features? physicalDeviceImageProcessing3FeaturesQcom = null, SharpVk.NVidia.PhysicalDeviceDescriptorPoolOverallocationFeatures? physicalDeviceDescriptorPoolOverallocationFeaturesNv = null, SharpVk.NVidia.PhysicalDevicePerStageDescriptorSetFeatures? physicalDevicePerStageDescriptorSetFeaturesNv = null, SharpVk.Android.PhysicalDeviceExternalFormatResolveFeatures? physicalDeviceExternalFormatResolveFeaturesAndroid = null, SharpVk.NVidia.PhysicalDeviceCudaKernelLaunchFeatures? physicalDeviceCudaKernelLaunchFeaturesNv = null, SharpVk.Arm.DeviceQueueShaderCoreControlCreateInfo? deviceQueueShaderCoreControlCreateInfoArm = null, SharpVk.Arm.PhysicalDeviceSchedulingControlsFeatures? physicalDeviceSchedulingControlsFeaturesArm = null, SharpVk.Img.PhysicalDeviceRelaxedLineRasterizationFeatures? physicalDeviceRelaxedLineRasterizationFeaturesImg = null, SharpVk.Arm.PhysicalDeviceRenderPassStripedFeatures? physicalDeviceRenderPassStripedFeaturesArm = null, SharpVk.Arm.PhysicalDevicePipelineOpacityMicromapFeatures? physicalDevicePipelineOpacityMicromapFeaturesArm = null, SharpVk.Khronos.PhysicalDeviceShaderMaximalReconvergenceFeatures? physicalDeviceShaderMaximalReconvergenceFeaturesKhr = null, SharpVk.PhysicalDeviceShaderSubgroupRotateFeatures? physicalDeviceShaderSubgroupRotateFeatures = null, SharpVk.PhysicalDeviceShaderExpectAssumeFeatures? physicalDeviceShaderExpectAssumeFeatures = null, SharpVk.PhysicalDeviceShaderFloatControls2Features? physicalDeviceShaderFloatControls2Features = null, SharpVk.PhysicalDeviceDynamicRenderingLocalReadFeatures? physicalDeviceDynamicRenderingLocalReadFeatures = null, SharpVk.Khronos.PhysicalDeviceShaderQuadControlFeatures? physicalDeviceShaderQuadControlFeaturesKhr = null, SharpVk.NVidia.PhysicalDeviceShaderAtomicFloat16VectorFeatures? physicalDeviceShaderAtomicFloat16VectorFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceMapMemoryPlacedFeatures? physicalDeviceMapMemoryPlacedFeaturesExt = null, SharpVk.Khronos.PhysicalDeviceShaderBfloat16Features? physicalDeviceShaderBfloat16FeaturesKhr = null, SharpVk.NVidia.PhysicalDeviceRawAccessChainsFeatures? physicalDeviceRawAccessChainsFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceCommandBufferInheritanceFeatures? physicalDeviceCommandBufferInheritanceFeaturesNv = null, SharpVk.Mesa.PhysicalDeviceImageAlignmentControlFeatures? physicalDeviceImageAlignmentControlFeaturesMesa = null, SharpVk.Multivendor.PhysicalDeviceShaderReplicatedCompositesFeatures? physicalDeviceShaderReplicatedCompositesFeaturesExt = null, SharpVk.Khronos.PhysicalDevicePresentModeFifoLatestReadyFeatures? physicalDevicePresentModeFifoLatestReadyFeaturesKhr = null, SharpVk.NVidia.PhysicalDeviceCooperativeMatrix2Features? physicalDeviceCooperativeMatrix2FeaturesNv = null, SharpVk.NVidia.PhysicalDeviceCooperativeMatrixDecodeVectorFeatures? physicalDeviceCooperativeMatrixDecodeVectorFeaturesNv = null, SharpVk.Huawei.PhysicalDeviceHdrVividFeatures? physicalDeviceHdrVividFeaturesHuawei = null, SharpVk.Multivendor.PhysicalDeviceVertexAttributeRobustnessFeatures? physicalDeviceVertexAttributeRobustnessFeaturesExt = null, SharpVk.Amdx.PhysicalDeviceDenseGeometryFormatFeatures? physicalDeviceDenseGeometryFormatFeaturesAmdx = null, SharpVk.Khronos.PhysicalDeviceDepthClampZeroOneFeatures? physicalDeviceDepthClampZeroOneFeaturesKhr = null, SharpVk.NVidia.PhysicalDeviceCooperativeVectorFeatures? physicalDeviceCooperativeVectorFeaturesNv = null, SharpVk.Qcom.PhysicalDeviceTileShadingFeatures? physicalDeviceTileShadingFeaturesQcom = null, SharpVk.Valve.PhysicalDeviceFragmentDensityMapLayeredFeatures? physicalDeviceFragmentDensityMapLayeredFeaturesValve = null, SharpVk.NVidia.PhysicalDevicePresentMeteringFeatures? physicalDevicePresentMeteringFeaturesNv = null, SharpVk.NVidia.ExternalComputeQueueDeviceCreateInfo? externalComputeQueueDeviceCreateInfoNv = null, SharpVk.Multivendor.PhysicalDeviceShaderUniformBufferUnsizedArrayFeatures? physicalDeviceShaderUniformBufferUnsizedArrayFeaturesExt = null, SharpVk.Valve.PhysicalDeviceShaderMixedFloatDotProductFeatures? physicalDeviceShaderMixedFloatDotProductFeaturesValve = null, SharpVk.Multivendor.PhysicalDevicePrimitiveRestartIndexFeatures? physicalDevicePrimitiveRestartIndexFeaturesExt = null, SharpVk.Arm.PhysicalDeviceFormatPackFeatures? physicalDeviceFormatPackFeaturesArm = null, SharpVk.Sec.PhysicalDeviceThrottleHintFeatures? physicalDeviceThrottleHintFeaturesSec = null, SharpVk.Arm.PhysicalDeviceTensorFeatures? physicalDeviceTensorFeaturesArm = null, SharpVk.Arm.PhysicalDeviceDescriptorBufferTensorFeatures? physicalDeviceDescriptorBufferTensorFeaturesArm = null, SharpVk.Multivendor.PhysicalDeviceShaderFloat8Features? physicalDeviceShaderFloat8FeaturesExt = null, SharpVk.Arm.PhysicalDeviceDataGraphFeatures? physicalDeviceDataGraphFeaturesArm = null, SharpVk.Sec.PhysicalDevicePipelineCacheIncrementalModeFeatures? physicalDevicePipelineCacheIncrementalModeFeaturesSec = null, SharpVk.Qcom.PhysicalDeviceDataGraphModelFeatures? physicalDeviceDataGraphModelFeaturesQcom = null, SharpVk.Khronos.PhysicalDeviceShaderUntypedPointersFeatures? physicalDeviceShaderUntypedPointersFeaturesKhr = null, SharpVk.Valve.PhysicalDeviceVideoEncodeRgbConversionFeatures? physicalDeviceVideoEncodeRgbConversionFeaturesValve = null, SharpVk.Multivendor.PhysicalDeviceShader64BitIndexingFeatures? physicalDeviceShader64BitIndexingFeaturesExt = null, SharpVk.Qcom.PhysicalDeviceQueuePerfHintFeatures? physicalDeviceQueuePerfHintFeaturesQcom = null, SharpVk.Arm.PhysicalDevicePerformanceCountersByRegionFeatures? physicalDevicePerformanceCountersByRegionFeaturesArm = null, SharpVk.NVidia.PhysicalDeviceComputeOccupancyPriorityFeatures? physicalDeviceComputeOccupancyPriorityFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceShaderLongVectorFeatures? physicalDeviceShaderLongVectorFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceTextureCompressionASTC3DFeatures? physicalDeviceTextureCompressionASTC3DFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceShaderSubgroupPartitionedFeatures? physicalDeviceShaderSubgroupPartitionedFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceShaderSplitBarrierFeatures? physicalDeviceShaderSplitBarrierFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceDescriptorHeapFeatures? physicalDeviceDescriptorHeapFeaturesExt = null, SharpVk.Arm.PhysicalDeviceShaderInstrumentationFeatures? physicalDeviceShaderInstrumentationFeaturesArm = null, SharpVk.Khronos.PhysicalDeviceDeviceAddressCommandsFeatures? physicalDeviceDeviceAddressCommandsFeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceShaderConstantDataFeatures? physicalDeviceShaderConstantDataFeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceShaderAbortFeatures? physicalDeviceShaderAbortFeaturesKhr = null, SharpVk.Arm.PhysicalDeviceDataGraphOpticalFlowFeatures? physicalDeviceDataGraphOpticalFlowFeaturesArm = null, SharpVk.Multivendor.PhysicalDeviceImageTilingControlFeatures? physicalDeviceImageTilingControlFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceShaderOCPMicroscalingTypesFeatures? physicalDeviceShaderOCPMicroscalingTypesFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceCooperativeMatrixMaintenance1Features? physicalDeviceCooperativeMatrixMaintenance1FeaturesExt = null, SharpVk.Valve.PhysicalDeviceBufferDeviceAddressAllocationAlignmentFeatures? physicalDeviceBufferDeviceAddressAllocationAlignmentFeaturesValve = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Device result = default(SharpVk.Device);
                SharpVk.Interop.DeviceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.DeviceCreateInfo*);
                void* vkDeviceCreateInfoNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Device marshalledDevice = default(SharpVk.Interop.Device);
                if (applicationParametersExt != null)
                {
                    SharpVk.Interop.Multivendor.ApplicationParameters* extensionPointer = default(SharpVk.Interop.Multivendor.ApplicationParameters*);
                    extensionPointer = (SharpVk.Interop.Multivendor.ApplicationParameters*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ApplicationParameters>());
                    applicationParametersExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExternalMemorySciBufFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceExternalMemorySciBufFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceExternalMemorySciBufFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceExternalMemorySciBufFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceExternalMemorySciBufFeatures>());
                    physicalDeviceExternalMemorySciBufFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDeviceGeneratedCommandsFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures>());
                    physicalDeviceDeviceGeneratedCommandsFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePushConstantBankFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDevicePushConstantBankFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDevicePushConstantBankFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDevicePushConstantBankFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDevicePushConstantBankFeatures>());
                    physicalDevicePushConstantBankFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDeviceGeneratedCommandsComputeFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsComputeFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsComputeFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsComputeFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsComputeFeatures>());
                    physicalDeviceDeviceGeneratedCommandsComputeFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (devicePrivateDataCreateInfo != null)
                {
                    SharpVk.Interop.DevicePrivateDataCreateInfo* extensionPointer = default(SharpVk.Interop.DevicePrivateDataCreateInfo*);
                    extensionPointer = (SharpVk.Interop.DevicePrivateDataCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DevicePrivateDataCreateInfo>());
                    devicePrivateDataCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePrivateDataFeatures != null)
                {
                    SharpVk.Interop.PhysicalDevicePrivateDataFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDevicePrivateDataFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDevicePrivateDataFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDevicePrivateDataFeatures>());
                    physicalDevicePrivateDataFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePrivateDataBaseHandleFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDevicePrivateDataBaseHandleFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDevicePrivateDataBaseHandleFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDevicePrivateDataBaseHandleFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDevicePrivateDataBaseHandleFeatures>());
                    physicalDevicePrivateDataBaseHandleFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceClusterAccelerationStructureFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceClusterAccelerationStructureFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceClusterAccelerationStructureFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceClusterAccelerationStructureFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceClusterAccelerationStructureFeatures>());
                    physicalDeviceClusterAccelerationStructureFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFeatures2 != null)
                {
                    SharpVk.Interop.PhysicalDeviceFeatures2* extensionPointer = default(SharpVk.Interop.PhysicalDeviceFeatures2*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceFeatures2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceFeatures2>());
                    physicalDeviceFeatures2.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVariablePointersFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceVariablePointersFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceVariablePointersFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceVariablePointersFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceVariablePointersFeatures>());
                    physicalDeviceVariablePointersFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExternalSciSyncFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceExternalSciSyncFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceExternalSciSyncFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceExternalSciSyncFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceExternalSciSyncFeatures>());
                    physicalDeviceExternalSciSyncFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExternalSciSync2FeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceExternalSciSync2Features* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceExternalSciSync2Features*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceExternalSciSync2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceExternalSciSync2Features>());
                    physicalDeviceExternalSciSync2FeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (deviceSemaphoreSciSyncPoolReservationCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.DeviceSemaphoreSciSyncPoolReservationCreateInfo* extensionPointer = default(SharpVk.Interop.NVidia.DeviceSemaphoreSciSyncPoolReservationCreateInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.DeviceSemaphoreSciSyncPoolReservationCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.DeviceSemaphoreSciSyncPoolReservationCreateInfo>());
                    deviceSemaphoreSciSyncPoolReservationCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMultiviewFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceMultiviewFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceMultiviewFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceMultiviewFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceMultiviewFeatures>());
                    physicalDeviceMultiviewFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (deviceGroupDeviceCreateInfo != null)
                {
                    SharpVk.Interop.DeviceGroupDeviceCreateInfo* extensionPointer = default(SharpVk.Interop.DeviceGroupDeviceCreateInfo*);
                    extensionPointer = (SharpVk.Interop.DeviceGroupDeviceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceGroupDeviceCreateInfo>());
                    deviceGroupDeviceCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePresentIdFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDevicePresentIdFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDevicePresentIdFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDevicePresentIdFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDevicePresentIdFeatures>());
                    physicalDevicePresentIdFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePresentId2FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDevicePresentId2Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDevicePresentId2Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDevicePresentId2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDevicePresentId2Features>());
                    physicalDevicePresentId2FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePresentWaitFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDevicePresentWaitFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDevicePresentWaitFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDevicePresentWaitFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDevicePresentWaitFeatures>());
                    physicalDevicePresentWaitFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePresentWait2FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDevicePresentWait2Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDevicePresentWait2Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDevicePresentWait2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDevicePresentWait2Features>());
                    physicalDevicePresentWait2FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePresentTimingFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDevicePresentTimingFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDevicePresentTimingFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDevicePresentTimingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDevicePresentTimingFeatures>());
                    physicalDevicePresentTimingFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevice16BitStorageFeatures != null)
                {
                    SharpVk.Interop.PhysicalDevice16BitStorageFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDevice16BitStorageFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDevice16BitStorageFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDevice16BitStorageFeatures>());
                    physicalDevice16BitStorageFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderSubgroupExtendedTypesFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderSubgroupExtendedTypesFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceShaderSubgroupExtendedTypesFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderSubgroupExtendedTypesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderSubgroupExtendedTypesFeatures>());
                    physicalDeviceShaderSubgroupExtendedTypesFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSamplerYcbcrConversionFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceSamplerYcbcrConversionFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceSamplerYcbcrConversionFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceSamplerYcbcrConversionFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceSamplerYcbcrConversionFeatures>());
                    physicalDeviceSamplerYcbcrConversionFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceProtectedMemoryFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceProtectedMemoryFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceProtectedMemoryFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceProtectedMemoryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceProtectedMemoryFeatures>());
                    physicalDeviceProtectedMemoryFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceBlendOperationAdvancedFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceBlendOperationAdvancedFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceBlendOperationAdvancedFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceBlendOperationAdvancedFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceBlendOperationAdvancedFeatures>());
                    physicalDeviceBlendOperationAdvancedFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMultiDrawFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceMultiDrawFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceMultiDrawFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceMultiDrawFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceMultiDrawFeatures>());
                    physicalDeviceMultiDrawFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceInlineUniformBlockFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceInlineUniformBlockFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceInlineUniformBlockFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceInlineUniformBlockFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceInlineUniformBlockFeatures>());
                    physicalDeviceInlineUniformBlockFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMaintenance4Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceMaintenance4Features* extensionPointer = default(SharpVk.Interop.PhysicalDeviceMaintenance4Features*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceMaintenance4Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceMaintenance4Features>());
                    physicalDeviceMaintenance4Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMaintenance5Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceMaintenance5Features* extensionPointer = default(SharpVk.Interop.PhysicalDeviceMaintenance5Features*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceMaintenance5Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceMaintenance5Features>());
                    physicalDeviceMaintenance5Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMaintenance6Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceMaintenance6Features* extensionPointer = default(SharpVk.Interop.PhysicalDeviceMaintenance6Features*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceMaintenance6Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceMaintenance6Features>());
                    physicalDeviceMaintenance6Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMaintenance7FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceMaintenance7Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceMaintenance7Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceMaintenance7Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceMaintenance7Features>());
                    physicalDeviceMaintenance7FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMaintenance8FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceMaintenance8Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceMaintenance8Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceMaintenance8Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceMaintenance8Features>());
                    physicalDeviceMaintenance8FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMaintenance9FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceMaintenance9Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceMaintenance9Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceMaintenance9Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceMaintenance9Features>());
                    physicalDeviceMaintenance9FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMaintenance11FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceMaintenance11Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceMaintenance11Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceMaintenance11Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceMaintenance11Features>());
                    physicalDeviceMaintenance11FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMaintenance10FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceMaintenance10Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceMaintenance10Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceMaintenance10Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceMaintenance10Features>());
                    physicalDeviceMaintenance10FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderDrawParametersFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderDrawParametersFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceShaderDrawParametersFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderDrawParametersFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderDrawParametersFeatures>());
                    physicalDeviceShaderDrawParametersFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderFloat16Int8Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderFloat16Int8Features* extensionPointer = default(SharpVk.Interop.PhysicalDeviceShaderFloat16Int8Features*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderFloat16Int8Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderFloat16Int8Features>());
                    physicalDeviceShaderFloat16Int8Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceHostQueryResetFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceHostQueryResetFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceHostQueryResetFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceHostQueryResetFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceHostQueryResetFeatures>());
                    physicalDeviceHostQueryResetFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceElapsedTimerQueryFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceElapsedTimerQueryFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceElapsedTimerQueryFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceElapsedTimerQueryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceElapsedTimerQueryFeatures>());
                    physicalDeviceElapsedTimerQueryFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceGlobalPriorityQueryFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceGlobalPriorityQueryFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceGlobalPriorityQueryFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceGlobalPriorityQueryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceGlobalPriorityQueryFeatures>());
                    physicalDeviceGlobalPriorityQueryFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDeviceMemoryReportFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceDeviceMemoryReportFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceDeviceMemoryReportFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceDeviceMemoryReportFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceDeviceMemoryReportFeatures>());
                    physicalDeviceDeviceMemoryReportFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (deviceDeviceMemoryReportCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.DeviceDeviceMemoryReportCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.DeviceDeviceMemoryReportCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.DeviceDeviceMemoryReportCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DeviceDeviceMemoryReportCreateInfo>());
                    deviceDeviceMemoryReportCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDescriptorIndexingFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceDescriptorIndexingFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceDescriptorIndexingFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceDescriptorIndexingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceDescriptorIndexingFeatures>());
                    physicalDeviceDescriptorIndexingFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTimelineSemaphoreFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceTimelineSemaphoreFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceTimelineSemaphoreFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceTimelineSemaphoreFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceTimelineSemaphoreFeatures>());
                    physicalDeviceTimelineSemaphoreFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevice8BitStorageFeatures != null)
                {
                    SharpVk.Interop.PhysicalDevice8BitStorageFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDevice8BitStorageFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDevice8BitStorageFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDevice8BitStorageFeatures>());
                    physicalDevice8BitStorageFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceConditionalRenderingFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceConditionalRenderingFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceConditionalRenderingFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceConditionalRenderingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceConditionalRenderingFeatures>());
                    physicalDeviceConditionalRenderingFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVulkanMemoryModelFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceVulkanMemoryModelFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceVulkanMemoryModelFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceVulkanMemoryModelFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceVulkanMemoryModelFeatures>());
                    physicalDeviceVulkanMemoryModelFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderAtomicInt64Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderAtomicInt64Features* extensionPointer = default(SharpVk.Interop.PhysicalDeviceShaderAtomicInt64Features*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderAtomicInt64Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderAtomicInt64Features>());
                    physicalDeviceShaderAtomicInt64Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderAtomicFloatFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloatFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloatFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloatFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloatFeatures>());
                    physicalDeviceShaderAtomicFloatFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderAtomicFloat2FeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloat2Features* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloat2Features*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloat2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloat2Features>());
                    physicalDeviceShaderAtomicFloat2FeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVertexAttributeDivisorFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceVertexAttributeDivisorFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceVertexAttributeDivisorFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceVertexAttributeDivisorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceVertexAttributeDivisorFeatures>());
                    physicalDeviceVertexAttributeDivisorFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceASTCDecodeFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceASTCDecodeFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceASTCDecodeFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceASTCDecodeFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceASTCDecodeFeatures>());
                    physicalDeviceASTCDecodeFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTransformFeedbackFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceTransformFeedbackFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceTransformFeedbackFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceTransformFeedbackFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceTransformFeedbackFeatures>());
                    physicalDeviceTransformFeedbackFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRepresentativeFragmentTestFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceRepresentativeFragmentTestFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceRepresentativeFragmentTestFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceRepresentativeFragmentTestFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceRepresentativeFragmentTestFeatures>());
                    physicalDeviceRepresentativeFragmentTestFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExclusiveScissorFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceExclusiveScissorFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceExclusiveScissorFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceExclusiveScissorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceExclusiveScissorFeatures>());
                    physicalDeviceExclusiveScissorFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCornerSampledImageFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceCornerSampledImageFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceCornerSampledImageFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceCornerSampledImageFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceCornerSampledImageFeatures>());
                    physicalDeviceCornerSampledImageFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceComputeShaderDerivativesFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceComputeShaderDerivativesFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceComputeShaderDerivativesFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceComputeShaderDerivativesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceComputeShaderDerivativesFeatures>());
                    physicalDeviceComputeShaderDerivativesFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderImageFootprintFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceShaderImageFootprintFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceShaderImageFootprintFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceShaderImageFootprintFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceShaderImageFootprintFeatures>());
                    physicalDeviceShaderImageFootprintFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDedicatedAllocationImageAliasingFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceDedicatedAllocationImageAliasingFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceDedicatedAllocationImageAliasingFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceDedicatedAllocationImageAliasingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceDedicatedAllocationImageAliasingFeatures>());
                    physicalDeviceDedicatedAllocationImageAliasingFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCopyMemoryIndirectFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceCopyMemoryIndirectFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceCopyMemoryIndirectFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceCopyMemoryIndirectFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceCopyMemoryIndirectFeatures>());
                    physicalDeviceCopyMemoryIndirectFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCopyMemoryIndirectFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceCopyMemoryIndirectFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceCopyMemoryIndirectFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceCopyMemoryIndirectFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceCopyMemoryIndirectFeatures>());
                    physicalDeviceCopyMemoryIndirectFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMemoryDecompressionFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceMemoryDecompressionFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceMemoryDecompressionFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceMemoryDecompressionFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceMemoryDecompressionFeatures>());
                    physicalDeviceMemoryDecompressionFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShadingRateImageFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceShadingRateImageFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceShadingRateImageFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceShadingRateImageFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceShadingRateImageFeatures>());
                    physicalDeviceShadingRateImageFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceInvocationMaskFeaturesHuawei != null)
                {
                    SharpVk.Interop.Huawei.PhysicalDeviceInvocationMaskFeatures* extensionPointer = default(SharpVk.Interop.Huawei.PhysicalDeviceInvocationMaskFeatures*);
                    extensionPointer = (SharpVk.Interop.Huawei.PhysicalDeviceInvocationMaskFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Huawei.PhysicalDeviceInvocationMaskFeatures>());
                    physicalDeviceInvocationMaskFeaturesHuawei.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMeshShaderFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceMeshShaderFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceMeshShaderFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceMeshShaderFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceMeshShaderFeatures>());
                    physicalDeviceMeshShaderFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMeshShaderFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceMeshShaderFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceMeshShaderFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceMeshShaderFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceMeshShaderFeatures>());
                    physicalDeviceMeshShaderFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceAccelerationStructureFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceAccelerationStructureFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceAccelerationStructureFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceAccelerationStructureFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceAccelerationStructureFeatures>());
                    physicalDeviceAccelerationStructureFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRayTracingPipelineFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceRayTracingPipelineFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceRayTracingPipelineFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceRayTracingPipelineFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceRayTracingPipelineFeatures>());
                    physicalDeviceRayTracingPipelineFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRayQueryFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceRayQueryFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceRayQueryFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceRayQueryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceRayQueryFeatures>());
                    physicalDeviceRayQueryFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRayTracingMaintenance1FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceRayTracingMaintenance1Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceRayTracingMaintenance1Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceRayTracingMaintenance1Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceRayTracingMaintenance1Features>());
                    physicalDeviceRayTracingMaintenance1FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (deviceMemoryOverallocationCreateInfoAmd != null)
                {
                    SharpVk.Interop.Amd.DeviceMemoryOverallocationCreateInfo* extensionPointer = default(SharpVk.Interop.Amd.DeviceMemoryOverallocationCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Amd.DeviceMemoryOverallocationCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.DeviceMemoryOverallocationCreateInfo>());
                    deviceMemoryOverallocationCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentDensityMapFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMapFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMapFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMapFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMapFeatures>());
                    physicalDeviceFragmentDensityMapFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentDensityMap2FeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMap2Features* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMap2Features*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMap2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMap2Features>());
                    physicalDeviceFragmentDensityMap2FeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentDensityMapOffsetFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMapOffsetFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMapOffsetFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMapOffsetFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMapOffsetFeatures>());
                    physicalDeviceFragmentDensityMapOffsetFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceScalarBlockLayoutFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceScalarBlockLayoutFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceScalarBlockLayoutFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceScalarBlockLayoutFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceScalarBlockLayoutFeatures>());
                    physicalDeviceScalarBlockLayoutFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceUniformBufferStandardLayoutFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceUniformBufferStandardLayoutFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceUniformBufferStandardLayoutFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceUniformBufferStandardLayoutFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceUniformBufferStandardLayoutFeatures>());
                    physicalDeviceUniformBufferStandardLayoutFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDepthClipEnableFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceDepthClipEnableFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceDepthClipEnableFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceDepthClipEnableFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceDepthClipEnableFeatures>());
                    physicalDeviceDepthClipEnableFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMemoryPriorityFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceMemoryPriorityFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceMemoryPriorityFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceMemoryPriorityFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceMemoryPriorityFeatures>());
                    physicalDeviceMemoryPriorityFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePageableDeviceLocalMemoryFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDevicePageableDeviceLocalMemoryFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDevicePageableDeviceLocalMemoryFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDevicePageableDeviceLocalMemoryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDevicePageableDeviceLocalMemoryFeatures>());
                    physicalDevicePageableDeviceLocalMemoryFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceBufferDeviceAddressFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceBufferDeviceAddressFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceBufferDeviceAddressFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceBufferDeviceAddressFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceBufferDeviceAddressFeatures>());
                    physicalDeviceBufferDeviceAddressFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceBufferDeviceAddressFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceBufferDeviceAddressFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceBufferDeviceAddressFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceBufferDeviceAddressFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceBufferDeviceAddressFeatures>());
                    physicalDeviceBufferDeviceAddressFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImagelessFramebufferFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceImagelessFramebufferFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceImagelessFramebufferFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceImagelessFramebufferFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceImagelessFramebufferFeatures>());
                    physicalDeviceImagelessFramebufferFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTextureCompressionASTCHDRFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceTextureCompressionASTCHDRFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceTextureCompressionASTCHDRFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceTextureCompressionASTCHDRFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceTextureCompressionASTCHDRFeatures>());
                    physicalDeviceTextureCompressionASTCHDRFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCooperativeMatrixFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrixFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrixFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrixFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrixFeatures>());
                    physicalDeviceCooperativeMatrixFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceYcbcrImageArraysFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceYcbcrImageArraysFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceYcbcrImageArraysFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceYcbcrImageArraysFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceYcbcrImageArraysFeatures>());
                    physicalDeviceYcbcrImageArraysFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePresentBarrierFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDevicePresentBarrierFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDevicePresentBarrierFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDevicePresentBarrierFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDevicePresentBarrierFeatures>());
                    physicalDevicePresentBarrierFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePerformanceQueryFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDevicePerformanceQueryFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDevicePerformanceQueryFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDevicePerformanceQueryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDevicePerformanceQueryFeatures>());
                    physicalDevicePerformanceQueryFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (performanceQueryReservationInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.PerformanceQueryReservationInfo* extensionPointer = default(SharpVk.Interop.Khronos.PerformanceQueryReservationInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.PerformanceQueryReservationInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PerformanceQueryReservationInfo>());
                    performanceQueryReservationInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCoverageReductionModeFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceCoverageReductionModeFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceCoverageReductionModeFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceCoverageReductionModeFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceCoverageReductionModeFeatures>());
                    physicalDeviceCoverageReductionModeFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderIntegerFunctions2FeaturesIntel != null)
                {
                    SharpVk.Interop.Intel.PhysicalDeviceShaderIntegerFunctions2Features* extensionPointer = default(SharpVk.Interop.Intel.PhysicalDeviceShaderIntegerFunctions2Features*);
                    extensionPointer = (SharpVk.Interop.Intel.PhysicalDeviceShaderIntegerFunctions2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Intel.PhysicalDeviceShaderIntegerFunctions2Features>());
                    physicalDeviceShaderIntegerFunctions2FeaturesIntel.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderClockFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceShaderClockFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceShaderClockFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceShaderClockFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceShaderClockFeatures>());
                    physicalDeviceShaderClockFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceIndexTypeUint8Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceIndexTypeUint8Features* extensionPointer = default(SharpVk.Interop.PhysicalDeviceIndexTypeUint8Features*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceIndexTypeUint8Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceIndexTypeUint8Features>());
                    physicalDeviceIndexTypeUint8Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderSMBuiltinsFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceShaderSMBuiltinsFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceShaderSMBuiltinsFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceShaderSMBuiltinsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceShaderSMBuiltinsFeatures>());
                    physicalDeviceShaderSMBuiltinsFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentShaderInterlockFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceFragmentShaderInterlockFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceFragmentShaderInterlockFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceFragmentShaderInterlockFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceFragmentShaderInterlockFeatures>());
                    physicalDeviceFragmentShaderInterlockFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSeparateDepthStencilLayoutsFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceSeparateDepthStencilLayoutsFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceSeparateDepthStencilLayoutsFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceSeparateDepthStencilLayoutsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceSeparateDepthStencilLayoutsFeatures>());
                    physicalDeviceSeparateDepthStencilLayoutsFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePrimitiveTopologyListRestartFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDevicePrimitiveTopologyListRestartFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDevicePrimitiveTopologyListRestartFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDevicePrimitiveTopologyListRestartFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDevicePrimitiveTopologyListRestartFeatures>());
                    physicalDevicePrimitiveTopologyListRestartFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePipelineExecutablePropertiesFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDevicePipelineExecutablePropertiesFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDevicePipelineExecutablePropertiesFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDevicePipelineExecutablePropertiesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDevicePipelineExecutablePropertiesFeatures>());
                    physicalDevicePipelineExecutablePropertiesFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderDemoteToHelperInvocationFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderDemoteToHelperInvocationFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceShaderDemoteToHelperInvocationFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderDemoteToHelperInvocationFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderDemoteToHelperInvocationFeatures>());
                    physicalDeviceShaderDemoteToHelperInvocationFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTexelBufferAlignmentFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceTexelBufferAlignmentFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceTexelBufferAlignmentFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceTexelBufferAlignmentFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceTexelBufferAlignmentFeatures>());
                    physicalDeviceTexelBufferAlignmentFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSubgroupSizeControlFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceSubgroupSizeControlFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceSubgroupSizeControlFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceSubgroupSizeControlFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceSubgroupSizeControlFeatures>());
                    physicalDeviceSubgroupSizeControlFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceLineRasterizationFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceLineRasterizationFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceLineRasterizationFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceLineRasterizationFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceLineRasterizationFeatures>());
                    physicalDeviceLineRasterizationFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePipelineCreationCacheControlFeatures != null)
                {
                    SharpVk.Interop.PhysicalDevicePipelineCreationCacheControlFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDevicePipelineCreationCacheControlFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDevicePipelineCreationCacheControlFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDevicePipelineCreationCacheControlFeatures>());
                    physicalDevicePipelineCreationCacheControlFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVulkan11Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceVulkan11Features* extensionPointer = default(SharpVk.Interop.PhysicalDeviceVulkan11Features*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceVulkan11Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceVulkan11Features>());
                    physicalDeviceVulkan11Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVulkan12Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceVulkan12Features* extensionPointer = default(SharpVk.Interop.PhysicalDeviceVulkan12Features*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceVulkan12Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceVulkan12Features>());
                    physicalDeviceVulkan12Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVulkan13Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceVulkan13Features* extensionPointer = default(SharpVk.Interop.PhysicalDeviceVulkan13Features*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceVulkan13Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceVulkan13Features>());
                    physicalDeviceVulkan13Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVulkan14Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceVulkan14Features* extensionPointer = default(SharpVk.Interop.PhysicalDeviceVulkan14Features*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceVulkan14Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceVulkan14Features>());
                    physicalDeviceVulkan14Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCoherentMemoryFeaturesAmd != null)
                {
                    SharpVk.Interop.Amd.PhysicalDeviceCoherentMemoryFeatures* extensionPointer = default(SharpVk.Interop.Amd.PhysicalDeviceCoherentMemoryFeatures*);
                    extensionPointer = (SharpVk.Interop.Amd.PhysicalDeviceCoherentMemoryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.PhysicalDeviceCoherentMemoryFeatures>());
                    physicalDeviceCoherentMemoryFeaturesAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceGpaFeaturesAmd != null)
                {
                    SharpVk.Interop.Amd.PhysicalDeviceGpaFeatures* extensionPointer = default(SharpVk.Interop.Amd.PhysicalDeviceGpaFeatures*);
                    extensionPointer = (SharpVk.Interop.Amd.PhysicalDeviceGpaFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.PhysicalDeviceGpaFeatures>());
                    physicalDeviceGpaFeaturesAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (faultCallbackInfo != null)
                {
                    SharpVk.Interop.FaultCallbackInfo* extensionPointer = default(SharpVk.Interop.FaultCallbackInfo*);
                    extensionPointer = (SharpVk.Interop.FaultCallbackInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.FaultCallbackInfo>());
                    faultCallbackInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCustomBorderColorFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceCustomBorderColorFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceCustomBorderColorFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceCustomBorderColorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceCustomBorderColorFeatures>());
                    physicalDeviceCustomBorderColorFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceBorderColorSwizzleFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceBorderColorSwizzleFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceBorderColorSwizzleFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceBorderColorSwizzleFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceBorderColorSwizzleFeatures>());
                    physicalDeviceBorderColorSwizzleFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExtendedDynamicStateFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicStateFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicStateFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicStateFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicStateFeatures>());
                    physicalDeviceExtendedDynamicStateFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExtendedDynamicState2FeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicState2Features* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicState2Features*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicState2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicState2Features>());
                    physicalDeviceExtendedDynamicState2FeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExtendedDynamicState3FeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicState3Features* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicState3Features*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicState3Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicState3Features>());
                    physicalDeviceExtendedDynamicState3FeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExtendedFlagsFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceExtendedFlagsFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceExtendedFlagsFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceExtendedFlagsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceExtendedFlagsFeatures>());
                    physicalDeviceExtendedFlagsFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePartitionedAccelerationStructureFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDevicePartitionedAccelerationStructureFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDevicePartitionedAccelerationStructureFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDevicePartitionedAccelerationStructureFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDevicePartitionedAccelerationStructureFeatures>());
                    physicalDevicePartitionedAccelerationStructureFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDiagnosticsConfigFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceDiagnosticsConfigFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceDiagnosticsConfigFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceDiagnosticsConfigFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceDiagnosticsConfigFeatures>());
                    physicalDeviceDiagnosticsConfigFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (deviceDiagnosticsConfigCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.DeviceDiagnosticsConfigCreateInfo* extensionPointer = default(SharpVk.Interop.NVidia.DeviceDiagnosticsConfigCreateInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.DeviceDiagnosticsConfigCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.DeviceDiagnosticsConfigCreateInfo>());
                    deviceDiagnosticsConfigCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceZeroInitializeWorkgroupMemoryFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures>());
                    physicalDeviceZeroInitializeWorkgroupMemoryFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderSubgroupUniformControlFlowFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceShaderSubgroupUniformControlFlowFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceShaderSubgroupUniformControlFlowFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceShaderSubgroupUniformControlFlowFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceShaderSubgroupUniformControlFlowFeatures>());
                    physicalDeviceShaderSubgroupUniformControlFlowFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRobustness2FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceRobustness2Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceRobustness2Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceRobustness2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceRobustness2Features>());
                    physicalDeviceRobustness2FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImageRobustnessFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceImageRobustnessFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceImageRobustnessFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceImageRobustnessFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceImageRobustnessFeatures>());
                    physicalDeviceImageRobustnessFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceWorkgroupMemoryExplicitLayoutFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceWorkgroupMemoryExplicitLayoutFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceWorkgroupMemoryExplicitLayoutFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceWorkgroupMemoryExplicitLayoutFeatures>());
                    physicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePortabilitySubsetFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDevicePortabilitySubsetFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDevicePortabilitySubsetFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDevicePortabilitySubsetFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDevicePortabilitySubsetFeatures>());
                    physicalDevicePortabilitySubsetFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevice4444FormatsFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDevice4444FormatsFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDevice4444FormatsFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDevice4444FormatsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDevice4444FormatsFeatures>());
                    physicalDevice4444FormatsFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSubpassShadingFeaturesHuawei != null)
                {
                    SharpVk.Interop.Huawei.PhysicalDeviceSubpassShadingFeatures* extensionPointer = default(SharpVk.Interop.Huawei.PhysicalDeviceSubpassShadingFeatures*);
                    extensionPointer = (SharpVk.Interop.Huawei.PhysicalDeviceSubpassShadingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Huawei.PhysicalDeviceSubpassShadingFeatures>());
                    physicalDeviceSubpassShadingFeaturesHuawei.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceClusterCullingShaderFeaturesHuawei != null)
                {
                    SharpVk.Interop.Huawei.PhysicalDeviceClusterCullingShaderFeatures* extensionPointer = default(SharpVk.Interop.Huawei.PhysicalDeviceClusterCullingShaderFeatures*);
                    extensionPointer = (SharpVk.Interop.Huawei.PhysicalDeviceClusterCullingShaderFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Huawei.PhysicalDeviceClusterCullingShaderFeatures>());
                    physicalDeviceClusterCullingShaderFeaturesHuawei.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderImageAtomicInt64FeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderImageAtomicInt64Features* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShaderImageAtomicInt64Features*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderImageAtomicInt64Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderImageAtomicInt64Features>());
                    physicalDeviceShaderImageAtomicInt64FeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentShadingRateFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceFragmentShadingRateFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceFragmentShadingRateFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceFragmentShadingRateFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceFragmentShadingRateFeatures>());
                    physicalDeviceFragmentShadingRateFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderTerminateInvocationFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderTerminateInvocationFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceShaderTerminateInvocationFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderTerminateInvocationFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderTerminateInvocationFeatures>());
                    physicalDeviceShaderTerminateInvocationFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentShadingRateEnumsFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceFragmentShadingRateEnumsFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceFragmentShadingRateEnumsFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceFragmentShadingRateEnumsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceFragmentShadingRateEnumsFeatures>());
                    physicalDeviceFragmentShadingRateEnumsFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImage2DViewOf3DFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceImage2DViewOf3DFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceImage2DViewOf3DFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceImage2DViewOf3DFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceImage2DViewOf3DFeatures>());
                    physicalDeviceImage2DViewOf3DFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImageSlicedViewOf3DFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceImageSlicedViewOf3DFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceImageSlicedViewOf3DFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceImageSlicedViewOf3DFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceImageSlicedViewOf3DFeatures>());
                    physicalDeviceImageSlicedViewOf3DFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeatures>());
                    physicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceLegacyVertexAttributesFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceLegacyVertexAttributesFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceLegacyVertexAttributesFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceLegacyVertexAttributesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceLegacyVertexAttributesFeatures>());
                    physicalDeviceLegacyVertexAttributesFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMutableDescriptorTypeFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceMutableDescriptorTypeFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceMutableDescriptorTypeFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceMutableDescriptorTypeFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceMutableDescriptorTypeFeatures>());
                    physicalDeviceMutableDescriptorTypeFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDepthClipControlFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceDepthClipControlFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceDepthClipControlFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceDepthClipControlFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceDepthClipControlFeatures>());
                    physicalDeviceDepthClipControlFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceZeroInitializeDeviceMemoryFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceZeroInitializeDeviceMemoryFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceZeroInitializeDeviceMemoryFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceZeroInitializeDeviceMemoryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceZeroInitializeDeviceMemoryFeatures>());
                    physicalDeviceZeroInitializeDeviceMemoryFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCustomResolveFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceCustomResolveFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceCustomResolveFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceCustomResolveFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceCustomResolveFeatures>());
                    physicalDeviceCustomResolveFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDeviceGeneratedCommandsFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceDeviceGeneratedCommandsFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceDeviceGeneratedCommandsFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceDeviceGeneratedCommandsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceDeviceGeneratedCommandsFeatures>());
                    physicalDeviceDeviceGeneratedCommandsFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDepthClampControlFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceDepthClampControlFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceDepthClampControlFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceDepthClampControlFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceDepthClampControlFeatures>());
                    physicalDeviceDepthClampControlFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVertexInputDynamicStateFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceVertexInputDynamicStateFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceVertexInputDynamicStateFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceVertexInputDynamicStateFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceVertexInputDynamicStateFeatures>());
                    physicalDeviceVertexInputDynamicStateFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExternalMemoryRDMAFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceExternalMemoryRDMAFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceExternalMemoryRDMAFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceExternalMemoryRDMAFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceExternalMemoryRDMAFeatures>());
                    physicalDeviceExternalMemoryRDMAFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderRelaxedExtendedInstructionFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceShaderRelaxedExtendedInstructionFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceShaderRelaxedExtendedInstructionFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceShaderRelaxedExtendedInstructionFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceShaderRelaxedExtendedInstructionFeatures>());
                    physicalDeviceShaderRelaxedExtendedInstructionFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceColorWriteEnableFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceColorWriteEnableFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceColorWriteEnableFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceColorWriteEnableFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceColorWriteEnableFeatures>());
                    physicalDeviceColorWriteEnableFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSynchronization2Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceSynchronization2Features* extensionPointer = default(SharpVk.Interop.PhysicalDeviceSynchronization2Features*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceSynchronization2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceSynchronization2Features>());
                    physicalDeviceSynchronization2Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceUnifiedImageLayoutsFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceUnifiedImageLayoutsFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceUnifiedImageLayoutsFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceUnifiedImageLayoutsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceUnifiedImageLayoutsFeatures>());
                    physicalDeviceUnifiedImageLayoutsFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceHostImageCopyFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceHostImageCopyFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceHostImageCopyFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceHostImageCopyFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceHostImageCopyFeatures>());
                    physicalDeviceHostImageCopyFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (deviceObjectReservationCreateInfo != null)
                {
                    SharpVk.Interop.DeviceObjectReservationCreateInfo* extensionPointer = default(SharpVk.Interop.DeviceObjectReservationCreateInfo*);
                    extensionPointer = (SharpVk.Interop.DeviceObjectReservationCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceObjectReservationCreateInfo>());
                    deviceObjectReservationCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVulkanSC10Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceVulkanSC10Features* extensionPointer = default(SharpVk.Interop.PhysicalDeviceVulkanSC10Features*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceVulkanSC10Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceVulkanSC10Features>());
                    physicalDeviceVulkanSC10Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePrimitivesGeneratedQueryFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDevicePrimitivesGeneratedQueryFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDevicePrimitivesGeneratedQueryFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDevicePrimitivesGeneratedQueryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDevicePrimitivesGeneratedQueryFeatures>());
                    physicalDevicePrimitivesGeneratedQueryFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceLegacyDitheringFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceLegacyDitheringFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceLegacyDitheringFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceLegacyDitheringFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceLegacyDitheringFeatures>());
                    physicalDeviceLegacyDitheringFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMultisampledRenderToSingleSampledFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceMultisampledRenderToSingleSampledFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceMultisampledRenderToSingleSampledFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceMultisampledRenderToSingleSampledFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceMultisampledRenderToSingleSampledFeatures>());
                    physicalDeviceMultisampledRenderToSingleSampledFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMultisampledRenderToSwapchainFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceMultisampledRenderToSwapchainFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceMultisampledRenderToSwapchainFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceMultisampledRenderToSwapchainFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceMultisampledRenderToSwapchainFeatures>());
                    physicalDeviceMultisampledRenderToSwapchainFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePipelineProtectedAccessFeatures != null)
                {
                    SharpVk.Interop.PhysicalDevicePipelineProtectedAccessFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDevicePipelineProtectedAccessFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDevicePipelineProtectedAccessFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDevicePipelineProtectedAccessFeatures>());
                    physicalDevicePipelineProtectedAccessFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVideoMaintenance1FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceVideoMaintenance1Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceVideoMaintenance1Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceVideoMaintenance1Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceVideoMaintenance1Features>());
                    physicalDeviceVideoMaintenance1FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVideoMaintenance2FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceVideoMaintenance2Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceVideoMaintenance2Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceVideoMaintenance2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceVideoMaintenance2Features>());
                    physicalDeviceVideoMaintenance2FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVideoDecodeVP9FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceVideoDecodeVP9Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceVideoDecodeVP9Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceVideoDecodeVP9Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceVideoDecodeVP9Features>());
                    physicalDeviceVideoDecodeVP9FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVideoEncodeQuantizationMapFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeQuantizationMapFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeQuantizationMapFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeQuantizationMapFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeQuantizationMapFeatures>());
                    physicalDeviceVideoEncodeQuantizationMapFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVideoEncodeFeedback2FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeFeedback2Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeFeedback2Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeFeedback2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeFeedback2Features>());
                    physicalDeviceVideoEncodeFeedback2FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVideoEncodeAV1FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeAV1Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeAV1Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeAV1Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeAV1Features>());
                    physicalDeviceVideoEncodeAV1FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceInheritedViewportScissorFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceInheritedViewportScissorFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceInheritedViewportScissorFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceInheritedViewportScissorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceInheritedViewportScissorFeatures>());
                    physicalDeviceInheritedViewportScissorFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceYcbcr2Plane444FormatsFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceYcbcr2Plane444FormatsFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceYcbcr2Plane444FormatsFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceYcbcr2Plane444FormatsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceYcbcr2Plane444FormatsFeatures>());
                    physicalDeviceYcbcr2Plane444FormatsFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceProvokingVertexFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceProvokingVertexFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceProvokingVertexFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceProvokingVertexFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceProvokingVertexFeatures>());
                    physicalDeviceProvokingVertexFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVideoEncodeIntraRefreshFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeIntraRefreshFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeIntraRefreshFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeIntraRefreshFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceVideoEncodeIntraRefreshFeatures>());
                    physicalDeviceVideoEncodeIntraRefreshFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDescriptorBufferFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceDescriptorBufferFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceDescriptorBufferFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceDescriptorBufferFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceDescriptorBufferFeatures>());
                    physicalDeviceDescriptorBufferFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderIntegerDotProductFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderIntegerDotProductFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceShaderIntegerDotProductFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderIntegerDotProductFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderIntegerDotProductFeatures>());
                    physicalDeviceShaderIntegerDotProductFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentShaderBarycentricFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceFragmentShaderBarycentricFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceFragmentShaderBarycentricFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceFragmentShaderBarycentricFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceFragmentShaderBarycentricFeatures>());
                    physicalDeviceFragmentShaderBarycentricFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderFmaFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceShaderFmaFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceShaderFmaFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceShaderFmaFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceShaderFmaFeatures>());
                    physicalDeviceShaderFmaFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRayTracingMotionBlurFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceRayTracingMotionBlurFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceRayTracingMotionBlurFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceRayTracingMotionBlurFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceRayTracingMotionBlurFeatures>());
                    physicalDeviceRayTracingMotionBlurFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRayTracingValidationFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceRayTracingValidationFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceRayTracingValidationFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceRayTracingValidationFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceRayTracingValidationFeatures>());
                    physicalDeviceRayTracingValidationFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRayTracingLinearSweptSpheresFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceRayTracingLinearSweptSpheresFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceRayTracingLinearSweptSpheresFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceRayTracingLinearSweptSpheresFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceRayTracingLinearSweptSpheresFeatures>());
                    physicalDeviceRayTracingLinearSweptSpheresFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRGBA10X6FormatsFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceRGBA10X6FormatsFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceRGBA10X6FormatsFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceRGBA10X6FormatsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceRGBA10X6FormatsFeatures>());
                    physicalDeviceRGBA10X6FormatsFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDynamicRenderingFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceDynamicRenderingFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceDynamicRenderingFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceDynamicRenderingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceDynamicRenderingFeatures>());
                    physicalDeviceDynamicRenderingFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImageViewMinLodFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceImageViewMinLodFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceImageViewMinLodFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceImageViewMinLodFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceImageViewMinLodFeatures>());
                    physicalDeviceImageViewMinLodFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRasterizationOrderAttachmentAccessFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceRasterizationOrderAttachmentAccessFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceRasterizationOrderAttachmentAccessFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceRasterizationOrderAttachmentAccessFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceRasterizationOrderAttachmentAccessFeatures>());
                    physicalDeviceRasterizationOrderAttachmentAccessFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceLinearColorAttachmentFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceLinearColorAttachmentFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceLinearColorAttachmentFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceLinearColorAttachmentFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceLinearColorAttachmentFeatures>());
                    physicalDeviceLinearColorAttachmentFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceGraphicsPipelineLibraryFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceGraphicsPipelineLibraryFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceGraphicsPipelineLibraryFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceGraphicsPipelineLibraryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceGraphicsPipelineLibraryFeatures>());
                    physicalDeviceGraphicsPipelineLibraryFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePipelineBinaryFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDevicePipelineBinaryFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDevicePipelineBinaryFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDevicePipelineBinaryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDevicePipelineBinaryFeatures>());
                    physicalDevicePipelineBinaryFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (devicePipelineBinaryInternalCacheControlKhr != null)
                {
                    SharpVk.Interop.Khronos.DevicePipelineBinaryInternalCacheControl* extensionPointer = default(SharpVk.Interop.Khronos.DevicePipelineBinaryInternalCacheControl*);
                    extensionPointer = (SharpVk.Interop.Khronos.DevicePipelineBinaryInternalCacheControl*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DevicePipelineBinaryInternalCacheControl>());
                    devicePipelineBinaryInternalCacheControlKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesArm != null)
                {
                    SharpVk.Interop.Arm.PhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeatures* extensionPointer = default(SharpVk.Interop.Arm.PhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeatures*);
                    extensionPointer = (SharpVk.Interop.Arm.PhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeatures>());
                    physicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDescriptorSetHostMappingFeaturesValve != null)
                {
                    SharpVk.Interop.Valve.PhysicalDeviceDescriptorSetHostMappingFeatures* extensionPointer = default(SharpVk.Interop.Valve.PhysicalDeviceDescriptorSetHostMappingFeatures*);
                    extensionPointer = (SharpVk.Interop.Valve.PhysicalDeviceDescriptorSetHostMappingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Valve.PhysicalDeviceDescriptorSetHostMappingFeatures>());
                    physicalDeviceDescriptorSetHostMappingFeaturesValve.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceNestedCommandBufferFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceNestedCommandBufferFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceNestedCommandBufferFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceNestedCommandBufferFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceNestedCommandBufferFeatures>());
                    physicalDeviceNestedCommandBufferFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderModuleIdentifierFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderModuleIdentifierFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShaderModuleIdentifierFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderModuleIdentifierFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderModuleIdentifierFeatures>());
                    physicalDeviceShaderModuleIdentifierFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImageCompressionControlFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceImageCompressionControlFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceImageCompressionControlFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceImageCompressionControlFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceImageCompressionControlFeatures>());
                    physicalDeviceImageCompressionControlFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImageCompressionControlSwapchainFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceImageCompressionControlSwapchainFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceImageCompressionControlSwapchainFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceImageCompressionControlSwapchainFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceImageCompressionControlSwapchainFeatures>());
                    physicalDeviceImageCompressionControlSwapchainFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSubpassMergeFeedbackFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceSubpassMergeFeedbackFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceSubpassMergeFeedbackFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceSubpassMergeFeedbackFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceSubpassMergeFeedbackFeatures>());
                    physicalDeviceSubpassMergeFeedbackFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceOpacityMicromapFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceOpacityMicromapFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceOpacityMicromapFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceOpacityMicromapFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceOpacityMicromapFeatures>());
                    physicalDeviceOpacityMicromapFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceOpacityMicromapFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceOpacityMicromapFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceOpacityMicromapFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceOpacityMicromapFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceOpacityMicromapFeatures>());
                    physicalDeviceOpacityMicromapFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDisplacementMicromapFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceDisplacementMicromapFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceDisplacementMicromapFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceDisplacementMicromapFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceDisplacementMicromapFeatures>());
                    physicalDeviceDisplacementMicromapFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePipelinePropertiesFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDevicePipelinePropertiesFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDevicePipelinePropertiesFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDevicePipelinePropertiesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDevicePipelinePropertiesFeatures>());
                    physicalDevicePipelinePropertiesFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAmd != null)
                {
                    SharpVk.Interop.Amd.PhysicalDeviceShaderEarlyAndLateFragmentTestsFeatures* extensionPointer = default(SharpVk.Interop.Amd.PhysicalDeviceShaderEarlyAndLateFragmentTestsFeatures*);
                    extensionPointer = (SharpVk.Interop.Amd.PhysicalDeviceShaderEarlyAndLateFragmentTestsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.PhysicalDeviceShaderEarlyAndLateFragmentTestsFeatures>());
                    physicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceNonSeamlessCubeMapFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceNonSeamlessCubeMapFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceNonSeamlessCubeMapFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceNonSeamlessCubeMapFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceNonSeamlessCubeMapFeatures>());
                    physicalDeviceNonSeamlessCubeMapFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePipelineRobustnessFeatures != null)
                {
                    SharpVk.Interop.PhysicalDevicePipelineRobustnessFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDevicePipelineRobustnessFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDevicePipelineRobustnessFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDevicePipelineRobustnessFeatures>());
                    physicalDevicePipelineRobustnessFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderMultipleWaitQueuesFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceShaderMultipleWaitQueuesFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceShaderMultipleWaitQueuesFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceShaderMultipleWaitQueuesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceShaderMultipleWaitQueuesFeatures>());
                    physicalDeviceShaderMultipleWaitQueuesFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImageProcessingFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceImageProcessingFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceImageProcessingFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceImageProcessingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceImageProcessingFeatures>());
                    physicalDeviceImageProcessingFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTilePropertiesFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceTilePropertiesFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceTilePropertiesFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceTilePropertiesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceTilePropertiesFeatures>());
                    physicalDeviceTilePropertiesFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceAmigoProfilingFeaturesSec != null)
                {
                    SharpVk.Interop.Sec.PhysicalDeviceAmigoProfilingFeatures* extensionPointer = default(SharpVk.Interop.Sec.PhysicalDeviceAmigoProfilingFeatures*);
                    extensionPointer = (SharpVk.Interop.Sec.PhysicalDeviceAmigoProfilingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Sec.PhysicalDeviceAmigoProfilingFeatures>());
                    physicalDeviceAmigoProfilingFeaturesSec.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceAttachmentFeedbackLoopLayoutFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceAttachmentFeedbackLoopLayoutFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceAttachmentFeedbackLoopLayoutFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceAttachmentFeedbackLoopLayoutFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceAttachmentFeedbackLoopLayoutFeatures>());
                    physicalDeviceAttachmentFeedbackLoopLayoutFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceAddressBindingReportFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceAddressBindingReportFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceAddressBindingReportFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceAddressBindingReportFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceAddressBindingReportFeatures>());
                    physicalDeviceAddressBindingReportFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceOpticalFlowFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceOpticalFlowFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceOpticalFlowFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceOpticalFlowFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceOpticalFlowFeatures>());
                    physicalDeviceOpticalFlowFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFaultFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceFaultFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceFaultFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceFaultFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceFaultFeatures>());
                    physicalDeviceFaultFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFaultFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceFaultFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceFaultFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceFaultFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceFaultFeatures>());
                    physicalDeviceFaultFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePipelineLibraryGroupHandlesFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDevicePipelineLibraryGroupHandlesFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDevicePipelineLibraryGroupHandlesFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDevicePipelineLibraryGroupHandlesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDevicePipelineLibraryGroupHandlesFeatures>());
                    physicalDevicePipelineLibraryGroupHandlesFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderCoreBuiltinsFeaturesArm != null)
                {
                    SharpVk.Interop.Arm.PhysicalDeviceShaderCoreBuiltinsFeatures* extensionPointer = default(SharpVk.Interop.Arm.PhysicalDeviceShaderCoreBuiltinsFeatures*);
                    extensionPointer = (SharpVk.Interop.Arm.PhysicalDeviceShaderCoreBuiltinsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDeviceShaderCoreBuiltinsFeatures>());
                    physicalDeviceShaderCoreBuiltinsFeaturesArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFrameBoundaryFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceFrameBoundaryFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceFrameBoundaryFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceFrameBoundaryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceFrameBoundaryFeatures>());
                    physicalDeviceFrameBoundaryFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDynamicRenderingUnusedAttachmentsFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceDynamicRenderingUnusedAttachmentsFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceDynamicRenderingUnusedAttachmentsFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceDynamicRenderingUnusedAttachmentsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceDynamicRenderingUnusedAttachmentsFeatures>());
                    physicalDeviceDynamicRenderingUnusedAttachmentsFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceInternallySynchronizedQueuesFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceInternallySynchronizedQueuesFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceInternallySynchronizedQueuesFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceInternallySynchronizedQueuesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceInternallySynchronizedQueuesFeatures>());
                    physicalDeviceInternallySynchronizedQueuesFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSwapchainMaintenance1FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceSwapchainMaintenance1Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceSwapchainMaintenance1Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceSwapchainMaintenance1Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceSwapchainMaintenance1Features>());
                    physicalDeviceSwapchainMaintenance1FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDepthBiasControlFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceDepthBiasControlFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceDepthBiasControlFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceDepthBiasControlFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceDepthBiasControlFeatures>());
                    physicalDeviceDepthBiasControlFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRayTracingInvocationReorderFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceRayTracingInvocationReorderFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceRayTracingInvocationReorderFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceRayTracingInvocationReorderFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceRayTracingInvocationReorderFeatures>());
                    physicalDeviceRayTracingInvocationReorderFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRayTracingInvocationReorderFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceRayTracingInvocationReorderFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceRayTracingInvocationReorderFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceRayTracingInvocationReorderFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceRayTracingInvocationReorderFeatures>());
                    physicalDeviceRayTracingInvocationReorderFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExtendedSparseAddressSpaceFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceExtendedSparseAddressSpaceFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceExtendedSparseAddressSpaceFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceExtendedSparseAddressSpaceFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceExtendedSparseAddressSpaceFeatures>());
                    physicalDeviceExtendedSparseAddressSpaceFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMultiviewPerViewViewportsFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceMultiviewPerViewViewportsFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceMultiviewPerViewViewportsFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceMultiviewPerViewViewportsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceMultiviewPerViewViewportsFeatures>());
                    physicalDeviceMultiviewPerViewViewportsFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRayTracingPositionFetchFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceRayTracingPositionFetchFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceRayTracingPositionFetchFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceRayTracingPositionFetchFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceRayTracingPositionFetchFeatures>());
                    physicalDeviceRayTracingPositionFetchFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMultiviewPerViewRenderAreasFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceMultiviewPerViewRenderAreasFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceMultiviewPerViewRenderAreasFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceMultiviewPerViewRenderAreasFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceMultiviewPerViewRenderAreasFeatures>());
                    physicalDeviceMultiviewPerViewRenderAreasFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderObjectFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderObjectFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShaderObjectFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderObjectFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderObjectFeatures>());
                    physicalDeviceShaderObjectFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderTileImageFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderTileImageFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShaderTileImageFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderTileImageFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderTileImageFeatures>());
                    physicalDeviceShaderTileImageFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExternalMemoryScreenBufferFeaturesQnx != null)
                {
                    SharpVk.Interop.Qnx.PhysicalDeviceExternalMemoryScreenBufferFeatures* extensionPointer = default(SharpVk.Interop.Qnx.PhysicalDeviceExternalMemoryScreenBufferFeatures*);
                    extensionPointer = (SharpVk.Interop.Qnx.PhysicalDeviceExternalMemoryScreenBufferFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qnx.PhysicalDeviceExternalMemoryScreenBufferFeatures>());
                    physicalDeviceExternalMemoryScreenBufferFeaturesQnx.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCooperativeMatrixFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceCooperativeMatrixFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceCooperativeMatrixFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceCooperativeMatrixFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceCooperativeMatrixFeatures>());
                    physicalDeviceCooperativeMatrixFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCooperativeMatrixConversionFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceCooperativeMatrixConversionFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceCooperativeMatrixConversionFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceCooperativeMatrixConversionFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceCooperativeMatrixConversionFeatures>());
                    physicalDeviceCooperativeMatrixConversionFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderEnqueueFeaturesAmdx != null)
                {
                    SharpVk.Interop.Amdx.PhysicalDeviceShaderEnqueueFeatures* extensionPointer = default(SharpVk.Interop.Amdx.PhysicalDeviceShaderEnqueueFeatures*);
                    extensionPointer = (SharpVk.Interop.Amdx.PhysicalDeviceShaderEnqueueFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amdx.PhysicalDeviceShaderEnqueueFeatures>());
                    physicalDeviceShaderEnqueueFeaturesAmdx.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceAntiLagFeaturesAmd != null)
                {
                    SharpVk.Interop.Amd.PhysicalDeviceAntiLagFeatures* extensionPointer = default(SharpVk.Interop.Amd.PhysicalDeviceAntiLagFeatures*);
                    extensionPointer = (SharpVk.Interop.Amd.PhysicalDeviceAntiLagFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.PhysicalDeviceAntiLagFeatures>());
                    physicalDeviceAntiLagFeaturesAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTileMemoryHeapFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceTileMemoryHeapFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceTileMemoryHeapFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceTileMemoryHeapFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceTileMemoryHeapFeatures>());
                    physicalDeviceTileMemoryHeapFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCubicClampFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceCubicClampFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceCubicClampFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceCubicClampFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceCubicClampFeatures>());
                    physicalDeviceCubicClampFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceYcbcrDegammaFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceYcbcrDegammaFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceYcbcrDegammaFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceYcbcrDegammaFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceYcbcrDegammaFeatures>());
                    physicalDeviceYcbcrDegammaFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCubicWeightsFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceCubicWeightsFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceCubicWeightsFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceCubicWeightsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceCubicWeightsFeatures>());
                    physicalDeviceCubicWeightsFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImageProcessing2FeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceImageProcessing2Features* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceImageProcessing2Features*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceImageProcessing2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceImageProcessing2Features>());
                    physicalDeviceImageProcessing2FeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImageProcessing3FeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceImageProcessing3Features* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceImageProcessing3Features*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceImageProcessing3Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceImageProcessing3Features>());
                    physicalDeviceImageProcessing3FeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDescriptorPoolOverallocationFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceDescriptorPoolOverallocationFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceDescriptorPoolOverallocationFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceDescriptorPoolOverallocationFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceDescriptorPoolOverallocationFeatures>());
                    physicalDeviceDescriptorPoolOverallocationFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePerStageDescriptorSetFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDevicePerStageDescriptorSetFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDevicePerStageDescriptorSetFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDevicePerStageDescriptorSetFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDevicePerStageDescriptorSetFeatures>());
                    physicalDevicePerStageDescriptorSetFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExternalFormatResolveFeaturesAndroid != null)
                {
                    SharpVk.Interop.Android.PhysicalDeviceExternalFormatResolveFeatures* extensionPointer = default(SharpVk.Interop.Android.PhysicalDeviceExternalFormatResolveFeatures*);
                    extensionPointer = (SharpVk.Interop.Android.PhysicalDeviceExternalFormatResolveFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Android.PhysicalDeviceExternalFormatResolveFeatures>());
                    physicalDeviceExternalFormatResolveFeaturesAndroid.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCudaKernelLaunchFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceCudaKernelLaunchFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceCudaKernelLaunchFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceCudaKernelLaunchFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceCudaKernelLaunchFeatures>());
                    physicalDeviceCudaKernelLaunchFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (deviceQueueShaderCoreControlCreateInfoArm != null)
                {
                    SharpVk.Interop.Arm.DeviceQueueShaderCoreControlCreateInfo* extensionPointer = default(SharpVk.Interop.Arm.DeviceQueueShaderCoreControlCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Arm.DeviceQueueShaderCoreControlCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DeviceQueueShaderCoreControlCreateInfo>());
                    deviceQueueShaderCoreControlCreateInfoArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSchedulingControlsFeaturesArm != null)
                {
                    SharpVk.Interop.Arm.PhysicalDeviceSchedulingControlsFeatures* extensionPointer = default(SharpVk.Interop.Arm.PhysicalDeviceSchedulingControlsFeatures*);
                    extensionPointer = (SharpVk.Interop.Arm.PhysicalDeviceSchedulingControlsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDeviceSchedulingControlsFeatures>());
                    physicalDeviceSchedulingControlsFeaturesArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRelaxedLineRasterizationFeaturesImg != null)
                {
                    SharpVk.Interop.Img.PhysicalDeviceRelaxedLineRasterizationFeatures* extensionPointer = default(SharpVk.Interop.Img.PhysicalDeviceRelaxedLineRasterizationFeatures*);
                    extensionPointer = (SharpVk.Interop.Img.PhysicalDeviceRelaxedLineRasterizationFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Img.PhysicalDeviceRelaxedLineRasterizationFeatures>());
                    physicalDeviceRelaxedLineRasterizationFeaturesImg.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRenderPassStripedFeaturesArm != null)
                {
                    SharpVk.Interop.Arm.PhysicalDeviceRenderPassStripedFeatures* extensionPointer = default(SharpVk.Interop.Arm.PhysicalDeviceRenderPassStripedFeatures*);
                    extensionPointer = (SharpVk.Interop.Arm.PhysicalDeviceRenderPassStripedFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDeviceRenderPassStripedFeatures>());
                    physicalDeviceRenderPassStripedFeaturesArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePipelineOpacityMicromapFeaturesArm != null)
                {
                    SharpVk.Interop.Arm.PhysicalDevicePipelineOpacityMicromapFeatures* extensionPointer = default(SharpVk.Interop.Arm.PhysicalDevicePipelineOpacityMicromapFeatures*);
                    extensionPointer = (SharpVk.Interop.Arm.PhysicalDevicePipelineOpacityMicromapFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDevicePipelineOpacityMicromapFeatures>());
                    physicalDevicePipelineOpacityMicromapFeaturesArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderMaximalReconvergenceFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceShaderMaximalReconvergenceFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceShaderMaximalReconvergenceFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceShaderMaximalReconvergenceFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceShaderMaximalReconvergenceFeatures>());
                    physicalDeviceShaderMaximalReconvergenceFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderSubgroupRotateFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderSubgroupRotateFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceShaderSubgroupRotateFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderSubgroupRotateFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderSubgroupRotateFeatures>());
                    physicalDeviceShaderSubgroupRotateFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderExpectAssumeFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderExpectAssumeFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceShaderExpectAssumeFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderExpectAssumeFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderExpectAssumeFeatures>());
                    physicalDeviceShaderExpectAssumeFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderFloatControls2Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderFloatControls2Features* extensionPointer = default(SharpVk.Interop.PhysicalDeviceShaderFloatControls2Features*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderFloatControls2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderFloatControls2Features>());
                    physicalDeviceShaderFloatControls2Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDynamicRenderingLocalReadFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceDynamicRenderingLocalReadFeatures* extensionPointer = default(SharpVk.Interop.PhysicalDeviceDynamicRenderingLocalReadFeatures*);
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceDynamicRenderingLocalReadFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceDynamicRenderingLocalReadFeatures>());
                    physicalDeviceDynamicRenderingLocalReadFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderQuadControlFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceShaderQuadControlFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceShaderQuadControlFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceShaderQuadControlFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceShaderQuadControlFeatures>());
                    physicalDeviceShaderQuadControlFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderAtomicFloat16VectorFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceShaderAtomicFloat16VectorFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceShaderAtomicFloat16VectorFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceShaderAtomicFloat16VectorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceShaderAtomicFloat16VectorFeatures>());
                    physicalDeviceShaderAtomicFloat16VectorFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMapMemoryPlacedFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceMapMemoryPlacedFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceMapMemoryPlacedFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceMapMemoryPlacedFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceMapMemoryPlacedFeatures>());
                    physicalDeviceMapMemoryPlacedFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderBfloat16FeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceShaderBfloat16Features* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceShaderBfloat16Features*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceShaderBfloat16Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceShaderBfloat16Features>());
                    physicalDeviceShaderBfloat16FeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRawAccessChainsFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceRawAccessChainsFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceRawAccessChainsFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceRawAccessChainsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceRawAccessChainsFeatures>());
                    physicalDeviceRawAccessChainsFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCommandBufferInheritanceFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceCommandBufferInheritanceFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceCommandBufferInheritanceFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceCommandBufferInheritanceFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceCommandBufferInheritanceFeatures>());
                    physicalDeviceCommandBufferInheritanceFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImageAlignmentControlFeaturesMesa != null)
                {
                    SharpVk.Interop.Mesa.PhysicalDeviceImageAlignmentControlFeatures* extensionPointer = default(SharpVk.Interop.Mesa.PhysicalDeviceImageAlignmentControlFeatures*);
                    extensionPointer = (SharpVk.Interop.Mesa.PhysicalDeviceImageAlignmentControlFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Mesa.PhysicalDeviceImageAlignmentControlFeatures>());
                    physicalDeviceImageAlignmentControlFeaturesMesa.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderReplicatedCompositesFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderReplicatedCompositesFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShaderReplicatedCompositesFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderReplicatedCompositesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderReplicatedCompositesFeatures>());
                    physicalDeviceShaderReplicatedCompositesFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePresentModeFifoLatestReadyFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDevicePresentModeFifoLatestReadyFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDevicePresentModeFifoLatestReadyFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDevicePresentModeFifoLatestReadyFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDevicePresentModeFifoLatestReadyFeatures>());
                    physicalDevicePresentModeFifoLatestReadyFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCooperativeMatrix2FeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrix2Features* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrix2Features*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrix2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrix2Features>());
                    physicalDeviceCooperativeMatrix2FeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCooperativeMatrixDecodeVectorFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrixDecodeVectorFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrixDecodeVectorFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrixDecodeVectorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrixDecodeVectorFeatures>());
                    physicalDeviceCooperativeMatrixDecodeVectorFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceHdrVividFeaturesHuawei != null)
                {
                    SharpVk.Interop.Huawei.PhysicalDeviceHdrVividFeatures* extensionPointer = default(SharpVk.Interop.Huawei.PhysicalDeviceHdrVividFeatures*);
                    extensionPointer = (SharpVk.Interop.Huawei.PhysicalDeviceHdrVividFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Huawei.PhysicalDeviceHdrVividFeatures>());
                    physicalDeviceHdrVividFeaturesHuawei.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVertexAttributeRobustnessFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceVertexAttributeRobustnessFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceVertexAttributeRobustnessFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceVertexAttributeRobustnessFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceVertexAttributeRobustnessFeatures>());
                    physicalDeviceVertexAttributeRobustnessFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDenseGeometryFormatFeaturesAmdx != null)
                {
                    SharpVk.Interop.Amdx.PhysicalDeviceDenseGeometryFormatFeatures* extensionPointer = default(SharpVk.Interop.Amdx.PhysicalDeviceDenseGeometryFormatFeatures*);
                    extensionPointer = (SharpVk.Interop.Amdx.PhysicalDeviceDenseGeometryFormatFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amdx.PhysicalDeviceDenseGeometryFormatFeatures>());
                    physicalDeviceDenseGeometryFormatFeaturesAmdx.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDepthClampZeroOneFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceDepthClampZeroOneFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceDepthClampZeroOneFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceDepthClampZeroOneFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceDepthClampZeroOneFeatures>());
                    physicalDeviceDepthClampZeroOneFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCooperativeVectorFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceCooperativeVectorFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceCooperativeVectorFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceCooperativeVectorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceCooperativeVectorFeatures>());
                    physicalDeviceCooperativeVectorFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTileShadingFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceTileShadingFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceTileShadingFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceTileShadingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceTileShadingFeatures>());
                    physicalDeviceTileShadingFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentDensityMapLayeredFeaturesValve != null)
                {
                    SharpVk.Interop.Valve.PhysicalDeviceFragmentDensityMapLayeredFeatures* extensionPointer = default(SharpVk.Interop.Valve.PhysicalDeviceFragmentDensityMapLayeredFeatures*);
                    extensionPointer = (SharpVk.Interop.Valve.PhysicalDeviceFragmentDensityMapLayeredFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Valve.PhysicalDeviceFragmentDensityMapLayeredFeatures>());
                    physicalDeviceFragmentDensityMapLayeredFeaturesValve.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePresentMeteringFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDevicePresentMeteringFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDevicePresentMeteringFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDevicePresentMeteringFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDevicePresentMeteringFeatures>());
                    physicalDevicePresentMeteringFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (externalComputeQueueDeviceCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.ExternalComputeQueueDeviceCreateInfo* extensionPointer = default(SharpVk.Interop.NVidia.ExternalComputeQueueDeviceCreateInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.ExternalComputeQueueDeviceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ExternalComputeQueueDeviceCreateInfo>());
                    externalComputeQueueDeviceCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderUniformBufferUnsizedArrayFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderUniformBufferUnsizedArrayFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShaderUniformBufferUnsizedArrayFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderUniformBufferUnsizedArrayFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderUniformBufferUnsizedArrayFeatures>());
                    physicalDeviceShaderUniformBufferUnsizedArrayFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderMixedFloatDotProductFeaturesValve != null)
                {
                    SharpVk.Interop.Valve.PhysicalDeviceShaderMixedFloatDotProductFeatures* extensionPointer = default(SharpVk.Interop.Valve.PhysicalDeviceShaderMixedFloatDotProductFeatures*);
                    extensionPointer = (SharpVk.Interop.Valve.PhysicalDeviceShaderMixedFloatDotProductFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Valve.PhysicalDeviceShaderMixedFloatDotProductFeatures>());
                    physicalDeviceShaderMixedFloatDotProductFeaturesValve.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePrimitiveRestartIndexFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDevicePrimitiveRestartIndexFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDevicePrimitiveRestartIndexFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDevicePrimitiveRestartIndexFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDevicePrimitiveRestartIndexFeatures>());
                    physicalDevicePrimitiveRestartIndexFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFormatPackFeaturesArm != null)
                {
                    SharpVk.Interop.Arm.PhysicalDeviceFormatPackFeatures* extensionPointer = default(SharpVk.Interop.Arm.PhysicalDeviceFormatPackFeatures*);
                    extensionPointer = (SharpVk.Interop.Arm.PhysicalDeviceFormatPackFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDeviceFormatPackFeatures>());
                    physicalDeviceFormatPackFeaturesArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceThrottleHintFeaturesSec != null)
                {
                    SharpVk.Interop.Sec.PhysicalDeviceThrottleHintFeatures* extensionPointer = default(SharpVk.Interop.Sec.PhysicalDeviceThrottleHintFeatures*);
                    extensionPointer = (SharpVk.Interop.Sec.PhysicalDeviceThrottleHintFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Sec.PhysicalDeviceThrottleHintFeatures>());
                    physicalDeviceThrottleHintFeaturesSec.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTensorFeaturesArm != null)
                {
                    SharpVk.Interop.Arm.PhysicalDeviceTensorFeatures* extensionPointer = default(SharpVk.Interop.Arm.PhysicalDeviceTensorFeatures*);
                    extensionPointer = (SharpVk.Interop.Arm.PhysicalDeviceTensorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDeviceTensorFeatures>());
                    physicalDeviceTensorFeaturesArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDescriptorBufferTensorFeaturesArm != null)
                {
                    SharpVk.Interop.Arm.PhysicalDeviceDescriptorBufferTensorFeatures* extensionPointer = default(SharpVk.Interop.Arm.PhysicalDeviceDescriptorBufferTensorFeatures*);
                    extensionPointer = (SharpVk.Interop.Arm.PhysicalDeviceDescriptorBufferTensorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDeviceDescriptorBufferTensorFeatures>());
                    physicalDeviceDescriptorBufferTensorFeaturesArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderFloat8FeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderFloat8Features* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShaderFloat8Features*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderFloat8Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderFloat8Features>());
                    physicalDeviceShaderFloat8FeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDataGraphFeaturesArm != null)
                {
                    SharpVk.Interop.Arm.PhysicalDeviceDataGraphFeatures* extensionPointer = default(SharpVk.Interop.Arm.PhysicalDeviceDataGraphFeatures*);
                    extensionPointer = (SharpVk.Interop.Arm.PhysicalDeviceDataGraphFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDeviceDataGraphFeatures>());
                    physicalDeviceDataGraphFeaturesArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePipelineCacheIncrementalModeFeaturesSec != null)
                {
                    SharpVk.Interop.Sec.PhysicalDevicePipelineCacheIncrementalModeFeatures* extensionPointer = default(SharpVk.Interop.Sec.PhysicalDevicePipelineCacheIncrementalModeFeatures*);
                    extensionPointer = (SharpVk.Interop.Sec.PhysicalDevicePipelineCacheIncrementalModeFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Sec.PhysicalDevicePipelineCacheIncrementalModeFeatures>());
                    physicalDevicePipelineCacheIncrementalModeFeaturesSec.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDataGraphModelFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceDataGraphModelFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceDataGraphModelFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceDataGraphModelFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceDataGraphModelFeatures>());
                    physicalDeviceDataGraphModelFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderUntypedPointersFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceShaderUntypedPointersFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceShaderUntypedPointersFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceShaderUntypedPointersFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceShaderUntypedPointersFeatures>());
                    physicalDeviceShaderUntypedPointersFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVideoEncodeRgbConversionFeaturesValve != null)
                {
                    SharpVk.Interop.Valve.PhysicalDeviceVideoEncodeRgbConversionFeatures* extensionPointer = default(SharpVk.Interop.Valve.PhysicalDeviceVideoEncodeRgbConversionFeatures*);
                    extensionPointer = (SharpVk.Interop.Valve.PhysicalDeviceVideoEncodeRgbConversionFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Valve.PhysicalDeviceVideoEncodeRgbConversionFeatures>());
                    physicalDeviceVideoEncodeRgbConversionFeaturesValve.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShader64BitIndexingFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShader64BitIndexingFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShader64BitIndexingFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShader64BitIndexingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShader64BitIndexingFeatures>());
                    physicalDeviceShader64BitIndexingFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceQueuePerfHintFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceQueuePerfHintFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceQueuePerfHintFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceQueuePerfHintFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceQueuePerfHintFeatures>());
                    physicalDeviceQueuePerfHintFeaturesQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePerformanceCountersByRegionFeaturesArm != null)
                {
                    SharpVk.Interop.Arm.PhysicalDevicePerformanceCountersByRegionFeatures* extensionPointer = default(SharpVk.Interop.Arm.PhysicalDevicePerformanceCountersByRegionFeatures*);
                    extensionPointer = (SharpVk.Interop.Arm.PhysicalDevicePerformanceCountersByRegionFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDevicePerformanceCountersByRegionFeatures>());
                    physicalDevicePerformanceCountersByRegionFeaturesArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceComputeOccupancyPriorityFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceComputeOccupancyPriorityFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceComputeOccupancyPriorityFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceComputeOccupancyPriorityFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceComputeOccupancyPriorityFeatures>());
                    physicalDeviceComputeOccupancyPriorityFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderLongVectorFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderLongVectorFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShaderLongVectorFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderLongVectorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderLongVectorFeatures>());
                    physicalDeviceShaderLongVectorFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTextureCompressionASTC3DFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceTextureCompressionASTC3DFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceTextureCompressionASTC3DFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceTextureCompressionASTC3DFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceTextureCompressionASTC3DFeatures>());
                    physicalDeviceTextureCompressionASTC3DFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderSubgroupPartitionedFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderSubgroupPartitionedFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShaderSubgroupPartitionedFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderSubgroupPartitionedFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderSubgroupPartitionedFeatures>());
                    physicalDeviceShaderSubgroupPartitionedFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderSplitBarrierFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderSplitBarrierFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShaderSplitBarrierFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderSplitBarrierFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderSplitBarrierFeatures>());
                    physicalDeviceShaderSplitBarrierFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDescriptorHeapFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceDescriptorHeapFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceDescriptorHeapFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceDescriptorHeapFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceDescriptorHeapFeatures>());
                    physicalDeviceDescriptorHeapFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderInstrumentationFeaturesArm != null)
                {
                    SharpVk.Interop.Arm.PhysicalDeviceShaderInstrumentationFeatures* extensionPointer = default(SharpVk.Interop.Arm.PhysicalDeviceShaderInstrumentationFeatures*);
                    extensionPointer = (SharpVk.Interop.Arm.PhysicalDeviceShaderInstrumentationFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDeviceShaderInstrumentationFeatures>());
                    physicalDeviceShaderInstrumentationFeaturesArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDeviceAddressCommandsFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceDeviceAddressCommandsFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceDeviceAddressCommandsFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceDeviceAddressCommandsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceDeviceAddressCommandsFeatures>());
                    physicalDeviceDeviceAddressCommandsFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderConstantDataFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceShaderConstantDataFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceShaderConstantDataFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceShaderConstantDataFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceShaderConstantDataFeatures>());
                    physicalDeviceShaderConstantDataFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderAbortFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceShaderAbortFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceShaderAbortFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceShaderAbortFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceShaderAbortFeatures>());
                    physicalDeviceShaderAbortFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDataGraphOpticalFlowFeaturesArm != null)
                {
                    SharpVk.Interop.Arm.PhysicalDeviceDataGraphOpticalFlowFeatures* extensionPointer = default(SharpVk.Interop.Arm.PhysicalDeviceDataGraphOpticalFlowFeatures*);
                    extensionPointer = (SharpVk.Interop.Arm.PhysicalDeviceDataGraphOpticalFlowFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDeviceDataGraphOpticalFlowFeatures>());
                    physicalDeviceDataGraphOpticalFlowFeaturesArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImageTilingControlFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceImageTilingControlFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceImageTilingControlFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceImageTilingControlFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceImageTilingControlFeatures>());
                    physicalDeviceImageTilingControlFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderOCPMicroscalingTypesFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderOCPMicroscalingTypesFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceShaderOCPMicroscalingTypesFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderOCPMicroscalingTypesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderOCPMicroscalingTypesFeatures>());
                    physicalDeviceShaderOCPMicroscalingTypesFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCooperativeMatrixMaintenance1FeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceCooperativeMatrixMaintenance1Features* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceCooperativeMatrixMaintenance1Features*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceCooperativeMatrixMaintenance1Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceCooperativeMatrixMaintenance1Features>());
                    physicalDeviceCooperativeMatrixMaintenance1FeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceBufferDeviceAddressAllocationAlignmentFeaturesValve != null)
                {
                    SharpVk.Interop.Valve.PhysicalDeviceBufferDeviceAddressAllocationAlignmentFeatures* extensionPointer = default(SharpVk.Interop.Valve.PhysicalDeviceBufferDeviceAddressAllocationAlignmentFeatures*);
                    extensionPointer = (SharpVk.Interop.Valve.PhysicalDeviceBufferDeviceAddressAllocationAlignmentFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Valve.PhysicalDeviceBufferDeviceAddressAllocationAlignmentFeatures>());
                    physicalDeviceBufferDeviceAddressAllocationAlignmentFeaturesValve.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.DeviceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DeviceCreateInfo;
                marshalledCreateInfo->Next = vkDeviceCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.DeviceCreateFlags);
                }
                marshalledCreateInfo->QueueCreateInfoCount = (uint)(Interop.HeapUtil.GetLength(queueCreateInfos));
                if (queueCreateInfos.IsNull())
                {
                    marshalledCreateInfo->QueueCreateInfos = null;
                }
                else
                {
                    if (queueCreateInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->QueueCreateInfos = (SharpVk.Interop.DeviceQueueCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceQueueCreateInfo>());
                        queueCreateInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.DeviceQueueCreateInfo*)(marshalledCreateInfo->QueueCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.DeviceQueueCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DeviceQueueCreateInfo>(Interop.HeapUtil.GetLength(queueCreateInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(queueCreateInfos.Value)); index++)
                        {
                            queueCreateInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfo->QueueCreateInfos = fieldPointer;
                    }
                }
                marshalledCreateInfo->EnabledLayerCount = (uint)(Interop.HeapUtil.GetLength(enabledLayerNames));
                marshalledCreateInfo->EnabledLayerNames = Interop.HeapUtil.MarshalTo(enabledLayerNames);
                marshalledCreateInfo->EnabledExtensionCount = (uint)(Interop.HeapUtil.GetLength(enabledExtensionNames));
                marshalledCreateInfo->EnabledExtensionNames = Interop.HeapUtil.MarshalTo(enabledExtensionNames);
                if (enabledFeatures != null)
                {
                    marshalledCreateInfo->EnabledFeatures = (SharpVk.Interop.PhysicalDeviceFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceFeatures>());
                    enabledFeatures.Value.MarshalTo(marshalledCreateInfo->EnabledFeatures);
                }
                else
                {
                    marshalledCreateInfo->EnabledFeatures = default(SharpVk.Interop.PhysicalDeviceFeatures*);
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkPhysicalDeviceCreateDeviceDelegate commandDelegate = commandCache.Cache.vkCreateDevice;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledDevice);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Device(this, marshalledDevice);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Returns properties of available physical device extensions.
        /// </summary>
        /// <param name="layerName">
        /// </param>
        public unsafe SharpVk.ExtensionProperties[] EnumerateDeviceExtensionProperties(string layerName)
        {
            try
            {
                SharpVk.ExtensionProperties[] result = default(SharpVk.ExtensionProperties[]);
                uint marshalledPropertyCount = default(uint);
                SharpVk.Interop.ExtensionProperties* marshalledProperties = default(SharpVk.Interop.ExtensionProperties*);
                SharpVk.Interop.VkPhysicalDeviceEnumerateDeviceExtensionPropertiesDelegate commandDelegate = commandCache.Cache.vkEnumerateDeviceExtensionProperties;
                Result methodResult = commandDelegate(this.handle, Interop.HeapUtil.MarshalTo(layerName), &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.ExtensionProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExtensionProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(this.handle, Interop.HeapUtil.MarshalTo(layerName), &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.ExtensionProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.ExtensionProperties.MarshalFrom(&marshalledProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Returns properties of available physical device layers.
        /// </summary>
        public unsafe SharpVk.LayerProperties[] EnumerateDeviceLayerProperties()
        {
            try
            {
                SharpVk.LayerProperties[] result = default(SharpVk.LayerProperties[]);
                uint marshalledPropertyCount = default(uint);
                SharpVk.Interop.LayerProperties* marshalledProperties = default(SharpVk.Interop.LayerProperties*);
                SharpVk.Interop.VkPhysicalDeviceEnumerateDeviceLayerPropertiesDelegate commandDelegate = commandCache.Cache.vkEnumerateDeviceLayerProperties;
                Result methodResult = commandDelegate(this.handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.LayerProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.LayerProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(this.handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.LayerProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.LayerProperties.MarshalFrom(&marshalledProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Retrieve properties of an image format applied to sparse images.
        /// </summary>
        /// <param name="format">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="samples">
        /// </param>
        /// <param name="usage">
        /// </param>
        /// <param name="tiling">
        /// </param>
        public unsafe SharpVk.SparseImageFormatProperties[] GetSparseImageFormatProperties(SharpVk.Format format, SharpVk.ImageType type, SharpVk.SampleCountFlags samples, SharpVk.ImageUsageFlags usage, SharpVk.ImageTiling tiling)
        {
            try
            {
                SharpVk.SparseImageFormatProperties[] result = default(SharpVk.SparseImageFormatProperties[]);
                uint marshalledPropertyCount = default(uint);
                SharpVk.SparseImageFormatProperties* marshalledProperties = default(SharpVk.SparseImageFormatProperties*);
                SharpVk.Interop.VkPhysicalDeviceGetSparseImageFormatPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSparseImageFormatProperties;
                commandDelegate(this.handle, format, type, samples, usage, tiling, &marshalledPropertyCount, marshalledProperties);
                marshalledProperties = (SharpVk.SparseImageFormatProperties*)(Interop.HeapUtil.Allocate<SharpVk.SparseImageFormatProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(this.handle, format, type, samples, usage, tiling, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.SparseImageFormatProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = marshalledProperties[index];
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.PhysicalDeviceFeatures2 GetFeatures2()
        {
            try
            {
                SharpVk.PhysicalDeviceFeatures2 result = default(SharpVk.PhysicalDeviceFeatures2);
                SharpVk.Interop.PhysicalDeviceFeatures2 marshalledFeatures = default(SharpVk.Interop.PhysicalDeviceFeatures2);
                SharpVk.Interop.VkPhysicalDeviceGetFeatures2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceFeatures2;
                commandDelegate(this.handle, &marshalledFeatures);
                result = SharpVk.PhysicalDeviceFeatures2.MarshalFrom(&marshalledFeatures);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.PhysicalDeviceProperties2 GetProperties2()
        {
            try
            {
                SharpVk.PhysicalDeviceProperties2 result = default(SharpVk.PhysicalDeviceProperties2);
                SharpVk.Interop.PhysicalDeviceProperties2 marshalledProperties = default(SharpVk.Interop.PhysicalDeviceProperties2);
                SharpVk.Interop.VkPhysicalDeviceGetProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceProperties2;
                commandDelegate(this.handle, &marshalledProperties);
                result = SharpVk.PhysicalDeviceProperties2.MarshalFrom(&marshalledProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="format">
        /// </param>
        public unsafe SharpVk.FormatProperties2 GetFormatProperties2(SharpVk.Format format)
        {
            try
            {
                SharpVk.FormatProperties2 result = default(SharpVk.FormatProperties2);
                SharpVk.Interop.FormatProperties2 marshalledFormatProperties = default(SharpVk.Interop.FormatProperties2);
                SharpVk.Interop.VkPhysicalDeviceGetFormatProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceFormatProperties2;
                commandDelegate(this.handle, format, &marshalledFormatProperties);
                result = SharpVk.FormatProperties2.MarshalFrom(&marshalledFormatProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageFormatInfo">
        /// </param>
        public unsafe SharpVk.ImageFormatProperties2 GetImageFormatProperties2(SharpVk.PhysicalDeviceImageFormatInfo2 imageFormatInfo)
        {
            try
            {
                SharpVk.ImageFormatProperties2 result = default(SharpVk.ImageFormatProperties2);
                SharpVk.Interop.PhysicalDeviceImageFormatInfo2* marshalledImageFormatInfo = default(SharpVk.Interop.PhysicalDeviceImageFormatInfo2*);
                SharpVk.Interop.ImageFormatProperties2 marshalledImageFormatProperties = default(SharpVk.Interop.ImageFormatProperties2);
                marshalledImageFormatInfo = (SharpVk.Interop.PhysicalDeviceImageFormatInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceImageFormatInfo2>());
                imageFormatInfo.MarshalTo(marshalledImageFormatInfo);
                SharpVk.Interop.VkPhysicalDeviceGetImageFormatProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceImageFormatProperties2;
                Result methodResult = commandDelegate(this.handle, marshalledImageFormatInfo, &marshalledImageFormatProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.ImageFormatProperties2.MarshalFrom(&marshalledImageFormatProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.QueueFamilyProperties2[] GetQueueFamilyProperties2()
        {
            try
            {
                SharpVk.QueueFamilyProperties2[] result = default(SharpVk.QueueFamilyProperties2[]);
                uint marshalledQueueFamilyPropertyCount = default(uint);
                SharpVk.Interop.QueueFamilyProperties2* marshalledQueueFamilyProperties = default(SharpVk.Interop.QueueFamilyProperties2*);
                SharpVk.Interop.VkPhysicalDeviceGetQueueFamilyProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceQueueFamilyProperties2;
                commandDelegate(this.handle, &marshalledQueueFamilyPropertyCount, marshalledQueueFamilyProperties);
                marshalledQueueFamilyProperties = (SharpVk.Interop.QueueFamilyProperties2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.QueueFamilyProperties2>((uint)(marshalledQueueFamilyPropertyCount)));
                commandDelegate(this.handle, &marshalledQueueFamilyPropertyCount, marshalledQueueFamilyProperties);
                if (marshalledQueueFamilyProperties != null)
                {
                    var fieldPointer = new SharpVk.QueueFamilyProperties2[(uint)(marshalledQueueFamilyPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledQueueFamilyPropertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.QueueFamilyProperties2.MarshalFrom(&marshalledQueueFamilyProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.PhysicalDeviceMemoryProperties2 GetMemoryProperties2()
        {
            try
            {
                SharpVk.PhysicalDeviceMemoryProperties2 result = default(SharpVk.PhysicalDeviceMemoryProperties2);
                SharpVk.Interop.PhysicalDeviceMemoryProperties2 marshalledMemoryProperties = default(SharpVk.Interop.PhysicalDeviceMemoryProperties2);
                SharpVk.Interop.VkPhysicalDeviceGetMemoryProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceMemoryProperties2;
                commandDelegate(this.handle, &marshalledMemoryProperties);
                result = SharpVk.PhysicalDeviceMemoryProperties2.MarshalFrom(&marshalledMemoryProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="formatInfo">
        /// </param>
        public unsafe SharpVk.SparseImageFormatProperties2[] GetSparseImageFormatProperties2(SharpVk.PhysicalDeviceSparseImageFormatInfo2 formatInfo)
        {
            try
            {
                SharpVk.SparseImageFormatProperties2[] result = default(SharpVk.SparseImageFormatProperties2[]);
                uint marshalledPropertyCount = default(uint);
                SharpVk.Interop.PhysicalDeviceSparseImageFormatInfo2* marshalledFormatInfo = default(SharpVk.Interop.PhysicalDeviceSparseImageFormatInfo2*);
                SharpVk.Interop.SparseImageFormatProperties2* marshalledProperties = default(SharpVk.Interop.SparseImageFormatProperties2*);
                marshalledFormatInfo = (SharpVk.Interop.PhysicalDeviceSparseImageFormatInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceSparseImageFormatInfo2>());
                formatInfo.MarshalTo(marshalledFormatInfo);
                SharpVk.Interop.VkPhysicalDeviceGetSparseImageFormatProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSparseImageFormatProperties2;
                commandDelegate(this.handle, marshalledFormatInfo, &marshalledPropertyCount, marshalledProperties);
                marshalledProperties = (SharpVk.Interop.SparseImageFormatProperties2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SparseImageFormatProperties2>((uint)(marshalledPropertyCount)));
                commandDelegate(this.handle, marshalledFormatInfo, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.SparseImageFormatProperties2[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.SparseImageFormatProperties2.MarshalFrom(&marshalledProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="externalBufferInfo">
        /// </param>
        public unsafe SharpVk.ExternalBufferProperties GetExternalBufferProperties(SharpVk.PhysicalDeviceExternalBufferInfo externalBufferInfo)
        {
            try
            {
                SharpVk.ExternalBufferProperties result = default(SharpVk.ExternalBufferProperties);
                SharpVk.Interop.PhysicalDeviceExternalBufferInfo* marshalledExternalBufferInfo = default(SharpVk.Interop.PhysicalDeviceExternalBufferInfo*);
                SharpVk.Interop.ExternalBufferProperties marshalledExternalBufferProperties = default(SharpVk.Interop.ExternalBufferProperties);
                marshalledExternalBufferInfo = (SharpVk.Interop.PhysicalDeviceExternalBufferInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceExternalBufferInfo>());
                externalBufferInfo.MarshalTo(marshalledExternalBufferInfo);
                SharpVk.Interop.VkPhysicalDeviceGetExternalBufferPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalBufferProperties;
                commandDelegate(this.handle, marshalledExternalBufferInfo, &marshalledExternalBufferProperties);
                result = SharpVk.ExternalBufferProperties.MarshalFrom(&marshalledExternalBufferProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="externalFenceInfo">
        /// </param>
        public unsafe SharpVk.ExternalFenceProperties GetExternalFenceProperties(SharpVk.PhysicalDeviceExternalFenceInfo externalFenceInfo)
        {
            try
            {
                SharpVk.ExternalFenceProperties result = default(SharpVk.ExternalFenceProperties);
                SharpVk.Interop.PhysicalDeviceExternalFenceInfo* marshalledExternalFenceInfo = default(SharpVk.Interop.PhysicalDeviceExternalFenceInfo*);
                SharpVk.Interop.ExternalFenceProperties marshalledExternalFenceProperties = default(SharpVk.Interop.ExternalFenceProperties);
                marshalledExternalFenceInfo = (SharpVk.Interop.PhysicalDeviceExternalFenceInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceExternalFenceInfo>());
                externalFenceInfo.MarshalTo(marshalledExternalFenceInfo);
                SharpVk.Interop.VkPhysicalDeviceGetExternalFencePropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalFenceProperties;
                commandDelegate(this.handle, marshalledExternalFenceInfo, &marshalledExternalFenceProperties);
                result = SharpVk.ExternalFenceProperties.MarshalFrom(&marshalledExternalFenceProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="externalSemaphoreInfo">
        /// </param>
        public unsafe SharpVk.ExternalSemaphoreProperties GetExternalSemaphoreProperties(SharpVk.PhysicalDeviceExternalSemaphoreInfo externalSemaphoreInfo)
        {
            try
            {
                SharpVk.ExternalSemaphoreProperties result = default(SharpVk.ExternalSemaphoreProperties);
                SharpVk.Interop.PhysicalDeviceExternalSemaphoreInfo* marshalledExternalSemaphoreInfo = default(SharpVk.Interop.PhysicalDeviceExternalSemaphoreInfo*);
                SharpVk.Interop.ExternalSemaphoreProperties marshalledExternalSemaphoreProperties = default(SharpVk.Interop.ExternalSemaphoreProperties);
                marshalledExternalSemaphoreInfo = (SharpVk.Interop.PhysicalDeviceExternalSemaphoreInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceExternalSemaphoreInfo>());
                externalSemaphoreInfo.MarshalTo(marshalledExternalSemaphoreInfo);
                SharpVk.Interop.VkPhysicalDeviceGetExternalSemaphorePropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalSemaphoreProperties;
                commandDelegate(this.handle, marshalledExternalSemaphoreInfo, &marshalledExternalSemaphoreProperties);
                result = SharpVk.ExternalSemaphoreProperties.MarshalFrom(&marshalledExternalSemaphoreProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.PhysicalDeviceToolProperties[] GetToolProperties()
        {
            try
            {
                SharpVk.PhysicalDeviceToolProperties[] result = default(SharpVk.PhysicalDeviceToolProperties[]);
                uint marshalledToolCount = default(uint);
                SharpVk.Interop.PhysicalDeviceToolProperties* marshalledToolProperties = default(SharpVk.Interop.PhysicalDeviceToolProperties*);
                SharpVk.Interop.VkPhysicalDeviceGetToolPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceToolProperties;
                Result methodResult = commandDelegate(this.handle, &marshalledToolCount, marshalledToolProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledToolProperties = (SharpVk.Interop.PhysicalDeviceToolProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceToolProperties>((uint)(marshalledToolCount)));
                commandDelegate(this.handle, &marshalledToolCount, marshalledToolProperties);
                if (marshalledToolProperties != null)
                {
                    var fieldPointer = new SharpVk.PhysicalDeviceToolProperties[(uint)(marshalledToolCount)];
                    for(int index = 0; index < (uint)(marshalledToolCount); index++)
                    {
                        fieldPointer[index] = SharpVk.PhysicalDeviceToolProperties.MarshalFrom(&marshalledToolProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
