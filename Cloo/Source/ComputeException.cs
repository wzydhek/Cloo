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

namespace Cloo
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Represents an error state that occurred while executing an OpenCL API call.
    /// </summary>
    /// <seealso cref="ComputeErrorCode"/>
    public class ComputeException : ApplicationException
    {
        #region Fields

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ComputeErrorCode _code;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the <see cref="ComputeErrorCode"/> of the <see cref="ComputeException"/>.
        /// </summary>
        public ComputeErrorCode ComputeErrorCode => _code;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new <see cref="ComputeException"/> with a specified <see cref="ComputeErrorCode"/>.
        /// </summary>
        /// <param name="code"> A <see cref="ComputeErrorCode"/>. </param>
        public ComputeException(ComputeErrorCode code)
            : base("OpenCL error code detected: " + code.ToString() + ".")
        {
            _code = code;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Checks for an OpenCL error code and throws a <see cref="ComputeException"/> if such is encountered.
        /// </summary>
        /// <param name="errorCode"> The value to be checked for an OpenCL error. </param>
        public static void ThrowOnError(int errorCode)
        {
            ThrowOnError((ComputeErrorCode)errorCode);
        }

        /// <summary>
        /// Checks for an OpenCL error code and throws a <see cref="ComputeException"/> if such is encountered.
        /// </summary>
        /// <param name="errorCode"> The OpenCL error code. </param>
        public static void ThrowOnError(ComputeErrorCode errorCode)
        {
            switch (errorCode)
            {
                case ComputeErrorCode.CL_SUCCESS:
                    return;

                case ComputeErrorCode.CL_DEVICE_NOT_FOUND:
                    throw new DeviceNotFoundComputeException();

                case ComputeErrorCode.CL_DEVICE_NOT_AVAILABLE:
                    throw new DeviceNotAvailableComputeException();

                case ComputeErrorCode.CL_COMPILER_NOT_AVAILABLE:
                    throw new CompilerNotAvailableComputeException();

                case ComputeErrorCode.CL_MEM_OBJECT_ALLOCATION_FAILURE:
                    throw new MemoryObjectAllocationFailureComputeException();

                case ComputeErrorCode.CL_OUT_OF_RESOURCES:
                    throw new OutOfResourcesComputeException();

                case ComputeErrorCode.CL_OUT_OF_HOST_MEMORY:
                    throw new OutOfHostMemoryComputeException();

                case ComputeErrorCode.CL_PROFILING_INFO_NOT_AVAILABLE:
                    throw new ProfilingInfoNotAvailableComputeException();

                case ComputeErrorCode.CL_MEM_COPY_OVERLAP:
                    throw new MemoryCopyOverlapComputeException();

                case ComputeErrorCode.CL_IMAGE_FORMAT_MISMATCH:
                    throw new ImageFormatMismatchComputeException();

                case ComputeErrorCode.CL_IMAGE_FORMAT_NOT_SUPPORTED:
                    throw new ImageFormatNotSupportedComputeException();

                case ComputeErrorCode.CL_BUILD_PROGRAM_FAILURE:
                    throw new BuildProgramFailureComputeException();

                case ComputeErrorCode.CL_MAP_FAILURE:
                    throw new MapFailureComputeException();

                case ComputeErrorCode.CL_INVALID_VALUE:
                    throw new InvalidValueComputeException();

                case ComputeErrorCode.CL_INVALID_DEVICE_TYPE:
                    throw new InvalidDeviceTypeComputeException();

                case ComputeErrorCode.CL_INVALID_PLATFORM:
                    throw new InvalidPlatformComputeException();

                case ComputeErrorCode.CL_INVALID_DEVICE:
                    throw new InvalidDeviceComputeException();

                case ComputeErrorCode.CL_INVALID_CONTEXT:
                    throw new InvalidContextComputeException();

                case ComputeErrorCode.CL_INVALID_QUEUE_PROPERTIES:
                    throw new InvalidCommandQueueFlagsComputeException();

                case ComputeErrorCode.CL_INVALID_COMMAND_QUEUE:
                    throw new InvalidCommandQueueComputeException();

                case ComputeErrorCode.CL_INVALID_HOST_PTR:
                    throw new InvalidHostPointerComputeException();

                case ComputeErrorCode.CL_INVALID_MEM_OBJECT:
                    throw new InvalidMemoryObjectComputeException();

                case ComputeErrorCode.CL_INVALID_IMAGE_FORMAT_DESCRIPTOR:
                    throw new InvalidImageFormatDescriptorComputeException();

                case ComputeErrorCode.CL_INVALID_IMAGE_SIZE:
                    throw new InvalidImageSizeComputeException();

                case ComputeErrorCode.CL_INVALID_SAMPLER:
                    throw new InvalidSamplerComputeException();

                case ComputeErrorCode.CL_INVALID_BINARY:
                    throw new InvalidBinaryComputeException();

                case ComputeErrorCode.CL_INVALID_BUILD_OPTIONS:
                    throw new InvalidBuildOptionsComputeException();

                case ComputeErrorCode.CL_INVALID_PROGRAM:
                    throw new InvalidProgramComputeException();

                case ComputeErrorCode.CL_INVALID_PROGRAM_EXECUTABLE:
                    throw new InvalidProgramExecutableComputeException();

                case ComputeErrorCode.CL_INVALID_KERNEL_NAME:
                    throw new InvalidKernelNameComputeException();

                case ComputeErrorCode.CL_INVALID_KERNEL_DEFINITION:
                    throw new InvalidKernelDefinitionComputeException();

                case ComputeErrorCode.CL_INVALID_KERNEL:
                    throw new InvalidKernelComputeException();

                case ComputeErrorCode.CL_INVALID_ARG_INDEX:
                    throw new InvalidArgumentIndexComputeException();

                case ComputeErrorCode.CL_INVALID_ARG_VALUE:
                    throw new InvalidArgumentValueComputeException();

                case ComputeErrorCode.CL_INVALID_ARG_SIZE:
                    throw new InvalidArgumentSizeComputeException();

                case ComputeErrorCode.CL_INVALID_KERNEL_ARGS:
                    throw new InvalidKernelArgumentsComputeException();

                case ComputeErrorCode.CL_INVALID_WORK_DIMENSION:
                    throw new InvalidWorkDimensionsComputeException();

                case ComputeErrorCode.CL_INVALID_WORK_GROUP_SIZE:
                    throw new InvalidWorkGroupSizeComputeException();

                case ComputeErrorCode.CL_INVALID_WORK_ITEM_SIZE:
                    throw new InvalidWorkItemSizeComputeException();

                case ComputeErrorCode.CL_INVALID_GLOBAL_OFFSET:
                    throw new InvalidGlobalOffsetComputeException();

                case ComputeErrorCode.CL_INVALID_EVENT_WAIT_LIST:
                    throw new InvalidEventWaitListComputeException();

                case ComputeErrorCode.CL_INVALID_EVENT:
                    throw new InvalidEventComputeException();

                case ComputeErrorCode.CL_INVALID_OPERATION:
                    throw new InvalidOperationComputeException();

                case ComputeErrorCode.CL_INVALID_GL_OBJECT:
                    throw new InvalidGLObjectComputeException();

                case ComputeErrorCode.CL_INVALID_BUFFER_SIZE:
                    throw new InvalidBufferSizeComputeException();

                case ComputeErrorCode.CL_INVALID_MIP_LEVEL:
                    throw new InvalidMipLevelComputeException();

                default:
                    throw new ComputeException(errorCode);
            }
        }

        #endregion
    }

    #region Exception classes

    // Disable CS1591 warnings (missing XML comment for publicly visible type or member).
    #pragma warning disable 1591

    public class DeviceNotFoundComputeException : ComputeException
    { public DeviceNotFoundComputeException() : base(ComputeErrorCode.CL_DEVICE_NOT_FOUND) { } }

    public class DeviceNotAvailableComputeException : ComputeException
    { public DeviceNotAvailableComputeException() : base(ComputeErrorCode.CL_DEVICE_NOT_AVAILABLE) { } }

    public class CompilerNotAvailableComputeException : ComputeException
    { public CompilerNotAvailableComputeException() : base(ComputeErrorCode.CL_COMPILER_NOT_AVAILABLE) { } }

    public class MemoryObjectAllocationFailureComputeException : ComputeException
    { public MemoryObjectAllocationFailureComputeException() : base(ComputeErrorCode.CL_MEM_OBJECT_ALLOCATION_FAILURE) { } }

    public class OutOfResourcesComputeException : ComputeException
    { public OutOfResourcesComputeException() : base(ComputeErrorCode.CL_OUT_OF_RESOURCES) { } }

    public class OutOfHostMemoryComputeException : ComputeException
    { public OutOfHostMemoryComputeException() : base(ComputeErrorCode.CL_OUT_OF_HOST_MEMORY) { } }

    public class ProfilingInfoNotAvailableComputeException : ComputeException
    { public ProfilingInfoNotAvailableComputeException() : base(ComputeErrorCode.CL_PROFILING_INFO_NOT_AVAILABLE) { } }

    public class MemoryCopyOverlapComputeException : ComputeException
    { public MemoryCopyOverlapComputeException() : base(ComputeErrorCode.CL_MEM_COPY_OVERLAP) { } }

    public class ImageFormatMismatchComputeException : ComputeException
    { public ImageFormatMismatchComputeException() : base(ComputeErrorCode.CL_IMAGE_FORMAT_MISMATCH) { } }

    public class ImageFormatNotSupportedComputeException : ComputeException
    { public ImageFormatNotSupportedComputeException() : base(ComputeErrorCode.CL_IMAGE_FORMAT_NOT_SUPPORTED) { } }

    public class BuildProgramFailureComputeException : ComputeException
    { public BuildProgramFailureComputeException() : base(ComputeErrorCode.CL_BUILD_PROGRAM_FAILURE) { } }

    public class MapFailureComputeException : ComputeException
    { public MapFailureComputeException() : base(ComputeErrorCode.CL_MAP_FAILURE) { } }

    public class InvalidValueComputeException : ComputeException
    { public InvalidValueComputeException() : base(ComputeErrorCode.CL_INVALID_VALUE) { } }

    public class InvalidDeviceTypeComputeException : ComputeException
    { public InvalidDeviceTypeComputeException() : base(ComputeErrorCode.CL_INVALID_DEVICE_TYPE) { } }

    public class InvalidPlatformComputeException : ComputeException
    { public InvalidPlatformComputeException() : base(ComputeErrorCode.CL_INVALID_PLATFORM) { } }

    public class InvalidDeviceComputeException : ComputeException
    { public InvalidDeviceComputeException() : base(ComputeErrorCode.CL_INVALID_DEVICE) { } }

    public class InvalidContextComputeException : ComputeException
    { public InvalidContextComputeException() : base(ComputeErrorCode.CL_INVALID_CONTEXT) { } }

    public class InvalidCommandQueueFlagsComputeException : ComputeException
    { public InvalidCommandQueueFlagsComputeException() : base(ComputeErrorCode.CL_INVALID_QUEUE_PROPERTIES) { } }

    public class InvalidCommandQueueComputeException : ComputeException
    { public InvalidCommandQueueComputeException() : base(ComputeErrorCode.CL_INVALID_COMMAND_QUEUE) { } }

    public class InvalidHostPointerComputeException : ComputeException
    { public InvalidHostPointerComputeException() : base(ComputeErrorCode.CL_INVALID_HOST_PTR) { } }

    public class InvalidMemoryObjectComputeException : ComputeException
    { public InvalidMemoryObjectComputeException() : base(ComputeErrorCode.CL_INVALID_MEM_OBJECT) { } }

    public class InvalidImageFormatDescriptorComputeException : ComputeException
    { public InvalidImageFormatDescriptorComputeException() : base(ComputeErrorCode.CL_INVALID_IMAGE_FORMAT_DESCRIPTOR) { } }

    public class InvalidImageSizeComputeException : ComputeException
    { public InvalidImageSizeComputeException() : base(ComputeErrorCode.CL_INVALID_IMAGE_SIZE) { } }

    public class InvalidSamplerComputeException : ComputeException
    { public InvalidSamplerComputeException() : base(ComputeErrorCode.CL_INVALID_SAMPLER) { } }

    public class InvalidBinaryComputeException : ComputeException
    { public InvalidBinaryComputeException() : base(ComputeErrorCode.CL_INVALID_BINARY) { } }

    public class InvalidBuildOptionsComputeException : ComputeException
    { public InvalidBuildOptionsComputeException() : base(ComputeErrorCode.CL_INVALID_BUILD_OPTIONS) { } }

    public class InvalidProgramComputeException : ComputeException
    { public InvalidProgramComputeException() : base(ComputeErrorCode.CL_INVALID_PROGRAM) { } }

    public class InvalidProgramExecutableComputeException : ComputeException
    { public InvalidProgramExecutableComputeException() : base(ComputeErrorCode.CL_INVALID_PROGRAM_EXECUTABLE) { } }

    public class InvalidKernelNameComputeException : ComputeException
    { public InvalidKernelNameComputeException() : base(ComputeErrorCode.CL_INVALID_KERNEL_NAME) { } }

    public class InvalidKernelDefinitionComputeException : ComputeException
    { public InvalidKernelDefinitionComputeException() : base(ComputeErrorCode.CL_INVALID_KERNEL_DEFINITION) { } }

    public class InvalidKernelComputeException : ComputeException
    { public InvalidKernelComputeException() : base(ComputeErrorCode.CL_INVALID_KERNEL) { } }

    public class InvalidArgumentIndexComputeException : ComputeException
    { public InvalidArgumentIndexComputeException() : base(ComputeErrorCode.CL_INVALID_ARG_INDEX) { } }

    public class InvalidArgumentValueComputeException : ComputeException
    { public InvalidArgumentValueComputeException() : base(ComputeErrorCode.CL_INVALID_ARG_VALUE) { } }

    public class InvalidArgumentSizeComputeException : ComputeException
    { public InvalidArgumentSizeComputeException() : base(ComputeErrorCode.CL_INVALID_ARG_SIZE) { } }

    public class InvalidKernelArgumentsComputeException : ComputeException
    { public InvalidKernelArgumentsComputeException() : base(ComputeErrorCode.CL_INVALID_KERNEL_ARGS) { } }

    public class InvalidWorkDimensionsComputeException : ComputeException
    { public InvalidWorkDimensionsComputeException() : base(ComputeErrorCode.CL_INVALID_WORK_DIMENSION) { } }

    public class InvalidWorkGroupSizeComputeException : ComputeException
    { public InvalidWorkGroupSizeComputeException() : base(ComputeErrorCode.CL_INVALID_WORK_GROUP_SIZE) { } }

    public class InvalidWorkItemSizeComputeException : ComputeException
    { public InvalidWorkItemSizeComputeException() : base(ComputeErrorCode.CL_INVALID_WORK_ITEM_SIZE) { } }

    public class InvalidGlobalOffsetComputeException : ComputeException
    { public InvalidGlobalOffsetComputeException() : base(ComputeErrorCode.CL_INVALID_GLOBAL_OFFSET) { } }

    public class InvalidEventWaitListComputeException : ComputeException
    { public InvalidEventWaitListComputeException() : base(ComputeErrorCode.CL_INVALID_EVENT_WAIT_LIST) { } }

    public class InvalidEventComputeException : ComputeException
    { public InvalidEventComputeException() : base(ComputeErrorCode.CL_INVALID_EVENT) { } }

    public class InvalidOperationComputeException : ComputeException
    { public InvalidOperationComputeException() : base(ComputeErrorCode.CL_INVALID_OPERATION) { } }

    public class InvalidGLObjectComputeException : ComputeException
    { public InvalidGLObjectComputeException() : base(ComputeErrorCode.CL_INVALID_GL_OBJECT) { } }

    public class InvalidBufferSizeComputeException : ComputeException
    { public InvalidBufferSizeComputeException() : base(ComputeErrorCode.CL_INVALID_BUFFER_SIZE) { } }

    public class InvalidMipLevelComputeException : ComputeException
    { public InvalidMipLevelComputeException() : base(ComputeErrorCode.CL_INVALID_MIP_LEVEL) { } }

    #endregion
}