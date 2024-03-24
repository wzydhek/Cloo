#region License

/*

Copyright (c) 2009 - 2013 Fatjon Sakiqi

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.

*/

#endregion

using System;

namespace Cloo
{
    /// <summary>
    /// The OpenCL error codes.
    /// </summary>
    public enum ComputeErrorCode : int
    {
        /// <summary> </summary>
        CL_SUCCESS = 0,
        /// <summary> </summary>
        CL_DEVICE_NOT_FOUND = -1,
        /// <summary> </summary>
        CL_DEVICE_NOT_AVAILABLE = -2,
        /// <summary> </summary>
        CL_COMPILER_NOT_AVAILABLE = -3,
        /// <summary> </summary>
        CL_MEM_OBJECT_ALLOCATION_FAILURE = -4,
        /// <summary> </summary>
        CL_OUT_OF_RESOURCES = -5,
        /// <summary> </summary>
        CL_OUT_OF_HOST_MEMORY = -6,
        /// <summary> </summary>
        CL_PROFILING_INFO_NOT_AVAILABLE = -7,
        /// <summary> </summary>
        CL_MEM_COPY_OVERLAP = -8,
        /// <summary> </summary>
        CL_IMAGE_FORMAT_MISMATCH = -9,
        /// <summary> </summary>
        CL_IMAGE_FORMAT_NOT_SUPPORTED = -10,
        /// <summary> </summary>
        CL_BUILD_PROGRAM_FAILURE = -11,
        /// <summary> </summary>
        CL_MAP_FAILURE = -12,
        /// <summary> </summary>
        CL_INVALID_VALUE = -30,
        /// <summary> </summary>
        CL_INVALID_DEVICE_TYPE = -31,
        /// <summary> </summary>
        CL_INVALID_PLATFORM = -32,
        /// <summary> </summary>
        CL_INVALID_DEVICE = -33,
        /// <summary> </summary>
        CL_INVALID_CONTEXT = -34,
        /// <summary> </summary>
        CL_INVALID_QUEUE_PROPERTIES = -35,
        /// <summary> </summary>
        CL_INVALID_COMMAND_QUEUE = -36,
        /// <summary> </summary>
        CL_INVALID_HOST_PTR = -37,
        /// <summary> </summary>
        CL_INVALID_MEM_OBJECT = -38,
        /// <summary> </summary>
        CL_INVALID_IMAGE_FORMAT_DESCRIPTOR = -39,
        /// <summary> </summary>
        CL_INVALID_IMAGE_SIZE = -40,
        /// <summary> </summary>
        CL_INVALID_SAMPLER = -41,
        /// <summary> </summary>
        CL_INVALID_BINARY = -42,
        /// <summary> </summary>
        CL_INVALID_BUILD_OPTIONS = -43,
        /// <summary> </summary>
        CL_INVALID_PROGRAM = -44,
        /// <summary> </summary>
        CL_INVALID_PROGRAM_EXECUTABLE = -45,
        /// <summary> </summary>
        CL_INVALID_KERNEL_NAME = -46,
        /// <summary> </summary>
        CL_INVALID_KERNEL_DEFINITION = -47,
        /// <summary> </summary>
        CL_INVALID_KERNEL = -48,
        /// <summary> </summary>
        CL_INVALID_ARG_INDEX = -49,
        /// <summary> </summary>
        CL_INVALID_ARG_VALUE = -50,
        /// <summary> </summary>
        CL_INVALID_ARG_SIZE = -51,
        /// <summary> </summary>
        CL_INVALID_KERNEL_ARGS = -52,
        /// <summary> </summary>
        CL_INVALID_WORK_DIMENSION = -53,
        /// <summary> </summary>
        CL_INVALID_WORK_GROUP_SIZE = -54,
        /// <summary> </summary>
        CL_INVALID_WORK_ITEM_SIZE = -55,
        /// <summary> </summary>
        CL_INVALID_GLOBAL_OFFSET = -56,
        /// <summary> </summary>
        CL_INVALID_EVENT_WAIT_LIST = -57,
        /// <summary> </summary>
        CL_INVALID_EVENT = -58,
        /// <summary> </summary>
        CL_INVALID_OPERATION = -59,
        /// <summary> </summary>
        CL_INVALID_GL_OBJECT = -60,
        /// <summary> </summary>
        CL_INVALID_BUFFER_SIZE = -61,
        /// <summary> </summary>
        CL_INVALID_MIP_LEVEL = -62,
        /// <summary> </summary>
        CL_INVALID_GLOBAL_WORK_SIZE = -63,
        /// <summary> </summary>
        CL_INVALID_GL_SHAREGROUP_REFERENCE_KHR = -1000,
        /// <summary> </summary>
        CL_PLATFORM_NOT_FOUND_KHR = -1001,
        /// <summary> </summary>
        CL_INVALID_D3D10_DEVICE_KHR = -1002,
        /// <summary> </summary>
        CL_INVALID_D3D10_RESOURCE_KHR = -1003,
        /// <summary> </summary>
        CL_D3D10_RESOURCE_ALREADY_ACQUIRED_KHR = -1004,
        /// <summary> </summary>
        CL_D3D10_RESOURCE_NOT_ACQUIRED_KHR = -1005,
        /// <summary> </summary>
        CL_INVALID_D3D11_DEVICE_KHR = -1006,
        /// <summary> </summary>
        CL_INVALID_D3D11_RESOURCE_KHR = -1007,
        /// <summary> </summary>
        CL_D3D11_RESOURCE_ALREADY_ACQUIRED_KHR = -1008,
        /// <summary> </summary>
        CL_D3D11_RESOURCE_NOT_ACQUIRED_KHR = -1009,
        /// <summary> </summary>
        CL_INVALID_DX9_MEDIA_ADAPTER_KHR = -1010,
        /// <summary> </summary>
        CL_INVALID_DX9_DEVICE_INTEL = -1010,
        /// <summary> </summary>
        CL_INVALID_DX9_MEDIA_SURFACE_KHR = -1011,
        /// <summary> </summary>
        CL_INVALID_DX9_RESOURCE_INTEL = -1011,
        /// <summary> </summary>
        CL_DX9_MEDIA_SURFACE_ALREADY_ACQUIRED_KHR = -1012,
        /// <summary> </summary>
        CL_DX9_RESOURCE_ALREADY_ACQUIRED_INTEL = -1012,
        /// <summary> </summary>
        CL_DX9_MEDIA_SURFACE_NOT_ACQUIRED_KHR = -1013,
        /// <summary> </summary>
        CL_DX9_RESOURCE_NOT_ACQUIRED_INTEL = -1013,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_FAILED_EXT = -1057,
        /// <summary> </summary>
        CL_INVALID_PARTITION_COUNT_EXT = -1058,
        /// <summary> </summary>
        CL_INVALID_PARTITION_NAME_EXT = -1059,
        /// <summary> </summary>
        CL_INVALID_ACCELERATOR_INTEL = -1094,
        /// <summary> </summary>
        CL_INVALID_ACCELERATOR_TYPE_INTEL = -1095,
        /// <summary> </summary>
        CL_INVALID_ACCELERATOR_DESCRIPTOR_INTEL = -1096,
        /// <summary> </summary>
        CL_ACCELERATOR_TYPE_NOT_SUPPORTED_INTEL = -1097,
        /// <summary> </summary>
        CL_INVALID_VA_API_MEDIA_ADAPTER_INTEL = -1098,
        /// <summary> </summary>
        CL_INVALID_VA_API_MEDIA_SURFACE_INTEL = -1099,
        /// <summary> </summary>
        CL_VA_API_MEDIA_SURFACE_ALREADY_ACQUIRED_INTEL = -1100,
        /// <summary> </summary>
        CL_VA_API_MEDIA_SURFACE_NOT_ACQUIRED_INTEL = -1101,
        /// <summary> </summary>
        CL_COMMAND_TERMINATED_ITSELF_WITH_FAILURE_ARM = -1108,
        /// <summary> </summary>
        CL_CONTEXT_TERMINATED_KHR = -1121,
        /// <summary> </summary>
        CL_INVALID_COMMAND_BUFFER_KHR = -1138,
        /// <summary> </summary>
        CL_INVALID_SYNC_POINT_WAIT_LIST_KHR = -1139,
        /// <summary> </summary>
        CL_INCOMPATIBLE_COMMAND_QUEUE_KHR = -1140,
        /// <summary> </summary>
        CL_INVALID_MUTABLE_COMMAND_KHR = -1141,
        /// <summary> </summary>
        CL_INVALID_SEMAPHORE_KHR = -1142,
        /// <summary> </summary>
        CL_GRALLOC_RESOURCE_NOT_ACQUIRED_IMG = -0x40D4,
        /// <summary> </summary>
        CL_INVALID_GRALLOC_OBJECT_IMG = -0x40D5,

        // OpenCL 1.1
        /// <summary> </summary>
        CL_MISALIGNED_SUB_BUFFER_OFFSET = -13,
        /// <summary> </summary>
        CL_EXEC_STATUS_ERROR_FOR_EVENTS_IN_WAIT_LIST = -14,
        /// <summary> </summary>
        CL_INVALID_PROPERTY = -64,

        // OpenCL 1.2
        /// <summary> </summary>
        CL_COMPILE_PROGRAM_FAILURE = -15,
        /// <summary> </summary>
        CL_LINKER_NOT_AVAILABLE = -16,
        /// <summary> </summary>
        CL_LINK_PROGRAM_FAILURE = -17,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_FAILED = -18,
        /// <summary> </summary>
        CL_KERNEL_ARG_INFO_NOT_AVAILABLE = -19,
        /// <summary> </summary>
        CL_INVALID_IMAGE_DESCRIPTOR = -65,
        /// <summary> </summary>
        CL_INVALID_COMPILER_OPTIONS = -66,
        /// <summary> </summary>
        CL_INVALID_LINKER_OPTIONS = -67,
        /// <summary> </summary>
        CL_INVALID_DEVICE_PARTITION_COUNT = -68,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_INVALID_PIPE_SIZE = -69,
        /// <summary> </summary>
        CL_INVALID_DEVICE_QUEUE = -70,

        // OpenCL 2.2
        /// <summary> </summary>
        CL_INVALID_SPEC_ID = -71,
        /// <summary> </summary>
        CL_MAX_SIZE_RESTRICTION_EXCEEDED = -72,
    }

    /// <summary>
    /// The OpenCL version.
    /// </summary>
    public enum OpenCLVersion : int
    {
        /// <summary> </summary>
        Version_1_0 = 1,
        /// <summary> </summary>
        Version_1_1 = 1,
        /// <summary> </summary>
        Version_1_2 = 1,
        /// <summary> </summary>
        Version_2_0 = 2,
        /// <summary> </summary>
        Version_2_1 = 2,
        /// <summary> </summary>
        Version_2_2 = 2,
        /// <summary> </summary>
        Version_3_0 = 3
    }

    /// <summary>
    /// The OpenCL boolean values expressed as integers.
    /// cl_bool
    /// </summary>
    public enum ComputeBoolean : int
    {
        /// <summary> </summary>
        False = 0,
        /// <summary> </summary>
        True = 1
    }

    /// <summary>
    /// The platform info query symbols.
    /// cl_platform_info
    /// </summary>
    public enum ComputePlatformInfo : int
    {
        /// <summary> </summary>
        CL_PLATFORM_PROFILE = 0x0900,
        /// <summary> </summary>
        CL_PLATFORM_VERSION = 0x0901,
        /// <summary> </summary>
        CL_PLATFORM_NAME = 0x0902,
        /// <summary> </summary>
        CL_PLATFORM_VENDOR = 0x0903,
        /// <summary> </summary>
        CL_PLATFORM_EXTENSIONS = 0x0904,
        /// <summary> </summary>
        CL_PLATFORM_COMMAND_BUFFER_CAPABILITIES_KHR = 0x0908,
        /// <summary> </summary>
        CL_PLATFORM_ICD_SUFFIX_KHR = 0x0920,
        /// <summary> </summary>
        CL_PLATFORM_SEMAPHORE_TYPES_KHR = 0x2036,
        /// <summary> </summary>
        CL_PLATFORM_SEMAPHORE_IMPORT_HANDLE_TYPES_KHR = 0x2037,
        /// <summary> </summary>
        CL_PLATFORM_SEMAPHORE_EXPORT_HANDLE_TYPES_KHR = 0x2038,
        /// <summary> </summary>
        CL_PLATFORM_EXTERNAL_MEMORY_IMPORT_HANDLE_TYPES_KHR = 0x2044,

        // OpenCL 2.1
        /// <summary> </summary>
        CL_PLATFORM_HOST_TIMER_RESOLUTION = 0x0905,

        // OpenCL 3.0
        /// <summary> </summary>
        CL_PLATFORM_NUMERIC_VERSION = 0x0906,
        /// <summary> </summary>
        CL_PLATFORM_NUMERIC_VERSION_KHR = 0x0906,
        /// <summary> </summary>
        CL_PLATFORM_EXTENSIONS_WITH_VERSION = 0x0907,
        /// <summary> </summary>
        CL_PLATFORM_EXTENSIONS_WITH_VERSION_KHR = 0x0907,
    }

    /// <summary>
    /// The types of devices.
    /// cl_device_type - bitfield
    /// </summary>
    [Flags]
    public enum ComputeDeviceTypes : long
    {
        /// <summary> </summary>
        Default = 1 << 0,
        /// <summary> </summary>
        Cpu = 1 << 1,
        /// <summary> </summary>
        Gpu = 1 << 2,
        /// <summary> </summary>
        Accelerator = 1 << 3,
        /// <summary> </summary>
        All = 0xFFFFFFFF,

        // OpenCL 1.2
        /// <summary> </summary>
        Custom = 1 << 4
    }

    /// <summary>
    /// The device info query symbols.
    /// cl_device_info
    /// </summary>
    public enum ComputeDeviceInfo : int
    {
        /// <summary> </summary>
        CL_DEVICE_TYPE = 0x1000,
        /// <summary> </summary>
        CL_DEVICE_VENDOR_ID = 0x1001,
        /// <summary> </summary>
        CL_DEVICE_MAX_COMPUTE_UNITS = 0x1002,
        /// <summary> </summary>
        CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS = 0x1003,
        /// <summary> </summary>
        CL_DEVICE_MAX_WORK_GROUP_SIZE = 0x1004,
        /// <summary> </summary>
        CL_DEVICE_MAX_WORK_ITEM_SIZES = 0x1005,
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR = 0x1006,
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT = 0x1007,
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT = 0x1008,
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG = 0x1009,
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT = 0x100A,
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE = 0x100B,
        /// <summary> </summary>
        CL_DEVICE_MAX_CLOCK_FREQUENCY = 0x100C,
        /// <summary> </summary>
        CL_DEVICE_ADDRESS_BITS = 0x100D,
        /// <summary> </summary>
        CL_DEVICE_MAX_READ_IMAGE_ARGS = 0x100E,
        /// <summary> </summary>
        CL_DEVICE_MAX_WRITE_IMAGE_ARGS = 0x100F,
        /// <summary> </summary>
        CL_DEVICE_MAX_MEM_ALLOC_SIZE = 0x1010,
        /// <summary> </summary>
        CL_DEVICE_IMAGE2D_MAX_WIDTH = 0x1011,
        /// <summary> </summary>
        CL_DEVICE_IMAGE2D_MAX_HEIGHT = 0x1012,
        /// <summary> </summary>
        CL_DEVICE_IMAGE3D_MAX_WIDTH = 0x1013,
        /// <summary> </summary>
        CL_DEVICE_IMAGE3D_MAX_HEIGHT = 0x1014,
        /// <summary> </summary>
        CL_DEVICE_IMAGE3D_MAX_DEPTH = 0x1015,
        /// <summary> </summary>
        CL_DEVICE_IMAGE_SUPPORT = 0x1016,
        /// <summary> </summary>
        CL_DEVICE_MAX_PARAMETER_SIZE = 0x1017,
        /// <summary> </summary>
        CL_DEVICE_MAX_SAMPLERS = 0x1018,
        /// <summary> </summary>
        CL_DEVICE_MEM_BASE_ADDR_ALIGN = 0x1019,
        /// <summary> </summary>
        CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE = 0x101A,
        /// <summary> </summary>
        CL_DEVICE_SINGLE_FP_CONFIG = 0x101B,
        /// <summary> </summary>
        CL_DEVICE_GLOBAL_MEM_CACHE_TYPE = 0x101C,
        /// <summary> </summary>
        CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE = 0x101D,
        /// <summary> </summary>
        CL_DEVICE_GLOBAL_MEM_CACHE_SIZE = 0x101E,
        /// <summary> </summary>
        CL_DEVICE_GLOBAL_MEM_SIZE = 0x101F,
        /// <summary> </summary>
        CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE = 0x1020,
        /// <summary> </summary>
        CL_DEVICE_MAX_CONSTANT_ARGS = 0x1021,
        /// <summary> </summary>
        CL_DEVICE_LOCAL_MEM_TYPE = 0x1022,
        /// <summary> </summary>
        CL_DEVICE_LOCAL_MEM_SIZE = 0x1023,
        /// <summary> </summary>
        CL_DEVICE_ERROR_CORRECTION_SUPPORT = 0x1024,
        /// <summary> </summary>
        CL_DEVICE_PROFILING_TIMER_RESOLUTION = 0x1025,
        /// <summary> </summary>
        CL_DEVICE_ENDIAN_LITTLE = 0x1026,
        /// <summary> </summary>
        CL_DEVICE_AVAILABLE = 0x1027,
        /// <summary> </summary>
        CL_DEVICE_COMPILER_AVAILABLE = 0x1028,
        /// <summary> </summary>
        CL_DEVICE_EXECUTION_CAPABILITIES = 0x1029,
        /// <summary> </summary>
        [Obsolete("Deprecated in OpenCL 2.0.")]
        CL_DEVICE_QUEUE_PROPERTIES = 0x102A,
        /// <summary> </summary>
        CL_DEVICE_NAME = 0x102B,
        /// <summary> </summary>
        CL_DEVICE_VENDOR = 0x102C,
        /// <summary> </summary>
        CL_DRIVER_VERSION = 0x102D,
        /// <summary> </summary>
        CL_DEVICE_PROFILE = 0x102E,
        /// <summary> </summary>
        CL_DEVICE_VERSION = 0x102F,
        /// <summary> </summary>
        CL_DEVICE_EXTENSIONS = 0x1030,
        /// <summary> </summary>
        CL_DEVICE_PLATFORM = 0x1031,
        /// <summary> </summary>
        CL_DEVICE_HALF_FP_CONFIG = 0x1033,
        /// <summary> </summary>
        CL_DEVICE_IMAGE_PITCH_ALIGNMENT_KHR = 0x104A,
        /// <summary> </summary>
        CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT_KHR = 0x104B,
        /// <summary> </summary>
        CL_DEVICE_IL_VERSION_KHR = 0x105B,
        /// <summary> </summary>
        CL_DEVICE_INTEGER_DOT_PRODUCT_CAPABILITIES_KHR = 0x1073,
        /// <summary> </summary>
        CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_8BIT_KHR = 0x1074,
        /// <summary> </summary>
        CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_4x8BIT_PACKED_KHR = 0x1075,
        /// <summary> </summary>
        CL_DEVICE_COMMAND_BUFFER_CAPABILITIES_KHR = 0x12A9,
        /// <summary> </summary>
        CL_DEVICE_COMMAND_BUFFER_REQUIRED_QUEUE_PROPERTIES_KHR = 0x12AA,
        /// <summary> </summary>
        CL_DEVICE_COMMAND_BUFFER_NUM_SYNC_DEVICES_KHR = 0x12AB,
        /// <summary> </summary>
        CL_DEVICE_COMMAND_BUFFER_SYNC_DEVICES_KHR = 0x12AC,
        /// <summary> </summary>
        CL_DEVICE_MUTABLE_DISPATCH_CAPABILITIES_KHR = 0x12B0,
        /// <summary> </summary>
        CL_DEVICE_TERMINATE_CAPABILITY_KHR = 0x2031,
        /// <summary> </summary>
        CL_DEVICE_MAX_NAMED_BARRIER_COUNT_KHR = 0x2035,
        /// <summary> </summary>
        CL_DEVICE_SEMAPHORE_TYPES_KHR = 0x204C,
        /// <summary> </summary>
        CL_DEVICE_SEMAPHORE_IMPORT_HANDLE_TYPES_KHR = 0x204D,
        /// <summary> </summary>
        CL_DEVICE_SEMAPHORE_EXPORT_HANDLE_TYPES_KHR = 0x204E,
        /// <summary> </summary>
        CL_DEVICE_EXTERNAL_MEMORY_IMPORT_HANDLE_TYPES_KHR = 0x204F,
        /// <summary> </summary>
        CL_DEVICE_EXTERNAL_MEMORY_IMPORT_ASSUME_LINEAR_IMAGES_HANDLE_TYPES_KHR = 0x2052,
        /// <summary> </summary>
        CL_DEVICE_COMPUTE_CAPABILITY_MAJOR_NV = 0x4000,
        /// <summary> </summary>
        CL_DEVICE_COMPUTE_CAPABILITY_MINOR_NV = 0x4001,
        /// <summary> </summary>
        CL_DEVICE_REGISTERS_PER_BLOCK_NV = 0x4002,
        /// <summary> </summary>
        CL_DEVICE_WARP_SIZE_NV = 0x4003,
        /// <summary> </summary>
        CL_DEVICE_GPU_OVERLAP_NV = 0x4004,
        /// <summary> </summary>
        CL_DEVICE_KERNEL_EXEC_TIMEOUT_NV = 0x4005,
        /// <summary> </summary>
        CL_DEVICE_INTEGRATED_MEMORY_NV = 0x4006,
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_AMD = 0x4030,
        /// <summary> </summary>
        CL_DEVICE_MAX_WORK_GROUP_SIZE_AMD = 0x4031,
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_CONSTANT_BUFFER_SIZE_AMD = 0x4033,
        /// <summary> </summary>
        CL_DEVICE_PCIE_ID_AMD = 0x4034,
        /// <summary> </summary>
        CL_DEVICE_PROFILING_TIMER_OFFSET_AMD = 0x4036,
        /// <summary> </summary>
        CL_DEVICE_TOPOLOGY_AMD = 0x4037,
        /// <summary> </summary>
        CL_DEVICE_BOARD_NAME_AMD = 0x4038,
        /// <summary> </summary>
        CL_DEVICE_GLOBAL_FREE_MEMORY_AMD = 0x4039,
        /// <summary> </summary>
        CL_DEVICE_SIMD_PER_COMPUTE_UNIT_AMD = 0x4040,
        /// <summary> </summary>
        CL_DEVICE_SIMD_WIDTH_AMD = 0x4041,
        /// <summary> </summary>
        CL_DEVICE_SIMD_INSTRUCTION_WIDTH_AMD = 0x4042,
        /// <summary> </summary>
        CL_DEVICE_WAVEFRONT_WIDTH_AMD = 0x4043,
        /// <summary> </summary>
        CL_DEVICE_GLOBAL_MEM_CHANNELS_AMD = 0x4044,
        /// <summary> </summary>
        CL_DEVICE_GLOBAL_MEM_CHANNEL_BANKS_AMD = 0x4045,
        /// <summary> </summary>
        CL_DEVICE_GLOBAL_MEM_CHANNEL_BANK_WIDTH_AMD = 0x4046,
        /// <summary> </summary>
        CL_DEVICE_LOCAL_MEM_SIZE_PER_COMPUTE_UNIT_AMD = 0x4047,
        /// <summary> </summary>
        CL_DEVICE_LOCAL_MEM_BANKS_AMD = 0x4048,
        /// <summary> </summary>
        CL_DEVICE_THREAD_TRACE_SUPPORTED_AMD = 0x4049,
        /// <summary> </summary>
        CL_DEVICE_GFXIP_MAJOR_AMD = 0x404A,
        /// <summary> </summary>
        CL_DEVICE_GFXIP_MINOR_AMD = 0x404B,
        /// <summary> </summary>
        CL_DEVICE_AVAILABLE_ASYNC_QUEUES_AMD = 0x404C,
        /// <summary> </summary>
        CL_DEVICE_PARENT_DEVICE_EXT = 0x4054,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_TYPES_EXT = 0x4055,
        /// <summary> </summary>
        CL_DEVICE_AFFINITY_DOMAINS_EXT = 0x4056,
        /// <summary> </summary>
        CL_DEVICE_REFERENCE_COUNT_EXT = 0x4057,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_STYLE_EXT = 0x4058,
        /// <summary> </summary>
        CL_DEVICE_ME_VERSION_INTEL = 0x407E,
        /// <summary> </summary>
        CL_DEVICE_EXT_MEM_PADDING_IN_BYTES_QCOM = 0x40A0,
        /// <summary> </summary>
        CL_DEVICE_PAGE_SIZE_QCOM = 0x40A1,
        /// <summary> </summary>
        CL_DEVICE_SPIR_VERSIONS = 0x40E0,
        /// <summary> </summary>
        CL_DEVICE_SVM_CAPABILITIES_ARM = 0x40B6,
        /// <summary> </summary>
        CL_DEVICE_SIMULTANEOUS_INTEROPS_INTEL = 0x4104,
        /// <summary> </summary>
        CL_DEVICE_NUM_SIMULTANEOUS_INTEROPS_INTEL = 0x4105,
        /// <summary> </summary>
        CL_DEVICE_SUB_GROUP_SIZES_INTEL = 0x4108,
        /// <summary> </summary>
        CL_DEVICE_AVC_ME_VERSION_INTEL = 0x410B,
        /// <summary> </summary>
        CL_DEVICE_AVC_ME_SUPPORTS_TEXTURE_SAMPLER_USE_INTEL = 0x410C,
        /// <summary> </summary>
        CL_DEVICE_AVC_ME_SUPPORTS_PREEMPTION_INTEL = 0x410D,
        /// <summary> </summary>
        CL_DEVICE_PCI_BUS_INFO_KHR = 0x410F,
        /// <summary> </summary>
        CL_DEVICE_PLANAR_YUV_MAX_WIDTH_INTEL = 0x417E,
        /// <summary> </summary>
        CL_DEVICE_PLANAR_YUV_MAX_HEIGHT_INTEL = 0x417F,
        /// <summary> </summary>
        CL_DEVICE_QUEUE_FAMILY_PROPERTIES_INTEL = 0x418B,
        /// <summary> </summary>
        CL_DEVICE_HOST_MEM_CAPABILITIES_INTEL = 0x4190,
        /// <summary> </summary>
        CL_DEVICE_DEVICE_MEM_CAPABILITIES_INTEL = 0x4191,
        /// <summary> </summary>
        CL_DEVICE_SINGLE_DEVICE_SHARED_MEM_CAPABILITIES_INTEL = 0x4192,
        /// <summary> </summary>
        CL_DEVICE_CROSS_DEVICE_SHARED_MEM_CAPABILITIES_INTEL = 0x4193,
        /// <summary> </summary>
        CL_DEVICE_SHARED_SYSTEM_MEM_CAPABILITIES_INTEL = 0x4194,
        /// <summary> </summary>
        CL_DEVICE_JOB_SLOTS_ARM = 0x41E0,
        /// <summary> </summary>
        CL_DEVICE_SCHEDULING_CONTROLS_CAPABILITIES_ARM = 0x41E4,
        /// <summary> </summary>
        CL_DEVICE_MAX_WARP_COUNT_ARM = 0x41EA,
        /// <summary> </summary>
        CL_DEVICE_SUPPORTED_REGISTER_ALLOCATIONS_ARM = 0x41EB,
        /// <summary> </summary>
        CL_DEVICE_CONTROLLED_TERMINATION_CAPABILITIES_ARM = 0x41EE,
        /// <summary> </summary>
        CL_DEVICE_CXX_FOR_OPENCL_NUMERIC_VERSION_EXT = 0x4230,
        /// <summary> </summary>
        CL_DEVICE_SINGLE_FP_ATOMIC_CAPABILITIES_EXT = 0x4231,
        /// <summary> </summary>
        CL_DEVICE_DOUBLE_FP_ATOMIC_CAPABILITIES_EXT = 0x4232,
        /// <summary> </summary>
        CL_DEVICE_HALF_FP_ATOMIC_CAPABILITIES_EXT = 0x4233,
        /// <summary> </summary>
        CL_DEVICE_IP_VERSION_INTEL = 0x4250,
        /// <summary> </summary>
        CL_DEVICE_ID_INTEL = 0x4251,
        /// <summary> </summary>
        CL_DEVICE_NUM_SLICES_INTEL = 0x4252,
        /// <summary> </summary>
        CL_DEVICE_NUM_SUB_SLICES_PER_SLICE_INTEL = 0x4253,
        /// <summary> </summary>
        CL_DEVICE_NUM_EUS_PER_SUB_SLICE_INTEL = 0x4254,
        /// <summary> </summary>
        CL_DEVICE_NUM_THREADS_PER_EU_INTEL = 0x4255,
        /// <summary> </summary>
        CL_DEVICE_FEATURE_CAPABILITIES_INTEL = 0x4256,

        // OpenCL 1.1
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF = 0x1034,
        /// <summary> </summary>
        [Obsolete("Deprecated in OpenCL 2.0.")]
        CL_DEVICE_HOST_UNIFIED_MEMORY = 0x1035,
        /// <summary> </summary>
        CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR = 0x1036,
        /// <summary> </summary>
        CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT = 0x1037,
        /// <summary> </summary>
        CL_DEVICE_NATIVE_VECTOR_WIDTH_INT = 0x1038,
        /// <summary> </summary>
        CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG = 0x1039,
        /// <summary> </summary>
        CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT = 0x103A,
        /// <summary> </summary>
        CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE = 0x103B,
        /// <summary> </summary>
        CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF = 0x103C,
        /// <summary> </summary>
        CL_DEVICE_OPENCL_C_VERSION = 0x103D,

        // OpenCL 1.2
        /// <summary> </summary>
        CL_DEVICE_DOUBLE_FP_CONFIG = 0x1032,
        /// <summary> </summary>
        CL_DEVICE_LINKER_AVAILABLE = 0x103E,
        /// <summary> </summary>
        CL_DEVICE_BUILT_IN_KERNELS = 0x103F,
        /// <summary> </summary>
        CL_DEVICE_IMAGE_MAX_BUFFER_SIZE = 0x1040,
        /// <summary> </summary>
        CL_DEVICE_IMAGE_MAX_ARRAY_SIZE = 0x1041,
        /// <summary> </summary>
        CL_DEVICE_PARENT_DEVICE = 0x1042,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_MAX_SUB_DEVICES = 0x1043,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_PROPERTIES = 0x1044,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_AFFINITY_DOMAIN = 0x1045,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_TYPE = 0x1046,
        /// <summary> </summary>
        CL_DEVICE_REFERENCE_COUNT = 0x1047,
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_INTEROP_USER_SYNC = 0x1048,
        /// <summary> </summary>
        CL_DEVICE_PRINTF_BUFFER_SIZE = 0x1049,
        /// <summary> </summary>
        CL_DEVICE_COMPUTE_UNITS_BITFIELD_ARM = 0x40BF,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_DEVICE_QUEUE_ON_HOST_PROPERTIES = 0x102A,
        /// <summary> </summary>
        CL_DEVICE_IMAGE_PITCH_ALIGNMENT = 0x104A,
        /// <summary> </summary>
        CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT = 0x104B,
        /// <summary> </summary>
        CL_DEVICE_MAX_READ_WRITE_IMAGE_ARGS = 0x104C,
        /// <summary> </summary>
        CL_DEVICE_MAX_GLOBAL_VARIABLE_SIZE = 0x104D,
        /// <summary> </summary>
        CL_DEVICE_QUEUE_ON_DEVICE_PROPERTIES = 0x104E,
        /// <summary> </summary>
        CL_DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE = 0x104F,
        /// <summary> </summary>
        CL_DEVICE_QUEUE_ON_DEVICE_MAX_SIZE = 0x1050,
        /// <summary> </summary>
        CL_DEVICE_MAX_ON_DEVICE_QUEUES = 0x1051,
        /// <summary> </summary>
        CL_DEVICE_MAX_ON_DEVICE_EVENTS = 0x1052,
        /// <summary> </summary>
        CL_DEVICE_SVM_CAPABILITIES = 0x1053,
        /// <summary> </summary>
        CL_DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE = 0x1054,
        /// <summary> </summary>
        CL_DEVICE_MAX_PIPE_ARGS = 0x1055,
        /// <summary> </summary>
        CL_DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS = 0x1056,
        /// <summary> </summary>
        CL_DEVICE_PIPE_MAX_PACKET_SIZE = 0x1057,
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT = 0x1058,
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT = 0x1059,
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT = 0x105A,

        // OpenCL 2.1
        /// <summary> </summary>
        CL_DEVICE_IL_VERSION = 0x105B,
        /// <summary> </summary>
        CL_DEVICE_MAX_NUM_SUB_GROUPS = 0x105C,
        /// <summary> </summary>
        CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS = 0x105D,

        // OpenCL 3.0
        /// <summary> </summary>
        CL_DEVICE_NUMERIC_VERSION = 0x105E,
        /// <summary> </summary>
        CL_DEVICE_NUMERIC_VERSION_KHR = 0x105E,
        /// <summary> </summary>
        CL_DEVICE_OPENCL_C_NUMERIC_VERSION_KHR = 0x105F,
        /// <summary> </summary>
        CL_DEVICE_EXTENSIONS_WITH_VERSION = 0x1060,
        /// <summary> </summary>
        CL_DEVICE_EXTENSIONS_WITH_VERSION_KHR = 0x1060,
        /// <summary> </summary>
        CL_DEVICE_ILS_WITH_VERSION = 0x1061,
        /// <summary> </summary>
        CL_DEVICE_ILS_WITH_VERSION_KHR = 0x1061,
        /// <summary> </summary>
        CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION = 0x1062,
        /// <summary> </summary>
        CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION_KHR = 0x1062,
        /// <summary> </summary>
        CL_DEVICE_ATOMIC_MEMORY_CAPABILITIES = 0x1063,
        /// <summary> </summary>
        CL_DEVICE_ATOMIC_FENCE_CAPABILITIES = 0x1064,
        /// <summary> </summary>
        CL_DEVICE_NON_UNIFORM_WORK_GROUP_SUPPORT = 0x1065,
        /// <summary> </summary>
        CL_DEVICE_OPENCL_C_ALL_VERSIONS = 0x1066,
        /// <summary> </summary>
        CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_MULTIPLE = 0x1067,
        /// <summary> </summary>
        CL_DEVICE_WORK_GROUP_COLLECTIVE_FUNCTIONS_SUPPORT = 0x1068,
        /// <summary> </summary>
        CL_DEVICE_GENERIC_ADDRESS_SPACE_SUPPORT = 0x1069,
        /// <summary> </summary>
        CL_DEVICE_UUID_KHR = 0x106A,
        /// <summary> </summary>
        CL_DRIVER_UUID_KHR = 0x106B,
        /// <summary> </summary>
        CL_DEVICE_LUID_VALID_KHR = 0x106C,
        /// <summary> </summary>
        CL_DEVICE_LUID_KHR = 0x106D,
        /// <summary> </summary>
        CL_DEVICE_NODE_MASK_KHR = 0x106E,
        /// <summary> </summary>
        CL_DEVICE_OPENCL_C_FEATURES = 0x106F,
        /// <summary> </summary>
        CL_DEVICE_DEVICE_ENQUEUE_CAPABILITIES = 0x1070,
        /// <summary> </summary>
        CL_DEVICE_PIPE_SUPPORT = 0x1071,
        /// <summary> </summary>
        CL_DEVICE_LATEST_CONFORMANCE_VERSION_PASSED = 0x1072,
    }

    /// <summary>
    /// cl_device_fp_config - bitfield
    /// </summary>
    [Flags]
    public enum ComputeDeviceSingleCapabilities : long
    {
        /// <summary> </summary>
        CL_FP_DENORM = 1 << 0,
        /// <summary> </summary>
        CL_FP_INF_NAN = 1 << 1,
        /// <summary> </summary>
        CL_FP_ROUND_TO_NEAREST = 1 << 2,
        /// <summary> </summary>
        CL_FP_ROUND_TO_ZERO = 1 << 3,
        /// <summary> </summary>
        CL_FP_ROUND_TO_INF = 1 << 4,
        /// <summary> </summary>
        CL_FP_FMA = 1 << 5,

        //OpenCL 1.1
        /// <summary> </summary>
        CL_FP_SOFT_FLOAT = 1 << 6,

        //OpenCL 1.2
        /// <summary> </summary>
        CL_FP_CORRECTLY_ROUNDED_DIVIDE_SQRT = 1 << 7
    }

    /// <summary>
    /// cl_device_mem_cache_type
    /// </summary>
    public enum ComputeDeviceMemoryCacheType : int
    {
        /// <summary> </summary>
        CL_NONE = 0x0,
        /// <summary> </summary>
        CL_READ_ONLY_CACHE = 0x1,
        /// <summary> </summary>
        CL_READ_WRITE_CACHE = 0x2,
    }

    /// <summary>
    /// cl_device_local_mem_type
    /// </summary>
    public enum ComputeDeviceLocalMemoryType : int
    {
        /// <summary> </summary>
        CL_LOCAL = 0x1,
        /// <summary> </summary>
        CL_GLOBAL = 0x2
    }

    /// <summary>
    /// cl_device_exec_capabilities - bitfield
    /// </summary>
    [Flags]
    public enum ComputeDeviceExecutionCapabilities : int
    {
        /// <summary> </summary>
        CL_EXEC_KERNEL = 1 << 0,
        /// <summary> </summary>
        CL_EXEC_NATIVE_KERNEL = 1 << 1
    }

    /// <summary>
    /// cl_command_queue_properties - bitfield
    /// </summary>
    [Flags]
    public enum ComputeCommandQueueFlags : long
    {
        /// <summary> </summary>
        CL_QUEUE_NONE = 0,
        /// <summary> </summary>
        CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE = 1 << 0,
        /// <summary> </summary>
        CL_QUEUE_PROFILING_ENABLE = 1 << 1,
        /// <summary> </summary>
        CL_QUEUE_NO_SYNC_OPERATIONS_INTEL = 1 << 29,
        /// <summary> </summary>
        CL_QUEUE_THREAD_LOCAL_EXEC_ENABLE_INTEL = 1 << 31
    }

    /// <summary>
    /// cl_command_queue_properties - bitfield
    /// </summary>
    [Flags]
    public enum ComputeCommandQueueProperties : long
    {
        /// <summary> </summary>
        CL_QUEUE_NONE = 0,
        /// <summary> </summary>
        CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE = 1 << 0,
        /// <summary> </summary>
        CL_QUEUE_PROFILING_ENABLE = 1 << 1,
        /// <summary> </summary>
        CL_QUEUE_NO_SYNC_OPERATIONS_INTEL = 1 << 29,
        /// <summary> </summary>
        CL_QUEUE_THREAD_LOCAL_EXEC_ENABLE_INTEL = 1 << 31,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_QUEUE_ON_DEVICE = 1 << 2,
        /// <summary> </summary>
        CL_QUEUE_ON_DEVICE_DEFAULT = 1 << 3
    }

    /// <summary>
    /// The context info query symbols.
    /// cl_context_info
    /// </summary>
    public enum ComputeContextInfo : int
    {
        /// <summary> </summary>
        CL_CONTEXT_REFERENCE_COUNT = 0x1080,
        /// <summary> </summary>
        CL_CONTEXT_DEVICES = 0x1081,
        /// <summary> </summary>
        CL_CONTEXT_PROPERTIES = 0x1082,
        /// <summary> </summary>
        CL_CONTEXT_PLATFORM = 0x1084,
        /// <summary> </summary>
        CL_CONTEXT_ADAPTER_D3D9_KHR = 0x2025,
        /// <summary> </summary>
        CL_CONTEXT_ADAPTER_D3D9EX_KHR = 0x2026,
        /// <summary> </summary>
        CL_CONTEXT_ADAPTER_DXVA_KHR = 0x2027,
        /// <summary> </summary>
        CL_CONTEXT_D3D10_DEVICE_KHR = 0x4014,
        /// <summary> </summary>
        CL_CONTEXT_D3D11_DEVICE_KHR = 0x401D,
        /// <summary> </summary>
        CL_CONTEXT_D3D9_DEVICE_INTEL = 0x4026,
        /// <summary> </summary>
        CL_CONTEXT_D3D10_PREFER_SHARED_RESOURCES_KHR = 0x402C,
        /// <summary> </summary>
        CL_CONTEXT_D3D11_PREFER_SHARED_RESOURCES_KHR = 0x402D,
        /// <summary> </summary>
        CL_CONTEXT_D3D9EX_DEVICE_INTEL = 0x4072,
        /// <summary> </summary>
        CL_CONTEXT_DXVA_DEVICE_INTEL = 0x4073,
        /// <summary> </summary>
        CL_CONTEXT_VA_API_DISPLAY_INTEL = 0x4097,

        // OpenCL 1.1
        /// <summary> </summary>
        CL_CONTEXT_NUM_DEVICES = 0x1083,

        // OpenCL 1.1
        /// <summary> </summary>
        CL_CONTEXT_INTEROP_USER_SYNC = 0x1085,
    }

    /// <summary>
    /// cl_context_properties
    /// </summary>
    public enum ComputeContextPropertyName : int
    {
        /// <summary> </summary>
        CL_CONTEXT_PLATFORM = ComputeContextInfo.CL_CONTEXT_PLATFORM,
        /// <summary> </summary>
        CL_GL_CONTEXT_KHR = 0x2008,
        /// <summary> </summary>
        CL_EGL_DISPLAY_KHR = 0x2009,
        /// <summary> </summary>
        CL_GLX_DISPLAY_KHR = 0x200A,
        /// <summary> </summary>
        CL_WGL_HDC_KHR = 0x200B,
        /// <summary> </summary>
        CL_CGL_SHAREGROUP_KHR = 0x200C,
        /// <summary> </summary>
        CL_CONTEXT_MEMORY_INITIALIZE_KHR = 0x2030,
        /// <summary> </summary>
        CL_CONTEXT_TERMINATE_KHR = 0x2032,
        /// <summary> </summary>
        CL_PRINTF_CALLBACK_ARM = 0x40B0,
        /// <summary> </summary>
        CL_PRINTF_BUFFERSIZE_ARM = 0x40B1,
        /// <summary> </summary>
        CL_CONTEXT_SHOW_DIAGNOSTICS_INTEL = 0x4106,

        // OpenCL 1.2
        /// <summary> </summary>
        CL_CONTEXT_INTEROP_USER_SYNC = 0x1085,
    }

    /// <summary>
    /// cl_device_partition_property
    /// OpenCL 1.2
    /// </summary>
    public enum ComputeDevicePartitionProperty
    {
        /// <summary> </summary>
        CL_DEVICE_PARTITION_EQUALLY = 0x1086,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_BY_COUNTS = 0x1087,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_BY_COUNTS_LIST_END = 0x0,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN = 0x1088,
    }

    /// <summary>
    /// cl_device_affinity_domain
    /// OpenCL 1.2
    /// </summary>
    [Flags]
    public enum ComputeDeviceAffinityDomain
    {
        /// <summary> </summary>
        CL_DEVICE_AFFINITY_DOMAIN_NUMA = 1 << 0,
        /// <summary> </summary>
        CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE = 1 << 1,
        /// <summary> </summary>
        CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE = 1 << 2,
        /// <summary> </summary>
        CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE = 1 << 3,
        /// <summary> </summary>
        CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE = 1 << 4,
        /// <summary> </summary>
        CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE = 1 << 5,
    }

    /// <summary>
    /// cl_device_svm_capabilities
    /// OpenCL 2.0
    /// </summary>
    [Flags]
    public enum ComputeDeviceSVMCapabilities
    {
        /// <summary> </summary>
        CL_DEVICE_SVM_COARSE_GRAIN_BUFFER = 1 << 0,
        /// <summary> </summary>
        CL_DEVICE_SVM_FINE_GRAIN_BUFFER = 1 << 1,
        /// <summary> </summary>
        CL_DEVICE_SVM_FINE_GRAIN_SYSTEM = 1 << 2,
        /// <summary> </summary>
        CL_DEVICE_SVM_ATOMICS = 1 << 3,
    }

    /// <summary>
    /// The command queue info query symbols.
    /// cl_command_queue_info
    /// </summary>
    public enum ComputeCommandQueueInfo : int
    {
        /// <summary> </summary>
        CL_QUEUE_CONTEXT = 0x1090,
        /// <summary> </summary>
        CL_QUEUE_DEVICE = 0x1091,
        /// <summary> </summary>
        CL_QUEUE_REFERENCE_COUNT = 0x1092,
        /// <summary> </summary>
        CL_QUEUE_PROPERTIES = 0x1093,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_QUEUE_SIZE = 0x1094,

        // OpenCL 2.1
        /// <summary> </summary>
        CL_QUEUE_DEVICE_DEFAULT = 0x1095,

        // OpenCL 3.0
        /// <summary> </summary>
        CL_QUEUE_PROPERTIES_ARRAY = 0x1098,
    }

    /// <summary>
    /// cl_mem_flags and cl_svm_mem_flags - bitfield
    /// </summary>
    [Flags]
    public enum ComputeMemoryFlags : long
    {
        /// <summary> Let the OpenCL choose the default flags. </summary>
        CL_MEM_NONE = 0,
        /// <summary> The <see cref="ComputeMemory"/> will be accessible from the <see cref="ComputeKernel"/> for read and write operations. </summary>
        CL_MEM_READ_WRITE = 1 << 0,
        /// <summary> The <see cref="ComputeMemory"/> will be accessible from the <see cref="ComputeKernel"/> for write operations only. </summary>
        CL_MEM_WRITE_ONLY = 1 << 1,
        /// <summary> The <see cref="ComputeMemory"/> will be accessible from the <see cref="ComputeKernel"/> for read operations only. </summary>
        CL_MEM_READ_ONLY = 1 << 2,
        /// <summary> </summary>
        CL_MEM_USE_HOST_PTR = 1 << 3,
        /// <summary> </summary>
        CL_MEM_ALLOC_HOST_PTR = 1 << 4,
        /// <summary> </summary>
        CL_MEM_COPY_HOST_PTR = 1 << 5,
        /// <summary> </summary>
        CL_MEM_FORCE_HOST_MEMORY_INTEL = 1 << 20,
        /// <summary> </summary>
        CL_MEM_NO_ACCESS_INTEL = 1 << 24,
        /// <summary> </summary>
        CL_MEM_ACCESS_FLAGS_UNRESTRICTED_INTEL = 1 << 25,
        /// <summary> </summary>
        CL_MEM_USE_UNCACHED_CPU_MEMORY_IMG = 1 << 26,
        /// <summary> </summary>
        CL_MEM_USE_CACHED_CPU_MEMORY_IMG = 1 << 27,
        /// <summary> </summary>
        CL_MEM_USE_GRALLOC_PTR_IMG = 1 << 28,
        /// <summary> </summary>
        CL_MEM_EXT_HOST_PTR_QCOM = 1 << 29,

        // OpenCL 1.2
        /// <summary> </summary>
        CL_MEM_HOST_WRITE_ONLY = 1 << 7,
        /// <summary> </summary>
        CL_MEM_HOST_READ_ONLY = 1 << 8,
        /// <summary> </summary>
        CL_MEM_HOST_NO_ACCESS = 1 << 9,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_MEM_SVM_FINE_GRAIN_BUFFER = 1 << 10,
        /// <summary> </summary>
        CL_MEM_SVM_ATOMICS = 1 << 11,
        /// <summary> </summary>
        CL_MEM_KERNEL_READ_AND_WRITE = 1 << 12,
    }

    /// <summary>
    /// cl_mem_properties
    /// </summary>
    public enum ComputeMemoryProperties : int
    {
        /// <summary> </summary>
        CL_MEM_DEVICE_HANDLE_LIST_KHR = 0x2051,
        /// <summary> </summary>
        CL_MEM_DEVICE_HANDLE_LIST_END_KHR = 0,
        /// <summary> </summary>
        CL_MEM_ALLOC_FLAGS_IMG = 0x40D7,
        /// <summary> </summary>
        CL_MEM_ALLOC_FLAGS_INTEL = 0x4195,
        /// <summary> </summary>
        CL_MEM_ALLOC_BUFFER_LOCATION_INTEL = 0x419E,
        /// <summary> </summary>
        CL_MEM_CHANNEL_INTEL = 0x4213,
        /// <summary> </summary>
        CL_MEM_LOCALLY_UNCACHED_RESOURCE_INTEL = 0x4218,
        /// <summary> </summary>
        CL_MEM_DEVICE_ID_INTEL = 0x4219,
    }

    /// <summary>
    /// cl_mem_migration_flags - bitfield
    /// OpenCL 1.2
    /// </summary>
    [Flags]
    public enum ComputeMemoryMigrationFlags
    {
        /// <summary> </summary>
        CL_MIGRATE_MEM_OBJECT_HOST = 1 << 0,
        /// <summary> </summary>
        CL_MIGRATE_MEM_OBJECT_CONTENT_UNDEFINED = 1 << 1,
    }

    /// <summary>
    /// cl_channel_order
    /// </summary>
    public enum ComputeImageChannelOrder : int
    {
        /// <summary> </summary>
        CL_R = 0x10B0,
        /// <summary> </summary>
        CL_A = 0x10B1,
        /// <summary> </summary>
        CL_RG = 0x10B2,
        /// <summary> </summary>
        CL_RA = 0x10B3,
        /// <summary> </summary>
        CL_RGB = 0x10B4,
        /// <summary> </summary>
        CL_RGBA = 0x10B5,
        /// <summary> </summary>
        CL_BGRA = 0x10B6,
        /// <summary> </summary>
        CL_ARGB = 0x10B7,
        /// <summary> </summary>
        CL_INTENSITY = 0x10B8,
        /// <summary> </summary>
        CL_LUMINANCE = 0x10B9,
        /// <summary> </summary>
        CL_DEPTH_STENCIL = 0x10BE,
        /// <summary> </summary>
        CL_YUYV_INTEL = 0x4076,
        /// <summary> </summary>
        CL_UYVY_INTEL = 0x4077,
        /// <summary> </summary>
        CL_YVYU_INTEL = 0x4078,
        /// <summary> </summary>
        CL_VYUY_INTEL = 0x4079,
        /// <summary> </summary>
        CL_NV21_IMG = 0x40D0,
        /// <summary> </summary>
        CL_YV12_IMG = 0x40D1,
        /// <summary> </summary>
        CL_NV12_INTEL = 0x410E,

        // OpenCL 1.1
        /// <summary> </summary>
        CL_Rx = 0x10BA,
        /// <summary> </summary>
        CL_RGx = 0x10BB,
        /// <summary> </summary>
        CL_RGBx = 0x10BC,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_DEPTH = 0x10BD,
        /// <summary> </summary>
        CL_sRGB = 0x10BF,
        /// <summary> </summary>
        CL_sRGBx = 0x10C0,
        /// <summary> </summary>
        CL_sRGBA = 0x10C1,
        /// <summary> </summary>
        CL_sBGRA = 0x10C2,
        /// <summary> </summary>
        CL_ABGR = 0x10C3,
    }

    /// <summary>
    /// cl_channel_type
    /// </summary>
    public enum ComputeImageChannelType : int
    {
        /// <summary> </summary>
        CL_SNORM_INT8 = 0x10D0,
        /// <summary> </summary>
        CL_SNORM_INT16 = 0x10D1,
        /// <summary> </summary>
        CL_UNORM_INT8 = 0x10D2,
        /// <summary> </summary>
        CL_UNORM_INT16 = 0x10D3,
        /// <summary> </summary>
        CL_UNORM_SHORT_565 = 0x10D4,
        /// <summary> </summary>
        CL_UNORM_SHORT_555 = 0x10D5,
        /// <summary> </summary>
        CL_UNORM_INT_101010 = 0x10D6,
        /// <summary> </summary>
        CL_SIGNED_INT8 = 0x10D7,
        /// <summary> </summary>
        CL_SIGNED_INT16 = 0x10D8,
        /// <summary> </summary>
        CL_SIGNED_INT32 = 0x10D9,
        /// <summary> </summary>
        CL_UNSIGNED_INT8 = 0x10DA,
        /// <summary> </summary>
        CL_UNSIGNED_INT16 = 0x10DB,
        /// <summary> </summary>
        CL_UNSIGNED_INT32 = 0x10DC,
        /// <summary> </summary>
        CL_HALF_FLOAT = 0x10DD,
        /// <summary> </summary>
        CL_FLOAT = 0x10DE,
        /// <summary> </summary>
        CL_UNORM_INT24 = 0x10DF,
        /// <summary> </summary>
        CL_UNSIGNED_INT_RAW10_EXT = 0x10E3,
        /// <summary> </summary>
        CL_UNSIGNED_INT_RAW12_EXT = 0x10E4,

        // OpenCL 2.1
        /// <summary> </summary>
        CL_UNORM_INT_101010_2 = 0x10E0,

    }

    /// <summary>
    /// cl_mem_object_type
    /// </summary>
    public enum ComputeMemoryType : int
    {
        /// <summary> </summary>
        CL_MEM_OBJECT_BUFFER = 0x10F0,
        /// <summary> </summary>
        CL_MEM_OBJECT_IMAGE2D = 0x10F1,
        /// <summary> </summary>
        CL_MEM_OBJECT_IMAGE3D = 0x10F2,

        // OpenCL 1.2
        /// <summary> </summary>
        CL_MEM_OBJECT_IMAGE2D_ARRAY = 0x10F3,
        /// <summary> </summary>
        CL_MEM_OBJECT_IMAGE1D = 0x10F4,
        /// <summary> </summary>
        CL_MEM_OBJECT_IMAGE1D_ARRAY = 0x10F5,
        /// <summary> </summary>
        CL_MEM_OBJECT_IMAGE1D_BUFFER = 0x10F6,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_MEM_OBJECT_PIPE = 0x10F7,
    }

    /// <summary>
    /// The memory info query symbols.
    /// cl_mem_info
    /// </summary>
    public enum ComputeMemoryInfo : int
    {
        /// <summary> </summary>
        CL_MEM_TYPE = 0x1100,
        /// <summary> </summary>
        CL_MEM_FLAGS = 0x1101,
        /// <summary> </summary>
        CL_MEM_SIZE = 0x1102,
        /// <summary> </summary>
        CL_MEM_HOST_PTR = 0x1103,
        /// <summary> </summary>
        CL_MEM_MAP_COUNT = 0x1104,
        /// <summary> </summary>
        CL_MEM_REFERENCE_COUNT = 0x1105,
        /// <summary> </summary>
        CL_MEM_CONTEXT = 0x1106,
        /// <summary> </summary>
        CL_MEM_DX9_MEDIA_ADAPTER_TYPE_KHR = 0x2028,
        /// <summary> </summary>
        CL_MEM_DX9_MEDIA_SURFACE_INFO_KHR = 0x2029,
        /// <summary> </summary>
        CL_MEM_D3D10_RESOURCE_KHR = 0x4015,
        /// <summary> </summary>
        CL_MEM_D3D11_RESOURCE_KHR = 0x401E,
        /// <summary> </summary>
        CL_MEM_DX9_RESOURCE_INTEL = 0x4027,
        /// <summary> </summary>
        CL_MEM_DX9_SHARED_HANDLE_INTEL = 0x4074,
        /// <summary> </summary>
        CL_MEM_VA_API_MEDIA_SURFACE_INTEL = 0x4098,
        /// <summary> </summary>
        CL_MEM_USES_SVM_POINTER_ARM = 0x40B7,

        // OpenCL 1.1
        /// <summary> </summary>
        CL_MEM_ASSOCIATED_MEMOBJECT = 0x1107,
        /// <summary> </summary>
        CL_MEM_OFFSET = 0x1108,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_MEM_USES_SVM_POINTER = 0x1109,

        // OpenCL 3.0
        /// <summary> </summary>
        CL_MEM_PROPERTIES = 0x110A,
    }

    /// <summary>
    /// The memory info query symbols.
    /// cl_mem_info
    /// </summary>
    [Flags]
    public enum ComputeSVMMemoryFlags : long
    {
        /// <summary> </summary>
        CL_MEM_READ_WRITE = 1 << 0,
        /// <summary> </summary>
        CL_MEM_WRITE_ONLY = 1 << 1,
        /// <summary> </summary>
        CL_MEM_READ_ONLY = 1 << 2,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_MEM_SVM_FINE_GRAIN_BUFFER = 1 << 10,
        /// <summary> </summary>
        CL_MEM_SVM_ATOMICS = 1 << 11,

    }

    /// <summary>
    /// The image info query symbols.
    /// cl_image_info
    /// </summary>
    public enum ComputeImageInfo : int
    {
        /// <summary> </summary>
        CL_IMAGE_FORMAT = 0x1110,
        /// <summary> </summary>
        CL_IMAGE_ELEMENT_SIZE = 0x1111,
        /// <summary> </summary>
        CL_IMAGE_ROW_PITCH = 0x1112,
        /// <summary> </summary>
        CL_IMAGE_SLICE_PITCH = 0x1113,
        /// <summary> </summary>
        CL_IMAGE_WIDTH = 0x1114,
        /// <summary> </summary>
        CL_IMAGE_HEIGHT = 0x1115,
        /// <summary> </summary>
        CL_IMAGE_DEPTH = 0x1116,
        /// <summary> </summary>
        CL_IMAGE_DX9_MEDIA_PLANE_KHR = 0x202A,
        /// <summary> </summary>
        CL_IMAGE_D3D10_SUBRESOURCE_KHR = 0x4016,
        /// <summary> </summary>
        CL_IMAGE_D3D11_SUBRESOURCE_KHR = 0x401F,
        /// <summary> </summary>
        CL_IMAGE_DX9_PLANE_INTEL = 0x4075,
        /// <summary> </summary>
        CL_IMAGE_VA_API_PLANE_INTEL = 0x4099,

        // OpenCL 1.2
        /// <summary> </summary>
        CL_IMAGE_ARRAY_SIZE = 0x1117,
        /// <summary> </summary>
        CL_IMAGE_BUFFER = 0x1118,
        /// <summary> </summary>
        CL_IMAGE_NUM_MIP_LEVELS = 0x1119,
        /// <summary> </summary>
        CL_IMAGE_NUM_SAMPLES = 0x111A,
    }

    /// <summary>
    /// cl_pipe_info
    /// OpenCL 2.0
    /// </summary>
    public enum ComputePipeInfo
    {
        /// <summary> </summary>
        CL_PIPE_PACKET_SIZE = 0x1120,
        /// <summary> </summary>
        CL_PIPE_MAX_PACKETS = 0x1121,

        // OpenCL 3.0
        /// <summary> </summary>
        CL_PIPE_PROPERTIES = 0x1122,
    }


    /// <summary>
    /// cl_addressing_mode
    /// </summary>
    public enum ComputeImageAddressing : int
    {
        /// <summary> </summary>
        CL_ADDRESS_NONE = 0x1130,
        /// <summary> </summary>
        CL_ADDRESS_CLAMP_TO_EDGE = 0x1131,
        /// <summary> </summary>
        CL_ADDRESS_CLAMP = 0x1132,
        /// <summary> </summary>
        CL_ADDRESS_REPEAT = 0x1133,

        // OpenCL 1.1
        /// <summary> </summary>
        CL_ADDRESS_MIRRORED_REPEAT = 0x1134
    }

    /// <summary>
    /// cl_filter_mode
    /// </summary>
    public enum ComputeImageFiltering : int
    {
        /// <summary> </summary>
        CL_FILTER_NEAREST = 0x1140,
        /// <summary> </summary>
        CL_FILTER_LINEAR = 0x1141
    }

    /// <summary>
    /// The sampler info query symbols.
    /// cl_sampler_info
    /// </summary>
    public enum ComputeSamplerInfo : int
    {
        /// <summary> </summary>
        CL_SAMPLER_REFERENCE_COUNT = 0x1150,
        /// <summary> </summary>
        CL_SAMPLER_CONTEXT = 0x1151,
        /// <summary> </summary>
        CL_SAMPLER_NORMALIZED_COORDS = 0x1152,
        /// <summary> </summary>
        CL_SAMPLER_ADDRESSING_MODE = 0x1153,
        /// <summary> </summary>
        CL_SAMPLER_FILTER_MODE = 0x1154,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_SAMPLER_MIP_FILTER_MODE = 0x1155,
        /// <summary> </summary>
        CL_SAMPLER_LOD_MIN = 0x1156,
        /// <summary> </summary>
        CL_SAMPLER_LOD_MAX = 0x1157,

        // OpenCL 3.0
        /// <summary> </summary>
        CL_SAMPLER_PROPERTIES = 0x1158,
    }

    /// <summary>
    /// cl_map_flags - bitfield
    /// </summary>
    [Flags]
    public enum ComputeMemoryMappingFlags : long
    {
        /// <summary> </summary>
        CL_MAP_READ = 1 << 0,
        /// <summary> </summary>
        CL_MAP_WRITE = 1 << 1,

        // OpenCL 1.2
        /// <summary> </summary>
        CL_MAP_WRITE_INVALIDATE_REGION = 1 << 2,

    }

    /// <summary>
    /// The program info query symbols.
    /// cl_program_info
    /// </summary>
    public enum ComputeProgramInfo : int
    {
        /// <summary> </summary>
        CL_PROGRAM_REFERENCE_COUNT = 0x1160,
        /// <summary> </summary>
        CL_PROGRAM_CONTEXT = 0x1161,
        /// <summary> </summary>
        CL_PROGRAM_NUM_DEVICES = 0x1162,
        /// <summary> </summary>
        CL_PROGRAM_DEVICES = 0x1163,
        /// <summary> </summary>
        CL_PROGRAM_SOURCE = 0x1164,
        /// <summary> </summary>
        CL_PROGRAM_BINARY_SIZES = 0x1165,
        /// <summary> </summary>
        CL_PROGRAM_BINARIES = 0x1166,

        // OpenCL 1.2
        /// <summary> </summary>
        CL_PROGRAM_NUM_KERNELS = 0x1167,
        /// <summary> </summary>
        CL_PROGRAM_KERNEL_NAMES = 0x1168,

        // OpenCL 2.1
        /// <summary> </summary>
        CL_PROGRAM_IL = 0x1169,
        /// <summary> </summary>
        CL_PROGRAM_IL_KHR = 0x1169,

        // OpenCL 2.2
        /// <summary> </summary>
        CL_PROGRAM_SCOPE_GLOBAL_CTORS_PRESENT = 0x116A,
        /// <summary> </summary>
        CL_PROGRAM_SCOPE_GLOBAL_DTORS_PRESENT = 0x116B,
    }

    /// <summary>
    /// The program build info query symbols.
    /// cl_program_build_info
    /// </summary>
    public enum ComputeProgramBuildInfo : int
    {
        /// <summary> </summary>
        CL_PROGRAM_BUILD_STATUS = 0x1181,
        /// <summary> </summary>
        CL_PROGRAM_BUILD_OPTIONS = 0x1182,
        /// <summary> </summary>
        CL_PROGRAM_BUILD_LOG = 0x1183,

        // OpenCL 1.2
        /// <summary> </summary>
        CL_PROGRAM_BINARY_TYPE = 0x1184,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE = 0x1185,
    }

    /// <summary>
    /// cl_program_binary_type
    /// OpenCL 1.2
    /// </summary>
    public enum ComputeProgramBinaryType
    {
        /// <summary> </summary>
        CL_PROGRAM_BINARY_TYPE_NONE = 0x0,
        /// <summary> </summary>
        CL_PROGRAM_BINARY_TYPE_COMPILED_OBJECT = 0x1,
        /// <summary> </summary>
        CL_PROGRAM_BINARY_TYPE_LIBRARY = 0x2,
        /// <summary> </summary>
        CL_PROGRAM_BINARY_TYPE_EXECUTABLE = 0x4,
    }

    /// <summary>
    /// cl_build_status
    /// </summary>
    public enum ComputeProgramBuildStatus : int
    {
        /// <summary> </summary>
        CL_BUILD_SUCCESS = 0,
        /// <summary> </summary>
        CL_BUILD_NONE = -1,
        /// <summary> </summary>
        CL_BUILD_ERROR = -2,
        /// <summary> </summary>
        CL_BUILD_IN_PROGRESS = -3
    }

    /// <summary>
    /// The kernel info query symbols.
    /// cl_kernel_info
    /// </summary>
    public enum ComputeKernelInfo : int
    {
        /// <summary> </summary>
        CL_KERNEL_FUNCTION_NAME = 0x1190,
        /// <summary> </summary>
        CL_KERNEL_NUM_ARGS = 0x1191,
        /// <summary> </summary>
        CL_KERNEL_REFERENCE_COUNT = 0x1192,
        /// <summary> </summary>
        CL_KERNEL_CONTEXT = 0x1193,
        /// <summary> </summary>
        CL_KERNEL_PROGRAM = 0x1194,
        /// <summary> </summary>
        CL_KERNEL_MAX_WARP_COUNT_ARM = 0x41E9,

        // OpenCL 1.2
        /// <summary> </summary>
        CL_KERNEL_ATTRIBUTES = 0x1195,
    }

    /// <summary>
    /// cl_kernel_arg_info
    /// OpenCL 1.2
    /// </summary>
    public enum ComputeKernelArgInfo
    {
        /// <summary> </summary>
        CL_KERNEL_ARG_ADDRESS_QUALIFIER = 0x1196,
        /// <summary> </summary>
        CL_KERNEL_ARG_ACCESS_QUALIFIER = 0x1197,
        /// <summary> </summary>
        CL_KERNEL_ARG_TYPE_NAME = 0x1198,
        /// <summary> </summary>
        CL_KERNEL_ARG_TYPE_QUALIFIER = 0x1199,
        /// <summary> </summary>
        CL_KERNEL_ARG_NAME = 0x119A,
    }

    /// <summary>
    /// cl_kernel_arg_address_qualifier
    /// OpenCL 1.2
    /// </summary>
    public enum ComputeKernelArgAddressQualifier
    {
        /// <summary> </summary>
        CL_KERNEL_ARG_ADDRESS_GLOBAL = 0x119B,
        /// <summary> </summary>
        CL_KERNEL_ARG_ADDRESS_LOCAL = 0x119C,
        /// <summary> </summary>
        CL_KERNEL_ARG_ADDRESS_CONSTANT = 0x119D,
        /// <summary> </summary>
        CL_KERNEL_ARG_ADDRESS_PRIVATE = 0x119E,
    }

    /// <summary>
    /// cl_kernel_arg_access_qualifier
    /// OpenCL 1.2
    /// </summary>
    public enum ComputeKernelArgAccessQualifier
    {
        /// <summary> </summary>
        CL_KERNEL_ARG_ACCESS_READ_ONLY = 0x11A0,
        /// <summary> </summary>
        CL_KERNEL_ARG_ACCESS_WRITE_ONLY = 0x11A1,
        /// <summary> </summary>
        CL_KERNEL_ARG_ACCESS_READ_WRITE = 0x11A2,
        /// <summary> </summary>
        CL_KERNEL_ARG_ACCESS_NONE = 0x11A3,
    }

    /// <summary>
    /// cl_kernel_arg_type_qualifier
    /// OpenCL 1.2
    /// </summary>
    [Flags]
    public enum ComputeKernelArgTypeQualifier
    {
        /// <summary> </summary>
        CL_KERNEL_ARG_TYPE_NONE = 0,
        /// <summary> </summary>
        CL_KERNEL_ARG_TYPE_CONST = 1 << 0,
        /// <summary> </summary>
        CL_KERNEL_ARG_TYPE_RESTRICT = 1 << 1,
        /// <summary> </summary>
        CL_KERNEL_ARG_TYPE_VOLATILE = 1 << 2,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_KERNEL_ARG_TYPE_PIPE = 1 << 3,
    }

    /// <summary>
    /// The kernel work-group info query symbols.
    /// cl_kernel_work_group_info
    /// </summary>
    public enum ComputeKernelWorkGroupInfo : int
    {
        /// <summary> </summary>
        CL_KERNEL_WORK_GROUP_SIZE = 0x11B0,
        /// <summary> </summary>
        CL_KERNEL_COMPILE_WORK_GROUP_SIZE = 0x11B1,
        /// <summary> </summary>
        CL_KERNEL_LOCAL_MEM_SIZE = 0x11B2,
        /// <summary> </summary>
        CL_KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE = 0x11B3,
        /// <summary> </summary>
        CL_KERNEL_PRIVATE_MEM_SIZE = 0x11B4,
        /// <summary> </summary>
        CL_KERNEL_SPILL_MEM_SIZE_INTEL = 0x4109,

        // OpenCL 1.2
        /// <summary> </summary>
        CL_KERNEL_GLOBAL_WORK_SIZE = 0x11B5,
    }

    /// <summary>
    /// cl_kernel_sub_group_info
    /// OpenCL 2.1
    /// </summary>
    public enum ComputeKernelSubGroupInfo
    {
        /// <summary> </summary>
        CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE = 0x2033,
        /// <summary> </summary>
        CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE = 0x2034,
        /// <summary> </summary>
        CL_KERNEL_LOCAL_SIZE_FOR_SUB_GROUP_COUNT = 0x11B8,
        /// <summary> </summary>
        CL_KERNEL_MAX_NUM_SUB_GROUPS = 0x11B9,
        /// <summary> </summary>
        CL_KERNEL_COMPILE_NUM_SUB_GROUPS = 0x11BA,
    }

    /// <summary>
    /// cl_kernel_exec_info
    /// OpenCL 2.0
    /// </summary>
    public enum ComputeKernelExecInfo
    {
        /// <summary> </summary>
        CL_KERNEL_EXEC_INFO_SVM_PTRS = 0x11B6,
        /// <summary> </summary>
        CL_KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM = 0x11B7,
    }

    /// <summary>
    /// The event info query symbols.
    /// cl_event_info
    /// </summary>
    public enum ComputeEventInfo : int
    {
        /// <summary> </summary>
        CL_EVENT_COMMAND_QUEUE = 0x11D0,
        /// <summary> </summary>
        CL_EVENT_COMMAND_TYPE = 0x11D1,
        /// <summary> </summary>
        CL_EVENT_REFERENCE_COUNT = 0x11D2,
        /// <summary> </summary>
        CL_EVENT_COMMAND_EXECUTION_STATUS = 0x11D3,
        /// <summary> </summary>
        CL_EVENT_COMMAND_TERMINATION_REASON_ARM = 0x41ED,

        // OpenCL 1.1
        /// <summary> </summary>
        CL_EVENT_CONTEXT = 0x11D4
    }

    /// <summary>
    /// cl_command_type
    /// </summary>
    public enum ComputeCommandType : int
    {
        /// <summary> </summary>
        CL_COMMAND_NDRANGE_KERNEL = 0x11F0,
        /// <summary> </summary>
        CL_COMMAND_TASK = 0x11F1,
        /// <summary> </summary>
        CL_COMMAND_NATIVE_KERNEL = 0x11F2,
        /// <summary> </summary>
        CL_COMMAND_READ_BUFFER = 0x11F3,
        /// <summary> </summary>
        CL_COMMAND_WRITE_BUFFER = 0x11F4,
        /// <summary> </summary>
        CL_COMMAND_COPY_BUFFER = 0x11F5,
        /// <summary> </summary>
        CL_COMMAND_READ_IMAGE = 0x11F6,
        /// <summary> </summary>
        CL_COMMAND_WRITE_IMAGE = 0x11F7,
        /// <summary> </summary>
        CL_COMMAND_COPY_IMAGE = 0x11F8,
        /// <summary> </summary>
        CL_COMMAND_COPY_IMAGE_TO_BUFFER = 0x11F9,
        /// <summary> </summary>
        CL_COMMAND_COPY_BUFFER_TO_IMAGE = 0x11FA,
        /// <summary> </summary>
        CL_COMMAND_MAP_BUFFER = 0x11FB,
        /// <summary> </summary>
        CL_COMMAND_MAP_IMAGE = 0x11FC,
        /// <summary> </summary>
        CL_COMMAND_UNMAP_MEM_OBJECT = 0x11FD,
        /// <summary> </summary>
        CL_COMMAND_MARKER = 0x11FE,
        /// <summary> </summary>
        CL_COMMAND_ACQUIRE_GL_OBJECTS = 0x11FF,
        /// <summary> </summary>
        CL_COMMAND_RELEASE_GL_OBJECTS = 0x1200,
        /// <summary> </summary>
        CL_COMMAND_COMMAND_BUFFER_KHR = 0x12A8,
        /// <summary> </summary>
        CL_COMMAND_GL_FENCE_SYNC_OBJECT_KHR = 0x200D,
        /// <summary> </summary>
        CL_COMMAND_ACQUIRE_DX9_MEDIA_SURFACES_KHR = 0x202B,
        /// <summary> </summary>
        CL_COMMAND_RELEASE_DX9_MEDIA_SURFACES_KHR = 0x202C,
        /// <summary> </summary>
        CL_COMMAND_SEMAPHORE_WAIT_KHR = 0x2042,
        /// <summary> </summary>
        CL_COMMAND_SEMAPHORE_SIGNAL_KHR = 0x2043,
        /// <summary> </summary>
        CL_COMMAND_ACQUIRE_EXTERNAL_MEM_OBJECTS_KHR = 0x2047,
        /// <summary> </summary>
        CL_COMMAND_RELEASE_EXTERNAL_MEM_OBJECTS_KHR = 0x2048,
        /// <summary> </summary>
        CL_COMMAND_ACQUIRE_D3D10_OBJECTS_KHR = 0x4017,
        /// <summary> </summary>
        CL_COMMAND_RELEASE_D3D10_OBJECTS_KHR = 0x4018,
        /// <summary> </summary>
        CL_COMMAND_ACQUIRE_D3D11_OBJECTS_KHR = 0x4020,
        /// <summary> </summary>
        CL_COMMAND_RELEASE_D3D11_OBJECTS_KHR = 0x4021,
        /// <summary> </summary>
        CL_COMMAND_ACQUIRE_DX9_OBJECTS_INTEL = 0x402A,
        /// <summary> </summary>
        CL_COMMAND_RELEASE_DX9_OBJECTS_INTEL = 0x402B,
        /// <summary> </summary>
        CL_COMMAND_MIGRATE_MEM_OBJECT_EXT = 0x4040,
        /// <summary> </summary>
        CL_COMMAND_ACQUIRE_VA_API_MEDIA_SURFACES_INTEL = 0x409A,
        /// <summary> </summary>
        CL_COMMAND_RELEASE_VA_API_MEDIA_SURFACES_INTEL = 0x409B,
        /// <summary> </summary>
        CL_COMMAND_SVM_FREE_ARM = 0x40BA,
        /// <summary> </summary>
        CL_COMMAND_SVM_MEMCPY_ARM = 0x40BB,
        /// <summary> </summary>
        CL_COMMAND_SVM_MEMFILL_ARM = 0x40BC,
        /// <summary> </summary>
        CL_COMMAND_SVM_MAP_ARM = 0x40BD,
        /// <summary> </summary>
        CL_COMMAND_SVM_UNMAP_ARM = 0x40BE,
        /// <summary> </summary>
        CL_COMMAND_ACQUIRE_GRALLOC_OBJECTS_IMG = 0x40D2,
        /// <summary> </summary>
        CL_COMMAND_RELEASE_GRALLOC_OBJECTS_IMG = 0x40D3,
        /// <summary> </summary>
        CL_COMMAND_GENERATE_MIPMAP_IMG = 0x40D6,
        /// <summary> </summary>
        CL_COMMAND_MEMFILL_INTEL = 0x4204,
        /// <summary> </summary>
        CL_COMMAND_MEMCPY_INTEL = 0x4205,
        /// <summary> </summary>
        CL_COMMAND_MIGRATEMEM_INTEL = 0x4206,
        /// <summary> </summary>
        CL_COMMAND_MEMADVISE_INTEL = 0x4207,

        // OpenCL 1.1
        /// <summary> </summary>
        CL_COMMAND_READ_BUFFER_RECT = 0x1201,
        /// <summary> </summary>
        CL_COMMAND_WRITE_BUFFER_RECT = 0x1202,
        /// <summary> </summary>
        CL_COMMAND_COPY_BUFFER_RECT = 0x1203,
        /// <summary> </summary>
        CL_COMMAND_USER = 0x1204,

        // OpenCL 1.2
        /// <summary> </summary>
        CL_COMMAND_BARRIER = 0x1205,
        /// <summary> </summary>
        CL_COMMAND_MIGRATE_MEM_OBJECTS = 0x1206,
        /// <summary> </summary>
        CL_COMMAND_FILL_BUFFER = 0x1207,
        /// <summary> </summary>
        CL_COMMAND_FILL_IMAGE = 0x1208,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_COMMAND_SVM_FREE = 0x1209,
        /// <summary> </summary>
        CL_COMMAND_SVM_MEMCPY = 0x120A,
        /// <summary> </summary>
        CL_COMMAND_SVM_MEMFILL = 0x120B,
        /// <summary> </summary>
        CL_COMMAND_SVM_MAP = 0x120C,
        /// <summary> </summary>
        CL_COMMAND_SVM_UNMAP = 0x120D,

        // OpenCL 3.0
        /// <summary> </summary>
        CL_COMMAND_SVM_MIGRATE_MEM = 0x120E,
    }

    /// <summary>
    /// command execution status
    /// </summary>
    public enum ComputeCommandExecutionStatus : int
    {
        /// <summary> </summary>
        CL_COMPLETE = 0x0,
        /// <summary> </summary>
        CL_RUNNING = 0x1,
        /// <summary> </summary>
        CL_SUBMITTED = 0x2,
        /// <summary> </summary>
        CL_QUEUED = 0x3
    }

    /// <summary>
    /// cl_buffer_create_type
    /// </summary>
    public enum ComputeBufferCreateType : int
    {
        // OpenCL 1.1
        /// <summary> </summary>
        CL_BUFFER_CREATE_TYPE_REGION = 0x1220
    }

    /// <summary>
    /// The command profiling info query symbols.
    /// cl_profiling_info
    /// </summary>
    public enum ComputeCommandProfilingInfo : int
    {
        /// <summary> </summary>
        CL_PROFILING_COMMAND_QUEUED = 0x1280,
        /// <summary> </summary>
        CL_PROFILING_COMMAND_SUBMIT = 0x1281,
        /// <summary> </summary>
        CL_PROFILING_COMMAND_START = 0x1282,
        /// <summary> </summary>
        CL_PROFILING_COMMAND_END = 0x1283,

        // OpenCL 2.0
        /// <summary> </summary>
        CL_PROFILING_COMMAND_COMPLETE = 0x1284
    }

    /// <summary>
    /// cl_device_atomic_capabilities - bitfield
    /// OpenCL 3.0
    /// </summary>
    [Flags]
    public enum ComputeDeviceAtomicCapabilities
    {
        /// <summary> </summary>
        CL_DEVICE_ATOMIC_ORDER_RELAXED = 1 << 0,
        /// <summary> </summary>
        CL_DEVICE_ATOMIC_ORDER_ACQ_REL = 1 << 1,
        /// <summary> </summary>
        CL_DEVICE_ATOMIC_ORDER_SEQ_CST = 1 << 2,
        /// <summary> </summary>
        CL_DEVICE_ATOMIC_SCOPE_WORK_ITEM = 1 << 3,
        /// <summary> </summary>
        CL_DEVICE_ATOMIC_SCOPE_WORK_GROUP = 1 << 4,
        /// <summary> </summary>
        CL_DEVICE_ATOMIC_SCOPE_DEVICE = 1 << 5,
        /// <summary> </summary>
        CL_DEVICE_ATOMIC_SCOPE_ALL_DEVICES = 1 << 6,
    }

    /// <summary>
    ///  cl_device_device_enqueue_capabilities - bitfield
    /// OpenCL 3.0
    /// </summary>
    [Flags]
    public enum ComputeDeviceEnqueueCapabilities
    {
        /// <summary> </summary>
        CL_DEVICE_QUEUE_SUPPORTED = 1 << 0,
        /// <summary> </summary>
        CL_DEVICE_QUEUE_REPLACEABLE_DEFAULT = 1 << 1,
    }

    /**************************************************************************************/
    // CL/GL Sharing API

    /// <summary>
    /// cl_gl_object_type
    /// </summary>
    public enum ComputeGLObjectType : int
    {
        /// <summary> </summary>
        CL_GL_OBJECT_BUFFER = 0x2000,
        /// <summary> </summary>
        CL_GL_OBJECT_TEXTURE2D = 0x2001,
        /// <summary> </summary>
        CL_GL_OBJECT_TEXTURE3D = 0x2002,
        /// <summary> </summary>
        CL_GL_OBJECT_RENDERBUFFER = 0x2003,

        // OpenCL 1.2
        /// <summary> </summary>
        CL_GL_OBJECT_TEXTURE2D_ARRAY = 0x200E,
        /// <summary> </summary>
        CL_GL_OBJECT_TEXTURE1D = 0x200F,
        /// <summary> </summary>
        CL_GL_OBJECT_TEXTURE1D_ARRAY = 0x2010,
        /// <summary> </summary>
        CL_GL_OBJECT_TEXTURE_BUFFER = 0x2011,

    }

    /// <summary>
    /// The shared CL/GL image/texture info query symbols.
    /// cl_gl_texture_info
    /// </summary>
    public enum ComputeGLTextureInfo : int
    {
        /// <summary> </summary>
        CL_GL_TEXTURE_TARGET = 0x2004,
        /// <summary> </summary>
        CL_GL_MIPMAP_LEVEL = 0x2005,
        /// <summary> </summary>
        CL_GL_NUM_SAMPLES = 0x2012
    }

    /// <summary>
    /// The shared CL/GL context info query symbols.
    /// cl_gl_context_info
    /// </summary>
    public enum ComputeGLContextInfo : int
    {
        /// <summary> </summary>
        CL_CURRENT_DEVICE_FOR_GL_CONTEXT_KHR = 0x2006,
        /// <summary> </summary>
        CL_DEVICES_FOR_GL_CONTEXT_KHR = 0x2007
    }

    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum cl_device_partition_property_ext
    {
        /// <summary> </summary>
        CL_DEVICE_PARTITION_EQUALLY_EXT = 0x4050,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_BY_COUNTS_EXT = 0x4051,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_BY_NAMES_EXT = 0x4052,
        /// <summary> </summary>
        CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN_EXT = 0x4053,

        /// <summary> </summary>
        CL_AFFINITY_DOMAIN_L1_CACHE_EXT = 0x1,
        /// <summary> </summary>
        CL_AFFINITY_DOMAIN_L2_CACHE_EXT = 0x2,
        /// <summary> </summary>
        CL_AFFINITY_DOMAIN_L3_CACHE_EXT = 0x3,
        /// <summary> </summary>
        CL_AFFINITY_DOMAIN_L4_CACHE_EXT = 0x4,
        /// <summary> </summary>
        CL_AFFINITY_DOMAIN_NUMA_EXT = 0x10,
        /// <summary> </summary>
        CL_AFFINITY_DOMAIN_NEXT_FISSIONABLE_EXT = 0x100,

        /// <summary> </summary>
        CL_PROPERTIES_LIST_END_EXT = 0x0,
        /// <summary> </summary>
        CL_PARTITION_BY_COUNTS_LIST_END_EXT = 0x0,
        /// <summary> </summary>
        CL_PARTITION_BY_NAMES_LIST_END_EXT = -1
    }

    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum cl_mem_migration_flags_ext
    {
        /// <summary> </summary>
        CL_MIGRATE_MEM_NONE = 0,
        /// <summary> </summary>
        CL_MIGRATE_MEM_OBJECT_HOST_EXT = 0x1,
    }

    internal enum CLFunctionNames
    {
        Unknown,
        GetPlatformIDs,
        GetPlatformInfo,
        GetDeviceIDs,
        GetDeviceInfo,
        CreateContext,
        CreateContextFromType,
        RetainContext,
        ReleaseContext,
        GetContextInfo,
        CreateCommandQueue,
        RetainCommandQueue,
        ReleaseCommandQueue,
        GetCommandQueueInfo,
        SetCommandQueueProperty,
        CreateBuffer,
        CreateImage2D,
        CreateImage3D,
        RetainMemObject,
        ReleaseMemObject,
        GetSupportedImageFormats,
        GetMemObjectInfo,
        GetImageInfo,
        CreateSampler,
        RetainSampler,
        ReleaseSampler,
        GetSamplerInfo,
        CreateProgramWithSource,
        CreateProgramWithBinary,
        RetainProgram,
        ReleaseProgram,
        BuildProgram,
        UnloadCompiler,
        GetProgramInfo,
        GetProgramBuildInfo,
        CreateKernel,
        CreateKernelsInProgram,
        RetainKernel,
        ReleaseKernel,
        SetKernelArg,
        GetKernelInfo,
        GetKernelWorkGroupInfo,
        WaitForEvents,
        GetEventInfo,
        RetainEvent,
        ReleaseEvent,
        GetEventProfilingInfo,
        Flush,
        Finish,
        EnqueueReadBuffer,
        EnqueueWriteBuffer,
        EnqueueCopyBuffer,
        EnqueueReadImage,
        EnqueueWriteImage,
        EnqueueCopyImage,
        EnqueueCopyImageToBuffer,
        EnqueueCopyBufferToImage,
        EnqueueMapBuffer,
        EnqueueMapImage,
        EnqueueUnmapMemObject,
        EnqueueNDRangeKernel,
        EnqueueTask,
        EnqueueNativeKernel,
        EnqueueMarker,
        EnqueueWaitForEvents,
        EnqueueBarrier,
        GetExtensionFunctionAddress,
        CreateFromGLBuffer,
        CreateFromGLTexture2D,
        CreateFromGLTexture3D,
        CreateFromGLRenderbuffer,
        GetGLObjectInfo,
        GetGLTextureInfo,
        EnqueueAcquireGLObjects,
        EnqueueReleaseGLObjects,
    }
}