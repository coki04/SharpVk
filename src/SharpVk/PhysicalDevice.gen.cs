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
        
        internal PhysicalDevice(SharpVk.Instance parent, SharpVk.Interop.PhysicalDevice handle)
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
        /// <param name="physicalDeviceDeviceGeneratedCommandsFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="devicePrivateDataCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePrivateDataFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFeatures2">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVariablePointersFeatures">
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
        /// <param name="physicalDevicePresentWaitFeaturesKhr">
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
        /// <param name="physicalDeviceShaderDrawParametersFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderFloat16Int8Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceHostQueryResetFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceGlobalPriorityQueryFeaturesKhr">
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
        /// <param name="physicalDeviceVertexAttributeDivisorFeaturesExt">
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
        /// <param name="physicalDeviceComputeShaderDerivativesFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderImageFootprintFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDedicatedAllocationImageAliasingFeaturesNv">
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
        /// <param name="physicalDeviceFragmentDensityMapOffsetFeaturesQcom">
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
        /// <param name="physicalDeviceCoverageReductionModeFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderIntegerFunctions2FeaturesIntel">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderClockFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceIndexTypeUint8FeaturesExt">
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
        /// <param name="physicalDeviceLineRasterizationFeaturesExt">
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
        /// <param name="physicalDeviceCoherentMemoryFeaturesAmd">
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
        /// <param name="physicalDeviceRobustness2FeaturesExt">
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
        /// <param name="physicalDeviceMutableDescriptorTypeFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDepthClipControlFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVertexInputDynamicStateFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExternalMemoryRDMAFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceColorWriteEnableFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceSynchronization2Features">
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
        /// <param name="physicalDevicePipelineProtectedAccessFeaturesExt">
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
        /// <param name="physicalDeviceShaderIntegerDotProductFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentShaderBarycentricFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRayTracingMotionBlurFeaturesNv">
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
        /// <param name="physicalDeviceDescriptorSetHostMappingFeaturesValve">
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
        /// <param name="physicalDeviceOpacityMicromapFeaturesExt">
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
        /// <param name="physicalDevicePipelineRobustnessFeaturesExt">
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
        /// <param name="physicalDeviceDepthClampZeroOneFeaturesExt">
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
        /// <param name="physicalDeviceShaderCoreBuiltinsFeaturesArm">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.Device CreateDevice(ArrayProxy<SharpVk.DeviceQueueCreateInfo>? queueCreateInfos, ArrayProxy<string>? enabledLayerNames, ArrayProxy<string>? enabledExtensionNames, SharpVk.DeviceCreateFlags? flags = default(SharpVk.DeviceCreateFlags?), SharpVk.PhysicalDeviceFeatures? enabledFeatures = default(SharpVk.PhysicalDeviceFeatures?), SharpVk.NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures? physicalDeviceDeviceGeneratedCommandsFeaturesNv = null, SharpVk.DevicePrivateDataCreateInfo? devicePrivateDataCreateInfo = null, SharpVk.PhysicalDevicePrivateDataFeatures? physicalDevicePrivateDataFeatures = null, SharpVk.PhysicalDeviceFeatures2? physicalDeviceFeatures2 = null, SharpVk.PhysicalDeviceVariablePointersFeatures? physicalDeviceVariablePointersFeatures = null, SharpVk.PhysicalDeviceMultiviewFeatures? physicalDeviceMultiviewFeatures = null, SharpVk.DeviceGroupDeviceCreateInfo? deviceGroupDeviceCreateInfo = null, SharpVk.Khronos.PhysicalDevicePresentIdFeatures? physicalDevicePresentIdFeaturesKhr = null, SharpVk.Khronos.PhysicalDevicePresentWaitFeatures? physicalDevicePresentWaitFeaturesKhr = null, SharpVk.PhysicalDevice16BitStorageFeatures? physicalDevice16BitStorageFeatures = null, SharpVk.PhysicalDeviceShaderSubgroupExtendedTypesFeatures? physicalDeviceShaderSubgroupExtendedTypesFeatures = null, SharpVk.PhysicalDeviceSamplerYcbcrConversionFeatures? physicalDeviceSamplerYcbcrConversionFeatures = null, SharpVk.PhysicalDeviceProtectedMemoryFeatures? physicalDeviceProtectedMemoryFeatures = null, SharpVk.Multivendor.PhysicalDeviceBlendOperationAdvancedFeatures? physicalDeviceBlendOperationAdvancedFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceMultiDrawFeatures? physicalDeviceMultiDrawFeaturesExt = null, SharpVk.PhysicalDeviceInlineUniformBlockFeatures? physicalDeviceInlineUniformBlockFeatures = null, SharpVk.PhysicalDeviceMaintenance4Features? physicalDeviceMaintenance4Features = null, SharpVk.PhysicalDeviceShaderDrawParametersFeatures? physicalDeviceShaderDrawParametersFeatures = null, SharpVk.PhysicalDeviceShaderFloat16Int8Features? physicalDeviceShaderFloat16Int8Features = null, SharpVk.PhysicalDeviceHostQueryResetFeatures? physicalDeviceHostQueryResetFeatures = null, SharpVk.Khronos.PhysicalDeviceGlobalPriorityQueryFeatures? physicalDeviceGlobalPriorityQueryFeaturesKhr = null, SharpVk.Multivendor.PhysicalDeviceDeviceMemoryReportFeatures? physicalDeviceDeviceMemoryReportFeaturesExt = null, SharpVk.Multivendor.DeviceDeviceMemoryReportCreateInfo? deviceDeviceMemoryReportCreateInfoExt = null, SharpVk.PhysicalDeviceDescriptorIndexingFeatures? physicalDeviceDescriptorIndexingFeatures = null, SharpVk.PhysicalDeviceTimelineSemaphoreFeatures? physicalDeviceTimelineSemaphoreFeatures = null, SharpVk.PhysicalDevice8BitStorageFeatures? physicalDevice8BitStorageFeatures = null, SharpVk.Multivendor.PhysicalDeviceConditionalRenderingFeatures? physicalDeviceConditionalRenderingFeaturesExt = null, SharpVk.PhysicalDeviceVulkanMemoryModelFeatures? physicalDeviceVulkanMemoryModelFeatures = null, SharpVk.PhysicalDeviceShaderAtomicInt64Features? physicalDeviceShaderAtomicInt64Features = null, SharpVk.Multivendor.PhysicalDeviceShaderAtomicFloatFeatures? physicalDeviceShaderAtomicFloatFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceShaderAtomicFloat2Features? physicalDeviceShaderAtomicFloat2FeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceVertexAttributeDivisorFeatures? physicalDeviceVertexAttributeDivisorFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceASTCDecodeFeatures? physicalDeviceASTCDecodeFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceTransformFeedbackFeatures? physicalDeviceTransformFeedbackFeaturesExt = null, SharpVk.NVidia.PhysicalDeviceRepresentativeFragmentTestFeatures? physicalDeviceRepresentativeFragmentTestFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceExclusiveScissorFeatures? physicalDeviceExclusiveScissorFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceCornerSampledImageFeatures? physicalDeviceCornerSampledImageFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceComputeShaderDerivativesFeatures? physicalDeviceComputeShaderDerivativesFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceShaderImageFootprintFeatures? physicalDeviceShaderImageFootprintFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceDedicatedAllocationImageAliasingFeatures? physicalDeviceDedicatedAllocationImageAliasingFeaturesNv = null, SharpVk.NVidia.PhysicalDeviceShadingRateImageFeatures? physicalDeviceShadingRateImageFeaturesNv = null, SharpVk.Huawei.PhysicalDeviceInvocationMaskFeatures? physicalDeviceInvocationMaskFeaturesHuawei = null, SharpVk.NVidia.PhysicalDeviceMeshShaderFeatures? physicalDeviceMeshShaderFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceMeshShaderFeatures? physicalDeviceMeshShaderFeaturesExt = null, SharpVk.Khronos.PhysicalDeviceAccelerationStructureFeatures? physicalDeviceAccelerationStructureFeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceRayTracingPipelineFeatures? physicalDeviceRayTracingPipelineFeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceRayQueryFeatures? physicalDeviceRayQueryFeaturesKhr = null, SharpVk.Khronos.PhysicalDeviceRayTracingMaintenance1Features? physicalDeviceRayTracingMaintenance1FeaturesKhr = null, SharpVk.Amd.DeviceMemoryOverallocationCreateInfo? deviceMemoryOverallocationCreateInfoAmd = null, SharpVk.Multivendor.PhysicalDeviceFragmentDensityMapFeatures? physicalDeviceFragmentDensityMapFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceFragmentDensityMap2Features? physicalDeviceFragmentDensityMap2FeaturesExt = null, SharpVk.Qcom.PhysicalDeviceFragmentDensityMapOffsetFeatures? physicalDeviceFragmentDensityMapOffsetFeaturesQcom = null, SharpVk.PhysicalDeviceScalarBlockLayoutFeatures? physicalDeviceScalarBlockLayoutFeatures = null, SharpVk.PhysicalDeviceUniformBufferStandardLayoutFeatures? physicalDeviceUniformBufferStandardLayoutFeatures = null, SharpVk.Multivendor.PhysicalDeviceDepthClipEnableFeatures? physicalDeviceDepthClipEnableFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceMemoryPriorityFeatures? physicalDeviceMemoryPriorityFeaturesExt = null, SharpVk.Multivendor.PhysicalDevicePageableDeviceLocalMemoryFeatures? physicalDevicePageableDeviceLocalMemoryFeaturesExt = null, SharpVk.PhysicalDeviceBufferDeviceAddressFeatures? physicalDeviceBufferDeviceAddressFeatures = null, SharpVk.Multivendor.PhysicalDeviceBufferDeviceAddressFeatures? physicalDeviceBufferDeviceAddressFeaturesExt = null, SharpVk.PhysicalDeviceImagelessFramebufferFeatures? physicalDeviceImagelessFramebufferFeatures = null, SharpVk.PhysicalDeviceTextureCompressionASTCHDRFeatures? physicalDeviceTextureCompressionASTCHDRFeatures = null, SharpVk.NVidia.PhysicalDeviceCooperativeMatrixFeatures? physicalDeviceCooperativeMatrixFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceYcbcrImageArraysFeatures? physicalDeviceYcbcrImageArraysFeaturesExt = null, SharpVk.NVidia.PhysicalDevicePresentBarrierFeatures? physicalDevicePresentBarrierFeaturesNv = null, SharpVk.Khronos.PhysicalDevicePerformanceQueryFeatures? physicalDevicePerformanceQueryFeaturesKhr = null, SharpVk.NVidia.PhysicalDeviceCoverageReductionModeFeatures? physicalDeviceCoverageReductionModeFeaturesNv = null, SharpVk.Intel.PhysicalDeviceShaderIntegerFunctions2Features? physicalDeviceShaderIntegerFunctions2FeaturesIntel = null, SharpVk.Khronos.PhysicalDeviceShaderClockFeatures? physicalDeviceShaderClockFeaturesKhr = null, SharpVk.Multivendor.PhysicalDeviceIndexTypeUint8Features? physicalDeviceIndexTypeUint8FeaturesExt = null, SharpVk.NVidia.PhysicalDeviceShaderSMBuiltinsFeatures? physicalDeviceShaderSMBuiltinsFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceFragmentShaderInterlockFeatures? physicalDeviceFragmentShaderInterlockFeaturesExt = null, SharpVk.PhysicalDeviceSeparateDepthStencilLayoutsFeatures? physicalDeviceSeparateDepthStencilLayoutsFeatures = null, SharpVk.Multivendor.PhysicalDevicePrimitiveTopologyListRestartFeatures? physicalDevicePrimitiveTopologyListRestartFeaturesExt = null, SharpVk.Khronos.PhysicalDevicePipelineExecutablePropertiesFeatures? physicalDevicePipelineExecutablePropertiesFeaturesKhr = null, SharpVk.PhysicalDeviceShaderDemoteToHelperInvocationFeatures? physicalDeviceShaderDemoteToHelperInvocationFeatures = null, SharpVk.Multivendor.PhysicalDeviceTexelBufferAlignmentFeatures? physicalDeviceTexelBufferAlignmentFeaturesExt = null, SharpVk.PhysicalDeviceSubgroupSizeControlFeatures? physicalDeviceSubgroupSizeControlFeatures = null, SharpVk.Multivendor.PhysicalDeviceLineRasterizationFeatures? physicalDeviceLineRasterizationFeaturesExt = null, SharpVk.PhysicalDevicePipelineCreationCacheControlFeatures? physicalDevicePipelineCreationCacheControlFeatures = null, SharpVk.PhysicalDeviceVulkan11Features? physicalDeviceVulkan11Features = null, SharpVk.PhysicalDeviceVulkan12Features? physicalDeviceVulkan12Features = null, SharpVk.PhysicalDeviceVulkan13Features? physicalDeviceVulkan13Features = null, SharpVk.Amd.PhysicalDeviceCoherentMemoryFeatures? physicalDeviceCoherentMemoryFeaturesAmd = null, SharpVk.Multivendor.PhysicalDeviceCustomBorderColorFeatures? physicalDeviceCustomBorderColorFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceBorderColorSwizzleFeatures? physicalDeviceBorderColorSwizzleFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceExtendedDynamicStateFeatures? physicalDeviceExtendedDynamicStateFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceExtendedDynamicState2Features? physicalDeviceExtendedDynamicState2FeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceExtendedDynamicState3Features? physicalDeviceExtendedDynamicState3FeaturesExt = null, SharpVk.NVidia.PhysicalDeviceDiagnosticsConfigFeatures? physicalDeviceDiagnosticsConfigFeaturesNv = null, SharpVk.NVidia.DeviceDiagnosticsConfigCreateInfo? deviceDiagnosticsConfigCreateInfoNv = null, SharpVk.PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures? physicalDeviceZeroInitializeWorkgroupMemoryFeatures = null, SharpVk.Khronos.PhysicalDeviceShaderSubgroupUniformControlFlowFeatures? physicalDeviceShaderSubgroupUniformControlFlowFeaturesKhr = null, SharpVk.Multivendor.PhysicalDeviceRobustness2Features? physicalDeviceRobustness2FeaturesExt = null, SharpVk.PhysicalDeviceImageRobustnessFeatures? physicalDeviceImageRobustnessFeatures = null, SharpVk.Khronos.PhysicalDeviceWorkgroupMemoryExplicitLayoutFeatures? physicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKhr = null, SharpVk.Khronos.PhysicalDevicePortabilitySubsetFeatures? physicalDevicePortabilitySubsetFeaturesKhr = null, SharpVk.Multivendor.PhysicalDevice4444FormatsFeatures? physicalDevice4444FormatsFeaturesExt = null, SharpVk.Huawei.PhysicalDeviceSubpassShadingFeatures? physicalDeviceSubpassShadingFeaturesHuawei = null, SharpVk.Multivendor.PhysicalDeviceShaderImageAtomicInt64Features? physicalDeviceShaderImageAtomicInt64FeaturesExt = null, SharpVk.Khronos.PhysicalDeviceFragmentShadingRateFeatures? physicalDeviceFragmentShadingRateFeaturesKhr = null, SharpVk.PhysicalDeviceShaderTerminateInvocationFeatures? physicalDeviceShaderTerminateInvocationFeatures = null, SharpVk.NVidia.PhysicalDeviceFragmentShadingRateEnumsFeatures? physicalDeviceFragmentShadingRateEnumsFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceImage2DViewOf3DFeatures? physicalDeviceImage2DViewOf3DFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceMutableDescriptorTypeFeatures? physicalDeviceMutableDescriptorTypeFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceDepthClipControlFeatures? physicalDeviceDepthClipControlFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceVertexInputDynamicStateFeatures? physicalDeviceVertexInputDynamicStateFeaturesExt = null, SharpVk.NVidia.PhysicalDeviceExternalMemoryRDMAFeatures? physicalDeviceExternalMemoryRDMAFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceColorWriteEnableFeatures? physicalDeviceColorWriteEnableFeaturesExt = null, SharpVk.PhysicalDeviceSynchronization2Features? physicalDeviceSynchronization2Features = null, SharpVk.Multivendor.PhysicalDevicePrimitivesGeneratedQueryFeatures? physicalDevicePrimitivesGeneratedQueryFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceLegacyDitheringFeatures? physicalDeviceLegacyDitheringFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceMultisampledRenderToSingleSampledFeatures? physicalDeviceMultisampledRenderToSingleSampledFeaturesExt = null, SharpVk.Multivendor.PhysicalDevicePipelineProtectedAccessFeatures? physicalDevicePipelineProtectedAccessFeaturesExt = null, SharpVk.NVidia.PhysicalDeviceInheritedViewportScissorFeatures? physicalDeviceInheritedViewportScissorFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceYcbcr2Plane444FormatsFeatures? physicalDeviceYcbcr2Plane444FormatsFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceProvokingVertexFeatures? physicalDeviceProvokingVertexFeaturesExt = null, SharpVk.PhysicalDeviceShaderIntegerDotProductFeatures? physicalDeviceShaderIntegerDotProductFeatures = null, SharpVk.Khronos.PhysicalDeviceFragmentShaderBarycentricFeatures? physicalDeviceFragmentShaderBarycentricFeaturesKhr = null, SharpVk.NVidia.PhysicalDeviceRayTracingMotionBlurFeatures? physicalDeviceRayTracingMotionBlurFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceRGBA10X6FormatsFeatures? physicalDeviceRGBA10X6FormatsFeaturesExt = null, SharpVk.PhysicalDeviceDynamicRenderingFeatures? physicalDeviceDynamicRenderingFeatures = null, SharpVk.Multivendor.PhysicalDeviceImageViewMinLodFeatures? physicalDeviceImageViewMinLodFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceRasterizationOrderAttachmentAccessFeatures? physicalDeviceRasterizationOrderAttachmentAccessFeaturesExt = null, SharpVk.NVidia.PhysicalDeviceLinearColorAttachmentFeatures? physicalDeviceLinearColorAttachmentFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceGraphicsPipelineLibraryFeatures? physicalDeviceGraphicsPipelineLibraryFeaturesExt = null, SharpVk.Valve.PhysicalDeviceDescriptorSetHostMappingFeatures? physicalDeviceDescriptorSetHostMappingFeaturesValve = null, SharpVk.Multivendor.PhysicalDeviceShaderModuleIdentifierFeatures? physicalDeviceShaderModuleIdentifierFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceImageCompressionControlFeatures? physicalDeviceImageCompressionControlFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceImageCompressionControlSwapchainFeatures? physicalDeviceImageCompressionControlSwapchainFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceSubpassMergeFeedbackFeatures? physicalDeviceSubpassMergeFeedbackFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceOpacityMicromapFeatures? physicalDeviceOpacityMicromapFeaturesExt = null, SharpVk.Multivendor.PhysicalDevicePipelinePropertiesFeatures? physicalDevicePipelinePropertiesFeaturesExt = null, SharpVk.Amd.PhysicalDeviceShaderEarlyAndLateFragmentTestsFeatures? physicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAmd = null, SharpVk.Multivendor.PhysicalDeviceNonSeamlessCubeMapFeatures? physicalDeviceNonSeamlessCubeMapFeaturesExt = null, SharpVk.Multivendor.PhysicalDevicePipelineRobustnessFeatures? physicalDevicePipelineRobustnessFeaturesExt = null, SharpVk.Qcom.PhysicalDeviceImageProcessingFeatures? physicalDeviceImageProcessingFeaturesQcom = null, SharpVk.Qcom.PhysicalDeviceTilePropertiesFeatures? physicalDeviceTilePropertiesFeaturesQcom = null, SharpVk.Sec.PhysicalDeviceAmigoProfilingFeatures? physicalDeviceAmigoProfilingFeaturesSec = null, SharpVk.Multivendor.PhysicalDeviceAttachmentFeedbackLoopLayoutFeatures? physicalDeviceAttachmentFeedbackLoopLayoutFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceDepthClampZeroOneFeatures? physicalDeviceDepthClampZeroOneFeaturesExt = null, SharpVk.Multivendor.PhysicalDeviceAddressBindingReportFeatures? physicalDeviceAddressBindingReportFeaturesExt = null, SharpVk.NVidia.PhysicalDeviceOpticalFlowFeatures? physicalDeviceOpticalFlowFeaturesNv = null, SharpVk.Multivendor.PhysicalDeviceFaultFeatures? physicalDeviceFaultFeaturesExt = null, SharpVk.Arm.PhysicalDeviceShaderCoreBuiltinsFeatures? physicalDeviceShaderCoreBuiltinsFeaturesArm = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Device result = default(SharpVk.Device);
                SharpVk.Interop.DeviceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.DeviceCreateInfo*);
                void* vkDeviceCreateInfoNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Device marshalledDevice = default(SharpVk.Interop.Device);
                if (physicalDeviceDeviceGeneratedCommandsFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures>());
                    physicalDeviceDeviceGeneratedCommandsFeaturesNv.Value.MarshalTo(extensionPointer);
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
                if (physicalDevicePresentWaitFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDevicePresentWaitFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDevicePresentWaitFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDevicePresentWaitFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDevicePresentWaitFeatures>());
                    physicalDevicePresentWaitFeaturesKhr.Value.MarshalTo(extensionPointer);
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
                if (physicalDeviceGlobalPriorityQueryFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceGlobalPriorityQueryFeatures* extensionPointer = default(SharpVk.Interop.Khronos.PhysicalDeviceGlobalPriorityQueryFeatures*);
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceGlobalPriorityQueryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceGlobalPriorityQueryFeatures>());
                    physicalDeviceGlobalPriorityQueryFeaturesKhr.Value.MarshalTo(extensionPointer);
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
                if (physicalDeviceVertexAttributeDivisorFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceVertexAttributeDivisorFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceVertexAttributeDivisorFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceVertexAttributeDivisorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceVertexAttributeDivisorFeatures>());
                    physicalDeviceVertexAttributeDivisorFeaturesExt.Value.MarshalTo(extensionPointer);
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
                if (physicalDeviceComputeShaderDerivativesFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceComputeShaderDerivativesFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceComputeShaderDerivativesFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceComputeShaderDerivativesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceComputeShaderDerivativesFeatures>());
                    physicalDeviceComputeShaderDerivativesFeaturesNv.Value.MarshalTo(extensionPointer);
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
                if (physicalDeviceFragmentDensityMapOffsetFeaturesQcom != null)
                {
                    SharpVk.Interop.Qcom.PhysicalDeviceFragmentDensityMapOffsetFeatures* extensionPointer = default(SharpVk.Interop.Qcom.PhysicalDeviceFragmentDensityMapOffsetFeatures*);
                    extensionPointer = (SharpVk.Interop.Qcom.PhysicalDeviceFragmentDensityMapOffsetFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.PhysicalDeviceFragmentDensityMapOffsetFeatures>());
                    physicalDeviceFragmentDensityMapOffsetFeaturesQcom.Value.MarshalTo(extensionPointer);
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
                if (physicalDeviceIndexTypeUint8FeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceIndexTypeUint8Features* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceIndexTypeUint8Features*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceIndexTypeUint8Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceIndexTypeUint8Features>());
                    physicalDeviceIndexTypeUint8FeaturesExt.Value.MarshalTo(extensionPointer);
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
                if (physicalDeviceLineRasterizationFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceLineRasterizationFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceLineRasterizationFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceLineRasterizationFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceLineRasterizationFeatures>());
                    physicalDeviceLineRasterizationFeaturesExt.Value.MarshalTo(extensionPointer);
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
                if (physicalDeviceCoherentMemoryFeaturesAmd != null)
                {
                    SharpVk.Interop.Amd.PhysicalDeviceCoherentMemoryFeatures* extensionPointer = default(SharpVk.Interop.Amd.PhysicalDeviceCoherentMemoryFeatures*);
                    extensionPointer = (SharpVk.Interop.Amd.PhysicalDeviceCoherentMemoryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.PhysicalDeviceCoherentMemoryFeatures>());
                    physicalDeviceCoherentMemoryFeaturesAmd.Value.MarshalTo(extensionPointer);
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
                if (physicalDeviceRobustness2FeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceRobustness2Features* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceRobustness2Features*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceRobustness2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceRobustness2Features>());
                    physicalDeviceRobustness2FeaturesExt.Value.MarshalTo(extensionPointer);
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
                if (physicalDevicePipelineProtectedAccessFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDevicePipelineProtectedAccessFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDevicePipelineProtectedAccessFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDevicePipelineProtectedAccessFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDevicePipelineProtectedAccessFeatures>());
                    physicalDevicePipelineProtectedAccessFeaturesExt.Value.MarshalTo(extensionPointer);
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
                if (physicalDeviceRayTracingMotionBlurFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceRayTracingMotionBlurFeatures* extensionPointer = default(SharpVk.Interop.NVidia.PhysicalDeviceRayTracingMotionBlurFeatures*);
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceRayTracingMotionBlurFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceRayTracingMotionBlurFeatures>());
                    physicalDeviceRayTracingMotionBlurFeaturesNv.Value.MarshalTo(extensionPointer);
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
                if (physicalDeviceDescriptorSetHostMappingFeaturesValve != null)
                {
                    SharpVk.Interop.Valve.PhysicalDeviceDescriptorSetHostMappingFeatures* extensionPointer = default(SharpVk.Interop.Valve.PhysicalDeviceDescriptorSetHostMappingFeatures*);
                    extensionPointer = (SharpVk.Interop.Valve.PhysicalDeviceDescriptorSetHostMappingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Valve.PhysicalDeviceDescriptorSetHostMappingFeatures>());
                    physicalDeviceDescriptorSetHostMappingFeaturesValve.Value.MarshalTo(extensionPointer);
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
                if (physicalDeviceOpacityMicromapFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceOpacityMicromapFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceOpacityMicromapFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceOpacityMicromapFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceOpacityMicromapFeatures>());
                    physicalDeviceOpacityMicromapFeaturesExt.Value.MarshalTo(extensionPointer);
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
                if (physicalDevicePipelineRobustnessFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDevicePipelineRobustnessFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDevicePipelineRobustnessFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDevicePipelineRobustnessFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDevicePipelineRobustnessFeatures>());
                    physicalDevicePipelineRobustnessFeaturesExt.Value.MarshalTo(extensionPointer);
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
                if (physicalDeviceDepthClampZeroOneFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceDepthClampZeroOneFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.PhysicalDeviceDepthClampZeroOneFeatures*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceDepthClampZeroOneFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceDepthClampZeroOneFeatures>());
                    physicalDeviceDepthClampZeroOneFeaturesExt.Value.MarshalTo(extensionPointer);
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
                if (physicalDeviceShaderCoreBuiltinsFeaturesArm != null)
                {
                    SharpVk.Interop.Arm.PhysicalDeviceShaderCoreBuiltinsFeatures* extensionPointer = default(SharpVk.Interop.Arm.PhysicalDeviceShaderCoreBuiltinsFeatures*);
                    extensionPointer = (SharpVk.Interop.Arm.PhysicalDeviceShaderCoreBuiltinsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDeviceShaderCoreBuiltinsFeatures>());
                    physicalDeviceShaderCoreBuiltinsFeaturesArm.Value.MarshalTo(extensionPointer);
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
