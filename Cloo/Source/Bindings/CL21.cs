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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using static System.Net.WebRequestMethods;

namespace Cloo.Bindings
{
    /// <summary>
    /// Contains bindings to the OpenCL 2.1 functions.
    /// </summary>
    /// <remarks> See the OpenCL specification for documentation regarding these functions. </remarks>
    [SuppressUnmanagedCodeSecurity]
    public class CL21 : CL20
    {
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clCloneKernel")]
        public static extern CLKernelHandle CloneKernel(
            CLKernelHandle source_kernel,
            out ComputeErrorCode errcode_ret);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clCreateProgramWithIL")]
        public static extern ComputeProgram CreateProgramWithIL(
            CLContextHandle context,
            CLMemoryHandle il,
            IntPtr length,
            out ComputeErrorCode errcode_ret);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clEnqueueSVMMigrateMem")]
        public static extern ComputeErrorCode EnqueueSVMMigrateMem(
            CLCommandQueueHandle command_queue,
            int num_svm_pointers,
            [MarshalAs(UnmanagedType.LPArray)] CLCommandQueueHandle[] svm_pointers,
            [MarshalAs(UnmanagedType.LPArray)] IntPtr[] sizes,
            ComputeMemoryMigrationFlags flags,
            int num_events_in_wait_list,
            [MarshalAs(UnmanagedType.LPArray)] CLEventHandle[] event_wait_list,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] CLEventHandle[] new_event);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clGetDeviceAndHostTimer")]
        public static extern ComputeErrorCode GetDeviceAndHostTimer(
            CLDeviceHandle device,
            ref long device_timestamp,
            ref long host_timestamp);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clGetHostTimer")]
        public static extern ComputeErrorCode GetHostTimer(
            CLDeviceHandle device,
            ref long host_timestamp);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clGetKernelSubGroupInfo")]
        public static extern ComputeErrorCode GetKernelSubGroupInfo(
            CLKernelHandle kernel,
            CLDeviceHandle device,
            ComputeKernelSubGroupInfo param_name,
            IntPtr input_value_size,
            IntPtr input_value,
            IntPtr param_value_size,
            IntPtr param_value,
            out IntPtr param_value_size_ret);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clSetDefaultDeviceCommandQueue")]
        public static extern ComputeErrorCode SetDefaultDeviceCommandQueue(
            CLContextHandle context,
            CLDeviceHandle device,
            CLCommandQueueHandle command_queue);
    }
}
