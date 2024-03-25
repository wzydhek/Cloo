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

namespace Cloo.Bindings
{
    /// <summary>
    /// Contains bindings to the OpenCL 2.0 functions.
    /// </summary>
    /// <remarks> See the OpenCL specification for documentation regarding these functions. </remarks>
    [SuppressUnmanagedCodeSecurity]
    public class CL20 : CL12
    {
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clCreateCommandQueueWithProperties")]
        public static extern CLCommandQueueHandle CreateCommandQueueWithProperties(
            CLContextHandle context,
            CLDeviceHandle device,
            [MarshalAs(UnmanagedType.LPArray)] long[] properties,
            out ComputeErrorCode errcode_ret);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clCreatePipe")]
        public static extern CLPipeHandle CreatePipe(
            CLContextHandle context,
            ComputeMemoryFlags flags,
            int pipe_packet_size,
            int pipe_max_packets,
            IntPtr properties,
            out ComputeErrorCode errcode_ret);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clCreateSamplerWithProperties")]
        public static extern CLSamplerHandle CreateSamplerWithProperties(
            CLContextHandle context,
            [MarshalAs(UnmanagedType.LPArray)] long[] sampler_properties,
            out ComputeErrorCode errcode_ret);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clEnqueueSVMFree")]
        public static extern ComputeErrorCode EnqueueSVMFree(
            CLCommandQueueHandle command_queue,
            int num_svm_pointers,
            [MarshalAs(UnmanagedType.LPArray)] CLSVMHandle[] svm_pointers,
            pfn_free_func free_func,
            IntPtr user_data,
            int num_events_in_wait_list,
            [MarshalAs(UnmanagedType.LPArray)] CLEventHandle[] event_wait_list,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] CLEventHandle[] new_event);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clEnqueueSVMMap")]
        public static extern ComputeErrorCode EnqueueSVMMap(
            CLCommandQueueHandle command_queue,
            [MarshalAs(UnmanagedType.Bool)] bool blocking_map,
            ComputeMemoryMappingFlags flags,
            CLSVMHandle svm_ptr,
            IntPtr size,
            int num_events_in_wait_list,
            [MarshalAs(UnmanagedType.LPArray)] CLEventHandle[] event_wait_list,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] CLEventHandle[] new_event);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clEnqueueSVMMemcpy")]
        public static extern ComputeErrorCode EnqueueSVMMemcpy(
            CLCommandQueueHandle command_queue,
            [MarshalAs(UnmanagedType.Bool)] bool blocking_copy,
            CLSVMHandle dst_ptr,
            CLSVMHandle src_ptr,
            IntPtr size,
            int num_events_in_wait_list,
            [MarshalAs(UnmanagedType.LPArray)] CLEventHandle[] event_wait_list,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] CLEventHandle[] new_event);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clEnqueueSVMMemFill")]
        public static extern ComputeErrorCode EnqueueSVMMemFill(
            CLCommandQueueHandle command_queue,
            CLSVMHandle svm_ptr,
            IntPtr pattern,
            IntPtr pattern_size,
            IntPtr size,
            int num_events_in_wait_list,
            [MarshalAs(UnmanagedType.LPArray)] CLEventHandle[] event_wait_list,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] CLEventHandle[] new_event);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clEnqueueSVMUnmap")]
        public static extern ComputeErrorCode EnqueueSVMUnmap(
            CLCommandQueueHandle command_queue,
            CLSVMHandle svm_ptr,
            int num_events_in_wait_list,
            [MarshalAs(UnmanagedType.LPArray)] CLEventHandle[] event_wait_list,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] CLEventHandle[] new_event);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clGetPipeInfo")]
        public static extern ComputeErrorCode GetPipeInfo(
            CLPipeHandle pipe,
            ComputePipeInfo param_name,
            IntPtr param_value_size,
            IntPtr param_value,
            out IntPtr param_value_size_ret);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clSetKernelArgSVMPointer")]
        public static extern ComputeErrorCode SetKernelArgSVMPointer(
            CLKernelHandle kernel,
            int arg_index,
            CLSVMHandle arg_value);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clSetKernelExecInfo")]
        public static extern ComputeErrorCode SetKernelExecInfo(
            CLKernelHandle kernel,
            ComputeKernelExecutionInfo param_name,
            IntPtr param_value_size,
            IntPtr param_value);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clSVMAlloc")]
        public static extern CLSVMHandle SVMAlloc(
            CLContextHandle context,
            ComputeSVMMemoryFlags flags,
            IntPtr size,
            int alignment);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clSVMFree")]
        public static extern void SVMFree(
            CLContextHandle context,
            CLSVMHandle svm_pointer);

        #region Deprecated functions

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [Obsolete("Deprecated in OpenCL 2.0.")]
        public new static CLCommandQueueHandle CreateCommandQueue(
            CLContextHandle context,
            CLDeviceHandle device,
            ComputeCommandQueueFlags properties,
            out ComputeErrorCode errcode_ret)
        {
            Debug.WriteLine("WARNING! clCreateCommandQueue has been deprecated in OpenCL 2.0.");
            return CL10.CreateCommandQueue(context, device, properties, out errcode_ret);
        }

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [Obsolete("Deprecated in OpenCL 2.0.")]
        public new static CLSamplerHandle CreateSampler(
            CLContextHandle context,
            bool normalized_coords,
            ComputeImageAddressing addressing_mode,
            ComputeImageFiltering filter_mode,
            out ComputeErrorCode errcode_ret)
        {
            Debug.WriteLine("WARNING! clCreateSampler has been deprecated in OpenCL 2.0.");
            return CL10.CreateSampler(context, normalized_coords, addressing_mode, filter_mode, out errcode_ret);
        }

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [Obsolete("Deprecated in OpenCL 2.0.")]
        public new static ComputeErrorCode EnqueueTask(
            CLCommandQueueHandle command_queue,
            CLKernelHandle kernel,
            int num_events_in_wait_list,
            CLEventHandle[] event_wait_list,
            CLEventHandle[] new_event)
        {
            Debug.WriteLine("WARNING! clEnqueueTask has been deprecated in OpenCL 2.0.");
            return CL10.EnqueueTask(command_queue, kernel, num_events_in_wait_list, event_wait_list, new_event);
        }

        #endregion
    }

    /// <summary>
    /// See the OpenCL specification.
    /// </summary>
    public delegate void pfn_free_func(CLCommandQueueHandle queue, int num_svm_pointers, [MarshalAs(UnmanagedType.LPArray)] CLSVMHandle[] svm_pointers, IntPtr user_data);
}
