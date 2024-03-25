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
using static System.Net.WebRequestMethods;

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
        /// <summary>
        /// OpenCL profile string. Returns the profile name supported by the implementation. The profile name returned can be one of the following strings:
        /// 
        /// FULL_PROFILE - if the implementation supports the OpenCL specification (functionality defined as part of the core specification and does not require any extensions to be supported).
        /// 
        /// EMBEDDED_PROFILE - if the implementation supports the OpenCL embedded profile. The embedded profile is defined to be a subset for each version of OpenCL. The embedded profile for OpenCL is described in <see cref="https://www.khronos.org/registry/OpenCL/specs/3.0-unified/html/OpenCL_API.html#opencl-embedded-profile">OpenCL Embedded Profile</see>.
        /// </summary>
        Profile = 0x0900,
        /// <summary>
        /// OpenCL version string. Returns the OpenCL version supported by the implementation. This version string has the following format:
        /// 
        /// OpenCL&lt;space&gt;&lt;major_version.minor_version&gt;&lt;space&gt;&lt;platform-specific information&gt;
        /// 
        /// The major_version.minor_version value returned will be one of 1.0, 1.1, 1.2, 2.0, 2.1, 2.2 or 3.0.
        /// </summary>
        Version = 0x0901,
        /// <summary>
        /// Platform name string.
        /// </summary>
        Name = 0x0902,
        /// <summary>
        /// Platform vendor string.
        /// </summary>
        Vendor = 0x0903,
        /// <summary>
        /// Returns a space separated list of extension names (the extension names themselves do not contain any spaces) supported by the platform. Each extension that is supported by all devices associated with this platform must be reported here.
        /// </summary>
        Extensions = 0x0904,
        /// <summary> </summary>

        // OpenCL 2.1
        /// <summary>
        /// Returns the resolution of the host timer in nanoseconds as used by clGetDeviceAndHostTimer.
        /// 
        /// Support for device and host timer synchronization is required for platforms supporting OpenCL 2.1 or 2.2. This value must be 0 for devices that do not support device and host timer synchronization.
        /// </summary>
        HostTimerResolution = 0x0905,

        // OpenCL 3.0
        /// <summary>
        /// Returns the detailed (major, minor, patch) version supported by the platform. The major and minor version numbers returned must match those returned via CL_PLATFORM_VERSION.
        /// </summary>
        NumericVersion = 0x0906,
        /// <summary>
        /// Returns an array of description (name and version) structures that lists all the extensions supported by the platform. The same extension name must not be reported more than once. The list of extensions reported must match the list reported via CL_PLATFORM_EXTENSIONS.
        /// </summary>
        ExtensionsWithVersion = 0x0907,
    }

    /// <summary>
    /// The types of devices.
    /// cl_device_type - bitfield
    /// </summary>
    [Flags]
    public enum ComputeDeviceType : long
    {
        /// <summary>
        /// An OpenCL device similar to a traditional CPU (Central Processing Unit). The host processor that executes OpenCL host code may also be considered a CPU OpenCL device.
        /// </summary>
        CPU = 1 << 1,
        /// <summary>
        /// An OpenCL device similar to a GPU (Graphics Processing Unit). Many systems include a dedicated processor for graphics or rendering that may be considered a GPU OpenCL device.
        /// </summary>
        GPU = 1 << 2,
        /// <summary>
        /// Dedicated devices that may accelerate OpenCL programs, such as FPGAs (Field Programmable Gate Arrays), DSPs (Digital Signal Processors), or AI (Artificial Intelligence) processors.
        /// </summary>
        Accelerator = 1 << 3,
        /// <summary>
        /// The default OpenCL device in the platform. The default OpenCL device must not be a CL_DEVICE_TYPE_CUSTOM device.
        /// </summary>
        Default = 1 << 0,
        /// <summary>
        /// All OpenCL devices available in the platform, except for CL_DEVICE_TYPE_CUSTOM devices.
        /// </summary>
        All = 0xFFFFFFFF,

        // OpenCL 1.2
        /// <summary>
        /// Specialized devices that implement some of the OpenCL runtime APIs but do not support all required OpenCL functionality.
        /// </summary>
        Custom = 1 << 4
    }

    /// <summary>
    /// The device info query symbols.
    /// cl_device_info
    /// </summary>
    public enum ComputeDeviceInfo : int
    {
        /// <summary>
        /// The type or types of the OpenCL device.
        /// 
        /// Please see the Device Types table for supported device types and device type combinations.
        /// </summary>
        Type = 0x1000,
        /// <summary>
        /// A unique device vendor identifier.
        /// 
        /// f the vendor has a PCI vendor ID, the low 16 bits must contain that PCI vendor ID, and the remaining bits must be set to zero. Otherwise, the value returned must be a valid Khronos vendor ID represented by type cl_khronos_vendor_id. Khronos vendor IDs are allocated starting at 0x10000, to distinguish them from the PCI vendor ID namespace.
        /// </summary>
        VendorID = 0x1001,
        /// <summary>
        /// The number of parallel compute units on the OpenCL device. A work-group executes on a single compute unit. The minimum value is 1.
        /// </summary>
        MaxComputeUnits = 0x1002,
        /// <summary>
        /// Maximum dimensions that specify the global and local work-item IDs used by the data parallel execution model. (Refer to clEnqueueNDRangeKernel). The minimum value is 3 for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        MaxWorkItemDimensions = 0x1003,
        /// <summary>
        /// Maximum number of work-items that can be specified in each dimension of the work-group to clEnqueueNDRangeKernel.
        /// 
        /// Returns n size_t entries, where n is the value returned by the query for CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS.
        /// 
        /// The minimum value is (1, 1, 1) for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        MaxWorkItemSizes = 0x1005,
        /// <summary>
        /// Maximum number of work-items in a work-group that a device is capable of executing on a single compute unit, for any given kernel-instance running on the device. (Refer also to clEnqueueNDRangeKernel and CL_KERNEL_WORK_GROUP_SIZE ). The minimum value is 1. The returned value is an upper limit and will not necessarily maximize performance. This maximum may be larger than supported by a specific kernel (refer to the CL_KERNEL_WORK_GROUP_SIZE query of clGetKernelWorkGroupInfo).
        /// </summary>
        MaxWorkGroupSize = 0x1004,
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        PreferredVectorWidthChar = 0x1006,
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        PreferredVectorWidthShort = 0x1007,
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        PreferredVectorWidthInt = 0x1008,
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        PreferredVectorWidthLong = 0x1009,
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        PreferredVectorWidthFloat = 0x100A,
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        PreferredVectorWidthDouble = 0x100B,
        /// <summary>
        /// Clock frequency of the device in MHz. The meaning of this value is implementation-defined. For devices with multiple clock domains, the clock frequency for any of the clock domains may be returned. For devices that dynamically change frequency for power or thermal reasons, the returned clock frequency may be any valid frequency. Note: This definition is missing before version 2.2.
        /// 
        /// Maximum configured clock frequency of the device in MHz. Note: This definition is deprecated by version 2.2.
        /// </summary>
        MaxClockFrequency = 0x100C,
        /// <summary>
        /// The default compute device address space size of the global address space specified as an unsigned integer value in bits. Currently supported values are 32 or 64 bits.
        /// </summary>
        AddressBits = 0x100D,
        /// <summary>
        /// Max size of memory object allocation in bytes. The minimum value is max(min(1024 × 1024 × 1024, 1/4th of CL_DEVICE_GLOBAL_MEM_SIZE), 32 × 1024 × 1024) for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        MaxMemoryAllocationSize = 0x1010,
        /// <summary>
        /// Is CL_TRUE if images are supported by the OpenCL device and CL_FALSE otherwise.
        /// </summary>
        ImageSupport = 0x1016,
        /// <summary>
        /// Max number of image objects arguments of a kernel declared with the read_only qualifier. The minimum value is 128 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE, the value is 0 otherwise.
        /// </summary>
        MaxReadImageArguments = 0x100E,
        /// <summary>
        /// Max number of image objects arguments of a kernel declared with the write_only qualifier. The minimum value is 64 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE, the value is 0 otherwise.
        /// </summary>
        MaxWriteImageArguments = 0x100F,
        /// <summary>
        /// Max width of 2D image or 1D image not created from a buffer object in pixels.
        /// 
        /// The minimum value is 16384 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE, the value is 0 otherwise.
        /// </summary>
        Image2DMaxWidth = 0x1011,
        /// <summary>
        /// Max height of 2D image in pixels.
        /// 
        /// The minimum value is 16384 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE, the value is 0 otherwise.
        /// </summary>
        Image2DMaxHeight = 0x1012,
        /// <summary>
        /// Max width of 3D image in pixels.
        /// 
        /// The minimum value is 2048 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE, the value is 0 otherwise.
        /// </summary>
        Image3DMaxWidth = 0x1013,
        /// <summary>
        /// Max height of 3D image in pixels.
        /// 
        /// The minimum value is 2048 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE, the value is 0 otherwise.
        /// </summary>
        Image3DMaxHeight = 0x1014,
        /// <summary>
        /// Max depth of 3D image in pixels.
        /// 
        /// The minimum value is 2048 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE, the value is 0 otherwise.
        /// </summary>
        Image3DMaxDepth = 0x1015,
        /// <summary>
        /// Maximum number of samplers that can be used in a kernel.
        /// 
        /// The minimum value is 16 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE, the value is 0 otherwise.
        /// </summary>
        MaxSamplers = 0x1018,
        /// <summary>
        /// Max size in bytes of all arguments that can be passed to a kernel.
        /// 
        /// The minimum value is 1024 for devices that are not of type CL_DEVICE_TYPE_CUSTOM. For this minimum value, only a maximum of 128 arguments can be passed to a kernel. For all other values, a maximum of 255 arguments can be passed to a kernel.
        /// </summary>
        MaxParameterSize = 0x1017,
        /// <summary>
        /// Alignment requirement (in bits) for sub-buffer offsets. The minimum value is the size (in bits) of the largest OpenCL built-in data type supported by the device (long16 in FULL profile, long16 or int16 in EMBEDDED profile) for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        MemoryBaseAddressAlign = 0x1019,
        /// <summary>
        /// The minimum value is the size (in bytes) of the largest OpenCL data type supported by the device (long16 in FULL profile, long16 or int16 in EMBEDDED profile).
        /// 
        /// Depracated in CL 1.2
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2.")]
        MinDataTypeAlignSize = 0x101A,
        /// <summary>
        /// Describes single precision floating-point capability of the device. This is a bit-field that describes one or more of the following values:
        /// 
        /// CL_FP_DENORM - denorms are supported
        /// CL_FP_INF_NAN - INF and quiet NaNs are supported
        /// CL_FP_ROUND_TO_NEAREST-- round to nearest even rounding mode supported
        /// CL_FP_ROUND_TO_ZERO - round to zero rounding mode supported
        /// CL_FP_ROUND_TO_INF - round to positive and negative infinity rounding modes supported
        /// CL_FP_FMA - IEEE754-2008 fused multiply-add is supported
        /// CL_FP_CORRECTLY_ROUNDED_DIVIDE_SQRT - divide and sqrt are correctly rounded as defined by the IEEE754 specification
        /// CL_FP_SOFT_FLOAT - Basic floating-point operations (such as addition, subtraction, multiplication) are implemented in software
        /// 
        /// For the full profile, the mandated minimum floating-point capability for devices that are not of type CL_DEVICE_TYPE_CUSTOM is:
        /// CL_FP_ROUND_TO_NEAREST | CL_FP_INF_NAN.
        /// 
        /// For the embedded profile, see the dedicated table.
        /// </summary>
        SingleFloatingPointConfig = 0x101B,
        /// <summary>
        /// Type of global memory cache supported. Valid values are: CL_NONE, CL_READ_ONLY_CACHE, and CL_READ_WRITE_CACHE.
        /// </summary>
        GlobalMemoryCcacheType = 0x101C,
        /// <summary>
        /// Size of global memory cache line in bytes.
        /// </summary>
        GlobalMemoryCachelineSize = 0x101D,
        /// <summary>
        /// Size of global memory cache in bytes.
        /// </summary>
        GlobalMemoryCacheSize = 0x101E,
        /// <summary>
        /// Size of global device memory in bytes.
        /// </summary>
        GlobalMemorySize = 0x101F,
        /// <summary>
        /// Max size in bytes of a constant buffer allocation. The minimum value is 64 KB for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        MaxConstantBufferSize = 0x1020,
        /// <summary>
        /// Max number of arguments declared with the __constant qualifier in a kernel. The minimum value is 8 for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        MaxConstantArgs = 0x1021,
        /// <summary>
        /// Type of local memory supported. This can be set to CL_LOCAL implying dedicated local memory storage such as SRAM , or CL_GLOBAL.
        /// 
        /// For custom devices, CL_NONE can also be returned indicating no local memory support.
        /// </summary>
        LocalMemoryType = 0x1022,
        /// <summary>
        /// Size of local memory region in bytes. The minimum value is 32 KB for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        LolcalMemorySize = 0x1023,
        /// <summary>
        /// Is CL_TRUE if the device implements error correction for all accesses to compute device memory (global and constant). Is CL_FALSE if the device does not implement such error correction.
        /// </summary>
        ErrorCorrectionSupport = 0x1024,
        /// <summary>
        /// Describes the resolution of device timer. This is measured in nanoseconds. Refer to Profiling Operations for details.
        /// </summary>
        ProfilingTimerResolution = 0x1025,
        /// <summary>
        /// Is CL_TRUE if the OpenCL device is a little endian device and CL_FALSE otherwise
        /// </summary>
        EndianLittle = 0x1026,
        /// <summary>
        /// Is CL_TRUE if the device is available and CL_FALSE otherwise. A device is considered to be available if the device can be expected to successfully execute commands enqueued to the device.
        /// </summary>
        Available = 0x1027,
        /// <summary>
        /// Is CL_FALSE if the implementation does not have a compiler available to compile the program source.
        /// 
        /// Is CL_TRUE if the compiler is available. This can be CL_FALSE for the embedded platform profile only.
        /// </summary>
        CompilerAvailable = 0x1028,
        /// <summary>
        /// Describes the execution capabilities of the device. This is a bit-field that describes one or more of the following values:
        /// 
        /// CL_EXEC_KERNEL - The OpenCL device can execute OpenCL kernels.
        /// CL_EXEC_NATIVE_KERNEL - The OpenCL device can execute native kernels.
        /// 
        /// The mandated minimum capability is: CL_EXEC_KERNEL.
        /// </summary>
        ExecutionCapabilities = 0x1029,
        /// <summary>
        /// See description of CL_DEVICE_QUEUE_ON_HOST_PROPERTIES.
        /// 
        /// Deprecated in CL 2.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 2.0.")]
        QueueProperties = 0x102A,
        /// <summary>
        /// The platform associated with this device.
        /// </summary>
        Platform = 0x1031,
        /// <summary>
        /// Device name string.
        /// </summary>
        Name = 0x102B,
        /// <summary>
        /// Vendor name string.
        /// </summary>
        Vendor = 0x102C,
        /// <summary>
        /// OpenCL software driver version string. Follows a vendor-specific format.
        /// </summary>
        DriverVersion = 0x102D,
        /// <summary>
        /// OpenCL profile string. Returns the profile name supported by the device. The profile name returned can be one of the following strings:
        /// 
        /// FULL_PROFILE - if the device supports the OpenCL specification (functionality defined as part of the core specification and does not require any extensions to be supported).
        /// 
        /// EMBEDDED_PROFILE - if the device supports the OpenCL embedded profile.
        /// </summary>
        Profile = 0x102E,
        /// <summary>
        /// OpenCL version string. Returns the OpenCL version supported by the device. This version string has the following format:
        /// 
        /// OpenCL&lt;space&gt;&lt;major_version.minor_version&gt;&lt;space&gt;&lt;vendor-specific information&gt;
        /// 
        /// The major_version.minor_version value returned will be one of 1.0, 1.1, 1.2, 2.0, 2.1, 2.2, or 3.0.
        /// </summary>
        DeviceVersion = 0x102F,
        /// <summary>
        /// Returns a space separated list of extension names (the extension names themselves do not contain any spaces) supported by the device. The list of extension names may include Khronos approved extension names and vendor specified extension names.
        /// 
        /// The following Khronos extension names must be returned by all devices that support OpenCL 1.1:
        /// 
        /// cl_khr_byte_addressable_store
        /// cl_khr_global_int32_base_atomics
        /// cl_khr_global_int32_extended_atomics
        /// cl_khr_local_int32_base_atomics
        /// cl_khr_local_int32_extended_atomics
        /// 
        /// Additionally, the following Khronos extension names must be returned by all devices that support OpenCL 1.2 when and only when the optional feature is supported:
        /// 
        /// cl_khr_fp64
        /// 
        /// Additionally, the following Khronos extension names must be returned by all devices that support OpenCL 2.0, OpenCL 2.1, or OpenCL 2.2. For devices that support OpenCL 3.0, these extension names must be returned when and only when the optional feature is supported:
        /// 
        /// cl_khr_3d_image_writes
        /// cl_khr_depth_images
        /// cl_khr_image2d_from_buffer
        /// 
        /// Please refer to the OpenCL Extension Specification or vendor provided documentation for a detailed description of these extensions.
        /// </summary>
        Extensions = 0x1030,

        // OpenCL 1.1
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        PreferredVectorWidthHalf = 0x1034,
        /// <summary>
        /// Returns the native ISA vector width. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        NativeVectorWidthChar = 0x1036,
        /// <summary>
        /// Returns the native ISA vector width. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        NativeVectorWidthShort = 0x1037,
        /// <summary>
        /// Returns the native ISA vector width. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        NativeVectorWidthInt = 0x1038,
        /// <summary>
        /// Returns the native ISA vector width. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        NativeVectorWidthLong = 0x1039,
        /// <summary>
        /// Returns the native ISA vector width. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        NativeVectorWidthFloat = 0x103A,
        /// <summary>
        /// Returns the native ISA vector width. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        NativeVectorWidthDouble = 0x103B,
        /// <summary>
        /// Returns the native ISA vector width. The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// 
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.
        /// 
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        NativeVectorWidthHalf = 0x103C,
        /// <summary>
        /// Is CL_TRUE if the device and the host have a unified memory subsystem and is CL_FALSE otherwise.
        /// 
        /// Deprecated in CL 2.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 2.0.")]
        HostUnifiedMemory = 0x1035,
        /// <summary>
        /// Returns the highest fully backwards compatible OpenCL C version supported by the compiler for the device. For devices supporting compilation from OpenCL C source, this will return a version string with the following format:
        /// 
        /// OpenCL&lt;space&gt;C&lt;space&gt;&lt;major_version.minor_version&gt;&lt;space&gt;&lt;vendor-specific information&gt;
        /// 
        /// For devices that support compilation from OpenCL C source:
        /// 
        /// Because OpenCL 3.0 is backwards compatible with OpenCL C 1.2, an OpenCL 3.0 device must support at least OpenCL C 1.2. An OpenCL 3.0 device may return an OpenCL C version newer than OpenCL C 1.2 if and only if all optional OpenCL C features are supported by the device for the newer version.
        /// 
        /// Support for OpenCL C 2.0 is required for an OpenCL 2.0, OpenCL 2.1, or OpenCL 2.2 device.
        /// 
        /// Support for OpenCL C 1.2 is required for an OpenCL 1.2 device.
        /// 
        /// Support for OpenCL C 1.1 is required for an OpenCL 1.1 device.
        /// 
        /// Support for either OpenCL C 1.0 or OpenCL C 1.1 is required for an OpenCL 1.0 device.
        /// 
        /// For devices that do not support compilation from OpenCL C source, such as when CL_DEVICE_COMPILER_AVAILABLE is CL_FALSE, this query may return an empty string.
        /// 
        /// This query has been superseded by the CL_DEVICE_OPENCL_C_ALL_VERSIONS query, which returns a set of OpenCL C versions supported by a device.
        /// </summary>
        [Obsolete("Deprecated in OpenCL 3.0.")]
        OpenCL_C_Version = 0x103D,

        // OpenCL 1.2
        /// <summary>
        /// Max number of pixels for a 1D image created from a buffer object.
        /// 
        /// The minimum value is 65536 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE, the value is 0 otherwise.
        /// </summary>
        ImageMaxBufferSize = 0x1040,
        /// <summary>
        /// Max number of images in a 1D or 2D image array.
        /// 
        /// The minimum value is 2048 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE, the value is 0 otherwise.
        /// </summary>
        ImageMaxArraySize = 0x1041,
        /// <summary>
        /// Describes double precision floating-point capability of the OpenCL device. This is a bit-field that describes one or more of the following values:
        /// 
        /// CL_FP_DENORM - denorms are supported
        /// CL_FP_INF_NAN - INF and NaNs are supported
        /// CL_FP_ROUND_TO_NEAREST - round to nearest even rounding mode supported
        /// CL_FP_ROUND_TO_ZERO - round to zero rounding mode supported
        /// CL_FP_ROUND_TO_INF - round to positive and negative infinity rounding modes supported
        /// CL_FP_FMA - IEEE754-2008 fused multiply-add is supported
        /// CL_FP_SOFT_FLOAT - Basic floating-point operations (such as addition, subtraction, multiplication) are implemented in software
        /// 
        /// Double precision is an optional feature so the mandated minimum double precision floating-point capability is 0.
        /// 
        /// If double precision is supported by the device, then the minimum double precision floating-point capability for OpenCL 2.0 or newer devices is:
        /// CL_FP_FMA | CL_FP_ROUND_TO_NEAREST | CL_FP_INF_NAN | CL_FP_DENORM.
        /// 
        /// or for OpenCL 1.0, OpenCL 1.1 or OpenCL 1.2 devices:
        /// CL_FP_FMA | CL_FP_ROUND_TO_NEAREST | CL_FP_ROUND_TO_ZERO | CL_FP_ROUND_TO_INF | CL_FP_INF_NAN | CL_FP_DENORM.
        /// </summary>
        DoubleFloatingPointConfig = 0x1032,
        /// <summary>
        /// Is CL_FALSE if the implementation does not have a linker available. Is CL_TRUE if the linker is available.
        /// 
        /// This can be CL_FALSE for the embedded platform profile only.
        /// 
        /// This must be CL_TRUE if CL_DEVICE_COMPILER_AVAILABLE is CL_TRUE.
        /// </summary>
        LinkerAvailable = 0x103E,
        /// <summary>
        /// A semi-colon separated list of built-in kernels supported by the device. An empty string is returned if no built-in kernels are supported by the device.
        /// </summary>
        BuiltInKernels = 0x103F,
        /// <summary>
        /// Maximum size in bytes of the internal buffer that holds the output of printf calls from a kernel. The minimum value for the FULL profile is 1 MB.
        /// </summary>
        PrintfBufferSize = 0x1049,
        /// <summary>
        /// Is CL_TRUE if the devices preference is for the user to be responsible for synchronization, when sharing memory objects between OpenCL and other APIs such as DirectX, CL_FALSE if the device / implementation has a performant path for performing synchronization of memory object shared between OpenCL and other APIs such as DirectX.
        /// </summary>
        PreferredInteropUserSync = 0x1048,
        /// <summary>
        /// Returns the cl_device_id of the parent device to which this sub-device belongs. If device is a root-level device, a NULL value is returned.
        /// </summary>
        ParentDevice = 0x1042,
        /// <summary>
        /// Returns the maximum number of sub-devices that can be created when a device is partitioned.
        /// 
        /// The value returned cannot exceed CL_DEVICE_MAX_COMPUTE_UNITS.
        /// </summary>
        PartitionMaxSubDevices = 0x1043,
        /// <summary>
        /// Returns the list of partition types supported by device. This is an array of cl_device_partition_property values drawn from the following list:
        /// 
        /// CL_DEVICE_PARTITION_EQUALLY
        /// CL_DEVICE_PARTITION_BY_COUNTS
        /// CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN
        /// 
        /// If the device cannot be partitioned (i.e. there is no partitioning scheme supported by the device that will return at least two sub-devices), a value of 0 will be returned.
        /// </summary>
        PartitionProperties = 0x1044,
        /// <summary>
        /// Returns the list of supported affinity domains for partitioning the device using CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN. This is a bit-field that describes one or more of the following values:
        /// 
        /// CL_DEVICE_AFFINITY_DOMAIN_NUMA
        /// CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE
        /// CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE
        /// CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE
        /// CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE
        /// CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE
        /// 
        /// If the device does not support any affinity domains, a value of 0 will be returned.
        /// </summary>
        PartitionAffinityDomain = 0x1045,
        /// <summary>
        /// Returns the properties argument specified in clCreateSubDevices if device is a sub-device. In the case where the properties argument to clCreateSubDevices is CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN, CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE, the affinity domain used to perform the partition will be returned. This can be one of the following values:
        /// 
        /// CL_DEVICE_AFFINITY_DOMAIN_NUMA
        /// CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE
        /// CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE
        /// CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE
        /// CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE
        /// 
        /// Otherwise the implementation may either return a param_value_size_ret of 0 i.e. there is no partition type associated with device or can return a property value of 0 (where 0 is used to terminate the partition property list) in the memory that param_value points to.
        /// </summary>
        PartitionType = 0x1046,
        /// <summary>
        /// Returns the device reference count. If the device is a root-level device, a reference count of one is returned.
        /// </summary>
        ReferenceCount = 0x1047,

        // OpenCL 2.0
        /// <summary>
        /// Max number of image objects arguments of a kernel declared with the write_only or read_write qualifier.
        /// 
        /// Support for read-write image arguments is required for an OpenCL 2.0, 2.1, or 2.2 device if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// 
        /// The minimum value is 64 if the device supports read-write images arguments, and must be 0 for devices that do not support read-write images.
        /// </summary>
        MaxReadWriteImageArguments = 0x104C,
        /// <summary>
        /// The row pitch alignment size in pixels for 2D images created from a buffer. The value returned must be a power of 2.
        /// 
        /// Support for 2D images created from a buffer is required for an OpenCL 2.0, 2.1, or 2.2 device if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// 
        /// This value must be 0 for devices that do not support 2D images created from a buffer.
        /// </summary>
        ImagePitchAlignment = 0x104A,
        /// <summary>
        /// This query specifies the minimum alignment in pixels of the host_ptr specified to clCreateBuffer or clCreateBufferWithProperties when a 2D image is created from a buffer which was created using CL_MEM_USE_HOST_PTR. The value returned must be a power of 2.
        /// 
        /// Support for 2D images created from a buffer is required for an OpenCL 2.0, 2.1, or 2.2 device if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// 
        /// This value must be 0 for devices that do not support 2D images created from a buffer.
        /// </summary>
        ImageBaseAddressAlignment = 0x104B,
        /// <summary>
        /// The maximum number of pipe objects that can be passed as arguments to a kernel. The minimum value is 16 for devices supporting pipes, and must be 0 for devices that do not support pipes.
        /// </summary>
        MaxPipeArguments = 0x1055,
        /// <summary>
        /// The maximum number of reservations that can be active for a pipe per work-item in a kernel. A work-group reservation is counted as one reservation per work-item. The minimum value is 1 for devices supporting pipes, and must be 0 for devices that do not support pipes.
        /// </summary>
        PipeMaxActiveReservations = 0x1056,
        /// <summary>
        /// The maximum size of pipe packet in bytes.
        /// 
        /// Support for pipes is required for an OpenCL 2.0, 2.1, or 2.2 device. The minimum value is 1024 bytes if the device supports pipes, and must be 0 for devices that do not support pipes.
        /// </summary>
        PipeMaxPacketSize = 0x1057,
        /// <summary>
        /// The maximum number of bytes of storage that may be allocated for any single variable in program scope or inside a function in an OpenCL kernel language declared in the global address space.
        /// 
        /// Support for program scope global variables is required for an OpenCL 2.0, 2.1, or 2.2 device. The minimum value is 64 KB if the device supports program scope global variables, and must be 0 for devices that do not support program scope global variables.
        /// </summary>
        MaxGlobalVariableSize = 0x104D,
        /// <summary>
        /// Maximum preferred total size, in bytes, of all program variables in the global address space. This is a performance hint. An implementation may place such variables in storage with optimized device access. This query returns the capacity of such storage. The minimum value is 0.
        /// </summary>
        GlobalVariablePreferredTotalSize = 0x1054,
        /// <summary>
        /// Describes the on host command-queue properties supported by the device. This is a bit-field that describes one or more of the following values:
        /// 
        /// CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE
        /// CL_QUEUE_PROFILING_ENABLE
        /// 
        /// These properties are described in the Queue Properties table.
        /// 
        /// The mandated minimum capability is: CL_QUEUE_PROFILING_ENABLE.
        /// </summary>
        QueueOnHostPorperties = 0x102A,
        /// <summary>
        /// Describes the on device command-queue properties supported by the device. This is a bit-field that describes one or more of the following values:
        /// 
        /// CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE
        /// CL_QUEUE_PROFILING_ENABLE
        /// 
        /// These properties are described in the Queue Properties table.
        /// 
        /// Support for on-device queues is required for an OpenCL 2.0, 2.1, or 2.2 device. When on-device queues are supported, the mandated minimum capability is:
        /// 
        /// CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE | CL_QUEUE_PROFILING_ENABLE
        /// 
        /// Must be 0 for devices that do not support on-device queues.
        /// </summary>
        QueueOnDeviceProperties = 0x104E,
        /// <summary>
        /// The preferred size of the device queue, in bytes. Applications should use this size for the device queue to ensure good performance.
        /// 
        /// The minimum value is 16 KB for devices supporting on-device queues, and must be 0 for devices that do not support on-device queues.
        /// </summary>
        QueueOnDevicePreferredSize = 0x104F,
        /// <summary>
        /// The maximum size of the device queue in bytes.
        /// 
        /// The minimum value is 256 KB for the full profile and 64 KB for the embedded profile for devices supporting on-device queues, and must be 0 for devices that do not support on-device queues.
        /// </summary>
        QueueOnDeviceMaxSize = 0x1050,
        /// <summary>
        /// The maximum number of device queues that can be created for this device in a single context.
        /// 
        /// The minimum value is 1 for devices supporting on-device queues, and must be 0 for devices that do not support on-device queues.
        /// </summary>
        MaxOnDeviceQueues = 0x1051,
        /// <summary>
        /// The maximum number of events in use by a device queue. These refer to events returned by the enqueue_ built-in functions to a device queue or user events returned by the create_user_event built-in function that have not been released.
        /// 
        /// The minimum value is 1024 for devices supporting on-device queues, and must be 0 for devices that do not support on-device queues.
        /// </summary>
        MaxOnDeviceEvents = 0x1052,
        /// <summary>
        /// Describes the various shared virtual memory (SVM) memory allocation types the device supports. This is a bit-field that describes a combination of the following values:
        /// 
        /// CL_DEVICE_SVM_COARSE_GRAIN_BUFFER - Support for coarse-grain buffer sharing using clSVMAlloc. Memory consistency is guaranteed at synchronization points and the host must use calls to clEnqueueMapBuffer and clEnqueueUnmapMemObject.
        /// CL_DEVICE_SVM_FINE_GRAIN_BUFFER - Support for fine-grain buffer sharing using clSVMAlloc. Memory consistency is guaranteed at synchronization points without need for clEnqueueMapBuffer and clEnqueueUnmapMemObject.
        /// CL_DEVICE_SVM_FINE_GRAIN_SYSTEM - Support for sharing the host’s entire virtual memory including memory allocated using malloc. Memory consistency is guaranteed at synchronization points.
        /// CL_DEVICE_SVM_ATOMICS - Support for the OpenCL 2.0 atomic operations that provide memory consistency across the host and all OpenCL devices supporting fine-grain SVM allocations.
        /// 
        /// The mandated minimum capability for an OpenCL 2.0, 2.1, or 2.2 device is CL_DEVICE_SVM_COARSE_GRAIN_BUFFER.
        /// 
        /// For other device versions there is no mandated minimum capability.
        /// </summary>
        SVMCapabilities = 0x1053,
        /// <summary>
        /// Returns the value representing the preferred alignment in bytes for OpenCL 2.0 fine-grained SVM atomic types. This query can return 0 which indicates that the preferred alignment is aligned to the natural size of the type.
        /// </summary>
        PreferredPlatformAtomicAlignment = 0x1058,
        /// <summary>
        /// Returns the value representing the preferred alignment in bytes for OpenCL 2.0 atomic types to global memory. This query can return 0 which indicates that the preferred alignment is aligned to the natural size of the type.
        /// </summary>
        PreferredGlobalAtomicAlignment = 0x1059,
        /// <summary>
        /// Returns the value representing the preferred alignment in bytes for OpenCL 2.0 atomic types to local memory. This query can return 0 which indicates that the preferred alignment is aligned to the natural size of the type.
        /// </summary>
        PreferredLocalAtomicAlignment = 0x105A,

        // OpenCL 2.1
        /// <summary>
        /// The intermediate languages that can be supported by clCreateProgramWithIL for this device. Returns a space-separated list of IL version strings of the form
        /// 
        /// &lt;IL_Prefix&gt;_&lt;Major_Version&gt;.&lt;Minor_Version&gt;
        /// 
        /// For an OpenCL 2.1 or 2.2 device, SPIR-V is a required IL prefix.
        /// 
        /// If the device does not support intermediate language programs, the value must be "" (an empty string).
        /// </summary>
        ILVersion = 0x105B,
        /// <summary>
        /// Maximum number of sub-groups in a work-group that a device is capable of executing on a single compute unit, for any given kernel-instance running on the device.
        /// 
        /// The minimum value is 1 if the device supports sub-groups, and must be 0 for devices that do not support sub-groups. Support for sub-groups is required for an OpenCL 2.1 or 2.2 device.
        /// 
        /// (Refer also to clGetKernelSubGroupInfo.)
        /// </summary>
        MaxNumberSubGroups = 0x105C,
        /// <summary>
        /// Is CL_TRUE if this device supports independent forward progress of sub-groups, CL_FALSE otherwise.
        /// 
        /// This query must return CL_TRUE for devices that support the cl_khr_subgroups extension, and must return CL_FALSE for devices that do not support sub-groups.
        /// </summary>
        SubGroupIndependentForwardProgress = 0x105D,

        // OpenCL 3.0
        /// <summary>
        /// Returns an array of descriptions (name and version) for all supported intermediate languages. Intermediate languages with the same name may be reported more than once but each name and major/minor version combination may only be reported once. The list of intermediate languages reported must match the list reported via CL_DEVICE_IL_VERSION.
        /// 
        /// For an OpenCL 2.1 or 2.2 device, at least one version of SPIR-V must be reported.
        /// </summary>
        ILSWithVersion = 0x1061,
        /// <summary>
        /// Returns an array of descriptions for the built-in kernels supported by the device. Each built-in kernel may only be reported once. The list of reported kernels must match the list returned via CL_DEVICE_BUILT_IN_KERNELS.
        /// </summary>
        BuiltInKernelsWithVersion = 0x1062,
        /// <summary>
        /// Returns the detailed (major, minor, patch) version supported by the device. The major and minor version numbers returned must match those returned via CL_DEVICE_VERSION.
        /// </summary>
        NumericVersion = 0x105E,
        /// <summary>
        /// Returns an array of name, version descriptions listing all the versions of OpenCL C supported by the compiler for the device. In each returned description structure, the name field is required to be "OpenCL C". The list may include both newer non-backwards compatible OpenCL C versions, such as OpenCL C 3.0, and older OpenCL C versions with mandatory backwards compatibility. The version returned by CL_DEVICE_OPENCL_C_VERSION is required to be present in the list.
        /// 
        /// For devices that support compilation from OpenCL C source:
        /// 
        /// Because OpenCL 3.0 is backwards compatible with OpenCL C 1.2, and OpenCL C 1.2 is backwards compatible with OpenCL C 1.1 and OpenCL C 1.0, support for at least OpenCL C 3.0, OpenCL C 1.2, OpenCL C 1.1, and OpenCL C 1.0 is required for an OpenCL 3.0 device.
        /// 
        /// Support for OpenCL C 2.0, OpenCL C 1.2, OpenCL C 1.1, and OpenCL C 1.0 is required for an OpenCL 2.0, OpenCL 2.1, or OpenCL 2.2 device.
        /// 
        /// Support for OpenCL C 1.2, OpenCL C 1.1, and OpenCL C 1.0 is required for an OpenCL 1.2 device.
        /// 
        /// Support for OpenCL C 1.1 and OpenCL C 1.0 is required for an OpenCL 1.1 device.
        /// 
        /// Support for at least OpenCL C 1.0 is required for an OpenCL 1.0 device.
        /// 
        /// For devices that do not support compilation from OpenCL C source, this query may return an empty array.
        /// </summary>
        OpenCL_C_AllVersions = 0x1066,
        /// <summary>
        /// Returns an array of optional OpenCL C features supported by the compiler for the device alongside the OpenCL C version that introduced the feature macro. For example, if a compiler supports an OpenCL C 3.0 feature, the returned name will be the full name of the OpenCL C feature macro, and the returned version will be 3.0.0.
        /// 
        /// For devices that do not support compilation from OpenCL C source, this query may return an empty array.
        /// </summary>
        OpenCL_C_Features = 0x106F,
        /// <summary>
        /// Returns an array of description (name and version) structures. The same extension name must not be reported more than once. The list of extensions reported must match the list reported via CL_DEVICE_EXTENSIONS.
        /// 
        /// See CL_DEVICE_EXTENSIONS for a list of extensions that are required to be reported for a given OpenCL version.
        /// </summary>
        ExtensionsWithVersion = 0x1060,
        /// <summary>
        /// Describes the various memory orders and scopes that the device supports for atomic memory operations. This is a bit-field that describes a combination of the following values:
        /// 
        /// CL_DEVICE_ATOMIC_ORDER_RELAXED - Support for the relaxed memory order.
        /// CL_DEVICE_ATOMIC_ORDER_ACQ_REL - Support for the acquire, release, and acquire-release memory orders.
        /// CL_DEVICE_ATOMIC_ORDER_SEQ_CST - Support for the sequentially consistent memory order.
        /// 
        /// Because atomic memory orders are hierarchical, a device that supports a strong memory order must also support all weaker memory orders.
        /// 
        /// CL_DEVICE_ATOMIC_SCOPE_WORK_ITEM [5] - Support for memory ordering constraints that apply to a single work-item.
        /// CL_DEVICE_ATOMIC_SCOPE_WORK_GROUP - Support for memory ordering constraints that apply to all work-items in a work-group.
        /// CL_DEVICE_ATOMIC_SCOPE_DEVICE - Support for memory ordering constraints that apply to all work-items executing on the device.
        /// CL_DEVICE_ATOMIC_SCOPE_ALL_DEVICES - Support for memory ordering constraints that apply to all work-items executing across all devices that can share SVM memory with each other and the host process.
        /// 
        /// Because atomic scopes are hierarchical, a device that supports a wide scope must also support all narrower scopes, except for the work-item scope, which is a special case.
        /// 
        /// The mandated minimum capability is:
        /// 
        /// CL_DEVICE_ATOMIC_ORDER_RELAXED | CL_DEVICE_ATOMIC_SCOPE_WORK_GROUP
        /// </summary>
        AtomicMemoryCapabilities = 0x1063,
        /// <summary>
        /// Describes the various memory orders and scopes that the device supports for atomic fence operations. This is a bit-field that has the same set of possible values as described for CL_DEVICE_ATOMIC_MEMORY_CAPABILITIES.
        /// 
        /// The mandated minimum capability is:
        /// 
        /// CL_DEVICE_ATOMIC_ORDER_RELAXED | CL_DEVICE_ATOMIC_ORDER_ACQ_REL | CL_DEVICE_ATOMIC_SCOPE_WORK_GROUP
        /// </summary>
        AtomicFenceCapabilities = 0x1064,
        /// <summary>
        /// Is CL_TRUE if the device supports non-uniform work-groups, and CL_FALSE otherwise.
        /// </summary>
        NonUniformWorkGroupSupport = 0x1065,
        /// <summary>
        /// Is CL_TRUE if the device supports work-group collective functions e.g. work_group_broadcast, work_group_reduce, and work_group_scan, and CL_FALSE otherwise.
        /// </summary>
        WorkGroupCollectiveFunctionsSupport = 0x1068,
        /// <summary>
        /// Is CL_TRUE if the device supports the generic address space and its associated built-in functions, and CL_FALSE otherwise.
        /// </summary>
        GenericAddressSpaceSupport = 0x1069,
        /// <summary>
        /// Describes device-side enqueue capabilities of the device. This is a bit-field that describes one or more of the following values:
        /// 
        /// CL_DEVICE_QUEUE_SUPPORTED - Device supports device-side enqueue and on-device queues.
        /// CL_DEVICE_QUEUE_REPLACEABLE_DEFAULT - Device supports a replaceable default on-device queue.
        /// 
        /// If CL_DEVICE_QUEUE_REPLACEABLE_DEFAULT is set, CL_DEVICE_QUEUE_SUPPORTED must also be set.
        /// 
        /// Devices that set CL_DEVICE_QUEUE_SUPPORTED for CL_DEVICE_DEVICE_ENQUEUE_CAPABILITIES must also return CL_TRUE for CL_DEVICE_GENERIC_ADDRESS_SPACE_SUPPORT.
        /// </summary>
        DeviceEnqueueCapabilities = 0x1070,
        /// <summary>
        /// Is CL_TRUE if the device supports pipes, and CL_FALSE otherwise.
        /// 
        /// Devices that return CL_TRUE for CL_DEVICE_PIPE_SUPPORT must also return CL_TRUE for CL_DEVICE_GENERIC_ADDRESS_SPACE_SUPPORT.
        /// </summary>
        PipeSupport = 0x1071,
        /// <summary>
        /// Returns the preferred multiple of work-group size for the given device. This is a performance hint intended as a guide when specifying the local work size argument to clEnqueueNDRangeKernel.
        /// 
        /// (Refer also to clGetKernelWorkGroupInfo where CL_KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE can return a different value to CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_MULTIPLE which may be more optimal.)
        /// </summary>
        PreferredWorkGroupSizeMultiple = 0x1067,
        /// <summary>
        /// Returns the latest version of the conformance test suite that this device has fully passed in accordance with the official conformance process.
        /// </summary>
        LatestConformanceVersionPassed = 0x1072,
    }

    /// <summary>
    /// cl_device_fp_config - bitfield
    /// </summary>
    [Flags]
    public enum ComputeDeviceSingleCapabilities : long
    {
        /// <summary>
        /// denorms are supported
        /// </summary>
        Denorm = 1 << 0,
        /// <summary>
        /// INF and quiet NaNs are supported
        /// </summary>
        InfNan = 1 << 1,
        /// <summary>
        /// round to nearest even rounding mode supported
        /// </summary>
        RoundToNearest = 1 << 2,
        /// <summary>
        /// round to zero rounding mode supported
        /// </summary>
        RountToZero = 1 << 3,
        /// <summary>
        /// round to positive and negative infinity rounding modes supported
        /// </summary>
        RoundToInf = 1 << 4,
        /// <summary>
        /// IEEE754-2008 fused multiply-add is supported
        /// </summary>
        FMA = 1 << 5,

        //OpenCL 1.1
        /// <summary>
        /// Basic floating-point operations (such as addition, subtraction, multiplication) are implemented in software
        /// </summary>
        SoftFloat = 1 << 6,

        //OpenCL 1.2
        /// <summary>
        /// divide and sqrt are correctly rounded as defined by the IEEE754 specification
        /// </summary>
        CorrectlyRoundedDivideSqrt = 1 << 7
    }

    /// <summary>
    /// cl_device_mem_cache_type
    /// </summary>
    public enum ComputeDeviceMemoryCacheType : int
    {
        /// <summary> </summary>
        None = 0x0,
        /// <summary> </summary>
        ReadOnlyCache = 0x1,
        /// <summary> </summary>
        ReadWriteCache = 0x2,
    }

    /// <summary>
    /// cl_device_local_mem_type
    /// </summary>
    public enum ComputeDeviceLocalMemoryType : int
    {
        /// <summary> </summary>
        Local = 0x1,
        /// <summary> </summary>
        Global = 0x2
    }

    /// <summary>
    /// cl_device_exec_capabilities - bitfield
    /// </summary>
    [Flags]
    public enum ComputeDeviceExecutionCapabilities : long
    {
        /// <summary>
        /// The OpenCL device can execute OpenCL kernels.
        /// </summary>
        Kernel = 1 << 0,
        /// <summary>
        /// The OpenCL device can execute native kernels.
        /// </summary>
        NativeKernel = 1 << 1
    }

    /// <summary>
    /// cl_command_queue_properties - bitfield
    /// </summary>
    [Flags]
    public enum ComputeCommandQueueFlags : long
    {
        /// <summary> </summary>
        None = 0,
        /// <summary>
        /// Determines whether the commands queued in the command-queue are executed in-order or out-of-order. If set, the commands in the command-queue are executed out-of-order. Otherwise, commands are executed in-order.
        /// </summary>
        OutOfOrderExecutionModeEnable = 1 << 0,
        /// <summary>
        /// Enable or disable profiling of commands in the command-queue. If set, the profiling of commands is enabled. Otherwise profiling of commands is disabled.
        /// </summary>
        ProfilingEnable = 1 << 1,

        // OpenCL 2.0
        /// <summary>
        /// Indicates that this is a device queue. If CL_QUEUE_ON_DEVICE is set, CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE [1] must also be set. missing before version 2.0.
        /// </summary>
        QueueOnDevice = 1 << 2,
        /// <summary>
        /// indicates that this is the default device queue. This can only be used with CL_QUEUE_ON_DEVICE. missing before version 2.0.
        /// </summary>
        QueueOnDeviceDefault = 1 << 3
    }

    /// <summary>
    /// The context info query symbols.
    /// cl_context_info
    /// </summary>
    public enum ComputeContextInfo : int
    {
        /// <summary>
        /// Return the context reference count.
        /// </summary>
        ReferenceCount = 0x1080,
        /// <summary>
        /// Return the list of devices and sub-devices in context.
        /// </summary>
        Devices = 0x1081,
        /// <summary>
        /// Return the properties argument specified in clCreateContext or clCreateContextFromType.
        /// 
        /// If the properties argument specified in clCreateContext or clCreateContextFromType used to create context was not NULL, the implementation must return the values specified in the properties argument in the same order and without including additional properties.
        /// 
        /// If the properties argument specified in clCreateContext or clCreateContextFromType used to create context was NULL, the implementation must return param_value_size_ret equal to 0, indicating that there are no properties to be returned.
        /// </summary>
        Properties = 0x1082,

        // OpenCL 1.1
        /// <summary>
        /// Return the number of devices in context.
        /// </summary>
        NumberOfDevices = 0x1083,
    }

    /// <summary>
    /// cl_context_properties
    /// </summary>
    public enum ComputeContextPropertyName
    {
        /// <summary>
        /// Specifies the platform to use.
        /// </summary>
        Platform = 0x1084,

        // OpenCL 1.2
        /// <summary>
        /// Specifies whether the user is responsible for synchronization between OpenCL and other APIs. Please refer to the specific sections in the OpenCL Extension Specification that describe sharing with other APIs for restrictions on using this flag.
        /// 
        /// If CL_CONTEXT_INTEROP_USER_SYNC is not specified, a default of CL_FALSE is assumed.
        /// </summary>
        InteropUserSync = 0x1085,
    }

    /// <summary>
    /// cl_device_partition_property
    /// OpenCL 1.2
    /// </summary>
    public enum ComputeDevicePartitionProperty
    {
        /// <summary>
        /// Split the aggregate device into as many smaller aggregate devices as can be created, each containing n compute units. The value n is passed as the value accompanying this property. If n does not divide evenly into CL_DEVICE_MAX_COMPUTE_UNITS, then the remaining compute units are not used.
        /// </summary>
        Equally = 0x1086,
        /// <summary>
        /// This property is followed by a list of compute unit counts terminated with 0 or CL_DEVICE_PARTITION_BY_COUNTS_LIST_END. For each non-zero count m in the list, a sub-device is created with m compute units in it.
        /// 
        /// The number of non-zero count entries in the list may not exceed CL_DEVICE_PARTITION_MAX_SUB_DEVICES.
        /// 
        /// The total number of compute units specified may not exceed CL_DEVICE_MAX_COMPUTE_UNITS.
        /// </summary>
        ByCounts = 0x1087,
        /// <summary>End of list marker</summary>
        ByCountsListEnd = 0x0,
        /// <summary>
        /// Split the device into smaller aggregate devices containing one or more compute units that all share part of a cache hierarchy. The value accompanying this property may be drawn from the following list:
        /// 
        /// CL_DEVICE_AFFINITY_DOMAIN_NUMA - Split the device into sub-devices comprised of compute units that share a NUMA node.
        /// CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE - Split the device into sub-devices comprised of compute units that share a level 4 data cache.
        /// CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE - Split the device into sub-devices comprised of compute units that share a level 3 data cache.
        /// CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE - Split the device into sub-devices comprised of compute units that share a level 2 data cache.
        /// CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE - Split the device into sub-devices comprised of compute units that share a level 1 data cache.
        /// CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE - Split the device along the next partitionable affinity domain. The implementation shall find the first level along which the device or sub-device may be further subdivided in the order NUMA, L4, L3, L2, L1, and partition the device into sub-devices comprised of compute units that share memory subsystems at this level.
        /// 
        /// The user may determine what happened by calling clGetDeviceInfo(CL_DEVICE_PARTITION_TYPE) on the sub-devices.
        /// </summary>
        ByAffinityDomain = 0x1088,
    }

    /// <summary>
    /// cl_device_affinity_domain
    /// OpenCL 1.2
    /// </summary>
    [Flags]
    public enum ComputeDeviceAffinityDomain : long
    {
        /// <summary> </summary>
        AffinityDomainNUMA = 1 << 0,
        /// <summary> </summary>
        AffinityDomainL4Cache = 1 << 1,
        /// <summary> </summary>
        AffinityDomainL3Cache = 1 << 2,
        /// <summary> </summary>
        AffinityDomainL2Cache = 1 << 3,
        /// <summary> </summary>
        AffinityDomainL1Cache = 1 << 4,
        /// <summary> </summary>
        NextPartitionable = 1 << 5,
    }

    /// <summary>
    /// cl_device_svm_capabilities
    /// OpenCL 2.0
    /// </summary>
    [Flags]
    public enum ComputeDeviceSVMCapabilities : long
    {
        /// <summary>
        /// Support for coarse-grain buffer sharing using clSVMAlloc. Memory consistency is guaranteed at synchronization points and the host must use calls to clEnqueueMapBuffer and clEnqueueUnmapMemObject.
        /// </summary>
        CoarseGrainBuffer = 1 << 0,
        /// <summary>
        /// Support for fine-grain buffer sharing using clSVMAlloc. Memory consistency is guaranteed at synchronization points without need for clEnqueueMapBuffer and clEnqueueUnmapMemObject.
        /// </summary>
        FineGrainBuffer = 1 << 1,
        /// <summary>
        /// Support for sharing the host’s entire virtual memory including memory allocated using malloc. Memory consistency is guaranteed at synchronization points.
        /// </summary>
        FineGrainSystem = 1 << 2,
        /// <summary>
        /// Support for the OpenCL 2.0 atomic operations that provide memory consistency across the host and all OpenCL devices supporting fine-grain SVM allocations.
        /// </summary>
        Atomics = 1 << 3,
    }

    /// <summary>
    /// The command queue info query symbols.
    /// cl_command_queue_info
    /// </summary>
    public enum ComputeCommandQueueInfo : int
    {
        /// <summary>
        /// Return the context specified when the command-queue is created.
        /// </summary>
        Context = 0x1090,
        /// <summary>
        /// Return the device specified when the command-queue is created.
        /// </summary>
        Device = 0x1091,
        /// <summary>
        /// Return the command-queue reference count.
        /// </summary>
        ReferenceCount = 0x1092,
        /// <summary>
        /// Return the currently specified properties for the command-queue. These properties are specified by the value associated with the CL_QUEUE_PROPERTIES passed in properties argument in clCreateCommandQueueWithProperties, or the value of the properties argument in clCreateCommandQueue.
        /// </summary>
        Properties = 0x1093,

        // OpenCL 2.0
        /// <summary>
        /// Return the size of the device command-queue. To be considered valid for this query, command_queue must be a device command-queue.
        /// </summary>
        Size = 0x1094,

        // OpenCL 2.1
        /// <summary>
        /// Return the current default command-queue for the underlying device.
        /// </summary>
        DeviceDefault = 0x1095,

        // OpenCL 3.0
        /// <summary>
        /// Return the properties argument specified in clCreateCommandQueueWithProperties.
        /// 
        /// If the properties argument specified in clCreateCommandQueueWithProperties used to create command_queue was not NULL, the implementation must return the values specified in the properties argument in the same order and without including additional properties.
        /// 
        /// If command_queue was created using clCreateCommandQueue, or if the properties argument specified in clCreateCommandQueueWithProperties} was NULL, the implementation must return param_value_size_ret equal to 0, indicating that there are no properties to be returned.
        /// </summary>
        PropertiesArray = 0x1098,
    }

    /// <summary>
    /// cl_mem_flags and cl_svm_mem_flags - bitfield
    /// </summary>
    [Flags]
    public enum ComputeMemoryFlags : long
    {
        /// <summary> Let the OpenCL choose the default flags. </summary>
        None = 0,
        /// <summary>
        /// This flag specifies that the memory object will be read and written by a kernel. This is the default.
        /// </summary>
        ReadWrite = 1 << 0,
        /// <summary>
        /// This flag specifies that the memory object will be written but not read by a kernel.
        /// 
        /// Reading from a buffer or image object created with CL_MEM_WRITE_ONLY inside a kernel is undefined.
        /// 
        /// CL_MEM_READ_WRITE and CL_MEM_WRITE_ONLY are mutually exclusive.
        /// </summary>
        WriteOnly = 1 << 1,
        /// <summary>
        /// This flag specifies that the memory object is a readonly memory object when used inside a kernel.
        /// 
        /// Writing to a buffer or image object created with CL_MEM_READ_ONLY inside a kernel is undefined.
        /// 
        /// CL_MEM_READ_WRITE or CL_MEM_WRITE_ONLY and CL_MEM_READ_ONLY are mutually exclusive.
        /// </summary>
        ReadOnly = 1 << 2,
        /// <summary>
        /// This flag is valid only if host_ptr is not NULL. If specified, it indicates that the application wants the OpenCL implementation to use memory referenced by host_ptr as the storage bits for the memory object.
        /// 
        /// The contents of the memory pointed to by host_ptr at the time of the clCreateBuffer, clCreateBufferWithProperties, clCreateImage, clCreateImageWithProperties, clCreateImage2D, or clCreateImage3D call define the initial contents of the memory object.
        /// 
        /// OpenCL implementations are allowed to cache the contents pointed to by host_ptr in device memory. This cached copy can be used when kernels are executed on a device.
        /// 
        /// The result of OpenCL commands that operate on multiple buffer objects created with the same host_ptr or from overlapping host or SVM regions is considered to be undefined.
        /// </summary>
        UseHostPtr = 1 << 3,
        /// <summary>
        /// This flag specifies that the application wants the OpenCL implementation to allocate memory from host accessible memory.
        /// 
        /// CL_MEM_ALLOC_HOST_PTR and CL_MEM_USE_HOST_PTR are mutually exclusive.
        /// </summary>
        AllocateHostPtr = 1 << 4,
        /// <summary>
        /// This flag is valid only if host_ptr is not NULL. If specified, it indicates that the application wants the OpenCL implementation to allocate memory for the memory object and copy the data from memory referenced by host_ptr. The implementation will copy the memory immediately and host_ptr is available for reuse by the application when the clCreateBuffer, clCreateBufferWithProperties, clCreateImage, clCreateImageWithProperties, clCreateImage2D, or clCreateImage3D operation returns.
        /// 
        /// CL_MEM_COPY_HOST_PTR and CL_MEM_USE_HOST_PTR are mutually exclusive.
        /// 
        /// CL_MEM_COPY_HOST_PTR can be used with CL_MEM_ALLOC_HOST_PTR to initialize the contents of the cl_mem object allocated using host-accessible (e.g. PCIe) memory.
        /// </summary>
        CopyHostPtr = 1 << 5,

        // OpenCL 1.2
        /// <summary>
        /// This flag specifies that the host will only write to the memory object (using OpenCL APIs that enqueue a write or a map for write). This can be used to optimize write access from the host (e.g. enable write-combined allocations for memory objects for devices that communicate with the host over a system bus such as PCIe).
        /// </summary>
        HostWriteOnly = 1 << 7,
        /// <summary>
        /// This flag specifies that the host will only read the memory object (using OpenCL APIs that enqueue a read or a map for read).
        /// 
        /// CL_MEM_HOST_WRITE_ONLY and CL_MEM_HOST_READ_ONLY are mutually exclusive.
        /// </summary>
        HostReadOnly = 1 << 8,
        /// <summary>
        /// This flag specifies that the host will not read or write the memory object.
        /// 
        /// CL_MEM_HOST_WRITE_ONLY or CL_MEM_HOST_READ_ONLY and CL_MEM_HOST_NO_ACCESS are mutually exclusive.
        /// </summary>
        HostNoAccess = 1 << 9,

        // OpenCL 2.0
        /// <summary>
        /// This flag is only used by clGetSupportedImageFormats to query image formats that may be both read from and written to by the same kernel instance. To create a memory object that may be read from and written to use CL_MEM_READ_WRITE.
        /// </summary>
        KernelReadWrite = 1 << 12,
    }

    /// <summary>
    /// cl_mem_migration_flags - bitfield
    /// OpenCL 1.2
    /// </summary>
    [Flags]
    public enum ComputeMemoryMigrationFlags : long
    {
        // OpenCL 1.2
        /// <summary>
        /// This flag indicates that the specified set of memory objects are to be migrated to the host, regardless of the target command-queue.
        /// </summary>
        MemoryObjectHost = 1 << 0,
        /// <summary>
        /// This flag indicates that the contents of the set of memory objects are undefined after migration. The specified set of memory objects are migrated to the device associated with command_queue without incurring the overhead of migrating their contents.
        /// </summary>
        MemoryObjectContentUndefined = 1 << 1,
    }

    /// <summary>
    /// cl_channel_order
    /// </summary>
    public enum ComputeImageChannelOrder : int
    {
        /// <summary>
        /// Single channel image formats where the single channel represents a RED component.
        /// </summary>
        R = 0x10B0,
        /// <summary>
        /// Single channel image formats where the single channel represents a ALPHA component.
        /// </summary>
        A = 0x10B1,
        /// <summary>
        /// Two channel image formats. The first channel always represents a RED component. The second channel represents a GREEN component component.
        /// </summary>
        RG = 0x10B2,
        /// <summary>
        /// Two channel image formats. The first channel always represents a RED component. The second channel represents an ALPHA component.
        /// </summary>
        RA = 0x10B3,
        /// <summary>
        /// A three channel image format, where the three channels represent RED, GREEN, and BLUE components.
        /// </summary>
        RGB = 0x10B4,
        /// <summary>
        /// Four channel image formats, where the four channels represent RED, GREEN, BLUE, and ALPHA components.
        /// </summary>
        RGBA = 0x10B5,
        /// <summary>
        /// Four channel image formats, where the four channels represent RED, GREEN, BLUE, and ALPHA components.
        /// </summary>
        BGRA = 0x10B6,
        /// <summary>
        /// Four channel image formats, where the four channels represent RED, GREEN, BLUE, and ALPHA components.
        /// </summary>
        ARGB = 0x10B7,
        /// <summary>
        /// A single channel image format where the single channel represents an INTENSITY value. The INTENSITY value is replicated into the RED, GREEN, BLUE, and ALPHA components.
        /// </summary>
        Intensity = 0x10B8,
        /// <summary>
        /// A single channel image format where the single channel represents a LUMINANCE value. The LUMINANCE value is replicated into the RED, GREEN, and BLUE components.
        /// </summary>
        Luminance = 0x10B9,

        // OpenCL 1.1
        /// <summary>
        /// A two channel image format, where the first channel represents a RED component and the second channel is ignored.
        /// </summary>
        Rx = 0x10BA,
        /// <summary>
        /// A three channel image format, where the first two channels represent RED and GREEN components and the third channel is ignored.
        /// </summary>
        RGx = 0x10BB,
        /// <summary>
        /// A four channel image format, where the first three channels represent RED, GREEN, and BLUE components and the fourth channel is ignored.
        /// </summary>
        RGBx = 0x10BC,

        // OpenCL 2.0
        /// <summary>
        /// A single channel image format where the single channel represents a DEPTH component.
        /// </summary>
        Depth = 0x10BD,
        /// <summary>
        /// A three channel image format, where the three channels represent RED, GREEN, and BLUE components in the sRGB color space.
        /// </summary>
        sRGB = 0x10BF,
        /// <summary>
        /// A four channel image format, where the three channels represent RED, GREEN, and BLUE components in the sRGB color space. The fourth channel is ignored.
        /// </summary>
        sRGBx = 0x10C0,
        /// <summary>
        /// Four channel image formats, where the first three channels represent RED, GREEN, and BLUE components in the sRGB color space. The fourth channel represents an ALPHA component.
        /// </summary>
        sRGBA = 0x10C1,
        /// <summary>
        /// Four channel image formats, where the first three channels represent RED, GREEN, and BLUE components in the sRGB color space. The fourth channel represents an ALPHA component.
        /// </summary>
        sBGRA = 0x10C2,
        /// <summary>
        /// Four channel image formats, where the four channels represent RED, GREEN, BLUE, and ALPHA components.
        /// </summary>
        ABGR = 0x10C3,
    }

    /// <summary>
    /// cl_channel_type
    /// </summary>
    public enum ComputeImageChannelType : int
    {
        /// <summary>
        /// Each channel component is a normalized signed 8-bit integer value
        /// </summary>
        SNormInt8 = 0x10D0,
        /// <summary>
        /// Each channel component is a normalized signed 16-bit integer value
        /// </summary>
        SNormInt16 = 0x10D1,
        /// <summary>
        /// Each channel component is a normalized unsigned 8-bit integer value
        /// </summary>
        UNormInt8 = 0x10D2,
        /// <summary>
        /// Each channel component is a normalized unsigned 16-bit integer value
        /// </summary>
        UNormInt16 = 0x10D3,
        /// <summary>
        /// Represents a normalized 5-6-5 3-channel RGB image. The channel order must be CL_RGB or CL_RGBx.
        /// </summary>
        UNormShort565 = 0x10D4,
        /// <summary>
        /// Represents a normalized x-5-5-5 4-channel xRGB image. The channel order must be CL_RGB or CL_RGBx.
        /// </summary>
        UNormShort555 = 0x10D5,
        /// <summary>
        /// Represents a normalized x-10-10-10 4-channel xRGB image. The channel order must be CL_RGB or CL_RGBx.
        /// </summary>
        UNormInt101010 = 0x10D6,
        /// <summary>
        /// Each channel component is an unnormalized signed 8-bit integer value
        /// </summary>
        SignedInt8 = 0x10D7,
        /// <summary>
        /// Each channel component is an unnormalized signed 16-bit integer value
        /// </summary>
        SignedInt16 = 0x10D8,
        /// <summary>
        /// Each channel component is an unnormalized signed 32-bit integer value
        /// </summary>
        SignedInt32 = 0x10D9,
        /// <summary>
        /// Each channel component is an unnormalized unsigned 8-bit integer value
        /// </summary>
        UnsignedInt8 = 0x10DA,
        /// <summary>
        /// Each channel component is an unnormalized unsigned 16-bit integer value
        /// </summary>
        UnsignedInt16 = 0x10DB,
        /// <summary>
        /// Each channel component is an unnormalized unsigned 32-bit integer value
        /// </summary>
        UnsignedInt32 = 0x10DC,
        /// <summary>
        /// Each channel component is a 16-bit half-float value
        /// </summary>
        HalfFloat = 0x10DD,
        /// <summary>
        /// Each channel component is a single precision floating-point value
        /// </summary>
        Float = 0x10DE,

        // OpenCL 2.1
        /// <summary>
        /// Represents a normalized 10-10-10-2 four-channel RGBA image. The channel order must be CL_RGBA.
        /// </summary>
        UNormInt101010_2 = 0x10E0,
    }

    /// <summary>
    /// cl_mem_object_type
    /// </summary>
    public enum ComputeMemoryType : int
    {
        /// <summary> </summary>
        Buffer = 0x10F0,
        /// <summary>
        /// ≥ image_row_pitch × image_height
        /// </summary>
        Image2D = 0x10F1,
        /// <summary>
        /// ≥ image_slice_pitch × image_depth
        /// </summary>
        Image3D = 0x10F2,

        // OpenCL 1.2
        /// <summary>
        /// ≥ image_slice_pitch × image_array_size
        /// </summary>
        Image2DArray = 0x10F3,
        /// <summary>
        /// ≥ image_row_pitch
        /// </summary>
        Image1D = 0x10F4,
        /// <summary>
        /// ≥ image_slice_pitch × image_array_size
        /// </summary>
        Image1DArray = 0x10F5,
        /// <summary>
        /// ≥ image_row_pitch
        /// </summary>
        Image1DBuffer = 0x10F6,

        // OpenCL 2.0
        /// <summary> </summary>
        Pipe = 0x10F7,
    }

    /// <summary>
    /// The memory info query symbols.
    /// cl_mem_info
    /// </summary>
    public enum ComputeMemoryInfo : int
    {
        /// <summary>
        /// Returns one of the following values:
        /// 
        /// CL_MEM_OBJECT_BUFFER if memobj is created with clCreateBuffer, clCreateBufferWithProperties, or clCreateSubBuffer.
        /// 
        /// CL_MEM_OBJECT_IMAGE2D if memobj is created with clCreateImage2D.
        /// 
        /// CL_MEM_OBJECT_IMAGE3D if memobj is created with clCreateImage3D.
        /// 
        /// The value of image_desc→image_type if memobj is created with clCreateImage or clCreateImageWithProperties.
        /// 
        /// CL_MEM_OBJECT_PIPE if memobj is created with clCreatePipe.
        /// </summary>
        Type = 0x1100,
        /// <summary>
        /// Return the flags argument value specified when memobj is created with clCreateBuffer,
        /// 
        /// clCreateBufferWithProperties
        /// clCreateSubBuffer
        /// clCreateImage
        /// clCreateImageWithProperties
        /// clCreateImage2D
        /// clCreateImage3D, or
        /// clCreatePipe
        /// 
        /// If memobj is a sub-buffer the memory access qualifiers inherited from parent buffer is also returned.
        /// </summary>
        Flags = 0x1101,
        /// <summary>
        /// Return actual size of the data store associated with memobj in bytes.
        /// </summary>
        Size = 0x1102,
        /// <summary>
        /// If memobj is created with clCreateBuffer, clCreateBufferWithProperties, clCreateImage, clCreateImageWithProperties, clCreateImage2D, or clCreateImage3D, and CL_MEM_USE_HOST_PTR is specified in mem_flags, return the host_ptr argument value specified when memobj is created.
        /// 
        /// Otherwise, if memobj is created with clCreateSubBuffer, and memobj is created from a buffer that was created with CL_MEM_USE_HOST_PTR specified in mem_flags, return the host_ptr passed to clCreateBuffer or clCreateBufferWithProperties, plus the origin value specified in buffer_create_info when memobj is created.
        /// 
        /// Otherwise, returns NULL.
        /// </summary>
        HostPtr = 0x1103,
        /// <summary>
        /// Map count.
        /// </summary>
        MapCount = 0x1104,
        /// <summary>
        /// Return memobj reference count.
        /// </summary>
        ReferenceCount = 0x1105,
        /// <summary>
        /// Return context specified when memory object is created. If memobj is created using clCreateSubBuffer, the context associated with the memory object specified as the buffer argument to clCreateSubBuffer is returned.
        /// </summary>
        Context = 0x1106,

        // OpenCL 1.1
        /// <summary>
        /// Return memory object from which memobj is created.
        /// 
        /// This returns the memory object specified as buffer argument to clCreateSubBuffer if memobj is a subbuffer object created using clCreateSubBuffer.
        /// 
        /// This returns image_desc→mem_object if memobj is an image object created using clCreateImage or clCreateImageWithProperties.
        /// 
        /// Otherwise, returns NULL.
        /// </summary>
        AssociatedMemoryObject = 0x1107,
        /// <summary>
        /// Return offset if memobj is a sub-buffer object created using clCreateSubBuffer.
        /// 
        /// This return 0 if memobj is not a subbuffer object.
        /// </summary>
        Offset = 0x1108,

        // OpenCL 2.0
        /// <summary>
        /// Return CL_TRUE if memobj is a buffer object that was created with CL_MEM_USE_HOST_PTR or is a sub-buffer object of a buffer object that was created with CL_MEM_USE_HOST_PTR and the host_ptr specified when the buffer object was created is a SVM pointer; otherwise returns CL_FALSE.
        /// </summary>
        UsesSVMPointer = 0x1109,

        // OpenCL 3.0
        /// <summary>
        /// Return the properties argument specified in clCreateBufferWithProperties or clCreateImageWithProperties.
        /// 
        /// If the properties argument specified in clCreateBufferWithProperties or clCreateImageWithProperties used to create memobj was not NULL, the implementation must return the values specified in the properties argument in the same order and without including additional properties.
        /// 
        /// If memobj was created using clCreateBuffer, clCreateSubBuffer, clCreateImage, clCreateImage2D, or clCreateImage3D, or if the properties argument specified in clCreateBufferWithProperties or clCreateImageWithProperties was NULL, the implementation must return param_value_size_ret equal to 0, indicating that there are no properties to be returned.
        /// </summary>
        Properties = 0x110A,
    }

    /// <summary>
    /// The memory info query symbols.
    /// cl_mem_info
    /// </summary>
    [Flags]
    public enum ComputeSVMMemoryFlags : long
    {
        /// <summary>
        /// This flag specifies that the SVM buffer will be read and written by a kernel. This is the default.
        /// </summary>
        ReadWrite = 1 << 0,
        /// <summary>
        /// This flag specifies that the SVM buffer will be written but not read by a kernel.
        /// 
        /// Reading from a SVM buffer created with CL_MEM_WRITE_ONLY inside a kernel is undefined.
        /// 
        /// CL_MEM_READ_WRITE and CL_MEM_WRITE_ONLY are mutually exclusive.
        /// </summary>
        WriteOnly = 1 << 1,
        /// <summary>
        /// This flag specifies that the SVM buffer object is a read-only memory object when used inside a kernel.
        /// 
        /// Writing to a SVM buffer created with CL_MEM_READ_ONLY inside a kernel is undefined.
        /// 
        /// CL_MEM_READ_WRITE or CL_MEM_WRITE_ONLY and CL_MEM_READ_ONLY are mutually exclusive.
        /// </summary>
        ReadOnly = 1 << 2,

        // OpenCL 2.0
        /// <summary>
        /// This specifies that the application wants the OpenCL implementation to do a fine-grained allocation.
        /// </summary>
        SVMFineGrainBuffer = 1 << 10,
        /// <summary>
        /// This flag is valid only if CL_MEM_SVM_FINE_GRAIN_BUFFER is specified in flags. It is used to indicate that SVM atomic operations can control visibility of memory accesses in this SVM buffer.
        /// </summary>
        SVMAtomics = 1 << 11,
    }

    /// <summary>
    /// The image info query symbols.
    /// cl_image_info
    /// </summary>
    public enum ComputeImageInfo : int
    {
        /// <summary>
        /// Return the image format descriptor specified when image is created with clCreateImage, clCreateImageWithProperties, clCreateImage2D or clCreateImage3D.
        /// </summary>
        Format = 0x1110,
        /// <summary>
        /// Return size of each element of the image memory object given by image in bytes.
        /// </summary>
        ElementSize = 0x1111,
        /// <summary>
        /// Returns the row pitch in bytes of a row of elements of the image object given by image.
        /// 
        /// If image was created with a non-zero value for image_row_pitch, then the value provided for image_row_pitch by the application is returned, otherwise the returned value is calculated as CL_IMAGE_WIDTH × CL_IMAGE_ELEMENT_SIZE.
        /// </summary>
        RowPitch = 0x1112,
        /// <summary>
        /// Returns the slice pitch in bytes of a 2D slice for the 3D image object or size of each image in a 1D or 2D image array given by image.
        /// 
        /// If image was created with a non-zero value for image_slice_pitch then the value provided for image_slice_pitch by the application is returned, otherwise the returned value is calculated as:
        /// - CL_IMAGE_ROW_PITCH for 1D image arrays.
        /// - CL_IMAGE_HEIGHT × CL_IMAGE_ROW_PITCH for 3D images and 2D image arrays.
        /// 
        /// For a 1D image, 1D image buffer and 2D image object return 0.
        /// </summary>
        SlicePitch = 0x1113,
        /// <summary>
        /// Return width of the image in pixels.
        /// </summary>
        Width = 0x1114,
        /// <summary>
        /// Return height of the image in pixels. For a 1D image, 1D image buffer and 1D image array object, height = 0.
        /// </summary>
        Height = 0x1115,
        /// <summary>
        /// Return depth of the image in pixels. For a 1D image, 1D image buffer, 2D image or 1D and 2D image array object, depth = 0.
        /// </summary>
        Depth = 0x1116,

        // OpenCL 1.2
        /// <summary>
        /// Return number of images in the image array. If image is not an image array, 0 is returned.
        /// </summary>
        ArraySize = 0x1117,
        /// <summary>
        /// Return buffer object associated with image.
        /// 
        /// Deprecated in CL 2.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 2.0.")]
        Buffer = 0x1118,
        /// <summary>
        /// Return num_mip_levels associated with image.
        /// </summary>
        NumberMIPLevels = 0x1119,
        /// <summary>
        /// Return num_samples associated with image.
        /// </summary>
        NumberSamples = 0x111A,
    }

    /// <summary>
    /// cl_pipe_info
    /// OpenCL 2.0
    /// </summary>
    public enum ComputePipeInfo : int
    {
        // OpenCL 2.0
        /// <summary>
        /// Return pipe packet size specified when pipe is created with clCreatePipe.
        /// </summary>
        PacketSize = 0x1120,
        /// <summary>
        /// Return max. number of packets specified when pipe is created with clCreatePipe.
        /// </summary>
        MaxPackets = 0x1121,

        // OpenCL 3.0
        /// <summary>
        /// Return the properties argument specified in clCreatePipe.
        /// 
        /// If the properties argument specified in clCreatePipe used to create pipe was not NULL, the implementation must return the values specified in the properties argument in the same order and without including additional properties.
        /// 
        /// If the properties argument specified in clCreatePipe used to create pipe was NULL, the implementation must return param_value_size_ret equal to 0, indicating that there are no properties to be returned.
        /// </summary>
        Properties = 0x1122,
    }

    /// <summary>
    /// cl_addressing_mode
    /// </summary>
    public enum ComputeImageAddressing : int
    {
        /// <summary>
        /// Behavior is undefined for out-of-range image coordinates.
        /// </summary>
        None = 0x1130,
        /// <summary>
        /// Out-of-range image coordinates are clamped to the edge of the image.
        /// </summary>
        ClampToEdge = 0x1131,
        /// <summary>
        /// Out-of-range image coordinates are assigned a border color value.
        /// </summary>
        Clamp = 0x1132,
        /// <summary>
        /// Out-of-range image coordinates read from the image as if the image data were replicated in all dimensions.
        /// </summary>
        Repeat = 0x1133,

        // OpenCL 1.1
        /// <summary>
        /// Out-of-range image coordinates read from the image as if the image data were replicated in all dimensions, mirroring the image contents at the edge of each replication.
        /// </summary>
        MirroredRepeat = 0x1134
    }

    /// <summary>
    /// cl_filter_mode
    /// </summary>
    public enum ComputeImageFiltering : int
    {
        /// <summary>
        /// Returns the image element nearest to the image coordinate.
        /// </summary>
        Nearest = 0x1140,
        /// <summary>
        /// Returns a weighted average of the four image elements nearest to the image coordinate.
        /// </summary>
        Linear = 0x1141
    }

    /// <summary>
    /// The sampler info query symbols.
    /// cl_sampler_info
    /// </summary>
    public enum ComputeSamplerInfo : int
    {
        /// <summary>
        /// Return the sampler reference count.
        /// </summary>
        ReferenceCount = 0x1150,
        /// <summary>
        /// Return the context specified when the sampler is created.
        /// </summary>
        Context = 0x1151,
        /// <summary>
        /// Return the normalized coords value associated with sampler.
        /// </summary>
        NormalizedCoords = 0x1152,
        /// <summary>
        /// Return the addressing mode value associated with sampler.
        /// </summary>
        AddressingMode = 0x1153,
        /// <summary>
        /// Return the filter mode value associated with sampler.
        /// </summary>
        FilterMode = 0x1154,

        // OpenCL 3.0
        /// <summary>
        /// Return the properties argument specified in clCreateSamplerWithProperties.
        /// 
        /// If the properties argument specified in clCreateSamplerWithProperties used to create sampler was not NULL, the implementation must return the values specified in the properties argument in the same order and without including additional properties.
        /// 
        /// If sampler was created using clCreateSampler, or if the properties argument specified in clCreateSamplerWithProperties was NULL, the implementation must return param_value_size_ret equal to 0, indicating that there are no properties to be returned.
        /// </summary>
        Properties = 0x1158,
    }

    /// <summary>
    /// cl_map_flags - bitfield
    /// </summary>
    [Flags]
    public enum ComputeMemoryMappingFlags : long
    {
        /// <summary>
        /// This flag specifies that the region being mapped in the memory object is being mapped for reading.
        /// 
        /// The pointer returned by clEnqueueMapBuffer (clEnqueueMapImage) is guaranteed to contain the latest bits in the region being mapped when the clEnqueueMapBuffer (clEnqueueMapImage) command has completed.
        /// </summary>
        Read = 1 << 0,
        /// <summary>
        /// This flag specifies that the region being mapped in the memory object is being mapped for writing.
        /// 
        /// The pointer returned by clEnqueueMapBuffer (clEnqueueMapImage) is guaranteed to contain the latest bits in the region being mapped when the clEnqueueMapBuffer (clEnqueueMapImage) command has completed
        /// </summary>
        Write = 1 << 1,

        // OpenCL 1.2
        /// <summary>
        /// This flag specifies that the region being mapped in the memory object is being mapped for writing.
        /// 
        /// The contents of the region being mapped are to be discarded. This is typically the case when the region being mapped is overwritten by the host. This flag allows the implementation to no longer guarantee that the pointer returned by clEnqueueMapBuffer (clEnqueueMapImage) contains the latest bits in the region being mapped which can be a significant performance enhancement.
        /// 
        /// CL_MAP_READ or CL_MAP_WRITE and CL_MAP_WRITE_INVALIDATE_REGION are mutually exclusive.
        /// </summary>
        WriteInvalidateRegion = 1 << 2,

    }

    /// <summary>
    /// The program info query symbols.
    /// cl_program_info
    /// </summary>
    public enum ComputeProgramInfo : int
    {
        /// <summary>
        /// Return the program reference count.
        /// </summary>
        RefernceCount = 0x1160,
        /// <summary>
        /// Return the context specified when the program object is created
        /// </summary>
        Context = 0x1161,
        /// <summary>
        /// Return the number of devices associated with program.
        /// </summary>
        NumberDevices = 0x1162,
        /// <summary>
        /// Return the list of devices associated with the program object. This can be the devices associated with context on which the program object has been created or can be a subset of devices that are specified when a program object is created using clCreateProgramWithBinary.
        /// </summary>
        Devices = 0x1163,
        /// <summary>
        /// Return the program source code specified by clCreateProgramWithSource. The source string returned is a concatenation of all source strings specified to clCreateProgramWithSource with a null terminator. The concatenation strips any nulls in the original source strings.
        /// 
        /// If program is created using clCreateProgramWithBinary, clCreateProgramWithIL or clCreateProgramWithBuiltInKernels, a null string or the appropriate program source code is returned depending on whether or not the program source code is stored in the binary.
        /// 
        /// The actual number of characters that represents the program source code including the null terminator is returned in param_value_size_ret.
        /// </summary>
        Source = 0x1164,
        /// <summary>
        /// Returns an array that contains the size in bytes of the program binary (could be an executable binary, compiled binary or library binary) for each device associated with program. The size of the array is the number of devices associated with program. If a binary is not available for a device(s), a size of zero is returned.
        /// 
        /// If program is created using clCreateProgramWithBuiltInKernels, the implementation may return zero in any entries of the returned array.
        /// </summary>
        BinarySizes = 0x1165,
        /// <summary>
        /// Return the program binaries (could be an executable binary, compiled binary or library binary) for all devices associated with program. For each device in program, the binary returned can be the binary specified for the device when program is created with clCreateProgramWithBinary or it can be the executable binary generated by clBuildProgram or clLinkProgram. If program is created with clCreateProgramWithSource or clCreateProgramWithIL, the binary returned is the binary generated by clBuildProgram, clCompileProgram or clLinkProgram. The bits returned can be an implementation-specific intermediate representation (a.k.a. IR) or device specific executable bits or both. The decision on which information is returned in the binary is up to the OpenCL implementation.
        /// 
        /// param_value points to an array of n pointers allocated by the caller, where n is the number of devices associated with program. The buffer sizes needed to allocate the memory that these n pointers refer to can be queried using the CL_PROGRAM_BINARY_SIZES query as described in this table.
        /// 
        /// Each entry in this array is used by the implementation as the location in memory where to copy the program binary for a specific device, if there is a binary available. To find out which device the program binary in the array refers to, use the CL_PROGRAM_DEVICES query to get the list of devices. There is a one-to-one correspondence between the array of n pointers returned by CL_PROGRAM_BINARIES and array of devices returned by CL_PROGRAM_DEVICES.
        /// </summary>
        Binaries = 0x1166,

        // OpenCL 1.2
        /// <summary>
        /// Returns the number of kernels declared in program that can be created with clCreateKernel. This information is only available after a successful program executable has been built for at least one device in the list of devices associated with program.
        /// </summary>
        NumberKernels = 0x1167,
        /// <summary>
        /// Returns a semi-colon separated list of kernel names in program that can be created with clCreateKernel. This information is only available after a successful program executable has been built for at least one device in the list of devices associated with program.
        /// </summary>
        KernelNames = 0x1168,

        // OpenCL 2.1
        /// <summary>
        /// Returns the program IL for programs created with clCreateProgramWithIL.
        /// 
        /// If program is created with clCreateProgramWithSource, clCreateProgramWithBinary or clCreateProgramWithBuiltInKernels the memory pointed to by param_value will be unchanged and param_value_size_retwill be set to 0.
        /// </summary>
        IL = 0x1169,

        // OpenCL 2.2
        /// <summary>
        /// This indicates that the program object contains non-trivial constructor(s) that will be executed by runtime before any kernel from the program is executed. This information is only available after a successful program executable has been built for at least one device in the list of devices associated with program.
        /// 
        /// Querying CL_PROGRAM_SCOPE_GLOBAL_CTORS_PRESENT may unconditionally return CL_FALSE if no devices associated with program support constructors for program scope global variables. Support for constructors and destructors for program scope global variables is required only for OpenCL 2.2 devices.
        /// 
        /// Deprecated in CL 3.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 3.0.")]
        ScopeGlobalCTorsPresent = 0x116A,
        /// <summary>
        /// This indicates that the program object contains non-trivial destructor(s) that will be executed by runtime when program is destroyed. This information is only available after a successful program executable has been built for at least one device in the list of devices associated with program.
        /// 
        /// Querying CL_PROGRAM_SCOPE_GLOBAL_CTORS_PRESENT may unconditionally return CL_FALSE if no devices associated with program support destructors for program scope global variables. Support for constructors and destructors for program scope global variables is required only for OpenCL 2.2 devices.
        /// 
        /// Deprecated in CL 3.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 3.0.")]
        ScopeGlobalDTorsPresent = 0x116B,
    }

    /// <summary>
    /// The program build info query symbols.
    /// cl_program_build_info
    /// </summary>
    public enum ComputeProgramBuildInfo : int
    {
        /// <summary>
        /// Returns the build, compile or link status, whichever was performed last on the specified program object for device.
        /// 
        /// This can be one of the following:
        /// 
        /// CL_BUILD_NONE - The build status returned if no clBuildProgram, clCompileProgram or clLinkProgram has been performed on the specified program object for device).
        /// 
        /// CL_BUILD_ERROR - The build status returned if clBuildProgram, clCompileProgram or clLinkProgram - whichever was performed last on the specified program object for device - generated an error.
        /// 
        /// CL_BUILD_SUCCESS - The build status returned if clBuildProgram, clCompileProgram or clLinkProgram - whichever was performed last on the specified program object for device - was successful.
        /// 
        /// CL_BUILD_IN_PROGRESS - The build status returned if clBuildProgram, clCompileProgram or clLinkProgram - whichever was performed last on the specified program object for device - has not finished.
        /// </summary>
        BuildStatus = 0x1181,
        /// <summary>
        /// Return the build, compile or link options specified by the options argument in clBuildProgram, clCompileProgram or clLinkProgram, whichever was performed last on the specified program object for device.
        /// 
        /// If build status of the specified program for device is CL_BUILD_NONE, an empty string is returned.
        /// </summary>
        BuildOptions = 0x1182,
        /// <summary>
        /// Return the build, compile or link log for clBuildProgram, clCompileProgram or clLinkProgram, whichever was performed last on program for device.
        /// 
        /// If build status of the specified program for device is CL_BUILD_NONE, an empty string is returned.
        /// </summary>
        BuildLog = 0x1183,

        // OpenCL 1.2
        /// <summary>
        /// Return the program binary type for device. This can be one of the following values:
        /// 
        /// CL_PROGRAM_BINARY_TYPE_NONE - There is no binary associated with the specified program object for device.
        /// 
        /// CL_PROGRAM_BINARY_TYPE_COMPILED_OBJECT - A compiled binary is associated with device. This is the case when the specified program object was created using clCreateProgramWithSource and compiled using clCompileProgram, or when a compiled binary was loaded using clCreateProgramWithBinary.
        /// 
        /// CL_PROGRAM_BINARY_TYPE_LIBRARY - A library binary is associated with device. This is the case when the specified program object was linked by clLinkProgram using the -create-library link option, or when a compiled library binary was loaded using clCreateProgramWithBinary.
        /// 
        /// CL_PROGRAM_BINARY_TYPE_EXECUTABLE - An executable binary is associated with device. This is the case when the specified program object was linked by clLinkProgram without the -create-library link option, or when an executable binary was built using clBuildProgram.
        /// </summary>
        BinaryType = 0x1184,

        // OpenCL 2.0
        /// <summary>
        /// The total amount of storage, in bytes, used by program variables in the global address space.
        /// </summary>
        BuildGlobalVariableTotalSize = 0x1185,
    }

    /// <summary>
    /// cl_program_binary_type
    /// OpenCL 1.2
    /// </summary>
    public enum ComputeProgramBinaryType : int
    {
        /// <summary>
        /// There is no binary associated with the specified program object for device.
        /// </summary>
        None = 0x0,
        /// <summary>
        /// A compiled binary is associated with device. This is the case when the specified program object was created using clCreateProgramWithSource and compiled using clCompileProgram, or when a compiled binary was loaded using clCreateProgramWithBinary.
        /// </summary>
        CompiledObject = 0x1,
        /// <summary>
        /// A library binary is associated with device. This is the case when the specified program object was linked by clLinkProgram using the -create-library link option, or when a compiled library binary was loaded using clCreateProgramWithBinary.
        /// </summary>
        Library = 0x2,
        /// <summary>
        /// An executable binary is associated with device. This is the case when the specified program object was linked by clLinkProgram without the -create-library link option, or when an executable binary was built using clBuildProgram.
        /// </summary>
        Executable = 0x4,
    }

    /// <summary>
    /// cl_build_status
    /// </summary>
    public enum ComputeProgramBuildStatus : int
    {
        /// <summary>
        /// The build status returned if clBuildProgram, clCompileProgram or clLinkProgram - whichever was performed last on the specified program object for device - was successful.
        /// </summary>
        Success = 0,
        /// <summary>
        /// The build status returned if no clBuildProgram, clCompileProgram or clLinkProgram has been performed on the specified program object for device).
        /// </summary>
        None = -1,
        /// <summary>
        /// The build status returned if clBuildProgram, clCompileProgram or clLinkProgram - whichever was performed last on the specified program object for device - generated an error.
        /// </summary>
        Error = -2,
        /// <summary>
        /// The build status returned if clBuildProgram, clCompileProgram or clLinkProgram - whichever was performed last on the specified program object for device - has not finished.
        /// </summary>
        InProgress = -3
    }

    /// <summary>
    /// The kernel info query symbols.
    /// cl_kernel_info
    /// </summary>
    public enum ComputeKernelInfo : int
    {
        /// <summary>
        /// Return the kernel function name.
        /// </summary>
        FunctionName = 0x1190,
        /// <summary>
        /// Return the number of arguments to kernel.
        /// </summary>
        NumberArguments = 0x1191,
        /// <summary>
        /// Return the kernel reference count.
        /// </summary>
        ReferenceCount = 0x1192,
        /// <summary>
        /// Return the context associated with kernel.
        /// </summary>
        Context = 0x1193,
        /// <summary>
        /// Return the program object associated with kernel.
        /// </summary>
        Program = 0x1194,

        // OpenCL 1.2
        /// <summary>
        /// Returns any attributes specified using the __attribute__ OpenCL C qualifier (or using an OpenCL C++ qualifier syntax [[]] ) with the kernel function declaration in the program source. These attributes include attributes described in the earlier OpenCL C kernel language specifications and other attributes supported by an implementation.
        /// 
        /// Attributes are returned as they were declared inside __attribute__((...)), with any surrounding whitespace and embedded newlines removed. When multiple attributes are present, they are returned as a single, space delimited string.
        /// 
        /// For kernels not created from OpenCL C source and the clCreateProgramWithSource API call the string returned from this query will be empty.
        /// </summary>
        Attributes = 0x1195,
    }

    /// <summary>
    /// cl_kernel_arg_info
    /// OpenCL 1.2
    /// </summary>
    public enum ComputeKernelArgumentInfo : int
    {
        // OpenCL 1.2
        /// <summary>
        /// Returns the address qualifier specified for the argument given by arg_index. This can be one of the following values:
        /// 
        /// CL_KERNEL_ARG_ADDRESS_GLOBAL
        /// CL_KERNEL_ARG_ADDRESS_LOCAL
        /// CL_KERNEL_ARG_ADDRESS_CONSTANT
        /// CL_KERNEL_ARG_ADDRESS_PRIVATE
        /// 
        /// If no address qualifier is specified, the default address qualifier which is CL_KERNEL_ARG_ADDRESS_PRIVATE is returned.
        /// </summary>
        ArgumentAddressQualifier = 0x1196,
        /// <summary>
        /// Returns the access qualifier specified for the argument given by arg_index. This can be one of the following values:
        /// 
        /// CL_KERNEL_ARG_ACCESS_READ_ONLY
        /// CL_KERNEL_ARG_ACCESS_WRITE_ONLY
        /// CL_KERNEL_ARG_ACCESS_READ_WRITE
        /// CL_KERNEL_ARG_ACCESS_NONE
        /// 
        /// If argument is not an image type and is not declared with the pipe qualifier, CL_KERNEL_ARG_ACCESS_NONE is returned. If argument is an image type, the access qualifier specified or the default access qualifier is returned.
        /// </summary>
        ArgumentAccessQualifier = 0x1197,
        /// <summary>
        /// Returns the type name specified for the argument given by arg_index. The type name returned will be the argument type name as it was declared with any whitespace removed. If argument type name is an unsigned scalar type (i.e. unsigned char, unsigned short, unsigned int, unsigned long), uchar, ushort, uint and ulong will be returned. The argument type name returned does not include any type qualifiers.
        /// </summary>
        ArgumentTypeName = 0x1198,
        /// <summary>
        /// Returns a bitfield describing one or more type qualifiers specified for the argument given by arg_index. The returned values can be:
        /// 
        /// CL_KERNEL_ARG_TYPE_CONST 
        /// CL_KERNEL_ARG_TYPE_RESTRICT
        /// CL_KERNEL_ARG_TYPE_VOLATILE
        /// CL_KERNEL_ARG_TYPE_PIPE, or
        /// CL_KERNEL_ARG_TYPE_NONE
        /// 
        /// CL_KERNEL_ARG_TYPE_NONE is returned for all parameters passed by value.
        /// </summary>
        ArgumentTypeQualifier = 0x1199,
        /// <summary>
        /// Returns the name specified for the argument given by arg_index.
        /// </summary>
        ArgumentName = 0x119A,
    }

    /// <summary>
    /// cl_kernel_arg_address_qualifier
    /// OpenCL 1.2
    /// </summary>
    public enum ComputeKernelArgumentAddressQualifier : int
    {
        /// <summary> </summary>
        Global = 0x119B,
        /// <summary> </summary>
        Local = 0x119C,
        /// <summary> </summary>
        Constant = 0x119D,
        /// <summary> </summary>
        Private = 0x119E,
    }

    /// <summary>
    /// cl_kernel_arg_access_qualifier
    /// OpenCL 1.2
    /// </summary>
    public enum ComputeKernelArgumentAccessQualifier : int
    {
        /// <summary> </summary>
        ReadOnly = 0x11A0,
        /// <summary> </summary>
        WriteOnly = 0x11A1,
        /// <summary> </summary>
        ReadWrite = 0x11A2,
        /// <summary> </summary>
        None = 0x11A3,
    }

    /// <summary>
    /// cl_kernel_arg_type_qualifier - bitfield
    /// OpenCL 1.2
    /// </summary>
    [Flags]
    public enum ComputeKernelArgumentTypeQualifier : long
    {
        /// <summary> </summary>
        None = 0,
        /// <summary> </summary>
        Constant = 1 << 0,
        /// <summary> </summary>
        Restricted = 1 << 1,
        /// <summary> </summary>
        Volatile = 1 << 2,

        // OpenCL 2.0
        /// <summary> </summary>
        Pipe = 1 << 3,
    }

    /// <summary>
    /// The kernel work-group info query symbols.
    /// cl_kernel_work_group_info
    /// </summary>
    public enum ComputeKernelWorkGroupInfo : int
    {
        /// <summary>
        /// This provides a mechanism for the application to query the maximum work-group size that can be used to execute the kernel on a specific device given by device. The OpenCL implementation uses the resource requirements of the kernel (register usage etc.) to determine what this work-group size should be.
        /// 
        /// As a result and unlike CL_DEVICE_MAX_WORK_GROUP_SIZE this value may vary from one kernel to another as well as one device to another.
        /// 
        /// CL_KERNEL_WORK_GROUP_SIZE will be less than or equal to CL_DEVICE_MAX_WORK_GROUP_SIZE for a given kernel object.
        /// </summary>
        WorkGroupSize = 0x11B0,
        /// <summary>
        /// Returns the work-group size specified in the kernel source or IL.
        /// 
        /// If the work-group size is not specified in the kernel source or IL, (0, 0, 0) is returned.
        /// </summary>
        CompileWorkGroupSize = 0x11B1,
        /// <summary>
        /// Returns the amount of local memory in bytes being used by a kernel. This includes local memory that may be needed by an implementation to execute the kernel, variables declared inside the kernel with the __local address qualifier and local memory to be allocated for arguments to the kernel declared as pointers with the __local address qualifier and whose size is specified with clSetKernelArg.
        /// 
        /// If the local memory size, for any pointer argument to the kernel declared with the __local address qualifier, is not specified, its size is assumed to be 0.
        /// </summary>
        LocalMemorySize = 0x11B2,
        /// <summary>
        /// Returns the preferred multiple of work-group size for launch. This is a performance hint. Specifying a work-group size that is not a multiple of the value returned by this query as the value of the local work size argument to clEnqueueNDRangeKernel will not fail to enqueue the kernel for execution unless the work-group size specified is larger than the device maximum.
        /// </summary>
        PreferredWorkGroupSizeMultiple = 0x11B3,
        /// <summary>
        /// Returns the minimum amount of private memory, in bytes, used by each work-item in the kernel. This value may include any private memory needed by an implementation to execute the kernel, including that used by the language built-ins and variable declared inside the kernel with the __private qualifier.
        /// </summary>
        PrivateMemorySize = 0x11B4,

        // OpenCL 1.2
        /// <summary>
        /// This provides a mechanism for the application to query the maximum global size that can be used to execute a kernel (i.e. global_work_size argument to clEnqueueNDRangeKernel) on a custom device given by device or a built-in kernel on an OpenCL device given by device.
        /// 
        /// If device is not a custom device and kernel is not a built-in kernel, clGetKernelWorkGroupInfo returns the error CL_INVALID_VALUE.
        /// </summary>
        GlobalWorkSize = 0x11B5,
    }

    /// <summary>
    /// cl_kernel_sub_group_info
    /// OpenCL 2.1
    /// </summary>
    public enum ComputeKernelSubGroupInfo : int
    {
        // OpenCL 2.1
        /// <summary>
        /// Returns the maximum sub-group size for this kernel. All sub-groups must be the same size, while the last sub-group in any work-group (i.e. the sub-group with the maximum index) could be the same or smaller size.
        /// 
        /// The input_value must be an array of size_t values corresponding to the local work size parameter of the intended dispatch. The number of dimensions in the ND-range will be inferred from the value specified for input_value_size.
        /// </summary>
        MaxSubGroupSizeForNDRange = 0x2033,
        /// <summary>
        /// Returns the number of sub-groups that will be present in each work-group for a given local work size. All workgroups, apart from the last work-group in each dimension in the presence of non-uniform work-group sizes, will have the same number of sub-groups.
        /// 
        /// The input_value must be an array of size_t values corresponding to the local work size parameter of the intended dispatch. The number of dimensions in the ND-range will be inferred from the value specified for input_value_size.
        /// </summary>
        SubGroupCountForNDRange = 0x2034,
        /// <summary>
        /// Returns the local size that will generate the requested number of sub-groups for the kernel. The output array must be an array of size_t values corresponding to the local size parameter. Any returned work-group will have one dimension. Other dimensions inferred from the value specified for param_value_size will be filled with the value 1. The returned value will produce an exact number of sub-groups and result in no partial groups for an executing kernel except in the case where the last work-group in a dimension has a size different from that of the other groups. If no work-group size can accommodate the requested number of sub-groups, 0 will be returned in each element of the return array.
        /// </summary>
        LocalSizeForSubGroupCount = 0x11B8,
        /// <summary>
        /// This provides a mechanism for the application to query the maximum number of sub-groups that may make up each work-group to execute a kernel on a specific device given by device. The OpenCL implementation uses the resource requirements of the kernel (register usage etc.) to determine what this work-group size should be. The returned value may be used to compute a work-group size to enqueue the kernel with to give a round number of sub-groups for an enqueue.
        /// </summary>
        MaxNumberSubGroups = 0x11B9,
        /// <summary>
        /// Returns the number of sub-groups per work-group specified in the kernel source or IL. If the sub-group count is not specified then 0 is returned.
        /// </summary>
        CompileNumberSubGroups = 0x11BA,
    }

    /// <summary>
    /// cl_kernel_exec_info
    /// OpenCL 2.0
    /// </summary>
    public enum ComputeKernelExecutionInfo : int
    {
        // OpenCL 2.0
        /// <summary>
        /// SVM pointers must reference locations contained entirely within buffers that are passed to kernel as arguments, or that are passed through the execution information.
        /// 
        /// Non-argument SVM buffers must be specified by passing pointers to those buffers via clSetKernelExecInfo for coarse-grain and fine-grain buffer SVM allocations but not for finegrain system SVM allocations.
        /// </summary>
        SVMPtrs = 0x11B6,
        /// <summary>
        /// This flag indicates whether the kernel uses pointers that are fine grain system SVM allocations. These fine grain system SVM pointers may be passed as arguments or defined in SVM buffers that are passed as arguments to kernel.
        /// </summary>
        SVMFineGrainSystem = 0x11B7,
    }

    /// <summary>
    /// The event info query symbols.
    /// cl_event_info
    /// </summary>
    public enum ComputeEventInfo : int
    {
        /// <summary>
        /// Return the command-queue associated with event. For user event objects, a NULL value is returned.
        /// </summary>
        CommandQueue = 0x11D0,
        /// <summary>
        /// Return the command type associated with event as described in the Event Command Types table.
        /// </summary>
        CommandType = 0x11D1,
        /// <summary>
        /// Return the execution status of the command identified by event. Valid values are:
        /// 
        /// CL_QUEUED (command has been enqueued in the command-queue),
        /// 
        /// CL_SUBMITTED (enqueued command has been submitted by the host to the device associated with the command-queue),
        /// 
        /// CL_RUNNING (device is currently executing this command),
        /// 
        /// CL_COMPLETE (the command has completed), or
        /// 
        /// Error code given by a negative integer value. (command was abnormally terminated - this may be caused by a bad memory access etc.). These error codes come from the same set of error codes that are returned from the platform or runtime API calls as return values or errcode_ret values.
        /// </summary>
        CommandExecutionStatus = 0x11D3,
        /// <summary>
        /// Return the event reference count.
        /// </summary>
        ReferenceCount = 0x11D2,

        // OpenCL 1.1
        /// <summary>
        /// Return the context associated with event.
        /// </summary>
        Context = 0x11D4
    }

    /// <summary>
    /// cl_command_type
    /// </summary>
    public enum ComputeCommandType : int
    {
        /// <summary>
        /// clEnqueueNDRangeKernel
        /// </summary>
        EnqueueNDRangeKernel = 0x11F0,
        /// <summary>
        /// clEnqueueTask
        /// </summary>
        EnqueueTask = 0x11F1,
        /// <summary>
        /// clEnqueueNativeKernel
        /// </summary>
        EnqueueNativeKernel = 0x11F2,
        /// <summary>
        /// clEnqueueReadBuffer
        /// </summary>
        EnqueueReadBuffer = 0x11F3,
        /// <summary>
        /// clEnqueueWriteBuffer
        /// </summary>
        EnqueueWriteBuffer = 0x11F4,
        /// <summary>
        /// clEnqueueCopyBuffer
        /// </summary>
        EnqueueCopyBuffer = 0x11F5,
        /// <summary>
        /// clEnqueueReadImage
        /// </summary>
        EnqueueReadImage = 0x11F6,
        /// <summary>
        /// clEnqueueWriteImage
        /// </summary>
        EnqueueWriteImage = 0x11F7,
        /// <summary>
        /// clEnqueueCopyImage
        /// </summary>
        EnqueueCopyImage = 0x11F8,
        /// <summary>
        /// clEnqueueCopyBufferToImage
        /// </summary>
        EnqueueCopyBufferToImage = 0x11FA,
        /// <summary>
        /// clEnqueueCopyImageToBuffer
        /// </summary>
        EnqueueCopyImageToBuffer = 0x11F9,
        /// <summary>
        /// clEnqueueMapBuffer
        /// </summary>
        EnqueueMapBuffer = 0x11FB,
        /// <summary>
        /// clEnqueueMapImage
        /// </summary>
        EnqueueMapImage = 0x11FC,
        /// <summary>
        /// clEnqueueUnmapMemObject
        /// </summary>
        EnqueueUnmapMemObject = 0x11FD,
        /// <summary>
        /// clEnqueueMarker
        /// clEnqueueMarkerWithWaitList
        /// </summary>
        EnqueueMarker = 0x11FE,

        // OpenCL 1.1
        /// <summary>
        /// clEnqueueReadBufferRect
        /// </summary>
        EnqueueReadBufferRect = 0x1201,
        /// <summary>
        /// clEnqueueWriteBufferRect
        /// </summary>
        EnqueueWriteBufferRect = 0x1202,
        /// <summary>
        /// clEnqueueCopyBufferRect
        /// </summary>
        EnqueueCopyBufferRect = 0x1203,
        /// <summary>
        /// clCreateUserEvent
        /// </summary>
        CreateUserEvent = 0x1204,

        // OpenCL 1.2
        /// <summary>
        /// clEnqueueBarrier
        /// clEnqueueBarrierWithWaitList
        /// </summary>
        EnqueueBarrier = 0x1205,
        /// <summary>
        /// clEnqueueMigrateMemObjects
        /// </summary>
        EnqueueMigrateMemObjects = 0x1206,
        /// <summary>
        /// clEnqueueFillBuffer
        /// </summary>
        EnqueueFillBuffer = 0x1207,
        /// <summary>
        /// clEnqueueFillImage
        /// </summary>
        EnqueueFillImage = 0x1208,

        // OpenCL 2.0
        /// <summary>
        /// clEnqueueSVMFree
        /// </summary>
        EnqueueSVMFree = 0x1209,
        /// <summary>
        /// clEnqueueSVMMemcpy
        /// </summary>
        EnqueueSVMMemcpy = 0x120A,
        /// <summary>
        /// clEnqueueSVMMemFill
        /// </summary>
        EnqueueSVMMemFill = 0x120B,
        /// <summary>
        /// clEnqueueSVMMap
        /// </summary>
        EnqueueSVMMap = 0x120C,
        /// <summary>
        /// clEnqueueSVMUnmap
        /// </summary>
        EnqueueSVMUnmap = 0x120D,

        // OpenCL 3.0
        /// <summary>
        /// clEnqueueSVMMigrateMem
        /// 
        /// Prior to OpenCL 3.0, implementations should return CL_COMMAND_MIGRATE_MEM_OBJECTS, but may return an implementation-defined event command type for clEnqueueSVMMigrateMem.
        /// </summary>
        EnqueueSVMMigrateMem = 0x120E,
    }

    /// <summary>
    /// command execution status
    /// </summary>
    public enum ComputeCommandExecutionStatus : int
    {
        /// <summary>
        /// the command has completed
        /// </summary>
        Complete = 0x0,
        /// <summary>
        /// device is currently executing this command
        /// </summary>
        Running = 0x1,
        /// <summary>
        /// enqueued command has been submitted by the host to the device associated with the command-queue
        /// </summary>
        Submitted = 0x2,
        /// <summary>
        /// command has been enqueued in the command-queue
        /// </summary>
        Queued = 0x3
    }

    /// <summary>
    /// cl_buffer_create_type
    /// </summary>
    public enum ComputeBufferCreateType : int
    {
        // OpenCL 1.1
        /// <summary>
        /// Create a buffer object that represents a specific region in buffer.
        /// 
        /// buffer_create_info is a pointer to a cl_buffer_region structure specifying a region of the buffer.
        /// 
        /// If buffer is created with CL_MEM_USE_HOST_PTR, the host_ptr associated with the buffer object returned is host_ptr + origin.
        /// 
        /// The buffer object returned references the data store allocated for buffer and points to the region specified by buffer_create_info in this data store.
        /// </summary>
        Region = 0x1220
    }

    /// <summary>
    /// The command profiling info query symbols.
    /// cl_profiling_info
    /// </summary>
    public enum ComputeCommandProfilingInfo : int
    {
        /// <summary>
        /// A 64-bit value that describes the current device time counter in nanoseconds when the command identified by event is enqueued in a command-queue by the host.
        /// </summary>
        Queued = 0x1280,
        /// <summary>
        /// A 64-bit value that describes the current device time counter in nanoseconds when the command identified by event that has been enqueued is submitted by the host to the device associated with the command-queue.
        /// </summary>
        Submitted = 0x1281,
        /// <summary>
        /// A 64-bit value that describes the current device time counter in nanoseconds when the command identified by event starts execution on the device.
        /// </summary>
        Started = 0x1282,
        /// <summary>
        /// A 64-bit value that describes the current device time counter in nanoseconds when the command identified by event has finished execution on the device.
        /// </summary>
        Ended = 0x1283,

        // OpenCL 2.0
        /// <summary>
        /// A 64-bit value that describes the current device time counter in nanoseconds when the command identified by event and any child commands enqueued by this command on the device have finished execution.
        /// </summary>
        Completed = 0x1284
    }

    /// <summary>
    /// cl_device_atomic_capabilities - bitfield
    /// OpenCL 3.0
    /// </summary>
    [Flags]
    public enum ComputeDeviceAtomicCapabilities : long
    {
        /// <summary>
        /// Support for the relaxed memory order.
        /// </summary>
        OrderRelaxed = 1 << 0,
        /// <summary>
        /// Support for the acquire, release, and acquire-release memory orders.
        /// </summary>
        OrderAcquireRelease = 1 << 1,
        /// <summary>
        /// Support for the sequentially consistent memory order.
        /// </summary>
        OrderSequentiallyConsistent = 1 << 2,
        /// <summary>
        /// Support for memory ordering constraints that apply to a single work-item.
        /// </summary>
        ScopeWorkItem = 1 << 3,
        /// <summary>
        /// Support for memory ordering constraints that apply to all work-items in a work-group.
        /// </summary>
        ScopeWorkGroup = 1 << 4,
        /// <summary>
        /// Support for memory ordering constraints that apply to all work-items executing on the device.
        /// </summary>
        ScopeDevice = 1 << 5,
        /// <summary>
        /// Support for memory ordering constraints that apply to all work-items executing across all devices that can share SVM memory with each other and the host process.
        /// </summary>
        ScopeAllDevices = 1 << 6,
    }

    /// <summary>
    ///  cl_device_device_enqueue_capabilities - bitfield
    /// OpenCL 3.0
    /// </summary>
    [Flags]
    public enum ComputeDeviceDeviceEnqueueCapabilities : long
    {
        /// <summary>
        /// Device supports device-side enqueue and on-device queues.
        /// </summary>
        DeviceQueueSupported = 1 << 0,
        /// <summary>
        /// Device supports a replaceable default on-device queue.
        /// </summary>
        DeviceQueueReplaceableDefault = 1 << 1,
    }

    /**************************************************************************************/
    // CL/GL Sharing API

    /// <summary>
    /// cl_gl_object_type
    /// </summary>
    public enum cl_gl_object_type : int
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
    public enum cl_gl_texture_info : int
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
    public enum cl_gl_context_info : int
    {
        /// <summary> </summary>
        CL_CURRENT_DEVICE_FOR_GL_CONTEXT_KHR = 0x2006,
        /// <summary> </summary>
        CL_DEVICES_FOR_GL_CONTEXT_KHR = 0x2007
    }

    /// <summary>
    /// cl_device_partition_property_ext
    /// </summary>
    [Flags]
    public enum cl_device_partition_property_ext : long
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
    /// cl_mem_migration_flags_ext - bitfield
    /// </summary>
    [Flags]
    public enum cl_mem_migration_flags_ext : long
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